namespace TheCoffe.CPresentacion.Gerente
{
    partial class ListClosingBoxForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListClosingBoxForm));
            this.dataClosingBox = new System.Windows.Forms.DataGridView();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_apertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_cierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto_inicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblClosingBoxList = new System.Windows.Forms.Label();
            this.btnSig = new WindowsFormsApplication1.RoundButton();
            this.btnAnt = new WindowsFormsApplication1.RoundButton();
            this.lblPagina = new System.Windows.Forms.Label();
            this.sPanel2 = new Sipaa.Framework.SPanel();
            this.dtpFechaHasta = new TheCoffe.Components.CustomDateTimePicker();
            this.dtpFechaDesde = new TheCoffe.Components.CustomDateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUsuario = new FontAwesome.Sharp.IconButton();
            this.cboUsers = new TheCoffe.CPresentacion.Components.CustomComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.modernTextBox2 = new TheCoffe.Components.ModernTextBox();
            this.sPanel1 = new Sipaa.Framework.SPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataClosingBox)).BeginInit();
            this.sPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataClosingBox
            // 
            this.dataClosingBox.AllowUserToAddRows = false;
            this.dataClosingBox.AllowUserToDeleteRows = false;
            this.dataClosingBox.AllowUserToResizeColumns = false;
            this.dataClosingBox.AllowUserToResizeRows = false;
            this.dataClosingBox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataClosingBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataClosingBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataClosingBox.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataClosingBox.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Medium", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataClosingBox.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataClosingBox.ColumnHeadersHeight = 45;
            this.dataClosingBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataClosingBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_usuario,
            this.Usuario,
            this.fecha_apertura,
            this.fecha_cierre,
            this.monto_inicial,
            this.detalle});
            this.dataClosingBox.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataClosingBox.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataClosingBox.EnableHeadersVisualStyles = false;
            this.dataClosingBox.GridColor = System.Drawing.Color.Silver;
            this.dataClosingBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataClosingBox.Location = new System.Drawing.Point(19, 139);
            this.dataClosingBox.MultiSelect = false;
            this.dataClosingBox.Name = "dataClosingBox";
            this.dataClosingBox.ReadOnly = true;
            this.dataClosingBox.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataClosingBox.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataClosingBox.RowHeadersVisible = false;
            this.dataClosingBox.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataClosingBox.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataClosingBox.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataClosingBox.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataClosingBox.RowTemplate.DividerHeight = 1;
            this.dataClosingBox.RowTemplate.Height = 45;
            this.dataClosingBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataClosingBox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataClosingBox.ShowCellErrors = false;
            this.dataClosingBox.ShowCellToolTips = false;
            this.dataClosingBox.ShowEditingIcon = false;
            this.dataClosingBox.ShowRowErrors = false;
            this.dataClosingBox.Size = new System.Drawing.Size(978, 479);
            this.dataClosingBox.TabIndex = 32;
            this.dataClosingBox.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataClosingBox_CellClick);
            // 
            // id_usuario
            // 
            this.id_usuario.DataPropertyName = "id_turno";
            this.id_usuario.FillWeight = 63.77905F;
            this.id_usuario.HeaderText = "ID";
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "c";
            this.Usuario.FillWeight = 105.0722F;
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // fecha_apertura
            // 
            this.fecha_apertura.DataPropertyName = "fechaApertura";
            this.fecha_apertura.FillWeight = 105.0722F;
            this.fecha_apertura.HeaderText = "Fecha de Apertura";
            this.fecha_apertura.Name = "fecha_apertura";
            this.fecha_apertura.ReadOnly = true;
            // 
            // fecha_cierre
            // 
            this.fecha_cierre.DataPropertyName = "fechaCierre";
            this.fecha_cierre.FillWeight = 105.0722F;
            this.fecha_cierre.HeaderText = "Fecha de cierre";
            this.fecha_cierre.Name = "fecha_cierre";
            this.fecha_cierre.ReadOnly = true;
            // 
            // monto_inicial
            // 
            this.monto_inicial.DataPropertyName = "monto_inicial";
            this.monto_inicial.HeaderText = "Monto Inicial";
            this.monto_inicial.Name = "monto_inicial";
            this.monto_inicial.ReadOnly = true;
            // 
            // detalle
            // 
            this.detalle.FillWeight = 39.82016F;
            this.detalle.HeaderText = "Detalle";
            this.detalle.Image = ((System.Drawing.Image)(resources.GetObject("detalle.Image")));
            this.detalle.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.detalle.Name = "detalle";
            this.detalle.ReadOnly = true;
            this.detalle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // lblClosingBoxList
            // 
            this.lblClosingBoxList.AutoSize = true;
            this.lblClosingBoxList.Font = new System.Drawing.Font("Roboto", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClosingBoxList.Location = new System.Drawing.Point(12, 15);
            this.lblClosingBoxList.Name = "lblClosingBoxList";
            this.lblClosingBoxList.Size = new System.Drawing.Size(263, 41);
            this.lblClosingBoxList.TabIndex = 28;
            this.lblClosingBoxList.Text = "Cierres de Cajas";
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
            this.btnSig.Location = new System.Drawing.Point(971, 624);
            this.btnSig.Name = "btnSig";
            this.btnSig.Size = new System.Drawing.Size(25, 40);
            this.btnSig.TabIndex = 82;
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
            this.btnAnt.Location = new System.Drawing.Point(832, 624);
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Size = new System.Drawing.Size(25, 40);
            this.btnAnt.TabIndex = 81;
            this.btnAnt.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnAnt.UseVisualStyleBackColor = false;
            this.btnAnt.Click += new System.EventHandler(this.btnAnt_Click);
            // 
            // lblPagina
            // 
            this.lblPagina.AutoSize = true;
            this.lblPagina.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagina.Location = new System.Drawing.Point(863, 635);
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(102, 17);
            this.lblPagina.TabIndex = 80;
            this.lblPagina.Text = "Pagina 1 de 10";
            // 
            // sPanel2
            // 
            this.sPanel2.BackColor = System.Drawing.Color.White;
            this.sPanel2.BorderColor = System.Drawing.Color.White;
            this.sPanel2.BorderRadius = 10;
            this.sPanel2.BorderSize = 0;
            this.sPanel2.Controls.Add(this.dtpFechaHasta);
            this.sPanel2.ForeColor = System.Drawing.Color.White;
            this.sPanel2.Location = new System.Drawing.Point(802, 86);
            this.sPanel2.Name = "sPanel2";
            this.sPanel2.Size = new System.Drawing.Size(195, 46);
            this.sPanel2.TabIndex = 91;
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
            this.dtpFechaDesde.Location = new System.Drawing.Point(590, 93);
            this.dtpFechaDesde.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(188, 35);
            this.dtpFechaDesde.SkinColor = System.Drawing.Color.White;
            this.dtpFechaDesde.TabIndex = 89;
            this.dtpFechaDesde.TextColor = System.Drawing.Color.Black;
            this.dtpFechaDesde.Value = new System.DateTime(2024, 10, 29, 0, 0, 0, 0);
            this.dtpFechaDesde.ValueChanged += new System.EventHandler(this.dtpFechaDesde_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(803, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 88;
            this.label3.Text = "Hasta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(587, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 87;
            this.label4.Text = "Desde:";
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.btnUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.btnUsuario.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnUsuario.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnUsuario.IconSize = 25;
            this.btnUsuario.Location = new System.Drawing.Point(274, 97);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(33, 35);
            this.btnUsuario.TabIndex = 86;
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // cboUsers
            // 
            this.cboUsers.BackColor = System.Drawing.SystemColors.Window;
            this.cboUsers.BorderColor = System.Drawing.Color.White;
            this.cboUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsers.DropDownWidth = 291;
            this.cboUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboUsers.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboUsers.FormattingEnabled = true;
            this.cboUsers.Items.AddRange(new object[] {
            "Emilia",
            "Juan",
            "Facundo"});
            this.cboUsers.Location = new System.Drawing.Point(27, 100);
            this.cboUsers.Name = "cboUsers";
            this.cboUsers.Size = new System.Drawing.Size(253, 24);
            this.cboUsers.TabIndex = 85;
            this.cboUsers.SelectedValueChanged += new System.EventHandler(this.cboUsers_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 83;
            this.label2.Text = "Filtrar por Usuario";
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
            this.modernTextBox2.Location = new System.Drawing.Point(19, 89);
            this.modernTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.modernTextBox2.Multiline = false;
            this.modernTextBox2.Name = "modernTextBox2";
            this.modernTextBox2.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.modernTextBox2.PasswordChar = false;
            this.modernTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.modernTextBox2.PlaceholderText = "";
            this.modernTextBox2.Size = new System.Drawing.Size(297, 46);
            this.modernTextBox2.TabIndex = 84;
            this.modernTextBox2.Texts = "";
            this.modernTextBox2.UnderlinedStyle = false;
            // 
            // sPanel1
            // 
            this.sPanel1.BackColor = System.Drawing.Color.White;
            this.sPanel1.BorderColor = System.Drawing.Color.White;
            this.sPanel1.BorderRadius = 10;
            this.sPanel1.BorderSize = 0;
            this.sPanel1.ForeColor = System.Drawing.Color.White;
            this.sPanel1.Location = new System.Drawing.Point(586, 86);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Size = new System.Drawing.Size(195, 46);
            this.sPanel1.TabIndex = 90;
            // 
            // ListClosingBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.sPanel2);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.cboUsers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modernTextBox2);
            this.Controls.Add(this.sPanel1);
            this.Controls.Add(this.btnSig);
            this.Controls.Add(this.btnAnt);
            this.Controls.Add(this.lblPagina);
            this.Controls.Add(this.dataClosingBox);
            this.Controls.Add(this.lblClosingBoxList);
            this.Name = "ListClosingBoxForm";
            this.Size = new System.Drawing.Size(1014, 681);
            this.Load += new System.EventHandler(this.ListClosingBoxForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataClosingBox)).EndInit();
            this.sPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataClosingBox;
        private System.Windows.Forms.Label lblClosingBoxList;
        private WindowsFormsApplication1.RoundButton btnSig;
        private WindowsFormsApplication1.RoundButton btnAnt;
        private System.Windows.Forms.Label lblPagina;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_apertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_cierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto_inicial;
        private System.Windows.Forms.DataGridViewImageColumn detalle;
        private Sipaa.Framework.SPanel sPanel2;
        private TheCoffe.Components.CustomDateTimePicker dtpFechaHasta;
        private TheCoffe.Components.CustomDateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnUsuario;
        private Components.CustomComboBox cboUsers;
        private System.Windows.Forms.Label label2;
        private TheCoffe.Components.ModernTextBox modernTextBox2;
        private Sipaa.Framework.SPanel sPanel1;
    }
}