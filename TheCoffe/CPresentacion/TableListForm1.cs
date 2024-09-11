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
                int rowIndex = dataCategory.Rows.Add();
                DataGridViewRow row = dataCategory.Rows[rowIndex];
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
    }
}
