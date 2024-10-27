namespace TheCoffe.CPresentacion.Components
{
    partial class Table2
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
            this.sPanel21 = new Sipaa.Framework.SPanel();
            this.sPanel24 = new Sipaa.Framework.SPanel();
            this.sPanel28 = new Sipaa.Framework.SPanel();
            this.sPanel30 = new Sipaa.Framework.SPanel();
            this.btnMesa = new WindowsFormsApplication1.RoundButton();
            this.sPanel21.SuspendLayout();
            this.sPanel30.SuspendLayout();
            this.SuspendLayout();
            // 
            // sPanel21
            // 
            this.sPanel21.BackColor = System.Drawing.Color.Transparent;
            this.sPanel21.BorderColor = System.Drawing.Color.Transparent;
            this.sPanel21.BorderRadius = 6;
            this.sPanel21.BorderSize = 1;
            this.sPanel21.Controls.Add(this.sPanel24);
            this.sPanel21.Controls.Add(this.sPanel28);
            this.sPanel21.Controls.Add(this.sPanel30);
            this.sPanel21.ForeColor = System.Drawing.Color.Red;
            this.sPanel21.Location = new System.Drawing.Point(10, 10);
            this.sPanel21.Name = "sPanel21";
            this.sPanel21.Size = new System.Drawing.Size(142, 132);
            this.sPanel21.TabIndex = 24;
            // 
            // sPanel24
            // 
            this.sPanel24.BackColor = System.Drawing.Color.White;
            this.sPanel24.BorderColor = System.Drawing.Color.White;
            this.sPanel24.BorderRadius = 6;
            this.sPanel24.BorderSize = 1;
            this.sPanel24.ForeColor = System.Drawing.Color.Red;
            this.sPanel24.Location = new System.Drawing.Point(115, 48);
            this.sPanel24.Name = "sPanel24";
            this.sPanel24.Size = new System.Drawing.Size(10, 35);
            this.sPanel24.TabIndex = 28;
            // 
            // sPanel28
            // 
            this.sPanel28.BackColor = System.Drawing.Color.White;
            this.sPanel28.BorderColor = System.Drawing.Color.White;
            this.sPanel28.BorderRadius = 6;
            this.sPanel28.BorderSize = 1;
            this.sPanel28.ForeColor = System.Drawing.Color.Red;
            this.sPanel28.Location = new System.Drawing.Point(15, 48);
            this.sPanel28.Name = "sPanel28";
            this.sPanel28.Size = new System.Drawing.Size(10, 35);
            this.sPanel28.TabIndex = 24;
            // 
            // sPanel30
            // 
            this.sPanel30.BackColor = System.Drawing.Color.White;
            this.sPanel30.BorderColor = System.Drawing.Color.White;
            this.sPanel30.BorderRadius = 6;
            this.sPanel30.BorderSize = 1;
            this.sPanel30.Controls.Add(this.btnMesa);
            this.sPanel30.ForeColor = System.Drawing.Color.White;
            this.sPanel30.Location = new System.Drawing.Point(29, 23);
            this.sPanel30.Name = "sPanel30";
            this.sPanel30.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sPanel30.Size = new System.Drawing.Size(80, 80);
            this.sPanel30.TabIndex = 21;
            // 
            // btnMesa
            // 
            this.btnMesa.BackColor = System.Drawing.Color.OrangeRed;
            this.btnMesa.BackgroundColor = System.Drawing.Color.OrangeRed;
            this.btnMesa.BorderColor = System.Drawing.Color.Black;
            this.btnMesa.BorderRadius = 20;
            this.btnMesa.BorderSize = 0;
            this.btnMesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMesa.FlatAppearance.BorderSize = 0;
            this.btnMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesa.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMesa.ForeColor = System.Drawing.Color.White;
            this.btnMesa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMesa.IconColor = System.Drawing.Color.Black;
            this.btnMesa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMesa.Location = new System.Drawing.Point(15, 19);
            this.btnMesa.Name = "btnMesa";
            this.btnMesa.Padding = new System.Windows.Forms.Padding(10);
            this.btnMesa.Size = new System.Drawing.Size(51, 41);
            this.btnMesa.TabIndex = 25;
            this.btnMesa.Text = "1";
            this.btnMesa.TextColor = System.Drawing.Color.White;
            this.btnMesa.UseVisualStyleBackColor = false;
            this.btnMesa.Click += new System.EventHandler(this.btnMesa_Click);
            // 
            // Table2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.sPanel21);
            this.Name = "Table2";
            this.Size = new System.Drawing.Size(162, 153);
            this.sPanel21.ResumeLayout(false);
            this.sPanel30.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sipaa.Framework.SPanel sPanel21;
        private Sipaa.Framework.SPanel sPanel24;
        private Sipaa.Framework.SPanel sPanel28;
        private Sipaa.Framework.SPanel sPanel30;
        private WindowsFormsApplication1.RoundButton btnMesa;
    }
}
