using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffe.CDatos;
using TheCoffe.CNegocio;
using TheCoffe.CNegocio.Services;

namespace TheCoffe.CPresentacion
{
    public partial class RemovedUsersForm : Form
    {
        private UserService _userService = new UserService();
        private bool isShowingMsgBox = false;
        private Paginator<Usuario>  paginator;
        public RemovedUsersForm()
        {
            InitializeComponent();
            dataUsersRemoved.AutoGenerateColumns = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public async void RefreshPantalla()
        {
            var usuarios = await _userService.ObtenerUsuariosEliminados();
            paginator = new Paginator<Usuario>(usuarios, 9);
            CargarDatos(paginator);
        }
        private void RemovedUsersForm_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            Timer timer = new Timer();
            timer.Interval = 8;
            timer.Tick += (s, ev) =>
            {
                if (this.Opacity < 1)
                    this.Opacity += 0.10;
                else
                    timer.Stop();
            };
            timer.Start();
            RefreshPantalla();
        }

        private void RemovedUsersForm_Deactivate(object sender, EventArgs e)
        {
            if (!this.isShowingMsgBox){
                this.Close();
            }
        }

        private void dataUsersRemoved_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataUsersRemoved.Columns[e.ColumnIndex].Name == "activar")
            {
                isShowingMsgBox = true;
                if (MessageBox.Show("¿Está seguro que desea activar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataUsersRemoved.CurrentRow.Cells[0].Value.ToString());
                    _userService.CambiarEstado(id);
                }
                isShowingMsgBox = false;
                RefreshPantalla();
            }         
        }

        public void CargarDatos(Paginator<Usuario> usuarios)
        {
            dataUsersRemoved.DataSource = null;
            dataUsersRemoved.DataSource = usuarios.GetPageData();
            ActualizarPaginacion(usuarios);
        }
        private void ActualizarPaginacion(Paginator<Usuario> usuario)
        {
            lblPagina.Text = $"Página {usuario.CurrentPage} de {usuario.TotalPages}";
            btnAnt.Enabled = usuario.CurrentPage > 1;
            btnSig.Enabled = usuario.CurrentPage < usuario.TotalPages;
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            paginator.NextPage();
            CargarDatos(paginator);
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            paginator.PreviousPage();
            CargarDatos(paginator);
        }
    }
}
