using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheCoffe.CAccesoADatos
{
   
    class BackupRepository
    {

        public void Backup()
        {
            SqlConnection conexion = new SqlConnection("Server=DESKTOP-F6IRILK\\SQL2;Database=marketplaces;Integrated Security=True;");

            string nombre_copia = (System.DateTime.Today.Day.ToString() + "-" + System.DateTime.Today.Month.ToString() + "-" + System.DateTime.Today.Year.ToString() + "-" + System.DateTime.Now.Hour.ToString() + "-" + System.DateTime.Now.Minute.ToString() + "-" + System.DateTime.Now.Second.ToString() + " TheCoffee");

            string comando_consulta = "BACKUP DATABASE [TheCoffee] TO  DISK = N'C:\\backup\\" + nombre_copia + "' WITH NOFORMAT, NOINIT,  NAME = N'TheCoffee-Completa Base de datos Copia de seguridad', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";

            SqlCommand cmd = new SqlCommand(comando_consulta, conexion);

            try
            {
                conexion.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("La copia se ha creado satifactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Si desea realizar otra copia de seguridad,  por favor cierre el formulario e intente de nuevo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }
        }

        public void Restore(OpenFileDialog openFileDialog1)
        {
            openFileDialog1.Title = "Selecciona el archivo de Backup";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string backupFilePath = openFileDialog1.FileName;

                string connectionString = "Server=DESKTOP-F6IRILK\\SQL2;Integrated Security=True;";

                string restoreQuery = $@"
                    RESTORE DATABASE  [TheCoffee] 
                    FROM DISK = '{backupFilePath}'
                    WITH REPLACE";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(restoreQuery, connection))
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Base de datos restaurada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
