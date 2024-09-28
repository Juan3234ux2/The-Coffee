using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCoffe.CDatos;

namespace TheCoffe.CAccesoADatos
{
    class CategoriaDAl
    {
        public static int AgregarCategoria(CDatos.Categoria categoria)
        {
            int retorna = 0;

            using (SqlConnection  conexion = DBTheCoffee.ObtenerConexion())
            {
                string query = "insert into Categoria (descripcion) values ('"+categoria.descripcion+"')";
                SqlCommand comando = new SqlCommand(query, conexion);
                retorna = comando.ExecuteNonQuery(); 
            }
            return retorna; 
        }

        public static List<Categoria> PresentarRegistro()
        {
            List<Categoria> lista = new List<Categoria>();
            using (SqlConnection conexion = DBTheCoffee.ObtenerConexion())
            {
                string query = "SELECT * FROM Categoria";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.id_categoria = reader.GetInt32(0);
                    categoria.descripcion = reader.GetString(1);
                    lista.Add(categoria);
                }

                conexion.Close();
                return lista;
            }
        }
    }
}
