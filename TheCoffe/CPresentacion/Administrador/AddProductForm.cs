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
using TheCoffe.CNegocio;

namespace TheCoffe.App
{
    public partial class AddProductForm : Form
    {
        private bool isShowingMsgBox = false;
        private int idProducto = 0;
        public AddProductForm()
        {
            InitializeComponent();
        }
        public AddProductForm(String name, String price, String description)
        {
            InitializeComponent();
            lblTitle.Text = "Editar Producto";
            btnAdd.Text = "Editar";
            txtName.Texts = name;
            txtPrice.Texts = price;
            txtDescription.Texts = description;
            cboCategory.SelectedIndex = 0;
            this.idProducto = 10;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Texts) || string.IsNullOrWhiteSpace(txtPrice.Texts) || cboCategory.SelectedIndex == -1 || string.IsNullOrWhiteSpace( txtDescription.Texts))
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
                if(this.idProducto == 0)
                {
                    /*Logica para agregar*/
                    new AlertBox(this.Owner as Form, Color.LightGreen, Color.SeaGreen, "Proceso completado", "Producto agregado correctamente", Properties.Resources.informacion);
                }
                else
                {
                    /*Logica para editar*/
                    new AlertBox(this.Owner as Form, Color.LightGreen, Color.SeaGreen, "Proceso completado", "Producto editado correctamente", Properties.Resources.informacion);

                }
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
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

        private void AddProductForm_Deactivate(object sender, EventArgs e)
        {
            if (!isShowingMsgBox)
            {
                this.Close();
            }
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            cboCategory.DroppedDown = !cboCategory.DroppedDown;
        }

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidator.ValidateInput(e, InputValidator.InputType.Letters);
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidator.ValidateInput(e, InputValidator.InputType.Letters);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidator.ValidateInput(e, InputValidator.InputType.Digits);
        }

        private void btnCategory_Click_1(object sender, EventArgs e)
        {
            cboCategory.DroppedDown = !cboCategory.DroppedDown;
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            selectImageDialog.Filter = "Imagenes (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            isShowingMsgBox = true;
            if (selectImageDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = selectImageDialog.FileName;
                string fileName = Path.GetFileName(selectedFilePath);
                string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string resourcesFolderPath = Path.Combine(projectDirectory, "Resources");
                string imagesFolderPath = Path.Combine(resourcesFolderPath, "Products");
                if (!Directory.Exists(imagesFolderPath))
                {
                    Directory.CreateDirectory(imagesFolderPath);
                }
                string destinationFilePath = Path.Combine(imagesFolderPath, fileName);
                try
                {
                    File.Copy(selectedFilePath, destinationFilePath, true);
                    pboImage.Image = Image.FromFile(destinationFilePath);
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
