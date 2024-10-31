using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffe.CAccesoADatos;
using TheCoffe.CDatos;
using TheCoffe.CNegocio;
using TheCoffe.CNegocio.Services;

namespace TheCoffe.App
{
    public partial class AddUserForm : Form
    {
        private bool isShowingMsgBox = false;
        private int idUsuario = 0;
        private readonly UserService _userService = new UserService();
        private Usuario usuario = new Usuario();
        public AddUserForm()
        {
            InitializeComponent();
        }

        public AddUserForm(int id)
        {
            InitializeComponent();
            lblAddUser.Text = "Editar Usuario";
            btnAdd.Text = "Editar";
            this.idUsuario = id;
            usuario = _userService.ObtenerUsuarioPorID(id);
            pboAvatar.Image = Image.FromFile(_userService.ObtenerImagen(usuario));
            txtName.Texts = usuario.nombre;
            txtLastName.Texts = usuario.apellido;
            txtNumber.Texts = usuario.telefono;
            txtUser.Texts = usuario.usuario1;
            txtPassword.Texts = usuario.contraseña;
        }

        private void CargarDatos()
        {
            usuario.nombre = txtName.Texts;
            usuario.apellido = txtLastName.Texts;
            usuario.telefono = txtNumber.Texts;
            usuario.usuario1 = txtUser.Texts;
            usuario.contraseña = txtPassword.Texts;
            usuario.id_rol = Convert.ToInt32(cboRol.SelectedValue);
            usuario.estado = true;
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

        private void AddUserForm_Load(object sender, EventArgs e)
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
            CargarRoles();
        }


        public async void CargarRoles()
        {
            var listRoles = await _userService.ObtenerRoles();
            cboRol.DataSource = listRoles;
            cboRol.DisplayMember = "descripcion";
            cboRol.ValueMember = "id_rol";
            if (idUsuario != 0)
            {
                CargarRolesActual();
            }
        }

        public async void CargarRolesActual()
        {
            var listRoles = await _userService.ObtenerRoles();

            int index = 0;
            for (int i = 0; i < listRoles.Count(); i++)
            {
                if (listRoles[i].id_rol == usuario.id_rol)
                {
                    index = i;
                    break;
                }
            }
            cboRol.SelectedIndex = index;
        }

        private void AddUserForm_Deactivate(object sender, EventArgs e)
        {
            if (!isShowingMsgBox)
            {
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRol_Click(object sender, EventArgs e)
        {
            cboRol.DroppedDown = !cboRol.DroppedDown;
        }
        private void validateLetters_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidator.ValidateInput(e, InputValidator.InputType.Letters);
        }
        private void validateCredendials_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidator.ValidateInput(e, InputValidator.InputType.Credentials);
        }
        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidator.ValidateInput(e, InputValidator.InputType.Digits);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Texts) || string.IsNullOrWhiteSpace(txtLastName.Texts) || string.IsNullOrWhiteSpace(txtUser.Texts) || string.IsNullOrWhiteSpace(txtPassword.Texts) || string.IsNullOrWhiteSpace(txtNumber.Texts) || cboRol.SelectedIndex == -1)
            {
                isShowingMsgBox = true;
                MessageBox.Show("Debe Completar todos los campos",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                isShowingMsgBox = false;
                return;
            }else if(validarContraseña()){
                if (this.idUsuario == 0)
                {
                    AddUser();
                }
                else
                {
                    EditUser();
                }

            }
        }

        private void EditUser()
        {
            try
            {
                CargarDatos();
                _userService.ActualizarUsuario(usuario);
                new AlertBox(this.Owner as Form, Color.LightGreen, Color.SeaGreen, "Proceso completado", "Usuario editado correctamente", Properties.Resources.informacion);            
            }
            catch (Exception ex)
            {
                isShowingMsgBox = true;
                MessageBox.Show(ex.Message, "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isShowingMsgBox = false;
            }
        }
        private void AddUser()
        {
            try
            {
                CargarDatos();
                _userService.CrearUsuario(usuario);
                new AlertBox(this.Owner as Form, Color.LightGreen, Color.SeaGreen, "Proceso completado", "Usuario agregado correctamente", Properties.Resources.informacion);
            }catch(Exception ex)
            {
                isShowingMsgBox = true;
                MessageBox.Show(ex.Message, "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isShowingMsgBox = false;
            }
        }
        private bool validarContraseña()
        {
            string contraseña = txtPassword.Texts;
            if (contraseña.Length < 6)
            {
                isShowingMsgBox = true;
                MessageBox.Show("El contraseña debe ser minimo de 6 caracteres",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                isShowingMsgBox = false;
                return false;
            }
            
            else if (contraseña.Length > 20)
            {
                isShowingMsgBox = true; 
                MessageBox.Show("El contraseña debe ser maximo de 20 caracteres",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                isShowingMsgBox = false;
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnSelectAvatar_Click(object sender, EventArgs e)
        {
            selectImageDialog.Filter = "Imagenes (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            isShowingMsgBox = true;
            if (selectImageDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = selectImageDialog.FileName;
                string extension = Path.GetExtension(selectedFilePath);
                string fileName = Guid.NewGuid().ToString() + extension;
                string parentRoot = Directory.GetParent(Application.StartupPath).Parent.FullName;
                string imagesFolderPath = Path.Combine(parentRoot, "Uploads", "Users");
                if (!Directory.Exists(imagesFolderPath))
                {
                    Directory.CreateDirectory(imagesFolderPath);
                }
                string destinationFilePath = Path.Combine(imagesFolderPath, fileName);
                try
                {
                    File.Copy(selectedFilePath, destinationFilePath, true);
                    pboAvatar.Image = Image.FromFile(destinationFilePath);
                    usuario.avatar = fileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al copiar la imagen: {ex.Message}");
                }
            }
            isShowingMsgBox = false;
        }
    }
}
