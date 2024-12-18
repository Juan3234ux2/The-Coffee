﻿using System;
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
using TheCoffe.CNegocio.Services;

namespace TheCoffe.CPresentacion.Cajero
{
    public partial class AddClientForm : Form
    {
        private Cliente cliente = new Cliente();
        private CustomerService customerService = new CustomerService();
        private bool isShowingMsgBox = false;
        public AddClientForm()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            cliente.nombre = txtName.Texts;
            cliente.apellido = txtLastName.Texts;
            cliente.cuit = txtCuit.Texts;
            cliente.domicilio = txtAdress.Texts;
            cliente.localidad = txtLocality.Texts;
            cliente.provincia = txtProvince.Texts;
            cliente.email = txtEmail.Texts;
            cliente.telefono = txtPhone.Texts;
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
                try
                {
                    CargarDatos();
                    customerService.CrearCliente(cliente);
                    new AlertBox(this.Owner as Form, Color.LightGreen, Color.SeaGreen, "Proceso Finalizado", "Cliente Agregado Exitosamente", Properties.Resources.informacion);
                }
                catch (Exception ex)
                {
                    this.isShowingMsgBox = true;
                    MessageBox.Show(ex.Message, "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.isShowingMsgBox = false;
                }
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

        private void txtCuit__TextChanged(object sender, EventArgs e)
        {
            if (txtCuit.Texts.Length > 11)
            {
                txtCuit.Texts = txtCuit.Texts.Substring(0, 11);
            }
        }

        private void txtPhone__TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Texts.Length > 12)
            {
                txtPhone.Texts = txtPhone.Texts.Substring(0, 12);
            }
        }
    }
}
