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
    public partial class CloseBoxForm : Form
    {
        private bool isShowingMsgBox = false;
        private TurnoService turnoService = new TurnoService();
        private OrderService orderService = new OrderService();
        private ProductService productService = new ProductService();
        public event Action cerrarCaja;
        private double totalRecaudado;
        public CloseBoxForm()
        {
            InitializeComponent();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidator.ValidateInput(e, InputValidator.InputType.Digits);           
        }

        private void CloseBoxForm_Load(object sender, EventArgs e)
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
        private async void CargarDatos()
        {
            var ventas = await turnoService.ObtenerVentasDeUnTurno(Turno.TurnoActual.id_turno);
            totalRecaudado = Turno.TurnoActual.monto_inicial + ventas.Sum(v => v.monto_total ?? 0);
            lblMontoRecaudado.Text = $"Monto recaudado: {totalRecaudado.ToString("C")}";
        }
        private void btnCloseBox_Click(object sender, EventArgs e)
        {
            if (orderService.HayPedidosActivos())
            {
                isShowingMsgBox = true;
                MessageBox.Show("No se puede cerrar la caja porque hay pedidos sin finalizar",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                isShowingMsgBox = false;
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAmount.Texts) || ValidarDiferencia())
            {
                isShowingMsgBox = true;
                MessageBox.Show("Debe Completar los campos",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                isShowingMsgBox = false;
                return;
            }
            CerrarCaja();
        }
        private bool ValidarDiferencia()
        {
            return Math.Abs((double.Parse(txtAmount.Texts)- totalRecaudado)) > 10000;
        }
        private void CerrarCaja()
        {
            try
            {
                Turno.TurnoActual.fecha_cierre = DateTime.Now;
                Turno.TurnoActual.observaciones = txtObservaciones.Texts;
                Turno.TurnoActual.monto_cierre = double.Parse(txtAmount.Texts.Trim());
                Turno.TurnoActual.diferencia = Turno.TurnoActual.monto_cierre - totalRecaudado;
                turnoService.ActualizarTurno(Turno.TurnoActual);
                cerrarCaja?.Invoke();
                new AlertBox(this.Owner as Form, Color.LightGreen, Color.SeaGreen, "Proceso Finalizado", "Caja Cerrada Exitosamente", Properties.Resources.informacion);
            }
            catch (Exception ex)
            {
                isShowingMsgBox = true;
                MessageBox.Show(ex.Message, "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isShowingMsgBox = false;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseBoxForm_Deactivate(object sender, EventArgs e)
        {
            if (!isShowingMsgBox)
            {
                this.Close();
            }
        }

        private void txtAmount__TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtAmount.Texts.Trim(), out double amount))
            {
                lblDiferencia.Text = $"Diferencia: $ {productService.FormatCurrency(amount - (totalRecaudado))}";
            }
        }
    }
}
