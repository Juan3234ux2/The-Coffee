using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffe.CDatos;
using TheCoffe.CNegocio.Services;

namespace TheCoffe.CPresentacion.Cajero
{
    public partial class CardProduct : UserControl
    {
        private ProductService productService = new ProductService();
        private OrderService orderService = new OrderService();
        private Venta_Detalle detalleVenta = new Venta_Detalle();
        public event Action ChangeQty;
        private int idDetalle;
        private Producto product;
        public CardProduct(int detalle)
        {
            InitializeComponent();
            idDetalle = detalle;
            product = productService.ObtenerProductoPorID(orderService.ObtenerDetallePorID(idDetalle).id_producto);
            CargarDatos();
        }
        public void CargarDatos()
        {
            detalleVenta = orderService.ObtenerDetallePorID(idDetalle);
            lblDescription.Text = product.descripcion;
            lblName.Text = product.nombre;            
            lblPrice.Text = $"$  {productService.FormatCurrency(product.precio * detalleVenta.cantidad)}";
            lblQty.Text = detalleVenta.cantidad.ToString();
            ChangeQty?.Invoke();
        }
        private void btnMas_Click(object sender, EventArgs e)
        {
            orderService.ModificarCantidad(idDetalle,1,product.id_producto);
            CargarDatos();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if(int.Parse(lblQty.Text) > 0)
            {
                orderService.ModificarCantidad(idDetalle, -1, product.id_producto);
                CargarDatos();
            }
        }

        private void btnMas_MouseHover(object sender, EventArgs e)
        {
            (sender as AltoControls.AltoButton).ForeColor = Color.White;
        }

        private void btnMas_MouseLeave(object sender, EventArgs e)
        {
            (sender as AltoControls.AltoButton).ForeColor = Color.Black;
        }
    }
}
