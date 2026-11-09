using MySql.Data.MySqlClient;
using PISVezba.Data;
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
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            cmbRola.SelectedIndex = 0;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
        private void PrikaziLogin()
        {
            Form login = Application.OpenForms.Cast<Form>().FirstOrDefault(f => f is FrmLogin);

            if (login == null)
                login = new FrmLogin();

            login.Show();
            login.BringToFront();
            login.Activate();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string password2 = txtPassword2.Text;
            string rola = cmbRola.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(password2))
            {
                MessageBox.Show("Molimo popunite sva polja.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != password2)
            {
                MessageBox.Show("Lozinke se ne poklapaju.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword2.Clear();
                txtPassword2.Focus();
                return;
            }

            try
            {
                using (MySqlConnection conn = Konekcija.GetConnection())
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(1) FROM korisnik WHERE korisnicko_ime = @korisnicko_ime";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@korisnicko_ime", username);
                        int userExists = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (userExists > 0)
                        {
                            MessageBox.Show("Korisničko ime već postoji. Izaberite drugo.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUsername.Focus();
                            return;
                        }
                    }

                    string insertQuery = "INSERT INTO korisnik (korisnicko_ime, lozinka, rola) VALUES (@korisnicko_ime, @lozinka, @rola)";
                    using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@korisnicko_ime", username);
                        insertCmd.Parameters.AddWithValue("@lozinka", password);
                        insertCmd.Parameters.AddWithValue("@rola", rola);
                        insertCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Uspešna registracija! Možete se prijaviti.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PrikaziLogin();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom registracije: " + ex.Message, "Greška baze", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PrikaziLogin();
            this.Close();

        }

        private void lblNaslov_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            PrikaziLogin();
        }
    }
}
