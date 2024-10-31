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

namespace TheCoffe.CPresentacion.Cajero
{
    public partial class OpenOrder : Form
    {
        private WaiterService waiterService = new WaiterService();
        private TableService tableService = new TableService();
        private OrderService orderService = new OrderService();
        private bool isShowingMsgBox = false;
        int nroMesa;
        public OpenOrder(int nroMesa)
        {
            InitializeComponent();
            this.nroMesa = nroMesa;
            lblTable.Text = $"Mesa {nroMesa}";
            CargarMeseros();
        }
        private async void CargarMeseros()
        {
            cboMesero.DataSource = await waiterService.ObtenerMeserosTrabajando();
            cboMesero.DisplayMember = "nombreCompleto";
            cboMesero.ValueMember = "id_mesero";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenOrder_Deactivate(object sender, EventArgs e)
        {
            if (!isShowingMsgBox)
            {
                this.Close();
            }
        }

        private void OpenOrder_Load(object sender, EventArgs e)
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
        }

        private void btnOpenBox_Click(object sender, EventArgs e)
        {
            if (cboMesero.SelectedIndex == -1)
            {
                isShowingMsgBox = true;
                MessageBox.Show("Selecciona un mesero",
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
                    Venta pedido = new Venta
                    {
                        id_mesa = tableService.ObtenerMesaPorNro(nroMesa).id_mesa,
                        id_turno = Turno.TurnoActual.id_turno,
                        fecha_venta = DateTime.Now,
                        id_mesero = Convert.ToInt32(cboMesero.SelectedValue),
                        estado = "En Preparacion"
                    };
                    orderService.CrearVenta(pedido);
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    isShowingMsgBox = true;
                    MessageBox.Show(ex.Message, "Error al iniciar pedido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isShowingMsgBox = false;
                }
            }
        }
        
    }
}
