using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;
using TheCoffe.CDatos;
using TheCoffe.CPresentacion.Components;
using TheCoffe.CNegocio.Services;

namespace TheCoffe.CPresentacion.Cajero
{
    public partial class TablesForm : UserControl
    {
        public event Action<string> mesaSeleccionada;
        private TableService tableService = new TableService();
        public TablesForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            CargarMesas();
        }
        public async void CargarMesas()
        {
            var mesas = await tableService.ObtenerMesasActivas();
            foreach(Mesa mesa in mesas)
            {
                if (mesa.cantidad_sillas > 0 && mesa.cantidad_sillas <= 2)
                {
                    var mesaForm = new Table2(mesa);
                    mesaForm.selectTable += selectTable;
                    mesaForm.Margin = new Padding(10);
                    pnlTables.Controls.Add(mesaForm);
                }
                else if(mesa.cantidad_sillas <= 4)
                {
                    var mesaForm = new Table4(mesa);
                    mesaForm.selectTable += selectTable;
                    mesaForm.Margin = new Padding(10);
                    pnlTables.Controls.Add(mesaForm);
                }
                else if (mesa.cantidad_sillas <= 6)
                {
                    var mesaForm = new Table6(mesa);
                    mesaForm.selectTable += selectTable;
                    mesaForm.Margin = new Padding(10);
                    pnlTables.Controls.Add(mesaForm);
                }
                else if (mesa.cantidad_sillas <= 8)
                {
                    var mesaForm = new Table8(mesa);
                    mesaForm.selectTable += selectTable;
                    mesaForm.Margin = new Padding(10);
                    pnlTables.Controls.Add(mesaForm);
                }
                else
                {
                    var mesaForm = new Table10(mesa);
                    mesaForm.selectTable += selectTable;
                    mesaForm.Margin = new Padding(10);
                    pnlTables.Controls.Add(mesaForm);
                }
               
            }
        }
        private void selectTable(string nroMesa)
        {
            mesaSeleccionada?.Invoke(nroMesa);
        }
    }
}
