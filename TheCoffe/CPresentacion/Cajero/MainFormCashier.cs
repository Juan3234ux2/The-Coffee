﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;
using AltoControls;
using FontAwesome.Sharp;
using TheCoffe.App;
using TheCoffe.CPresentacion;
using TheCoffe.CPresentacion.Cajero;
using WindowsFormsApplication1;

namespace TheCoffe
{
    public partial class MainFormCashier : Form
    {
        UserControl activeSection = null;
        private TakeOrderForm TakeOrder;
        private TablesForm tablesForm;
        private SalesBoxForm salesBoxForm;
        public MainFormCashier()
        {
            InitializeComponent();
            TakeOrder = new TakeOrderForm();
            tablesForm = new TablesForm();
            salesBoxForm = new SalesBoxForm();
            tablesForm.mesaSeleccionada += selectedTable;        
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
           LoadUserControl(tablesForm);
           SetActiveSection(btnTables);

            using (OverlayForm overlay = new OverlayForm())
            {
                overlay.Show();
                using (OpenBoxForm modal = new OpenBoxForm())
                {
                    modal.ShowDialog(overlay);
                }
                overlay.Close();
            }
        }
        private void selectedTable(string p_mesaSeleccionada)
        {
            TakeOrder.mesaSeleccionada = p_mesaSeleccionada;
            LoadUserControl(TakeOrder);
            TakeOrder.OnSection1Loaded();
        }
        private void LoadUserControl(UserControl userControl)
        {
            if (activeSection != null && activeSection.GetType() == userControl.GetType())
            {
                return;
            }

            if (activeSection != null)
            {        
                pnlMain.Controls.Remove(activeSection);
            }
            activeSection = userControl;
            activeSection.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(activeSection);

        }
        private void SetActiveSection(RoundButton activeButton) {
            RemoveActiveSection();
            activeButton.ForeColor = Color.FromArgb(96, 75, 232);
            activeButton.BackgroundColor = Color.FromArgb(245, 240, 240);
            activeButton.IconColor = Color.FromArgb(96, 75, 232);
        }
        private void RemoveActiveSection()
        {
            foreach (Control control in pnlSideBar.Controls)
            {
                if (control is RoundButton button)
                {
                    if (control.Name == "btnLogout") continue;
                    button.BackColor = Color.Transparent;
                    button.ForeColor = Color.DimGray;
                    button.IconColor = Color.DimGray;
                }
            }
        }
        
        private void btnTables_Click(object sender, EventArgs e)
        {
            SetActiveSection(sender as RoundButton);
            LoadUserControl(tablesForm);
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que deseas cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnBox_Click(object sender, EventArgs e)
        {
            SetActiveSection(sender as RoundButton);
            LoadUserControl(salesBoxForm);
        }
    }
}
