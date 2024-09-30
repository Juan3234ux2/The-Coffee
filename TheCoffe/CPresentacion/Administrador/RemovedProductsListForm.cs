using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoffe.App;
using System.Windows.Forms;

namespace TheCoffe.CPresentacion
{
    public partial class RemovedProductsListForm : Form
    {
        private bool isShowingMsgBox = false;
        public RemovedProductsListForm()
        {
            InitializeComponent();
        }

        private void RemovedProductsListForm_Load(object sender, EventArgs e)
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
            for (int i = 0; i < 4; i++)
            {
                int rowIndex = dataRemovedProducts.Rows.Add();
                DataGridViewRow row = dataRemovedProducts.Rows[rowIndex];
                row.Cells[0].Value = 1;
                row.Cells[1].Value = "Torta Tofi";
                row.Cells[2].Value = 5000;
                row.Cells[3].Value = "Pasteleria";
            }
        }

        private void dataRemovedProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataRemovedProducts.Columns[e.ColumnIndex].Name == "activar")
            {
                    isShowingMsgBox = true;
                    if (MessageBox.Show("¿Está seguro que desea activar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dataRemovedProducts.Rows.RemoveAt(e.RowIndex);
                    }
                    isShowingMsgBox = false;
            }
        }

        private void RemovedProductsListForm_Deactivate(object sender, EventArgs e)
        {
            if (!isShowingMsgBox)
            {
                this.Close();
            }
        }
    }
}
