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

namespace TheCoffe.CPresentacion.Cajero
{
    public partial class Cajero : UserControl
    {
        private ProductService productservice = new ProductService();
        private TableService tableService = new TableService();
        private OrderService orderService = new OrderService();
        private Venta order;
        public string mesaSeleccionada { get; set; }
        public Cajero()
        {
            InitializeComponent();
            dataProducts.AutoGenerateColumns = false;
            pnlProducts.HorizontalScroll.Enabled = false;
            pnlProducts.HorizontalScroll.Visible     = false;
        }
        private async Task CargarProductos()
        {
            var productos = await productservice.ObtenerProductosActivos();
            dataProducts.DataSource = productos;
        }
        public async void OnSection1Loaded()
        {
            if (!string.IsNullOrEmpty(mesaSeleccionada))
            {
                lblNroMesa.Text = $"Mesa: {mesaSeleccionada}";
                await CargarPedido();
                lblFecha.Text = order?.fecha_venta.ToString();                
                lblCajero.Text = order.Mesero.apellido + " " + order.Mesero.nombre;
                await CargarProductos();
                CargarProductosAlPedido();
                ActualizarDatos();
            }
        }
        public async void ActualizarDatos()
        {
            order = await orderService.ObtenerVentaPorMesa(order.id_mesa);
            lblCountProduct.Text = pnlProducts.Controls.Count.ToString();
            lblTotal.Text = $"$ {productservice.FormatCurrency(order.Venta_Detalle.Sum(d => d.subtotal))}";
        }
        public async Task CargarPedido()
        {
            Mesa mesa = tableService.ObtenerMesaPorNro(int.Parse(mesaSeleccionada));
            order = await orderService.ObtenerVentaPorMesa(mesa.id_mesa);
        }
        private void btnFinalizeOrder_Click(object sender, EventArgs e)
        {
            using (OverlayForm overlay = new OverlayForm())
            {
                overlay.Show();
                using (FinalizeOrder modal = new FinalizeOrder(order))
                {
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
                pnlProducts.Controls.Add(producto);
            }
        }
        private async void dataProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                pnlProducts.Controls.Add(new CardProduct(ultimoRegistro.id_detalle));
            }            
            ActualizarDatos();
        }
    }
}
