using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheCoffe.CPresentacion.Cajero
{
    public partial class TicketPreview : Form
    {
        public TicketPreview(PrintDocument Document, int Altura )
        {
            InitializeComponent();
            ticketPreviewControl.Document = Document;
            ticketPreviewControl.Height = Altura;
            this.Height = Altura + 30;
        }

        private void TicketPreview_Load(object sender, EventArgs e)
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
    }
}
