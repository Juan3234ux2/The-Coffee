using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCoffe.CDatos
{
    public class DBTheCoffee
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TheCoffee;Data Source=DESKTOP-F6IRILK\\SQL2");
            conexion.Open();
            return conexion;
        }
    }
}
