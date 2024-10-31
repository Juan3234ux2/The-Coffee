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
using TheCoffe.CAccesoADatos;
using TheCoffe.CDatos;
using TheCoffe.CNegocio.Services;

namespace TheCoffe.App
{
    public partial class ProductListForm : UserControl
    {
        private ProductService productService = new ProductService();
        private int id;
        public ProductListForm()
        {
            InitializeComponent();
            dataProducts.AutoGenerateColumns = false;
        }

        public async void RefreshPantalla()
        {
            var productos = await productService.ObtenerProductosActivos();

            dataProducts.DataSource = productos.Select(p =>
            new
            {
                p.id_producto,
                p.nombre,
                p.precio,
                c = p.Categoria1.descripcion
            }).ToList();
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            RefreshPantalla();
        }

        private void roundButton4_Click(object sender, EventArgs e)
        {
            using (OverlayForm overlay = new OverlayForm())
            {
                overlay.Show();
                using (AddProductForm modal = new AddProductForm())
                {
                    modal.ShowDialog(overlay);
                }
                overlay.Close();
            }
            RefreshPantalla();
        }

        private void dataProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataProducts.CurrentRow.Cells[0].Value.ToString());
            if (dataProducts.Columns[e.ColumnIndex].Name == "editar")
            {
                using (OverlayForm overlay = new OverlayForm())
                {
                    overlay.Show();
                    using (AddProductForm modal = new AddProductForm(id))
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
                    productService.CambiarEstado(id);
                }
            }
            RefreshPantalla();
        }

        private void btnRemovedProducts_Click(object sender, EventArgs e)
        {
            using (OverlayForm overlay = new OverlayForm())
            {
                overlay.Show();
                using (RemovedProductsListForm productsRemoved = new RemovedProductsListForm())
                {
                    productsRemoved.ShowDialog(overlay);
                }
                overlay.Close();
            }
            RefreshPantalla();
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Texts != string.Empty)
            {
                var Lst = productService.BuscarPorNombre(txtSearch.Texts).Select(p => new {
                    p.id_producto,
                    p.nombre,
                    p.precio,
                    p.id_categoria
                }).ToList();
                dataProducts.DataSource = Lst;
            }
            else
            {
                RefreshPantalla();
            }
        }
    }
}
