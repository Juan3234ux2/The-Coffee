﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheCoffe.App
{
    public partial class UserListForm : UserControl
    {
        public UserListForm()
        {
            InitializeComponent();
        }

        private void UserListForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                int index = dataUsers.Rows.Add();
                DataGridViewRow row = dataUsers.Rows[index];
                row.Cells["Usuario"].Value = "Juan Coronel";
                row.Cells["Telefono"].Value = "3794457533";
                row.Cells["Rol"].Value = "Administrador";
                row.Cells["Creado"].Value = "25 Mar 25";
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            using (OverlayForm overlay = new OverlayForm())
            {
                overlay.Size = parentForm.ClientSize;
                overlay.Location = parentForm.PointToScreen(Point.Empty);
                overlay.Owner = parentForm;

                overlay.Show();
                using (AddUserForm modal = new AddUserForm())
                {
                    modal.ShowDialog(overlay);
                }
                overlay.Close();
            }
        }
    }
}
