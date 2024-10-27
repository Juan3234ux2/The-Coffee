using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffe.CNegocio.Services;

namespace TheCoffe.CPresentacion.Cajero
{
    public partial class OpenOrder : Form
    {
        private WaiterService waiterService = new WaiterService();
        public OpenOrder(int nroMesa)
        {
            InitializeComponent();
            lblTable.Text = $"Mesa {nroMesa}";
            CargarMeseros();
        }
        private async void CargarMeseros()
        {
            cboMesero.DataSource = await waiterService.ObtenerMeserosActivos();
            cboMesero.DisplayMember = "nombreCompleto";
            cboMesero.ValueMember = "id_mesero";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenOrder_Deactivate(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
