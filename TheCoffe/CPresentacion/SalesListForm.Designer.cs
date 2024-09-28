﻿namespace TheCoffe.CPresentacion
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
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.dataSales = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFecha = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMesero = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMesero = new CustomComboBox();
            this.modernTextBox2 = new TheCoffe.Components.ModernTextBox();
            this.cboFecha = new CustomComboBox();
            this.modernTextBox4 = new TheCoffe.Components.ModernTextBox();
            this.modernTextBox1 = new TheCoffe.Components.ModernTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSales)).BeginInit();
            this.SuspendLayout();
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
            this.iconButton5.Location = new System.Drawing.Point(313, 84);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(38, 32);
            this.iconButton5.TabIndex = 19;
            this.iconButton5.UseVisualStyleBackColor = false;
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
            this.dataSales.Location = new System.Drawing.Point(23, 139);
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
            this.ID.FillWeight = 94.16002F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 99.19505F;
            this.Nombre.HeaderText = "Mesero";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.FillWeight = 103.6368F;
            this.Precio.HeaderText = "Fecha";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.FillWeight = 96.17036F;
            this.Categoria.HeaderText = "Hora";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // detalle
            // 
            this.detalle.FillWeight = 70.1602F;
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
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 41);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ventas";
            // 
            // btnFecha
            // 
            this.btnFecha.BackColor = System.Drawing.SystemColors.Window;
            this.btnFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFecha.FlatAppearance.BorderSize = 0;
            this.btnFecha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFecha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecha.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.btnFecha.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnFecha.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnFecha.IconSize = 25;
            this.btnFecha.Location = new System.Drawing.Point(962, 83);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(33, 35);
            this.btnFecha.TabIndex = 62;
            this.btnFecha.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFecha.UseVisualStyleBackColor = false;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(799, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 59;
            this.label7.Text = "Filtar";
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
            this.btnMesero.Location = new System.Drawing.Point(641, 83);
            this.btnMesero.Name = "btnMesero";
            this.btnMesero.Size = new System.Drawing.Size(33, 35);
            this.btnMesero.TabIndex = 66;
            this.btnMesero.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMesero.UseVisualStyleBackColor = false;
            this.btnMesero.Click += new System.EventHandler(this.btnMesero_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(478, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 63;
            this.label2.Text = "Filtar por Mesero";
            // 
            // cboMesero
            // 
            this.cboMesero.BackColor = System.Drawing.SystemColors.Window;
            this.cboMesero.BorderColor = System.Drawing.Color.Transparent;
            this.cboMesero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboMesero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMesero.DropDownWidth = 188;
            this.cboMesero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMesero.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMesero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboMesero.FormattingEnabled = true;
            this.cboMesero.Items.AddRange(new object[] {
            "Emilia",
            "Juan",
            "Facundo"});
            this.cboMesero.Location = new System.Drawing.Point(487, 89);
            this.cboMesero.Name = "cboMesero";
            this.cboMesero.Size = new System.Drawing.Size(160, 24);
            this.cboMesero.TabIndex = 65;
            // 
            // modernTextBox2
            // 
            this.modernTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.modernTextBox2.BorderColor = System.Drawing.Color.Transparent;
            this.modernTextBox2.BorderFocusColor = System.Drawing.Color.Transparent;
            this.modernTextBox2.BorderRadius = 10;
            this.modernTextBox2.BorderSize = 1;
            this.modernTextBox2.Enabled = false;
            this.modernTextBox2.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modernTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modernTextBox2.Location = new System.Drawing.Point(481, 74);
            this.modernTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.modernTextBox2.Multiline = false;
            this.modernTextBox2.Name = "modernTextBox2";
            this.modernTextBox2.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.modernTextBox2.PasswordChar = false;
            this.modernTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.modernTextBox2.PlaceholderText = "";
            this.modernTextBox2.Size = new System.Drawing.Size(195, 46);
            this.modernTextBox2.TabIndex = 64;
            this.modernTextBox2.Texts = "";
            this.modernTextBox2.UnderlinedStyle = false;
            // 
            // cboFecha
            // 
            this.cboFecha.BackColor = System.Drawing.SystemColors.Window;
            this.cboFecha.BorderColor = System.Drawing.Color.Transparent;
            this.cboFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFecha.DropDownWidth = 188;
            this.cboFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFecha.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboFecha.FormattingEnabled = true;
            this.cboFecha.Items.AddRange(new object[] {
            "Mes",
            "Quicena",
            "semana"});
            this.cboFecha.Location = new System.Drawing.Point(808, 89);
            this.cboFecha.Name = "cboFecha";
            this.cboFecha.Size = new System.Drawing.Size(160, 24);
            this.cboFecha.TabIndex = 61;
            // 
            // modernTextBox4
            // 
            this.modernTextBox4.BackColor = System.Drawing.SystemColors.Window;
            this.modernTextBox4.BorderColor = System.Drawing.Color.Transparent;
            this.modernTextBox4.BorderFocusColor = System.Drawing.Color.Transparent;
            this.modernTextBox4.BorderRadius = 10;
            this.modernTextBox4.BorderSize = 1;
            this.modernTextBox4.Enabled = false;
            this.modernTextBox4.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modernTextBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modernTextBox4.Location = new System.Drawing.Point(802, 74);
            this.modernTextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.modernTextBox4.Multiline = false;
            this.modernTextBox4.Name = "modernTextBox4";
            this.modernTextBox4.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.modernTextBox4.PasswordChar = false;
            this.modernTextBox4.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.modernTextBox4.PlaceholderText = "";
            this.modernTextBox4.Size = new System.Drawing.Size(195, 46);
            this.modernTextBox4.TabIndex = 60;
            this.modernTextBox4.Texts = "";
            this.modernTextBox4.UnderlinedStyle = false;
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
            this.modernTextBox1.Location = new System.Drawing.Point(23, 74);
            this.modernTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.modernTextBox1.Multiline = false;
            this.modernTextBox1.Name = "modernTextBox1";
            this.modernTextBox1.Padding = new System.Windows.Forms.Padding(10, 16, 10, 7);
            this.modernTextBox1.PasswordChar = false;
            this.modernTextBox1.PlaceholderColor = System.Drawing.Color.DimGray;
            this.modernTextBox1.PlaceholderText = "Buscar...";
            this.modernTextBox1.Size = new System.Drawing.Size(329, 44);
            this.modernTextBox1.TabIndex = 18;
            this.modernTextBox1.Texts = "";
            this.modernTextBox1.UnderlinedStyle = false;
            // 
            // SalesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.btnMesero);
            this.Controls.Add(this.cboMesero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modernTextBox2);
            this.Controls.Add(this.btnFecha);
            this.Controls.Add(this.cboFecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.modernTextBox4);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.modernTextBox1);
            this.Controls.Add(this.dataSales);
            this.Controls.Add(this.label1);
            this.Name = "SalesListForm";
            this.Size = new System.Drawing.Size(1030, 720);
            this.Load += new System.EventHandler(this.SalesListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton5;
        private Components.ModernTextBox modernTextBox1;
        private System.Windows.Forms.DataGridView dataSales;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnFecha;
        private CustomComboBox cboFecha;
        private System.Windows.Forms.Label label7;
        private Components.ModernTextBox modernTextBox4;
        private FontAwesome.Sharp.IconButton btnMesero;
        private CustomComboBox cboMesero;
        private System.Windows.Forms.Label label2;
        private Components.ModernTextBox modernTextBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewImageColumn detalle;
    }
}
