namespace TheCoffe.App
{
    partial class AddTableForm
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
            this.label10 = new System.Windows.Forms.Label();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.txtNroMesa = new TheCoffe.Components.ModernTextBox();
            this.txtCantSillas = new TheCoffe.Components.ModernTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddTable = new AltoControls.AltoButton();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.label10.Location = new System.Drawing.Point(13, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(210, 22);
            this.label10.TabIndex = 38;
            this.label10.Text = "Agregar Nuevo Producto";
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
            this.btnClose.Location = new System.Drawing.Point(355, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 34);
            this.btnClose.TabIndex = 37;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtNroMesa
            // 
            this.txtNroMesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.txtNroMesa.BorderColor = System.Drawing.Color.Transparent;
            this.txtNroMesa.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtNroMesa.BorderRadius = 10;
            this.txtNroMesa.BorderSize = 1;
            this.txtNroMesa.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroMesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNroMesa.Location = new System.Drawing.Point(17, 86);
            this.txtNroMesa.Margin = new System.Windows.Forms.Padding(4);
            this.txtNroMesa.Multiline = false;
            this.txtNroMesa.Name = "txtNroMesa";
            this.txtNroMesa.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.txtNroMesa.PasswordChar = false;
            this.txtNroMesa.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNroMesa.PlaceholderText = "";
            this.txtNroMesa.Size = new System.Drawing.Size(382, 46);
            this.txtNroMesa.TabIndex = 42;
            this.txtNroMesa.Texts = "";
            this.txtNroMesa.UnderlinedStyle = false;
            // 
            // txtCantSillas
            // 
            this.txtCantSillas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.txtCantSillas.BorderColor = System.Drawing.Color.Transparent;
            this.txtCantSillas.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtCantSillas.BorderRadius = 10;
            this.txtCantSillas.BorderSize = 1;
            this.txtCantSillas.Font = new System.Drawing.Font("Roboto Medium", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantSillas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCantSillas.Location = new System.Drawing.Point(17, 177);
            this.txtCantSillas.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantSillas.Multiline = false;
            this.txtCantSillas.Name = "txtCantSillas";
            this.txtCantSillas.Padding = new System.Windows.Forms.Padding(10, 15, 10, 7);
            this.txtCantSillas.PasswordChar = false;
            this.txtCantSillas.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCantSillas.PlaceholderText = "";
            this.txtCantSillas.Size = new System.Drawing.Size(382, 46);
            this.txtCantSillas.TabIndex = 41;
            this.txtCantSillas.Texts = "";
            this.txtCantSillas.UnderlinedStyle = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 15);
            this.label8.TabIndex = 40;
            this.label8.Text = "Cant de Sillas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 15);
            this.label9.TabIndex = 39;
            this.label9.Text = "Nro de Mesa";
            // 
            // btnAddTable
            // 
            this.btnAddTable.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnAddTable.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnAddTable.BackColor = System.Drawing.Color.Transparent;
            this.btnAddTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTable.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddTable.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTable.ForeColor = System.Drawing.Color.White;
            this.btnAddTable.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnAddTable.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnAddTable.Location = new System.Drawing.Point(18, 255);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Radius = 10;
            this.btnAddTable.Size = new System.Drawing.Size(381, 45);
            this.btnAddTable.Stroke = false;
            this.btnAddTable.StrokeColor = System.Drawing.Color.Gray;
            this.btnAddTable.TabIndex = 43;
            this.btnAddTable.Text = "Agregar";
            this.btnAddTable.Transparency = false;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // AddTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(418, 317);
            this.Controls.Add(this.btnAddTable);
            this.Controls.Add(this.txtNroMesa);
            this.Controls.Add(this.txtCantSillas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Deactivate += new System.EventHandler(this.AddTableForm_Deactivate);
            this.Load += new System.EventHandler(this.AddTableForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton btnClose;
        private Components.ModernTextBox txtNroMesa;
        private Components.ModernTextBox txtCantSillas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private AltoControls.AltoButton btnAddTable;
    }
}
