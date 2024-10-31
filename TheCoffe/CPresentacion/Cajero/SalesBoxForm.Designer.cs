namespace TheCoffe.CPresentacion.Cajero
{
    partial class SalesBoxForm
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
            this.txtSearch = new TheCoffe.Components.ModernTextBox();
            this.dataBoxSales = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEnCaja = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnCloseBox = new WindowsFormsApplication1.RoundButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataBoxSales)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.BorderColor = System.Drawing.Color.Transparent;
            this.txtSearch.BorderFocusColor = System.Drawing.Color.Black;
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.BorderSize = 1;
            this.txtSearch.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.Location = new System.Drawing.Point(20, 74);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(10, 16, 10, 7);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtSearch.PlaceholderText = "Buscar Por Mesero...";
            this.txtSearch.Size = new System.Drawing.Size(329, 44);
            this.txtSearch.TabIndex = 76;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = false;
            this.txtSearch._TextChanged += new System.EventHandler(this.txtSearch__TextChanged);
            // 
            // dataBoxSales
            // 
            this.dataBoxSales.AllowUserToAddRows = false;
            this.dataBoxSales.AllowUserToDeleteRows = false;
            this.dataBoxSales.AllowUserToResizeColumns = false;
            this.dataBoxSales.AllowUserToResizeRows = false;
            this.dataBoxSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataBoxSales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataBoxSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataBoxSales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataBoxSales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Medium", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataBoxSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataBoxSales.ColumnHeadersHeight = 45;
            this.dataBoxSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataBoxSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Precio,
            this.Categoria,
            this.total,
            this.detalle});
            this.dataBoxSales.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataBoxSales.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataBoxSales.EnableHeadersVisualStyles = false;
            this.dataBoxSales.GridColor = System.Drawing.Color.Silver;
            this.dataBoxSales.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataBoxSales.Location = new System.Drawing.Point(20, 139);
            this.dataBoxSales.MultiSelect = false;
            this.dataBoxSales.Name = "dataBoxSales";
            this.dataBoxSales.ReadOnly = true;
            this.dataBoxSales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataBoxSales.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataBoxSales.RowHeadersVisible = false;
            this.dataBoxSales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataBoxSales.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataBoxSales.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataBoxSales.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataBoxSales.RowTemplate.DividerHeight = 1;
            this.dataBoxSales.RowTemplate.Height = 45;
            this.dataBoxSales.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataBoxSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataBoxSales.ShowCellErrors = false;
            this.dataBoxSales.ShowCellToolTips = false;
            this.dataBoxSales.ShowEditingIcon = false;
            this.dataBoxSales.ShowRowErrors = false;
            this.dataBoxSales.Size = new System.Drawing.Size(976, 427);
            this.dataBoxSales.TabIndex = 75;
            this.dataBoxSales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBoxSales_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_ventas";
            this.ID.FillWeight = 28.59505F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 10;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "mesero";
            this.Nombre.FillWeight = 113.0575F;
            this.Nombre.HeaderText = "Mesero";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "fecha";
            this.Precio.FillWeight = 118.1199F;
            this.Precio.HeaderText = "Fecha";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "hora";
            this.Categoria.FillWeight = 109.6101F;
            this.Categoria.HeaderText = "Hora";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // total
            // 
            this.total.DataPropertyName = "monto_total";
            this.total.FillWeight = 113.9749F;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // detalle
            // 
            this.detalle.FillWeight = 79.96502F;
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
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 41);
            this.label1.TabIndex = 74;
            this.label1.Text = "Caja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.label3.Location = new System.Drawing.Point(728, 616);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 80;
            this.label3.Text = "Total Recaudado:";
            // 
            // lblEnCaja
            // 
            this.lblEnCaja.AutoSize = true;
            this.lblEnCaja.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEnCaja.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold);
            this.lblEnCaja.Location = new System.Drawing.Point(0, 0);
            this.lblEnCaja.Name = "lblEnCaja";
            this.lblEnCaja.Size = new System.Drawing.Size(70, 18);
            this.lblEnCaja.TabIndex = 86;
            this.lblEnCaja.Text = "$ 90,500";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(19, 601);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(980, 1);
            this.panel2.TabIndex = 87;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(19, 648);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 1);
            this.panel1.TabIndex = 88;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 70.1602F;
            this.dataGridViewImageColumn1.HeaderText = "Detalle";
            this.dataGridViewImageColumn1.Image = global::TheCoffe.Properties.Resources.detalle;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 121;
            // 
            // btnCloseBox
            // 
            this.btnCloseBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnCloseBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnCloseBox.BorderColor = System.Drawing.Color.Black;
            this.btnCloseBox.BorderRadius = 5;
            this.btnCloseBox.BorderSize = 0;
            this.btnCloseBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseBox.FlatAppearance.BorderSize = 0;
            this.btnCloseBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseBox.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseBox.ForeColor = System.Drawing.Color.White;
            this.btnCloseBox.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCloseBox.IconColor = System.Drawing.Color.White;
            this.btnCloseBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseBox.IconSize = 20;
            this.btnCloseBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseBox.Location = new System.Drawing.Point(838, 15);
            this.btnCloseBox.Name = "btnCloseBox";
            this.btnCloseBox.Size = new System.Drawing.Size(156, 43);
            this.btnCloseBox.TabIndex = 78;
            this.btnCloseBox.Text = "  Cerrar Caja";
            this.btnCloseBox.TextColor = System.Drawing.Color.White;
            this.btnCloseBox.UseVisualStyleBackColor = false;
            this.btnCloseBox.Click += new System.EventHandler(this.btnCloseBox_Click);
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
            this.iconButton5.Location = new System.Drawing.Point(310, 83);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(38, 32);
            this.iconButton5.TabIndex = 77;
            this.iconButton5.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblEnCaja);
            this.panel3.Location = new System.Drawing.Point(847, 616);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(174, 19);
            this.panel3.TabIndex = 89;
            // 
            // SalesBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCloseBox);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataBoxSales);
            this.Controls.Add(this.label1);
            this.Name = "SalesBoxForm";
            this.Size = new System.Drawing.Size(1014, 681);
            this.Load += new System.EventHandler(this.SalesBoxForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBoxSales)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton5;
        private TheCoffe.Components.ModernTextBox txtSearch;
        private System.Windows.Forms.DataGridView dataBoxSales;
        private System.Windows.Forms.Label label1;
        private WindowsFormsApplication1.RoundButton btnCloseBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEnCaja;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewImageColumn detalle;
        private System.Windows.Forms.Panel panel3;
    }
}