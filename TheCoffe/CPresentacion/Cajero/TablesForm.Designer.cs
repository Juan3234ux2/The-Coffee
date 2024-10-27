namespace TheCoffe.CPresentacion.Cajero
{
    partial class TablesForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sPanel85 = new Sipaa.Framework.SPanel();
            this.sPanel86 = new Sipaa.Framework.SPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlTables = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(16, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(970, 1);
            this.panel2.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 33);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mesas";
            // 
            // sPanel85
            // 
            this.sPanel85.BackColor = System.Drawing.Color.OrangeRed;
            this.sPanel85.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.sPanel85.BorderRadius = 6;
            this.sPanel85.BorderSize = 1;
            this.sPanel85.ForeColor = System.Drawing.Color.Red;
            this.sPanel85.Location = new System.Drawing.Point(22, 77);
            this.sPanel85.Name = "sPanel85";
            this.sPanel85.Size = new System.Drawing.Size(40, 30);
            this.sPanel85.TabIndex = 32;
            // 
            // sPanel86
            // 
            this.sPanel86.BackColor = System.Drawing.Color.LimeGreen;
            this.sPanel86.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.sPanel86.BorderRadius = 6;
            this.sPanel86.BorderSize = 1;
            this.sPanel86.ForeColor = System.Drawing.Color.Red;
            this.sPanel86.Location = new System.Drawing.Point(138, 77);
            this.sPanel86.Name = "sPanel86";
            this.sPanel86.Size = new System.Drawing.Size(40, 30);
            this.sPanel86.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(68, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 14);
            this.label9.TabIndex = 34;
            this.label9.Text = "Ocupado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(184, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 14);
            this.label2.TabIndex = 35;
            this.label2.Text = "Disponible";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(836, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "Seleccione una Mesa";
            // 
            // pnlTables
            // 
            this.pnlTables.Location = new System.Drawing.Point(22, 128);
            this.pnlTables.Name = "pnlTables";
            this.pnlTables.Size = new System.Drawing.Size(964, 408);
            this.pnlTables.TabIndex = 37;
            // 
            // TablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.pnlTables);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sPanel86);
            this.Controls.Add(this.sPanel85);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Name = "TablesForm";
            this.Size = new System.Drawing.Size(1030, 720);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Sipaa.Framework.SPanel sPanel85;
        private Sipaa.Framework.SPanel sPanel86;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel pnlTables;
    }
}
