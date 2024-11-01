namespace TheCoffe.CPresentacion.General
{
    partial class RemovedCategoriesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataRemovedCategory = new System.Windows.Forms.DataGridView();
            this.id_categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnSig = new WindowsFormsApplication1.RoundButton();
            this.btnAnt = new WindowsFormsApplication1.RoundButton();
            this.lblPagina = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataRemovedCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 41);
            this.label1.TabIndex = 16;
            this.label1.Text = "Categorías Eliminadas";
            // 
            // dataRemovedCategory
            // 
            this.dataRemovedCategory.AllowUserToAddRows = false;
            this.dataRemovedCategory.AllowUserToDeleteRows = false;
            this.dataRemovedCategory.AllowUserToResizeColumns = false;
            this.dataRemovedCategory.AllowUserToResizeRows = false;
            this.dataRemovedCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataRemovedCategory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataRemovedCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataRemovedCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataRemovedCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Roboto Medium", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataRemovedCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataRemovedCategory.ColumnHeadersHeight = 45;
            this.dataRemovedCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataRemovedCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_categoria,
            this.nombre,
            this.activar});
            this.dataRemovedCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataRemovedCategory.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataRemovedCategory.EnableHeadersVisualStyles = false;
            this.dataRemovedCategory.GridColor = System.Drawing.Color.Silver;
            this.dataRemovedCategory.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataRemovedCategory.Location = new System.Drawing.Point(24, 73);
            this.dataRemovedCategory.MultiSelect = false;
            this.dataRemovedCategory.Name = "dataRemovedCategory";
            this.dataRemovedCategory.ReadOnly = true;
            this.dataRemovedCategory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataRemovedCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataRemovedCategory.RowHeadersVisible = false;
            this.dataRemovedCategory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dataRemovedCategory.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataRemovedCategory.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataRemovedCategory.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataRemovedCategory.RowTemplate.DividerHeight = 1;
            this.dataRemovedCategory.RowTemplate.Height = 45;
            this.dataRemovedCategory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataRemovedCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataRemovedCategory.ShowCellErrors = false;
            this.dataRemovedCategory.ShowCellToolTips = false;
            this.dataRemovedCategory.ShowEditingIcon = false;
            this.dataRemovedCategory.ShowRowErrors = false;
            this.dataRemovedCategory.Size = new System.Drawing.Size(976, 479);
            this.dataRemovedCategory.TabIndex = 18;
            this.dataRemovedCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCategory_CellClick);
            this.dataRemovedCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataRemovedCategory_CellContentClick);
            // 
            // id_categoria
            // 
            this.id_categoria.DataPropertyName = "id_categoria";
            this.id_categoria.FillWeight = 15.93962F;
            this.id_categoria.HeaderText = "ID";
            this.id_categoria.Name = "id_categoria";
            this.id_categoria.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "descripcion";
            this.nombre.FillWeight = 186.1617F;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // activar
            // 
            this.activar.FillWeight = 19.08735F;
            this.activar.HeaderText = "Activar";
            this.activar.Image = global::TheCoffe.Properties.Resources.activar;
            this.activar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.activar.Name = "activar";
            this.activar.ReadOnly = true;
            this.activar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 21.18868F;
            this.dataGridViewImageColumn1.HeaderText = "Activar";
            this.dataGridViewImageColumn1.Image = global::TheCoffe.Properties.Resources.activar;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 68;
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
            this.btnClose.Location = new System.Drawing.Point(974, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 37);
            this.btnClose.TabIndex = 29;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSig
            // 
            this.btnSig.BackColor = System.Drawing.Color.Transparent;
            this.btnSig.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSig.BorderColor = System.Drawing.Color.Black;
            this.btnSig.BorderRadius = 20;
            this.btnSig.BorderSize = 0;
            this.btnSig.FlatAppearance.BorderSize = 0;
            this.btnSig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnSig.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.btnSig.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnSig.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSig.Location = new System.Drawing.Point(959, 548);
            this.btnSig.Name = "btnSig";
            this.btnSig.Size = new System.Drawing.Size(25, 40);
            this.btnSig.TabIndex = 32;
            this.btnSig.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnSig.UseVisualStyleBackColor = false;
            this.btnSig.Click += new System.EventHandler(this.btnSig_Click);
            // 
            // btnAnt
            // 
            this.btnAnt.BackColor = System.Drawing.Color.Transparent;
            this.btnAnt.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAnt.BorderColor = System.Drawing.Color.Black;
            this.btnAnt.BorderRadius = 20;
            this.btnAnt.BorderSize = 0;
            this.btnAnt.FlatAppearance.BorderSize = 0;
            this.btnAnt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnAnt.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.btnAnt.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnAnt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAnt.Location = new System.Drawing.Point(822, 548);
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Size = new System.Drawing.Size(25, 40);
            this.btnAnt.TabIndex = 31;
            this.btnAnt.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnAnt.UseVisualStyleBackColor = false;
            this.btnAnt.Click += new System.EventHandler(this.btnAnt_Click);
            // 
            // lblPagina
            // 
            this.lblPagina.AutoSize = true;
            this.lblPagina.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagina.Location = new System.Drawing.Point(852, 558);
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(102, 17);
            this.lblPagina.TabIndex = 30;
            this.lblPagina.Text = "Pagina 1 de 10";
            // 
            // RemovedCategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1030, 600);
            this.Controls.Add(this.btnSig);
            this.Controls.Add(this.btnAnt);
            this.Controls.Add(this.lblPagina);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataRemovedCategory);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RemovedCategoriesForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemovedCategoriesForm";
            this.Deactivate += new System.EventHandler(this.RemovedCategoriesForm_Deactivate);
            this.Load += new System.EventHandler(this.RemovedCategoriesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataRemovedCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataRemovedCategory;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewImageColumn activar;
        private WindowsFormsApplication1.RoundButton btnSig;
        private WindowsFormsApplication1.RoundButton btnAnt;
        private System.Windows.Forms.Label lblPagina;
    }
}