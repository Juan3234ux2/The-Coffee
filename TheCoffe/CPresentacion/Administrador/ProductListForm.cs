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
using TheCoffe.CNegocio;

namespace TheCoffe.App
{
    public partial class ProductListForm : UserControl
    {
        private Paginator<Producto> paginator;
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
            paginator = new Paginator<Producto>(productos, 9);
            CargarDatos(paginator);
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
                    c = p.Categoria1.descripcion
                }).ToList();
                dataProducts.DataSource = Lst;
            }
            else
            {
                RefreshPantalla();
            }
        }

        public void CargarDatos(Paginator<Producto> producto)
        {
            dataProducts.DataSource = null;
            dataProducts.DataSource = producto.GetPageData().Select(p => 
            new
            {
                p.id_producto,
                p.nombre,
                p.precio,
                c = p.Categoria1.descripcion
            }).ToList();
            ActualizarPaginacion(producto);
        }
        private void ActualizarPaginacion(Paginator<Producto> productos)
        {
            lblPagina.Text = $"Página {productos.CurrentPage} de {productos.TotalPages}";
            btnAnt.Enabled = productos.CurrentPage > 1;
            btnSig.Enabled = productos.CurrentPage < productos.TotalPages;
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            paginator.PreviousPage();
            CargarDatos(paginator);
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            paginator.NextPage();
            CargarDatos(paginator);
        }
    }
}
