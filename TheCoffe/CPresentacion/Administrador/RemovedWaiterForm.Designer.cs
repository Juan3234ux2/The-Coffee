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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dataRemovedWaiter = new System.Windows.Forms.DataGridView();
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
            this.dataRemovedWaiter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dataRemovedWaiter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataRemovedWaiter.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataRemovedWaiter.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Medium", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(75)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataRemovedWaiter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataRemovedWaiter.ColumnHeadersHeight = 45;
            this.dataRemovedWaiter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataRemovedWaiter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.activar});
            this.dataRemovedWaiter.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataRemovedWaiter.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataRemovedWaiter.EnableHeadersVisualStyles = false;
            this.dataRemovedWaiter.GridColor = System.Drawing.Color.Silver;
            this.dataRemovedWaiter.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataRemovedWaiter.Location = new System.Drawing.Point(24, 73);
            this.dataRemovedWaiter.MultiSelect = false;
            this.dataRemovedWaiter.Name = "dataRemovedWaiter";
            this.dataRemovedWaiter.ReadOnly = true;
            this.dataRemovedWaiter.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataRemovedWaiter.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataRemovedWaiter.RowHeadersVisible = false;
            this.dataRemovedWaiter.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataRemovedWaiter.RowsDefaultCellStyle = dataGridViewCellStyle4;
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
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
        private System.Windows.Forms.DataGridViewImageColumn activar;
    }
}