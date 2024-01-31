using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ticketAutomation
{
    internal class connection
    {
        
        public SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=KOCATURK;Initial Catalog=dbTicketAutomation;Integrated Security=True";
            return conn;
        }
    }
}
