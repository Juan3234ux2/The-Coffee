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
using TheCoffe.CDatos;
using TheCoffe.CNegocio.Services;

namespace TheCoffe.App
{
    public partial class WaiterListForm : UserControl
    {
        private WaiterService _waiterService = new WaiterService();
        private Mesero mesero = new Mesero();
        private int id;
        public WaiterListForm()
        {
            InitializeComponent();
            dataWaiter.AutoGenerateColumns = false;
        }


        private async void WaiterListForm_Load(object sender, EventArgs e)
        {
            WaiterService service = new WaiterService();
            var mesero = await service.ObtenerMeserosActivos();
            dataWaiter.DataSource = mesero;
        }

        public async void RefreshPantalla()
        {
            WaiterService service = new WaiterService();
            var mesero = await service.ObtenerMeserosActivos();
            dataWaiter.DataSource = mesero;
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
                id = Convert.ToInt32(dataWaiter.CurrentRow.Cells[0].Value.ToString());

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
                    id = Convert.ToInt32(dataWaiter.CurrentRow.Cells[0].Value.ToString());
                    _waiterService.CambiarEstado(id);
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
                var meseros = _waiterService.BuscarPorNombre(txtSearch.Texts);
                dataWaiter.DataSource = meseros;
            }
            else
            {
                RefreshPantalla();
            }
        }
    }
}
