using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.Utility
{
   public static class DataGridViewStyle
    {
       public static void ChangeDataGridViewColor(this DataGridView dataGridView, Color headerColor , Color AlternatingRowsColor)
        {
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = headerColor;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(137, 136, 138);
            dataGridView.RowHeadersVisible = false;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = AlternatingRowsColor;
            dataGridView.EnableHeadersVisualStyles = false;
        }
    }
}
