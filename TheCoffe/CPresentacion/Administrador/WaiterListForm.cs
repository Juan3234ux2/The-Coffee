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

namespace TheCoffe.App
{
    public partial class WaiterListForm : UserControl
    {
        public WaiterListForm()
        {
            InitializeComponent();
        }

        private void WaiterListForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                int rowIndex = dataWaiter.Rows.Add();
                DataGridViewRow row = dataWaiter.Rows[rowIndex];
                row.Cells[0].Value = 1;
                row.Cells[1].Value = "Emilia";
                row.Cells[2].Value = "Espinola";
                row.Cells[3].Value = "45939582";
                row.Cells[4].Value = "54-379 4997735";
                row.Cells[5].Value = "08:00";
                row.Cells[6].Value = "12:00";
            }
        }

        private void btnAddWaiter_Click(object sender, EventArgs e)
        {
            using (OverlayForm overlay = new OverlayForm())
            {
                overlay.Show();
                using (AddWaiterForm modal = new AddWaiterForm())
                {
                    modal.ShowDialog(overlay);
                }
                overlay.Close();
            }
        }
        
        private void dataWaiter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataWaiter.Columns[e.ColumnIndex].Name == "editar")
            {
                using (OverlayForm overlay = new OverlayForm())
                {
                    overlay.Show();
                    using (AddWaiterForm modal = new AddWaiterForm("Emilia", "Espinola", "54 - 379 4997735", "45939582", "08:00", "12:00"))
                    {
                        modal.ShowDialog(overlay);
                    }
                    overlay.Close();
                }
            }
            else if (dataWaiter.Columns[e.ColumnIndex].Name == "eliminar")
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dataWaiter.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void btnRemovedWaiter_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            using (OverlayForm overlay = new OverlayForm())
            {
                overlay.Size = parentForm.ClientSize;
                overlay.Location = parentForm.PointToScreen(Point.Empty);
                overlay.Owner = parentForm;

                overlay.Show();
                using (RemovedWaiterForm waiterRemoved = new RemovedWaiterForm())
                {
                    waiterRemoved.ShowDialog(overlay);
                }
                overlay.Close();
            }
        }
    }
}
