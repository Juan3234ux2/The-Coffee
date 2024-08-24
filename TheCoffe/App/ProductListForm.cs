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
            int rowIndex = dataProducts.Rows.Add();
            DataGridViewRow row = dataProducts.Rows[rowIndex];
            row.Cells[0].Value = 20;
            row.Cells[1].Value = "Cafe";
            row.Cells[2].Value = 2000;
            row.Cells[3].Value = "Cafes";
            int rowIndex2 = dataProducts.Rows.Add();
            DataGridViewRow row2 = dataProducts.Rows[rowIndex2];
            row2.Cells[0].Value = 20;
            row2.Cells[1].Value = "Cafe";
            row2.Cells[2].Value = 2000;
            row2.Cells[3].Value = "Cafes";
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
