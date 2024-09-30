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
    public partial class SaleDetailListForm : Form
    {
        private bool isShowingMsgBox = false;
        public SaleDetailListForm()
        {
            InitializeComponent();
        }

        private void SaleDetailListForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                int rowIndex = dataSaleDetail.Rows.Add();
                DataGridViewRow row = dataSaleDetail.Rows[rowIndex];
                row.Cells[0].Value = 1;
                row.Cells[1].Value = "Cafe";
                row.Cells[2].Value = "2";
                row.Cells[3].Value = "3000";
                row.Cells[4].Value = "6000";
            }

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
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaleDetailListForm_Deactivate(object sender, EventArgs e)
        {
            if (!isShowingMsgBox)
            {
                this.Close();
            }
        }
    }
}
