using MySql.Data.MySqlClient;
using PISVezba.Data;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PISVezba.Forms
{
    public partial class FrmGosti : Form
    {
        private bool _ucitavanje = false;    // da tabela ne puni polja dok se sama osvežava
        private int _izabranId = 0;         

        public FrmGosti()
        {
            InitializeComponent();

            
            this.Load += FrmGosti_Load;
            btnPretrazi.Click += btnPretrazi_Click;
            btnPonisti.Click += btnPonisti_Click;
            btnDodaj.Click += btnDodaj_Click;
            btnIzmeni.Click += btnIzmeni_Click;
            btnObrisi.Click += btnObrisi_Click;
            btnOcisti.Click += btnOcisti_Click;
            txtPretraga.KeyDown += Pretraga_KeyDown;
            txtPretragaKarta.KeyDown += Pretraga_KeyDown;
            dgvGosti.SelectionChanged += dgvGosti_SelectionChanged;
        }

        private void FrmGosti_Load(object sender, EventArgs e)
        {
            UcitajGoste();
        }


        private void UcitajGoste()
        {
            string upit =
                "SELECT gost_id, ime, prezime, broj_licne_karte, broj_telefona FROM gost WHERE 1 = 1";

            string tekst = txtPretraga.Text.Trim();
            string karta = txtPretragaKarta.Text.Trim();

            
            if (tekst != "")
                upit += " AND (ime LIKE @tekst OR prezime LIKE @tekst " +
                        "OR CONCAT(ime, ' ', prezime) LIKE @tekst " +
                        "OR CONCAT(prezime, ' ', ime) LIKE @tekst)";
            if (karta != "")
                upit += " AND broj_licne_karte LIKE @karta";
            upit += " ORDER BY prezime, ime";

            _ucitavanje = true;
            try
            {
                using (MySqlConnection conn = Konekcija.GetConnection())
                using (MySqlCommand cmd = new MySqlCommand(upit, conn))
                {
                    if (tekst != "")
                        cmd.Parameters.AddWithValue("@tekst", "%" + tekst + "%");
                    if (karta != "")
                        cmd.Parameters.AddWithValue("@karta", "%" + karta + "%");

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvGosti.DataSource = dt;
                    }
                }
                PodesiKolone();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom učitavanja gostiju: " + ex.Message, "Greška baze",
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
            if (dgvGosti.Columns.Count == 0) return;

            dgvGosti.Columns["gost_id"].Visible = false;
            dgvGosti.Columns["ime"].HeaderText = "Ime";
            dgvGosti.Columns["prezime"].HeaderText = "Prezime";
            dgvGosti.Columns["broj_licne_karte"].HeaderText = "Broj lične karte";
            dgvGosti.Columns["broj_telefona"].HeaderText = "Broj telefona";
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            UcitajGoste();
        }

        private void Pretraga_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                UcitajGoste();
            }
        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            txtPretraga.Clear();
            txtPretragaKarta.Clear();
            UcitajGoste();
        }

       
        private void dgvGosti_SelectionChanged(object sender, EventArgs e)
        {
            if (_ucitavanje) return;
            if (dgvGosti.CurrentRow == null || dgvGosti.SelectedRows.Count == 0) return;

            DataGridViewRow red = dgvGosti.CurrentRow;

            _izabranId = Convert.ToInt32(red.Cells["gost_id"].Value);
            txtIme.Text = red.Cells["ime"].Value.ToString();
            txtPrezime.Text = red.Cells["prezime"].Value.ToString();
            txtBrojKarte.Text = red.Cells["broj_licne_karte"].Value.ToString();
            txtTelefon.Text = red.Cells["broj_telefona"].Value.ToString();
        }

        private void OcistiPolja()
        {
            _ucitavanje = true;
            dgvGosti.ClearSelection();
            if (dgvGosti.Rows.Count > 0)
                dgvGosti.CurrentCell = null;
            _ucitavanje = false;

            _izabranId = 0;
            txtIme.Clear();
            txtPrezime.Clear();
            txtBrojKarte.Clear();
            txtTelefon.Clear();
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            OcistiPolja();
            txtIme.Focus();
        }

        

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Sacuvaj(0);
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (_izabranId == 0)
            {
                Upozorenje("Izaberite gosta iz tabele kojeg želite da izmenite.");
                return;
            }
            Sacuvaj(_izabranId);
        }

        // id = 0 dodaje novog gosta, id veći od 0 menja postojećeg
        private void Sacuvaj(int id)
        {
            string ime = txtIme.Text.Trim();
            string prezime = txtPrezime.Text.Trim();
            string karta = txtBrojKarte.Text.Trim();
            string telefon = txtTelefon.Text.Trim();

            if (ime == "")
            {
                Upozorenje("Ime ne može biti prazno.");
                txtIme.Focus();
                return;
            }
            if (prezime == "")
            {
                Upozorenje("Prezime ne može biti prazno.");
                txtPrezime.Focus();
                return;
            }
            if (karta == "")
            {
                Upozorenje("Unesite broj lične karte.");
                txtBrojKarte.Focus();
                return;
            }
            if (telefon == "" || !Regex.IsMatch(telefon, @"^[0-9+\-/() ]+$"))
            {
                Upozorenje("Unesite ispravan broj telefona (cifre, a dozvoljeni su i + - / ( ) i razmak).");
                txtTelefon.Focus();
                return;
            }

            try
            {
                using (MySqlConnection conn = Konekcija.GetConnection())
                {
                    conn.Open();

                    // Broj lične karte mora biti jedinstven (kod izmene se ne računa isti gost)
                    const string proveraUpit =
                        "SELECT COUNT(1) FROM gost WHERE broj_licne_karte = @karta AND gost_id <> @id";
                    using (MySqlCommand provera = new MySqlCommand(proveraUpit, conn))
                    {
                        provera.Parameters.AddWithValue("@karta", karta);
                        provera.Parameters.AddWithValue("@id", id);

                        if (Convert.ToInt32(provera.ExecuteScalar()) > 0)
                        {
                            Upozorenje("Gost sa tim brojem lične karte već postoji.");
                            txtBrojKarte.Focus();
                            return;
                        }
                    }

                    string upit = id == 0
                        ? "INSERT INTO gost (ime, prezime, broj_licne_karte, broj_telefona) " +
                          "VALUES (@ime, @prezime, @karta, @telefon)"
                        : "UPDATE gost SET ime = @ime, prezime = @prezime, " +
                          "broj_licne_karte = @karta, broj_telefona = @telefon WHERE gost_id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(upit, conn))
                    {
                        cmd.Parameters.AddWithValue("@ime", ime);
                        cmd.Parameters.AddWithValue("@prezime", prezime);
                        cmd.Parameters.AddWithValue("@karta", karta);
                        cmd.Parameters.AddWithValue("@telefon", telefon);
                        if (id > 0)
                            cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                    }
                }

                UcitajGoste();
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
                Upozorenje("Izaberite gosta iz tabele kojeg želite da obrišete.");
                return;
            }

            DialogResult odgovor = MessageBox.Show(
                "Da li sigurno želite da obrišete gosta " + txtIme.Text + " " + txtPrezime.Text + "?\n\n" +
                "Brisanjem gosta brišu se i sve njegove rezervacije, plaćanja i recenzije.",
                "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (odgovor != DialogResult.Yes)
                return;

            try
            {
                using (MySqlConnection conn = Konekcija.GetConnection())
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM gost WHERE gost_id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", _izabranId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                UcitajGoste();
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