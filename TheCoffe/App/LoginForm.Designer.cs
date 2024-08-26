namespace TheCoffe
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnLogin = new AltoControls.AltoButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
<<<<<<< Updated upstream
=======
            this.modernTextBox2 = new TheCoffe.ModernTextBox();
            this.modernTextBox3 = new TheCoffe.ModernTextBox();
>>>>>>> Stashed changes
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 475);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TheCoffe.Properties.Resources.The_Coffee__600_x_600_px___1_;
            this.pictureBox1.InitialImage = global::TheCoffe.Properties.Resources.The_Coffee__600_x_600_px___1_;
            this.pictureBox1.Location = new System.Drawing.Point(-9, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 276);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
<<<<<<< Updated upstream
            this.label2.Font = new System.Drawing.Font("Gilroy-Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
=======
            this.label2.Font = new System.Drawing.Font("Gilroy-SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
>>>>>>> Stashed changes
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Al punto de venta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
<<<<<<< Updated upstream
            this.label1.Font = new System.Drawing.Font("Gilroy-Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 50);
=======
            this.label1.Font = new System.Drawing.Font("Gilroy-Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 49);
>>>>>>> Stashed changes
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Gilroy-Bold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(388, 85);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(268, 49);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Iniciar Sesión";
            // 
            // btnLogin
            // 
            this.btnLogin.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnLogin.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
<<<<<<< Updated upstream
            this.btnLogin.Font = new System.Drawing.Font("Gilroy-Bold", 11F, System.Drawing.FontStyle.Bold);
=======
            this.btnLogin.Font = new System.Drawing.Font("Gilroy-SemiBold", 11F);
>>>>>>> Stashed changes
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnLogin.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnLogin.Location = new System.Drawing.Point(372, 323);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Radius = 10;
            this.btnLogin.Size = new System.Drawing.Size(295, 48);
            this.btnLogin.Stroke = false;
            this.btnLogin.StrokeColor = System.Drawing.Color.Gray;
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.Transparency = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
<<<<<<< Updated upstream
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Transparent;
            this.txtUser.Br = System.Drawing.Color.White;
            this.txtUser.Font = new System.Drawing.Font("Gilroy-Bold", 11F);
            this.txtUser.ForeColor = System.Drawing.Color.DimGray;
            this.txtUser.Location = new System.Drawing.Point(374, 168);
            this.txtUser.Name = "txtUser";
            this.txtUser.PlaceHolder = "Usuario";
            this.txtUser.Size = new System.Drawing.Size(295, 45);
            this.txtUser.TabIndex = 8;
            this.txtUser.Text = "Usuario";
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.Transparent;
            this.txtContraseña.Br = System.Drawing.Color.White;
            this.txtContraseña.Font = new System.Drawing.Font("Gilroy-Bold", 11F);
            this.txtContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.txtContraseña.Location = new System.Drawing.Point(374, 248);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PlaceHolder = "Contraseña";
            this.txtContraseña.Size = new System.Drawing.Size(295, 45);
            this.txtContraseña.TabIndex = 9;
            this.txtContraseña.Text = "Contraseña";
            // 
=======
>>>>>>> Stashed changes
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnClose.IconColor = System.Drawing.Color.Red;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnClose.IconSize = 44;
            this.btnClose.Location = new System.Drawing.Point(715, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 34);
            this.btnClose.TabIndex = 10;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
<<<<<<< Updated upstream
=======
            // modernTextBox2
            // 
            this.modernTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.modernTextBox2.BorderColor = System.Drawing.Color.Black;
            this.modernTextBox2.BorderFocusColor = System.Drawing.Color.Black;
            this.modernTextBox2.BorderRadius = 8;
            this.modernTextBox2.BorderSize = 1;
            this.modernTextBox2.Font = new System.Drawing.Font("Roboto Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modernTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modernTextBox2.Location = new System.Drawing.Point(374, 169);
            this.modernTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.modernTextBox2.Multiline = false;
            this.modernTextBox2.Name = "modernTextBox2";
            this.modernTextBox2.Padding = new System.Windows.Forms.Padding(10, 16, 10, 7);
            this.modernTextBox2.PasswordChar = false;
            this.modernTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.modernTextBox2.PlaceholderText = "Usuario";
            this.modernTextBox2.Size = new System.Drawing.Size(293, 50);
            this.modernTextBox2.TabIndex = 12;
            this.modernTextBox2.Texts = "";
            this.modernTextBox2.UnderlinedStyle = false;
            // 
            // modernTextBox3
            // 
            this.modernTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.modernTextBox3.BorderColor = System.Drawing.Color.Black;
            this.modernTextBox3.BorderFocusColor = System.Drawing.Color.Black;
            this.modernTextBox3.BorderRadius = 8;
            this.modernTextBox3.BorderSize = 1;
            this.modernTextBox3.Font = new System.Drawing.Font("Roboto Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modernTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modernTextBox3.Location = new System.Drawing.Point(372, 245);
            this.modernTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.modernTextBox3.Multiline = false;
            this.modernTextBox3.Name = "modernTextBox3";
            this.modernTextBox3.Padding = new System.Windows.Forms.Padding(10, 16, 10, 7);
            this.modernTextBox3.PasswordChar = true;
            this.modernTextBox3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.modernTextBox3.PlaceholderText = "Contraseña";
            this.modernTextBox3.Size = new System.Drawing.Size(293, 50);
            this.modernTextBox3.TabIndex = 13;
            this.modernTextBox3.Texts = "";
            this.modernTextBox3.UnderlinedStyle = false;
            this.modernTextBox3._TextChanged += new System.EventHandler(this.modernTextBox3__TextChanged);
            // 
>>>>>>> Stashed changes
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 475);
            this.Controls.Add(this.modernTextBox3);
            this.Controls.Add(this.modernTextBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLogin;
        private AltoControls.AltoButton btnLogin;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ModernTextBox modernTextBox2;
        private ModernTextBox modernTextBox3;
    }
}