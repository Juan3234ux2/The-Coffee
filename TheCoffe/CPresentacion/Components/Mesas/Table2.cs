﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffe.CDatos;
using TheCoffe.App;
using TheCoffe.CPresentacion.Cajero;

namespace TheCoffe.CPresentacion.Components
{
    public partial class Table2 : UserControl 
    {
        private Mesa mesa;
        public event Action<string> selectTable;
        public event Action newOrder;
        public Table2(Mesa p_mesa)
        {
            InitializeComponent();
            this.mesa = p_mesa;
            btnMesa.Text = mesa.nro_mesa.ToString();
            btnMesa.BackColor = mesa.disponible ?Color.LimeGreen : Color.OrangeRed;
        }

        private void btnMesa_Click(object sender, EventArgs e)
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
                            newOrder?.Invoke();                      
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
