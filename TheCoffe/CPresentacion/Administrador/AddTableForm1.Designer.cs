namespace TheCoffe.App
{
    partial class AddTableForm1
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAdd = new AltoControls.AltoButton();
            this.txtNroSilla = new TheCoffe.Components.ModernTextBox();
            this.txtMesa = new TheCoffe.Components.ModernTextBox();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 40;
            this.label8.Text = "Nro de Silla";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 15);
            this.label9.TabIndex = 39;
            this.label9.Text = "Nro de Mesa";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.lblTitle.Location = new System.Drawing.Point(24, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(125, 22);
            this.lblTitle.TabIndex = 38;
            this.lblTitle.Text = "Agregar Mesa";
            // 
            // btnAdd
            // 
            this.btnAdd.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnAdd.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnAdd.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnAdd.Location = new System.Drawing.Point(26, 260);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Radius = 10;
            this.btnAdd.Size = new System.Drawing.Size(317, 45);
            this.btnAdd.Stroke = false;
            this.btnAdd.StrokeColor = System.Drawing.Color.Gray;
            this.btnAdd.TabIndex = 43;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.Transparency = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNroSilla
            // 
            this.txtNroSilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtNroSilla.BorderColor = System.Drawing.Color.Transparent;
            this.txtNroSilla.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtNroSilla.BorderRadius = 10;
            this.txtNroSilla.BorderSize = 1;
            this.txtNroSilla.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroSilla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNroSilla.Location = new System.Drawing.Point(29, 181);
            this.txtNroSilla.Margin = new System.Windows.Forms.Padding(4);
            this.txtNroSilla.Multiline = false;
            this.txtNroSilla.Name = "txtNroSilla";
            this.txtNroSilla.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.txtNroSilla.PasswordChar = false;
            this.txtNroSilla.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNroSilla.PlaceholderText = "";
            this.txtNroSilla.Size = new System.Drawing.Size(317, 46);
            this.txtNroSilla.TabIndex = 41;
            this.txtNroSilla.Texts = "";
            this.txtNroSilla.UnderlinedStyle = false;
            this.txtNroSilla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroSilla_KeyPress);
            // 
            // txtMesa
            // 
            this.txtMesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtMesa.BorderColor = System.Drawing.Color.Transparent;
            this.txtMesa.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtMesa.BorderRadius = 10;
            this.txtMesa.BorderSize = 1;
            this.txtMesa.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMesa.Location = new System.Drawing.Point(30, 99);
            this.txtMesa.Margin = new System.Windows.Forms.Padding(4);
            this.txtMesa.Multiline = false;
            this.txtMesa.Name = "txtMesa";
            this.txtMesa.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.txtMesa.PasswordChar = false;
            this.txtMesa.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMesa.PlaceholderText = "";
            this.txtMesa.Size = new System.Drawing.Size(317, 46);
            this.txtMesa.TabIndex = 44;
            this.txtMesa.Texts = "";
            this.txtMesa.UnderlinedStyle = false;
            this.txtMesa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMesa_KeyPress);
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
            this.btnClose.Location = new System.Drawing.Point(313, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 34);
            this.btnClose.TabIndex = 37;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // AddTableForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(378, 328);
            this.Controls.Add(this.txtMesa);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNroSilla);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTableForm1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTableForm1";
            this.Deactivate += new System.EventHandler(this.AddTableForm1_Deactivate);
            this.Load += new System.EventHandler(this.AddTableForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.ModernTextBox txtNroSilla;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconButton btnClose;
        private AltoControls.AltoButton btnAdd;
        private Components.ModernTextBox txtMesa;
    }
}