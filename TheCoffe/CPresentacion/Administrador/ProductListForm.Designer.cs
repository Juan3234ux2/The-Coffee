﻿namespace TheCoffe.App
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductListForm));
            this.label1 = new System.Windows.Forms.Label();
            this.dataProducts = new System.Windows.Forms.DataGridView();
            this.Id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtSearch = new TheCoffe.Components.ModernTextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.roundButton4 = new WindowsFormsApplication1.RoundButton();
            this.btnRemovedProducts = new WindowsFormsApplication1.RoundButton();
            this.btnSig = new WindowsFormsApplication1.RoundButton();
            this.btnAnt = new WindowsFormsApplication1.RoundButton();
            this.lblPagina = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Roboto Medium", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataProducts.ColumnHeadersHeight = 45;
            this.dataProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_producto,
            this.nombre,
            this.categoria,
            this.precio,
            this.editar,
            this.eliminar});
            this.dataProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataProducts.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataProducts.EnableHeadersVisualStyles = false;
            this.dataProducts.GridColor = System.Drawing.Color.Silver;
            this.dataProducts.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataProducts.Location = new System.Drawing.Point(19, 139);
            this.dataProducts.MultiSelect = false;
            this.dataProducts.Name = "dataProducts";
            this.dataProducts.ReadOnly = true;
            this.dataProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataProducts.RowHeadersVisible = false;
            this.dataProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dataProducts.RowsDefaultCellStyle = dataGridViewCellStyle12;
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
            // Id_producto
            // 
            this.Id_producto.DataPropertyName = "id_producto";
            this.Id_producto.FillWeight = 28.3479F;
            this.Id_producto.HeaderText = "ID";
            this.Id_producto.Name = "Id_producto";
            this.Id_producto.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.FillWeight = 123.7938F;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "c";
            this.categoria.FillWeight = 123.7938F;
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            this.precio.FillWeight = 123.7938F;
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // editar
            // 
            this.editar.FillWeight = 30.30469F;
            this.editar.HeaderText = "Acciones";
            this.editar.Image = global::TheCoffe.Properties.Resources.pencil;
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            this.editar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // eliminar
            // 
            this.eliminar.FillWeight = 22.99648F;
            this.eliminar.HeaderText = "";
            this.eliminar.Image = ((System.Drawing.Image)(resources.GetObject("eliminar.Image")));
            this.eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            this.eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.txtSearch.Location = new System.Drawing.Point(19, 74);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(10, 16, 10, 7);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtSearch.PlaceholderText = "Buscar...";
            this.txtSearch.Size = new System.Drawing.Size(329, 44);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = false;
            this.txtSearch._TextChanged += new System.EventHandler(this.txtSearch__TextChanged);
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
            this.dataGridViewImageColumn2.Image = global::TheCoffe.Properties.Resources.lapiz;
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
            this.iconButton5.Location = new System.Drawing.Point(306, 82);
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
            this.roundButton4.Location = new System.Drawing.Point(841, 15);
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
            this.btnRemovedProducts.Location = new System.Drawing.Point(644, 15);
            this.btnRemovedProducts.Name = "btnRemovedProducts";
            this.btnRemovedProducts.Size = new System.Drawing.Size(156, 43);
            this.btnRemovedProducts.TabIndex = 15;
            this.btnRemovedProducts.Text = "Productos Eliminados";
            this.btnRemovedProducts.TextColor = System.Drawing.Color.White;
            this.btnRemovedProducts.UseVisualStyleBackColor = false;
            this.btnRemovedProducts.Click += new System.EventHandler(this.btnRemovedProducts_Click);
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
            this.btnSig.Location = new System.Drawing.Point(970, 625);
            this.btnSig.Name = "btnSig";
            this.btnSig.Size = new System.Drawing.Size(25, 40);
            this.btnSig.TabIndex = 79;
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
            this.btnAnt.Location = new System.Drawing.Point(833, 625);
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Size = new System.Drawing.Size(25, 40);
            this.btnAnt.TabIndex = 78;
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
            this.lblPagina.TabIndex = 77;
            this.lblPagina.Text = "Pagina 1 de 10";
            // 
            // ProductListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.btnSig);
            this.Controls.Add(this.btnAnt);
            this.Controls.Add(this.lblPagina);
            this.Controls.Add(this.btnRemovedProducts);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataProducts);
            this.Controls.Add(this.roundButton4);
            this.Controls.Add(this.label1);
            this.Name = "ProductListForm";
            this.Size = new System.Drawing.Size(1014, 681);
            this.Load += new System.EventHandler(this.ProductList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private WindowsFormsApplication1.RoundButton roundButton4;
        private FontAwesome.Sharp.IconButton iconButton5;
        private Components.ModernTextBox txtSearch;
        private System.Windows.Forms.DataGridView dataProducts;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private WindowsFormsApplication1.RoundButton btnRemovedProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.DataGridViewImageColumn eliminar;
        private WindowsFormsApplication1.RoundButton btnSig;
        private WindowsFormsApplication1.RoundButton btnAnt;
        private System.Windows.Forms.Label lblPagina;
    }
}
