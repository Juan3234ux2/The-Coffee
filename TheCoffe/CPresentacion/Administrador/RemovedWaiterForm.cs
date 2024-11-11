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
using TheCoffe.CDatos;
using TheCoffe.CNegocio;
using TheCoffe.CNegocio.Services;

namespace TheCoffe.CPresentacion
{
    public partial class RemovedWaiterForm : Form
    {
        private Paginator<Mesero> paginator;
        private bool isShowingMsgBox = false;
        private WaiterService _waiterService = new WaiterService();
        public RemovedWaiterForm()
        {
            InitializeComponent();
            dataRemovedWaiter.AutoGenerateColumns = false;
        }

        public async void RefreshPantalla()
        {
            var meseros = await _waiterService.ObtenerMeserosEliminados();
            paginator = new Paginator<Mesero>(meseros, 9);
            CargarDatos(paginator);
        }

        private void RemovedWaiterForm_Load(object sender, EventArgs e)
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

        private void dataRemovedWaiter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataRemovedWaiter.Columns[e.ColumnIndex].Name == "activar")
            {
                    isShowingMsgBox = true;
                    if (MessageBox.Show("¿Está seguro que desea activar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                    int id = Convert.ToInt32(dataRemovedWaiter.CurrentRow.Cells[0].Value.ToString());
                    _waiterService.CambiarEstado(id);
                    }
                    isShowingMsgBox = false;
                    RefreshPantalla();
            }
        }

        private void RemovedWaiterForm_Deactivate(object sender, EventArgs e)
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


        public void CargarDatos(Paginator<Mesero> meseros)
        {
            dataRemovedWaiter.DataSource = null;
            dataRemovedWaiter.DataSource = meseros.GetPageData();
            ActualizarPaginacion(meseros);
        }
        private void ActualizarPaginacion(Paginator<Mesero> mesero)
        {
            lblPagina.Text = $"Página {mesero.CurrentPage} de {mesero.TotalPages}";
            btnAnt.Enabled = mesero.CurrentPage > 1;
            btnSig.Enabled = mesero.CurrentPage < mesero.TotalPages;
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            paginator.PreviousPage();
            CargarDatos(paginator);
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            paginator.NextPage();
            CargarDatos(paginator);
        }
    }
}
