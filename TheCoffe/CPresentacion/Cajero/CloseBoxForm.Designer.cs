namespace TheCoffe.CPresentacion.Cajero
{
    partial class CloseBoxForm
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
            this.txtAmount = new TheCoffe.Components.ModernTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAddClient = new System.Windows.Forms.Label();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.lblMontoRecaudado = new System.Windows.Forms.Label();
            this.txtObservaciones = new TheCoffe.Components.ModernTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDiferencia = new System.Windows.Forms.Label();
            this.btnCloseBox = new WindowsFormsApplication1.RoundButton();
            this.SuspendLayout();
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
            this.txtAmount.Location = new System.Drawing.Point(23, 147);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.Multiline = false;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.txtAmount.PasswordChar = false;
            this.txtAmount.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAmount.PlaceholderText = "";
            this.txtAmount.Size = new System.Drawing.Size(205, 46);
            this.txtAmount.TabIndex = 87;
            this.txtAmount.Texts = "";
            this.txtAmount.UnderlinedStyle = false;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            this.txtAmount._TextChanged += new System.EventHandler(this.txtAmount__TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 86;
            this.label5.Text = "Monto en Caja $";
            // 
            // lblAddClient
            // 
            this.lblAddClient.AutoSize = true;
            this.lblAddClient.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.lblAddClient.Location = new System.Drawing.Point(22, 18);
            this.lblAddClient.Name = "lblAddClient";
            this.lblAddClient.Size = new System.Drawing.Size(104, 22);
            this.lblAddClient.TabIndex = 85;
            this.lblAddClient.Text = "Cerrar Caja";
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
            this.btnClose.Location = new System.Drawing.Point(466, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 34);
            this.btnClose.TabIndex = 84;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblMontoRecaudado
            // 
            this.lblMontoRecaudado.AutoSize = true;
            this.lblMontoRecaudado.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoRecaudado.Location = new System.Drawing.Point(19, 76);
            this.lblMontoRecaudado.Name = "lblMontoRecaudado";
            this.lblMontoRecaudado.Size = new System.Drawing.Size(130, 15);
            this.lblMontoRecaudado.TabIndex = 89;
            this.lblMontoRecaudado.Text = "Monto Recaudado $ 0";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtObservaciones.BorderColor = System.Drawing.Color.Transparent;
            this.txtObservaciones.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtObservaciones.BorderRadius = 10;
            this.txtObservaciones.BorderSize = 1;
            this.txtObservaciones.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtObservaciones.Location = new System.Drawing.Point(267, 90);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.txtObservaciones.PasswordChar = false;
            this.txtObservaciones.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtObservaciones.PlaceholderText = "";
            this.txtObservaciones.Size = new System.Drawing.Size(243, 104);
            this.txtObservaciones.TabIndex = 90;
            this.txtObservaciones.Texts = "";
            this.txtObservaciones.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 91;
            this.label2.Text = "Observaciones";
            // 
            // lblDiferencia
            // 
            this.lblDiferencia.AutoSize = true;
            this.lblDiferencia.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiferencia.Location = new System.Drawing.Point(22, 228);
            this.lblDiferencia.Name = "lblDiferencia";
            this.lblDiferencia.Size = new System.Drawing.Size(118, 19);
            this.lblDiferencia.TabIndex = 92;
            this.lblDiferencia.Text = "Diferencia:  $ 0";
            // 
            // btnCloseBox
            // 
            this.btnCloseBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnCloseBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnCloseBox.BorderColor = System.Drawing.Color.Black;
            this.btnCloseBox.BorderRadius = 6;
            this.btnCloseBox.BorderSize = 0;
            this.btnCloseBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseBox.FlatAppearance.BorderSize = 0;
            this.btnCloseBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseBox.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCloseBox.ForeColor = System.Drawing.Color.White;
            this.btnCloseBox.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCloseBox.IconColor = System.Drawing.Color.White;
            this.btnCloseBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseBox.IconSize = 34;
            this.btnCloseBox.Location = new System.Drawing.Point(22, 284);
            this.btnCloseBox.Name = "btnCloseBox";
            this.btnCloseBox.Size = new System.Drawing.Size(487, 46);
            this.btnCloseBox.TabIndex = 88;
            this.btnCloseBox.Text = "Cerrar e Imprimir";
            this.btnCloseBox.TextColor = System.Drawing.Color.White;
            this.btnCloseBox.UseVisualStyleBackColor = false;
            this.btnCloseBox.Click += new System.EventHandler(this.btnCloseBox_Click);
            // 
            // CloseBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(536, 356);
            this.Controls.Add(this.lblDiferencia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.lblMontoRecaudado);
            this.Controls.Add(this.btnCloseBox);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAddClient);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CloseBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CloseBoxForm";
            this.Deactivate += new System.EventHandler(this.CloseBoxForm_Deactivate);
            this.Load += new System.EventHandler(this.CloseBoxForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TheCoffe.Components.ModernTextBox txtAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAddClient;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label lblMontoRecaudado;
        private TheCoffe.Components.ModernTextBox txtObservaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDiferencia;
        private WindowsFormsApplication1.RoundButton btnCloseBox;
    }
}