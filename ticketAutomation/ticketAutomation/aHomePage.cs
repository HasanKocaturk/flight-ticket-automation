using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticketAutomation
{
    public partial class aHomePage : Form
    {
        connection conn = new connection();
        SqlConnection sqlconn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public aHomePage()
        {
            InitializeComponent();
            sqlconn = conn.GetConnection();
        }

        private void aHomePage_Load(object sender, EventArgs e)
        {
            filledCmb fillCmb = new filledCmb(cmbCFrom);
            filledCmb fCmb = new filledCmb(cmbCTo);
            fillCmb.fillCmbCity();
            fCmb.fillCmbCity();
            LoadData();
            DataGridViewStyler dtwStyle = new DataGridViewStyler(dataGWFlights);
            dtwStyle.addStyle();
        }

        private void btnFAdd_Click(object sender, EventArgs e)
        {
            flightAdd();
        }

        private void flightAdd()
        {
            try
            {
                using (SqlConnection sqlconn = conn.GetConnection())
                {
                    sqlconn.Open();
                    string query = "INSERT INTO flights (flightNo,cFrom,cTo,fDate,price,sitaution) VALUES (@flightNo,@cFrom,@cTo,@fDate,@price,@sitaution)";

                    using (cmd = new SqlCommand(query, sqlconn))
                    {
                        cmd.Parameters.AddWithValue("@flightNo",txtbFlightNo.Text);
                        cmd.Parameters.AddWithValue("@cFrom",cmbCFrom.SelectedValue);
                        cmd.Parameters.AddWithValue("@cTo",cmbCTo.SelectedValue);
                        cmd.Parameters.AddWithValue("@fDate",dtpFDate.Value);
                        cmd.Parameters.AddWithValue("@price",txtbPrice.Text);
                        cmd.Parameters.AddWithValue("@sitaution",2);

                        cmd.ExecuteNonQuery();
                    }
                    LoadData();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dataGWFlights.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGWFlights.SelectedRows[0];

                string flightNo = selectedRow.Cells["flightNo"].Value.ToString();

                using (SqlConnection sqlconn = conn.GetConnection())
                {
                    sqlconn.Open();

                   
                    string currentSituationQuery = "SELECT sitaution FROM flights WHERE flightNo = @FlightNo";
                    using (SqlCommand currentSituationCmd = new SqlCommand(currentSituationQuery, sqlconn))
                    {
                        currentSituationCmd.Parameters.AddWithValue("@FlightNo", flightNo);
                        int currentSituation = Convert.ToInt32(currentSituationCmd.ExecuteScalar());

                       
                        int newSituation = (currentSituation == 1) ? 2 : 1;

                        string updateQuery = "UPDATE flights SET sitaution = @NewSituation WHERE flightNo = @FlightNo";

                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, sqlconn))
                        {
                            updateCmd.Parameters.AddWithValue("@NewSituation", newSituation);
                            updateCmd.Parameters.AddWithValue("@FlightNo", flightNo);

                            updateCmd.ExecuteNonQuery();
                        }

                        LoadData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek bir uçuş seçin.");
            }if (dataGWFlights.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGWFlights.SelectedRows[0];

                string flightNo = selectedRow.Cells["flightNo"].Value.ToString();

                using (SqlConnection sqlconn = conn.GetConnection())
                {
                    sqlconn.Open();

                   
                    string currentSituationQuery = "SELECT sitaution FROM flights WHERE flightNo = @FlightNo";
                    using (SqlCommand currentSituationCmd = new SqlCommand(currentSituationQuery, sqlconn))
                    {
                        currentSituationCmd.Parameters.AddWithValue("@FlightNo", flightNo);
                        int currentSituation = Convert.ToInt32(currentSituationCmd.ExecuteScalar());

                       
                        int newSituation = (currentSituation == 1) ? 2 : 1;

                        string updateQuery = "UPDATE flights SET sitaution = @NewSituation WHERE flightNo = @FlightNo";

                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, sqlconn))
                        {
                            updateCmd.Parameters.AddWithValue("@NewSituation", newSituation);
                            updateCmd.Parameters.AddWithValue("@FlightNo", flightNo);

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

        private void btnUHPExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
