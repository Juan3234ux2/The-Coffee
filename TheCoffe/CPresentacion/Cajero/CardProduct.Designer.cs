namespace TheCoffe.CPresentacion.Cajero
{
    partial class CardProduct
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
            this.sPanel1 = new Sipaa.Framework.SPanel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnMas = new AltoControls.AltoButton();
            this.btnMenos = new AltoControls.AltoButton();
            this.lblQty = new System.Windows.Forms.Label();
            this.btnDelete = new WindowsFormsApplication1.RoundButton();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sPanel1
            // 
            this.sPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sPanel1.BackColor = System.Drawing.Color.White;
            this.sPanel1.BorderColor = System.Drawing.Color.White;
            this.sPanel1.BorderRadius = 6;
            this.sPanel1.BorderSize = 1;
            this.sPanel1.Controls.Add(this.panel1);
            this.sPanel1.Controls.Add(this.lblDescription);
            this.sPanel1.Controls.Add(this.btnMas);
            this.sPanel1.Controls.Add(this.btnMenos);
            this.sPanel1.Controls.Add(this.lblQty);
            this.sPanel1.Controls.Add(this.btnDelete);
            this.sPanel1.Controls.Add(this.lblName);
            this.sPanel1.ForeColor = System.Drawing.Color.White;
            this.sPanel1.Location = new System.Drawing.Point(4, 3);
            this.sPanel1.MaximumSize = new System.Drawing.Size(282, 109);
            this.sPanel1.MinimumSize = new System.Drawing.Size(282, 109);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Size = new System.Drawing.Size(282, 109);
            this.sPanel1.TabIndex = 18;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Roboto", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.Black;
            this.lblDescription.Location = new System.Drawing.Point(13, 34);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(59, 13);
            this.lblDescription.TabIndex = 15;
            this.lblDescription.Text = "Descripcion";
            // 
            // btnMas
            // 
            this.btnMas.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnMas.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnMas.BackColor = System.Drawing.Color.Transparent;
            this.btnMas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMas.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnMas.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMas.ForeColor = System.Drawing.Color.Black;
            this.btnMas.Inactive1 = System.Drawing.Color.Silver;
            this.btnMas.Inactive2 = System.Drawing.Color.Silver;
            this.btnMas.Location = new System.Drawing.Point(64, 72);
            this.btnMas.Name = "btnMas";
            this.btnMas.Padding = new System.Windows.Forms.Padding(7);
            this.btnMas.Radius = 8;
            this.btnMas.Size = new System.Drawing.Size(24, 26);
            this.btnMas.Stroke = false;
            this.btnMas.StrokeColor = System.Drawing.Color.Gray;
            this.btnMas.TabIndex = 13;
            this.btnMas.Text = "+";
            this.btnMas.Transparency = false;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            this.btnMas.MouseLeave += new System.EventHandler(this.btnMas_MouseLeave);
            this.btnMas.MouseHover += new System.EventHandler(this.btnMas_MouseHover);
            // 
            // btnMenos
            // 
            this.btnMenos.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnMenos.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnMenos.BackColor = System.Drawing.Color.Transparent;
            this.btnMenos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenos.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnMenos.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.ForeColor = System.Drawing.Color.Black;
            this.btnMenos.Inactive1 = System.Drawing.Color.Silver;
            this.btnMenos.Inactive2 = System.Drawing.Color.Silver;
            this.btnMenos.Location = new System.Drawing.Point(9, 72);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Padding = new System.Windows.Forms.Padding(3, 9, 7, 7);
            this.btnMenos.Radius = 8;
            this.btnMenos.Size = new System.Drawing.Size(24, 26);
            this.btnMenos.Stroke = false;
            this.btnMenos.StrokeColor = System.Drawing.Color.Gray;
            this.btnMenos.TabIndex = 12;
            this.btnMenos.Text = "-";
            this.btnMenos.Transparency = false;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            this.btnMenos.MouseLeave += new System.EventHandler(this.btnMas_MouseLeave);
            this.btnMenos.MouseHover += new System.EventHandler(this.btnMas_MouseHover);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.ForeColor = System.Drawing.Color.Black;
            this.lblQty.Location = new System.Drawing.Point(39, 76);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(19, 19);
            this.lblQty.TabIndex = 11;
            this.lblQty.Text = "0";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.BorderRadius = 10;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDelete.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 23;
            this.btnDelete.Location = new System.Drawing.Point(227, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(51, 40);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPrice.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(79, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 19);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "$ 0";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Roboto Medium", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(11, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 18);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Nombre";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Location = new System.Drawing.Point(150, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 19);
            this.panel1.TabIndex = 16;
            // 
            // CardProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.sPanel1);
            this.Margin = new System.Windows.Forms.Padding(17, 3, 3, 3);
            this.MaximumSize = new System.Drawing.Size(290, 115);
            this.MinimumSize = new System.Drawing.Size(290, 115);
            this.Name = "CardProduct";
            this.Size = new System.Drawing.Size(290, 115);
            this.sPanel1.ResumeLayout(false);
            this.sPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sipaa.Framework.SPanel sPanel1;
        private System.Windows.Forms.Label lblDescription;
        private AltoControls.AltoButton btnMas;
        private AltoControls.AltoButton btnMenos;
        private System.Windows.Forms.Label lblQty;
        private WindowsFormsApplication1.RoundButton btnDelete;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel1;
    }
}
