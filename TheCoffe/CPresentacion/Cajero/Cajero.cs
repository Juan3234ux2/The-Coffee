using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffe.CAccesoADatos;
using TheCoffe.App;
using TheCoffe.CNegocio.Services;
using TheCoffe.CDatos;
using WindowsFormsApplication1;

namespace TheCoffe.CPresentacion.Cajero
{
    public partial class Cajero : UserControl
    {
        private ProductService productservice = new ProductService();
        private TableService tableService = new TableService();
        private OrderService orderService = new OrderService();
        private CategoryService categoryService = new CategoryService();
        private List<Categoria1> categorias;
        private Venta order;
        private Mesa mesa;
        public event Action finalizarOrden;
        public string mesaSeleccionada { get; set; }
        public Cajero()
        {
            InitializeComponent();
            dataProducts.AutoGenerateColumns = false;
            pnlProducts.HorizontalScroll.Enabled = false;
            pnlProducts.HorizontalScroll.Visible = false;
            CargarProductosYCategorias();
        }
        public async void CargarProductosYCategorias()
        {
            var productos = await productservice.ObtenerProductosActivos();
            dataProducts.DataSource = productos;
            await CargarCategorias();
        }
        public async Task CargarCategorias()
        {
            categorias = await categoryService.ObtenerCategoriasActivas();
            for(int i = 0; i < 3; i++)
            {
                RoundButton btnCategory = new RoundButton
                {
                    ForeColor = Color.DimGray,
                    BorderColor = Color.DimGray,
                    BorderRadius = 20,
                    BackColor = Color.White,
                    Height = 40,
                    Text = categorias[i].descripcion,
                    BorderSize = 1,
                    TabStop = false
                };
                btnCategory.FlatAppearance.MouseDownBackColor = Color.White;
                btnCategory.FlatAppearance.MouseDownBackColor = Color.White;
                btnCategory.Click += new EventHandler(SeleccionarCategoria);
                pnlCategorias.Controls.Add(btnCategory);
            }
        }
        public async void SeleccionarCategoria(object sender, EventArgs e)
        {
            pnlProducts.Focus();
            List<Producto> productos;
            if ((sender as RoundButton).Text != "Mas Populares")
            {
                Categoria1 categoria = categorias.Where(c => c.descripcion == (sender as RoundButton).Text).First();
                productos = await productservice.ObtenerProductosPörCategoria(categoria.descripcion);
            }
            else
            {
                productos = await productservice.ObtenerProductosActivos();
            }
            dataProducts.DataSource = productos;
            ModificarBotonesCategoria(sender as RoundButton);
        }
        public void ModificarBotonesCategoria(RoundButton button)
        {
            foreach(Control control in pnlCategorias.Controls)
            {
                if(control is RoundButton btn){
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.DimGray;
                    btn.BorderSize = 1;
                }
            }
            button.ForeColor = Color.White;
            button.BackColor = Color.FromArgb(96, 75, 232);
            button.BorderSize = 0;
        }
        public async void OnSection1Loaded()
        {
            if (!string.IsNullOrEmpty(mesaSeleccionada))
            {
                lblNroMesa.Text = $"Mesa: {mesaSeleccionada}";
                mesa = tableService.ObtenerMesaPorNro(int.Parse(mesaSeleccionada));
                await CargarPedido();
                lblFecha.Text = order?.fecha_venta.ToString();                
                lblCajero.Text = order.Mesero.apellido + " " + order.Mesero.nombre;
                CargarProductosAlPedido();
                ActualizarDatos();
            }
        }
        public async void ActualizarDatos()
        {
            await CargarPedido();
            lblCountProduct.Text = pnlProducts.Controls.Count.ToString();
            lblTotal.Text = $"$ {productservice.FormatCurrency(order.Venta_Detalle.Sum(d => d.subtotal))}";
        }
        public async Task CargarPedido()
        {           
            order = await orderService.ObtenerVentaPorMesa(mesa.id_mesa);
        }
        private void btnFinalizeOrder_Click(object sender, EventArgs e)
        {
            using (OverlayForm overlay = new OverlayForm())
            {
                overlay.Show();
                using (FinalizeOrder modal = new FinalizeOrder(order,mesa))
                {
                    modal.finishOrder += () =>
                    {
                        finalizarOrden?.Invoke();
                    }; 
                    modal.ShowDialog(overlay);
                }
                 overlay.Close();
            }
        }
        public void CargarProductosAlPedido()
        {
            pnlProducts.Controls.Clear();
            var detallePedido = order.Venta_Detalle.ToList();
            foreach(Venta_Detalle detalle in detallePedido)
            {
                CardProduct producto = new CardProduct(detalle.id_detalle);
                producto.ChangeQty += ActualizarDatos;
                producto.CargarDatos();
                pnlProducts.Controls.Add(producto);
            }
        }
        private void dataProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idProducto = Convert.ToInt32(dataProducts.CurrentRow.Cells[0].Value.ToString());
            bool esNuevoProducto = orderService.AgregarProductoAlPedido(order, idProducto);
            foreach (Control control in pnlProducts.Controls)
            {
                if (control is CardProduct card)
                {
                    card.CargarDatos();
                }
            }
            if (esNuevoProducto)
            {
                Venta_Detalle ultimoRegistro = orderService.ObtenerUltimoDetalle();
                CardProduct producto = new CardProduct(ultimoRegistro.id_detalle);
                producto.ChangeQty += ActualizarDatos;
                pnlProducts.Controls.Add(producto);
            }            
            ActualizarDatos();
        }

        private async void txtSearch__TextChanged(object sender, EventArgs e)
        {
            List<Producto> productos;
            if (txtSearch.Texts != string.Empty)
            {
                List<Producto> listaProductos = productservice.BuscarPorNombre(txtSearch.Texts);
                productos = listaProductos;
            }
            else
            {
                productos = await productservice.ObtenerProductosActivos();
            }
            dataProducts.DataSource = productos;
            ModificarBotonesCategoria(btnPopulares);
        }
    }
}
