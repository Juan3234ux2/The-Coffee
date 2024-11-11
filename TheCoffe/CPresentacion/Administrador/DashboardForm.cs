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
        private WaiterService waiterService = new WaiterService();
        private ProductService productService = new ProductService();
        public DashboardForm()
        {
            InitializeComponent();
            dataWaiters.AutoGenerateColumns = false;
            PoblarChart();
            PoblarChartDonas();
            PoblarChartChicos();
            CargarCantidades();
            CargarMeserosYProductos();
        }
        private async void CargarCantidades()
        {
            var cantidades = await adminService.ObtenerCantidadesDashboard();
            lblProducts.Text = cantidades.CantidadProductos.ToString();
            lblTotalEmpleados.Text = cantidades.TotalMeseros.ToString();
            lblTotalPedidos.Text = cantidades.TotalPedido.ToString();
            lbltotalRecaudado.Text = cantidades.TotalRecaudado.ToString("C");
        }
        private async void CargarMeserosYProductos()
        {
            var meseros = await waiterService.ObtenerMejoresMeseros();
            dataWaiters.DataSource = meseros.Select(m => new
            {
                Nombre = $"{m.Mesero.nombre} {m.Mesero.apellido}",
                Recaudado = m.Recaudado.ToString("C")
            }).ToList();
            dataProducts.DataSource = await productService.ObtenerEstadisticaProductos();
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

        private async void PoblarChart()
        {

            Series serie = new Series("Ventas")
            {
                ChartType = SeriesChartType.SplineArea,
                Color = Color.FromArgb(96, 75, 200),
                BackGradientStyle = GradientStyle.TopBottom,
                BackSecondaryColor = Color.FromArgb(230, 230, 230),
                BorderColor = Color.Navy,
                BorderWidth = 4,
                ToolTip = "#VALY{C}",
            };
            var recaudado = await adminService.ObtenerTotalRecaudado(DateTime.Now.AddDays(-7), DateTime.Now);
            if(recaudado.Count() > 0)
            {
                foreach (var estadistica in recaudado)
                {
                    serie.Points.AddXY(estadistica.Periodo, estadistica.Recaudado);
                }
            }
            else
            {
                serie.Points.AddXY("Sin Registros", 0);
            }
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
