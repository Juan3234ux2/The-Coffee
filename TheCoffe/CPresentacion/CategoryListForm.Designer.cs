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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.modernTextBox1 = new TheCoffe.Components.ModernTextBox();
            this.dataCategory = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.btnAddCategory = new WindowsFormsApplication1.RoundButton();
            this.btnRemovedCategories = new WindowsFormsApplication1.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataCategory)).BeginInit();
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
            // dataCategory
            // 
            this.dataCategory.AllowUserToAddRows = false;
            this.dataCategory.AllowUserToDeleteRows = false;
            this.dataCategory.AllowUserToResizeColumns = false;
            this.dataCategory.AllowUserToResizeRows = false;
            this.dataCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCategory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.dataCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto Medium", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataCategory.ColumnHeadersHeight = 45;
            this.dataCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.editar,
            this.eliminar});
            this.dataCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataCategory.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataCategory.EnableHeadersVisualStyles = false;
            this.dataCategory.GridColor = System.Drawing.Color.Silver;
            this.dataCategory.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataCategory.Location = new System.Drawing.Point(23, 139);
            this.dataCategory.MultiSelect = false;
            this.dataCategory.Name = "dataCategory";
            this.dataCategory.ReadOnly = true;
            this.dataCategory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataCategory.RowHeadersVisible = false;
            this.dataCategory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dataCategory.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataCategory.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.dataCategory.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
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
            // ID
            // 
            this.ID.FillWeight = 24.46955F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 258.7863F;
            this.Nombre.HeaderText = "Descripción";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // editar
            // 
            this.editar.FillWeight = 21.18868F;
            this.editar.HeaderText = "Acciones";
            this.editar.Image = global::TheCoffe.Properties.Resources.pencil;
            this.editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            this.editar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // eliminar
            // 
            this.eliminar.FillWeight = 16.64549F;
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
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 41);
            this.label1.TabIndex = 15;
            this.label1.Text = "Categorías";
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
            this.iconButton5.Location = new System.Drawing.Point(308, 82);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(38, 32);
            this.iconButton5.TabIndex = 19;
            this.iconButton5.UseVisualStyleBackColor = false;
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
            this.btnAddCategory.Location = new System.Drawing.Point(843, 15);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(156, 43);
            this.btnAddCategory.TabIndex = 16;
            this.btnAddCategory.Text = "  Agregar Categoría";
            this.btnAddCategory.TextColor = System.Drawing.Color.White;
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
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
            this.btnRemovedCategories.Location = new System.Drawing.Point(639, 15);
            this.btnRemovedCategories.Name = "btnRemovedCategories";
            this.btnRemovedCategories.Size = new System.Drawing.Size(165, 43);
            this.btnRemovedCategories.TabIndex = 20;
            this.btnRemovedCategories.Text = "Categorías Eliminadas";
            this.btnRemovedCategories.TextColor = System.Drawing.Color.White;
            this.btnRemovedCategories.UseVisualStyleBackColor = false;
            this.btnRemovedCategories.Click += new System.EventHandler(this.btnRemovedCategories_Click);
            // 
            // CategoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btnRemovedCategories);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.modernTextBox1);
            this.Controls.Add(this.dataCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.label1);
            this.Name = "CategoryList";
            this.Size = new System.Drawing.Size(1030, 720);
            this.Load += new System.EventHandler(this.CategoryList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButton5;
        private Components.ModernTextBox modernTextBox1;
        private System.Windows.Forms.DataGridView dataCategory;
        private WindowsFormsApplication1.RoundButton btnAddCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.DataGridViewImageColumn eliminar;
        private WindowsFormsApplication1.RoundButton btnRemovedCategories;
    }
}
