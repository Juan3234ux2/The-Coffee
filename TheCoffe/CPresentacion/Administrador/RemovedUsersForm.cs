using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffe.CNegocio.Services;

namespace TheCoffe.CPresentacion
{
    public partial class RemovedUsersForm : Form
    {
        private UserService _userService = new UserService();
        private bool isShowingMsgBox = false;
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
            dataUsersRemoved.DataSource = usuarios;
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
    }
}
