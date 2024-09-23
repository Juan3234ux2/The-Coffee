using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffe.CNegocio;

namespace TheCoffe.App
{
    public partial class AddCategoryForm : Form
    {
        private bool isShowingMsgBox = false;
        public AddCategoryForm()
        {
            InitializeComponent();
        }

        public AddCategoryForm(string descripcion)
        {
            InitializeComponent();
            lblTitle.Text = "Editar Categoría";
            btnAddCategory.Text = "Editar";
            txtDescripcion.Texts = descripcion;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Texts))
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
                new AlertBox(this.Owner as Form, Color.LightGreen, Color.SeaGreen, "Proceso completado", "Categoría agregada correctamente", Properties.Resources.informacion);
            }
        }

        private void AddCategoryForm_Deactivate(object sender, EventArgs e)
        {
            if (!isShowingMsgBox)
            {
              this.Close();
            }
        }

        private void AddCategoryForm_Load(object sender, EventArgs e)
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

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidator.ValidateInput(e, InputValidator.InputType.Letters);
        }
    }
}
