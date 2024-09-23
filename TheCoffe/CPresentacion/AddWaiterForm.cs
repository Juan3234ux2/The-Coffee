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

namespace TheCoffe.App
{
    public partial class AddWaiterForm : Form
    {
        private bool isShowingMsgBox = false;

        public AddWaiterForm()
        {
            InitializeComponent();
        }

        public AddWaiterForm(String name, String lastName, String number, String dni, String income, String exit)
        {
            InitializeComponent();
            lblAddWaiter.Text = "Editar Mesero";
            btnAddWaiter.Text = "Editar";
            txtName.Texts = name;
            txtLastName.Texts = lastName;
            txtDNI.Texts = dni;
            txtNumber.Texts = number;
            txtIncome.Texts = income;
            txtExit.Texts = exit;
        }

        private void btnAddWaiter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Texts) || string.IsNullOrWhiteSpace(txtLastName.Texts) || string.IsNullOrWhiteSpace(txtDNI.Texts) || string.IsNullOrWhiteSpace(txtNumber.Texts) || string.IsNullOrWhiteSpace(txtIncome.Texts) || string.IsNullOrWhiteSpace(txtExit.Texts))
            {
                isShowingMsgBox = true;
                MessageBox.Show("Debe Completar todos los campos",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                isShowingMsgBox = false;
                return;
            }
            else
            {
                new AlertBox(this.Owner as Form, Color.LightGreen, Color.SeaGreen, "Proceso completado", "Mesero agregado correctamente", Properties.Resources.informacion);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddWaiterForm_Load(object sender, EventArgs e)
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

        private void AddWaiterForm_Deactivate(object sender, EventArgs e)
        {
            if (!isShowingMsgBox)
            {
                this.Close();
            }
        }
        private void validateLetters_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidator.ValidateInput(e, InputValidator.InputType.Letters);
        }
        private void validateDigits_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidator.ValidateInput(e, InputValidator.InputType.Digits);
        }
    }
}
