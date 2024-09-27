namespace TheCoffe.App
{
    partial class WaiterListForm
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
            this.modernTextBox1 = new TheCoffe.Components.ModernTextBox();
            this.dataWaiter = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.btnAddWaiter = new WindowsFormsApplication1.RoundButton();
            this.btnRemovedWaiter = new WindowsFormsApplication1.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataWaiter)).BeginInit();
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
            this.modernTextBox1.Location = new System.Drawing.Point(21, 74);
            this.modernTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.modernTextBox1.Multiline = false;
            this.modernTextBox1.Name = "modernTextBox1";
            this.modernTextBox1.Padding = new System.Windows.Forms.Padding(10, 16, 10, 7);
            this.modernTextBox1.PasswordChar = false;
            this.modernTextBox1.PlaceholderColor = System.Drawing.Color.DimGray;
            this.modernTextBox1.PlaceholderText = "Buscar...";
            this.modernTextBox1.Size = new System.Drawing.Size(329, 44);
            this.modernTextBox1.TabIndex = 23;
            this.modernTextBox1.Texts = "";
            this.modernTextBox1.UnderlinedStyle = false;
            // 
            // dataWaiter
            // 
            this.dataWaiter.AllowUserToAddRows = false;
            this.dataWaiter.AllowUserToDeleteRows = false;
            this.dataWaiter.AllowUserToResizeColumns = false;
            this.dataWaiter.AllowUserToResizeRows = false;
            this.dataWaiter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataWaiter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.dataWaiter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataWaiter.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataWaiter.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Roboto Medium", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataWaiter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataWaiter.ColumnHeadersHeight = 45;
            this.dataWaiter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataWaiter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4,
            this.editar,
            this.eliminar});
            this.dataWaiter.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataWaiter.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataWaiter.EnableHeadersVisualStyles = false;
            this.dataWaiter.GridColor = System.Drawing.Color.Silver;
            this.dataWaiter.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataWaiter.Location = new System.Drawing.Point(21, 138);
            this.dataWaiter.MultiSelect = false;
            this.dataWaiter.Name = "dataWaiter";
            this.dataWaiter.ReadOnly = true;
            this.dataWaiter.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataWaiter.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataWaiter.RowHeadersVisible = false;
            this.dataWaiter.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dataWaiter.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataWaiter.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.dataWaiter.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.dataWaiter.RowTemplate.DividerHeight = 1;
            this.dataWaiter.RowTemplate.Height = 45;
            this.dataWaiter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataWaiter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataWaiter.ShowCellErrors = false;
            this.dataWaiter.ShowCellToolTips = false;
            this.dataWaiter.ShowEditingIcon = false;
            this.dataWaiter.ShowRowErrors = false;
            this.dataWaiter.Size = new System.Drawing.Size(976, 479);
            this.dataWaiter.TabIndex = 22;
            this.dataWaiter.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataWaiter_CellContentClick);
            // 
            // ID
            // 
            this.ID.FillWeight = 33.34377F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 76.38828F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 122.9931F;
            this.Column1.HeaderText = "Apellido";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 122.9931F;
            this.Column5.HeaderText = "DNI";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 122.9931F;
            this.Column2.HeaderText = "Teléfono";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 122.9931F;
            this.Column3.HeaderText = "Hora de Ingreso";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 122.9931F;
            this.Column4.HeaderText = "Hora de Salida";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // editar
            // 
            this.editar.FillWeight = 57.09146F;
            this.editar.HeaderText = "Acciones";
            this.editar.Image = global::TheCoffe.Properties.Resources.pencil;
            this.editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            this.editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // eliminar
            // 
            this.eliminar.FillWeight = 39.30109F;
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
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 41);
            this.label1.TabIndex = 20;
            this.label1.Text = "Meseros";
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
            this.iconButton5.Location = new System.Drawing.Point(306, 81);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(38, 32);
            this.iconButton5.TabIndex = 24;
            this.iconButton5.UseVisualStyleBackColor = false;
            // 
            // btnAddWaiter
            // 
            this.btnAddWaiter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnAddWaiter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnAddWaiter.BorderColor = System.Drawing.Color.Black;
            this.btnAddWaiter.BorderRadius = 5;
            this.btnAddWaiter.BorderSize = 0;
            this.btnAddWaiter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddWaiter.FlatAppearance.BorderSize = 0;
            this.btnAddWaiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWaiter.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWaiter.ForeColor = System.Drawing.Color.White;
            this.btnAddWaiter.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAddWaiter.IconColor = System.Drawing.Color.White;
            this.btnAddWaiter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddWaiter.IconSize = 20;
            this.btnAddWaiter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddWaiter.Location = new System.Drawing.Point(841, 14);
            this.btnAddWaiter.Name = "btnAddWaiter";
            this.btnAddWaiter.Size = new System.Drawing.Size(156, 43);
            this.btnAddWaiter.TabIndex = 21;
            this.btnAddWaiter.Text = "  Agregar Mesero";
            this.btnAddWaiter.TextColor = System.Drawing.Color.White;
            this.btnAddWaiter.UseVisualStyleBackColor = false;
            this.btnAddWaiter.Click += new System.EventHandler(this.btnAddWaiter_Click);
            // 
            // btnRemovedWaiter
            // 
            this.btnRemovedWaiter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnRemovedWaiter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnRemovedWaiter.BorderColor = System.Drawing.Color.Black;
            this.btnRemovedWaiter.BorderRadius = 5;
            this.btnRemovedWaiter.BorderSize = 0;
            this.btnRemovedWaiter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemovedWaiter.FlatAppearance.BorderSize = 0;
            this.btnRemovedWaiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovedWaiter.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovedWaiter.ForeColor = System.Drawing.Color.White;
            this.btnRemovedWaiter.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRemovedWaiter.IconColor = System.Drawing.Color.White;
            this.btnRemovedWaiter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemovedWaiter.IconSize = 20;
            this.btnRemovedWaiter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemovedWaiter.Location = new System.Drawing.Point(648, 15);
            this.btnRemovedWaiter.Name = "btnRemovedWaiter";
            this.btnRemovedWaiter.Size = new System.Drawing.Size(156, 43);
            this.btnRemovedWaiter.TabIndex = 26;
            this.btnRemovedWaiter.Text = "Meseros Eliminados";
            this.btnRemovedWaiter.TextColor = System.Drawing.Color.White;
            this.btnRemovedWaiter.UseVisualStyleBackColor = false;
            this.btnRemovedWaiter.Click += new System.EventHandler(this.btnRemovedWaiter_Click);
            // 
            // WaiterListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btnRemovedWaiter);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.modernTextBox1);
            this.Controls.Add(this.dataWaiter);
            this.Controls.Add(this.btnAddWaiter);
            this.Controls.Add(this.label1);
            this.Name = "WaiterListForm";
            this.Size = new System.Drawing.Size(1030, 720);
            this.Load += new System.EventHandler(this.WaiterListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataWaiter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton5;
        private Components.ModernTextBox modernTextBox1;
        private System.Windows.Forms.DataGridView dataWaiter;
        private WindowsFormsApplication1.RoundButton btnAddWaiter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.DataGridViewImageColumn eliminar;
        private WindowsFormsApplication1.RoundButton btnRemovedWaiter;
    }
}
