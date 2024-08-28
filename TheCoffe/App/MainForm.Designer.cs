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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUser = new WindowsFormsApplication1.RoundButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imgUser = new System.Windows.Forms.PictureBox();
            this.roundButton4 = new WindowsFormsApplication1.RoundButton();
            this.roundButton3 = new WindowsFormsApplication1.RoundButton();
            this.roundButton2 = new WindowsFormsApplication1.RoundButton();
            this.btnProducts = new WindowsFormsApplication1.RoundButton();
            this.btnDashboard = new WindowsFormsApplication1.RoundButton();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.White;
            this.pnlSideBar.Controls.Add(this.pictureBox1);
            this.pnlSideBar.Controls.Add(this.panel3);
            this.pnlSideBar.Controls.Add(this.roundButton4);
            this.pnlSideBar.Controls.Add(this.roundButton3);
            this.pnlSideBar.Controls.Add(this.roundButton2);
            this.pnlSideBar.Controls.Add(this.btnProducts);
            this.pnlSideBar.Controls.Add(this.btnDashboard);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.MaximumSize = new System.Drawing.Size(250, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(250, 681);
            this.pnlSideBar.TabIndex = 0;
            this.pnlSideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSideBar_Paint);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.btnUser);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.imgUser);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 526);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 155);
            this.panel3.TabIndex = 2;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.btnUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.btnUser.BorderColor = System.Drawing.Color.Transparent;
            this.btnUser.BorderRadius = 10;
            this.btnUser.BorderSize = 0;
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnUser.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUser.IconColor = System.Drawing.Color.DimGray;
            this.btnUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUser.IconSize = 35;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnUser.Location = new System.Drawing.Point(57, 105);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(130, 30);
            this.btnUser.TabIndex = 18;
            this.btnUser.Tag = "";
            this.btnUser.Text = "Ver Perfil";
            this.btnUser.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnUser.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(83, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Administrador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Juan Coronel";
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
            // roundButton4
            // 
            this.roundButton4.BackColor = System.Drawing.Color.Transparent;
            this.roundButton4.BackgroundColor = System.Drawing.Color.Transparent;
            this.roundButton4.BorderColor = System.Drawing.Color.Transparent;
            this.roundButton4.BorderRadius = 10;
            this.roundButton4.BorderSize = 0;
            this.roundButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton4.FlatAppearance.BorderSize = 0;
            this.roundButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton4.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton4.ForeColor = System.Drawing.Color.DimGray;
            this.roundButton4.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.roundButton4.IconColor = System.Drawing.Color.DimGray;
            this.roundButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.roundButton4.IconSize = 35;
            this.roundButton4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.roundButton4.Location = new System.Drawing.Point(3, 290);
            this.roundButton4.MinimumSize = new System.Drawing.Size(58, 0);
            this.roundButton4.Name = "roundButton4";
            this.roundButton4.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.roundButton4.Size = new System.Drawing.Size(244, 45);
            this.roundButton4.TabIndex = 16;
            this.roundButton4.Tag = "Configuraciones";
            this.roundButton4.Text = "  Configuraciones";
            this.roundButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.roundButton4.TextColor = System.Drawing.Color.DimGray;
            this.roundButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundButton4.UseVisualStyleBackColor = false;
            // 
            // roundButton3
            // 
            this.roundButton3.BackColor = System.Drawing.Color.Transparent;
            this.roundButton3.BackgroundColor = System.Drawing.Color.Transparent;
            this.roundButton3.BorderColor = System.Drawing.Color.Transparent;
            this.roundButton3.BorderRadius = 10;
            this.roundButton3.BorderSize = 0;
            this.roundButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton3.FlatAppearance.BorderSize = 0;
            this.roundButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton3.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton3.ForeColor = System.Drawing.Color.DimGray;
            this.roundButton3.IconChar = FontAwesome.Sharp.IconChar.File;
            this.roundButton3.IconColor = System.Drawing.Color.DimGray;
            this.roundButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.roundButton3.IconSize = 35;
            this.roundButton3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.roundButton3.Location = new System.Drawing.Point(3, 244);
            this.roundButton3.MinimumSize = new System.Drawing.Size(58, 0);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.roundButton3.Size = new System.Drawing.Size(244, 45);
            this.roundButton3.TabIndex = 15;
            this.roundButton3.Tag = "Reportes";
            this.roundButton3.Text = "  Reportes";
            this.roundButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.roundButton3.TextColor = System.Drawing.Color.DimGray;
            this.roundButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundButton3.UseVisualStyleBackColor = false;
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.Transparent;
            this.roundButton2.BackgroundColor = System.Drawing.Color.Transparent;
            this.roundButton2.BorderColor = System.Drawing.Color.Transparent;
            this.roundButton2.BorderRadius = 10;
            this.roundButton2.BorderSize = 0;
            this.roundButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton2.FlatAppearance.BorderSize = 0;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton2.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton2.ForeColor = System.Drawing.Color.DimGray;
            this.roundButton2.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.roundButton2.IconColor = System.Drawing.Color.DimGray;
            this.roundButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.roundButton2.IconSize = 35;
            this.roundButton2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.roundButton2.Location = new System.Drawing.Point(3, 199);
            this.roundButton2.MinimumSize = new System.Drawing.Size(58, 0);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.roundButton2.Size = new System.Drawing.Size(244, 45);
            this.roundButton2.TabIndex = 14;
            this.roundButton2.Tag = "Empleados";
            this.roundButton2.Text = "  Empleados";
            this.roundButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.roundButton2.TextColor = System.Drawing.Color.DimGray;
            this.roundButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundButton2.UseVisualStyleBackColor = false;
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.Transparent;
            this.btnProducts.BackgroundColor = System.Drawing.Color.Transparent;
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
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.btnDashboard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
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
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Red;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMain.Location = new System.Drawing.Point(245, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1019, 681);
            this.pnlMain.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlSideBar);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Coffe";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideBar;
        private WindowsFormsApplication1.RoundButton btnDashboard;
        private WindowsFormsApplication1.RoundButton roundButton4;
        private WindowsFormsApplication1.RoundButton roundButton3;
        private WindowsFormsApplication1.RoundButton roundButton2;
        private WindowsFormsApplication1.RoundButton btnProducts;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox imgUser;
        private WindowsFormsApplication1.RoundButton btnUser;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

