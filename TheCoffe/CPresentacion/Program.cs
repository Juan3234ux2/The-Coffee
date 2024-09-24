using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffe.CPresentacion.General;

namespace TheCoffe
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (LoginForm loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    using (SelectModeForm selectMode = new SelectModeForm())
                    {
                        if (selectMode.ShowDialog() == DialogResult.OK)
                        {
                            Application.Run(new MainFormCashier());
                        }
                        else
                        {
                            Application.Run(new MainForm());
                        }
                    }
                }
            }
        }
    }
}
