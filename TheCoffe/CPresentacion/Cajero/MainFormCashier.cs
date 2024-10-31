using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;
using AltoControls;
using FontAwesome.Sharp;
using TheCoffe.App;
using TheCoffe.CDatos;
using TheCoffe.CNegocio.Services;
using TheCoffe.CPresentacion;
using TheCoffe.CPresentacion.Cajero;
using WindowsFormsApplication1;

namespace TheCoffe
{
    public partial class MainFormCashier : Form
    {
        UserControl activeSection = null;
        private Cajero TakeOrder;
        private TablesForm tablesForm;
        private SalesBoxForm salesBoxForm;
        private UserService _userService = new UserService();
        private OrderService _orderService = new OrderService();
        private Usuario usuarioActual = AuthUser.Usuario;
        public MainFormCashier()
        {
            InitializeComponent();
            TakeOrder = new Cajero();
            tablesForm = new TablesForm();
            salesBoxForm = new SalesBoxForm();
            tablesForm.mesaSeleccionada += selectedTable;
            TakeOrder.finalizarOrden += finalizarPedido;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            using (OverlayForm overlay = new OverlayForm())
            {
                overlay.Show();
                using (OpenBoxForm modal = new OpenBoxForm())
                {
                    modal.ShowDialog(overlay);
                }
                overlay.Close();
            }
           tablesForm.CargarMesas();
           LoadUserControl(tablesForm);
           SetActiveSection(btnTables);
           lblUser.Text = usuarioActual.nombreCompleto;
           imgUser.Image = Image.FromFile(_userService.ObtenerImagen());
        }
        private void finalizarPedido()
        {            
            tablesForm.CargarMesas();
            CargarVistaMesas(btnTables);
            salesBoxForm.CargarVentasDelTurno();
            new AlertBox(this.Owner as Form, Color.LightGreen, Color.SeaGreen, "Pedido Finalizado", "Pedido Finalizado Exitosamente", Properties.Resources.informacion);
        }
        private void selectedTable(string p_mesaSeleccionada)
        {            
            tablesForm.CargarMesas();
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
            CargarVistaMesas(sender as RoundButton);
        }
        private void CargarVistaMesas(RoundButton button)
        {
            if (Turno.TurnoActual.monto_cierre != null)
            {
                MessageBox.Show("La caja está cerrada. No se pueden tomar órdenes.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SetActiveSection(button);
            LoadUserControl(tablesForm);
        }
        private void BtnBox_Click(object sender, EventArgs e)
        {
            SetActiveSection(sender as RoundButton);
            LoadUserControl(salesBoxForm);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (Turno.TurnoActual.monto_cierre == null)
            {
                MessageBox.Show("El cierre de caja está pendiente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("¿Estás seguro que deseas cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void MainFormCashier_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Turno.TurnoActual != null)
            {
                if(Turno.TurnoActual.monto_cierre == null)
                {
                    MessageBox.Show("El cierre de caja está pendiente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
        }
    }
}
