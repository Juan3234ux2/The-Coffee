using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffe.CPresentacion.General;
using TheCoffe.CPresentacion.Gerente;

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
                        switch (selectMode.ShowDialog())
                        {
                            case DialogResult.OK:
                                Application.Run(new MainFormCashier());
                                    break;
                            case DialogResult.Yes:
                                Application.Run(new MainForm());
                                break;
                            case DialogResult.Ignore:
                                Application.Run(new MainFormManager());
                                break;

                        }
                    }
                }
            }
        }
    }
}
