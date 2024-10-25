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
    public partial class AddCategoryForm : Form
    {
        private bool isShowingMsgBox = false;
        private readonly CategoryService _categoryService = new CategoryService();
        private Categoria1 categoria = null;
        private int idCategoria = 0;
        public AddCategoryForm()
        {
            InitializeComponent();
        }

        public AddCategoryForm(int id)
        {
            InitializeComponent();
            lblTitle.Text = "Editar Categoría";
            btnAddCategory.Text = "Editar";
            this.idCategoria = id;
            categoria = _categoryService.ObtenerCategoriaPorID(id);
            txtDescripcion.Texts = categoria.descripcion;
        }

        private void CargarDatos()
        {
            this.categoria.descripcion = txtDescripcion.Texts;
            this.categoria.estado = true;
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
                    if (this.idCategoria == 0)
                    {
                        AddCategory();
                    }
                    else
                    {
                        EditCategory();
                    }
                }
        }
        private void AddCategory()
        {
            try
            {
                categoria = new Categoria1();
                CargarDatos();
                _categoryService.CrearCategoria(categoria);
                new AlertBox(this.Owner as Form, Color.LightGreen, Color.SeaGreen, "Proceso completado", "Categoría agregada correctamente", Properties.Resources.informacion);
            }catch(Exception ex)
            {
                this.isShowingMsgBox = true;
                MessageBox.Show(ex.Message,"Error al insertar", MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.isShowingMsgBox = false;
            }
        }
        private void EditCategory()
        {
            try
            {
                CargarDatos();
                _categoryService.ActualizarCategoria(categoria);
                new AlertBox(this.Owner as Form, Color.LightGreen, Color.SeaGreen, "Proceso completado", "Categoría editada correctamente", Properties.Resources.informacion);
            
            }
            catch (Exception ex)
            {
                this.isShowingMsgBox = true;
                MessageBox.Show(ex.Message, "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.isShowingMsgBox = false;
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
