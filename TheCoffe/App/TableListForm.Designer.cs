namespace TheCoffe.App
{
    partial class TableListForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.roundButton3 = new WindowsFormsApplication1.RoundButton();
            this.roundButton2 = new WindowsFormsApplication1.RoundButton();
            this.roundButton1 = new WindowsFormsApplication1.RoundButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.modernTextBox1 = new TheCoffe.Components.ModernTextBox();
            this.dataTable = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddTable = new WindowsFormsApplication1.RoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.roundButton3);
            this.panel1.Controls.Add(this.roundButton2);
            this.panel1.Controls.Add(this.roundButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 45);
            this.panel1.TabIndex = 0;
            // 
            // roundButton3
            // 
            this.roundButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.roundButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.roundButton3.BorderColor = System.Drawing.Color.Black;
            this.roundButton3.BorderRadius = 8;
            this.roundButton3.BorderSize = 0;
            this.roundButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton3.FlatAppearance.BorderSize = 0;
            this.roundButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton3.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton3.ForeColor = System.Drawing.Color.White;
            this.roundButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.roundButton3.IconColor = System.Drawing.Color.Black;
            this.roundButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.roundButton3.Location = new System.Drawing.Point(457, 0);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(197, 47);
            this.roundButton3.TabIndex = 5;
            this.roundButton3.Text = "Administrar Mesas";
            this.roundButton3.TextColor = System.Drawing.Color.White;
            this.roundButton3.UseVisualStyleBackColor = false;
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.Transparent;
            this.roundButton2.BackgroundColor = System.Drawing.Color.Transparent;
            this.roundButton2.BorderColor = System.Drawing.Color.Black;
            this.roundButton2.BorderRadius = 8;
            this.roundButton2.BorderSize = 0;
            this.roundButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton2.FlatAppearance.BorderSize = 0;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton2.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton2.ForeColor = System.Drawing.Color.DimGray;
            this.roundButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.roundButton2.IconColor = System.Drawing.Color.Black;
            this.roundButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.roundButton2.Location = new System.Drawing.Point(230, 0);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(227, 47);
            this.roundButton2.TabIndex = 4;
            this.roundButton2.Text = "Administrar Categorías";
            this.roundButton2.TextColor = System.Drawing.Color.DimGray;
            this.roundButton2.UseVisualStyleBackColor = false;
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.Transparent;
            this.roundButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.roundButton1.BorderColor = System.Drawing.Color.Black;
            this.roundButton1.BorderRadius = 8;
            this.roundButton1.BorderSize = 0;
            this.roundButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton1.ForeColor = System.Drawing.Color.DimGray;
            this.roundButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.roundButton1.IconColor = System.Drawing.Color.Black;
            this.roundButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.roundButton1.Location = new System.Drawing.Point(3, 0);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(227, 47);
            this.roundButton1.TabIndex = 3;
            this.roundButton1.Text = "Administrar Productos";
            this.roundButton1.TextColor = System.Drawing.Color.DimGray;
            this.roundButton1.UseVisualStyleBackColor = false;
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
            this.iconButton5.Location = new System.Drawing.Point(316, 126);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(38, 32);
            this.iconButton5.TabIndex = 19;
            this.iconButton5.UseVisualStyleBackColor = false;
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
            this.modernTextBox1.Location = new System.Drawing.Point(31, 118);
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
            // dataTable
            // 
            this.dataTable.AllowUserToAddRows = false;
            this.dataTable.AllowUserToDeleteRows = false;
            this.dataTable.AllowUserToResizeColumns = false;
            this.dataTable.AllowUserToResizeRows = false;
            this.dataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.dataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Medium", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTable.ColumnHeadersHeight = 45;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Precio,
            this.Acciones});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataTable.EnableHeadersVisualStyles = false;
            this.dataTable.GridColor = System.Drawing.Color.Silver;
            this.dataTable.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataTable.Location = new System.Drawing.Point(31, 184);
            this.dataTable.MultiSelect = false;
            this.dataTable.Name = "dataTable";
            this.dataTable.ReadOnly = true;
            this.dataTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataTable.RowHeadersVisible = false;
            this.dataTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataTable.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataTable.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.dataTable.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.dataTable.RowTemplate.DividerHeight = 1;
            this.dataTable.RowTemplate.Height = 45;
            this.dataTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTable.ShowCellErrors = false;
            this.dataTable.ShowCellToolTips = false;
            this.dataTable.ShowEditingIcon = false;
            this.dataTable.ShowRowErrors = false;
            this.dataTable.Size = new System.Drawing.Size(964, 479);
            this.dataTable.TabIndex = 17;
            // 
            // ID
            // 
            this.ID.FillWeight = 58.95526F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 62.10778F;
            this.Nombre.HeaderText = "Nro. de Mesa";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.FillWeight = 64.88885F;
            this.Precio.HeaderText = "Cant. de Sillas";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Acciones
            // 
            this.Acciones.FillWeight = 100.027F;
            this.Acciones.HeaderText = "Acciones";
            this.Acciones.Name = "Acciones";
            this.Acciones.ReadOnly = true;
            // 
            // btnAddTable
            // 
            this.btnAddTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnAddTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnAddTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddTable.BorderColor = System.Drawing.Color.Black;
            this.btnAddTable.BorderRadius = 5;
            this.btnAddTable.BorderSize = 0;
            this.btnAddTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTable.FlatAppearance.BorderSize = 0;
            this.btnAddTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTable.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTable.ForeColor = System.Drawing.Color.White;
            this.btnAddTable.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAddTable.IconColor = System.Drawing.Color.White;
            this.btnAddTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddTable.IconSize = 20;
            this.btnAddTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTable.Location = new System.Drawing.Point(851, 59);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(156, 43);
            this.btnAddTable.TabIndex = 16;
            this.btnAddTable.Text = "  Agregar Mesa";
            this.btnAddTable.TextColor = System.Drawing.Color.White;
            this.btnAddTable.UseVisualStyleBackColor = false;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 41);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mesas";
            // 
            // TableListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.modernTextBox1);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.btnAddTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "TableListForm";
            this.Size = new System.Drawing.Size(1030, 720);
            this.Load += new System.EventHandler(this.TableListForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private WindowsFormsApplication1.RoundButton roundButton3;
        private WindowsFormsApplication1.RoundButton roundButton2;
        private WindowsFormsApplication1.RoundButton roundButton1;
        private FontAwesome.Sharp.IconButton iconButton5;
        private Components.ModernTextBox modernTextBox1;
        private System.Windows.Forms.DataGridView dataTable;
        private WindowsFormsApplication1.RoundButton btnAddTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acciones;
    }
}
