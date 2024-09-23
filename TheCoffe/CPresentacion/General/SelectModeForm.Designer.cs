namespace TheCoffe.CPresentacion.General
{
    partial class SelectModeForm
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
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.roundButton1 = new WindowsFormsApplication1.RoundButton();
            this.roundButton2 = new WindowsFormsApplication1.RoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnClose.IconColor = System.Drawing.Color.Red;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnClose.IconSize = 44;
            this.btnClose.Location = new System.Drawing.Point(396, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 34);
            this.btnClose.TabIndex = 11;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.roundButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.roundButton1.BorderColor = System.Drawing.Color.Black;
            this.roundButton1.BorderRadius = 20;
            this.roundButton1.BorderSize = 0;
            this.roundButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold);
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.roundButton1.IconColor = System.Drawing.Color.White;
            this.roundButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.roundButton1.IconSize = 40;
            this.roundButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundButton1.Location = new System.Drawing.Point(12, 74);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.roundButton1.Size = new System.Drawing.Size(410, 60);
            this.roundButton1.TabIndex = 15;
            this.roundButton1.Text = "     Punto de Venta";
            this.roundButton1.TextColor = System.Drawing.Color.White;
            this.roundButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundButton1.UseVisualStyleBackColor = false;
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.Teal;
            this.roundButton2.BackgroundColor = System.Drawing.Color.Teal;
            this.roundButton2.BorderColor = System.Drawing.Color.Black;
            this.roundButton2.BorderRadius = 20;
            this.roundButton2.BorderSize = 0;
            this.roundButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton2.FlatAppearance.BorderSize = 0;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton2.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold);
            this.roundButton2.ForeColor = System.Drawing.Color.White;
            this.roundButton2.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.roundButton2.IconColor = System.Drawing.Color.White;
            this.roundButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.roundButton2.IconSize = 40;
            this.roundButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundButton2.Location = new System.Drawing.Point(12, 151);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.roundButton2.Size = new System.Drawing.Size(410, 60);
            this.roundButton2.TabIndex = 16;
            this.roundButton2.Text = "     Panel Administrador";
            this.roundButton2.TextColor = System.Drawing.Color.White;
            this.roundButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundButton2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "¿Dónde desea ingresar?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SelectModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 237);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SelectModeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectModeForm";
            this.Load += new System.EventHandler(this.SelectModeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnClose;
        private WindowsFormsApplication1.RoundButton roundButton1;
        private WindowsFormsApplication1.RoundButton roundButton2;
        private System.Windows.Forms.Label label1;
    }
}