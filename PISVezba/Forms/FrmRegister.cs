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

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Osnovna validacija unosa
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Molimo popunite sva polja.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = Konekcija.GetConnection())
                {
                    conn.Open();

                    // 1. Provera da li korisničko ime već postoji u bazi
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

                    // 2. Unos novog korisnika u bazu
                    string insertQuery = "INSERT INTO korisnik (korisnicko_ime, lozinka) VALUES (@korisnicko_ime, @lozinka)";
                    using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@korisnicko_ime", username);
                        insertCmd.Parameters.AddWithValue("@lozinka", password); // Napomena: U ozbiljnim aplikacijama lozinka se hešira!

                        insertCmd.ExecuteNonQuery();

                        MessageBox.Show("Uspešna registracija! Možete se prijaviti.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Vraćanje na login formu
                        FrmLogin frmLogin = new FrmLogin();
                        frmLogin.Show();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom registracije: " + ex.Message, "Greška baze", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Close();
        }
    }
}
