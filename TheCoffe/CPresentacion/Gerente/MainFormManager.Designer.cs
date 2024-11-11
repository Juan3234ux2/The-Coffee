namespace TheCoffe.CPresentacion.Gerente
{
    partial class MainFormManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormManager));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.btnClosingBox = new WindowsFormsApplication1.RoundButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new WindowsFormsApplication1.RoundButton();
            this.btnReports = new WindowsFormsApplication1.RoundButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMain = new WindowsFormsApplication1.RoundButton();
            this.pnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMain.Location = new System.Drawing.Point(250, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1014, 681);
            this.pnlMain.TabIndex = 4;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.White;
            this.pnlSideBar.Controls.Add(this.btnClosingBox);
            this.pnlSideBar.Controls.Add(this.panel2);
            this.pnlSideBar.Controls.Add(this.btnLogout);
            this.pnlSideBar.Controls.Add(this.btnReports);
            this.pnlSideBar.Controls.Add(this.pictureBox1);
            this.pnlSideBar.Controls.Add(this.btnMain);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.MaximumSize = new System.Drawing.Size(250, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(250, 681);
            this.pnlSideBar.TabIndex = 3;
            // 
            // btnClosingBox
            // 
            this.btnClosingBox.BackColor = System.Drawing.Color.White;
            this.btnClosingBox.BackgroundColor = System.Drawing.Color.White;
            this.btnClosingBox.BorderColor = System.Drawing.Color.Transparent;
            this.btnClosingBox.BorderRadius = 10;
            this.btnClosingBox.BorderSize = 0;
            this.btnClosingBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClosingBox.FlatAppearance.BorderSize = 0;
            this.btnClosingBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosingBox.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosingBox.ForeColor = System.Drawing.Color.DimGray;
            this.btnClosingBox.IconChar = FontAwesome.Sharp.IconChar.FileArchive;
            this.btnClosingBox.IconColor = System.Drawing.Color.DimGray;
            this.btnClosingBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClosingBox.IconSize = 35;
            this.btnClosingBox.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnClosingBox.Location = new System.Drawing.Point(3, 202);
            this.btnClosingBox.MinimumSize = new System.Drawing.Size(58, 0);
            this.btnClosingBox.Name = "btnClosingBox";
            this.btnClosingBox.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.btnClosingBox.Size = new System.Drawing.Size(244, 45);
            this.btnClosingBox.TabIndex = 23;
            this.btnClosingBox.Tag = "Mesas";
            this.btnClosingBox.Text = "  Cierres de Caja";
            this.btnClosingBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClosingBox.TextColor = System.Drawing.Color.DimGray;
            this.btnClosingBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClosingBox.UseVisualStyleBackColor = false;
            this.btnClosingBox.Click += new System.EventHandler(this.btnClosingBox_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(249, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 680);
            this.panel2.TabIndex = 22;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.BackgroundColor = System.Drawing.Color.White;
            this.btnLogout.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogout.BorderRadius = 10;
            this.btnLogout.BorderSize = 0;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnLogout.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 35;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnLogout.Location = new System.Drawing.Point(3, 624);
            this.btnLogout.MinimumSize = new System.Drawing.Size(58, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(244, 45);
            this.btnLogout.TabIndex = 21;
            this.btnLogout.Tag = "Mesas";
            this.btnLogout.Text = "  Cerrar Sesión";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
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
            this.btnReports.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btnReports.IconColor = System.Drawing.Color.DimGray;
            this.btnReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReports.IconSize = 35;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnReports.Location = new System.Drawing.Point(3, 153);
            this.btnReports.MinimumSize = new System.Drawing.Size(58, 0);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(244, 45);
            this.btnReports.TabIndex = 20;
            this.btnReports.Tag = "Mesas";
            this.btnReports.Text = "  Reportes";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReports.TextColor = System.Drawing.Color.DimGray;
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
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
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnMain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnMain.BorderColor = System.Drawing.Color.Transparent;
            this.btnMain.BorderRadius = 10;
            this.btnMain.BorderSize = 0;
            this.btnMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMain.FlatAppearance.BorderSize = 0;
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnMain.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnMain.IconChar = FontAwesome.Sharp.IconChar.Coffee;
            this.btnMain.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnMain.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMain.IconSize = 35;
            this.btnMain.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnMain.Location = new System.Drawing.Point(3, 109);
            this.btnMain.MinimumSize = new System.Drawing.Size(58, 0);
            this.btnMain.Name = "btnMain";
            this.btnMain.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.btnMain.Size = new System.Drawing.Size(244, 45);
            this.btnMain.TabIndex = 1;
            this.btnMain.Tag = "";
            this.btnMain.Text = "  Principal";
            this.btnMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMain.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // MainFormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainFormManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Coffee";
            this.Load += new System.EventHandler(this.MainFormManager_Load);
            this.pnlSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Panel panel2;
        private WindowsFormsApplication1.RoundButton btnLogout;
        private WindowsFormsApplication1.RoundButton btnReports;
        private System.Windows.Forms.PictureBox pictureBox1;
        private WindowsFormsApplication1.RoundButton btnMain;
        private WindowsFormsApplication1.RoundButton btnClosingBox;
    }
}