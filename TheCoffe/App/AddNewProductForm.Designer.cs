namespace TheCoffe.App
{
    partial class AddNewProductForm
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNewProduct = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCategory = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.altoButton1 = new AltoControls.AltoButton();
            this.Imagen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.modernTextBox1 = new TheCoffe.Components.ModernTextBox();
            this.cboCategory = new CustomComboBox();
            this.modernTextBox4 = new TheCoffe.Components.ModernTextBox();
            this.txtPrice = new TheCoffe.Components.ModernTextBox();
            this.txtName = new TheCoffe.Components.ModernTextBox();
            this.cuiBorder1 = new CuoreUI.Controls.cuiBorder();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNewProduct
            // 
            this.lblNewProduct.AutoSize = true;
            this.lblNewProduct.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewProduct.Location = new System.Drawing.Point(24, 19);
            this.lblNewProduct.Name = "lblNewProduct";
            this.lblNewProduct.Size = new System.Drawing.Size(229, 33);
            this.lblNewProduct.TabIndex = 16;
            this.lblNewProduct.Text = "Agregar Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(117, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 89;
            this.label1.Text = "Descripcion";
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.White;
            this.btnCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.btnCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.IconChar = FontAwesome.Sharp.IconChar.AngleDown;
            this.btnCategory.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnCategory.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCategory.IconSize = 25;
            this.btnCategory.Location = new System.Drawing.Point(507, 279);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(33, 35);
            this.btnCategory.TabIndex = 85;
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCategory.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(117, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 82;
            this.label7.Text = "Categoría";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(117, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 79;
            this.label8.Text = "Precio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(117, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 78;
            this.label9.Text = "Nombre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.InitialImage = global::TheCoffe.Properties.Resources.hombre;
            this.pictureBox1.Location = new System.Drawing.Point(200, 406);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cuiBorder1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Imagen);
            this.panel1.Controls.Add(this.altoButton1);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(30, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 594);
            this.panel1.TabIndex = 91;
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
            this.altoButton1.Location = new System.Drawing.Point(367, 456);
            this.altoButton1.Name = "altoButton1";
            this.altoButton1.Radius = 10;
            this.altoButton1.Size = new System.Drawing.Size(150, 45);
            this.altoButton1.Stroke = false;
            this.altoButton1.StrokeColor = System.Drawing.Color.Gray;
            this.altoButton1.TabIndex = 88;
            this.altoButton1.Text = "Cambiar Imagen ";
            this.altoButton1.Transparency = false;
            // 
            // Imagen
            // 
            this.Imagen.AutoSize = true;
            this.Imagen.BackColor = System.Drawing.Color.White;
            this.Imagen.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Imagen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Imagen.Location = new System.Drawing.Point(87, 417);
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(50, 15);
            this.Imagen.TabIndex = 92;
            this.Imagen.Text = "Imagen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(87, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 22);
            this.label2.TabIndex = 92;
            this.label2.Text = "Informacion del producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(549, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 93;
            this.label3.Text = "Variantes";
            // 
            // modernTextBox1
            // 
            this.modernTextBox1.BackColor = System.Drawing.Color.White;
            this.modernTextBox1.BorderColor = System.Drawing.Color.DimGray;
            this.modernTextBox1.BorderFocusColor = System.Drawing.Color.Transparent;
            this.modernTextBox1.BorderRadius = 10;
            this.modernTextBox1.BorderSize = 1;
            this.modernTextBox1.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modernTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modernTextBox1.Location = new System.Drawing.Point(233, 344);
            this.modernTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.modernTextBox1.Multiline = true;
            this.modernTextBox1.Name = "modernTextBox1";
            this.modernTextBox1.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.modernTextBox1.PasswordChar = false;
            this.modernTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.modernTextBox1.PlaceholderText = "";
            this.modernTextBox1.Size = new System.Drawing.Size(314, 112);
            this.modernTextBox1.TabIndex = 90;
            this.modernTextBox1.Texts = "";
            this.modernTextBox1.UnderlinedStyle = false;
            // 
            // cboCategory
            // 
            this.cboCategory.BackColor = System.Drawing.Color.White;
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
            this.cboCategory.Location = new System.Drawing.Point(237, 283);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(280, 24);
            this.cboCategory.TabIndex = 84;
            // 
            // modernTextBox4
            // 
            this.modernTextBox4.BackColor = System.Drawing.Color.White;
            this.modernTextBox4.BorderColor = System.Drawing.Color.DimGray;
            this.modernTextBox4.BorderFocusColor = System.Drawing.Color.Transparent;
            this.modernTextBox4.BorderRadius = 10;
            this.modernTextBox4.BorderSize = 1;
            this.modernTextBox4.Enabled = false;
            this.modernTextBox4.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modernTextBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modernTextBox4.Location = new System.Drawing.Point(230, 272);
            this.modernTextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.modernTextBox4.Multiline = false;
            this.modernTextBox4.Name = "modernTextBox4";
            this.modernTextBox4.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.modernTextBox4.PasswordChar = false;
            this.modernTextBox4.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.modernTextBox4.PlaceholderText = "";
            this.modernTextBox4.Size = new System.Drawing.Size(317, 46);
            this.modernTextBox4.TabIndex = 83;
            this.modernTextBox4.Texts = "";
            this.modernTextBox4.UnderlinedStyle = false;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.BorderColor = System.Drawing.Color.DimGray;
            this.txtPrice.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtPrice.BorderRadius = 10;
            this.txtPrice.BorderSize = 1;
            this.txtPrice.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrice.Location = new System.Drawing.Point(230, 200);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Multiline = false;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.txtPrice.PasswordChar = false;
            this.txtPrice.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.Size = new System.Drawing.Size(317, 46);
            this.txtPrice.TabIndex = 80;
            this.txtPrice.Texts = "";
            this.txtPrice.UnderlinedStyle = false;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderColor = System.Drawing.Color.DimGray;
            this.txtName.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtName.BorderRadius = 10;
            this.txtName.BorderSize = 1;
            this.txtName.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.Location = new System.Drawing.Point(200, 59);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.txtName.PasswordChar = false;
            this.txtName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtName.PlaceholderText = "";
            this.txtName.Size = new System.Drawing.Size(317, 46);
            this.txtName.TabIndex = 81;
            this.txtName.Texts = "";
            this.txtName.UnderlinedStyle = false;
            // 
            // cuiBorder1
            // 
            this.cuiBorder1.Location = new System.Drawing.Point(538, 82);
            this.cuiBorder1.Name = "cuiBorder1";
            this.cuiBorder1.OutlineThickness = 1F;
            this.cuiBorder1.PanelColor = System.Drawing.Color.Coral;
            this.cuiBorder1.PanelOutlineColor = System.Drawing.Color.Coral;
            this.cuiBorder1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiBorder1.Size = new System.Drawing.Size(462, 456);
            this.cuiBorder1.TabIndex = 94;
            // 
            // AddNewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.label7);
            this.Controls.Add(this.modernTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.modernTextBox4);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblNewProduct);
            this.Controls.Add(this.panel1);
            this.Name = "AddNewProductForm";
            this.Size = new System.Drawing.Size(1030, 720);
            this.Load += new System.EventHandler(this.AddNewProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewProduct;
        private Components.ModernTextBox modernTextBox1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnCategory;
        private CustomComboBox cboCategory;
        private Components.ModernTextBox modernTextBox4;
        private System.Windows.Forms.Label label7;
        private Components.ModernTextBox txtPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Components.ModernTextBox txtName;
        private System.Windows.Forms.Panel panel1;
        private AltoControls.AltoButton altoButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Imagen;
        private CuoreUI.Controls.cuiBorder cuiBorder1;
    }
}
