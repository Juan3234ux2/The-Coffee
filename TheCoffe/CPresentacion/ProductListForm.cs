using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

    }
}
