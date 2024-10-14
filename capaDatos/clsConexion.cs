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
            string cadenaConexion = "Server=DESKTOP-FJAOIAQ;Database=BD_VENTA_DIARIOS;Trusted_Connection=True;";
            conexion = new SqlConnection(cadenaConexion);
        }

        public SqlConnection AbrirConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
                conexion.Open();
            Console.WriteLine("CONEXIÓN ABIERTA");
            return conexion;
        }

        public void CerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();
        }
    }
}
