using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffe.App;
using TheCoffe.CAccesoADatos;
using TheCoffe.CDatos;
using TheCoffe.CNegocio;

namespace TheCoffe.CPresentacion.Cajero
{
    public partial class AddClientForm : Form
    {
        private bool isShowingMsgBox = false;
        public AddClientForm()
        {
            InitializeComponent();
        }

        Cliente cliente = new Cliente();
        ClienteDAL clienteDAL = new ClienteDAL();

        private void CargarDatos()
        {
            cliente.nombre = txtName.Texts;
            cliente.apellido = txtLastName.Texts;
            cliente.cuit =  int.Parse(txtCuit.Texts);
            cliente.domicilio = txtAdress.Texts;
            cliente.localidad = txtLocality.Texts;
            cliente.provincia = txtProvince.Texts;
            cliente.email = txtEmail.Texts;
            cliente.telefono = int.Parse(txtPhone.Texts);
        }

        private void AddClientForm_Load(object sender, EventArgs e)
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

        private void AddClientForm_Deactivate(object sender, EventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Texts) || string.IsNullOrWhiteSpace(txtLastName.Texts) || string.IsNullOrWhiteSpace(txtCuit.Texts) || string.IsNullOrWhiteSpace(txtAdress.Texts) || string.IsNullOrWhiteSpace(txtLocality.Texts) || string.IsNullOrWhiteSpace(txtProvince.Texts) || string.IsNullOrWhiteSpace(txtEmail.Texts) || string.IsNullOrWhiteSpace(txtPhone.Texts))
            {
                isShowingMsgBox = true;
                MessageBox.Show("Debe Completar todos los campos",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                isShowingMsgBox = false;
                return;
            }
            if (IsValidEmail(txtEmail.Texts))
            {
                CargarDatos();
                clienteDAL.Create(cliente);
                new AlertBox(this.Owner as Form, Color.LightGreen, Color.SeaGreen, "Proceso Finalizado", "Cliente Agregado Exitosamente", Properties.Resources.informacion);
            }
            else
            {
                isShowingMsgBox = true;
                MessageBox.Show("Ingresa un Email Valido",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                isShowingMsgBox = false;
                return;
            }
        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
    }
}
