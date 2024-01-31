using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticketAutomation
{
    internal class DataGridViewStyler
    {
        private DataGridView dataGWFlights;

        
        public DataGridViewStyler(DataGridView dataGridView)
        {
            dataGWFlights = dataGridView;
        }

        public void addStyle()
        {
            CustomizeDataGridViewHeaderStyle();
            CustomizeDataGridViewStyle();
        }

        public void CustomizeDataGridViewStyle()
        {
            if (dataGWFlights != null)
            {
                dataGWFlights.DefaultCellStyle.BackColor = Color.AntiqueWhite;
                dataGWFlights.DefaultCellStyle.ForeColor = Color.Black;
                dataGWFlights.DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
                dataGWFlights.DefaultCellStyle.SelectionForeColor = Color.White;
            }
        }

        public void CustomizeDataGridViewHeaderStyle()
        {
            if (dataGWFlights != null)
            {
                dataGWFlights.EnableHeadersVisualStyles = false;

                foreach (DataGridViewColumn column in dataGWFlights.Columns)
                {
                    column.HeaderCell.Style.BackColor = Color.Red;
                    column.HeaderCell.Style.ForeColor = Color.White;
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    column.HeaderCell.Style.SelectionBackColor = Color.Transparent;
                }
            }
        }

    }
}
