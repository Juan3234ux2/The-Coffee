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
            totalRecaudado = ventas.Sum(v => v.monto_total ?? 0);
            lblMontoRecaudado.Text = $"Monto recaudado: $ {productService.FormatCurrency(Turno.TurnoActual.monto_inicial + totalRecaudado)}";
        }
        private void btnCloseBox_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAmount.Texts))
            {
                isShowingMsgBox = true;
                MessageBox.Show("Debe Completar el campo",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                isShowingMsgBox = false;
                return;
            }
            else
            {
                try
                {
                    double montoEsperado = Turno.TurnoActual.monto_inicial + totalRecaudado;
                    Turno.TurnoActual.fecha_cierre = DateTime.Now;
                    Turno.TurnoActual.observaciones = txtObservaciones.Texts;
                    Turno.TurnoActual.monto_cierre = double.Parse(txtAmount.Texts.Trim());
                    Turno.TurnoActual.diferencia = Turno.TurnoActual.monto_cierre - montoEsperado;
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
                lblDiferencia.Text = $"Diferencia: $ {productService.FormatCurrency(amount - (totalRecaudado + Turno.TurnoActual.monto_inicial))}";
            }
        }
    }
}
