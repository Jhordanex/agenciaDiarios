using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class clsConexion
    {
        public SqlConnection conexion;

        public clsConexion()
        {
            string cadenaConexion = "Data Source=.;Initial Catalog=BD_VENTA_DIARIOS;Integrated Security=True;";
            conexion = new SqlConnection(cadenaConexion);
        }

        public SqlConnection AbrirConexion()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Closed)
                    conexion.Open();
            }
            catch (SqlException ex)
            {
                // Mostrar mensaje de error si falla la conexión
                throw new Exception("Error al conectar con el servidor: " + ex.Message);
            }

            return conexion;
        }

        public void CerrarConexion()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al cerrar la conexión con el servidor: " + ex.Message);
            }
        }
    }
}
