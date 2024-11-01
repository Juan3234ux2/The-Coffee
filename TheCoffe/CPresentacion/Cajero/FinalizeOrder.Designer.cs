using TheCoffe.CPresentacion.Components;

namespace TheCoffe.CPresentacion.Cajero
{
    partial class FinalizeOrder
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
            this.lblAddClient = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClient = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPago = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRecibo = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCash = new TheCoffe.Components.ModernTextBox();
            this.cboRecibo = new TheCoffe.CPresentacion.Components.CustomComboBox();
            this.modernTextBox2 = new TheCoffe.Components.ModernTextBox();
            this.cboPago = new TheCoffe.CPresentacion.Components.CustomComboBox();
            this.modernTextBox1 = new TheCoffe.Components.ModernTextBox();
            this.btnFinalizeOrder = new WindowsFormsApplication1.RoundButton();
            this.btnAddClient = new WindowsFormsApplication1.RoundButton();
            this.cboCustomer = new TheCoffe.CPresentacion.Components.CustomComboBox();
            this.modernTextBox4 = new TheCoffe.Components.ModernTextBox();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataProducts = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblCajero = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblVuelto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddClient
            // 
            this.lblAddClient.AutoSize = true;
            this.lblAddClient.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.lblAddClient.Location = new System.Drawing.Point(22, 16);
            this.lblAddClient.Name = "lblAddClient";
            this.lblAddClient.Size = new System.Drawing.Size(226, 22);
            this.lblAddClient.TabIndex = 62;
            this.lblAddClient.Text = "Finalizar Pedido - Mesa 10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(428, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 63;
            this.label7.Text = "Cliente";
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClient.FlatAppearance.BorderSize = 0;
            this.btnClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.btnClient.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnClient.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnClient.IconSize = 25;
            this.btnClient.Location = new System.Drawing.Point(704, 116);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(34, 35);
            this.btnClient.TabIndex = 66;
            this.btnClient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnClose.IconSize = 44;
            this.btnClose.Location = new System.Drawing.Point(772, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 37);
            this.btnClose.TabIndex = 61;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.label1.Location = new System.Drawing.Point(22, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 68;
            this.label1.Text = "Consumido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.label2.Location = new System.Drawing.Point(428, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 18);
            this.label2.TabIndex = 69;
            this.label2.Text = "Pago";
            // 
            // btnPago
            // 
            this.btnPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPago.FlatAppearance.BorderSize = 0;
            this.btnPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPago.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.btnPago.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnPago.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnPago.IconSize = 25;
            this.btnPago.Location = new System.Drawing.Point(648, 279);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(34, 35);
            this.btnPago.TabIndex = 74;
            this.btnPago.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPago.UseVisualStyleBackColor = false;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(428, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 71;
            this.label3.Text = "Medio De Pago";
            // 
            // btnRecibo
            // 
            this.btnRecibo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnRecibo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecibo.FlatAppearance.BorderSize = 0;
            this.btnRecibo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnRecibo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnRecibo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecibo.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.btnRecibo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnRecibo.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnRecibo.IconSize = 25;
            this.btnRecibo.Location = new System.Drawing.Point(758, 199);
            this.btnRecibo.Name = "btnRecibo";
            this.btnRecibo.Size = new System.Drawing.Size(34, 35);
            this.btnRecibo.TabIndex = 78;
            this.btnRecibo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRecibo.UseVisualStyleBackColor = false;
            this.btnRecibo.Click += new System.EventHandler(this.btnRecibo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(428, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 75;
            this.label4.Text = "Tipo Recibo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(701, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 79;
            this.label5.Text = "Recibido $";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(428, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 18);
            this.label8.TabIndex = 82;
            this.label8.Text = "Vuelto: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(23, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 18);
            this.label9.TabIndex = 85;
            this.label9.Text = "Total: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(23, 331);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 18);
            this.label17.TabIndex = 86;
            this.label17.Text = "Mesero:";
            // 
            // txtCash
            // 
            this.txtCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtCash.BorderColor = System.Drawing.Color.Transparent;
            this.txtCash.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtCash.BorderRadius = 10;
            this.txtCash.BorderSize = 1;
            this.txtCash.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCash.Location = new System.Drawing.Point(704, 270);
            this.txtCash.Margin = new System.Windows.Forms.Padding(4);
            this.txtCash.Multiline = false;
            this.txtCash.Name = "txtCash";
            this.txtCash.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.txtCash.PasswordChar = false;
            this.txtCash.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCash.PlaceholderText = "";
            this.txtCash.Size = new System.Drawing.Size(93, 46);
            this.txtCash.TabIndex = 80;
            this.txtCash.Texts = "";
            this.txtCash.UnderlinedStyle = false;
            this.txtCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCash_KeyPress);
            this.txtCash._TextChanged += new System.EventHandler(this.txtCash__TextChanged);
            // 
            // cboRecibo
            // 
            this.cboRecibo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cboRecibo.BorderColor = System.Drawing.Color.Transparent;
            this.cboRecibo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboRecibo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRecibo.DropDownWidth = 360;
            this.cboRecibo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboRecibo.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRecibo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboRecibo.FormattingEnabled = true;
            this.cboRecibo.Items.AddRange(new object[] {
            "Ticket ",
            "Factura"});
            this.cboRecibo.Location = new System.Drawing.Point(437, 202);
            this.cboRecibo.Name = "cboRecibo";
            this.cboRecibo.Size = new System.Drawing.Size(319, 24);
            this.cboRecibo.TabIndex = 77;
            this.cboRecibo.SelectedIndexChanged += new System.EventHandler(this.cboRecibo_SelectedIndexChanged);
            // 
            // modernTextBox2
            // 
            this.modernTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.modernTextBox2.BorderColor = System.Drawing.Color.Transparent;
            this.modernTextBox2.BorderFocusColor = System.Drawing.Color.Transparent;
            this.modernTextBox2.BorderRadius = 10;
            this.modernTextBox2.BorderSize = 1;
            this.modernTextBox2.Enabled = false;
            this.modernTextBox2.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modernTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modernTextBox2.Location = new System.Drawing.Point(431, 190);
            this.modernTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.modernTextBox2.Multiline = false;
            this.modernTextBox2.Name = "modernTextBox2";
            this.modernTextBox2.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.modernTextBox2.PasswordChar = false;
            this.modernTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.modernTextBox2.PlaceholderText = "";
            this.modernTextBox2.Size = new System.Drawing.Size(366, 46);
            this.modernTextBox2.TabIndex = 76;
            this.modernTextBox2.Texts = "";
            this.modernTextBox2.UnderlinedStyle = false;
            // 
            // cboPago
            // 
            this.cboPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cboPago.BorderColor = System.Drawing.Color.Transparent;
            this.cboPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPago.DropDownWidth = 249;
            this.cboPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPago.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboPago.FormattingEnabled = true;
            this.cboPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta de Débito"});
            this.cboPago.Location = new System.Drawing.Point(437, 282);
            this.cboPago.Name = "cboPago";
            this.cboPago.Size = new System.Drawing.Size(216, 24);
            this.cboPago.TabIndex = 73;
            // 
            // modernTextBox1
            // 
            this.modernTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.modernTextBox1.BorderColor = System.Drawing.Color.Transparent;
            this.modernTextBox1.BorderFocusColor = System.Drawing.Color.Transparent;
            this.modernTextBox1.BorderRadius = 10;
            this.modernTextBox1.BorderSize = 1;
            this.modernTextBox1.Enabled = false;
            this.modernTextBox1.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modernTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modernTextBox1.Location = new System.Drawing.Point(431, 270);
            this.modernTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.modernTextBox1.Multiline = false;
            this.modernTextBox1.Name = "modernTextBox1";
            this.modernTextBox1.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.modernTextBox1.PasswordChar = false;
            this.modernTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.modernTextBox1.PlaceholderText = "";
            this.modernTextBox1.Size = new System.Drawing.Size(255, 46);
            this.modernTextBox1.TabIndex = 72;
            this.modernTextBox1.Texts = "";
            this.modernTextBox1.UnderlinedStyle = false;
            // 
            // btnFinalizeOrder
            // 
            this.btnFinalizeOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnFinalizeOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnFinalizeOrder.BorderColor = System.Drawing.Color.Black;
            this.btnFinalizeOrder.BorderRadius = 6;
            this.btnFinalizeOrder.BorderSize = 0;
            this.btnFinalizeOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizeOrder.FlatAppearance.BorderSize = 0;
            this.btnFinalizeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizeOrder.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnFinalizeOrder.ForeColor = System.Drawing.Color.White;
            this.btnFinalizeOrder.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnFinalizeOrder.IconColor = System.Drawing.Color.White;
            this.btnFinalizeOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFinalizeOrder.IconSize = 34;
            this.btnFinalizeOrder.Location = new System.Drawing.Point(637, 386);
            this.btnFinalizeOrder.Name = "btnFinalizeOrder";
            this.btnFinalizeOrder.Size = new System.Drawing.Size(160, 46);
            this.btnFinalizeOrder.TabIndex = 70;
            this.btnFinalizeOrder.Text = "Finalizar Pedido";
            this.btnFinalizeOrder.TextColor = System.Drawing.Color.White;
            this.btnFinalizeOrder.UseVisualStyleBackColor = false;
            this.btnFinalizeOrder.Click += new System.EventHandler(this.btnFinalizeOrder_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnAddClient.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnAddClient.BorderColor = System.Drawing.Color.Black;
            this.btnAddClient.BorderRadius = 6;
            this.btnAddClient.BorderSize = 0;
            this.btnAddClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddClient.FlatAppearance.BorderSize = 0;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.Font = new System.Drawing.Font("Roboto Black", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.ForeColor = System.Drawing.Color.White;
            this.btnAddClient.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddClient.IconColor = System.Drawing.Color.White;
            this.btnAddClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddClient.IconSize = 30;
            this.btnAddClient.Location = new System.Drawing.Point(751, 108);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
            this.btnAddClient.Size = new System.Drawing.Size(46, 46);
            this.btnAddClient.TabIndex = 67;
            this.btnAddClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddClient.TextColor = System.Drawing.Color.White;
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // cboCustomer
            // 
            this.cboCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cboCustomer.BorderColor = System.Drawing.Color.Transparent;
            this.cboCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomer.DropDownWidth = 307;
            this.cboCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCustomer.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(437, 120);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(267, 24);
            this.cboCustomer.TabIndex = 65;
            // 
            // modernTextBox4
            // 
            this.modernTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.modernTextBox4.BorderColor = System.Drawing.Color.Transparent;
            this.modernTextBox4.BorderFocusColor = System.Drawing.Color.Transparent;
            this.modernTextBox4.BorderRadius = 10;
            this.modernTextBox4.BorderSize = 1;
            this.modernTextBox4.Enabled = false;
            this.modernTextBox4.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modernTextBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modernTextBox4.Location = new System.Drawing.Point(431, 108);
            this.modernTextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.modernTextBox4.Multiline = false;
            this.modernTextBox4.Name = "modernTextBox4";
            this.modernTextBox4.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.modernTextBox4.PasswordChar = false;
            this.modernTextBox4.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.modernTextBox4.PlaceholderText = "";
            this.modernTextBox4.Size = new System.Drawing.Size(313, 46);
            this.modernTextBox4.TabIndex = 64;
            this.modernTextBox4.Texts = "";
            this.modernTextBox4.UnderlinedStyle = false;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            this.precio.FillWeight = 83.75633F;
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.FillWeight = 156.1607F;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.FillWeight = 60.08295F;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // dataProducts
            // 
            this.dataProducts.AllowUserToAddRows = false;
            this.dataProducts.AllowUserToDeleteRows = false;
            this.dataProducts.AllowUserToResizeColumns = false;
            this.dataProducts.AllowUserToResizeRows = false;
            this.dataProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataProducts.BackgroundColor = System.Drawing.Color.White;
            this.dataProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProducts.ColumnHeadersVisible = false;
            this.dataProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cantidad,
            this.nombre,
            this.precio});
            this.dataProducts.EnableHeadersVisualStyles = false;
            this.dataProducts.Location = new System.Drawing.Point(25, 87);
            this.dataProducts.MultiSelect = false;
            this.dataProducts.Name = "dataProducts";
            this.dataProducts.ReadOnly = true;
            this.dataProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataProducts.RowHeadersVisible = false;
            this.dataProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataProducts.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataProducts.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto Medium", 9.5F);
            this.dataProducts.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataProducts.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dataProducts.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataProducts.RowTemplate.DividerHeight = 1;
            this.dataProducts.RowTemplate.Height = 40;
            this.dataProducts.RowTemplate.ReadOnly = true;
            this.dataProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataProducts.ShowCellErrors = false;
            this.dataProducts.ShowCellToolTips = false;
            this.dataProducts.ShowEditingIcon = false;
            this.dataProducts.ShowRowErrors = false;
            this.dataProducts.Size = new System.Drawing.Size(370, 226);
            this.dataProducts.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblCajero);
            this.panel6.Location = new System.Drawing.Point(220, 332);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(172, 17);
            this.panel6.TabIndex = 88;
            // 
            // lblCajero
            // 
            this.lblCajero.AutoSize = true;
            this.lblCajero.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCajero.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold);
            this.lblCajero.Location = new System.Drawing.Point(77, 0);
            this.lblCajero.Name = "lblCajero";
            this.lblCajero.Size = new System.Drawing.Size(95, 18);
            this.lblCajero.TabIndex = 6;
            this.lblCajero.Text = "Juan Coronel";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Location = new System.Drawing.Point(220, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 17);
            this.panel1.TabIndex = 89;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(142, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(30, 18);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "$ 0";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblVuelto);
            this.panel2.Location = new System.Drawing.Point(629, 356);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 17);
            this.panel2.TabIndex = 90;
            // 
            // lblVuelto
            // 
            this.lblVuelto.AutoSize = true;
            this.lblVuelto.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblVuelto.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold);
            this.lblVuelto.Location = new System.Drawing.Point(142, 0);
            this.lblVuelto.Name = "lblVuelto";
            this.lblVuelto.Size = new System.Drawing.Size(30, 18);
            this.lblVuelto.TabIndex = 6;
            this.lblVuelto.Text = "$ 0";
            // 
            // FinalizeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(825, 444);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.dataProducts);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRecibo);
            this.Controls.Add(this.cboRecibo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.modernTextBox2);
            this.Controls.Add(this.btnPago);
            this.Controls.Add(this.cboPago);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.modernTextBox1);
            this.Controls.Add(this.btnFinalizeOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.cboCustomer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.modernTextBox4);
            this.Controls.Add(this.lblAddClient);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FinalizeOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FinalizeOrder";
            this.Deactivate += new System.EventHandler(this.FinalizeOrder_Deactivate);
            this.Load += new System.EventHandler(this.FinalizeOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddClient;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnClient;
        private CustomComboBox cboCustomer;
        private System.Windows.Forms.Label label7;
        private TheCoffe.Components.ModernTextBox modernTextBox4;
        private WindowsFormsApplication1.RoundButton btnAddClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private WindowsFormsApplication1.RoundButton btnFinalizeOrder;
        private FontAwesome.Sharp.IconButton btnPago;
        private CustomComboBox cboPago;
        private System.Windows.Forms.Label label3;
        private TheCoffe.Components.ModernTextBox modernTextBox1;
        private FontAwesome.Sharp.IconButton btnRecibo;
        private CustomComboBox cboRecibo;
        private System.Windows.Forms.Label label4;
        private TheCoffe.Components.ModernTextBox modernTextBox2;
        private System.Windows.Forms.Label label5;
        private TheCoffe.Components.ModernTextBox txtCash;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridView dataProducts;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblCajero;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblVuelto;
    }
}