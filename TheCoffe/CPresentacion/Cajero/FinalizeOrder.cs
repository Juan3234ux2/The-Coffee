using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffe.App;
using TheCoffe.CDatos;
using TheCoffe.CNegocio;
using TheCoffe.CNegocio.Services;

namespace TheCoffe.CPresentacion.Cajero
{
    public partial class FinalizeOrder : Form
    {
        private bool isShowingMsgBox = false;
        private CustomerService customerService = new CustomerService();
        private ProductService productService = new ProductService();
        private double montoTotal;
        public FinalizeOrder(Venta venta)
        {
            InitializeComponent();
            dataProducts.AutoGenerateColumns = false;
            var listaVenta = venta.Venta_Detalle.Select(d =>
            new
            {
                d.cantidad,
                productService.ObtenerProductoPorID(d.id_producto).nombre,
                precio = $"$ {productService.FormatCurrency(d.subtotal)}",
            }).ToList();
            dataProducts.DataSource = listaVenta;
            lblCajero.Text = venta.Mesero.apellido + " " + venta.Mesero.nombre;
            montoTotal = venta.Venta_Detalle.Sum(d => d.subtotal);
            lblTotal.Text = $"$ {productService.FormatCurrency(montoTotal)}";
        }
        private void CargarClientes()
        {
            cboCustomer.DataSource = customerService.ObtenerClientes();
            cboCustomer.DisplayMember = "nombreYCuit";
            cboCustomer.ValueMember = "id_cliente";
        }
        private void btnClient_Click(object sender, EventArgs e)
        {
            cboCustomer.DroppedDown = !cboCustomer.DroppedDown;
        }

        private void FinalizeOrder_Load(object sender, EventArgs e)
        {
            CargarClientes();
            cboCustomer.SelectedIndex = 0;
            cboRecibo.SelectedIndex = 0;
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
        }

        private void btnRecibo_Click(object sender, EventArgs e)
        {
            cboRecibo.DroppedDown = !cboRecibo.DroppedDown;
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            cboPago.DroppedDown = !cboPago.DroppedDown;
        }

        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidator.ValidateInput(e, InputValidator.InputType.Digits);
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            isShowingMsgBox = true;
            using (OverlayForm overlay = new OverlayForm())
            {
                overlay.Show();
                using (AddClientForm modal = new AddClientForm())
                {
                    modal.ShowDialog(overlay);
                }
                overlay.Close();
            }
            CargarClientes();
            isShowingMsgBox = false;
        }

        private void btnFinalizeOrder_Click(object sender, EventArgs e)
        {
            if(cboPago.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtCash.Texts))
            {
                isShowingMsgBox = true;
                MessageBox.Show("Debe completar todos los campos",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                isShowingMsgBox = false;
                return;
            }
            else {
                new AlertBox(this.Owner as Form, Color.LightGreen, Color.SeaGreen, "Pedido Finalizado", "Pedido Finalizado Exitosamente", Properties.Resources.informacion);
            }
        }

        private void FinalizeOrder_Deactivate(object sender, EventArgs e)
        {
            if (!isShowingMsgBox)
            {
                this.Close();
            }
        }

        private void txtCash__TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtCash.Texts.Trim(), out double amount))
            {
                lblVuelto.Text = $"$ {productService.FormatCurrency((amount - montoTotal))}";
            }
        }
    }
}
