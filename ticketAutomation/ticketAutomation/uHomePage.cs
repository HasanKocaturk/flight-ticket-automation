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
    public partial class uHomePage : Form
    {
        connection conn = new connection();
        SqlConnection sqlconn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
 
        public uHomePage()
        {
            InitializeComponent();
            sqlconn=conn.GetConnection();
        }

        private void uHomePage_Load(object sender, EventArgs e)
        {
            LoadData();
            DataGridViewStyler dtwStyle = new DataGridViewStyler(dataGWFlights);
            dtwStyle.addStyle();
            filledCmb fCmb = new filledCmb(cmbFClass);
            fCmb.fillCmbClass();

        }
        private void LoadData()
        {

            using (SqlConnection sqlconn = conn.GetConnection())
            {

                string query = "SELECT * FROM flights";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlconn))
                {

                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    

                    dataGWFlights.DataSource = dataTable;
                }
            }
        }

        private void btnUHPExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUHPBuy_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlconn = conn.GetConnection())
                {
                    sqlconn.Open();


                    DataGridViewRow selectedRow = dataGWFlights.SelectedRows[0];
                    
                    int flightNo = Convert.ToInt32(selectedRow.Cells["flightNo"].Value);



                    string addQuery = "INSERT INTO fTickets (uID, flightNo, class, sitaution) VALUES (@uID, @flightNo, @class, @sitaution)";
                   
                    using (cmd = new SqlCommand(addQuery, sqlconn))
                    {
                        cmd.Parameters.AddWithValue("@uID", UserManager.LoggedInUserId);
                        cmd.Parameters.AddWithValue("@flightNo", flightNo);
                        cmd.Parameters.AddWithValue("@class", cmbFClass.SelectedValue);
                        cmd.Parameters.AddWithValue("@sitaution", 2);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void lblUserReceive_Click(object sender, EventArgs e)
        {
            usersReceive uR = new usersReceive();
            uR.Show();
        }
    }
}
