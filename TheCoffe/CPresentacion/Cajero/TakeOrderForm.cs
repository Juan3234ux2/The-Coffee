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
using TheCoffe.App;

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
                panel6.AutoScroll = false;
                panel6.AutoScroll = true;
            }
        }

        private void btnWaiter_Click(object sender, EventArgs e)
        {
            cboWaiter.DroppedDown = cboWaiter.DroppedDown;
        }

        private void btnFinalizeOrder_Click(object sender, EventArgs e)
        {
            if(cboWaiter.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un mesero",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            else
            {
                using (OverlayForm overlay = new OverlayForm())
                {
                    overlay.Show();
                    using (FinalizeOrder modal = new FinalizeOrder())
                    {
                        modal.ShowDialog(overlay);
                    }
                    overlay.Close();
                }
            }
        }
    }
}
