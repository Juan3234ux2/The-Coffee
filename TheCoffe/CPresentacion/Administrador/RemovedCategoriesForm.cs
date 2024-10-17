using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffe.App;
using TheCoffe.CAccesoADatos;
using TheCoffe.CDatos;

namespace TheCoffe.CPresentacion.General
{
    public partial class RemovedCategoriesForm : Form
    {
        private bool isShowingMsgBox = false;
        public RemovedCategoriesForm()
        {
            InitializeComponent();
        }

        Categoria1DAL categoriaDAL = new Categoria1DAL();
        Categoria1 categoria = new Categoria1();
        private int id;

        public void RefreshPantalla()
        {
            var Lst = categoriaDAL.Read(true).Select(p => new {
                p.id_categoria,
                p.descripcion
            }).ToList();

            dataRemovedCategory.DataSource = Lst;
            dataRemovedCategory.Columns[1].HeaderText = "ID";
            dataRemovedCategory.Columns[2].HeaderText = "Descripción";
            dataRemovedCategory.Columns[0].DisplayIndex = dataRemovedCategory.Columns.Count - 1;
        }
        private void RemovedCategoriesForm_Load(object sender, EventArgs e)
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

        private void dataCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataRemovedCategory.Columns[e.ColumnIndex].Name == "activar")
            {
                    isShowingMsgBox = true;
                    if (MessageBox.Show("¿Está seguro que desea activar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                    id = Convert.ToInt32(dataRemovedCategory.CurrentRow.Cells[1].Value.ToString());
                    categoriaDAL.Delete(id);
                    }
                    isShowingMsgBox = false;
                    RefreshPantalla();
            }
        }

        private void RemovedCategoriesForm_Deactivate(object sender, EventArgs e)
        {
            if (!this.isShowingMsgBox)
            {
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataRemovedCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
