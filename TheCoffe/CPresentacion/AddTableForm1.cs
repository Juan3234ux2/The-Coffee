﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheCoffe.App
{
    public partial class AddTableForm1 : Form
    {
        public AddTableForm1()
        {
            InitializeComponent();
        }

        void AlertBox(Color backColor, Color color, string title, string text, Image icon)
        {
            AlertBox frm = new AlertBox();
            frm.BackColor = backColor;
            frm.ColorAlertBox = color;
            frm.TitleAlertBox = title;
            frm.TextAlertBox = text;
            frm.IconAlertBox = icon;
            frm.Show();
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNroSilla.Text) || string.IsNullOrWhiteSpace(txtMesa.Text))
            {

                MessageBox.Show("Debe Completar todos los campos",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
        }

        private void AddTableForm1_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddTableForm1_Load(object sender, EventArgs e)
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
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNroMesa__TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AlertBox(Color.LightGreen, Color.SeaGreen, "Hola Mundo", "Emilia...", Properties.Resources.informacion);
        }
    }
}