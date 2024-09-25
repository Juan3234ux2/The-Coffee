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
    public partial class RemovedProductsListForm : UserControl
    {
        public RemovedProductsListForm()
        {
            InitializeComponent();
        }

        private void RemovedProductsListForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                int rowIndex = dataRemovedProducts.Rows.Add();
                DataGridViewRow row = dataRemovedProducts.Rows[rowIndex];
                row.Cells[0].Value = 1;
                row.Cells[1].Value = "Torta Tofi";
                row.Cells[2].Value = 5000;
                row.Cells[3].Value = "Pasteleria";
            }
        }

        private void dataRemovedProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataRemovedProducts.Columns[e.ColumnIndex].Name == "activar")
            {
                Form parentForm = this.FindForm();
                using (App.OverlayForm overlay = new App.OverlayForm())
                {
                    if (MessageBox.Show("¿Está seguro que desea activar este registro?", "Confirmar Activación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dataRemovedProducts.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        }
    }
}
