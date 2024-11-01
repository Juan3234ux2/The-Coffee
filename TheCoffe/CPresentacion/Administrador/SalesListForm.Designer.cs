using TheCoffe;
using TheCoffe.CPresentacion.Components;

namespace TheCoffe.CPresentacion
{
    partial class SalesListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataSales = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sPanel1 = new Sipaa.Framework.SPanel();
            this.sPanel2 = new Sipaa.Framework.SPanel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnMesero = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.lblPagina = new System.Windows.Forms.Label();
            this.btnSig = new WindowsFormsApplication1.RoundButton();
            this.btnAnt = new WindowsFormsApplication1.RoundButton();
            this.dtpFechaHasta = new TheCoffe.Components.CustomDateTimePicker();
            this.dtpFechaDesde = new TheCoffe.Components.CustomDateTimePicker();
            this.cboMesero = new TheCoffe.CPresentacion.Components.CustomComboBox();
            this.modernTextBox2 = new TheCoffe.Components.ModernTextBox();
            this.modernTextBox1 = new TheCoffe.Components.ModernTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSales)).BeginInit();
            this.sPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSales
            // 
            this.dataSales.AllowUserToAddRows = false;
            this.dataSales.AllowUserToDeleteRows = false;
            this.dataSales.AllowUserToResizeColumns = false;
            this.dataSales.AllowUserToResizeRows = false;
            this.dataSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataSales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataSales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Medium", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataSales.ColumnHeadersHeight = 45;
            this.dataSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Precio,
            this.Categoria,
            this.total,
            this.detalle});
            this.dataSales.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataSales.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataSales.EnableHeadersVisualStyles = false;
            this.dataSales.GridColor = System.Drawing.Color.Silver;
            this.dataSales.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataSales.Location = new System.Drawing.Point(19, 139);
            this.dataSales.MultiSelect = false;
            this.dataSales.Name = "dataSales";
            this.dataSales.ReadOnly = true;
            this.dataSales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataSales.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataSales.RowHeadersVisible = false;
            this.dataSales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataSales.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataSales.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataSales.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataSales.RowTemplate.DividerHeight = 1;
            this.dataSales.RowTemplate.Height = 45;
            this.dataSales.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataSales.ShowCellErrors = false;
            this.dataSales.ShowCellToolTips = false;
            this.dataSales.ShowEditingIcon = false;
            this.dataSales.ShowRowErrors = false;
            this.dataSales.Size = new System.Drawing.Size(976, 479);
            this.dataSales.TabIndex = 17;
            this.dataSales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSales_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_ventas";
            this.ID.FillWeight = 34.31406F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "mesero";
            this.Nombre.FillWeight = 136.5347F;
            this.Nombre.HeaderText = "Mesero";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "fecha";
            this.Precio.FillWeight = 104.2719F;
            this.Precio.HeaderText = "Fecha";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "hora";
            this.Categoria.FillWeight = 98.82233F;
            this.Categoria.HeaderText = "Hora";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // total
            // 
            this.total.DataPropertyName = "monto_total";
            this.total.FillWeight = 137.6426F;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // detalle
            // 
            this.detalle.FillWeight = 51.7368F;
            this.detalle.HeaderText = "Detalle";
            this.detalle.Image = global::TheCoffe.Properties.Resources.detalle;
            this.detalle.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.detalle.Name = "detalle";
            this.detalle.ReadOnly = true;
            this.detalle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 41);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 63;
            this.label2.Text = "Filtar por Mesero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(801, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 70;
            this.label3.Text = "Hasta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(585, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 69;
            this.label4.Text = "Desde:";
            // 
            // sPanel1
            // 
            this.sPanel1.BackColor = System.Drawing.Color.White;
            this.sPanel1.BorderColor = System.Drawing.Color.White;
            this.sPanel1.BorderRadius = 10;
            this.sPanel1.BorderSize = 0;
            this.sPanel1.ForeColor = System.Drawing.Color.White;
            this.sPanel1.Location = new System.Drawing.Point(584, 74);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Size = new System.Drawing.Size(195, 46);
            this.sPanel1.TabIndex = 72;
            // 
            // sPanel2
            // 
            this.sPanel2.BackColor = System.Drawing.Color.White;
            this.sPanel2.BorderColor = System.Drawing.Color.White;
            this.sPanel2.BorderRadius = 10;
            this.sPanel2.BorderSize = 0;
            this.sPanel2.Controls.Add(this.dtpFechaHasta);
            this.sPanel2.ForeColor = System.Drawing.Color.White;
            this.sPanel2.Location = new System.Drawing.Point(800, 74);
            this.sPanel2.Name = "sPanel2";
            this.sPanel2.Size = new System.Drawing.Size(195, 46);
            this.sPanel2.TabIndex = 73;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 70.1602F;
            this.dataGridViewImageColumn1.HeaderText = "Detalle";
            this.dataGridViewImageColumn1.Image = global::TheCoffe.Properties.Resources.detalle;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 121;
            // 
            // btnMesero
            // 
            this.btnMesero.BackColor = System.Drawing.SystemColors.Window;
            this.btnMesero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMesero.FlatAppearance.BorderSize = 0;
            this.btnMesero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMesero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMesero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesero.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.btnMesero.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnMesero.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMesero.IconSize = 25;
            this.btnMesero.Location = new System.Drawing.Point(525, 82);
            this.btnMesero.Name = "btnMesero";
            this.btnMesero.Size = new System.Drawing.Size(33, 35);
            this.btnMesero.TabIndex = 66;
            this.btnMesero.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMesero.UseVisualStyleBackColor = false;
            this.btnMesero.Click += new System.EventHandler(this.btnMesero_Click);
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.White;
            this.iconButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.iconButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton5.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 25;
            this.iconButton5.Location = new System.Drawing.Point(270, 82);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(38, 32);
            this.iconButton5.TabIndex = 19;
            this.iconButton5.UseVisualStyleBackColor = false;
            // 
            // lblPagina
            // 
            this.lblPagina.AutoSize = true;
            this.lblPagina.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagina.Location = new System.Drawing.Point(842, 631);
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(102, 17);
            this.lblPagina.TabIndex = 74;
            this.lblPagina.Text = "Pagina 1 de 10";
            // 
            // btnSig
            // 
            this.btnSig.BackColor = System.Drawing.Color.Transparent;
            this.btnSig.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSig.BorderColor = System.Drawing.Color.Black;
            this.btnSig.BorderRadius = 20;
            this.btnSig.BorderSize = 0;
            this.btnSig.FlatAppearance.BorderSize = 0;
            this.btnSig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnSig.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.btnSig.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnSig.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSig.Location = new System.Drawing.Point(949, 621);
            this.btnSig.Name = "btnSig";
            this.btnSig.Size = new System.Drawing.Size(25, 40);
            this.btnSig.TabIndex = 76;
            this.btnSig.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnSig.UseVisualStyleBackColor = false;
            this.btnSig.Click += new System.EventHandler(this.btnSig_Click);
            // 
            // btnAnt
            // 
            this.btnAnt.BackColor = System.Drawing.Color.Transparent;
            this.btnAnt.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAnt.BorderColor = System.Drawing.Color.Black;
            this.btnAnt.BorderRadius = 20;
            this.btnAnt.BorderSize = 0;
            this.btnAnt.FlatAppearance.BorderSize = 0;
            this.btnAnt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnAnt.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.btnAnt.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnAnt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAnt.Location = new System.Drawing.Point(812, 621);
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Size = new System.Drawing.Size(25, 40);
            this.btnAnt.TabIndex = 75;
            this.btnAnt.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnAnt.UseVisualStyleBackColor = false;
            this.btnAnt.Click += new System.EventHandler(this.btnAnt_Click);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.BorderColor = System.Drawing.Color.Black;
            this.dtpFechaHasta.BorderSize = 0;
            this.dtpFechaHasta.CalendarFont = new System.Drawing.Font("Roboto Medium", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHasta.Font = new System.Drawing.Font("Roboto Medium", 10.5F);
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(4, 7);
            this.dtpFechaHasta.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(188, 35);
            this.dtpFechaHasta.SkinColor = System.Drawing.Color.White;
            this.dtpFechaHasta.TabIndex = 74;
            this.dtpFechaHasta.TextColor = System.Drawing.Color.Black;
            this.dtpFechaHasta.ValueChanged += new System.EventHandler(this.dtpFechaDesde_ValueChanged);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.BorderColor = System.Drawing.Color.Black;
            this.dtpFechaDesde.BorderSize = 0;
            this.dtpFechaDesde.CalendarFont = new System.Drawing.Font("Roboto Medium", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDesde.Font = new System.Drawing.Font("Roboto Medium", 10.5F);
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(588, 81);
            this.dtpFechaDesde.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(188, 35);
            this.dtpFechaDesde.SkinColor = System.Drawing.Color.White;
            this.dtpFechaDesde.TabIndex = 71;
            this.dtpFechaDesde.TextColor = System.Drawing.Color.Black;
            this.dtpFechaDesde.Value = new System.DateTime(2024, 10, 29, 0, 0, 0, 0);
            this.dtpFechaDesde.ValueChanged += new System.EventHandler(this.dtpFechaDesde_ValueChanged);
            // 
            // cboMesero
            // 
            this.cboMesero.BackColor = System.Drawing.SystemColors.Window;
            this.cboMesero.BorderColor = System.Drawing.Color.White;
            this.cboMesero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboMesero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMesero.DropDownWidth = 226;
            this.cboMesero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMesero.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMesero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboMesero.FormattingEnabled = true;
            this.cboMesero.Items.AddRange(new object[] {
            "Emilia",
            "Juan",
            "Facundo"});
            this.cboMesero.Location = new System.Drawing.Point(339, 85);
            this.cboMesero.Name = "cboMesero";
            this.cboMesero.Size = new System.Drawing.Size(193, 24);
            this.cboMesero.TabIndex = 65;
            // 
            // modernTextBox2
            // 
            this.modernTextBox2.BackColor = System.Drawing.Color.White;
            this.modernTextBox2.BorderColor = System.Drawing.Color.Transparent;
            this.modernTextBox2.BorderFocusColor = System.Drawing.Color.Transparent;
            this.modernTextBox2.BorderRadius = 10;
            this.modernTextBox2.BorderSize = 1;
            this.modernTextBox2.Enabled = false;
            this.modernTextBox2.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modernTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modernTextBox2.Location = new System.Drawing.Point(331, 74);
            this.modernTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.modernTextBox2.Multiline = false;
            this.modernTextBox2.Name = "modernTextBox2";
            this.modernTextBox2.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.modernTextBox2.PasswordChar = false;
            this.modernTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.modernTextBox2.PlaceholderText = "";
            this.modernTextBox2.Size = new System.Drawing.Size(232, 46);
            this.modernTextBox2.TabIndex = 64;
            this.modernTextBox2.Texts = "";
            this.modernTextBox2.UnderlinedStyle = false;
            // 
            // modernTextBox1
            // 
            this.modernTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.modernTextBox1.BorderColor = System.Drawing.Color.Transparent;
            this.modernTextBox1.BorderFocusColor = System.Drawing.Color.Black;
            this.modernTextBox1.BorderRadius = 10;
            this.modernTextBox1.BorderSize = 1;
            this.modernTextBox1.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modernTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modernTextBox1.Location = new System.Drawing.Point(19, 74);
            this.modernTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.modernTextBox1.Multiline = false;
            this.modernTextBox1.Name = "modernTextBox1";
            this.modernTextBox1.Padding = new System.Windows.Forms.Padding(10, 16, 10, 7);
            this.modernTextBox1.PasswordChar = false;
            this.modernTextBox1.PlaceholderColor = System.Drawing.Color.DimGray;
            this.modernTextBox1.PlaceholderText = "Buscar...";
            this.modernTextBox1.Size = new System.Drawing.Size(291, 44);
            this.modernTextBox1.TabIndex = 18;
            this.modernTextBox1.Texts = "";
            this.modernTextBox1.UnderlinedStyle = false;
            // 
            // SalesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.btnSig);
            this.Controls.Add(this.btnAnt);
            this.Controls.Add(this.lblPagina);
            this.Controls.Add(this.sPanel2);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMesero);
            this.Controls.Add(this.cboMesero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modernTextBox2);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.modernTextBox1);
            this.Controls.Add(this.dataSales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sPanel1);
            this.Name = "SalesListForm";
            this.Size = new System.Drawing.Size(1014, 681);
            this.Load += new System.EventHandler(this.SalesListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSales)).EndInit();
            this.sPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton5;
        private TheCoffe.Components.ModernTextBox modernTextBox1;
        private System.Windows.Forms.DataGridView dataSales;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnMesero;
        private CustomComboBox cboMesero;
        private System.Windows.Forms.Label label2;
        private TheCoffe.Components.ModernTextBox modernTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private TheCoffe.Components.CustomDateTimePicker dtpFechaDesde;
        private Sipaa.Framework.SPanel sPanel1;
        private Sipaa.Framework.SPanel sPanel2;
        private TheCoffe.Components.CustomDateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewImageColumn detalle;
        private WindowsFormsApplication1.RoundButton btnSig;
        private WindowsFormsApplication1.RoundButton btnAnt;
        private System.Windows.Forms.Label lblPagina;
    }
}
