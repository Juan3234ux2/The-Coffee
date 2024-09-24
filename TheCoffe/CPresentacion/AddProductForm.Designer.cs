namespace TheCoffe.App
{
    partial class AddProductForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDescription = new TheCoffe.Components.ModernTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.altoButton1 = new AltoControls.AltoButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCategory = new FontAwesome.Sharp.IconButton();
            this.cboCategory = new CustomComboBox();
            this.modernTextBox4 = new TheCoffe.Components.ModernTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new TheCoffe.Components.ModernTextBox();
            this.txtPrice = new TheCoffe.Components.ModernTextBox();
            this.btnAdd = new AltoControls.AltoButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.altoButton1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnCategory);
            this.panel1.Controls.Add(this.cboCategory);
            this.panel1.Controls.Add(this.modernTextBox4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 533);
            this.panel1.TabIndex = 24;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.txtDescription.BorderColor = System.Drawing.Color.Transparent;
            this.txtDescription.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtDescription.BorderRadius = 10;
            this.txtDescription.BorderSize = 1;
            this.txtDescription.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescription.Location = new System.Drawing.Point(372, 84);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.txtDescription.PasswordChar = false;
            this.txtDescription.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.Size = new System.Drawing.Size(317, 206);
            this.txtDescription.TabIndex = 77;
            this.txtDescription.Texts = "";
            this.txtDescription.UnderlinedStyle = false;
            this.txtDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescription_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 76;
            this.label1.Text = "Descripcion";
            // 
            // altoButton1
            // 
            this.altoButton1.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.altoButton1.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.altoButton1.BackColor = System.Drawing.Color.Transparent;
            this.altoButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.altoButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.altoButton1.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altoButton1.ForeColor = System.Drawing.Color.White;
            this.altoButton1.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.altoButton1.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.altoButton1.Location = new System.Drawing.Point(142, 355);
            this.altoButton1.Name = "altoButton1";
            this.altoButton1.Radius = 10;
            this.altoButton1.Size = new System.Drawing.Size(154, 45);
            this.altoButton1.Stroke = false;
            this.altoButton1.StrokeColor = System.Drawing.Color.Gray;
            this.altoButton1.TabIndex = 75;
            this.altoButton1.Text = "Cambiar Imagen ";
            this.altoButton1.Transparency = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.InitialImage = global::TheCoffe.Properties.Resources.hombre;
            this.pictureBox1.Location = new System.Drawing.Point(33, 325);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 73;
            this.label6.Text = "Imagen";
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.btnCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.btnCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.btnCategory.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnCategory.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCategory.IconSize = 25;
            this.btnCategory.Location = new System.Drawing.Point(310, 251);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(33, 35);
            this.btnCategory.TabIndex = 72;
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click_1);
            // 
            // cboCategory
            // 
            this.cboCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.cboCategory.BorderColor = System.Drawing.Color.Transparent;
            this.cboCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.DropDownWidth = 310;
            this.cboCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCategory.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Items.AddRange(new object[] {
            "Cafe",
            "Cocido",
            "Chocolate"});
            this.cboCategory.Location = new System.Drawing.Point(38, 255);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(280, 24);
            this.cboCategory.TabIndex = 71;
            // 
            // modernTextBox4
            // 
            this.modernTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.modernTextBox4.BorderColor = System.Drawing.Color.Transparent;
            this.modernTextBox4.BorderFocusColor = System.Drawing.Color.Transparent;
            this.modernTextBox4.BorderRadius = 10;
            this.modernTextBox4.BorderSize = 1;
            this.modernTextBox4.Enabled = false;
            this.modernTextBox4.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modernTextBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modernTextBox4.Location = new System.Drawing.Point(32, 244);
            this.modernTextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.modernTextBox4.Multiline = false;
            this.modernTextBox4.Name = "modernTextBox4";
            this.modernTextBox4.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.modernTextBox4.PasswordChar = false;
            this.modernTextBox4.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.modernTextBox4.PlaceholderText = "";
            this.modernTextBox4.Size = new System.Drawing.Size(317, 46);
            this.modernTextBox4.TabIndex = 70;
            this.modernTextBox4.Texts = "";
            this.modernTextBox4.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 69;
            this.label7.Text = "Categoría";
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
            this.txtName.Location = new System.Drawing.Point(33, 84);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceholderText = "";
            this.txtName.Size = new System.Drawing.Size(317, 46);
            this.txtName.TabIndex = 36;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = false;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
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
            this.txtPrice.Location = new System.Drawing.Point(32, 163);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Multiline = false;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.txtPrice.PasswordChar = false;
            this.txtPrice.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.Size = new System.Drawing.Size(317, 46);
            this.txtPrice.TabIndex = 35;
            this.txtPrice.Texts = "";
            this.txtPrice.UnderlinedStyle = false;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
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
            this.btnAdd.Location = new System.Drawing.Point(34, 457);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Radius = 10;
            this.btnAdd.Size = new System.Drawing.Size(651, 45);
            this.btnAdd.Stroke = false;
            this.btnAdd.StrokeColor = System.Drawing.Color.Gray;
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.Transparency = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 28;
            this.label8.Text = "Precio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "Nombre";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.lblTitle.Location = new System.Drawing.Point(28, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(154, 22);
            this.lblTitle.TabIndex = 25;
            this.lblTitle.Text = "Agregar Producto";
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
            this.btnClose.Location = new System.Drawing.Point(648, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 34);
            this.btnClose.TabIndex = 24;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(719, 531);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "AddProductForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddProductForm";
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.AddProductForm_Deactivate);
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private AltoControls.AltoButton btnAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconButton btnClose;
        private Components.ModernTextBox txtPrice;
        private Components.ModernTextBox txtName;
        private Components.ModernTextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private AltoControls.AltoButton altoButton1;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btnCategory;
        private CustomComboBox cboCategory;
        private Components.ModernTextBox modernTextBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}