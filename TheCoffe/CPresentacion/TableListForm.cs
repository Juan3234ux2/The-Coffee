using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheCoffe.App
{
    public partial class TableListForm : UserControl
    {
        public TableListForm()
        {
            InitializeComponent();
        }

        private void TableListForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                int rowIndex = dataTable.Rows.Add();
                DataGridViewRow row = dataTable.Rows[rowIndex];
                row.Cells[0].Value = 1;
                row.Cells[1].Value = 2;
                row.Cells[2].Value = 4;
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
                using (AddTableForm modal = new AddTableForm())
                {
                    modal.ShowDialog(overlay);
                }
                overlay.Close();
            }
        }
    }
}
