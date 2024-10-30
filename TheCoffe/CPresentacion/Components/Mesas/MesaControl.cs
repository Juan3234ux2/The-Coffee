using System;
using System.Drawing;
using System.Windows.Forms;
using TheCoffe.App;
using TheCoffe.CDatos;
using TheCoffe.CPresentacion.Cajero;

namespace TheCoffe.CPresentacion.Components
{
    public partial class MesaControl : UserControl
    {
        protected Mesa mesa;
        public event Action<string> selectTable;

        public MesaControl(Mesa p_mesa)
        {
            InitializeComponent(); 
            this.mesa = p_mesa;
            InitializeTable();
        }

        protected virtual void InitializeTable()
        {

        }

        protected void btnMesa_Click(object sender, EventArgs e)
        {
            if (mesa.disponible)
            {
                using (OverlayForm overlay = new OverlayForm())
                {
                    overlay.Show();
                    using (OpenOrder modal = new OpenOrder(mesa.nro_mesa))
                    {
                        var result = modal.ShowDialog(overlay);
                        if (result == DialogResult.OK)
                        {
                            selectTable?.Invoke(mesa.nro_mesa.ToString());
                        }
                    }
                    overlay.Close();
                }
            }
            else
            {
                selectTable?.Invoke(mesa.nro_mesa.ToString());
            }
        }
    }
}
