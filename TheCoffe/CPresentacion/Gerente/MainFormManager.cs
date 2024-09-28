﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace TheCoffe.CPresentacion.Gerente
{
    public partial class MainFormManager : Form
    {
        UserControl activeSection = null;
        public MainFormManager()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainFormManager_Load(object sender, EventArgs e)
        {
            LoadUserControl(new SalesReportsForm());
        }
        private async void LoadUserControl(UserControl userControl)
        {
            if (activeSection != null && activeSection.GetType() == userControl.GetType())
            {
                return;
            }

            if (activeSection != null)
            {
                pnlMain.Controls.Remove(activeSection);
                await Task.Delay(200);
            }
            activeSection = userControl;
            activeSection.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(activeSection);
        }

        private void SetActiveSection(RoundButton activeButton)
        {
            RemoveActiveSection();
            activeButton.ForeColor = Color.FromArgb(96, 75, 232);
            activeButton.BackgroundColor = Color.FromArgb(222, 232, 250);
            activeButton.IconColor = Color.FromArgb(96, 75, 232);
        }

        private void RemoveActiveSection()
        {
            foreach (Control control in pnlSideBar.Controls)
            {
                if (control is RoundButton button)
                {
                    button.BackColor = Color.Transparent;
                    button.ForeColor = Color.DimGray;
                    button.IconColor = Color.DimGray;
                }
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            SetActiveSection(sender as RoundButton);
            LoadUserControl(new SalesListForm());
        }
    }
}