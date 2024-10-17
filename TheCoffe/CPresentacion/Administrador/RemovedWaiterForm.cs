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

namespace TheCoffe.CPresentacion
{
    public partial class RemovedWaiterForm : Form
    {
        private bool isShowingMsgBox = false;
        public RemovedWaiterForm()
        {
            InitializeComponent();
        }

        MeseroDAL meseroDAL = new MeseroDAL();
        Mesero mesero = new Mesero();
        private int id;

        public void RefreshPantalla()
        {
            var Lst = meseroDAL.Read(true).Select(p => new {
                p.id_mesero,
                p.nombre,
                p.apellido,
                p.dni,
                p.telefono,
                p.hora_entrada,
                p.hora_salida
            }).ToList();
            dataRemovedWaiter.DataSource = Lst;
            dataRemovedWaiter.Columns[1].HeaderText = "ID";
            dataRemovedWaiter.Columns[2].HeaderText = "Nombre";
            dataRemovedWaiter.Columns[3].HeaderText = "Apellido";
            dataRemovedWaiter.Columns[4].HeaderText = "DNI";
            dataRemovedWaiter.Columns[5].HeaderText = "Teléfono";
            dataRemovedWaiter.Columns[6].HeaderText = "Hora de Ingreso";
            dataRemovedWaiter.Columns[7].HeaderText = "Hora de Salida";
            dataRemovedWaiter.Columns[0].DisplayIndex = dataRemovedWaiter.Columns.Count - 1;
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
                    id = Convert.ToInt32(dataRemovedWaiter.CurrentRow.Cells[1].Value.ToString());
                    meseroDAL.Delete(id);
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
    }
}
