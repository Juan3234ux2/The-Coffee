namespace TheCoffe.CPresentacion
{
    partial class RemovedProductsListForm
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
            this.modernTextBox1 = new TheCoffe.Components.ModernTextBox();
            this.dataRemovedProducts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataRemovedProducts)).BeginInit();
            this.SuspendLayout();
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
            // dataRemovedProducts
            // 
            this.dataRemovedProducts.AllowUserToAddRows = false;
            this.dataRemovedProducts.AllowUserToDeleteRows = false;
            this.dataRemovedProducts.AllowUserToResizeColumns = false;
            this.dataRemovedProducts.AllowUserToResizeRows = false;
            this.dataRemovedProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataRemovedProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.dataRemovedProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataRemovedProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataRemovedProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Medium", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataRemovedProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataRemovedProducts.ColumnHeadersHeight = 45;
            this.dataRemovedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataRemovedProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Precio,
            this.Categoria,
            this.activar});
            this.dataRemovedProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataRemovedProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataRemovedProducts.EnableHeadersVisualStyles = false;
            this.dataRemovedProducts.GridColor = System.Drawing.Color.Silver;
            this.dataRemovedProducts.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataRemovedProducts.Location = new System.Drawing.Point(26, 139);
            this.dataRemovedProducts.MultiSelect = false;
            this.dataRemovedProducts.Name = "dataRemovedProducts";
            this.dataRemovedProducts.ReadOnly = true;
            this.dataRemovedProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataRemovedProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataRemovedProducts.RowHeadersVisible = false;
            this.dataRemovedProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataRemovedProducts.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataRemovedProducts.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.dataRemovedProducts.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.dataRemovedProducts.RowTemplate.DividerHeight = 1;
            this.dataRemovedProducts.RowTemplate.Height = 45;
            this.dataRemovedProducts.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataRemovedProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataRemovedProducts.ShowCellErrors = false;
            this.dataRemovedProducts.ShowCellToolTips = false;
            this.dataRemovedProducts.ShowEditingIcon = false;
            this.dataRemovedProducts.ShowRowErrors = false;
            this.dataRemovedProducts.Size = new System.Drawing.Size(976, 479);
            this.dataRemovedProducts.TabIndex = 17;
            this.dataRemovedProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataRemovedProducts_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 41);
            this.label1.TabIndex = 15;
            this.label1.Text = "Productos Eliminados";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 29.4442F;
            this.dataGridViewImageColumn1.HeaderText = "Acciones";
            this.dataGridViewImageColumn1.Image = global::TheCoffe.Properties.Resources.editarr;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 64;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 23.58641F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::TheCoffe.Properties.Resources.eliminate;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 51;
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
            this.iconButton5.TabIndex = 19;
            this.iconButton5.UseVisualStyleBackColor = false;
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
            // activar
            // 
            this.activar.FillWeight = 50.4442F;
            this.activar.HeaderText = "Activar";
            this.activar.Image = global::TheCoffe.Properties.Resources.activar;
            this.activar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.activar.Name = "activar";
            this.activar.ReadOnly = true;
            this.activar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // RemovedProductsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.modernTextBox1);
            this.Controls.Add(this.dataRemovedProducts);
            this.Controls.Add(this.label1);
            this.Name = "RemovedProductsListForm";
            this.Size = new System.Drawing.Size(1030, 720);
            this.Load += new System.EventHandler(this.RemovedProductsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataRemovedProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton5;
        private Components.ModernTextBox modernTextBox1;
        private System.Windows.Forms.DataGridView dataRemovedProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewImageColumn activar;
    }
}
