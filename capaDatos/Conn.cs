using System;
using System.Data.SqlClient;

namespace capaDatos
{
    public class Conexion
    {
        private SqlConnection con;

        public Conexion()
        {
            string connectionString = "Data Source=LAPTOP-1KOC4VAP;Initial Catalog=BD_VENTA_DIARIOS;Integrated Security=True;";
            con = new SqlConnection(connectionString);
        }

        public SqlConnection AbrirConexion()
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                    con.Open();
            }
            catch (SqlException ex)
            {
                // Mostrar mensaje de error si falla la conexión
                throw new Exception("Error al conectar con el servidor: " + ex.Message);
            }

            return con;
        }

        public void CerrarConexion()
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
            catch (SqlException ex)
            {
                // Mostrar mensaje de error si falla el cierre de la conexión
                throw new Exception("Error al cerrar la conexión con el servidor: " + ex.Message);
            }
        }
    }
}
