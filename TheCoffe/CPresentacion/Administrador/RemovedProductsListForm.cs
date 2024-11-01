using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoffe.App;
using System.Windows.Forms;
using TheCoffe.CAccesoADatos;
using TheCoffe.CDatos;
using TheCoffe.CNegocio.Services;
using TheCoffe.CNegocio;

namespace TheCoffe.CPresentacion
{
    public partial class RemovedProductsListForm : Form
    {
        private Paginator<Producto> paginator;
        private bool isShowingMsgBox = false;
        private ProductService productService = new ProductService();
        private int id;
        public RemovedProductsListForm()
        {
            InitializeComponent();
            dataRemovedProducts.AutoGenerateColumns = false;
        }


        public async void RefreshPantalla()
        {
            var productos = await productService.ObtenerProductosEliminados();
            paginator = new Paginator<Producto>(productos, 9);
            CargarDatos(paginator);

        }
        private void RemovedProductsListForm_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            Timer timer = new Timer();
            timer.Interval = 10;
            timer.Tick += (s, ev) =>
            {
                if (this.Opacity < 1)
                    this.Opacity += 0.10;
                else
                    timer.Stop();
            };
            timer.Start();
            RefreshPantalla();
        }

        private void dataRemovedProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataRemovedProducts.Columns[e.ColumnIndex].Name == "activar")
            {
                    isShowingMsgBox = true;
                    if (MessageBox.Show("¿Está seguro que desea activar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                    id = Convert.ToInt32(dataRemovedProducts.CurrentRow.Cells[0].Value.ToString());
                    productService.CambiarEstado(id);
                    }
                    isShowingMsgBox = false;
                    RefreshPantalla();
            }
        }

        public void CargarDatos(Paginator<Producto> producto)
        {
            dataRemovedProducts.DataSource = null;
            dataRemovedProducts.DataSource = producto.GetPageData().Select(p =>
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


        private void RemovedProductsListForm_Deactivate(object sender, EventArgs e)
        {
            if (!isShowingMsgBox)
            {
                this.Close();
            }
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
