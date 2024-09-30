using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffe.App;

namespace TheCoffe.CPresentacion
{
    public partial class RemovedWaiterForm : Form
    {
        private bool isShowingMsgBox = false;
        public RemovedWaiterForm()
        {
            InitializeComponent();
        }

        private void RemovedWaiterForm_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            Timer timer = new Timer();
            timer.Interval = 10;
            timer.Tick += (s, ev) =>
            {
                if (this.Opacity < 1)
                    this.Opacity += 0.10;
                else
                    timer.Stop();
            };
            timer.Start();
            for (int i = 0; i < 3; i++)
            {
                int rowIndex = dataRemovedWaiter.Rows.Add();
                DataGridViewRow row = dataRemovedWaiter.Rows[rowIndex];
                row.Cells[0].Value = 1;
                row.Cells[1].Value = "Emilia";
                row.Cells[2].Value = "Espinola";
                row.Cells[3].Value = "45939582";
                row.Cells[4].Value = "54-379 4997735";
                row.Cells[5].Value = "08:00";
                row.Cells[6].Value = "12:00";
            }
        }

        private void dataRemovedWaiter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataRemovedWaiter.Columns[e.ColumnIndex].Name == "activar")
            {
                    isShowingMsgBox = true;
                    if (MessageBox.Show("¿Está seguro que desea activar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dataRemovedWaiter.Rows.RemoveAt(e.RowIndex);
                    }
                    isShowingMsgBox = false;
            }
        }

        private void RemovedWaiterForm_Deactivate(object sender, EventArgs e)
        {
            if (!this.isShowingMsgBox)
            {
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
