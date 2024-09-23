﻿namespace TheCoffe.App
{
    partial class AddWaiterForm
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
            this.txtName = new TheCoffe.Components.ModernTextBox();
            this.txtDNI = new TheCoffe.Components.ModernTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAddWaiter = new System.Windows.Forms.Label();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.txtLastName = new TheCoffe.Components.ModernTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumber = new TheCoffe.Components.ModernTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExit = new TheCoffe.Components.ModernTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIncome = new TheCoffe.Components.ModernTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddWaiter = new AltoControls.AltoButton();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.txtName.BorderColor = System.Drawing.Color.Transparent;
            this.txtName.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtName.BorderRadius = 10;
            this.txtName.BorderSize = 1;
            this.txtName.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.Location = new System.Drawing.Point(28, 82);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceholderText = "";
            this.txtName.Size = new System.Drawing.Size(195, 46);
            this.txtName.TabIndex = 42;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = false;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateLetters_KeyPress);
            // 
            // txtDNI
            // 
            this.txtDNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.txtDNI.BorderColor = System.Drawing.Color.Transparent;
            this.txtDNI.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtDNI.BorderRadius = 10;
            this.txtDNI.BorderSize = 1;
            this.txtDNI.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDNI.Location = new System.Drawing.Point(28, 171);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(4);
            this.txtDNI.Multiline = false;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.txtDNI.PasswordChar = false;
            this.txtDNI.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDNI.PlaceholderText = "";
            this.txtDNI.Size = new System.Drawing.Size(195, 46);
            this.txtDNI.TabIndex = 41;
            this.txtDNI.Texts = "";
            this.txtDNI.UnderlinedStyle = false;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateDigits_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 15);
            this.label8.TabIndex = 40;
            this.label8.Text = "DNI";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 39;
            this.label9.Text = "Nombre";
            // 
            // lblAddWaiter
            // 
            this.lblAddWaiter.AutoSize = true;
            this.lblAddWaiter.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddWaiter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.lblAddWaiter.Location = new System.Drawing.Point(24, 18);
            this.lblAddWaiter.Name = "lblAddWaiter";
            this.lblAddWaiter.Size = new System.Drawing.Size(142, 22);
            this.lblAddWaiter.TabIndex = 38;
            this.lblAddWaiter.Text = "Agregar Mesero";
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
            this.btnClose.Location = new System.Drawing.Point(416, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 34);
            this.btnClose.TabIndex = 37;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.txtLastName.BorderColor = System.Drawing.Color.Transparent;
            this.txtLastName.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtLastName.BorderRadius = 10;
            this.txtLastName.BorderSize = 1;
            this.txtLastName.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLastName.Location = new System.Drawing.Point(248, 82);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Multiline = false;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.txtLastName.PasswordChar = false;
            this.txtLastName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLastName.PlaceholderText = "";
            this.txtLastName.Size = new System.Drawing.Size(195, 46);
            this.txtLastName.TabIndex = 44;
            this.txtLastName.Texts = "";
            this.txtLastName.UnderlinedStyle = false;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateLetters_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "Apellido";
            // 
            // txtNumber
            // 
            this.txtNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.txtNumber.BorderColor = System.Drawing.Color.Transparent;
            this.txtNumber.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtNumber.BorderRadius = 10;
            this.txtNumber.BorderSize = 1;
            this.txtNumber.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNumber.Location = new System.Drawing.Point(248, 171);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumber.Multiline = false;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.txtNumber.PasswordChar = false;
            this.txtNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNumber.PlaceholderText = "";
            this.txtNumber.Size = new System.Drawing.Size(195, 46);
            this.txtNumber.TabIndex = 46;
            this.txtNumber.Texts = "";
            this.txtNumber.UnderlinedStyle = false;
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateDigits_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 45;
            this.label2.Text = "Teléfono";
            // 
            // txtExit
            // 
            this.txtExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.txtExit.BorderColor = System.Drawing.Color.Transparent;
            this.txtExit.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtExit.BorderRadius = 10;
            this.txtExit.BorderSize = 1;
            this.txtExit.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtExit.Location = new System.Drawing.Point(249, 260);
            this.txtExit.Margin = new System.Windows.Forms.Padding(4);
            this.txtExit.Multiline = false;
            this.txtExit.Name = "txtExit";
            this.txtExit.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.txtExit.PasswordChar = false;
            this.txtExit.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtExit.PlaceholderText = "";
            this.txtExit.Size = new System.Drawing.Size(195, 46);
            this.txtExit.TabIndex = 50;
            this.txtExit.Texts = "";
            this.txtExit.UnderlinedStyle = false;
            this.txtExit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateDigits_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 49;
            this.label3.Text = "Hora de Salida";
            // 
            // txtIncome
            // 
            this.txtIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.txtIncome.BorderColor = System.Drawing.Color.Transparent;
            this.txtIncome.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtIncome.BorderRadius = 10;
            this.txtIncome.BorderSize = 1;
            this.txtIncome.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIncome.Location = new System.Drawing.Point(29, 260);
            this.txtIncome.Margin = new System.Windows.Forms.Padding(4);
            this.txtIncome.Multiline = false;
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.txtIncome.PasswordChar = false;
            this.txtIncome.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtIncome.PlaceholderText = "";
            this.txtIncome.Size = new System.Drawing.Size(195, 46);
            this.txtIncome.TabIndex = 48;
            this.txtIncome.Texts = "";
            this.txtIncome.UnderlinedStyle = false;
            this.txtIncome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateDigits_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 47;
            this.label4.Text = "Hora de ingreso";
            // 
            // btnAddWaiter
            // 
            this.btnAddWaiter.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnAddWaiter.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnAddWaiter.BackColor = System.Drawing.Color.Transparent;
            this.btnAddWaiter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddWaiter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddWaiter.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWaiter.ForeColor = System.Drawing.Color.White;
            this.btnAddWaiter.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnAddWaiter.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnAddWaiter.Location = new System.Drawing.Point(28, 349);
            this.btnAddWaiter.Name = "btnAddWaiter";
            this.btnAddWaiter.Radius = 10;
            this.btnAddWaiter.Size = new System.Drawing.Size(416, 45);
            this.btnAddWaiter.Stroke = false;
            this.btnAddWaiter.StrokeColor = System.Drawing.Color.Gray;
            this.btnAddWaiter.TabIndex = 52;
            this.btnAddWaiter.Text = "Agregar";
            this.btnAddWaiter.Transparency = false;
            this.btnAddWaiter.Click += new System.EventHandler(this.btnAddWaiter_Click);
            // 
            // AddWaiterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(472, 419);
            this.Controls.Add(this.btnAddWaiter);
            this.Controls.Add(this.txtExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIncome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblAddWaiter);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddWaiterForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddWaiterForm";
            this.Deactivate += new System.EventHandler(this.AddWaiterForm_Deactivate);
            this.Load += new System.EventHandler(this.AddWaiterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.ModernTextBox txtName;
        private Components.ModernTextBox txtDNI;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAddWaiter;
        private FontAwesome.Sharp.IconButton btnClose;
        private Components.ModernTextBox txtLastName;
        private System.Windows.Forms.Label label1;
        private Components.ModernTextBox txtNumber;
        private System.Windows.Forms.Label label2;
        private Components.ModernTextBox txtExit;
        private System.Windows.Forms.Label label3;
        private Components.ModernTextBox txtIncome;
        private System.Windows.Forms.Label label4;
        private AltoControls.AltoButton btnAddWaiter;
    }
}