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
    public partial class OverlayForm : Form
    {
        public OverlayForm()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            this.Opacity = 0.5;
        }

        private void OverlayForm_Deactivate(object sender, EventArgs e)
        {
        }
    }
}
