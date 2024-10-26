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
using TheCoffe.App;
using TheCoffe.CDatos;
using TheCoffe.CNegocio.Services;
using System.IO;

namespace TheCoffe.CPresentacion
{
    public partial class ProfileForm : UserControl
    {
        private UserService _userService = new UserService();
        private Usuario usuario = new Usuario();
        public event Action UpdatedUser;
        Usuario usuarioActual = AuthUser.Usuario;
        public ProfileForm()
        {
            InitializeComponent();
            RecargarInformacion();
            txtRol.Texts = "Administrador";
            usuario = usuarioActual;
        }
        private void CargarDatos()
        {
            usuario.nombre = txtName.Texts;
            usuario.apellido = txtLastName.Texts;
            usuario.telefono = txtNumber.Texts;
            usuario.usuario1 = txtUser.Texts;
            usuario.contraseña = txtPassword.Texts;
            usuario.estado = true;
        }
        private void RecargarInformacion()
        {
            lblUser.Text = usuarioActual.nombreCompleto;
            txtName.Texts = usuarioActual.nombre;
            txtLastName.Texts = usuarioActual.apellido;
            txtNumber.Texts = usuarioActual.telefono;
            txtUser.Texts = usuarioActual.usuario1;
            txtPassword.Texts = usuarioActual.contraseña;
            pboUser.Image = Image.FromFile(_userService.ObtenerImagen());
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
        private void validateCredendials_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidator.ValidateInput(e, InputValidator.InputType.Credentials);
        }
        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidator.ValidateInput(e, InputValidator.InputType.Digits);
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

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Texts) || string.IsNullOrWhiteSpace(txtLastName.Texts) || string.IsNullOrWhiteSpace(txtUser.Texts) || string.IsNullOrWhiteSpace(txtPassword.Texts) || string.IsNullOrWhiteSpace(txtNumber.Texts))
            {
                MessageBox.Show("Debe Completar todos los campos",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            else
            {
                EditUser();
            }
        }
        private void EditUser()
        {
            try
            {
                CargarDatos();
                _userService.ActualizarUsuario(usuario);
                new AlertBox(null, Color.LightGreen, Color.SeaGreen, "Proceso completado", "Usuario actualizado correctamente", Properties.Resources.informacion);
                RecargarInformacion();
                AuthUser.Usuario = usuario;
                usuarioActual = AuthUser.Usuario;
                UpdatedUser?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEditAvatar_Click(object sender, EventArgs e)
        {
            selectImageDialog.Filter = "Imagenes (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
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
                    pboUser.Image = Image.FromFile(destinationFilePath);
                    usuario.avatar = fileName;
                    EditUser();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al copiar la imagen: {ex.Message}");
                }
            }
        }
    }
}