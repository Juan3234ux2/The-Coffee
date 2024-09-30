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

namespace TheCoffe.CPresentacion.General
{
    public partial class RemovedCategoriesForm : Form
    {
        private bool isShowingMsgBox = false;
        public RemovedCategoriesForm()
        {
            InitializeComponent();
        }

        private void RemovedCategoriesForm_Load(object sender, EventArgs e)
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
                int rowIndex = dataRemovedCategory.Rows.Add();
                DataGridViewRow row = dataRemovedCategory.Rows[rowIndex];
                row.Cells[0].Value = 1;
                row.Cells[1].Value = "Cafes";
            }
        }

        private void dataCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataRemovedCategory.Columns[e.ColumnIndex].Name == "activar")
            {
                    isShowingMsgBox = true;
                    if (MessageBox.Show("¿Está seguro que desea activar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dataRemovedCategory.Rows.RemoveAt(e.RowIndex);
                    }
                    isShowingMsgBox = false;
            }
        }

        private void RemovedCategoriesForm_Deactivate(object sender, EventArgs e)
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
