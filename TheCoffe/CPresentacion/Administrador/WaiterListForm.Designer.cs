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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataWaiter = new System.Windows.Forms.DataGridView();
            this.id_mesero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.btnRemovedWaiter = new WindowsFormsApplication1.RoundButton();
            this.txtSearch = new TheCoffe.Components.ModernTextBox();
            this.btnAddWaiter = new WindowsFormsApplication1.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataWaiter)).BeginInit();
            this.SuspendLayout();
            // 
            // dataWaiter
            // 
            this.dataWaiter.AllowUserToAddRows = false;
            this.dataWaiter.AllowUserToDeleteRows = false;
            this.dataWaiter.AllowUserToResizeColumns = false;
            this.dataWaiter.AllowUserToResizeRows = false;
            this.dataWaiter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataWaiter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataWaiter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataWaiter.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataWaiter.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Medium", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataWaiter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataWaiter.ColumnHeadersHeight = 45;
            this.dataWaiter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataWaiter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_mesero,
            this.nombre,
            this.apellido,
            this.Telefono,
            this.hora_entrada,
            this.hora_salida,
            this.editar,
            this.eliminar});
            this.dataWaiter.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataWaiter.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataWaiter.EnableHeadersVisualStyles = false;
            this.dataWaiter.GridColor = System.Drawing.Color.Silver;
            this.dataWaiter.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataWaiter.Location = new System.Drawing.Point(18, 138);
            this.dataWaiter.MultiSelect = false;
            this.dataWaiter.Name = "dataWaiter";
            this.dataWaiter.ReadOnly = true;
            this.dataWaiter.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataWaiter.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataWaiter.RowHeadersVisible = false;
            this.dataWaiter.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataWaiter.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataWaiter.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataWaiter.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
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
            // id_mesero
            // 
            this.id_mesero.DataPropertyName = "id_mesero";
            this.id_mesero.FillWeight = 36.62743F;
            this.id_mesero.HeaderText = "ID";
            this.id_mesero.Name = "id_mesero";
            this.id_mesero.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.FillWeight = 114.846F;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.FillWeight = 114.846F;
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "telefono";
            this.Telefono.FillWeight = 114.846F;
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // hora_entrada
            // 
            this.hora_entrada.DataPropertyName = "hora_entrada";
            this.hora_entrada.FillWeight = 114.846F;
            this.hora_entrada.HeaderText = "Hora Entrada";
            this.hora_entrada.Name = "hora_entrada";
            this.hora_entrada.ReadOnly = true;
            // 
            // hora_salida
            // 
            this.hora_salida.DataPropertyName = "hora_salida";
            this.hora_salida.FillWeight = 114.846F;
            this.hora_salida.HeaderText = "Hora Salida";
            this.hora_salida.Name = "hora_salida";
            this.hora_salida.ReadOnly = true;
            // 
            // editar
            // 
            this.editar.FillWeight = 50.18527F;
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
            this.eliminar.FillWeight = 35.34988F;
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
            this.label1.Location = new System.Drawing.Point(11, 14);
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
            this.iconButton5.Location = new System.Drawing.Point(303, 81);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(38, 32);
            this.iconButton5.TabIndex = 24;
            this.iconButton5.UseVisualStyleBackColor = false;
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
            this.btnRemovedWaiter.Location = new System.Drawing.Point(645, 15);
            this.btnRemovedWaiter.Name = "btnRemovedWaiter";
            this.btnRemovedWaiter.Size = new System.Drawing.Size(156, 43);
            this.btnRemovedWaiter.TabIndex = 26;
            this.btnRemovedWaiter.Text = "Meseros Eliminados";
            this.btnRemovedWaiter.TextColor = System.Drawing.Color.White;
            this.btnRemovedWaiter.UseVisualStyleBackColor = false;
            this.btnRemovedWaiter.Click += new System.EventHandler(this.btnRemovedWaiter_Click);
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
            this.txtSearch.Location = new System.Drawing.Point(18, 74);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(10, 16, 10, 7);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtSearch.PlaceholderText = "Buscar...";
            this.txtSearch.Size = new System.Drawing.Size(329, 44);
            this.txtSearch.TabIndex = 23;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = false;
            this.txtSearch._TextChanged += new System.EventHandler(this.txtSearch__TextChanged);
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
            this.btnAddWaiter.Location = new System.Drawing.Point(838, 14);
            this.btnAddWaiter.Name = "btnAddWaiter";
            this.btnAddWaiter.Size = new System.Drawing.Size(156, 43);
            this.btnAddWaiter.TabIndex = 21;
            this.btnAddWaiter.Text = "  Agregar Mesero";
            this.btnAddWaiter.TextColor = System.Drawing.Color.White;
            this.btnAddWaiter.UseVisualStyleBackColor = false;
            this.btnAddWaiter.Click += new System.EventHandler(this.btnAddWaiter_Click);
            // 
            // WaiterListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.btnRemovedWaiter);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataWaiter);
            this.Controls.Add(this.btnAddWaiter);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "WaiterListForm";
            this.Size = new System.Drawing.Size(1014, 681);
            this.Load += new System.EventHandler(this.WaiterListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataWaiter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton5;
        private Components.ModernTextBox txtSearch;
        private System.Windows.Forms.DataGridView dataWaiter;
        private WindowsFormsApplication1.RoundButton btnAddWaiter;
        private System.Windows.Forms.Label label1;
        private WindowsFormsApplication1.RoundButton btnRemovedWaiter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_mesero;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_salida;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.DataGridViewImageColumn eliminar;
    }
}
