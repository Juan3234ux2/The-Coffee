namespace TheCoffe.App
{
    partial class ProductListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductListForm));
            this.label1 = new System.Windows.Forms.Label();
            this.dataProducts = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.modernTextBox1 = new TheCoffe.Components.ModernTextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.roundButton4 = new WindowsFormsApplication1.RoundButton();
            this.btnRemovedProducts = new WindowsFormsApplication1.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Productos";
            // 
            // dataProducts
            // 
            this.dataProducts.AllowUserToAddRows = false;
            this.dataProducts.AllowUserToDeleteRows = false;
            this.dataProducts.AllowUserToResizeColumns = false;
            this.dataProducts.AllowUserToResizeRows = false;
            this.dataProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Medium", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataProducts.ColumnHeadersHeight = 45;
            this.dataProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Precio,
            this.Categoria,
            this.editar,
            this.eliminar});
            this.dataProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataProducts.EnableHeadersVisualStyles = false;
            this.dataProducts.GridColor = System.Drawing.Color.Silver;
            this.dataProducts.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataProducts.Location = new System.Drawing.Point(23, 139);
            this.dataProducts.MultiSelect = false;
            this.dataProducts.Name = "dataProducts";
            this.dataProducts.ReadOnly = true;
            this.dataProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataProducts.RowHeadersVisible = false;
            this.dataProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataProducts.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataProducts.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataProducts.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataProducts.RowTemplate.DividerHeight = 1;
            this.dataProducts.RowTemplate.Height = 45;
            this.dataProducts.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataProducts.ShowCellErrors = false;
            this.dataProducts.ShowCellToolTips = false;
            this.dataProducts.ShowEditingIcon = false;
            this.dataProducts.ShowRowErrors = false;
            this.dataProducts.Size = new System.Drawing.Size(976, 479);
            this.dataProducts.TabIndex = 11;
            this.dataProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProducts_CellClick);
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
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.FillWeight = 103.6368F;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.FillWeight = 96.17036F;
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // editar
            // 
            this.editar.FillWeight = 29.4442F;
            this.editar.HeaderText = "Acciones";
            this.editar.Image = global::TheCoffe.Properties.Resources.pencil;
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            this.editar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // eliminar
            // 
            this.eliminar.FillWeight = 23.58641F;
            this.eliminar.HeaderText = "";
            this.eliminar.Image = ((System.Drawing.Image)(resources.GetObject("eliminar.Image")));
            this.eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            this.eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.modernTextBox1.TabIndex = 13;
            this.modernTextBox1.Texts = "";
            this.modernTextBox1.UnderlinedStyle = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 44.77055F;
            this.dataGridViewImageColumn1.HeaderText = "Acciones";
            this.dataGridViewImageColumn1.Image = global::TheCoffe.Properties.Resources.eliminate;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 98;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 33.97407F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::TheCoffe.Properties.Resources.edit;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 74;
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
            this.iconButton5.Location = new System.Drawing.Point(310, 82);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(38, 32);
            this.iconButton5.TabIndex = 14;
            this.iconButton5.UseVisualStyleBackColor = false;
            // 
            // roundButton4
            // 
            this.roundButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.roundButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.roundButton4.BorderColor = System.Drawing.Color.Black;
            this.roundButton4.BorderRadius = 5;
            this.roundButton4.BorderSize = 0;
            this.roundButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton4.FlatAppearance.BorderSize = 0;
            this.roundButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton4.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton4.ForeColor = System.Drawing.Color.White;
            this.roundButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.roundButton4.IconColor = System.Drawing.Color.White;
            this.roundButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.roundButton4.IconSize = 20;
            this.roundButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundButton4.Location = new System.Drawing.Point(845, 15);
            this.roundButton4.Name = "roundButton4";
            this.roundButton4.Size = new System.Drawing.Size(156, 43);
            this.roundButton4.TabIndex = 2;
            this.roundButton4.Text = "  Agregar Producto";
            this.roundButton4.TextColor = System.Drawing.Color.White;
            this.roundButton4.UseVisualStyleBackColor = false;
            this.roundButton4.Click += new System.EventHandler(this.roundButton4_Click);
            // 
            // btnRemovedProducts
            // 
            this.btnRemovedProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnRemovedProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnRemovedProducts.BorderColor = System.Drawing.Color.Black;
            this.btnRemovedProducts.BorderRadius = 5;
            this.btnRemovedProducts.BorderSize = 0;
            this.btnRemovedProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemovedProducts.FlatAppearance.BorderSize = 0;
            this.btnRemovedProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovedProducts.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovedProducts.ForeColor = System.Drawing.Color.White;
            this.btnRemovedProducts.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRemovedProducts.IconColor = System.Drawing.Color.White;
            this.btnRemovedProducts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemovedProducts.IconSize = 20;
            this.btnRemovedProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemovedProducts.Location = new System.Drawing.Point(648, 15);
            this.btnRemovedProducts.Name = "btnRemovedProducts";
            this.btnRemovedProducts.Size = new System.Drawing.Size(156, 43);
            this.btnRemovedProducts.TabIndex = 15;
            this.btnRemovedProducts.Text = "Productos Eliminados";
            this.btnRemovedProducts.TextColor = System.Drawing.Color.White;
            this.btnRemovedProducts.UseVisualStyleBackColor = false;
            this.btnRemovedProducts.Click += new System.EventHandler(this.btnRemovedProducts_Click);
            // 
            // ProductListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.btnRemovedProducts);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.modernTextBox1);
            this.Controls.Add(this.dataProducts);
            this.Controls.Add(this.roundButton4);
            this.Controls.Add(this.label1);
            this.Name = "ProductListForm";
            this.Size = new System.Drawing.Size(1030, 720);
            this.Load += new System.EventHandler(this.ProductList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private WindowsFormsApplication1.RoundButton roundButton4;
        private FontAwesome.Sharp.IconButton iconButton5;
        private Components.ModernTextBox modernTextBox1;
        private System.Windows.Forms.DataGridView dataProducts;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private WindowsFormsApplication1.RoundButton btnRemovedProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.DataGridViewImageColumn eliminar;
    }
}
