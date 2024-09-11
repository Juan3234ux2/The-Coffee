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
        public AlertBox()
        {
            InitializeComponent();
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
            xPos = Screen.GetWorkingArea(this).Width;
            yPos = Screen.GetWorkingArea(this).Height;
            this.Location = new Point(xPos - this.Width, yPos - this.Height);
        }

        private void timerAnimasion_Tick(object sender, EventArgs e)
        {
            linAlertBox.Width = linAlertBox.Width + 2;
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

        private void AlertBox_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
