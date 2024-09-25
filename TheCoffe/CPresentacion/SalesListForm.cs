using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheCoffe.CPresentacion
{
    public partial class SalesListForm : UserControl
    {
        public SalesListForm()
        {
            InitializeComponent();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }

        private void SalesListForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                int rowIndex = dataSales.Rows.Add();
                DataGridViewRow row = dataSales.Rows[rowIndex];
                row.Cells[0].Value = 1;
                row.Cells[1].Value = "Emilia";
                row.Cells[2].Value = "2024-06-14";
                row.Cells[3].Value = "20:10:05";
                row.Cells[4].Value = "30,000";
            }
        }

        private void dataSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataSales.Columns[e.ColumnIndex].Name == "detalle")
            {
                Form parentForm = this.FindForm();
            using (App.OverlayForm overlay = new App.OverlayForm())
            {
                overlay.Size = parentForm.ClientSize;
                overlay.Location = parentForm.PointToScreen(Point.Empty);
                overlay.Owner = parentForm;

                overlay.Show();
                using (SaleDetailListForm modal = new SaleDetailListForm())
                {
                    modal.ShowDialog(overlay);
                }
                overlay.Close();
            }
            }
        }
    }
}
