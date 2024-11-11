using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using TheCoffe.CAccesoADatos;
using TheCoffe.CNegocio.Services;

namespace TheCoffe.CPresentacion.Administrador
{
    public partial class SettingsForm : UserControl
    {
        BackupService backup = new BackupService();

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void btnCopia_Click(object sender, EventArgs e)
        {
            backup.Backup();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            backup.Restore(openFileDialog1);
     
        }
    }
}
