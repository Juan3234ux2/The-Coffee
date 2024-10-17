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
    public partial class AddTableForm1 : Form
    {
        private bool isShowingMsgBox = false;
        private int idMesa = 0;
        public AddTableForm1()
        {
            InitializeComponent();
        }
        Mesa mesa = null;
        MesaDAL mesaDAL = new MesaDAL();
        
        public AddTableForm1(int id)
        {
            InitializeComponent();
            lblTitle.Text = "Editar Mesa";
            btnAdd.Text = "Editar";
            this.idMesa = id;
            mesa = mesaDAL.SearchObject(id);
            txtMesa.Texts = Convert.ToString(mesa.nro_mesa);
            txtNroSilla.Texts = Convert.ToString(mesa.cantidad_sillas);
        }

        private void CargarDatos()
        {
            mesa.nro_mesa = int.Parse(txtMesa.Texts);
            mesa.cantidad_sillas = int.Parse(txtNroSilla.Texts);
        }

        private void AddTableForm1_Deactivate(object sender, EventArgs e)
        {
            if (!isShowingMsgBox)
            {
                this.Close();
            }
        }

        private void AddTableForm1_Load(object sender, EventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtMesa.Texts) || string.IsNullOrEmpty(txtNroSilla.Texts))
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
                if(this.idMesa == 0)
                {
                    mesa = new Mesa();
                    CargarDatos();
                    mesaDAL.Create(mesa);
                    new AlertBox(this.Owner as Form, Color.LightGreen, Color.SeaGreen, "Proceso completado", "Mesa agregada correctamente", Properties.Resources.informacion);
                }
                else
                {
                    CargarDatos();
                    mesaDAL.Update(mesa);
                    new AlertBox(this.Owner as Form, Color.LightGreen, Color.SeaGreen, "Proceso completado", "Mesa editada correctamente", Properties.Resources.informacion);
                }
            }
        }

        private void txtMesa_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidator.ValidateInput(e, InputValidator.InputType.Digits);
        }

        private void txtNroSilla_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidator.ValidateInput(e, InputValidator.InputType.Digits);
        }
    }
}
