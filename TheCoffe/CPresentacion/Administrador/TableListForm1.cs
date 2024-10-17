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
using TheCoffe.CNegocio;

namespace TheCoffe.App
{
    public partial class TableList : UserControl
    {
        public TableList()
        {
            InitializeComponent();
        }

        MesaDAL mesaDAL = new MesaDAL();
        Mesa mesa = new Mesa();
        private int id;

        public void RefreshPantalla()
        {
            var Lst = mesaDAL.Read(false).Select(p => new {
                p.id_mesa,
                p.nro_mesa,
                p.cantidad_sillas
            }).ToList();
            dataTable.DataSource = Lst;
            dataTable.Columns[2].HeaderText = "ID";
            dataTable.Columns[3].HeaderText = "Nro de Mesa";
            dataTable.Columns[4].HeaderText = "Cant. de Sillas";
            dataTable.Columns[0].DisplayIndex = dataTable.Columns.Count - 1;
            dataTable.Columns[1].DisplayIndex = dataTable.Columns.Count - 1;
        }

        private void TableList_Load(object sender, EventArgs e)
        {
            RefreshPantalla();
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            using (OverlayForm overlay = new OverlayForm())
            {
                overlay.Show();
                using (AddTableForm1 modal = new AddTableForm1())
                {
                    modal.ShowDialog(overlay);
                }
                overlay.Close();
            }
            RefreshPantalla();
        }

        private void dataCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataTable.Columns[e.ColumnIndex].Name == "editar")
            {
                id = Convert.ToInt32(dataTable.CurrentRow.Cells[2].Value.ToString());
                using (OverlayForm overlay = new OverlayForm())
                {
                    overlay.Show();
                    using (AddTableForm1 modal = new AddTableForm1(id))
                    {
                        modal.ShowDialog(overlay);
                    }
                    overlay.Close();
                }
            }
            else if (dataTable.Columns[e.ColumnIndex].Name == "eliminar")
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = Convert.ToInt32(dataTable.CurrentRow.Cells[2].Value.ToString());
                    mesaDAL.Delete(id);
                }
            }
            RefreshPantalla();
        }

        private void btnRemovedTables_Click(object sender, EventArgs e)
        {
            using (OverlayForm overlay = new OverlayForm())
            {
                overlay.Show();
                using (RemovedTablesForm tablesRemoved = new RemovedTablesForm())
                {
                    tablesRemoved.ShowDialog(overlay);
                }
                overlay.Close();
            }
            RefreshPantalla();
        }
       
        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Texts != string.Empty)
            {
                var lst = mesaDAL.Search(Convert.ToInt32(txtSearch.Texts)).Select(p => new {
                    p.id_mesa,
                    p.nro_mesa,
                    p.cantidad_sillas
                }).ToList();
                dataTable.DataSource = lst;
            }
            else
            {
                RefreshPantalla();
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidator.ValidateInput(e, InputValidator.InputType.Digits);
        }
    }
}
