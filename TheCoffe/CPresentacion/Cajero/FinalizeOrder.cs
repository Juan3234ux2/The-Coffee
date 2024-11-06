using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
        private OrderService orderService = new OrderService();
        private PrintDocument ticketDocument;
        private PrintPreviewDialog ticketPreviewDialog;
        private double montoTotal;
        private Venta ventaTotal;
        public event Action finishOrder;
        public FinalizeOrder(Venta venta, Mesa mesa)
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
            lblAddClient.Text = $"Finalizar Pedido - Mesa {mesa.nro_mesa}";
            lblCajero.Text = venta.Mesero.apellido + " " + venta.Mesero.nombre;
            montoTotal = venta.Venta_Detalle.Sum(d => d.subtotal);
            ventaTotal = venta;
            lblTotal.Text = $"$ {productService.FormatCurrency(montoTotal)}";
        }
        private void ConfigurarTicket()
        {
            ticketDocument = new PrintDocument();
            ticketDocument.PrintPage += new PrintPageEventHandler(PrintTicket_PrintPage);
            int altoContenido = 430;
            foreach(Venta_Detalle detalle in ventaTotal.Venta_Detalle)
            {
                altoContenido += 40;
            }
            ticketDocument.DefaultPageSettings.PaperSize = new PaperSize("Custom", 315, altoContenido);
            ticketPreviewDialog = new PrintPreviewDialog
            {
                Document = ticketDocument,
                Height = altoContenido,
                ShowIcon = false,
            };
            ticketPreviewDialog.Shown += (sender, e) =>
            {
                DisablePrintButton(ticketPreviewDialog);
                CenterPrintPreviewDialog(ticketPreviewDialog);
            };
            ticketPreviewDialog.FormClosed += (sender, e) =>
            {
                orderService.FinalizarPedido(ventaTotal);
                finishOrder?.Invoke();
            };
        }
        private void PrintTicket_PrintPage(object sender, PrintPageEventArgs e)
        {
            Ticket ticket = new Ticket();
            ticket.CrearTicket(ventaTotal,e, double.Parse(txtCash.Texts.Trim()));
        }

        private void CargarClientes()
        {
            var clientes = customerService.ObtenerClientes();
            cboCustomer.DataSource = clientes;
            cboCustomer.DisplayMember = "nombreYCuit";
            cboCustomer.ValueMember = "id_cliente";
            if(clientes.Count > 0)
            {
                cboCustomer.SelectedIndex = 0;
            }
        }
        private void btnClient_Click(object sender, EventArgs e)
        {
            cboCustomer.DroppedDown = !cboCustomer.DroppedDown;
        }

        private void FinalizeOrder_Load(object sender, EventArgs e)
        {
            CargarClientes();
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
            }else if(montoTotal > double.Parse(txtCash.Texts.Trim()) )
            {
                isShowingMsgBox = true;
                MessageBox.Show("El monto recibido no cubre la venta",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                isShowingMsgBox = false;
                return;
            }
            if(cboRecibo.SelectedIndex == 0)
            {
                ConfigurarTicket();
                ticketPreviewDialog.ShowDialog(this);
            }
            else {
                if(cboCustomer.SelectedIndex == -1)
                {
                    isShowingMsgBox = true;
                    MessageBox.Show("Debe seleccionar un cliente",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    isShowingMsgBox = false;
                    return;
                }
                Factura factura = new Factura();
                Cliente cliente = customerService.ObtenerClientePorID(int.Parse(cboCustomer.SelectedValue.ToString()));
                orderService.FinalizarPedido(ventaTotal);
                factura.CrearFactura(ventaTotal,cliente);
                finishOrder?.Invoke();
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
        private void DisablePrintButton(PrintPreviewDialog dialog)
        {
            ToolStrip toolStrip = null;

            foreach (Control control in dialog.Controls)
            {
                if (control is ToolStrip)
                {
                    toolStrip = (ToolStrip)control;
                    break;
                }
            }

            if (toolStrip != null)
            {
                foreach (ToolStripItem item in toolStrip.Items)
                {
                    if (item is ToolStripButton button && button.Text == "Imprimir")
                    {
                        button.Enabled = false;
                    }
                }
            }
        }
        private void CenterPrintPreviewDialog(PrintPreviewDialog dialog)
        {
            var screenBounds = Screen.PrimaryScreen.WorkingArea;
            dialog.StartPosition = FormStartPosition.Manual;
            dialog.Location = new Point(
                (screenBounds.Width - dialog.Width) / 2,
                (screenBounds.Height - dialog.Height) / 2
            );
        }

        private void cboRecibo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRecibo.SelectedIndex == 0)
            {
                cboCustomer.Enabled = false;
                btnAddClient.Enabled = false;
                btnClient.Enabled = false;
            }
            else
            {
                cboCustomer.Enabled = true;
                btnAddClient.Enabled = true;
                btnClient.Enabled = true;
            }
        }
    }
}
