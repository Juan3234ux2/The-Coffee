using AltoControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffe.CDatos;
using TheCoffe.CNegocio;
using TheCoffe.CNegocio.Services;
using TheCoffe.CPresentacion.Gerente;

namespace TheCoffe
{
    public partial class LoginForm : Form
    {
        private WaiterService _waiterService = new WaiterService();
        public LoginForm()
        {
            InitializeComponent();
            precargarDatos();
        }
        private async void precargarDatos()
        {
            var Lst = await _waiterService.ObtenerMeserosActivos();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtUser.Texts) || string.IsNullOrWhiteSpace(txtPassword.Texts))
            {
                MessageBox.Show("Debe Completar todos los campos",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            else
            {
                AuthService authService = new AuthService();
                try
                {
                    var usuario = authService.Login(txtUser.Texts, txtPassword.Texts);
                    AuthUser.Usuario = usuario;
                    Form mainForm = null;
                    switch (AuthUser.Usuario.id_rol)
                    {
                        case 1:
                            mainForm = new MainForm();
                            break;
                        case 2:
                            mainForm = new MainFormManager();
                            break;
                        case 3:
                            mainForm = new MainFormCashier();
                            break;
                    }                    
                    mainForm.FormClosed += (s, args) => {
                        AuthUser.Usuario = null;
                        this.Show();
                    };
                    mainForm.Show();
                    txtUser.Texts = "";
                    txtPassword.Texts = "";
                    this.Hide();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            Timer timer = new Timer();
            timer.Interval = 10;
            timer.Tick += (s, ev) =>
            {
                if (this.Opacity < 1)
                    this.Opacity += 0.15;
                else
                    timer.Stop();
            };
            timer.Start();
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

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidator.ValidateInput(e, InputValidator.InputType.Credentials);
        }
    }
}
