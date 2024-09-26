using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffe.CPresentacion;

namespace TheCoffe.App
{
    public partial class ProductListForm : UserControl
    {
        public ProductListForm()
        {
            InitializeComponent();
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 6; i++)
            {
                int rowIndex = dataProducts.Rows.Add();
                DataGridViewRow row = dataProducts.Rows[rowIndex];
                row.Cells[0].Value = 20;
                row.Cells[1].Value = "Cafe";
                row.Cells[2].Value = 3000;
                row.Cells[3].Value = "Cafes";
            }
        }

        private void roundButton4_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            using (OverlayForm overlay = new OverlayForm())
            {
                overlay.Size = parentForm.ClientSize;
                overlay.Location = parentForm.PointToScreen(Point.Empty);
                overlay.Owner = parentForm;

                overlay.Show();
                using (AddProductForm modal = new AddProductForm())
                {
                    modal.ShowDialog(overlay);
                }
                overlay.Close();
            }
        }

        private void dataProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataProducts.Columns[e.ColumnIndex].Name == "editar")
            {
                Form parentForm = this.FindForm();
                using (OverlayForm overlay = new OverlayForm())
                {
                    overlay.Size = parentForm.ClientSize;
                    overlay.Location = parentForm.PointToScreen(Point.Empty);
                    overlay.Owner = parentForm;

                    overlay.Show();
                    using (AddProductForm modal = new AddProductForm("Cafe", "3000", "Leche, Azucar, Cafe Morenita"))
                    {
                        modal.ShowDialog(overlay);
                    }
                    overlay.Close();
                }
            }
            else if(dataProducts.Columns[e.ColumnIndex].Name == "eliminar")
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dataProducts.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void btnRemovedProducts_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            using (OverlayForm overlay = new OverlayForm())
            {
                overlay.Size = parentForm.ClientSize;
                overlay.Location = parentForm.PointToScreen(Point.Empty);
                overlay.Owner = parentForm;

                overlay.Show();
                using (RemovedProductsListForm productsRemoved = new RemovedProductsListForm())
                {
                    productsRemoved.ShowDialog(overlay);
                }
                overlay.Close();
            }
        }
    }
}
