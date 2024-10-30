namespace TheCoffe.CPresentacion.Components
{
    partial class MesaControl
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
            this.btnMesa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMesa
            // 
            this.btnMesa.Location = new System.Drawing.Point(3, 3);
            this.btnMesa.Name = "btnMesa";
            this.btnMesa.Size = new System.Drawing.Size(75, 23);
            this.btnMesa.TabIndex = 0;
            this.btnMesa.UseVisualStyleBackColor = true;
            this.btnMesa.Visible = false;
            // 
            // MesaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnMesa);
            this.Name = "MesaControl";
            this.Size = new System.Drawing.Size(86, 33);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMesa;
    }
}
