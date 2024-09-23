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
            Form parentForm = this.FindForm();
            using (OverlayForm overlay = new OverlayForm())
            {
                overlay.Size = parentForm.ClientSize;
                overlay.Location = parentForm.PointToScreen(Point.Empty);
                overlay.Owner = parentForm;

                overlay.Show();
                using (AddCategoryForm modal = new AddCategoryForm())
                {
                    modal.ShowDialog(overlay);
                }
                overlay.Close();
            }
        }

        private void dataCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataCategory.Columns[e.ColumnIndex].Name == "editar")
            {
                Form parentForm = this.FindForm();
                using (OverlayForm overlay = new OverlayForm())
                {
                    overlay.Size = parentForm.ClientSize;
                    overlay.Location = parentForm.PointToScreen(Point.Empty);
                    overlay.Owner = parentForm;

                    overlay.Show();
                    using (AddCategoryForm modal = new AddCategoryForm("Cafes"))
                    {
                        modal.ShowDialog(overlay);
                    }
                    overlay.Close();
                }
            }
            else if (dataCategory.Columns[e.ColumnIndex].Name == "eliminar")
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dataCategory.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}
