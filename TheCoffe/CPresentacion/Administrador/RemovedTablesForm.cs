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
using TheCoffe.CNegocio.Services;

namespace TheCoffe.CPresentacion
{
    public partial class RemovedTablesForm : Form
    {
        private bool isShowingMsgBox = false;
        private readonly TableService _tableService = new TableService();
        private Mesa mesa = new Mesa();
        private int id;
        public RemovedTablesForm()
        {
            InitializeComponent();
            dataRemovedTable.AutoGenerateColumns = false;
        }

        public async void RefreshPantalla()
        {
            var tables = await _tableService.ObtenerMesasEliminadas();
            dataRemovedTable.DataSource = tables;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemovedTablesForm_Load(object sender, EventArgs e)
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

        private void RemovedTablesForm_Deactivate(object sender, EventArgs e)
        {
            if (!this.isShowingMsgBox)
            {
                this.Close();
            }
        }

        private void dataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataRemovedTable.Columns[e.ColumnIndex].Name == "activar")
            {
                    isShowingMsgBox = true;
                    if (MessageBox.Show("¿Está seguro que desea activar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                    id = Convert.ToInt32(dataRemovedTable.CurrentRow.Cells[0].Value.ToString());
                    _tableService.CambiarEstado(id);
                    }
                    isShowingMsgBox = false;
                    RefreshPantalla();
            }
        }
    }
}
