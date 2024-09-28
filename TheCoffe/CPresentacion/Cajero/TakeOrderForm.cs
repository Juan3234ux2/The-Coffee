using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AltoControls;

namespace TheCoffe.CPresentacion.Cajero
{
    public partial class TakeOrderForm : UserControl
    {
        public string mesaSeleccionada { get; set; }
        public TakeOrderForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        public void OnSection1Loaded()
        {
            if (!string.IsNullOrEmpty(mesaSeleccionada))
            {
                lblNroMesa.Text = $"Mesa: {mesaSeleccionada}";
                MessageBox.Show($"Se seleccionó la mesa: {mesaSeleccionada}");
            }
        }
    }
}
