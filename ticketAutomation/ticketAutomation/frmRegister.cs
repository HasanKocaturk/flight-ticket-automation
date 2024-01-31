using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;
using System.Web;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace ticketAutomation
{
    public partial class frmRegister : Form
    {
        connection conn = new connection();
        SqlConnection sqlconn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        password p1 = new password();
        


        public frmRegister()
        {
            InitializeComponent();
            sqlconn=conn.GetConnection();
            
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            filledCmb fCmb = new filledCmb(cmbRegUGender);
            fCmb.fiilCmb();

        }
        
        private void bntReg_Click(object sender, EventArgs e)
        {
            if (IsFieldValid(@"^.+$", txtbRegUName, lblName, "İsim") &&
                IsFieldValid(@"^.+$", txtbRegUSirname, lblSirname, "Soyisim") &&
                IsFieldValid(@"^([\w]+)@([\w]+)\.([\w]+)$", txtbRegUEmail, lblEmail, "Mail") &&
                IsFieldValid(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]+$", txtbRegPassword, lblPassword, "Şifre") &&
                IsFieldValid(@"^\d+$", txtbRegUNumber, lblNumber, "Numara") &&
                IsFieldValid(@"^\d+$", txtbRegUIdentityNo, lblIdentityNo, "Kimlik"))
            {
               
                if (IsEmailInUse(txtbRegUEmail.Text))
                {
                    MessageBox.Show("Bu e-posta adresi zaten kullanılmaktadır. Lütfen farklı bir tane seçiniz.");
                    return;
                }

                if (IsIdentityNoInUse(txtbRegUIdentityNo.Text))
                {
                    MessageBox.Show("Bu kimlik numarası zaten kullanılmaktadır. Lütfen farklı bir tane seçiniz.");
                    return;
                }

                RegisterUser();
                MessageBox.Show("Kullanıcı başarıyla kaydedildi.");
            }
        }
        private void RegisterUser()
        {
            try
            {
                using (SqlConnection sqlconn = conn.GetConnection())
                {
                    
                    sqlconn.Open();

                    string query = "INSERT INTO users(uName, uSirname, uNumber, uPassword, uEmail, uIdentityNo, uBirthday, uGender, uAuthority) " +
                                    "VALUES (@uName, @uSirname, @uNumber, @uPassword, @uEmail, @uIdentityNo, @uBirthday, @uGender, @uAuthority)";

                    
                    using (SqlCommand cmd = new SqlCommand(query, sqlconn))
                        {
                            cmd.Parameters.AddWithValue("@uName", txtbRegUName.Text);
                            cmd.Parameters.AddWithValue("@uSirname", txtbRegUSirname.Text);
                            cmd.Parameters.AddWithValue("@uNumber", txtbRegUNumber.Text);
                            cmd.Parameters.AddWithValue("@uPassword", p1.GetMD5Hash(txtbRegPassword.Text));
                            cmd.Parameters.AddWithValue("@uEmail", txtbRegUEmail.Text);
                            cmd.Parameters.AddWithValue("@uIdentityNo", txtbRegUIdentityNo.Text);
                            cmd.Parameters.AddWithValue("@uBirthday", dtRegUBirthday.Value);
                            cmd.Parameters.AddWithValue("@uGender", cmbRegUGender.SelectedValue);
                            cmd.Parameters.AddWithValue("@uAuthority", 2);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool IsEmailInUse(string email)
        {

            using (SqlConnection sqlconn = conn.GetConnection())
            {
                sqlconn.Open();
                string query = "SELECT COUNT(*) FROM users WHERE uEmail = @uEmail";
                using (SqlCommand cmd = new SqlCommand(query, sqlconn))
                {
                    cmd.Parameters.AddWithValue("@uEmail", email);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }

        }

        private bool IsIdentityNoInUse(string identityNo)
        {
            using (SqlConnection sqlconn = conn.GetConnection())
            {
                sqlconn.Open();
                string query = "SELECT COUNT(*) FROM users WHERE uIdentityNo = @uIdentityNo";
                using (SqlCommand cmd = new SqlCommand(query, sqlconn))
                {
                    cmd.Parameters.AddWithValue("@uIdentityNo", identityNo);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private bool IsFieldValid(string re, TextBox tb, Label lbl, string s)
        {
            Regex regex = new Regex(re);
            bool isValid = regex.IsMatch(tb.Text);

            if (isValid)
            {
                lbl.ForeColor = Color.Green;
                lbl.Text = s + " Geçerli.";
            }
            else
            {
                lbl.ForeColor = Color.Red;
                lbl.Text = s + " Geçersiz veya hatalı.";
            }

            return isValid;
        }


        private void bntRegFExit_Click_1(object sender, EventArgs e)
        {
            frmLog login = new frmLog();
            login.Show();
            this.Close();

        }
    }
}
