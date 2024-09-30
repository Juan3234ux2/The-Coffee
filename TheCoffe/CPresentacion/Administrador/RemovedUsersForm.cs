using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheCoffe.CPresentacion
{
    public partial class RemovedUsersForm : Form
    {
        private bool isShowingMsgBox = false;
        public RemovedUsersForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
            for (int i = 0; i < 6; i++)
            {
                int index = dataUsersRemoved.Rows.Add();
                DataGridViewRow row = dataUsersRemoved.Rows[index];
                row.Cells["idUser"].Value = 1;
                row.Cells["Usuario"].Value = "Juan Coronel";
                row.Cells["Telefono"].Value = "3794457533";
                row.Cells["Rol"].Value = "Administrador";
                row.Cells["Creado"].Value = "25 Mar 25";
            }
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
                    dataUsersRemoved.Rows.RemoveAt(e.RowIndex);
                }
                isShowingMsgBox = false;
            }
        }
    }
}
