using System;
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
        public MainFormCashier()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
           LoadUserControl(new TakeOrderForm());
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
        private void SetActiveSection(RoundButton activeButton) {
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
        
        private void btnMain_Click(object sender, EventArgs e)
        {
            SetActiveSection(sender as RoundButton);
            LoadUserControl(new TakeOrderForm());
        }
        
        private void btnTables_Click(object sender, EventArgs e)
        {
            SetActiveSection(sender as RoundButton);
            LoadUserControl(new TablesForm());
        }
    }
}
