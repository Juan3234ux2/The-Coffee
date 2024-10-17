using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffe.CPresentacion;
using TheCoffe.CPresentacion.Cajero;
using TheCoffe.CAccesoADatos;
using TheCoffe.CDatos;

namespace TheCoffe.App
{
    public partial class UserListForm : UserControl
    {
        public UserListForm()
        {
            InitializeComponent();
        }

        UsuarioDAL usuarioDAL = new UsuarioDAL();
        Usuario usuario = new Usuario();
        private int id;

        public void RefreshPantalla()
        {
            var usuarios = usuarioDAL.Read(false);

            dataUsers.DataSource = usuarios.Select(p =>
            new
            {
                p.id_usuario,
                p.usuario1,
                p.nombre,
                p.apellido,
                p.telefono,  
                c = p.rol_usuario.descripcion
            }).ToList();

            dataUsers.Columns[2].HeaderText = "ID";
            dataUsers.Columns[3].HeaderText = "Usuario";
            dataUsers.Columns[4].HeaderText = "Nombre";
            dataUsers.Columns[5].HeaderText = "Apellido";
            dataUsers.Columns[6].HeaderText = "Telefono";
            dataUsers.Columns[7].HeaderText = "Rol";
            dataUsers.Columns[0].DisplayIndex = dataUsers.Columns.Count - 1;
            dataUsers.Columns[1].DisplayIndex = dataUsers.Columns.Count - 1;
        }

        private void UserListForm_Load(object sender, EventArgs e)
        {
            RefreshPantalla();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            /*using (OverlayForm overlay = new OverlayForm())
            {
                overlay.Show();*/
                using (AddUserForm modal = new AddUserForm())
                {
                    modal.ShowDialog();
                }
                /*overlay.Close();
            }*/
            RefreshPantalla();
        }

        private void dataUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataUsers.Columns[e.ColumnIndex].Name == "editar")
            {
                id = Convert.ToInt32(dataUsers.CurrentRow.Cells[2].Value.ToString());

                /*using (OverlayForm overlay = new OverlayForm())
            {
                overlay.Show();*/
                using (AddUserForm modal = new AddUserForm(id))
                    {
                        modal.ShowDialog();
                    }
                    /*overlay.Close();
                }*/
            }
            else if (dataUsers.Columns[e.ColumnIndex].Name == "eliminar")
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = Convert.ToInt32(dataUsers.CurrentRow.Cells[2].Value.ToString());
                    usuarioDAL.Delete(id);
                }
            }
            RefreshPantalla();
        }

        private void btnRemovedUsers_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            using (OverlayForm overlay = new OverlayForm())
            {
                overlay.Size = parentForm.ClientSize;
                overlay.Location = parentForm.PointToScreen(Point.Empty);
                overlay.Owner = parentForm;

                overlay.Show();
                using (RemovedUsersForm usersRemoved = new RemovedUsersForm())
                {
                    usersRemoved.ShowDialog(overlay);
                }
                overlay.Close();
            }
            RefreshPantalla();
        }
    }
}
