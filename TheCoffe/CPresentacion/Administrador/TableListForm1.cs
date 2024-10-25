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
using TheCoffe.CNegocio.Services;

namespace TheCoffe.App
{
    public partial class TableList : UserControl
    {
        private readonly TableService _tableService = new TableService();
        private Mesa mesa = new Mesa();
        private int id;
        public TableList()
        {
            InitializeComponent();
            dataTable.AutoGenerateColumns = false;
        }


        public async void RefreshPantalla()
        {
            TableService service = new TableService();
            var tables = await service.ObtenerMesasActivas();
            dataTable.DataSource = tables;
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
                id = Convert.ToInt32(dataTable.CurrentRow.Cells[0].Value.ToString());
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
                    id = Convert.ToInt32(dataTable.CurrentRow.Cells[0].Value.ToString());
                    _tableService.CambiarEstado(id);
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
                var lst = _tableService.BuscarPorNro(Convert.ToInt32(txtSearch.Texts));
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
