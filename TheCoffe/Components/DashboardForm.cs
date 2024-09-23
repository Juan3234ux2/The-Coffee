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

namespace TheCoffe.App
{
    public partial class DashboardForm2 : UserControl
    {
        public DashboardForm2()
        {
            InitializeComponent();
            PoblarChart();
            PoblarChartDonas();
        }
        private void PoblarChartDonas()
        {
            // Crear una nueva serie de tipo Doughnut
            Series serie = new Series("Categorias")
            {
                ChartType = SeriesChartType.Doughnut,
                IsValueShownAsLabel = true
            };
            serie.LabelForeColor = Color.White;
            serie.Font = new Font("Roboto", 10, FontStyle.Bold);


            serie.Points.AddXY("Cafetería", 500);
            serie.Points.AddXY("Pastelería", 300);
            serie.Points.AddXY("Bebidas", 200);
            chartDona.Series.Clear();
            chartDona.Series.Add(serie);

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

        private void AgregarDatos(Series serie)
        {
            Random random = new Random();
            for (int i = 1; i <= 7; i++)
            {
                int valorAleatorio = random.Next(50, 201);
                serie.Points.AddXY(i, valorAleatorio);
            }
        }

    }
}
