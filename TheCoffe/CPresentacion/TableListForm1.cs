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
    public partial class TableList : UserControl
    {
        public TableList()
        {
            InitializeComponent();
        }

        private void TableList_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                int rowIndex = dataTable.Rows.Add();
                DataGridViewRow row = dataTable.Rows[rowIndex];
                row.Cells[0].Value = 1;
                row.Cells[1].Value = "3";
                row.Cells[2].Value = "4";
            }
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            using (OverlayForm overlay = new OverlayForm())
            {
                overlay.Size = parentForm.ClientSize;
                overlay.Location = parentForm.PointToScreen(Point.Empty);
                overlay.Owner = parentForm;

                overlay.Show();
                using (AddTableForm1 modal = new AddTableForm1())
                {
                    modal.ShowDialog(overlay);
                }
                overlay.Close();
            }
        }

        private void dataCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataTable.Columns[e.ColumnIndex].Name == "editar")
            {
                Form parentForm = this.FindForm();
                using (OverlayForm overlay = new OverlayForm())
                {
                    overlay.Size = parentForm.ClientSize;
                    overlay.Location = parentForm.PointToScreen(Point.Empty);
                    overlay.Owner = parentForm;

                    overlay.Show();
                    using (AddTableForm1 modal = new AddTableForm1("3","4"))
                    {
                        modal.ShowDialog(overlay);
                    }
                    overlay.Close();
                }
            }
            else if (dataTable.Columns[e.ColumnIndex].Name == "eliminar")
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dataTable.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void btnRemovedTables_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            using (OverlayForm overlay = new OverlayForm())
            {
                overlay.Size = parentForm.ClientSize;
                overlay.Location = parentForm.PointToScreen(Point.Empty);
                overlay.Owner = parentForm;

                overlay.Show();
                using (RemovedTablesForm tablesRemoved = new RemovedTablesForm())
                {
                    tablesRemoved.ShowDialog(overlay);
                }
                overlay.Close();
            }
        }
    }
}
