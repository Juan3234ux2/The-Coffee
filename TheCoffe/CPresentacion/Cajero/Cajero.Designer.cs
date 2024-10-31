using TheCoffe.CPresentacion.Components;

namespace TheCoffe.CPresentacion.Cajero
{
    partial class Cajero
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCountProduct = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblCajero = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnFinalizeOrder = new WindowsFormsApplication1.RoundButton();
            this.lblNroMesa = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnCategory = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.dataProducts = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relleno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCategorias = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPopulares = new WindowsFormsApplication1.RoundButton();
            this.txtSearch = new TheCoffe.Components.ModernTextBox();
            this.cboWaiter = new TheCoffe.CPresentacion.Components.CustomComboBox();
            this.modernTextBox4 = new TheCoffe.Components.ModernTextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).BeginInit();
            this.pnlCategorias.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(1, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(327, 1);
            this.panel4.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.label6.Location = new System.Drawing.Point(261, 509);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mesero";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotal.Font = new System.Drawing.Font("Roboto Medium", 13F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(86, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(86, 22);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "$ 34,000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.label4.Location = new System.Drawing.Point(16, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Roboto", 25F, System.Drawing.FontStyle.Bold);
            this.label25.Location = new System.Drawing.Point(15, 18);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(173, 41);
            this.label25.TabIndex = 23;
            this.label25.Text = "Productos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(19, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 1);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalles de la orden";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pnlProducts);
            this.panel1.Controls.Add(this.lblCountProduct);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblNroMesa);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(681, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 696);
            this.panel1.TabIndex = 22;
            // 
            // pnlProducts
            // 
            this.pnlProducts.AutoScroll = true;
            this.pnlProducts.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlProducts.Location = new System.Drawing.Point(-1, 137);
            this.pnlProducts.MaximumSize = new System.Drawing.Size(336, 415);
            this.pnlProducts.MinimumSize = new System.Drawing.Size(336, 405);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Size = new System.Drawing.Size(336, 412);
            this.pnlProducts.TabIndex = 7;
            this.pnlProducts.WrapContents = false;
            // 
            // lblCountProduct
            // 
            this.lblCountProduct.AutoSize = true;
            this.lblCountProduct.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.lblCountProduct.Location = new System.Drawing.Point(112, 108);
            this.lblCountProduct.Name = "lblCountProduct";
            this.lblCountProduct.Size = new System.Drawing.Size(17, 18);
            this.lblCountProduct.TabIndex = 6;
            this.lblCountProduct.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Productos";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnFinalizeOrder);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 548);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(331, 146);
            this.panel3.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblTotal);
            this.panel7.Location = new System.Drawing.Point(141, 50);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(172, 21);
            this.panel7.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblCajero);
            this.panel6.Location = new System.Drawing.Point(136, 20);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(172, 17);
            this.panel6.TabIndex = 7;
            // 
            // lblCajero
            // 
            this.lblCajero.AutoSize = true;
            this.lblCajero.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCajero.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold);
            this.lblCajero.Location = new System.Drawing.Point(80, 0);
            this.lblCajero.Name = "lblCajero";
            this.lblCajero.Size = new System.Drawing.Size(92, 14);
            this.lblCajero.TabIndex = 6;
            this.lblCajero.Text = "Juan Coronel";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.label21.Location = new System.Drawing.Point(16, 17);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 17);
            this.label21.TabIndex = 5;
            this.label21.Text = "Mesero";
            // 
            // btnFinalizeOrder
            // 
            this.btnFinalizeOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnFinalizeOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnFinalizeOrder.BorderColor = System.Drawing.Color.Transparent;
            this.btnFinalizeOrder.BorderRadius = 10;
            this.btnFinalizeOrder.BorderSize = 0;
            this.btnFinalizeOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizeOrder.FlatAppearance.BorderSize = 0;
            this.btnFinalizeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizeOrder.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizeOrder.ForeColor = System.Drawing.Color.White;
            this.btnFinalizeOrder.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnFinalizeOrder.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnFinalizeOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFinalizeOrder.IconSize = 35;
            this.btnFinalizeOrder.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnFinalizeOrder.Location = new System.Drawing.Point(13, 81);
            this.btnFinalizeOrder.MinimumSize = new System.Drawing.Size(58, 0);
            this.btnFinalizeOrder.Name = "btnFinalizeOrder";
            this.btnFinalizeOrder.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.btnFinalizeOrder.Size = new System.Drawing.Size(300, 45);
            this.btnFinalizeOrder.TabIndex = 2;
            this.btnFinalizeOrder.Tag = "";
            this.btnFinalizeOrder.Text = "Finalizar Pedido";
            this.btnFinalizeOrder.TextColor = System.Drawing.Color.White;
            this.btnFinalizeOrder.UseVisualStyleBackColor = false;
            this.btnFinalizeOrder.Click += new System.EventHandler(this.btnFinalizeOrder_Click);
            // 
            // lblNroMesa
            // 
            this.lblNroMesa.AutoSize = true;
            this.lblNroMesa.Font = new System.Drawing.Font("Roboto Medium", 9.5F);
            this.lblNroMesa.Location = new System.Drawing.Point(252, 79);
            this.lblNroMesa.Name = "lblNroMesa";
            this.lblNroMesa.Size = new System.Drawing.Size(56, 15);
            this.lblNroMesa.TabIndex = 3;
            this.lblNroMesa.Text = "Mesa 10";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Roboto Medium", 9.5F);
            this.lblFecha.Location = new System.Drawing.Point(16, 79);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(80, 15);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Sep 21, 2024";
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.White;
            this.btnCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.btnCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.btnCategory.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnCategory.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCategory.IconSize = 25;
            this.btnCategory.Location = new System.Drawing.Point(529, 506);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(24, 24);
            this.btnCategory.TabIndex = 73;
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCategory.UseVisualStyleBackColor = false;
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
            this.iconButton5.Location = new System.Drawing.Point(633, 28);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(38, 32);
            this.iconButton5.TabIndex = 28;
            this.iconButton5.UseVisualStyleBackColor = false;
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
            this.id,
            this.relleno,
            this.nombre,
            this.precio});
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
            this.dataProducts.Location = new System.Drawing.Point(14, 177);
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
            this.dataProducts.Size = new System.Drawing.Size(657, 479);
            this.dataProducts.TabIndex = 29;
            this.dataProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProducts_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id_producto";
            this.id.FillWeight = 8.822021F;
            this.id.HeaderText = "";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // relleno
            // 
            this.relleno.FillWeight = 11.13618F;
            this.relleno.HeaderText = "";
            this.relleno.Name = "relleno";
            this.relleno.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.FillWeight = 340.8011F;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precioFormateado";
            this.precio.FillWeight = 86.8283F;
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // pnlCategorias
            // 
            this.pnlCategorias.Controls.Add(this.btnPopulares);
            this.pnlCategorias.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.pnlCategorias.ForeColor = System.Drawing.Color.DimGray;
            this.pnlCategorias.Location = new System.Drawing.Point(14, 99);
            this.pnlCategorias.Name = "pnlCategorias";
            this.pnlCategorias.Size = new System.Drawing.Size(657, 48);
            this.pnlCategorias.TabIndex = 75;
            // 
            // btnPopulares
            // 
            this.btnPopulares.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnPopulares.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnPopulares.BorderColor = System.Drawing.Color.Black;
            this.btnPopulares.BorderRadius = 20;
            this.btnPopulares.BorderSize = 0;
            this.btnPopulares.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPopulares.FlatAppearance.BorderSize = 0;
            this.btnPopulares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPopulares.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.btnPopulares.ForeColor = System.Drawing.Color.White;
            this.btnPopulares.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPopulares.IconColor = System.Drawing.Color.Black;
            this.btnPopulares.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPopulares.Location = new System.Drawing.Point(3, 3);
            this.btnPopulares.Name = "btnPopulares";
            this.btnPopulares.Size = new System.Drawing.Size(146, 40);
            this.btnPopulares.TabIndex = 76;
            this.btnPopulares.TabStop = false;
            this.btnPopulares.Text = "Mas Populares";
            this.btnPopulares.TextColor = System.Drawing.Color.White;
            this.btnPopulares.UseVisualStyleBackColor = false;
            this.btnPopulares.Click += new System.EventHandler(this.SeleccionarCategoria);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.BorderColor = System.Drawing.Color.DimGray;
            this.txtSearch.BorderFocusColor = System.Drawing.Color.Black;
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.BorderSize = 1;
            this.txtSearch.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.Location = new System.Drawing.Point(376, 21);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(10, 16, 10, 7);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtSearch.PlaceholderText = "Buscar producto...";
            this.txtSearch.Size = new System.Drawing.Size(298, 44);
            this.txtSearch.TabIndex = 27;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = false;
            this.txtSearch._TextChanged += new System.EventHandler(this.txtSearch__TextChanged);
            // 
            // cboWaiter
            // 
            this.cboWaiter.BackColor = System.Drawing.Color.White;
            this.cboWaiter.BorderColor = System.Drawing.Color.Transparent;
            this.cboWaiter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboWaiter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWaiter.DropDownWidth = 143;
            this.cboWaiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboWaiter.Font = new System.Drawing.Font("Roboto Medium", 10.5F);
            this.cboWaiter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboWaiter.FormattingEnabled = true;
            this.cboWaiter.Items.AddRange(new object[] {
            "Juan Coronel",
            "Pedro Ramirez",
            "Jorge Gonzalez"});
            this.cboWaiter.Location = new System.Drawing.Point(417, 506);
            this.cboWaiter.Name = "cboWaiter";
            this.cboWaiter.Size = new System.Drawing.Size(110, 24);
            this.cboWaiter.TabIndex = 6;
            // 
            // modernTextBox4
            // 
            this.modernTextBox4.BackColor = System.Drawing.Color.White;
            this.modernTextBox4.BorderColor = System.Drawing.Color.Transparent;
            this.modernTextBox4.BorderFocusColor = System.Drawing.Color.Transparent;
            this.modernTextBox4.BorderRadius = 10;
            this.modernTextBox4.BorderSize = 1;
            this.modernTextBox4.Enabled = false;
            this.modernTextBox4.Font = new System.Drawing.Font("Roboto Medium", 1.5F);
            this.modernTextBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modernTextBox4.Location = new System.Drawing.Point(406, 500);
            this.modernTextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.modernTextBox4.Multiline = false;
            this.modernTextBox4.Name = "modernTextBox4";
            this.modernTextBox4.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.modernTextBox4.PasswordChar = false;
            this.modernTextBox4.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.modernTextBox4.PlaceholderText = "";
            this.modernTextBox4.Size = new System.Drawing.Size(152, 32);
            this.modernTextBox4.TabIndex = 74;
            this.modernTextBox4.Texts = "";
            this.modernTextBox4.UnderlinedStyle = false;
            // 
            // Cajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCategorias);
            this.Controls.Add(this.dataProducts);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cboWaiter);
            this.Controls.Add(this.modernTextBox4);
            this.Controls.Add(this.label25);
            this.Name = "Cajero";
            this.Size = new System.Drawing.Size(1014, 681);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).EndInit();
            this.pnlCategorias.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButton5;
        private TheCoffe.Components.ModernTextBox txtSearch;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label4;
        private WindowsFormsApplication1.RoundButton btnFinalizeOrder;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private CustomComboBox cboWaiter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCountProduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private TheCoffe.Components.ModernTextBox modernTextBox4;
        private System.Windows.Forms.Label lblNroMesa;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DataGridView dataProducts;
        private System.Windows.Forms.Label lblCajero;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.FlowLayoutPanel pnlProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn relleno;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.FlowLayoutPanel pnlCategorias;
        private WindowsFormsApplication1.RoundButton btnPopulares;
    }
}
