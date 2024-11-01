namespace TheCoffe.App
{
    partial class CategoryList
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
            this.dataCategory = new System.Windows.Forms.DataGridView();
            this.id_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.btnRemovedCategories = new WindowsFormsApplication1.RoundButton();
            this.txtSearch = new TheCoffe.Components.ModernTextBox();
            this.btnAddCategory = new WindowsFormsApplication1.RoundButton();
            this.lblPagina = new System.Windows.Forms.Label();
            this.btnAnt = new WindowsFormsApplication1.RoundButton();
            this.btnSig = new WindowsFormsApplication1.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataCategory
            // 
            this.dataCategory.AllowUserToAddRows = false;
            this.dataCategory.AllowUserToDeleteRows = false;
            this.dataCategory.AllowUserToResizeColumns = false;
            this.dataCategory.AllowUserToResizeRows = false;
            this.dataCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCategory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Roboto Medium", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataCategory.ColumnHeadersHeight = 45;
            this.dataCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_categoria,
            this.descripcion,
            this.editar,
            this.eliminar});
            this.dataCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataCategory.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataCategory.EnableHeadersVisualStyles = false;
            this.dataCategory.GridColor = System.Drawing.Color.Silver;
            this.dataCategory.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataCategory.Location = new System.Drawing.Point(20, 139);
            this.dataCategory.MultiSelect = false;
            this.dataCategory.Name = "dataCategory";
            this.dataCategory.ReadOnly = true;
            this.dataCategory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataCategory.RowHeadersVisible = false;
            this.dataCategory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dataCategory.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataCategory.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataCategory.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataCategory.RowTemplate.DividerHeight = 1;
            this.dataCategory.RowTemplate.Height = 45;
            this.dataCategory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataCategory.ShowCellErrors = false;
            this.dataCategory.ShowCellToolTips = false;
            this.dataCategory.ShowEditingIcon = false;
            this.dataCategory.ShowRowErrors = false;
            this.dataCategory.Size = new System.Drawing.Size(976, 479);
            this.dataCategory.TabIndex = 17;
            this.dataCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCategory_CellClick);
            // 
            // id_categoria
            // 
            this.id_categoria.DataPropertyName = "id_categoria";
            this.id_categoria.FillWeight = 21.30032F;
            this.id_categoria.HeaderText = "ID";
            this.id_categoria.Name = "id_categoria";
            this.id_categoria.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.FillWeight = 187.5035F;
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // editar
            // 
            this.editar.FillWeight = 16.95756F;
            this.editar.HeaderText = "Acciones";
            this.editar.Image = global::TheCoffe.Properties.Resources.pencil;
            this.editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            this.editar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // eliminar
            // 
            this.eliminar.FillWeight = 12.0728F;
            this.eliminar.HeaderText = "";
            this.eliminar.Image = global::TheCoffe.Properties.Resources.delete;
            this.eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 41);
            this.label1.TabIndex = 15;
            this.label1.Text = "Categorías";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 21.18868F;
            this.dataGridViewImageColumn1.HeaderText = "Acciones";
            this.dataGridViewImageColumn1.Image = global::TheCoffe.Properties.Resources.pencil;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 64;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 16.64549F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::TheCoffe.Properties.Resources.delete;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
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
            this.iconButton5.Location = new System.Drawing.Point(305, 82);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(38, 32);
            this.iconButton5.TabIndex = 19;
            this.iconButton5.UseVisualStyleBackColor = false;
            // 
            // btnRemovedCategories
            // 
            this.btnRemovedCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnRemovedCategories.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnRemovedCategories.BorderColor = System.Drawing.Color.Black;
            this.btnRemovedCategories.BorderRadius = 5;
            this.btnRemovedCategories.BorderSize = 0;
            this.btnRemovedCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemovedCategories.FlatAppearance.BorderSize = 0;
            this.btnRemovedCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovedCategories.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovedCategories.ForeColor = System.Drawing.Color.White;
            this.btnRemovedCategories.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRemovedCategories.IconColor = System.Drawing.Color.White;
            this.btnRemovedCategories.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemovedCategories.IconSize = 20;
            this.btnRemovedCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemovedCategories.Location = new System.Drawing.Point(636, 15);
            this.btnRemovedCategories.Name = "btnRemovedCategories";
            this.btnRemovedCategories.Size = new System.Drawing.Size(165, 43);
            this.btnRemovedCategories.TabIndex = 20;
            this.btnRemovedCategories.Text = "Categorías Eliminadas";
            this.btnRemovedCategories.TextColor = System.Drawing.Color.White;
            this.btnRemovedCategories.UseVisualStyleBackColor = false;
            this.btnRemovedCategories.Click += new System.EventHandler(this.btnRemovedCategories_Click);
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
            this.txtSearch.PlaceholderText = "Buscar...";
            this.txtSearch.Size = new System.Drawing.Size(329, 44);
            this.txtSearch.TabIndex = 18;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = false;
            this.txtSearch._TextChanged += new System.EventHandler(this.txtSearch__TextChanged);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnAddCategory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnAddCategory.BorderColor = System.Drawing.Color.Black;
            this.btnAddCategory.BorderRadius = 5;
            this.btnAddCategory.BorderSize = 0;
            this.btnAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCategory.FlatAppearance.BorderSize = 0;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAddCategory.IconColor = System.Drawing.Color.White;
            this.btnAddCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddCategory.IconSize = 20;
            this.btnAddCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCategory.Location = new System.Drawing.Point(840, 15);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(156, 43);
            this.btnAddCategory.TabIndex = 16;
            this.btnAddCategory.Text = "  Agregar Categoría";
            this.btnAddCategory.TextColor = System.Drawing.Color.White;
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // lblPagina
            // 
            this.lblPagina.AutoSize = true;
            this.lblPagina.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagina.Location = new System.Drawing.Point(845, 633);
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(102, 17);
            this.lblPagina.TabIndex = 21;
            this.lblPagina.Text = "Pagina 1 de 10";
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
            this.btnAnt.Location = new System.Drawing.Point(815, 623);
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Size = new System.Drawing.Size(25, 40);
            this.btnAnt.TabIndex = 22;
            this.btnAnt.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnAnt.UseVisualStyleBackColor = false;
            this.btnAnt.Click += new System.EventHandler(this.btnAnt_Click);
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
            this.btnSig.Location = new System.Drawing.Point(952, 623);
            this.btnSig.Name = "btnSig";
            this.btnSig.Size = new System.Drawing.Size(25, 40);
            this.btnSig.TabIndex = 23;
            this.btnSig.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnSig.UseVisualStyleBackColor = false;
            this.btnSig.Click += new System.EventHandler(this.btnSig_Click);
            // 
            // CategoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.btnSig);
            this.Controls.Add(this.btnAnt);
            this.Controls.Add(this.lblPagina);
            this.Controls.Add(this.btnRemovedCategories);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.label1);
            this.Name = "CategoryList";
            this.Size = new System.Drawing.Size(1014, 681);
            this.Load += new System.EventHandler(this.CategoryList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButton5;
        private Components.ModernTextBox txtSearch;
        private System.Windows.Forms.DataGridView dataCategory;
        private WindowsFormsApplication1.RoundButton btnAddCategory;
        private System.Windows.Forms.Label label1;
        private WindowsFormsApplication1.RoundButton btnRemovedCategories;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.DataGridViewImageColumn eliminar;
        private System.Windows.Forms.Label lblPagina;
        private WindowsFormsApplication1.RoundButton btnAnt;
        private WindowsFormsApplication1.RoundButton btnSig;
    }
}
