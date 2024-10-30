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
using TheCoffe.CNegocio.Services;

namespace TheCoffe.CPresentacion.Cajero
{
    public partial class SalesBoxForm : UserControl
    {
        private TurnoService turnoService = new TurnoService();
        private ProductService productService = new ProductService();
        public SalesBoxForm()
        {
            InitializeComponent();
        }
        private void btnCloseBox_Click(object sender, EventArgs e)
        {
            using (OverlayForm overlay = new OverlayForm())
            {
                overlay.Show();
                using (CloseBoxForm modal = new CloseBoxForm())
                {
                    modal.cerrarCaja += CerrarCaja;
                    modal.ShowDialog(overlay);
                }
                overlay.Close();
            }
        }

        private void dataBoxSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataBoxSales.Columns[e.ColumnIndex].Name == "detalle")
            {
                using (OverlayForm overlay = new OverlayForm())
                {
                    overlay.Show();
                    using (SaleDetailListForm modal = new SaleDetailListForm())
                    {
                        modal.ShowDialog(overlay);
                    }
                    overlay.Close();
                }
            }
        }
        private void CerrarCaja()
        {
            btnCloseBox.Enabled = false;
            btnCloseBox.Cursor = DefaultCursor;
            btnCloseBox.Text = "Caja Cerrada";
        }
        private void SalesBoxForm_Load(object sender, EventArgs e)
        {
            CargarVentasDelTurno();
            if(Turno.TurnoActual.monto_cierre != null)
            {
                CerrarCaja();
            }
            /*
            for (int i = 0; i < 3; i++)
            {
                int rowIndex = dataBoxSales.Rows.Add();
            }
                
                DataGridViewRow row = dataBoxSales.Rows[rowIndex];
                row.Cells[0].Value = 1;                
                row.Cells[1].Value = "Emilia";
                row.Cells[2].Value = "2024-06-14";
                row.Cells[3].Value = "20:10:05";
                row.Cells[4].Value = "30,000";
            }*/
        }
        private async void CargarVentasDelTurno()
        {
            var ventas = await turnoService.ObtenerVentasDeUnTurno(Turno.TurnoActual.id_turno);
            double totalRecaudado = ventas.Sum(v => v.monto_total ?? 0);
            lblEnCaja.Text = $"{productService.FormatCurrency(Turno.TurnoActual.monto_inicial + totalRecaudado)}";
            dataBoxSales.DataSource = ventas.Select(v =>
            new
            {
                v.id_ventas,
                mesero = v.Mesero.nombreCompleto,
                fecha = v.fecha_venta?.ToString("dd-MM"),
                hora = v.fecha_venta?.ToString("HH:mm"),
                v.monto_total,
            }).ToList();
        }
    }
}
