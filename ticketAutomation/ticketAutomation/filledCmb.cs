using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace ticketAutomation
{
    internal class filledCmb : Component
    {
        connection conn = new connection();
        private ComboBox cmbType;

        public filledCmb(ComboBox cmbType)
        {
            this.cmbType = cmbType;
        }
        public void fiilCmb()
        {

            using (SqlConnection sqlConn = conn.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT id,gender FROM genders", sqlConn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbType.DataSource = dt;
                cmbType.DisplayMember = "gender";
                cmbType.ValueMember = "id";

            }
        }
        public void fillCmbCity()
        {
            using (SqlConnection sqlCon = conn.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT id,city FROM cities", sqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbType.DataSource = dt;
                cmbType.DisplayMember = "city";
                cmbType.ValueMember = "id";
            }
        }
        public void fillCmbClass()
        {
            using (SqlConnection sqlCon = conn.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT id,class FROM classes", sqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbType.DataSource = dt;
                cmbType.DisplayMember = "class";
                cmbType.ValueMember = "id";
            }
        }

    }
}
