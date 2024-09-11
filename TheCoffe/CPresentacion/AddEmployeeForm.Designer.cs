namespace TheCoffe.App
{
    partial class AddEmployeeForm
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
            this.txtPrice = new TheCoffe.Components.ModernTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.modernTextBox1 = new TheCoffe.Components.ModernTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.modernTextBox2 = new TheCoffe.Components.ModernTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new AltoControls.AltoButton();
            this.modernTextBox3 = new TheCoffe.Components.ModernTextBox();
            this.modernTextBox4 = new TheCoffe.Components.ModernTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.txtName.Location = new System.Drawing.Point(23, 89);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceholderText = "";
            this.txtName.Size = new System.Drawing.Size(222, 46);
            this.txtName.TabIndex = 42;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = false;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.txtPrice.BorderColor = System.Drawing.Color.Transparent;
            this.txtPrice.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtPrice.BorderRadius = 10;
            this.txtPrice.BorderSize = 1;
            this.txtPrice.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrice.Location = new System.Drawing.Point(272, 89);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Multiline = false;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.txtPrice.PasswordChar = false;
            this.txtPrice.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.Size = new System.Drawing.Size(223, 46);
            this.txtPrice.TabIndex = 41;
            this.txtPrice.Texts = "";
            this.txtPrice.UnderlinedStyle = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(269, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 40;
            this.label8.Text = "Apellido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 39;
            this.label9.Text = "Nombre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.label10.Location = new System.Drawing.Point(18, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(217, 22);
            this.label10.TabIndex = 38;
            this.label10.Text = "Agregar Nuevo Empleado";
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
            this.btnClose.Location = new System.Drawing.Point(451, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 34);
            this.btnClose.TabIndex = 37;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // modernTextBox1
            // 
            this.modernTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.modernTextBox1.BorderColor = System.Drawing.Color.Transparent;
            this.modernTextBox1.BorderFocusColor = System.Drawing.Color.Transparent;
            this.modernTextBox1.BorderRadius = 10;
            this.modernTextBox1.BorderSize = 1;
            this.modernTextBox1.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modernTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modernTextBox1.Location = new System.Drawing.Point(21, 338);
            this.modernTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.modernTextBox1.Multiline = false;
            this.modernTextBox1.Name = "modernTextBox1";
            this.modernTextBox1.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.modernTextBox1.PasswordChar = false;
            this.modernTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.modernTextBox1.PlaceholderText = "";
            this.modernTextBox1.Size = new System.Drawing.Size(473, 46);
            this.modernTextBox1.TabIndex = 44;
            this.modernTextBox1.Texts = "";
            this.modernTextBox1.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "Teléfono";
            // 
            // modernTextBox2
            // 
            this.modernTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.modernTextBox2.BorderColor = System.Drawing.Color.Transparent;
            this.modernTextBox2.BorderFocusColor = System.Drawing.Color.Transparent;
            this.modernTextBox2.BorderRadius = 10;
            this.modernTextBox2.BorderSize = 1;
            this.modernTextBox2.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modernTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modernTextBox2.Location = new System.Drawing.Point(22, 249);
            this.modernTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.modernTextBox2.Multiline = false;
            this.modernTextBox2.Name = "modernTextBox2";
            this.modernTextBox2.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.modernTextBox2.PasswordChar = false;
            this.modernTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.modernTextBox2.PlaceholderText = "";
            this.modernTextBox2.Size = new System.Drawing.Size(473, 46);
            this.modernTextBox2.TabIndex = 46;
            this.modernTextBox2.Texts = "";
            this.modernTextBox2.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 45;
            this.label2.Text = "Email";
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
            this.btnAdd.Location = new System.Drawing.Point(22, 408);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Radius = 10;
            this.btnAdd.Size = new System.Drawing.Size(472, 45);
            this.btnAdd.Stroke = false;
            this.btnAdd.StrokeColor = System.Drawing.Color.Gray;
            this.btnAdd.TabIndex = 51;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.Transparency = false;
            // 
            // modernTextBox3
            // 
            this.modernTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.modernTextBox3.BorderColor = System.Drawing.Color.Transparent;
            this.modernTextBox3.BorderFocusColor = System.Drawing.Color.Transparent;
            this.modernTextBox3.BorderRadius = 10;
            this.modernTextBox3.BorderSize = 1;
            this.modernTextBox3.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modernTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modernTextBox3.Location = new System.Drawing.Point(23, 171);
            this.modernTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.modernTextBox3.Multiline = false;
            this.modernTextBox3.Name = "modernTextBox3";
            this.modernTextBox3.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.modernTextBox3.PasswordChar = false;
            this.modernTextBox3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.modernTextBox3.PlaceholderText = "";
            this.modernTextBox3.Size = new System.Drawing.Size(222, 46);
            this.modernTextBox3.TabIndex = 55;
            this.modernTextBox3.Texts = "";
            this.modernTextBox3.UnderlinedStyle = false;
            // 
            // modernTextBox4
            // 
            this.modernTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.modernTextBox4.BorderColor = System.Drawing.Color.Transparent;
            this.modernTextBox4.BorderFocusColor = System.Drawing.Color.Transparent;
            this.modernTextBox4.BorderRadius = 10;
            this.modernTextBox4.BorderSize = 1;
            this.modernTextBox4.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modernTextBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modernTextBox4.Location = new System.Drawing.Point(272, 171);
            this.modernTextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.modernTextBox4.Multiline = false;
            this.modernTextBox4.Name = "modernTextBox4";
            this.modernTextBox4.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.modernTextBox4.PasswordChar = false;
            this.modernTextBox4.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.modernTextBox4.PlaceholderText = "";
            this.modernTextBox4.Size = new System.Drawing.Size(223, 46);
            this.modernTextBox4.TabIndex = 54;
            this.modernTextBox4.Texts = "";
            this.modernTextBox4.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(269, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 53;
            this.label4.Text = "Hora Hasta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 52;
            this.label5.Text = "Hora Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(23, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "example@example.com";
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 475);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.modernTextBox3);
            this.Controls.Add(this.modernTextBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.modernTextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modernTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.ModernTextBox txtName;
        private Components.ModernTextBox txtPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton btnClose;
        private Components.ModernTextBox modernTextBox1;
        private System.Windows.Forms.Label label1;
        private Components.ModernTextBox modernTextBox2;
        private System.Windows.Forms.Label label2;
        private AltoControls.AltoButton btnAdd;
        private Components.ModernTextBox modernTextBox3;
        private Components.ModernTextBox modernTextBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}