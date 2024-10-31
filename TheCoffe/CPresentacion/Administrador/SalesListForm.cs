using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoffe.App;
using System.Windows.Forms;
using TheCoffe.CNegocio.Services;

namespace TheCoffe.CPresentacion
{
    public partial class SalesListForm : UserControl
    {
        OrderService orderService = new OrderService();
        WaiterService waiterService = new WaiterService();
        public SalesListForm()
        {
            InitializeComponent();
            dataSales.AutoGenerateColumns = false;
            dataSales.AutoGenerateColumns = false;
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }

        private async void SalesListForm_Load(object sender, EventArgs e)
        {
            await CargarDatos();
            cboMesero.DataSource = await waiterService.ObtenerTodosLosMeseros();
            cboMesero.DisplayMember = "nombreCompleto";
            cboMesero.ValueMember = "id_mesero";
        }
        private async Task CargarDatos()
        {
            await ObtenerVentasFiltradas();
        }
        private void dataSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataSales.Columns[e.ColumnIndex].Name == "detalle")
            {
                int id = int.Parse(dataSales.CurrentRow.Cells[0].Value.ToString());
                using (OverlayForm overlay = new OverlayForm())
                {
                    overlay.Show();
                    using (SaleDetailListForm modal = new SaleDetailListForm(id))
                    {
                        modal.ShowDialog(overlay);
                    }
                    overlay.Close();
                }
            }
        }

        private void btnMesero_Click(object sender, EventArgs e)
        {
            cboMesero.DroppedDown = !cboMesero.DroppedDown;
        }

        private async void dtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            await ObtenerVentasFiltradas();
        }
        private async Task ObtenerVentasFiltradas()
        {
            var ventasPorFecha = await orderService.FiltrarPorFecha(dtpFechaDesde.Value, dtpFechaHasta.Value);
            dataSales.DataSource = ventasPorFecha.Select(v =>
            new
            {
                v.id_ventas,
                mesero = v.Mesero.nombreCompleto,
                fecha = v.fecha_venta?.ToString("dd-MM-yy"),
                hora = v.fecha_venta?.ToString("HH:mm"),
                monto_total = $" {(v.monto_total ?? 0).ToString("C")}",
            }).ToList();
        }

        private async void dtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            await ObtenerVentasFiltradas();
        }
    }
}
