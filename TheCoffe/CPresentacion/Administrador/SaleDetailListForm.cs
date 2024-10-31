using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffe.CDatos;
using TheCoffe.CNegocio.Services;

namespace TheCoffe.CPresentacion
{
    public partial class SaleDetailListForm : Form
    {
        private bool isShowingMsgBox = false;
        private OrderService orderService = new OrderService();
        private int idPedido;
        public SaleDetailListForm(int idPedido)
        {
            InitializeComponent();
            this.idPedido = idPedido;
            dataSaleDetail.AutoGenerateColumns = false;
        }
        private async void CargarDatos()
        {
            var detalle = await orderService.ObtenerDetallesDeUnPedido(idPedido);
            dataSaleDetail.DataSource = detalle.Select(p => new
            {
                p.id_detalle,
                producto = p.Producto.nombre,
                p.cantidad,
                p.subtotal,
                p.precio_unitario
            }).ToList();
        }
        private void SaleDetailListForm_Load(object sender, EventArgs e)
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
            CargarDatos();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaleDetailListForm_Deactivate(object sender, EventArgs e)
        {
            if (!isShowingMsgBox)
            {
                this.Close();
            }
        }
    }
}
