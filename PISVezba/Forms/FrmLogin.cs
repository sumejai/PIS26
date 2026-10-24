using PISVezba.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=hotel;Trusted_Connection=True;";
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Osnovna validacija unosa
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Molimo unesite korisničko ime i lozinku.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // SQL upit za MySQL
            string query = "SELECT COUNT(1) FROM korisnik WHERE korisnicko_ime = @korisnicko_ime AND lozinka = @lozinka";

            try
            {
                // Uzimamo konekciju preko naše Konekcija klase
                using (MySqlConnection conn = Konekcija.GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Dodavanje parametara za bezbednost (sprečava SQL Injection)
                        cmd.Parameters.AddWithValue("@korisnicko_ime", username);
                        cmd.Parameters.AddWithValue("@lozinka", password);

                        conn.Open();

                        // ExecuteScalar vraća broj redova koji ispunjavaju uslov (0 ili 1)
                        int userExists = Convert.ToInt32(cmd.ExecuteScalar());

                        if (userExists == 1)
                        {
                            MessageBox.Show("Uspešno prijavljivanje!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Otvaranje glavne forme
                            FrmMain frmMain = new FrmMain();
                            frmMain.Show();

                            // Sakrivanje login forme
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Pogrešno korisničko ime ili lozinka.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPassword.Clear();
                            txtUsername.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom povezivanja sa bazom: " + ex.Message, "Greška baze", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
