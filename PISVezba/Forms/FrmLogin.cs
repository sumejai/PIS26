using PISVezba.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; 
using PISVezba.Data;

namespace PISVezba
{
    public partial class FrmLogin : Form
    {
       
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string korisnickoIme = txtUsername.Text.Trim();
            string lozinka = txtPassword.Text;

            if (string.IsNullOrEmpty(korisnickoIme) || string.IsNullOrEmpty(lozinka))
            {
                MessageBox.Show("Unesite korisničko ime i lozinku.", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            const string upit =
                "SELECT korisnik_id, rola FROM korisnik " +
                "WHERE korisnicko_ime = @ime AND lozinka = @lozinka";

            try
            {
                using (MySqlConnection conn = Konekcija.GetConnection())
                using (MySqlCommand cmd = new MySqlCommand(upit, conn))
                {
                    cmd.Parameters.AddWithValue("@ime", korisnickoIme);
                    cmd.Parameters.AddWithValue("@lozinka", lozinka);

                    conn.Open();
                    using (MySqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            Sesija.KorisnikId = Convert.ToInt32(r["korisnik_id"]);
                            Sesija.KorisnickoIme = korisnickoIme;
                            Sesija.Rola = r["rola"].ToString();

                            FrmMain frmMain = new FrmMain();
                            frmMain.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Pogrešno korisničko ime ili lozinka.", "Greška",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPassword.Clear();
                            txtUsername.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom povezivanja sa bazom: " + ex.Message,
                    "Greška baze", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegister frmRegister = new FrmRegister();
            frmRegister.Show();
            this.Hide();
        }
    }
}
