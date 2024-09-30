using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffe.CNegocio;

namespace TheCoffe.CPresentacion
{
    public partial class ProfileForm : UserControl
    {
        public ProfileForm()
        {
            InitializeComponent();
            cboRol.SelectedIndex = 1;
        }
        private void btnWatchPassword_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = !txtPassword.PasswordChar;
            if (txtPassword.PasswordChar)
            {
                btnWatchPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
            else
            {
                btnWatchPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
        }
        private void validateLetters_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidator.ValidateInput(e, InputValidator.InputType.Letters);
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidator.ValidateInput(e, InputValidator.InputType.Digits);
        }

        private void btnRol_Click(object sender, EventArgs e)
        {
            cboRol.DroppedDown = !cboRol.DroppedDown;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que deseas cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form parent = this.FindForm();
                parent.Close();
            }
        }
    }
}
