using System;
using System.Text;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ticketAutomation
{
    public partial class frmLog : Form
    {
        connection conn = new connection();
        SqlConnection sqlconn = new SqlConnection();
        



        public frmLog()
        {
            InitializeComponent();
            sqlconn = conn.GetConnection();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister reg = new frmRegister();
            reg.Show();
            this.Hide();
        }

        private void btnAppExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtbUName.Text;
            string password = GetMD5Hash(txtbUPassword.Text);

            string query = "SELECT id, uEmail, uPassword, uAuthority FROM users WHERE uEmail = @Email";

            using (SqlCommand cmd = new SqlCommand(query, sqlconn))
            {
                cmd.Parameters.AddWithValue("@Email", email);

                sqlconn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    
                    string storedEmail = reader["uEmail"].ToString();
                    string storedPasswordHash = reader["uPassword"].ToString();
                    string authority = reader["uAuthority"].ToString();

                    if (CheckPassword(txtbUPassword.Text, storedPasswordHash))
                    {
                        MessageBox.Show("Giriş başarılı!");


                        int loggedInUserId = Convert.ToInt32(reader["id"]);
                        UserManager.SetLoggedInUserId(loggedInUserId);


                        if (authority == "1")
                        {
                            aHomePage aHomeP = new aHomePage();
                            aHomeP.Show();
                            this.Hide();
                        }
                        else if (authority == "2")
                        {
                            uHomePage uHomeP = new uHomePage();
                            uHomeP.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz e-posta veya şifre. Lütfen tekrar deneyin.");
                    }
                }
                else
                {
                    MessageBox.Show("Geçersiz e-posta. Lütfen tekrar deneyin.");
                }

                sqlconn.Close();
                reader.Close();
            }
        }

        private bool CheckPassword(string userInput, string storedHash)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(userInput);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }

                string userInputHash = sb.ToString();

                return string.Equals(userInputHash, storedHash, StringComparison.OrdinalIgnoreCase);
            }
        }

        private string GetMD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }

                return sb.ToString();
            }
        }

        private void frmLog_Load(object sender, EventArgs e)
        {
            txtbUPassword.UseSystemPasswordChar = true;
        }
    }
}
