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

namespace ticketAutomation
{
    
    public partial class usersReceive : Form
    {
        connection conn = new connection();
        SqlConnection sqlconn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        
        public usersReceive()
        {
            InitializeComponent();
            sqlconn = conn.GetConnection();
        }

        private void usersReceive_Load(object sender, EventArgs e)
        {
            LoadData();
            DataGridViewStyler dtwStyle = new DataGridViewStyler(dataUsersReceive);
            dtwStyle.addStyle();
        }
        private void LoadData()
        {
            using (SqlConnection sqlconn = conn.GetConnection())
            {
                string query = "SELECT * FROM fTickets";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlconn))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    string filterExpression = $"uID = {UserManager.LoggedInUserId}";

                 
                    DataRow[] foundRows = dataTable.Select(filterExpression);

                    if (foundRows.Length > 0)
                    {
                        DataTable filteredTable = foundRows.CopyToDataTable();
                        dataUsersReceive.DataSource = filteredTable;
                    }
                    else
                    {
                        
                        dataUsersReceive.DataSource = null;
                        MessageBox.Show("Eşleşen veri bulunamadı.");
                    }
                }
            }
        }
        
        private void btnURCancel_Click(object sender, EventArgs e)
        {
            if (dataUsersReceive.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataUsersReceive.SelectedRows[0];
                string id = selectedRow.Cells["id"].Value.ToString();

                using (SqlConnection sqlconn = conn.GetConnection())
                {
                    sqlconn.Open();

                    string currentSituationQuery = "SELECT sitaution FROM fTickets WHERE id = @id";
                    using (SqlCommand currentSituationCmd = new SqlCommand(currentSituationQuery, sqlconn))
                    {
                        currentSituationCmd.Parameters.AddWithValue("@id", id);
                        int currentSituation = Convert.ToInt32(currentSituationCmd.ExecuteScalar());

                        int newSituation = (currentSituation == 1) ? 2 : 1;

                        string updateQuery = "UPDATE fTickets SET sitaution = @NewSituation WHERE id = @id";

                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, sqlconn))
                        {
                            updateCmd.Parameters.AddWithValue("@NewSituation", newSituation);
                            updateCmd.Parameters.AddWithValue("@id", id);

                            updateCmd.ExecuteNonQuery();
                        }

                        LoadData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek bir uçuş seçin.");
            }
        }

        private void picBBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
