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
using TheCoffe.CNegocio.Services;

namespace TheCoffe.App
{
    public partial class AddWaiterForm : Form
    {
        private bool isShowingMsgBox = false;
        private WaiterService _waiterService = new WaiterService();
        private Mesero mesero = null;
        private int idMesero = 0;

        public AddWaiterForm()
        {
            InitializeComponent();
        }


        public AddWaiterForm(int id)
        {
            InitializeComponent();
            lblAddWaiter.Text = "Editar Mesero";
            btnAddWaiter.Text = "Editar";
            this.idMesero = id;
            mesero = _waiterService.ObtenerMeseroPorID(id);
            txtName.Texts = mesero.nombre;
            txtLastName.Texts = mesero.apellido;
            txtDNI.Texts = Convert.ToString(mesero.dni);
            txtNumber.Texts = Convert.ToString(mesero.telefono);
            txtExit.Texts = Convert.ToString(mesero.hora_salida);
            txtIncome.Texts = Convert.ToString(mesero.hora_entrada);
            CargarDias();
        }
        private void CargarDias()
        {
            var dias = _waiterService.ObtenerMeseroPorID(idMesero).DiaDeTrabajo;
            foreach (Control control in pnlChecks.Controls)
            {
                if (control is CheckBox check)
                {
                    check.Checked = dias.Any(d => d.id_dia == Convert.ToInt32(check.Tag)); 
                }
            }
        }
        private void CargarDatos()
        {
            mesero.nombre = txtName.Texts;
            mesero.apellido = txtLastName.Texts;
            mesero.dni = int.Parse(txtDNI.Texts); 
            mesero.telefono = txtNumber.Texts;
            mesero.hora_salida = Convert.ToInt32(txtExit.Texts);
            mesero.hora_entrada= Convert.ToInt32(txtIncome.Texts);
            mesero.estado = true;
        }
        private List<int> ObtenerDiasSeleccionados()
        {
            var diasSeleccionados = new List<int>();
            if (chkLun.Checked) diasSeleccionados.Add(1);
            if (chkMar.Checked) diasSeleccionados.Add(2);
            if (chkMie.Checked) diasSeleccionados.Add(3);
            if (chkJue.Checked) diasSeleccionados.Add(4);
            if (chkVie.Checked) diasSeleccionados.Add(5);
            if (chkSab.Checked) diasSeleccionados.Add(6);
            if (chkDom.Checked) diasSeleccionados.Add(7);
            return diasSeleccionados;
        }
        private void btnAddWaiter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Texts) || string.IsNullOrWhiteSpace(txtLastName.Texts) || string.IsNullOrWhiteSpace(txtDNI.Texts) ||
                string.IsNullOrWhiteSpace(txtNumber.Texts) || string.IsNullOrWhiteSpace(txtIncome.Texts) || string.IsNullOrWhiteSpace(txtExit.Texts) || ObtenerDiasSeleccionados().Count < 1 )
            {
                isShowingMsgBox = true;
                MessageBox.Show("Debe Completar todos los campos",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                isShowingMsgBox = false;
                return;
            }else if (validarHorarios())
            {
                if(this.idMesero == 0)
                {
                    AddWaiter();
                }
                else
                {
                    EditWaiter();
                }
            }
        }
        private void EditWaiter()
        {
            try
            {
                CargarDatos();
                _waiterService.ActualizarMesero(mesero, ObtenerDiasSeleccionados());
                new AlertBox(this.Owner as Form, Color.LightGreen, Color.SeaGreen, "Proceso completado", "Mesero editado correctamente", Properties.Resources.informacion);
            }
            catch (Exception ex)
            {
                this.isShowingMsgBox = true;
                MessageBox.Show(ex.Message, "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.isShowingMsgBox = false;
            }
        }
        private void AddWaiter()
        {
            try
            {
                mesero = new Mesero();
                CargarDatos();
                _waiterService.CrearMesero(mesero, ObtenerDiasSeleccionados());
                new AlertBox(this.Owner as Form, Color.LightGreen, Color.SeaGreen, "Proceso completado", "Mesero agregado correctamente", Properties.Resources.informacion);
            }
            catch (Exception ex)
            {
                this.isShowingMsgBox = true;
                MessageBox.Show(ex.Message, "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.isShowingMsgBox = false;
            }
        }
        private bool validarHorarios()
        {
            int horaEntrada = Convert.ToInt32(txtIncome.Texts);
            int horaSalida = Convert.ToInt32(txtExit.Texts);
            if(horaEntrada > 24 || horaEntrada < 1 || horaSalida > 24 || horaSalida < 1)
            {
                isShowingMsgBox = true;
                MessageBox.Show("Los horarios deben estar entre las 1 y las 24hs",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                isShowingMsgBox = false;
                return false;
            }
            else if(horaSalida - horaEntrada > 8)
            {
                isShowingMsgBox = true;
                MessageBox.Show("La diferencia entre el horario de salida y el de entrada tiene que ser como maximo 8 horas",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                isShowingMsgBox = false;
                return false;
            }
            else if (horaEntrada > horaSalida)
            {
                isShowingMsgBox = true;
                MessageBox.Show("El horario de entrada debe ser inferior al de salida",
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

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAll.Checked)
            {
                foreach (Control control in pnlChecks.Controls)
                {
                    if (control is CheckBox check)
                    {
                        check.Checked = true;
                    }
                }
            }
            else
            {
                foreach (Control control in pnlChecks.Controls)
                {
                    if (control is CheckBox check)
                    {
                        check.Checked = false;
                    }
                }
            }
        }
    }
}
