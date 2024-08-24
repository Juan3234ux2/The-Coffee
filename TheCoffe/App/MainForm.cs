﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using AltoControls;
using FontAwesome.Sharp;
using LiveCharts;
using LiveCharts.Wpf;
using TheCoffe.App;
using WindowsFormsApplication1;

namespace TheCoffe
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
           LoadUserControl(new DashboardForm());
        }
        private void LoadUserControl(UserControl userControl)
        {
            pnlMain.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(userControl);
        }
        private void SetActiveSection(RoundButton activeButton) {
            foreach (Control control in pnlSideBar.Controls)
            {
                if (control is RoundButton button)
                {
                    button.BackColor = Color.Transparent;
                    button.ForeColor = Color.DimGray;
                    button.IconColor = Color.DimGray;
                }
            }
            activeButton.ForeColor = Color.FromArgb(96, 75, 232);
            activeButton.BackgroundColor = Color.FromArgb(222, 232, 250);
            activeButton.IconColor = Color.FromArgb(96, 75, 232);
        }
     
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SetActiveSection(sender as RoundButton);
            LoadUserControl(new DashboardForm());
        }

        private void pnlSideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            SetActiveSection(sender as RoundButton);
            LoadUserControl(new ProductListForm());
        }
    }
}