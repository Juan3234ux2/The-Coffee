using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffe.CPresentacion;
using TheCoffe.CAccesoADatos;
using TheCoffe.CDatos;

namespace TheCoffe.App
{
    public partial class WaiterListForm : UserControl
    {
        public WaiterListForm()
        {
            InitializeComponent();
        }

        MeseroDAL meseroDAL = new MeseroDAL();
        Mesero mesero = new Mesero();
        private int id;

        private void WaiterListForm_Load(object sender, EventArgs e)
        {
            RefreshPantalla();
        }

        public void RefreshPantalla()
        {
            var Lst = meseroDAL.Read(false).Select(p => new {
                p.id_mesero, p.nombre, p.apellido, p.dni, p.telefono, p.hora_entrada, p.hora_salida
            }).ToList();
            dataWaiter.DataSource = Lst;
            dataWaiter.Columns[2].HeaderText = "ID";
            dataWaiter.Columns[3].HeaderText = "Nombre";
            dataWaiter.Columns[4].HeaderText = "Apellido";
            dataWaiter.Columns[5].HeaderText = "DNI";
            dataWaiter.Columns[6].HeaderText = "Teléfono";
            dataWaiter.Columns[7].HeaderText = "Hora de Ingreso";
            dataWaiter.Columns[8].HeaderText = "Hora de Salida";
            dataWaiter.Columns[0].DisplayIndex = dataWaiter.Columns.Count - 1;
            dataWaiter.Columns[1].DisplayIndex = dataWaiter.Columns.Count - 1;
        }

        private void btnAddWaiter_Click(object sender, EventArgs e)
        {
            using (OverlayForm overlay = new OverlayForm())
            {
                overlay.Show();
                using (AddWaiterForm modal = new AddWaiterForm())
                {
                    modal.ShowDialog(overlay);
                }
                overlay.Close();
            }
            RefreshPantalla();
        }
        
        private void dataWaiter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataWaiter.Columns[e.ColumnIndex].Name == "editar")
            {
                id = Convert.ToInt32(dataWaiter.CurrentRow.Cells[2].Value.ToString());

                using (OverlayForm overlay = new OverlayForm())
                {
                    overlay.Show();
                    using (AddWaiterForm modal = new AddWaiterForm(id))
                    {
                        modal.ShowDialog(overlay);
                    }
                    overlay.Close();
                }
            }
            else if (dataWaiter.Columns[e.ColumnIndex].Name == "eliminar")
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = Convert.ToInt32(dataWaiter.CurrentRow.Cells[2].Value.ToString());
                    meseroDAL.Delete(id);
                }
            }
            RefreshPantalla();
        }

        private void btnRemovedWaiter_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            using (OverlayForm overlay = new OverlayForm())
            {
                overlay.Size = parentForm.ClientSize;
                overlay.Location = parentForm.PointToScreen(Point.Empty);
                overlay.Owner = parentForm;

                overlay.Show();
                using (RemovedWaiterForm waiterRemoved = new RemovedWaiterForm())
                {
                    waiterRemoved.ShowDialog(overlay);
                }
                overlay.Close();
            }
            RefreshPantalla();
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Texts != string.Empty)
            {
                var Lst = meseroDAL.Search(txtSearch.Texts).Select(p => new {
                    p.id_mesero,
                    p.nombre,
                    p.apellido,
                    p.dni,
                    p.telefono,
                    p.hora_entrada,
                    p.hora_salida
                }).ToList();
                dataWaiter.DataSource = Lst;
            }
            else
            {
                RefreshPantalla();
            }
        }
    }
}
