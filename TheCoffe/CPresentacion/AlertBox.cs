using System;
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
    public partial class AlertBox : Form
    {
        private Form mainForm;
        public AlertBox(Form parentForm, Color backColor, Color color, string title, string text, Image icon)
        {
            InitializeComponent();
            this.mainForm = parentForm;
            this.BackColor = backColor;
            this.ColorAlertBox = color;
            this.TitleAlertBox = title;
            this.TextAlertBox = text;
            this.IconAlertBox = icon;
            this.Show();
        }

        public Color BackColorAlertBox
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        public Color ColorAlertBox
        {
            get { return linAlertBox.BackColor; }
            set { linAlertBox.BackColor = lblTitleAlertBox.ForeColor =  lblTextAlertBox.ForeColor = value; }
        }

        public Image IconAlertBox
        {
            get { return picAlertBox.Image; }
            set { picAlertBox.Image = value; }
        }

        public String TitleAlertBox
        {
            get { return lblTitleAlertBox.Text; }
            set { lblTitleAlertBox.Text = value; }
        }

        public String TextAlertBox
        {
            get { return lblTextAlertBox.Text; }
            set { lblTextAlertBox.Text = value; }
        }

        private void PositionAlertBox()
        {
            int xPos = 0; int yPos = 0;
            xPos = this.mainForm.Width;
            yPos = this.mainForm.Height;
            this.Location = this.mainForm.PointToScreen(new Point(xPos - this.Width, yPos - this.Height));
        }

        private void timerAnimasion_Tick(object sender, EventArgs e)
        {
            linAlertBox.Width = linAlertBox.Width + 3;
            if (linAlertBox.Width >= 350)
            {
                timerAnimasion.Stop();
                this.Close();
            }
        }

        private void AlertBox_Load(object sender, EventArgs e)
        {
            PositionAlertBox();
            
            timerAnimasion.Start();
        }

    }
}
