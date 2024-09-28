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

namespace TheCoffe.CPresentacion.Cajero
{
    public partial class TablesForm : UserControl
    {
        public event Action<string> mesaSeleccionada;
        public TablesForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        private void selectTable_click(object sender, EventArgs e)
        {
            RoundButton button = sender as RoundButton;
            mesaSeleccionada?.Invoke(button.Text);
        }
    }
}
