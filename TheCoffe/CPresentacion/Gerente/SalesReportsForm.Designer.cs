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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roundButton1 = new WindowsFormsApplication1.RoundButton();
            this.label6 = new System.Windows.Forms.Label();
            this.sPanel2 = new Sipaa.Framework.SPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.chartDona = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sPanel1 = new Sipaa.Framework.SPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDona)).BeginInit();
            this.sPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 158);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(134, 23);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(188, 158);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(134, 23);
            this.dateTimePicker2.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Hasta:";
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.roundButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.roundButton1.BorderColor = System.Drawing.Color.Transparent;
            this.roundButton1.BorderRadius = 10;
            this.roundButton1.BorderSize = 0;
            this.roundButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.roundButton1.IconColor = System.Drawing.Color.DimGray;
            this.roundButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.roundButton1.IconSize = 35;
            this.roundButton1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.roundButton1.Location = new System.Drawing.Point(362, 153);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(100, 30);
            this.roundButton1.TabIndex = 30;
            this.roundButton1.Tag = "";
            this.roundButton1.Text = "Filtrar";
            this.roundButton1.TextColor = System.Drawing.Color.White;
            this.roundButton1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 15);
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
            this.sPanel2.Controls.Add(this.label3);
            this.sPanel2.Controls.Add(this.chartDona);
            this.sPanel2.ForeColor = System.Drawing.Color.White;
            this.sPanel2.Location = new System.Drawing.Point(773, 200);
            this.sPanel2.Name = "sPanel2";
            this.sPanel2.Size = new System.Drawing.Size(230, 313);
            this.sPanel2.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ventas Por Categoría";
            // 
            // chartDona
            // 
            this.chartDona.BackSecondaryColor = System.Drawing.Color.White;
            this.chartDona.BorderSkin.BackColor = System.Drawing.Color.DarkRed;
            chartArea3.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea3.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.IsStartedFromZero = false;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.Maximum = 7D;
            chartArea3.AxisX.MaximumAutoSize = 90F;
            chartArea3.AxisX.Minimum = 1D;
            chartArea3.AxisX.ScrollBar.Enabled = false;
            chartArea3.AxisX.ScrollBar.Size = 6D;
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea3.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea3.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.IsMarginVisible = false;
            chartArea3.AxisY.IsMarksNextToAxis = false;
            chartArea3.AxisY.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)(((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep45) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Roboto Medium", 8F);
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisY.LineColor = System.Drawing.Color.White;
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea3.BorderColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            chartArea3.Position.Auto = false;
            chartArea3.Position.Height = 85F;
            chartArea3.Position.Width = 85F;
            chartArea3.Position.X = 3F;
            chartArea3.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chartDona.ChartAreas.Add(chartArea3);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.DockedToChartArea = "ChartArea1";
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Font = new System.Drawing.Font("Roboto Medium", 8F);
            legend2.IsDockedInsideChartArea = false;
            legend2.IsEquallySpacedItems = true;
            legend2.IsTextAutoFit = false;
            legend2.ItemColumnSpacing = 1;
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend2.MaximumAutoSize = 100F;
            legend2.Name = "Legend1";
            legend2.Position.Auto = false;
            legend2.Position.Height = 15F;
            legend2.Position.Width = 100F;
            legend2.Position.Y = 80F;
            legend2.TextWrapThreshold = 30;
            this.chartDona.Legends.Add(legend2);
            this.chartDona.Location = new System.Drawing.Point(1, 34);
            this.chartDona.Name = "chartDona";
            this.chartDona.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartDona.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(82))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(129)))))};
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Color = System.Drawing.Color.White;
            series3.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.IsValueShownAsLabel = true;
            series3.IsVisibleInLegend = false;
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.MarkerBorderWidth = 4;
            series3.Name = "Series1";
            series3.SmartLabelStyle.Enabled = false;
            this.chartDona.Series.Add(series3);
            this.chartDona.Size = new System.Drawing.Size(252, 290);
            this.chartDona.TabIndex = 27;
            this.chartDona.Text = "chart2";
            // 
            // sPanel1
            // 
            this.sPanel1.BackColor = System.Drawing.Color.White;
            this.sPanel1.BorderColor = System.Drawing.Color.White;
            this.sPanel1.BorderRadius = 15;
            this.sPanel1.BorderSize = 1;
            this.sPanel1.Controls.Add(this.chart1);
            this.sPanel1.Controls.Add(this.iconButton4);
            this.sPanel1.Controls.Add(this.label5);
            this.sPanel1.Controls.Add(this.label4);
            this.sPanel1.ForeColor = System.Drawing.Color.White;
            this.sPanel1.Location = new System.Drawing.Point(25, 200);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Size = new System.Drawing.Size(726, 315);
            this.sPanel1.TabIndex = 72;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.chart1.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.DarkRed;
            chartArea4.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea4.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea4.AxisX.IsLabelAutoFit = false;
            chartArea4.AxisX.IsMarginVisible = false;
            chartArea4.AxisX.IsStartedFromZero = false;
            chartArea4.AxisX.LabelStyle.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisX.MaximumAutoSize = 90F;
            chartArea4.AxisX.Minimum = 1D;
            chartArea4.AxisX.ScrollBar.Enabled = false;
            chartArea4.AxisX.ScrollBar.Size = 6D;
            chartArea4.AxisX.TitleFont = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea4.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea4.AxisY.IsLabelAutoFit = false;
            chartArea4.AxisY.IsMarksNextToAxis = false;
            chartArea4.AxisY.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)(((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep45) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea4.AxisY.LabelStyle.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisY.MajorGrid.Enabled = false;
            chartArea4.AxisY.TitleFont = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea4.BorderColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            chartArea4.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Location = new System.Drawing.Point(-22, 65);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))))};
            series4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series4.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            series4.BorderColor = System.Drawing.Color.Navy;
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(200)))));
            series4.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.IsVisibleInLegend = false;
            series4.IsXValueIndexed = true;
            series4.MarkerBorderWidth = 4;
            series4.Name = "Series1";
            series4.SmartLabelStyle.Enabled = false;
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(771, 258);
            this.chart1.TabIndex = 26;
            this.chart1.Text = "chart1";
            // 
            // iconButton4
            // 
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.iconButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Roboto", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.Black;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 13;
            this.iconButton4.Location = new System.Drawing.Point(17, 49);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(157, 23);
            this.iconButton4.TabIndex = 24;
            this.iconButton4.Text = "2.1% vs última semana";
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.label5.Location = new System.Drawing.Point(21, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "2.548";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ventas Diarias";
            // 
            // SalesReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.sPanel2);
            this.Controls.Add(this.sPanel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Location = new System.Drawing.Point(16, 15);
            this.Name = "SalesReportsForm";
            this.Size = new System.Drawing.Size(1030, 720);
            this.sPanel2.ResumeLayout(false);
            this.sPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDona)).EndInit();
            this.sPanel1.ResumeLayout(false);
            this.sPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private WindowsFormsApplication1.RoundButton roundButton1;
        private System.Windows.Forms.Label label6;
        private Sipaa.Framework.SPanel sPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDona;
        private Sipaa.Framework.SPanel sPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}
