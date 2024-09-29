namespace TheCoffe.CPresentacion.Cajero
{
    partial class AddClientForm
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
            this.btnAdd = new AltoControls.AltoButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAddClient = new System.Windows.Forms.Label();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProvince = new TheCoffe.Components.ModernTextBox();
            this.txtPhone = new TheCoffe.Components.ModernTextBox();
            this.txtEmail = new TheCoffe.Components.ModernTextBox();
            this.txtCuit = new TheCoffe.Components.ModernTextBox();
            this.txtLocality = new TheCoffe.Components.ModernTextBox();
            this.txtAdress = new TheCoffe.Components.ModernTextBox();
            this.txtLastName = new TheCoffe.Components.ModernTextBox();
            this.txtName = new TheCoffe.Components.ModernTextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnAdd.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnAdd.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnAdd.Location = new System.Drawing.Point(19, 404);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Radius = 10;
            this.btnAdd.Size = new System.Drawing.Size(413, 45);
            this.btnAdd.Stroke = false;
            this.btnAdd.StrokeColor = System.Drawing.Color.Gray;
            this.btnAdd.TabIndex = 73;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.Transparency = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 68;
            this.label3.Text = "Localidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 66;
            this.label2.Text = "Domicilio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 63;
            this.label1.Text = "Apellido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 61;
            this.label9.Text = "Nombre";
            // 
            // lblAddClient
            // 
            this.lblAddClient.AutoSize = true;
            this.lblAddClient.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.lblAddClient.Location = new System.Drawing.Point(17, 17);
            this.lblAddClient.Name = "lblAddClient";
            this.lblAddClient.Size = new System.Drawing.Size(138, 22);
            this.lblAddClient.TabIndex = 60;
            this.lblAddClient.Text = "Agregar Cliente";
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
            this.btnClose.Location = new System.Drawing.Point(396, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 37);
            this.btnClose.TabIndex = 59;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 77;
            this.label6.Text = "CUIT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(234, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 81;
            this.label5.Text = "Teléfono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 79;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(234, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 83;
            this.label8.Text = "Provincia";
            // 
            // txtProvince
            // 
            this.txtProvince.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtProvince.BorderColor = System.Drawing.Color.Transparent;
            this.txtProvince.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtProvince.BorderRadius = 10;
            this.txtProvince.BorderSize = 1;
            this.txtProvince.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvince.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProvince.Location = new System.Drawing.Point(237, 246);
            this.txtProvince.Margin = new System.Windows.Forms.Padding(4);
            this.txtProvince.Multiline = false;
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.txtProvince.PasswordChar = false;
            this.txtProvince.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtProvince.PlaceholderText = "";
            this.txtProvince.Size = new System.Drawing.Size(195, 46);
            this.txtProvince.TabIndex = 84;
            this.txtProvince.Texts = "";
            this.txtProvince.UnderlinedStyle = false;
            this.txtProvince.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateLetters_KeyPress);
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtPhone.BorderColor = System.Drawing.Color.Transparent;
            this.txtPhone.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtPhone.BorderRadius = 10;
            this.txtPhone.BorderSize = 1;
            this.txtPhone.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPhone.Location = new System.Drawing.Point(237, 328);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Multiline = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.txtPhone.PasswordChar = false;
            this.txtPhone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.Size = new System.Drawing.Size(195, 46);
            this.txtPhone.TabIndex = 82;
            this.txtPhone.Texts = "";
            this.txtPhone.UnderlinedStyle = false;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateDigits_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtEmail.BorderColor = System.Drawing.Color.Transparent;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.BorderSize = 1;
            this.txtEmail.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.Location = new System.Drawing.Point(16, 328);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.Size = new System.Drawing.Size(195, 46);
            this.txtEmail.TabIndex = 80;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = false;
            // 
            // txtCuit
            // 
            this.txtCuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtCuit.BorderColor = System.Drawing.Color.Transparent;
            this.txtCuit.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtCuit.BorderRadius = 10;
            this.txtCuit.BorderSize = 1;
            this.txtCuit.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCuit.Location = new System.Drawing.Point(16, 165);
            this.txtCuit.Margin = new System.Windows.Forms.Padding(4);
            this.txtCuit.Multiline = false;
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.txtCuit.PasswordChar = false;
            this.txtCuit.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCuit.PlaceholderText = "";
            this.txtCuit.Size = new System.Drawing.Size(195, 46);
            this.txtCuit.TabIndex = 78;
            this.txtCuit.Texts = "";
            this.txtCuit.UnderlinedStyle = false;
            this.txtCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateDigits_KeyPress);
            // 
            // txtLocality
            // 
            this.txtLocality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtLocality.BorderColor = System.Drawing.Color.Transparent;
            this.txtLocality.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtLocality.BorderRadius = 10;
            this.txtLocality.BorderSize = 1;
            this.txtLocality.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLocality.Location = new System.Drawing.Point(16, 246);
            this.txtLocality.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocality.Multiline = false;
            this.txtLocality.Name = "txtLocality";
            this.txtLocality.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.txtLocality.PasswordChar = false;
            this.txtLocality.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLocality.PlaceholderText = "";
            this.txtLocality.Size = new System.Drawing.Size(195, 46);
            this.txtLocality.TabIndex = 69;
            this.txtLocality.Texts = "";
            this.txtLocality.UnderlinedStyle = false;
            this.txtLocality.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateLetters_KeyPress);
            // 
            // txtAdress
            // 
            this.txtAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtAdress.BorderColor = System.Drawing.Color.Transparent;
            this.txtAdress.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtAdress.BorderRadius = 10;
            this.txtAdress.BorderSize = 1;
            this.txtAdress.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAdress.Location = new System.Drawing.Point(237, 165);
            this.txtAdress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdress.Multiline = false;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.txtAdress.PasswordChar = false;
            this.txtAdress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAdress.PlaceholderText = "";
            this.txtAdress.Size = new System.Drawing.Size(195, 46);
            this.txtAdress.TabIndex = 67;
            this.txtAdress.Texts = "";
            this.txtAdress.UnderlinedStyle = false;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtLastName.BorderColor = System.Drawing.Color.Transparent;
            this.txtLastName.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtLastName.BorderRadius = 10;
            this.txtLastName.BorderSize = 1;
            this.txtLastName.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLastName.Location = new System.Drawing.Point(237, 83);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Multiline = false;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.txtLastName.PasswordChar = false;
            this.txtLastName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLastName.PlaceholderText = "";
            this.txtLastName.Size = new System.Drawing.Size(195, 46);
            this.txtLastName.TabIndex = 64;
            this.txtLastName.Texts = "";
            this.txtLastName.UnderlinedStyle = false;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateLetters_KeyPress);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtName.BorderColor = System.Drawing.Color.Transparent;
            this.txtName.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtName.BorderRadius = 10;
            this.txtName.BorderSize = 1;
            this.txtName.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.Location = new System.Drawing.Point(16, 83);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceholderText = "";
            this.txtName.Size = new System.Drawing.Size(195, 46);
            this.txtName.TabIndex = 62;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = false;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateLetters_KeyPress);
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(451, 466);
            this.Controls.Add(this.txtProvince);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtLocality);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblAddClient);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddClientForm";
            this.Deactivate += new System.EventHandler(this.AddClientForm_Deactivate);
            this.Load += new System.EventHandler(this.AddClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AltoControls.AltoButton btnAdd;
        private Components.ModernTextBox txtLocality;
        private System.Windows.Forms.Label label3;
        private Components.ModernTextBox txtAdress;
        private System.Windows.Forms.Label label2;
        private Components.ModernTextBox txtLastName;
        private System.Windows.Forms.Label label1;
        private Components.ModernTextBox txtName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAddClient;
        private FontAwesome.Sharp.IconButton btnClose;
        private Components.ModernTextBox txtCuit;
        private System.Windows.Forms.Label label6;
        private Components.ModernTextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private Components.ModernTextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private Components.ModernTextBox txtProvince;
        private System.Windows.Forms.Label label8;
    }
}