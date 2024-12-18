﻿using System;
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

namespace TheCoffe.CPresentacion.Gerente
{
    public partial class SalesReportsForm : UserControl
    {
        AdminService adminService = new AdminService();
        public SalesReportsForm()
        {
            InitializeComponent();
        }
        private void SalesReportsForm_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Now.AddMonths(-1);
            dtpHasta.Value = DateTime.Now;
            CargarDatos();
        }
        private async void CargarDatos()
        {
            List<CategoriaEstadistica> categoriaEstadisticas = await adminService.ObtenerVentasPorCategoria(dtpDesde.Value, dtpHasta.Value);
            double promedioIngresos = await adminService.ObtenerPromedioIngresosDiarios(dtpDesde.Value, dtpHasta.Value);
            int promedioCantidad = await adminService.ObtenerPromedioCantidadVentas(dtpDesde.Value, dtpHasta.Value);
            lblIngresoPromedio.Text = promedioIngresos.ToString("C");
            lblPromedioCantidad.Text = promedioCantidad.ToString();
            CargarChartDonas(categoriaEstadisticas);
            CargarChartRecaudado();
            MostrarGraficoDeBarras();
        }
        private void CargarChartDonas(List<CategoriaEstadistica> estadisticas)
        {
            Series serie = new Series("Categorias")
            {
                ChartType = SeriesChartType.Doughnut,
                IsValueShownAsLabel = true
            };
            serie.LabelForeColor = Color.White;
            serie.Font = new Font("Roboto", 10, FontStyle.Bold);
            if(estadisticas.Count == 0)
            {
                serie.Points.AddXY("Sin registros",100);
            }
            else
            {
                foreach(var categoria in estadisticas)
                {
                    serie.Points.AddXY(categoria.Categoria, categoria.TotalPedidos);
                }
            }
            chartDona.Legends.First().Position.Height = estadisticas.Count == 0 ? 8: 8 * estadisticas.Count();
            chartDona.Series.Clear();
            chartDona.Series.Add(serie);
        }

        private async void CargarChartRecaudado()
        {
            var estadisticas = await adminService.ObtenerTotalRecaudado(dtpDesde.Value, dtpHasta.Value);

            Series serie = new Series("Ventas")
            {
                ChartType = SeriesChartType.SplineArea,
                Color = Color.FromArgb(96, 75, 200),
                BackGradientStyle = GradientStyle.TopBottom,
                BackSecondaryColor = Color.FromArgb(230, 230, 230),
                BorderColor = Color.Navy,
                BorderWidth = 4,
                ToolTip = "#VALY{C}",
                IsValueShownAsLabel = true
            };
            if (estadisticas.Count > 0)
            {
                foreach (var recaudado in estadisticas)
                {
                    serie.Points.AddXY(recaudado.Periodo, recaudado.Recaudado);
                }
            }
            else
            {
                serie.Points.AddXY("Sin Registros", 0);
            }
            
            chart1.Series.Clear();
            chart1.Series.Add(serie);
        }

        private  void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            CargarDatos();
            dtpHasta.MinDate =  dtpDesde.Value.AddDays(2);
            dtpDesde.MaxDate = dtpHasta.Value.AddDays(-2);
        }
        private async void MostrarGraficoDeBarras()
        {
            var datos = await adminService.ObtenerPedidosAgrupados(dtpDesde.Value, dtpHasta.Value);



            var serie = new Series
            {
                Name = "Pedidos",
                ChartType = SeriesChartType.Column,
                Color = Color.FromArgb(96, 75, 200),
                BackGradientStyle = GradientStyle.TopBottom,
                BackSecondaryColor = Color.FromArgb(230, 230, 230),
                BorderColor = Color.Navy,
                BorderWidth = 2,
                ToolTip = "#VALY",
                IsValueShownAsLabel = true,
            };
            if(datos.Count > 0)
            {
                foreach (var dato in datos)
                {
                    serie.Points.AddXY(dato.Periodo, dato.CantidadPedidos);
                }
            }
            else
            {
                serie.Points.AddXY("Sin Registros", 0);
            }
            chartTotalPedidos.Series.Clear();
            chartTotalPedidos.Series.Add(serie);
            chartTotalPedidos.ChartAreas["Principal"].AxisX.Interval = 1;
        }

    }
}
