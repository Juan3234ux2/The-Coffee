﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;
using AltoControls;
using FontAwesome.Sharp;
using TheCoffe.App;
using TheCoffe.CAccesoADatos;
using TheCoffe.CPresentacion;
using TheCoffe.CDatos;
using WindowsFormsApplication1;
using TheCoffe.CNegocio.Services;
using System.IO;
using TheCoffe.CPresentacion.Administrador;

namespace TheCoffe
{
    public partial class MainForm : Form
    {
        UserControl activeSection = null;
        private UserService _userService = new UserService();
        private Usuario usuarioActual = AuthUser.Usuario;
        public MainForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            ActualizarInfo();
        }        
        private void MainForm_Load(object sender, EventArgs e)
        {
           LoadUserControl(new DashboardForm());
           precargarDatos();
        }
        private async void precargarDatos()
        {
                var Lst = await _userService.ObtenerUsuariosActivos();     
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
                    button.BackColor = Color.Transparent;
                    button.ForeColor = Color.DimGray;
                    button.IconColor = Color.DimGray;
                }
            }
        }
        private  void btnDashboard_Click(object sender, EventArgs e)
        {
            SetActiveSection(sender as RoundButton);
            LoadUserControl(new DashboardForm());
        }
        
        private  void btnProducts_Click(object sender, EventArgs e)
        {
            SetActiveSection(sender as RoundButton);
            LoadUserControl(new ProductListForm());
        }

        private void btnUserList_Click(object sender, EventArgs e)
        {
            SetActiveSection(sender as RoundButton);
            LoadUserControl(new UserListForm());
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            SetActiveSection(sender as RoundButton);
            LoadUserControl(new CategoryList());
        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            SetActiveSection(sender as RoundButton);
            LoadUserControl(new TableList());
        }

        private void btnWaiter_Click(object sender, EventArgs e)
        {
            SetActiveSection(sender as RoundButton);
            LoadUserControl(new WaiterListForm());
        }

        private void btnUserDetails_Click(object sender, EventArgs e)
        {
            RemoveActiveSection();
            ProfileForm profileForm = new ProfileForm();
            profileForm.UpdatedUser += ActualizarInfo;
            LoadUserControl(profileForm);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            SetActiveSection(sender as RoundButton);
            LoadUserControl(new SalesListForm());
        }
        private void ActualizarInfo()
        {
            lblUser.Text = usuarioActual.nombreCompleto;
            imgUser.Image = Image.FromFile(_userService.ObtenerImagen());
        }

        private void btnConfiguration_Click(object sender, EventArgs e)
        {
            SetActiveSection(sender as RoundButton);
            LoadUserControl(new SettingsForm());
        }
    }
}   
