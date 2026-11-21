using MySql.Data.MySqlClient;
using PISVezba.Data;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace PISVezba.Forms
{
    public partial class FrmSobe : Form
    {
        private bool _spremno = false;       // da filteri ne rade dok se forma učitava
        private bool _ucitavanje = false;    // da tabela ne puni polja dok se sama osvežava
        private int _izabranId = 0;          // soba izabrana u tabeli (0 = nijedna)

        public FrmSobe()
        {
            InitializeComponent();

            // Događaji su povezani ovde, pa ih ne povezuješ u dizajneru
            this.Load += FrmSobe_Load;
            btnPretrazi.Click += btnPretrazi_Click;
            btnPonisti.Click += btnPonisti_Click;
            btnDodaj.Click += btnDodaj_Click;
            btnIzmeni.Click += btnIzmeni_Click;
            btnObrisi.Click += btnObrisi_Click;
            btnOcisti.Click += btnOcisti_Click;
            txtPretraga.KeyDown += txtPretraga_KeyDown;
            cmbTip.SelectedIndexChanged += Filter_Promenjen;
            cmbStatus.SelectedIndexChanged += Filter_Promenjen;
            dgvSobe.SelectionChanged += dgvSobe_SelectionChanged;
        }

        private void FrmSobe_Load(object sender, EventArgs e)
        {
            cmbTip.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
            cmbTipUnos.SelectedIndex = 0;
            cmbStatusUnos.SelectedIndex = 0;
            UcitajSobe();
            _spremno = true;
        }

        // ---------- Učitavanje, pretraga i filteri ----------

        private void UcitajSobe()
        {
            string upit = "SELECT soba_id, broj_sobe, tip_sobe, cena_po_noci, `status` FROM soba WHERE 1 = 1";
            string broj = txtPretraga.Text.Trim();

            if (broj != "")
                upit += " AND CAST(broj_sobe AS CHAR) LIKE @broj";
            if (cmbTip.SelectedIndex > 0)
                upit += " AND tip_sobe = @tip";
            if (cmbStatus.SelectedIndex > 0)
                upit += " AND `status` = @status";
            upit += " ORDER BY broj_sobe";

            _ucitavanje = true;
            try
            {
                using (MySqlConnection conn = Konekcija.GetConnection())
                using (MySqlCommand cmd = new MySqlCommand(upit, conn))
                {
                    if (broj != "")
                        cmd.Parameters.AddWithValue("@broj", "%" + broj + "%");
                    if (cmbTip.SelectedIndex > 0)
                        cmd.Parameters.AddWithValue("@tip", cmbTip.Text);
                    if (cmbStatus.SelectedIndex > 0)
                        cmd.Parameters.AddWithValue("@status", cmbStatus.Text);

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvSobe.DataSource = dt;
                    }
                }
                PodesiKolone();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom učitavanja soba: " + ex.Message, "Greška baze",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _ucitavanje = false;
            }

            OcistiPolja();
        }

        private void PodesiKolone()
        {
            if (dgvSobe.Columns.Count == 0) return;

            dgvSobe.Columns["soba_id"].Visible = false;
            dgvSobe.Columns["broj_sobe"].HeaderText = "Broj sobe";
            dgvSobe.Columns["tip_sobe"].HeaderText = "Tip sobe";
            dgvSobe.Columns["cena_po_noci"].HeaderText = "Cena po noći";
            dgvSobe.Columns["cena_po_noci"].DefaultCellStyle.Format = "N2";
            dgvSobe.Columns["status"].HeaderText = "Status";
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            UcitajSobe();
        }

        private void txtPretraga_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                UcitajSobe();
            }
        }

        // Filtriranje čim se promeni izbor u ComboBox-u
        private void Filter_Promenjen(object sender, EventArgs e)
        {
            if (_spremno)
                UcitajSobe();
        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            _spremno = false;
            txtPretraga.Clear();
            cmbTip.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
            _spremno = true;
            UcitajSobe();
        }

        // ---------- Polja za unos ----------

        // Klik na red u tabeli puni polja podacima izabrane sobe
        private void dgvSobe_SelectionChanged(object sender, EventArgs e)
        {
            if (_ucitavanje) return;
            if (dgvSobe.CurrentRow == null || dgvSobe.SelectedRows.Count == 0) return;

            DataGridViewRow red = dgvSobe.CurrentRow;

            _izabranId = Convert.ToInt32(red.Cells["soba_id"].Value);
            txtBroj.Text = red.Cells["broj_sobe"].Value.ToString();
            txtCena.Text = Convert.ToDecimal(red.Cells["cena_po_noci"].Value)
                                  .ToString("0.00", CultureInfo.InvariantCulture);
            IzaberiStavku(cmbTipUnos, red.Cells["tip_sobe"].Value.ToString());
            IzaberiStavku(cmbStatusUnos, red.Cells["status"].Value.ToString());
        }

        // Bira stavku u ComboBox-u; ako je nema u listi, dodaje je
        private void IzaberiStavku(ComboBox cmb, string vrednost)
        {
            int index = cmb.Items.IndexOf(vrednost);
            if (index < 0)
            {
                cmb.Items.Add(vrednost);
                index = cmb.Items.Count - 1;
            }
            cmb.SelectedIndex = index;
        }

        private void OcistiPolja()
        {
            _ucitavanje = true;
            dgvSobe.ClearSelection();
            if (dgvSobe.Rows.Count > 0)
                dgvSobe.CurrentCell = null;
            _ucitavanje = false;

            _izabranId = 0;
            txtBroj.Clear();
            txtCena.Clear();
            cmbTipUnos.SelectedIndex = 0;
            cmbStatusUnos.SelectedIndex = 0;
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            OcistiPolja();
            txtBroj.Focus();
        }

        // ---------- Dodavanje, izmena, brisanje ----------

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Sacuvaj(0);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (_izabranId == 0)
            {
                Upozorenje("Izaberite sobu iz tabele koju želite da izmenite.");
                return;
            }
            Sacuvaj(_izabranId);
        }

        // id = 0 dodaje novu sobu, id veći od 0 menja postojeću
        private void Sacuvaj(int id)
        {
            int brojSobe;
            decimal cena;

            if (!int.TryParse(txtBroj.Text.Trim(), out brojSobe) || brojSobe <= 0)
            {
                Upozorenje("Broj sobe mora biti ceo broj veći od 0.");
                txtBroj.Focus();
                return;
            }

            // Prihvata i zarez i tačku kao decimalni separator
            string cenaTekst = txtCena.Text.Trim().Replace(',', '.');
            if (!decimal.TryParse(cenaTekst, NumberStyles.Number, CultureInfo.InvariantCulture, out cena) || cena <= 0)
            {
                Upozorenje("Cena po noći mora biti broj veći od 0.");
                txtCena.Focus();
                return;
            }

            try
            {
                using (MySqlConnection conn = Konekcija.GetConnection())
                {
                    conn.Open();

                    // Broj sobe mora biti jedinstven (kod izmene se ne računa ista soba)
                    const string proveraUpit =
                        "SELECT COUNT(1) FROM soba WHERE broj_sobe = @broj AND soba_id <> @id";
                    using (MySqlCommand provera = new MySqlCommand(proveraUpit, conn))
                    {
                        provera.Parameters.AddWithValue("@broj", brojSobe);
                        provera.Parameters.AddWithValue("@id", id);

                        if (Convert.ToInt32(provera.ExecuteScalar()) > 0)
                        {
                            Upozorenje("Soba sa tim brojem već postoji.");
                            txtBroj.Focus();
                            return;
                        }
                    }

                    string upit = id == 0
                        ? "INSERT INTO soba (broj_sobe, tip_sobe, cena_po_noci, `status`) " +
                          "VALUES (@broj, @tip, @cena, @status)"
                        : "UPDATE soba SET broj_sobe = @broj, tip_sobe = @tip, " +
                          "cena_po_noci = @cena, `status` = @status WHERE soba_id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(upit, conn))
                    {
                        cmd.Parameters.AddWithValue("@broj", brojSobe);
                        cmd.Parameters.AddWithValue("@tip", cmbTipUnos.Text);
                        cmd.Parameters.AddWithValue("@cena", cena);
                        cmd.Parameters.AddWithValue("@status", cmbStatusUnos.Text);
                        if (id > 0)
                            cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                    }
                }

                UcitajSobe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom čuvanja: " + ex.Message, "Greška baze",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (_izabranId == 0)
            {
                Upozorenje("Izaberite sobu iz tabele koju želite da obrišete.");
                return;
            }

            DialogResult odgovor = MessageBox.Show(
                "Da li sigurno želite da obrišete sobu " + txtBroj.Text + "?\n\n" +
                "Brisanjem sobe brišu se i sve njene rezervacije (sa plaćanjima i recenzijama).",
                "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (odgovor != DialogResult.Yes)
                return;

            try
            {
                using (MySqlConnection conn = Konekcija.GetConnection())
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM soba WHERE soba_id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", _izabranId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                UcitajSobe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom brisanja: " + ex.Message, "Greška baze",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Upozorenje(string poruka)
        {
            MessageBox.Show(poruka, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
