using System;
using System.Data;
using System.Data.SqlClient;  // Asegúrate de tener esta referencia para SQL Server

namespace capaNegocio
{
    public class UsuarioNegocio
    {   
        //CAMBIAR EL SERVIDOR Y LA BASE DE DATOS DE ACUERDO A DONDE SE CORRA EL PROGRAMA

        private string connectionString = "Data Source=.;Initial Catalog=BD_VENTA_DIARIOS;Integrated Security=True;";

        public string ValidarUsuario(string usuario, string contraseña)
        {
            // Validaciones iniciales
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                return "Credenciales incorrectas. Por favor, rellene ambos campos.";
            }

            try
            {
                // Establecer conexión a la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Crear consulta SQL para buscar el usuario
                    string query = "SELECT vchPassword FROM Usuarios WHERE vchNombreUsuario = @Usuario";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parámetro para evitar inyección SQL
                        command.Parameters.AddWithValue("@Usuario", usuario);

                        // Ejecutar la consulta
                        object result = command.ExecuteScalar();

                        // Si no se encuentra el usuario
                        if (result == null)
                        {
                            return "Usuario no encontrado.";
                        }

                        // Comparar la contraseña ingresada con la de la base de datos
                        string contraseñaAlmacenada = result.ToString();

                        if (contraseñaAlmacenada == contraseña)
                        {
                            return "Acceso concedido.";
                        }
                        else
                        {
                            return "Contraseña incorrecta.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Capturar cualquier error en la conexión o consulta a la base de datos
                return $"Error al intentar conectar con la base de datos: {ex.Message}";
            }
        }
    }
}
