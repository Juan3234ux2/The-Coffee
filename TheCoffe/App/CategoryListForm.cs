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
    public partial class CategoryList : UserControl
    {
        public CategoryList()
        {
            InitializeComponent();
        }

        private void CategoryList_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                int rowIndex = dataCategory.Rows.Add();
                DataGridViewRow row = dataCategory.Rows[rowIndex];
                row.Cells[0].Value = 1;
                row.Cells[1].Value = "Cafes";
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            AddCategoryForm form = new AddCategoryForm();
            form.Show();
        }
    }
}
