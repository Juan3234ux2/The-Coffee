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
using TheCoffe.CNegocio.Services;
using TheCoffe.CNegocio;

namespace TheCoffe.App
{
    public partial class UserListForm : UserControl
    {
        private UserService _userService = new UserService();
        private Usuario usuario = new Usuario();
        private Paginator<Usuario> paginator;
        private int id;
        public UserListForm()
        {
            InitializeComponent();
            dataUsers.AutoGenerateColumns = false;
        }

        public async void RefreshPantalla()
        {
            UserService service = new UserService();
            var usuarios = await service.ObtenerUsuariosActivos();
            paginator = new Paginator<Usuario>(usuarios, 9);
            CargarDatos(paginator);
        }

        private void UserListForm_Load(object sender, EventArgs e)
        {
            RefreshPantalla();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            using (OverlayForm overlay = new OverlayForm())
            {
                overlay.Show();
                using (AddUserForm modal = new AddUserForm())
                {
                    modal.ShowDialog(overlay);
                }
                overlay.Close();
            }
            RefreshPantalla();
        }

        private void dataUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataUsers.CurrentRow.Cells[0].Value.ToString());
            if (dataUsers.Columns[e.ColumnIndex].Name == "editar")
            {

                using (OverlayForm overlay = new OverlayForm())
            {
                overlay.Show();
                using (AddUserForm modal = new AddUserForm(id))
                    {
                        modal.ShowDialog(overlay);
                    }
                    overlay.Close();
                }
            }
            else if (dataUsers.Columns[e.ColumnIndex].Name == "eliminar")
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _userService.CambiarEstado(id);
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
        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Texts != string.Empty)
            {
                var usuarios = _userService.BuscarPorNombre(txtSearch.Texts);
                dataUsers.DataSource = usuarios;
            }
            else
            {
                RefreshPantalla();
            }
        }

        public void CargarDatos(Paginator<Usuario> usuarios)
        {
            dataUsers.DataSource = null;
            dataUsers.DataSource = usuarios.GetPageData();
            ActualizarPaginacion(usuarios);
        }
        private void ActualizarPaginacion(Paginator<Usuario> usuario)
        {
            lblPagina.Text = $"Página {usuario.CurrentPage} de {usuario.TotalPages}";
            btnAnt.Enabled = usuario.CurrentPage > 1;
            btnSig.Enabled = usuario.CurrentPage < usuario.TotalPages;
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            paginator.NextPage();
            CargarDatos(paginator);
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            paginator.PreviousPage();
            CargarDatos(paginator);
        }
    }
}
