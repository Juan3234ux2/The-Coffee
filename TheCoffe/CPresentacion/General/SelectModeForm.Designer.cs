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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectModeForm));
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdmin = new WindowsFormsApplication1.RoundButton();
            this.btnPos = new WindowsFormsApplication1.RoundButton();
            this.roundButton1 = new WindowsFormsApplication1.RoundButton();
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
            this.btnClose.Location = new System.Drawing.Point(399, -2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 34);
            this.btnClose.TabIndex = 11;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "¿Dónde desea ingresar?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Teal;
            this.btnAdmin.BackgroundColor = System.Drawing.Color.Teal;
            this.btnAdmin.BorderColor = System.Drawing.Color.Black;
            this.btnAdmin.BorderRadius = 20;
            this.btnAdmin.BorderSize = 0;
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.btnAdmin.IconColor = System.Drawing.Color.White;
            this.btnAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdmin.IconSize = 40;
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(12, 151);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAdmin.Size = new System.Drawing.Size(410, 60);
            this.btnAdmin.TabIndex = 16;
            this.btnAdmin.Text = "     Panel Administrador";
            this.btnAdmin.TextColor = System.Drawing.Color.White;
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnPos
            // 
            this.btnPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnPos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnPos.BorderColor = System.Drawing.Color.Black;
            this.btnPos.BorderRadius = 20;
            this.btnPos.BorderSize = 0;
            this.btnPos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPos.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPos.FlatAppearance.BorderSize = 0;
            this.btnPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPos.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold);
            this.btnPos.ForeColor = System.Drawing.Color.White;
            this.btnPos.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.btnPos.IconColor = System.Drawing.Color.White;
            this.btnPos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPos.IconSize = 40;
            this.btnPos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPos.Location = new System.Drawing.Point(12, 74);
            this.btnPos.Name = "btnPos";
            this.btnPos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPos.Size = new System.Drawing.Size(410, 60);
            this.btnPos.TabIndex = 15;
            this.btnPos.Text = "     Punto de Venta";
            this.btnPos.TextColor = System.Drawing.Color.White;
            this.btnPos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPos.UseVisualStyleBackColor = false;
            this.btnPos.Click += new System.EventHandler(this.btnPos_Click);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.roundButton1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.roundButton1.BorderColor = System.Drawing.Color.Black;
            this.roundButton1.BorderRadius = 20;
            this.roundButton1.BorderSize = 0;
            this.roundButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton1.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold);
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.roundButton1.IconColor = System.Drawing.Color.White;
            this.roundButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.roundButton1.IconSize = 40;
            this.roundButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundButton1.Location = new System.Drawing.Point(12, 228);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.roundButton1.Size = new System.Drawing.Size(410, 60);
            this.roundButton1.TabIndex = 17;
            this.roundButton1.Text = "     Panel Gerente";
            this.roundButton1.TextColor = System.Drawing.Color.White;
            this.roundButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // SelectModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 306);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnPos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private WindowsFormsApplication1.RoundButton btnPos;
        private WindowsFormsApplication1.RoundButton btnAdmin;
        private System.Windows.Forms.Label label1;
        private WindowsFormsApplication1.RoundButton roundButton1;
    }
}