﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffe.CNegocio;

namespace TheCoffe.App
{
    public partial class AddUserForm : Form
    {
        private bool isShowingMsgBox = false;
        private int idUsuario = 0;
        public AddUserForm()
        {
            InitializeComponent();
        }

        public AddUserForm(String name, String lastName, String number, String user, String pass)
        {
            InitializeComponent();
            lblAddUser.Text = "Editar Usuario";
            btnAdd.Text = "Editar";
            txtLastName.Texts = lastName;
            txtName.Texts = name;
            txtNumber.Texts = number;
            txtUser.Texts = user;
            txtPassword.Texts = pass;
            cboRol.SelectedIndex = 0;
            txtPassword.Enabled = false;
            btnWatchPassword.Visible = false;
            this.idUsuario = 10;
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
            }
            else
            {
                if (this.idUsuario == 0)
                {
                    new AlertBox(this.Owner as Form, Color.LightGreen, Color.SeaGreen, "Proceso completado", "Usuario agregado correctamente", Properties.Resources.informacion);
                }
                else
                {
                    new AlertBox(this.Owner as Form, Color.LightGreen, Color.SeaGreen, "Proceso completado", "Usuario editado correctamente", Properties.Resources.informacion);
                }
            }
        }

        private void btnSelectAvatar_Click(object sender, EventArgs e)
        {
            selectImageDialog.Filter = "Imagenes (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            isShowingMsgBox = true;
            if (selectImageDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = selectImageDialog.FileName;
                string fileName = Path.GetFileName(selectedFilePath);
                string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string resourcesFolderPath = Path.Combine(projectDirectory, "Resources");
                string imagesFolderPath = Path.Combine(resourcesFolderPath, "Users");
                if (!Directory.Exists(imagesFolderPath))
                {
                    Directory.CreateDirectory(imagesFolderPath);
                }
                string destinationFilePath = Path.Combine(imagesFolderPath, fileName);
                try
                {
                    File.Copy(selectedFilePath, destinationFilePath, true);
                    pboAvatar.Image = Image.FromFile(destinationFilePath);
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
