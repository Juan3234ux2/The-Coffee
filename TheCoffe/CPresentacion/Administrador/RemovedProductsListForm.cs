using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoffe.App;
using System.Windows.Forms;
using TheCoffe.CAccesoADatos;
using TheCoffe.CDatos;

namespace TheCoffe.CPresentacion
{
    public partial class RemovedProductsListForm : Form
    {
        private bool isShowingMsgBox = false;
        public RemovedProductsListForm()
        {
            InitializeComponent();
            dataRemovedProducts.AutoGenerateColumns = false;
        }

        ProductoDAL productoDAL = new ProductoDAL();
        Producto producto = new Producto();
        private int id;

        public void RefreshPantalla()
        {
            var productos = productoDAL.Read(false);

            dataRemovedProducts.DataSource = productos.Select(p =>
            new
            {
                p.id_producto,
                p.nombre,
                p.precio,
                c = p.Categoria1.descripcion
            }).ToList();

        }
        private void RemovedProductsListForm_Load(object sender, EventArgs e)
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
            RefreshPantalla();
        }

        private void dataRemovedProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataRemovedProducts.Columns[e.ColumnIndex].Name == "activar")
            {
                    isShowingMsgBox = true;
                    if (MessageBox.Show("¿Está seguro que desea activar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                    id = Convert.ToInt32(dataRemovedProducts.CurrentRow.Cells[0].Value.ToString());
                    productoDAL.Delete(id);
                    }
                    isShowingMsgBox = false;
                    RefreshPantalla();
            }
        }

        private void RemovedProductsListForm_Deactivate(object sender, EventArgs e)
        {
            if (!isShowingMsgBox)
            {
                this.Close();
            }
        }
    }
}
