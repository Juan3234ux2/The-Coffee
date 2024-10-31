namespace TheCoffe
{
    partial class MainFormCashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormCashier));
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLogout = new WindowsFormsApplication1.RoundButton();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.imgUser = new System.Windows.Forms.PictureBox();
            this.BtnBox = new WindowsFormsApplication1.RoundButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTables = new WindowsFormsApplication1.RoundButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.transitionTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlSideBar.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.White;
            this.pnlSideBar.Controls.Add(this.panel3);
            this.pnlSideBar.Controls.Add(this.BtnBox);
            this.pnlSideBar.Controls.Add(this.panel2);
            this.pnlSideBar.Controls.Add(this.btnTables);
            this.pnlSideBar.Controls.Add(this.pictureBox1);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.MaximumSize = new System.Drawing.Size(250, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(250, 681);
            this.pnlSideBar.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnLogout);
            this.panel3.Controls.Add(this.lblRol);
            this.panel3.Controls.Add(this.lblUser);
            this.panel3.Controls.Add(this.imgUser);
            this.panel3.Location = new System.Drawing.Point(0, 526);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 155);
            this.panel3.TabIndex = 24;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLogout.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLogout.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogout.BorderRadius = 10;
            this.btnLogout.BorderSize = 0;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLogout.IconColor = System.Drawing.Color.DimGray;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 35;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnLogout.Location = new System.Drawing.Point(57, 105);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(130, 30);
            this.btnLogout.TabIndex = 18;
            this.btnLogout.Tag = "";
            this.btnLogout.Text = "Cerrar Sesión";
            this.btnLogout.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.Color.DimGray;
            this.lblRol.Location = new System.Drawing.Point(101, 89);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(39, 13);
            this.lblRol.TabIndex = 19;
            this.lblRol.Text = "Cajero";
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
            // BtnBox
            // 
            this.BtnBox.BackColor = System.Drawing.Color.White;
            this.BtnBox.BackgroundColor = System.Drawing.Color.White;
            this.BtnBox.BorderColor = System.Drawing.Color.Transparent;
            this.BtnBox.BorderRadius = 10;
            this.BtnBox.BorderSize = 0;
            this.BtnBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBox.FlatAppearance.BorderSize = 0;
            this.BtnBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBox.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBox.ForeColor = System.Drawing.Color.DimGray;
            this.BtnBox.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.BtnBox.IconColor = System.Drawing.Color.DimGray;
            this.BtnBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBox.IconSize = 35;
            this.BtnBox.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnBox.Location = new System.Drawing.Point(3, 155);
            this.BtnBox.MinimumSize = new System.Drawing.Size(58, 0);
            this.BtnBox.Name = "BtnBox";
            this.BtnBox.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.BtnBox.Size = new System.Drawing.Size(244, 45);
            this.BtnBox.TabIndex = 23;
            this.BtnBox.Tag = "Mesas";
            this.BtnBox.Text = "  Caja";
            this.BtnBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBox.TextColor = System.Drawing.Color.DimGray;
            this.BtnBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnBox.UseVisualStyleBackColor = false;
            this.BtnBox.Click += new System.EventHandler(this.BtnBox_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(249, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 680);
            this.panel2.TabIndex = 22;
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
            this.btnTables.Location = new System.Drawing.Point(3, 109);
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
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
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
            // MainFormCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainFormCashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Coffe";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlSideBar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer transitionTimer;
        private WindowsFormsApplication1.RoundButton btnTables;
        private System.Windows.Forms.Panel panel2;
        private WindowsFormsApplication1.RoundButton BtnBox;
        private System.Windows.Forms.Panel panel3;
        private WindowsFormsApplication1.RoundButton btnLogout;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox imgUser;
    }
}

