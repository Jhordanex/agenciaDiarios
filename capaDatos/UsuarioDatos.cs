using System.Data.SqlClient;

namespace capaDatos
{
    public class UsuariosDatos
    {
        private clsConexion conexion = new clsConexion();
        private SqlCommand comando = new SqlCommand();

        // Método para validar el inicio de sesión
        public bool ValidarUsuario(string nombreUsuario, string contrasena)
        {
            SqlDataReader reader;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @nombreUsuario AND Contrasena = @contrasena";
            comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
            comando.Parameters.AddWithValue("@contrasena", contrasena);
            int count = (int)comando.ExecuteScalar();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return count > 0;
        }
    }
}
