using TheCoffe.CPresentacion.Components;

namespace TheCoffe.CPresentacion.Cajero
{
    partial class OpenOrder
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
            this.lblTable = new System.Windows.Forms.Label();
            this.cboMesero = new TheCoffe.CPresentacion.Components.CustomComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.modernTextBox4 = new TheCoffe.Components.ModernTextBox();
            this.btnRol = new FontAwesome.Sharp.IconButton();
            this.btnOpenBox = new WindowsFormsApplication1.RoundButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.lblTable.Location = new System.Drawing.Point(15, 18);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(79, 22);
            this.lblTable.TabIndex = 85;
            this.lblTable.Text = "Mesa 10";
            // 
            // cboMesero
            // 
            this.cboMesero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cboMesero.BorderColor = System.Drawing.Color.Transparent;
            this.cboMesero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboMesero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMesero.DropDownWidth = 285;
            this.cboMesero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMesero.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMesero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboMesero.FormattingEnabled = true;
            this.cboMesero.Items.AddRange(new object[] {
            "Administrador",
            "Cajero"});
            this.cboMesero.Location = new System.Drawing.Point(25, 97);
            this.cboMesero.Name = "cboMesero";
            this.cboMesero.Size = new System.Drawing.Size(259, 24);
            this.cboMesero.TabIndex = 91;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 89;
            this.label7.Text = "Mesero";
            // 
            // modernTextBox4
            // 
            this.modernTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.modernTextBox4.BorderColor = System.Drawing.Color.Transparent;
            this.modernTextBox4.BorderFocusColor = System.Drawing.Color.Transparent;
            this.modernTextBox4.BorderRadius = 10;
            this.modernTextBox4.BorderSize = 1;
            this.modernTextBox4.Enabled = false;
            this.modernTextBox4.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modernTextBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modernTextBox4.Location = new System.Drawing.Point(19, 85);
            this.modernTextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.modernTextBox4.Multiline = false;
            this.modernTextBox4.Name = "modernTextBox4";
            this.modernTextBox4.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.modernTextBox4.PasswordChar = false;
            this.modernTextBox4.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.modernTextBox4.PlaceholderText = "";
            this.modernTextBox4.Size = new System.Drawing.Size(291, 46);
            this.modernTextBox4.TabIndex = 90;
            this.modernTextBox4.Texts = "";
            this.modernTextBox4.UnderlinedStyle = false;
            // 
            // btnRol
            // 
            this.btnRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRol.FlatAppearance.BorderSize = 0;
            this.btnRol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnRol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRol.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.btnRol.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnRol.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnRol.IconSize = 25;
            this.btnRol.Location = new System.Drawing.Point(275, 93);
            this.btnRol.Name = "btnRol";
            this.btnRol.Size = new System.Drawing.Size(33, 35);
            this.btnRol.TabIndex = 92;
            this.btnRol.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRol.UseVisualStyleBackColor = false;
            // 
            // btnOpenBox
            // 
            this.btnOpenBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnOpenBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnOpenBox.BorderColor = System.Drawing.Color.Black;
            this.btnOpenBox.BorderRadius = 6;
            this.btnOpenBox.BorderSize = 0;
            this.btnOpenBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenBox.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOpenBox.FlatAppearance.BorderSize = 0;
            this.btnOpenBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenBox.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnOpenBox.ForeColor = System.Drawing.Color.White;
            this.btnOpenBox.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnOpenBox.IconColor = System.Drawing.Color.White;
            this.btnOpenBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOpenBox.IconSize = 34;
            this.btnOpenBox.Location = new System.Drawing.Point(16, 153);
            this.btnOpenBox.Name = "btnOpenBox";
            this.btnOpenBox.Size = new System.Drawing.Size(294, 46);
            this.btnOpenBox.TabIndex = 88;
            this.btnOpenBox.Text = "Iniciar Pedido";
            this.btnOpenBox.TextColor = System.Drawing.Color.White;
            this.btnOpenBox.UseVisualStyleBackColor = false;
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
            this.btnClose.Location = new System.Drawing.Point(274, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 34);
            this.btnClose.TabIndex = 84;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // OpenOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(329, 223);
            this.Controls.Add(this.btnRol);
            this.Controls.Add(this.cboMesero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.modernTextBox4);
            this.Controls.Add(this.btnOpenBox);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OpenOrder";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenOrder";
            this.Deactivate += new System.EventHandler(this.OpenOrder_Deactivate);
            this.Load += new System.EventHandler(this.OpenOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsApplication1.RoundButton btnOpenBox;
        private System.Windows.Forms.Label lblTable;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnRol;
        private CustomComboBox cboMesero;
        private System.Windows.Forms.Label label7;
        private TheCoffe.Components.ModernTextBox modernTextBox4;
    }
}