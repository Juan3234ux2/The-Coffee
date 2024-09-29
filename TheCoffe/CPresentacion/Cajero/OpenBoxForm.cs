using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffe.CNegocio;

namespace TheCoffe.CPresentacion.Cajero
{
    public partial class OpenBoxForm : Form
    {
        private bool isShowingMsgBox = false;
        public OpenBoxForm()
        {
            InitializeComponent();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidator.ValidateInput(e, InputValidator.InputType.Digits);
        }

        private void btnOpenBox_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAmount.Texts)) { 
                isShowingMsgBox = true;
                MessageBox.Show("Debe Completar el campo",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                isShowingMsgBox = false;
                return;
            }
            else
            {
                this.Close();
            }
        }

        private void OpenBoxForm_Load(object sender, EventArgs e)
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
    }
}
