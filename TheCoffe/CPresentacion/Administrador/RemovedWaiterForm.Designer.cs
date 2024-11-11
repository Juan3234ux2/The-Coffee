namespace TheCoffe.CPresentacion
{
    partial class RemovedWaiterForm
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
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dataRemovedWaiter = new System.Windows.Forms.DataGridView();
            this.id_mesero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnSig = new WindowsFormsApplication1.RoundButton();
            this.btnAnt = new WindowsFormsApplication1.RoundButton();
            this.lblPagina = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataRemovedWaiter)).BeginInit();
            this.SuspendLayout();
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
            this.btnClose.TabIndex = 31;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 41);
            this.label1.TabIndex = 30;
            this.label1.Text = "Meseros Eliminados";
            // 
            // dataRemovedWaiter
            // 
            this.dataRemovedWaiter.AllowUserToAddRows = false;
            this.dataRemovedWaiter.AllowUserToDeleteRows = false;
            this.dataRemovedWaiter.AllowUserToResizeColumns = false;
            this.dataRemovedWaiter.AllowUserToResizeRows = false;
            this.dataRemovedWaiter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataRemovedWaiter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataRemovedWaiter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataRemovedWaiter.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataRemovedWaiter.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Roboto Medium", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataRemovedWaiter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataRemovedWaiter.ColumnHeadersHeight = 45;
            this.dataRemovedWaiter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataRemovedWaiter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_mesero,
            this.nombre,
            this.Apellido,
            this.telefono,
            this.hora_entrada,
            this.hora_salida,
            this.activar});
            this.dataRemovedWaiter.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataRemovedWaiter.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataRemovedWaiter.EnableHeadersVisualStyles = false;
            this.dataRemovedWaiter.GridColor = System.Drawing.Color.Silver;
            this.dataRemovedWaiter.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataRemovedWaiter.Location = new System.Drawing.Point(24, 73);
            this.dataRemovedWaiter.MultiSelect = false;
            this.dataRemovedWaiter.Name = "dataRemovedWaiter";
            this.dataRemovedWaiter.ReadOnly = true;
            this.dataRemovedWaiter.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataRemovedWaiter.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataRemovedWaiter.RowHeadersVisible = false;
            this.dataRemovedWaiter.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dataRemovedWaiter.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataRemovedWaiter.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataRemovedWaiter.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataRemovedWaiter.RowTemplate.DividerHeight = 1;
            this.dataRemovedWaiter.RowTemplate.Height = 45;
            this.dataRemovedWaiter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataRemovedWaiter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataRemovedWaiter.ShowCellErrors = false;
            this.dataRemovedWaiter.ShowCellToolTips = false;
            this.dataRemovedWaiter.ShowEditingIcon = false;
            this.dataRemovedWaiter.ShowRowErrors = false;
            this.dataRemovedWaiter.Size = new System.Drawing.Size(976, 479);
            this.dataRemovedWaiter.TabIndex = 32;
            this.dataRemovedWaiter.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataRemovedWaiter_CellClick);
            // 
            // id_mesero
            // 
            this.id_mesero.DataPropertyName = "id_mesero";
            this.id_mesero.FillWeight = 33.3549F;
            this.id_mesero.HeaderText = "ID";
            this.id_mesero.Name = "id_mesero";
            this.id_mesero.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.FillWeight = 113.5201F;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "apellido";
            this.Apellido.FillWeight = 113.5201F;
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.FillWeight = 113.5201F;
            this.telefono.HeaderText = "Teléfono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // hora_entrada
            // 
            this.hora_entrada.DataPropertyName = "hora_entrada";
            this.hora_entrada.FillWeight = 113.5201F;
            this.hora_entrada.HeaderText = "Hora Entrada";
            this.hora_entrada.Name = "hora_entrada";
            this.hora_entrada.ReadOnly = true;
            // 
            // hora_salida
            // 
            this.hora_salida.DataPropertyName = "hora_salida";
            this.hora_salida.FillWeight = 113.5201F;
            this.hora_salida.HeaderText = "Hora Salida";
            this.hora_salida.Name = "hora_salida";
            this.hora_salida.ReadOnly = true;
            // 
            // activar
            // 
            this.activar.FillWeight = 56.13629F;
            this.activar.HeaderText = "Activar";
            this.activar.Image = global::TheCoffe.Properties.Resources.activar;
            this.activar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.activar.Name = "activar";
            this.activar.ReadOnly = true;
            this.activar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.activar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.btnSig.Location = new System.Drawing.Point(960, 548);
            this.btnSig.Name = "btnSig";
            this.btnSig.Size = new System.Drawing.Size(25, 40);
            this.btnSig.TabIndex = 38;
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
            this.btnAnt.Location = new System.Drawing.Point(821, 548);
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Size = new System.Drawing.Size(25, 40);
            this.btnAnt.TabIndex = 37;
            this.btnAnt.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            this.btnAnt.UseVisualStyleBackColor = false;
            this.btnAnt.Click += new System.EventHandler(this.btnAnt_Click);
            // 
            // lblPagina
            // 
            this.lblPagina.AutoSize = true;
            this.lblPagina.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagina.Location = new System.Drawing.Point(852, 557);
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(102, 17);
            this.lblPagina.TabIndex = 36;
            this.lblPagina.Text = "Pagina 1 de 10";
            // 
            // RemovedWaiterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1030, 600);
            this.Controls.Add(this.btnSig);
            this.Controls.Add(this.btnAnt);
            this.Controls.Add(this.lblPagina);
            this.Controls.Add(this.dataRemovedWaiter);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RemovedWaiterForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemovedWaiterForm";
            this.Deactivate += new System.EventHandler(this.RemovedWaiterForm_Deactivate);
            this.Load += new System.EventHandler(this.RemovedWaiterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataRemovedWaiter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataRemovedWaiter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_mesero;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_salida;
        private System.Windows.Forms.DataGridViewImageColumn activar;
        private WindowsFormsApplication1.RoundButton btnSig;
        private WindowsFormsApplication1.RoundButton btnAnt;
        private System.Windows.Forms.Label lblPagina;
    }
}