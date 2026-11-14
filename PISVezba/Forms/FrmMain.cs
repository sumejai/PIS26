using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PISVezba.Forms
{
    public partial class FrmMain : Form
    {
        private bool _odjava = false;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblKorisnik.Text = "Prijavljeni korisnik: " + Sesija.KorisnickoIme + " (" + Sesija.Rola + ")";
            lblDobrodosli.Text = "Dobrodošli, " + Sesija.KorisnickoIme;

            // Dugmad za sobe i goste vidi samo administrator
            btnSobe.Visible = Sesija.JeAdmin;
            btnGosti.Visible = Sesija.JeAdmin;

            Aktiviraj(btnPocetna, "Početna");
        }
        private void Aktiviraj(Button aktivno, string naslov)
        {
            foreach (Control c in pnlMeni.Controls)
            {
                if (c is Button b && b != btnOdjava)
                    b.BackColor = Color.MidnightBlue;
            }
            aktivno.BackColor = Color.SteelBlue;
            lblNaslovStrane.Text = naslov;
        }
        private void OtvoriFormu(Form forma)
        {
            OcistiSadrzaj();
            forma.TopLevel = false;
            forma.FormBorderStyle = FormBorderStyle.None;
            forma.Dock = DockStyle.Fill;
            pnlSadrzaj.Controls.Add(forma);
            forma.Show();
        }
        private void OcistiSadrzaj()
        {
            foreach (Form f in pnlSadrzaj.Controls.OfType<Form>().ToList())
                f.Dispose();
            pnlSadrzaj.Controls.Clear();
        }
        private void PrikaziPocetnu()
        {
            OcistiSadrzaj();
            pnlSadrzaj.Controls.Add(lblDobrodosli);
            pnlSadrzaj.Controls.Add(lblUputstvo);
        }
        private void btnPocetna_Click(object sender, EventArgs e)
        {
            Aktiviraj(btnPocetna, "Početna");
            PrikaziPocetnu();
        }

        private void btnRezervacije_Click(object sender, EventArgs e)
        {
            Aktiviraj(btnRezervacije, "Rezervacije");
        }

        private void btnSobe_Click(object sender, EventArgs e)
        {
            Aktiviraj(btnSobe, "Sobe");
        }

        private void btnGosti_Click(object sender, EventArgs e)
        {
            Aktiviraj(btnGosti, "Gosti");
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            _odjava = true;
            Sesija.KorisnikId = 0;
            Sesija.KorisnickoIme = null;
            Sesija.Rola = null;

            Form login = Application.OpenForms.Cast<Form>().FirstOrDefault(f => f is FrmLogin);
            if (login == null)
                login = new FrmLogin();
            login.Show();

            this.Close();
        }
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_odjava)
                Application.Exit();
        }

        private void lblNaslovStrane_Click(object sender, EventArgs e)
        {

        }

        private void lblKorisnik_Click(object sender, EventArgs e)
        {

        }
    }
}
