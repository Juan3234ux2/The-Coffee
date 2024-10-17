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
using TheCoffe.CDatos;
using System.Data.Entity;

namespace TheCoffe.App
{
    public partial class CategoryList : UserControl
    {
        public CategoryList()
        {
            InitializeComponent();
        }

        Categoria1DAL categoriaDAL = new Categoria1DAL();
        Categoria1 categoria = new Categoria1();
        private int id;

        private void CategoryList_Load(object sender, EventArgs e)
        {
            RefreshPantalla();
        }

        public void RefreshPantalla()
        {
            var Lst = categoriaDAL.Read(false).Select(p => new {
                p.id_categoria,
                p.descripcion
            }).ToList();
            dataCategory.DataSource = Lst;
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
            RefreshPantalla();
        }

        private void dataCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataCategory.Columns[e.ColumnIndex].Name == "editar")
            {
                id = Convert.ToInt32(dataCategory.CurrentRow.Cells[2].Value.ToString());

                using (OverlayForm overlay = new OverlayForm())
                {
                    overlay.Show();
                    using (AddCategoryForm modal = new AddCategoryForm(id))
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
                    id = Convert.ToInt32(dataCategory.CurrentRow.Cells[2].Value.ToString());
                    categoriaDAL.Delete(id);
                }
            }

            RefreshPantalla();
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
            RefreshPantalla();
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Texts != string.Empty)
            {
                var Lst = categoriaDAL.Search(txtSearch.Texts).Select(p => new {
                    p.id_categoria,
                    p.descripcion
                }).ToList();
                dataCategory.DataSource = Lst;
            }
            else
            {
                RefreshPantalla();
            }
        }
    }
}
