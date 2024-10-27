namespace TheCoffe.CPresentacion.Cajero
{
    partial class OpenBoxForm
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
            this.txtAmount = new TheCoffe.Components.ModernTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOpenBox = new WindowsFormsApplication1.RoundButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lblAddClient
            // 
            this.lblAddClient.AutoSize = true;
            this.lblAddClient.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.lblAddClient.Location = new System.Drawing.Point(12, 18);
            this.lblAddClient.Name = "lblAddClient";
            this.lblAddClient.Size = new System.Drawing.Size(92, 22);
            this.lblAddClient.TabIndex = 63;
            this.lblAddClient.Text = "Abrir Caja";
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtAmount.BorderColor = System.Drawing.Color.Transparent;
            this.txtAmount.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtAmount.BorderRadius = 10;
            this.txtAmount.BorderSize = 1;
            this.txtAmount.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAmount.Location = new System.Drawing.Point(18, 93);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.Multiline = false;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.txtAmount.PasswordChar = false;
            this.txtAmount.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAmount.PlaceholderText = "";
            this.txtAmount.Size = new System.Drawing.Size(361, 46);
            this.txtAmount.TabIndex = 82;
            this.txtAmount.Texts = "";
            this.txtAmount.UnderlinedStyle = false;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 15);
            this.label5.TabIndex = 81;
            this.label5.Text = "Monto Disponible $";
            // 
            // btnOpenBox
            // 
            this.btnOpenBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnOpenBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnOpenBox.BorderColor = System.Drawing.Color.Black;
            this.btnOpenBox.BorderRadius = 6;
            this.btnOpenBox.BorderSize = 0;
            this.btnOpenBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenBox.FlatAppearance.BorderSize = 0;
            this.btnOpenBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenBox.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnOpenBox.ForeColor = System.Drawing.Color.White;
            this.btnOpenBox.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnOpenBox.IconColor = System.Drawing.Color.White;
            this.btnOpenBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOpenBox.IconSize = 34;
            this.btnOpenBox.Location = new System.Drawing.Point(18, 166);
            this.btnOpenBox.Name = "btnOpenBox";
            this.btnOpenBox.Size = new System.Drawing.Size(361, 46);
            this.btnOpenBox.TabIndex = 83;
            this.btnOpenBox.Text = "Abrir Caja";
            this.btnOpenBox.TextColor = System.Drawing.Color.White;
            this.btnOpenBox.UseVisualStyleBackColor = false;
            this.btnOpenBox.Click += new System.EventHandler(this.btnOpenBox_Click);
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
            this.btnClose.Location = new System.Drawing.Point(346, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 34);
            this.btnClose.TabIndex = 25;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // OpenBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(402, 235);
            this.Controls.Add(this.btnOpenBox);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAddClient);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OpenBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenBoxForm";
            this.Deactivate += new System.EventHandler(this.OpenBoxForm_Deactivate);
            this.Load += new System.EventHandler(this.OpenBoxForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label lblAddClient;
        private TheCoffe.Components.ModernTextBox txtAmount;
        private System.Windows.Forms.Label label5;
        private WindowsFormsApplication1.RoundButton btnOpenBox;
    }
}