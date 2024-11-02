namespace TheCoffe.CPresentacion.Gerente
{
    partial class SalesReportsForm
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(45570D, 5D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(45571D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(45572D, 8D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(45573D, 15D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(45574D, 12D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(45575D, 3D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(45576D, 9D);
            this.label6 = new System.Windows.Forms.Label();
            this.sPanel2 = new Sipaa.Framework.SPanel();
            this.chartDona = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.sPanel1 = new Sipaa.Framework.SPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.sPanel3 = new Sipaa.Framework.SPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sPanel4 = new Sipaa.Framework.SPanel();
            this.sPanel5 = new Sipaa.Framework.SPanel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.sPanel6 = new Sipaa.Framework.SPanel();
            this.lblIngresoPromedio = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sPanel7 = new Sipaa.Framework.SPanel();
            this.lblPromedioCantidad = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpHasta = new TheCoffe.Components.CustomDateTimePicker();
            this.dtpDesde = new TheCoffe.Components.CustomDateTimePicker();
            this.sPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDona)).BeginInit();
            this.sPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.sPanel3.SuspendLayout();
            this.sPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.sPanel6.SuspendLayout();
            this.sPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(295, 41);
            this.label6.TabIndex = 71;
            this.label6.Text = "Reporte de Ventas";
            // 
            // sPanel2
            // 
            this.sPanel2.BackColor = System.Drawing.Color.White;
            this.sPanel2.BorderColor = System.Drawing.Color.White;
            this.sPanel2.BorderRadius = 15;
            this.sPanel2.BorderSize = 0;
            this.sPanel2.Controls.Add(this.chartDona);
            this.sPanel2.Controls.Add(this.label3);
            this.sPanel2.ForeColor = System.Drawing.Color.White;
            this.sPanel2.Location = new System.Drawing.Point(675, 74);
            this.sPanel2.Name = "sPanel2";
            this.sPanel2.Size = new System.Drawing.Size(320, 301);
            this.sPanel2.TabIndex = 73;
            // 
            // chartDona
            // 
            this.chartDona.BackSecondaryColor = System.Drawing.Color.White;
            this.chartDona.BorderSkin.BackColor = System.Drawing.Color.DarkRed;
            chartArea4.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea4.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea4.AxisX.IsLabelAutoFit = false;
            chartArea4.AxisX.IsStartedFromZero = false;
            chartArea4.AxisX.LabelStyle.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisX.Maximum = 7D;
            chartArea4.AxisX.MaximumAutoSize = 90F;
            chartArea4.AxisX.Minimum = 1D;
            chartArea4.AxisX.ScrollBar.Enabled = false;
            chartArea4.AxisX.ScrollBar.Size = 6D;
            chartArea4.AxisX.TitleFont = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea4.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea4.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea4.AxisY.IsLabelAutoFit = false;
            chartArea4.AxisY.IsMarginVisible = false;
            chartArea4.AxisY.IsMarksNextToAxis = false;
            chartArea4.AxisY.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)(((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep45) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea4.AxisY.LabelStyle.Font = new System.Drawing.Font("Roboto Medium", 8F);
            chartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea4.AxisY.LineColor = System.Drawing.Color.White;
            chartArea4.AxisY.MajorGrid.Enabled = false;
            chartArea4.AxisY.TitleFont = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea4.BorderColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            chartArea4.Position.Auto = false;
            chartArea4.Position.Height = 80F;
            chartArea4.Position.Width = 80F;
            chartArea4.Position.X = 3F;
            chartArea4.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chartDona.ChartAreas.Add(chartArea4);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.DockedToChartArea = "ChartArea1";
            legend2.Font = new System.Drawing.Font("Roboto Medium", 8F);
            legend2.IsDockedInsideChartArea = false;
            legend2.IsEquallySpacedItems = true;
            legend2.IsTextAutoFit = false;
            legend2.ItemColumnSpacing = 1;
            legend2.LegendItemOrder = System.Windows.Forms.DataVisualization.Charting.LegendItemOrder.SameAsSeriesOrder;
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend2.MaximumAutoSize = 100F;
            legend2.Name = "Legend1";
            legend2.Position.Auto = false;
            legend2.Position.Height = 8.363636F;
            legend2.Position.Width = 30F;
            legend2.Position.X = 70F;
            legend2.Position.Y = 1F;
            legend2.TextWrapThreshold = 30;
            this.chartDona.Legends.Add(legend2);
            this.chartDona.Location = new System.Drawing.Point(-37, 51);
            this.chartDona.Name = "chartDona";
            this.chartDona.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartDona.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(82))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(129))))),
        System.Drawing.Color.DarkTurquoise};
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Color = System.Drawing.Color.White;
            series4.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.IsValueShownAsLabel = true;
            series4.IsVisibleInLegend = false;
            series4.LabelForeColor = System.Drawing.Color.White;
            series4.Legend = "Legend1";
            series4.MarkerBorderWidth = 4;
            series4.Name = "Series1";
            series4.SmartLabelStyle.Enabled = false;
            this.chartDona.Series.Add(series4);
            this.chartDona.Size = new System.Drawing.Size(349, 276);
            this.chartDona.TabIndex = 27;
            this.chartDona.Text = "chart2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Categoría Mas Populares";
            // 
            // sPanel1
            // 
            this.sPanel1.BackColor = System.Drawing.Color.White;
            this.sPanel1.BorderColor = System.Drawing.Color.White;
            this.sPanel1.BorderRadius = 15;
            this.sPanel1.BorderSize = 1;
            this.sPanel1.Controls.Add(this.chart1);
            this.sPanel1.Controls.Add(this.label4);
            this.sPanel1.ForeColor = System.Drawing.Color.White;
            this.sPanel1.Location = new System.Drawing.Point(17, 74);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Size = new System.Drawing.Size(631, 301);
            this.sPanel1.TabIndex = 72;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.chart1.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.DarkRed;
            chartArea5.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea5.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea5.AxisX.IsLabelAutoFit = false;
            chartArea5.AxisX.IsMarginVisible = false;
            chartArea5.AxisX.IsStartedFromZero = false;
            chartArea5.AxisX.LabelStyle.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea5.AxisX.MajorGrid.Enabled = false;
            chartArea5.AxisX.MaximumAutoSize = 90F;
            chartArea5.AxisX.ScrollBar.Enabled = false;
            chartArea5.AxisX.ScrollBar.Size = 6D;
            chartArea5.AxisX.TitleFont = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea5.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea5.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea5.AxisY.IsLabelAutoFit = false;
            chartArea5.AxisY.IsMarksNextToAxis = false;
            chartArea5.AxisY.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)(((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep45) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea5.AxisY.LabelStyle.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea5.AxisY.MajorGrid.Enabled = false;
            chartArea5.AxisY.TitleFont = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea5.BackColor = System.Drawing.Color.Transparent;
            chartArea5.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea5.BorderColor = System.Drawing.Color.Transparent;
            chartArea5.Name = "ChartArea1";
            chartArea5.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chart1.ChartAreas.Add(chartArea5);
            this.chart1.Location = new System.Drawing.Point(-23, 36);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))))};
            series5.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series5.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            series5.BorderColor = System.Drawing.Color.Navy;
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(200)))));
            series5.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series5.IsValueShownAsLabel = true;
            series5.IsVisibleInLegend = false;
            series5.IsXValueIndexed = true;
            series5.LabelFormat = "        $ {0:N2}";
            series5.MarkerBorderWidth = 4;
            series5.Name = "Series1";
            series5.SmartLabelStyle.Enabled = false;
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(637, 267);
            this.chart1.TabIndex = 26;
            this.chart1.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Total Recaudado";
            // 
            // sPanel3
            // 
            this.sPanel3.BackColor = System.Drawing.Color.White;
            this.sPanel3.BorderColor = System.Drawing.Color.White;
            this.sPanel3.BorderRadius = 10;
            this.sPanel3.BorderSize = 0;
            this.sPanel3.Controls.Add(this.dtpHasta);
            this.sPanel3.ForeColor = System.Drawing.Color.White;
            this.sPanel3.Location = new System.Drawing.Point(800, 17);
            this.sPanel3.Name = "sPanel3";
            this.sPanel3.Size = new System.Drawing.Size(195, 46);
            this.sPanel3.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(749, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 75;
            this.label1.Text = "Hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(464, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 74;
            this.label2.Text = "Desde:";
            // 
            // sPanel4
            // 
            this.sPanel4.BackColor = System.Drawing.Color.White;
            this.sPanel4.BorderColor = System.Drawing.Color.White;
            this.sPanel4.BorderRadius = 10;
            this.sPanel4.BorderSize = 0;
            this.sPanel4.ForeColor = System.Drawing.Color.White;
            this.sPanel4.Location = new System.Drawing.Point(518, 17);
            this.sPanel4.Name = "sPanel4";
            this.sPanel4.Size = new System.Drawing.Size(195, 46);
            this.sPanel4.TabIndex = 77;
            // 
            // sPanel5
            // 
            this.sPanel5.BackColor = System.Drawing.Color.White;
            this.sPanel5.BorderColor = System.Drawing.Color.White;
            this.sPanel5.BorderRadius = 15;
            this.sPanel5.BorderSize = 1;
            this.sPanel5.Controls.Add(this.chart2);
            this.sPanel5.Controls.Add(this.label5);
            this.sPanel5.ForeColor = System.Drawing.Color.White;
            this.sPanel5.Location = new System.Drawing.Point(17, 392);
            this.sPanel5.Name = "sPanel5";
            this.sPanel5.Size = new System.Drawing.Size(631, 265);
            this.sPanel5.TabIndex = 73;
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            this.chart2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.chart2.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chart2.BorderSkin.BackColor = System.Drawing.Color.DarkRed;
            chartArea6.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea6.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea6.AxisX.IsLabelAutoFit = false;
            chartArea6.AxisX.IsMarginVisible = false;
            chartArea6.AxisX.IsStartedFromZero = false;
            chartArea6.AxisX.LabelStyle.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea6.AxisX.MajorGrid.Enabled = false;
            chartArea6.AxisX.MaximumAutoSize = 95F;
            chartArea6.AxisX.ScaleBreakStyle.Spacing = 1D;
            chartArea6.AxisX.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.Yes;
            chartArea6.AxisX.ScrollBar.Enabled = false;
            chartArea6.AxisX.ScrollBar.Size = 6D;
            chartArea6.AxisX.TitleFont = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea6.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea6.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea6.AxisY.IsLabelAutoFit = false;
            chartArea6.AxisY.IsMarginVisible = false;
            chartArea6.AxisY.IsMarksNextToAxis = false;
            chartArea6.AxisY.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)(((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep45) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea6.AxisY.LabelStyle.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea6.AxisY.MajorGrid.Enabled = false;
            chartArea6.AxisY.TitleFont = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea6.BackColor = System.Drawing.Color.Transparent;
            chartArea6.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea6.BorderColor = System.Drawing.Color.Transparent;
            chartArea6.Name = "ChartArea1";
            chartArea6.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chart2.ChartAreas.Add(chartArea6);
            this.chart2.Location = new System.Drawing.Point(-15, 34);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart2.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))))};
            series6.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series6.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            series6.BorderColor = System.Drawing.Color.Navy;
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(200)))));
            series6.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series6.IsVisibleInLegend = false;
            series6.IsXValueIndexed = true;
            series6.MarkerBorderWidth = 4;
            series6.Name = "Series1";
            series6.Points.Add(dataPoint8);
            series6.Points.Add(dataPoint9);
            series6.Points.Add(dataPoint10);
            series6.Points.Add(dataPoint11);
            series6.Points.Add(dataPoint12);
            series6.Points.Add(dataPoint13);
            series6.Points.Add(dataPoint14);
            series6.SmartLabelStyle.Enabled = false;
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series6.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(646, 235);
            this.chart2.TabIndex = 26;
            this.chart2.Text = "chart2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(21, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Cantidad Ventas";
            // 
            // sPanel6
            // 
            this.sPanel6.BackColor = System.Drawing.Color.White;
            this.sPanel6.BorderColor = System.Drawing.Color.White;
            this.sPanel6.BorderRadius = 15;
            this.sPanel6.BorderSize = 1;
            this.sPanel6.Controls.Add(this.lblIngresoPromedio);
            this.sPanel6.Controls.Add(this.label7);
            this.sPanel6.ForeColor = System.Drawing.Color.White;
            this.sPanel6.Location = new System.Drawing.Point(675, 389);
            this.sPanel6.Name = "sPanel6";
            this.sPanel6.Size = new System.Drawing.Size(320, 120);
            this.sPanel6.TabIndex = 74;
            // 
            // lblIngresoPromedio
            // 
            this.lblIngresoPromedio.AutoSize = true;
            this.lblIngresoPromedio.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Bold);
            this.lblIngresoPromedio.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblIngresoPromedio.Location = new System.Drawing.Point(8, 44);
            this.lblIngresoPromedio.Name = "lblIngresoPromedio";
            this.lblIngresoPromedio.Size = new System.Drawing.Size(73, 52);
            this.lblIngresoPromedio.TabIndex = 23;
            this.lblIngresoPromedio.Text = "$0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(14, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "Promedio De Ingreso Diario";
            // 
            // sPanel7
            // 
            this.sPanel7.BackColor = System.Drawing.Color.White;
            this.sPanel7.BorderColor = System.Drawing.Color.White;
            this.sPanel7.BorderRadius = 15;
            this.sPanel7.BorderSize = 1;
            this.sPanel7.Controls.Add(this.lblPromedioCantidad);
            this.sPanel7.Controls.Add(this.label10);
            this.sPanel7.ForeColor = System.Drawing.Color.White;
            this.sPanel7.Location = new System.Drawing.Point(675, 537);
            this.sPanel7.Name = "sPanel7";
            this.sPanel7.Size = new System.Drawing.Size(320, 120);
            this.sPanel7.TabIndex = 75;
            // 
            // lblPromedioCantidad
            // 
            this.lblPromedioCantidad.AutoSize = true;
            this.lblPromedioCantidad.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Bold);
            this.lblPromedioCantidad.ForeColor = System.Drawing.Color.Navy;
            this.lblPromedioCantidad.Location = new System.Drawing.Point(9, 44);
            this.lblPromedioCantidad.Name = "lblPromedioCantidad";
            this.lblPromedioCantidad.Size = new System.Drawing.Size(73, 52);
            this.lblPromedioCantidad.TabIndex = 23;
            this.lblPromedioCantidad.Text = "47";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(14, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(210, 19);
            this.label10.TabIndex = 22;
            this.label10.Text = "Promedio De Ventas Diarias";
            // 
            // dtpHasta
            // 
            this.dtpHasta.BorderColor = System.Drawing.Color.Black;
            this.dtpHasta.BorderSize = 0;
            this.dtpHasta.CalendarFont = new System.Drawing.Font("Roboto Medium", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Font = new System.Drawing.Font("Roboto Medium", 10.5F);
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(4, 7);
            this.dtpHasta.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(188, 35);
            this.dtpHasta.SkinColor = System.Drawing.Color.White;
            this.dtpHasta.TabIndex = 74;
            this.dtpHasta.TextColor = System.Drawing.Color.Black;
            this.dtpHasta.Value = new System.DateTime(2024, 11, 2, 0, 0, 0, 0);
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // dtpDesde
            // 
            this.dtpDesde.BorderColor = System.Drawing.Color.Black;
            this.dtpDesde.BorderSize = 0;
            this.dtpDesde.CalendarFont = new System.Drawing.Font("Roboto Medium", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Font = new System.Drawing.Font("Roboto Medium", 10.5F);
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(522, 24);
            this.dtpDesde.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(188, 35);
            this.dtpDesde.SkinColor = System.Drawing.Color.White;
            this.dtpDesde.TabIndex = 76;
            this.dtpDesde.TextColor = System.Drawing.Color.Black;
            this.dtpDesde.Value = new System.DateTime(2024, 10, 29, 0, 0, 0, 0);
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // SalesReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.sPanel7);
            this.Controls.Add(this.sPanel6);
            this.Controls.Add(this.sPanel5);
            this.Controls.Add(this.sPanel3);
            this.Controls.Add(this.sPanel2);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.sPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sPanel4);
            this.Location = new System.Drawing.Point(16, 15);
            this.Name = "SalesReportsForm";
            this.Size = new System.Drawing.Size(1014, 681);
            this.Load += new System.EventHandler(this.SalesReportsForm_Load);
            this.sPanel2.ResumeLayout(false);
            this.sPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDona)).EndInit();
            this.sPanel1.ResumeLayout(false);
            this.sPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.sPanel3.ResumeLayout(false);
            this.sPanel5.ResumeLayout(false);
            this.sPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.sPanel6.ResumeLayout(false);
            this.sPanel6.PerformLayout();
            this.sPanel7.ResumeLayout(false);
            this.sPanel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private Sipaa.Framework.SPanel sPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDona;
        private Sipaa.Framework.SPanel sPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label4;
        private Sipaa.Framework.SPanel sPanel3;
        private TheCoffe.Components.CustomDateTimePicker dtpHasta;
        private TheCoffe.Components.CustomDateTimePicker dtpDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Sipaa.Framework.SPanel sPanel4;
        private Sipaa.Framework.SPanel sPanel5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label5;
        private Sipaa.Framework.SPanel sPanel6;
        private System.Windows.Forms.Label lblIngresoPromedio;
        private System.Windows.Forms.Label label7;
        private Sipaa.Framework.SPanel sPanel7;
        private System.Windows.Forms.Label lblPromedioCantidad;
        private System.Windows.Forms.Label label10;
    }
}
