namespace TheCoffe.App
{
    partial class AlertBox
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
            this.components = new System.ComponentModel.Container();
            this.picAlertBox = new System.Windows.Forms.PictureBox();
            this.lblTitleAlertBox = new System.Windows.Forms.Label();
            this.lblTextAlertBox = new System.Windows.Forms.Label();
            this.linAlertBox = new System.Windows.Forms.Panel();
            this.timerAnimasion = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picAlertBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picAlertBox
            // 
            this.picAlertBox.Location = new System.Drawing.Point(13, 11);
            this.picAlertBox.Name = "picAlertBox";
            this.picAlertBox.Size = new System.Drawing.Size(50, 50);
            this.picAlertBox.TabIndex = 0;
            this.picAlertBox.TabStop = false;
            // 
            // lblTitleAlertBox
            // 
            this.lblTitleAlertBox.AutoSize = true;
            this.lblTitleAlertBox.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleAlertBox.Location = new System.Drawing.Point(69, 13);
            this.lblTitleAlertBox.Name = "lblTitleAlertBox";
            this.lblTitleAlertBox.Size = new System.Drawing.Size(122, 23);
            this.lblTitleAlertBox.TabIndex = 1;
            this.lblTitleAlertBox.Text = "TitleAlertBox";
            // 
            // lblTextAlertBox
            // 
            this.lblTextAlertBox.AutoSize = true;
            this.lblTextAlertBox.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextAlertBox.Location = new System.Drawing.Point(76, 41);
            this.lblTextAlertBox.Name = "lblTextAlertBox";
            this.lblTextAlertBox.Size = new System.Drawing.Size(91, 17);
            this.lblTextAlertBox.TabIndex = 2;
            this.lblTextAlertBox.Text = "TextAlertBox";
            // 
            // linAlertBox
            // 
            this.linAlertBox.BackColor = System.Drawing.Color.Black;
            this.linAlertBox.Location = new System.Drawing.Point(0, 73);
            this.linAlertBox.Name = "linAlertBox";
            this.linAlertBox.Size = new System.Drawing.Size(2, 7);
            this.linAlertBox.TabIndex = 3;
            // 
            // timerAnimasion
            // 
            this.timerAnimasion.Interval = 2;
            this.timerAnimasion.Tick += new System.EventHandler(this.timerAnimasion_Tick);
            // 
            // AlertBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 80);
            this.Controls.Add(this.linAlertBox);
            this.Controls.Add(this.lblTextAlertBox);
            this.Controls.Add(this.lblTitleAlertBox);
            this.Controls.Add(this.picAlertBox);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlertBox";
            this.Text = "AlertBox";
            this.Load += new System.EventHandler(this.AlertBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAlertBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAlertBox;
        private System.Windows.Forms.Label lblTitleAlertBox;
        private System.Windows.Forms.Label lblTextAlertBox;
        private System.Windows.Forms.Panel linAlertBox;
        private System.Windows.Forms.Timer timerAnimasion;
    }
}