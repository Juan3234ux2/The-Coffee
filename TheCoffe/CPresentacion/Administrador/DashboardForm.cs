using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TheCoffe.CNegocio.Services;
using TheCoffe.CDatos;

namespace TheCoffe.App
{
    public partial class DashboardForm : UserControl
    {
        private AdminService adminService = new AdminService();
        public DashboardForm()
        {
            InitializeComponent();
            PoblarChart();
            PoblarChartDonas();
            PoblarChartChicos();
            CargarCantidades();
        }
        private async void CargarCantidades()
        {
            var cantidades = await adminService.ObtenerCantidadesDashboard();
            lblProducts.Text = cantidades.CantidadProductos.ToString();
            lblTotalEmpleados.Text = cantidades.TotalMeseros.ToString();
            lblTotalPedidos.Text = cantidades.TotalPedido.ToString();
            lbltotalRecaudado.Text = cantidades.TotalRecaudado.ToString("C");
        }
        private async void PoblarChartDonas()
        {
            List<CategoriaEstadistica> categoriaEstadisticas = await adminService.ObtenerVentasPorCategoria(DateTime.Now, DateTime.Now);
            Series serie = new Series("Categorias")
            {
                ChartType = SeriesChartType.Doughnut,
                IsValueShownAsLabel = true
            };
            serie.LabelForeColor = Color.White;
            serie.Font = new Font("Roboto", 10, FontStyle.Bold);
            if (categoriaEstadisticas.Count == 0)
            {
                serie.Points.AddXY("Sin registros", 100);
            }
            else
            {
                foreach (var categoria in categoriaEstadisticas)
                {
                    serie.Points.AddXY(categoria.Categoria, categoria.TotalPedidos);
                }
            }
            h.Legends.First().Position.Height = categoriaEstadisticas.Count == 0 ? 8 : 8 * categoriaEstadisticas.Count();
            h.Series.Clear();
            h.Series.Add(serie);

        }

        private void PoblarChart()
        {
            Series serie = new Series("Ventas")
            {
                ChartType = SeriesChartType.SplineArea,
                Color = Color.FromArgb(96, 75, 200),
                BackGradientStyle = GradientStyle.TopBottom,
                BackSecondaryColor = Color.FromArgb(230, 230, 230),
                BorderColor = Color.Navy,
                BorderWidth = 4
            };
            serie.Points.AddXY("Enero", 300);
            serie.Points.AddXY("Febrero", 250);
            serie.Points.AddXY("Marzo", 200);
            serie.Points.AddXY("Febrero", 270);
            serie.Points.AddXY("Marzo", 400);
            serie.Points.AddXY("Junio", 300);
            serie.Points.AddXY("Julio", 450);
            serie.Points.AddXY("Agosto", 450);
            serie.Points.AddXY("Septiembre", 500);

            chart1.Series.Clear(); 
            chart1.Series.Add(serie);
        }
        private void PoblarChartChicos()
        {
            Series serie = chart2.Series["Productos"];
            AgregarDatos(serie);
            Series serie2 = chart3.Series["Empleados"];
            AgregarDatos(serie2);
            Series serie3 = chart4.Series["Pedidos"];
            AgregarDatos(serie3);
            Series serie4 = chart5.Series["Recaudado"];
            AgregarDatos(serie4);

        }
        private void AgregarDatos(Series serie)
        {
            Random random = new Random();
            for (int i = 1; i <= 7; i++)
            {
                int valorAleatorio = random.Next(0, 201);
                serie.Points.AddXY(i, valorAleatorio);
            }
        }

    }
}
