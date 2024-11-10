using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffe.CAccesoADatos;

namespace TheCoffe.CNegocio.Services
{

    class BackupService
    {
        BackupRepository _backupRepository = new BackupRepository(); 

        public void Backup()
        {
            _backupRepository.Backup();
        } 

        public void Restore(OpenFileDialog openFileDialog1)
        {
            _backupRepository.Restore(openFileDialog1);
        }
    }
}
