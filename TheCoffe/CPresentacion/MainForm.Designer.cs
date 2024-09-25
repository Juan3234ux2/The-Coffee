namespace TheCoffe
{
    partial class MainForm
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.transitionTimer = new System.Windows.Forms.Timer(this.components);
            this.btnTables = new WindowsFormsApplication1.RoundButton();
            this.btnCategory = new WindowsFormsApplication1.RoundButton();
            this.btnUserList = new WindowsFormsApplication1.RoundButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUserDetails = new WindowsFormsApplication1.RoundButton();
            this.imgUser = new System.Windows.Forms.PictureBox();
            this.btnConfig = new WindowsFormsApplication1.RoundButton();
            this.btnReports = new WindowsFormsApplication1.RoundButton();
            this.btnWaiter = new WindowsFormsApplication1.RoundButton();
            this.btnProducts = new WindowsFormsApplication1.RoundButton();
            this.btnDashboard = new WindowsFormsApplication1.RoundButton();
            this.btnRemovedProducts = new WindowsFormsApplication1.RoundButton();
            this.pnlSideBar.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.White;
            this.pnlSideBar.Controls.Add(this.btnRemovedProducts);
            this.pnlSideBar.Controls.Add(this.btnTables);
            this.pnlSideBar.Controls.Add(this.btnCategory);
            this.pnlSideBar.Controls.Add(this.btnUserList);
            this.pnlSideBar.Controls.Add(this.pictureBox1);
            this.pnlSideBar.Controls.Add(this.panel3);
            this.pnlSideBar.Controls.Add(this.btnConfig);
            this.pnlSideBar.Controls.Add(this.btnReports);
            this.pnlSideBar.Controls.Add(this.btnWaiter);
            this.pnlSideBar.Controls.Add(this.btnProducts);
            this.pnlSideBar.Controls.Add(this.btnDashboard);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.MaximumSize = new System.Drawing.Size(250, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(250, 681);
            this.pnlSideBar.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnUserDetails);
            this.panel3.Controls.Add(this.lblRol);
            this.panel3.Controls.Add(this.lblUser);
            this.panel3.Controls.Add(this.imgUser);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 526);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 155);
            this.panel3.TabIndex = 2;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.Color.DimGray;
            this.lblRol.Location = new System.Drawing.Point(83, 88);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(78, 13);
            this.lblRol.TabIndex = 19;
            this.lblRol.Text = "Administrador";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(74, 70);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(95, 18);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Juan Coronel";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.DarkGray;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMain.Location = new System.Drawing.Point(250, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1014, 681);
            this.pnlMain.TabIndex = 2;
            // 
            // transitionTimer
            // 
            this.transitionTimer.Interval = 30;
            // 
            // btnTables
            // 
            this.btnTables.BackColor = System.Drawing.Color.White;
            this.btnTables.BackgroundColor = System.Drawing.Color.White;
            this.btnTables.BorderColor = System.Drawing.Color.Transparent;
            this.btnTables.BorderRadius = 10;
            this.btnTables.BorderSize = 0;
            this.btnTables.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTables.FlatAppearance.BorderSize = 0;
            this.btnTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTables.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTables.ForeColor = System.Drawing.Color.DimGray;
            this.btnTables.IconChar = FontAwesome.Sharp.IconChar.Chair;
            this.btnTables.IconColor = System.Drawing.Color.DimGray;
            this.btnTables.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTables.IconSize = 35;
            this.btnTables.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnTables.Location = new System.Drawing.Point(3, 243);
            this.btnTables.MinimumSize = new System.Drawing.Size(58, 0);
            this.btnTables.Name = "btnTables";
            this.btnTables.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.btnTables.Size = new System.Drawing.Size(244, 45);
            this.btnTables.TabIndex = 20;
            this.btnTables.Tag = "Mesas";
            this.btnTables.Text = "  Mesas";
            this.btnTables.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTables.TextColor = System.Drawing.Color.DimGray;
            this.btnTables.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTables.UseVisualStyleBackColor = false;
            this.btnTables.Click += new System.EventHandler(this.btnTables_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.White;
            this.btnCategory.BackgroundColor = System.Drawing.Color.White;
            this.btnCategory.BorderColor = System.Drawing.Color.Transparent;
            this.btnCategory.BorderRadius = 10;
            this.btnCategory.BorderSize = 0;
            this.btnCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.DimGray;
            this.btnCategory.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.btnCategory.IconColor = System.Drawing.Color.DimGray;
            this.btnCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCategory.IconSize = 35;
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCategory.Location = new System.Drawing.Point(3, 199);
            this.btnCategory.MinimumSize = new System.Drawing.Size(58, 0);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.btnCategory.Size = new System.Drawing.Size(244, 45);
            this.btnCategory.TabIndex = 19;
            this.btnCategory.Tag = "Categorias";
            this.btnCategory.Text = "  Categorias";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCategory.TextColor = System.Drawing.Color.DimGray;
            this.btnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnUserList
            // 
            this.btnUserList.BackColor = System.Drawing.Color.White;
            this.btnUserList.BackgroundColor = System.Drawing.Color.White;
            this.btnUserList.BorderColor = System.Drawing.Color.Transparent;
            this.btnUserList.BorderRadius = 10;
            this.btnUserList.BorderSize = 0;
            this.btnUserList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserList.FlatAppearance.BorderSize = 0;
            this.btnUserList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserList.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserList.ForeColor = System.Drawing.Color.DimGray;
            this.btnUserList.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.btnUserList.IconColor = System.Drawing.Color.DimGray;
            this.btnUserList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUserList.IconSize = 35;
            this.btnUserList.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnUserList.Location = new System.Drawing.Point(3, 378);
            this.btnUserList.MinimumSize = new System.Drawing.Size(58, 0);
            this.btnUserList.Name = "btnUserList";
            this.btnUserList.Padding = new System.Windows.Forms.Padding(8, 3, 0, 0);
            this.btnUserList.Size = new System.Drawing.Size(244, 45);
            this.btnUserList.TabIndex = 18;
            this.btnUserList.Tag = "Reportes";
            this.btnUserList.Text = "  Usuarios";
            this.btnUserList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUserList.TextColor = System.Drawing.Color.DimGray;
            this.btnUserList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUserList.UseVisualStyleBackColor = false;
            this.btnUserList.Click += new System.EventHandler(this.btnUserList_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TheCoffe.Properties.Resources.logo_sidebar;
            this.pictureBox1.InitialImage = global::TheCoffe.Properties.Resources.logo_sidebar;
            this.pictureBox1.Location = new System.Drawing.Point(15, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 80);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnUserDetails
            // 
            this.btnUserDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.btnUserDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.btnUserDetails.BorderColor = System.Drawing.Color.Transparent;
            this.btnUserDetails.BorderRadius = 10;
            this.btnUserDetails.BorderSize = 0;
            this.btnUserDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserDetails.FlatAppearance.BorderSize = 0;
            this.btnUserDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserDetails.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnUserDetails.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUserDetails.IconColor = System.Drawing.Color.DimGray;
            this.btnUserDetails.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUserDetails.IconSize = 35;
            this.btnUserDetails.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnUserDetails.Location = new System.Drawing.Point(57, 105);
            this.btnUserDetails.Name = "btnUserDetails";
            this.btnUserDetails.Size = new System.Drawing.Size(130, 30);
            this.btnUserDetails.TabIndex = 18;
            this.btnUserDetails.Tag = "";
            this.btnUserDetails.Text = "Ver Perfil";
            this.btnUserDetails.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnUserDetails.UseVisualStyleBackColor = false;
            this.btnUserDetails.Click += new System.EventHandler(this.btnUserDetails_Click);
            // 
            // imgUser
            // 
            this.imgUser.Image = ((System.Drawing.Image)(resources.GetObject("imgUser.Image")));
            this.imgUser.Location = new System.Drawing.Point(91, 17);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(61, 50);
            this.imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUser.TabIndex = 18;
            this.imgUser.TabStop = false;
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.White;
            this.btnConfig.BackgroundColor = System.Drawing.Color.White;
            this.btnConfig.BorderColor = System.Drawing.Color.Transparent;
            this.btnConfig.BorderRadius = 10;
            this.btnConfig.BorderSize = 0;
            this.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.DimGray;
            this.btnConfig.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnConfig.IconColor = System.Drawing.Color.DimGray;
            this.btnConfig.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfig.IconSize = 35;
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnConfig.Location = new System.Drawing.Point(3, 423);
            this.btnConfig.MinimumSize = new System.Drawing.Size(58, 0);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.btnConfig.Size = new System.Drawing.Size(244, 45);
            this.btnConfig.TabIndex = 16;
            this.btnConfig.Tag = "Configuraciones";
            this.btnConfig.Text = "  Configuraciones";
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfig.TextColor = System.Drawing.Color.DimGray;
            this.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfig.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.White;
            this.btnReports.BackgroundColor = System.Drawing.Color.White;
            this.btnReports.BorderColor = System.Drawing.Color.Transparent;
            this.btnReports.BorderRadius = 10;
            this.btnReports.BorderSize = 0;
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.DimGray;
            this.btnReports.IconChar = FontAwesome.Sharp.IconChar.File;
            this.btnReports.IconColor = System.Drawing.Color.DimGray;
            this.btnReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReports.IconSize = 35;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnReports.Location = new System.Drawing.Point(3, 333);
            this.btnReports.MinimumSize = new System.Drawing.Size(58, 0);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(244, 45);
            this.btnReports.TabIndex = 15;
            this.btnReports.Tag = "Reportes";
            this.btnReports.Text = "  Reportes";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReports.TextColor = System.Drawing.Color.DimGray;
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnWaiter
            // 
            this.btnWaiter.BackColor = System.Drawing.Color.White;
            this.btnWaiter.BackgroundColor = System.Drawing.Color.White;
            this.btnWaiter.BorderColor = System.Drawing.Color.Transparent;
            this.btnWaiter.BorderRadius = 10;
            this.btnWaiter.BorderSize = 0;
            this.btnWaiter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWaiter.FlatAppearance.BorderSize = 0;
            this.btnWaiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWaiter.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWaiter.ForeColor = System.Drawing.Color.DimGray;
            this.btnWaiter.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            this.btnWaiter.IconColor = System.Drawing.Color.DimGray;
            this.btnWaiter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWaiter.IconSize = 35;
            this.btnWaiter.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnWaiter.Location = new System.Drawing.Point(3, 288);
            this.btnWaiter.MinimumSize = new System.Drawing.Size(58, 0);
            this.btnWaiter.Name = "btnWaiter";
            this.btnWaiter.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.btnWaiter.Size = new System.Drawing.Size(244, 45);
            this.btnWaiter.TabIndex = 14;
            this.btnWaiter.Tag = "Empleados";
            this.btnWaiter.Text = "  Meseros";
            this.btnWaiter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWaiter.TextColor = System.Drawing.Color.DimGray;
            this.btnWaiter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWaiter.UseVisualStyleBackColor = false;
            this.btnWaiter.Click += new System.EventHandler(this.btnWaiter_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.White;
            this.btnProducts.BackgroundColor = System.Drawing.Color.White;
            this.btnProducts.BorderColor = System.Drawing.Color.Transparent;
            this.btnProducts.BorderRadius = 10;
            this.btnProducts.BorderSize = 0;
            this.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.DimGray;
            this.btnProducts.IconChar = FontAwesome.Sharp.IconChar.Coffee;
            this.btnProducts.IconColor = System.Drawing.Color.DimGray;
            this.btnProducts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProducts.IconSize = 35;
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(3, 154);
            this.btnProducts.MinimumSize = new System.Drawing.Size(58, 0);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.btnProducts.Size = new System.Drawing.Size(244, 45);
            this.btnProducts.TabIndex = 13;
            this.btnProducts.Tag = "Productos";
            this.btnProducts.Text = "  Productos";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProducts.TextColor = System.Drawing.Color.DimGray;
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.btnDashboard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.btnDashboard.BorderColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BorderRadius = 10;
            this.btnDashboard.BorderSize = 0;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.btnDashboard.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 35;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnDashboard.Location = new System.Drawing.Point(3, 109);
            this.btnDashboard.MinimumSize = new System.Drawing.Size(58, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(244, 45);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Tag = "Dashboard";
            this.btnDashboard.Text = "  Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboard.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnRemovedProducts
            // 
            this.btnRemovedProducts.BackColor = System.Drawing.Color.White;
            this.btnRemovedProducts.BackgroundColor = System.Drawing.Color.White;
            this.btnRemovedProducts.BorderColor = System.Drawing.Color.Transparent;
            this.btnRemovedProducts.BorderRadius = 10;
            this.btnRemovedProducts.BorderSize = 0;
            this.btnRemovedProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemovedProducts.FlatAppearance.BorderSize = 0;
            this.btnRemovedProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovedProducts.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovedProducts.ForeColor = System.Drawing.Color.DimGray;
            this.btnRemovedProducts.IconChar = FontAwesome.Sharp.IconChar.Coffee;
            this.btnRemovedProducts.IconColor = System.Drawing.Color.DimGray;
            this.btnRemovedProducts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemovedProducts.IconSize = 35;
            this.btnRemovedProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemovedProducts.Location = new System.Drawing.Point(3, 465);
            this.btnRemovedProducts.MinimumSize = new System.Drawing.Size(58, 0);
            this.btnRemovedProducts.Name = "btnRemovedProducts";
            this.btnRemovedProducts.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.btnRemovedProducts.Size = new System.Drawing.Size(244, 45);
            this.btnRemovedProducts.TabIndex = 21;
            this.btnRemovedProducts.Tag = "Productos";
            this.btnRemovedProducts.Text = "  Productos Eliminados";
            this.btnRemovedProducts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemovedProducts.TextColor = System.Drawing.Color.DimGray;
            this.btnRemovedProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemovedProducts.UseVisualStyleBackColor = false;
            this.btnRemovedProducts.Click += new System.EventHandler(this.btnRemovedProducts_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Coffe";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlSideBar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideBar;
        private WindowsFormsApplication1.RoundButton btnDashboard;
        private WindowsFormsApplication1.RoundButton btnConfig;
        private WindowsFormsApplication1.RoundButton btnReports;
        private WindowsFormsApplication1.RoundButton btnWaiter;
        private WindowsFormsApplication1.RoundButton btnProducts;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox imgUser;
        private WindowsFormsApplication1.RoundButton btnUserDetails;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer transitionTimer;
        private WindowsFormsApplication1.RoundButton btnUserList;
        private WindowsFormsApplication1.RoundButton btnTables;
        private WindowsFormsApplication1.RoundButton btnCategory;
        private WindowsFormsApplication1.RoundButton btnRemovedProducts;
    }
}

