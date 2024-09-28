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

            while (true) // Loop para manejar múltiples inicios de sesión
            {
                // Mostrar el formulario de login
                using (LoginForm loginForm = new LoginForm())
                {
                    if (loginForm.ShowDialog() != DialogResult.OK)
                    {
                        // Si el login es cancelado o fallido, salir del ciclo y cerrar la aplicación
                        break;
                    }

                    // Mostrar la ventana de selección de modo
                    using (SelectModeForm selectModeForm = new SelectModeForm())
                    {
                        DialogResult modeResult = selectModeForm.ShowDialog();

                        // Dependiendo del modo seleccionado, correr el formulario adecuado
                        Form selectedForm = null;
                        switch (modeResult)
                        {
                            case DialogResult.OK:
                                selectedForm = new MainFormCashier();
                                break;
                            case DialogResult.Yes:
                                selectedForm = new MainForm();
                                break;
                            case DialogResult.Ignore:
                                selectedForm = new MainFormManager();
                                break;
                            default:
                                // Si el usuario cancela la selección de modo, se cierra la aplicación
                                return;
                        }

                        // Ejecutar el formulario seleccionado
                        if (selectedForm != null)
                        {
                            // Usamos ShowDialog en lugar de Application.Run para mantener el control sobre el ciclo de login
                            selectedForm.ShowDialog();

                            // Si el formulario se cierra, volver al login para cerrar sesión
                        }
                    }
                }
            }
        }

    }
}
