namespace TheCoffe.CPresentacion
{
    partial class ProfileForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.sPanel1 = new Sipaa.Framework.SPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.pboUser = new System.Windows.Forms.PictureBox();
            this.sPanel2 = new Sipaa.Framework.SPanel();
            this.btnEditUser = new WindowsFormsApplication1.RoundButton();
            this.txtNumber = new TheCoffe.Components.ModernTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnWatchPassword = new WindowsFormsApplication1.RoundButton();
            this.txtPassword = new TheCoffe.Components.ModernTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUser = new TheCoffe.Components.ModernTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLastName = new TheCoffe.Components.ModernTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtName = new TheCoffe.Components.ModernTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRol = new TheCoffe.Components.ModernTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditAvatar = new WindowsFormsApplication1.RoundButton();
            this.selectImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.sPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboUser)).BeginInit();
            this.sPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Perfil";
            // 
            // sPanel1
            // 
            this.sPanel1.BackColor = System.Drawing.Color.White;
            this.sPanel1.BorderColor = System.Drawing.Color.White;
            this.sPanel1.BorderRadius = 15;
            this.sPanel1.BorderSize = 0;
            this.sPanel1.Controls.Add(this.btnEditAvatar);
            this.sPanel1.Controls.Add(this.button1);
            this.sPanel1.Controls.Add(this.btnLogout);
            this.sPanel1.Controls.Add(this.iconButton2);
            this.sPanel1.Controls.Add(this.iconButton1);
            this.sPanel1.Controls.Add(this.label3);
            this.sPanel1.Controls.Add(this.lblUser);
            this.sPanel1.Controls.Add(this.pboUser);
            this.sPanel1.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sPanel1.ForeColor = System.Drawing.Color.White;
            this.sPanel1.Location = new System.Drawing.Point(19, 79);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Size = new System.Drawing.Size(355, 564);
            this.sPanel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(349, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(6, 50);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.DimGray;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnLogout.IconColor = System.Drawing.Color.DimGray;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnLogout.IconSize = 35;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 325);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(358, 50);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Cerrar Sesión";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton2.IconSize = 35;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 489);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton2.Size = new System.Drawing.Size(358, 50);
            this.iconButton2.TabIndex = 4;
            this.iconButton2.Text = "Eliminar Cuenta";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.DimGray;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton1.IconColor = System.Drawing.Color.DimGray;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 35;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 269);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(358, 50);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.Text = "Información personal";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(129, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Administrador";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Roboto Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(96, 202);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(149, 25);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Juan Coronel";
            // 
            // pboUser
            // 
            this.pboUser.Image = global::TheCoffe.Properties.Resources.hombre;
            this.pboUser.InitialImage = global::TheCoffe.Properties.Resources.hombre;
            this.pboUser.Location = new System.Drawing.Point(86, 49);
            this.pboUser.Name = "pboUser";
            this.pboUser.Size = new System.Drawing.Size(171, 143);
            this.pboUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboUser.TabIndex = 0;
            this.pboUser.TabStop = false;
            // 
            // sPanel2
            // 
            this.sPanel2.BackColor = System.Drawing.Color.White;
            this.sPanel2.BorderColor = System.Drawing.Color.White;
            this.sPanel2.BorderRadius = 15;
            this.sPanel2.BorderSize = 0;
            this.sPanel2.Controls.Add(this.btnEditUser);
            this.sPanel2.Controls.Add(this.txtNumber);
            this.sPanel2.Controls.Add(this.label5);
            this.sPanel2.Controls.Add(this.btnWatchPassword);
            this.sPanel2.Controls.Add(this.txtPassword);
            this.sPanel2.Controls.Add(this.label6);
            this.sPanel2.Controls.Add(this.txtUser);
            this.sPanel2.Controls.Add(this.label7);
            this.sPanel2.Controls.Add(this.label8);
            this.sPanel2.Controls.Add(this.txtLastName);
            this.sPanel2.Controls.Add(this.label9);
            this.sPanel2.Controls.Add(this.txtName);
            this.sPanel2.Controls.Add(this.label10);
            this.sPanel2.Controls.Add(this.txtRol);
            this.sPanel2.Controls.Add(this.label4);
            this.sPanel2.ForeColor = System.Drawing.Color.Black;
            this.sPanel2.Location = new System.Drawing.Point(403, 79);
            this.sPanel2.Name = "sPanel2";
            this.sPanel2.Size = new System.Drawing.Size(594, 564);
            this.sPanel2.TabIndex = 4;
            // 
            // btnEditUser
            // 
            this.btnEditUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnEditUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnEditUser.BorderColor = System.Drawing.Color.Black;
            this.btnEditUser.BorderRadius = 5;
            this.btnEditUser.BorderSize = 0;
            this.btnEditUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditUser.FlatAppearance.BorderSize = 0;
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUser.ForeColor = System.Drawing.Color.White;
            this.btnEditUser.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEditUser.IconColor = System.Drawing.Color.White;
            this.btnEditUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditUser.IconSize = 20;
            this.btnEditUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditUser.Location = new System.Drawing.Point(35, 496);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(528, 43);
            this.btnEditUser.TabIndex = 74;
            this.btnEditUser.Text = "Guardar Cambios";
            this.btnEditUser.TextColor = System.Drawing.Color.White;
            this.btnEditUser.UseVisualStyleBackColor = false;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtNumber.BorderColor = System.Drawing.Color.Transparent;
            this.txtNumber.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtNumber.BorderRadius = 10;
            this.txtNumber.BorderSize = 1;
            this.txtNumber.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNumber.Location = new System.Drawing.Point(308, 258);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumber.Multiline = false;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.txtNumber.PasswordChar = false;
            this.txtNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNumber.PlaceholderText = "";
            this.txtNumber.Size = new System.Drawing.Size(255, 46);
            this.txtNumber.TabIndex = 70;
            this.txtNumber.Texts = "3782452892";
            this.txtNumber.UnderlinedStyle = false;
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(305, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 69;
            this.label5.Text = "Teléfono";
            // 
            // btnWatchPassword
            // 
            this.btnWatchPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnWatchPassword.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnWatchPassword.BorderColor = System.Drawing.Color.Black;
            this.btnWatchPassword.BorderRadius = 0;
            this.btnWatchPassword.BorderSize = 0;
            this.btnWatchPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWatchPassword.FlatAppearance.BorderSize = 0;
            this.btnWatchPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnWatchPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnWatchPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWatchPassword.ForeColor = System.Drawing.Color.White;
            this.btnWatchPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnWatchPassword.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnWatchPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWatchPassword.IconSize = 40;
            this.btnWatchPassword.Location = new System.Drawing.Point(526, 421);
            this.btnWatchPassword.Name = "btnWatchPassword";
            this.btnWatchPassword.Size = new System.Drawing.Size(34, 36);
            this.btnWatchPassword.TabIndex = 68;
            this.btnWatchPassword.TextColor = System.Drawing.Color.White;
            this.btnWatchPassword.UseVisualStyleBackColor = false;
            this.btnWatchPassword.Click += new System.EventHandler(this.btnWatchPassword_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtPassword.BorderColor = System.Drawing.Color.Transparent;
            this.txtPassword.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.BorderSize = 1;
            this.txtPassword.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.Location = new System.Drawing.Point(35, 415);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.Size = new System.Drawing.Size(530, 46);
            this.txtPassword.TabIndex = 67;
            this.txtPassword.Texts = "Juan323";
            this.txtPassword.UnderlinedStyle = false;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateCredendials_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 66;
            this.label6.Text = "Contraseña";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtUser.BorderColor = System.Drawing.Color.Transparent;
            this.txtUser.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtUser.BorderRadius = 10;
            this.txtUser.BorderSize = 1;
            this.txtUser.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUser.Location = new System.Drawing.Point(35, 339);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Multiline = false;
            this.txtUser.Name = "txtUser";
            this.txtUser.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.txtUser.PasswordChar = false;
            this.txtUser.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUser.PlaceholderText = "";
            this.txtUser.Size = new System.Drawing.Size(530, 46);
            this.txtUser.TabIndex = 65;
            this.txtUser.Texts = "Juan3234";
            this.txtUser.UnderlinedStyle = false;
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateCredendials_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 64;
            this.label7.Text = "Usuario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 15);
            this.label8.TabIndex = 63;
            this.label8.Text = "Rol";
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
            this.txtLastName.Location = new System.Drawing.Point(35, 176);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Multiline = false;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.txtLastName.PasswordChar = false;
            this.txtLastName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLastName.PlaceholderText = "";
            this.txtLastName.Size = new System.Drawing.Size(530, 46);
            this.txtLastName.TabIndex = 62;
            this.txtLastName.Texts = "Coronel";
            this.txtLastName.UnderlinedStyle = false;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateLetters_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 61;
            this.label9.Text = "Apellido";
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
            this.txtName.Location = new System.Drawing.Point(32, 98);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceholderText = "";
            this.txtName.Size = new System.Drawing.Size(530, 46);
            this.txtName.TabIndex = 60;
            this.txtName.Texts = "Juan";
            this.txtName.UnderlinedStyle = false;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateLetters_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 15);
            this.label10.TabIndex = 59;
            this.label10.Text = "Nombre";
            // 
            // txtRol
            // 
            this.txtRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtRol.BorderColor = System.Drawing.Color.Transparent;
            this.txtRol.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtRol.BorderRadius = 10;
            this.txtRol.BorderSize = 1;
            this.txtRol.Enabled = false;
            this.txtRol.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRol.Location = new System.Drawing.Point(35, 258);
            this.txtRol.Margin = new System.Windows.Forms.Padding(4);
            this.txtRol.Multiline = false;
            this.txtRol.Name = "txtRol";
            this.txtRol.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.txtRol.PasswordChar = false;
            this.txtRol.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtRol.PlaceholderText = "";
            this.txtRol.Size = new System.Drawing.Size(252, 46);
            this.txtRol.TabIndex = 71;
            this.txtRol.Texts = "";
            this.txtRol.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(27, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Información Personal";
            // 
            // btnEditAvatar
            // 
            this.btnEditAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnEditAvatar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnEditAvatar.BorderColor = System.Drawing.Color.Black;
            this.btnEditAvatar.BorderRadius = 20;
            this.btnEditAvatar.BorderSize = 0;
            this.btnEditAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditAvatar.FlatAppearance.BorderSize = 0;
            this.btnEditAvatar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnEditAvatar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnEditAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAvatar.ForeColor = System.Drawing.Color.White;
            this.btnEditAvatar.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnEditAvatar.IconColor = System.Drawing.Color.White;
            this.btnEditAvatar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditAvatar.IconSize = 25;
            this.btnEditAvatar.Location = new System.Drawing.Point(215, 164);
            this.btnEditAvatar.Name = "btnEditAvatar";
            this.btnEditAvatar.Padding = new System.Windows.Forms.Padding(2, 4, 0, 0);
            this.btnEditAvatar.Size = new System.Drawing.Size(42, 40);
            this.btnEditAvatar.TabIndex = 7;
            this.btnEditAvatar.TextColor = System.Drawing.Color.White;
            this.btnEditAvatar.UseVisualStyleBackColor = false;
            this.btnEditAvatar.Click += new System.EventHandler(this.btnEditAvatar_Click);
            // 
            // selectImageDialog
            // 
            this.selectImageDialog.FileName = "openFileDialog1";
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.sPanel2);
            this.Controls.Add(this.sPanel1);
            this.Controls.Add(this.label1);
            this.Name = "ProfileForm";
            this.Size = new System.Drawing.Size(1014, 681);
            this.sPanel1.ResumeLayout(false);
            this.sPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboUser)).EndInit();
            this.sPanel2.ResumeLayout(false);
            this.sPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Sipaa.Framework.SPanel sPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pboUser;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Sipaa.Framework.SPanel sPanel2;
        private System.Windows.Forms.Label label4;
        private TheCoffe.Components.ModernTextBox txtNumber;
        private System.Windows.Forms.Label label5;
        private WindowsFormsApplication1.RoundButton btnWatchPassword;
        private TheCoffe.Components.ModernTextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private TheCoffe.Components.ModernTextBox txtUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private TheCoffe.Components.ModernTextBox txtLastName;
        private System.Windows.Forms.Label label9;
        private TheCoffe.Components.ModernTextBox txtName;
        private System.Windows.Forms.Label label10;
        private TheCoffe.Components.ModernTextBox txtRol;
        private WindowsFormsApplication1.RoundButton btnEditUser;
        private System.Windows.Forms.Button button1;
        private WindowsFormsApplication1.RoundButton btnEditAvatar;
        private System.Windows.Forms.OpenFileDialog selectImageDialog;
    }
}
