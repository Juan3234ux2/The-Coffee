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
using TheCoffe.CDatos;
using TheCoffe.CNegocio;

namespace TheCoffe.CPresentacion
{
    public partial class SalesListForm : UserControl
    {
        OrderService orderService = new OrderService();
        WaiterService waiterService = new WaiterService();
        private Paginator<Venta> paginator;
        public SalesListForm()
        {
            InitializeComponent();
            dataSales.AutoGenerateColumns = false;
            dataSales.AutoGenerateColumns = false;
        }

        private async void SalesListForm_Load(object sender, EventArgs e)
        {
            await ObtenerVentasFiltradas();
            cboMesero.DataSource = await waiterService.ObtenerTodosLosMeseros();
            cboMesero.DisplayMember = "nombreCompleto";
            cboMesero.ValueMember = "id_mesero";
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
            paginator = new Paginator<Venta>(ventasPorFecha, 9);
            CargarDatos(paginator);
        }
        public void CargarDatos(Paginator<Venta> ventas)
        {
            dataSales.DataSource = ventas.GetPageData().Select(v =>
            new
            {
                v.id_ventas,
                mesero = v.Mesero.nombreCompleto,
                fecha = v.fecha_venta?.ToString("dd-MM-yy"),
                hora = v.fecha_venta?.ToString("HH:mm"),
                monto_total = $" {(v.monto_total ?? 0).ToString("C")}",
            }).ToList(); 
            ActualizarPaginacion(ventas);          
        }
        private void ActualizarPaginacion(Paginator<Venta> ventas)
        {
            lblPagina.Text = $"Página {ventas.CurrentPage} de {ventas.TotalPages}";
            btnAnt.Enabled = ventas.CurrentPage > 1;
            btnSig.Enabled = ventas.CurrentPage < ventas.TotalPages;
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            paginator.PreviousPage();
            CargarDatos(paginator);
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            paginator.NextPage();
            CargarDatos(paginator);
        }
    }
}
