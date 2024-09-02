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
    public partial class AddTableForm : Form{
        public AddTableForm()
        {
            InitializeComponent();
        }

        private void txtName__TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNroMesa.Text) || string.IsNullOrWhiteSpace(txtCantSillas.Text))
            {
                MessageBox.Show("Debe Completar todos los campos",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddTableForm_Load(object sender, EventArgs e)
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
        }

        private void AddTableForm_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
