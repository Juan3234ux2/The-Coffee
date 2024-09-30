using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffe.CPresentacion.General;
using TheCoffe.CAccesoADatos;

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
            RefressPantalla();
            dataCategory.Columns[0].DisplayIndex = dataCategory.Columns.Count - 1;
            dataCategory.Columns[1].DisplayIndex = dataCategory.Columns.Count - 1;
        }

        public void RefressPantalla()
        {
            dataCategory.DataSource = CategoriaDAl.PresentarRegistro();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            using (OverlayForm overlay = new OverlayForm())
            {
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
                using (OverlayForm overlay = new OverlayForm())
                {
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

        private void btnRemovedCategories_Click(object sender, EventArgs e)
        {
            using (OverlayForm overlay = new OverlayForm())
            {
                overlay.Show();
                using (RemovedCategoriesForm categoriesRemoved = new RemovedCategoriesForm())
                {
                    categoriesRemoved.ShowDialog(overlay);
                }
                overlay.Close();
            }
        }
    }
}
