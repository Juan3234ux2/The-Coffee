namespace TheCoffe.CPresentacion.Administrador
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnRestore = new WindowsFormsApplication1.RoundButton();
            this.btnCopia = new WindowsFormsApplication1.RoundButton();
            this.sPanel5 = new Sipaa.Framework.SPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sPanel1 = new Sipaa.Framework.SPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 41);
            this.label1.TabIndex = 16;
            this.label1.Text = "Configuraciones";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnRestore.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnRestore.BorderColor = System.Drawing.Color.Black;
            this.btnRestore.BorderRadius = 10;
            this.btnRestore.BorderSize = 0;
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.ForeColor = System.Drawing.Color.White;
            this.btnRestore.IconChar = FontAwesome.Sharp.IconChar.FileExport;
            this.btnRestore.IconColor = System.Drawing.Color.White;
            this.btnRestore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRestore.IconSize = 25;
            this.btnRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestore.Location = new System.Drawing.Point(60, 276);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRestore.Size = new System.Drawing.Size(170, 45);
            this.btnRestore.TabIndex = 18;
            this.btnRestore.Text = "Restaurar";
            this.btnRestore.TextColor = System.Drawing.Color.White;
            this.btnRestore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnCopia
            // 
            this.btnCopia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnCopia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnCopia.BorderColor = System.Drawing.Color.Black;
            this.btnCopia.BorderRadius = 10;
            this.btnCopia.BorderSize = 0;
            this.btnCopia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopia.FlatAppearance.BorderSize = 0;
            this.btnCopia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopia.ForeColor = System.Drawing.Color.White;
            this.btnCopia.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnCopia.IconColor = System.Drawing.Color.White;
            this.btnCopia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCopia.IconSize = 25;
            this.btnCopia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopia.Location = new System.Drawing.Point(55, 275);
            this.btnCopia.Name = "btnCopia";
            this.btnCopia.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCopia.Size = new System.Drawing.Size(170, 46);
            this.btnCopia.TabIndex = 17;
            this.btnCopia.Text = "Copia De Seguridad";
            this.btnCopia.TextColor = System.Drawing.Color.White;
            this.btnCopia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCopia.UseVisualStyleBackColor = false;
            this.btnCopia.Click += new System.EventHandler(this.btnCopia_Click);
            // 
            // sPanel5
            // 
            this.sPanel5.BackColor = System.Drawing.Color.White;
            this.sPanel5.BorderColor = System.Drawing.Color.White;
            this.sPanel5.BorderRadius = 15;
            this.sPanel5.BorderSize = 0;
            this.sPanel5.Controls.Add(this.pictureBox1);
            this.sPanel5.Controls.Add(this.label2);
            this.sPanel5.Controls.Add(this.btnCopia);
            this.sPanel5.ForeColor = System.Drawing.Color.Black;
            this.sPanel5.Location = new System.Drawing.Point(134, 168);
            this.sPanel5.Name = "sPanel5";
            this.sPanel5.Size = new System.Drawing.Size(280, 342);
            this.sPanel5.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 134);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "Generar Copia";
            // 
            // sPanel1
            // 
            this.sPanel1.BackColor = System.Drawing.Color.White;
            this.sPanel1.BorderColor = System.Drawing.Color.White;
            this.sPanel1.BorderRadius = 15;
            this.sPanel1.BorderSize = 0;
            this.sPanel1.Controls.Add(this.pictureBox2);
            this.sPanel1.Controls.Add(this.label3);
            this.sPanel1.Controls.Add(this.btnRestore);
            this.sPanel1.ForeColor = System.Drawing.Color.Black;
            this.sPanel1.Location = new System.Drawing.Point(578, 168);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Size = new System.Drawing.Size(280, 342);
            this.sPanel1.TabIndex = 33;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(71, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 134);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "Restaurar Base de Datos";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.sPanel1);
            this.Controls.Add(this.sPanel5);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SettingsForm";
            this.Size = new System.Drawing.Size(1183, 786);
            this.sPanel5.ResumeLayout(false);
            this.sPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sPanel1.ResumeLayout(false);
            this.sPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private WindowsFormsApplication1.RoundButton btnCopia;
        private WindowsFormsApplication1.RoundButton btnRestore;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Sipaa.Framework.SPanel sPanel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Sipaa.Framework.SPanel sPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
    }
}
