using System;
using System.Data;
using System.Data.SqlClient;
using capaDatos; 

namespace capaNegocio
{
    public class UsuarioNegocio
    {
        public string ValidarUsuario(string usuario, string contraseña)
        {
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                return "Credenciales incorrectas. Por favor, rellene ambos campos.";
            }

            try
            {
                // Instancia de clsConexion
                clsConexion conexionDB = new clsConexion();
                SqlConnection connection = conexionDB.AbrirConexion();

                using (SqlCommand command = new SqlCommand("SP_VALIDAR_USUARIO", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@Contraseña", contraseña);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int usuarioId = reader.GetInt32(0);
                            string usuarioIngresado = reader.GetString(1);
                            string contraseñaAlmacenada = reader.GetString(2);

                            if (contraseñaAlmacenada == contraseña)
                            {
                                VariablesGL.Usuario = usuarioIngresado;
                                VariablesGL.idUsuario = usuarioId;

                                return "Acceso concedido.";
                            }
                            else
                            {
                                return "Contraseña incorrecta.";
                            }
                        }
                        else
                        {
                            return "Usuario no encontrado.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error al intentar conectar con la base de datos: {ex.Message}";
            }
            finally
            {
                clsConexion conexion = new clsConexion();
                conexion.CerrarConexion();
            
            }
        }
    }
}
