﻿namespace TheCoffe.CPresentacion
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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activar = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.dataRemovedWaiter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
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
            this.ID,
            this.Nombre,
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4,
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
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dataRemovedWaiter.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataRemovedWaiter.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.dataRemovedWaiter.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
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
            // ID
            // 
            this.ID.FillWeight = 33.34377F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 76.38828F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 122.9931F;
            this.Column1.HeaderText = "Apellido";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 122.9931F;
            this.Column5.HeaderText = "DNI";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 122.9931F;
            this.Column2.HeaderText = "Teléfono";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 122.9931F;
            this.Column3.HeaderText = "Hora de Ingreso";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 122.9931F;
            this.Column4.HeaderText = "Hora de Salida";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // activar
            // 
            this.activar.FillWeight = 57.09146F;
            this.activar.HeaderText = "Activar";
            this.activar.Image = global::TheCoffe.Properties.Resources.activar;
            this.activar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.activar.Name = "activar";
            this.activar.ReadOnly = true;
            this.activar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.activar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // RemovedWaiterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1030, 600);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn activar;
    }
}