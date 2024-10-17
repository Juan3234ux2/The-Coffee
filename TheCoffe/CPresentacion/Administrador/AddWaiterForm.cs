using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffe.CAccesoADatos;
using TheCoffe.CDatos;
using TheCoffe.CNegocio;

namespace TheCoffe.App
{
    public partial class AddWaiterForm : Form
    {
        private bool isShowingMsgBox = false;
        private int idMesero = 0;

        public AddWaiterForm()
        {
            InitializeComponent();
        }

        MeseroDAL meseroDAL = new MeseroDAL();
        Mesero mesero = null;

        public AddWaiterForm(int id)
        {
            InitializeComponent();
            lblAddWaiter.Text = "Editar Mesero";
            btnAddWaiter.Text = "Editar";
            this.idMesero = id;
            mesero = meseroDAL.SearchObject(id);
            txtName.Texts = mesero.nombre;
            txtLastName.Texts = mesero.apellido;
            txtDNI.Texts = Convert.ToString(mesero.dni);
            txtNumber.Texts = Convert.ToString(mesero.telefono);
            txtExit.Texts = Convert.ToString(mesero.hora_salida);
            txtIncome.Texts = Convert.ToString(mesero.hora_entrada);
        }

        private void CargarDatos()
        {
            mesero.nombre = txtName.Texts;
            mesero.apellido = txtLastName.Texts;
            mesero.dni = int.Parse(txtDNI.Texts); 
            mesero.telefono = Convert.ToInt32(txtNumber.Texts);
            mesero.hora_salida = Convert.ToInt32(txtExit.Texts);
            mesero.hora_entrada= Convert.ToInt32(txtIncome.Texts);
        }

        private void btnAddWaiter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Texts) || string.IsNullOrWhiteSpace(txtLastName.Texts) || string.IsNullOrWhiteSpace(txtDNI.Texts) ||
                string.IsNullOrWhiteSpace(txtNumber.Texts) || string.IsNullOrWhiteSpace(txtIncome.Texts) || string.IsNullOrWhiteSpace(txtExit.Texts))
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
                if(this.idMesero == 0)
                {
                    mesero = new Mesero();
                    CargarDatos();
                    meseroDAL.Create(mesero);
                    new AlertBox(this.Owner as Form, Color.LightGreen, Color.SeaGreen, "Proceso completado", "Mesero agregado correctamente", Properties.Resources.informacion);
                }
                else
                {
                    CargarDatos();
                    meseroDAL.Update(mesero);
                    new AlertBox(this.Owner as Form, Color.LightGreen, Color.SeaGreen, "Proceso completado", "Mesero editado correctamente", Properties.Resources.informacion);
                }
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtDNI__TextChanged(object sender, EventArgs e)
        {
            if (txtDNI.Texts.Length > 8)
            {
                txtDNI.Texts = txtDNI.Texts.Substring(0,8);
            }
        }
    }
}
