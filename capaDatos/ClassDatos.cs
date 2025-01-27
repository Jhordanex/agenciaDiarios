using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace capaDatos
{
    public class ClassDatos : clsConexion
    {
        public DataTable ObtenerDiarios()
        {
            DataTable tablaDiarios = new DataTable();

            try
            {
                AbrirConexion();
                string query = "SP_LISTAR_DIARIOS";
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = comando.ExecuteReader();
                    tablaDiarios.Load(reader);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }

            return tablaDiarios;
        }

        public DataTable ObtenerInvtDiarios()
        {
            DataTable tablaDiarios = new DataTable();

            try
            {
                AbrirConexion();
                string query = "SP_LISTAR_INVENTARIO_DIARIOS";
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = comando.ExecuteReader();
                    tablaDiarios.Load(reader);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }

            return tablaDiarios;
        }

        public string ObtenerNombreUsuario(int idUser)
        {
            string nombre = string.Empty;

            try
            {
                AbrirConexion();
                string query = "SELECT vchNombreUsuario FROM Usuarios WHERE idUsuario = @idUsuario";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@idUsuario", idUser);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    nombre = reader["vchNombreUsuario"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                CerrarConexion();
            }
            return nombre;
        }

        public void AgregarDiario(string sNombreDiario, int iUsuarioCreacion)
        {
            try
            {
                AbrirConexion();
                using (SqlCommand comando = new SqlCommand("SP_AGREGAR_DIARIO", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@pevchNombreDiario", sNombreDiario);
                    comando.Parameters.AddWithValue("@peiUsuarioRegistro", iUsuarioCreacion);
                    comando.Parameters.AddWithValue("@pedtFechaRegistro", DateTime.Now);
                    comando.Parameters.AddWithValue("@peiUsuarioModificacion", iUsuarioCreacion);
                    comando.Parameters.AddWithValue("@pedtFechaModificacion", DateTime.Now);

                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }

        public void AgregarInvDiario(int diarioSeleccionado, int stock,double precioDia,int iUsuarioCreacion)
        {
            try
            {
                AbrirConexion();
                using (SqlCommand comando = new SqlCommand("SP_AGREGAR_INVENTARIO_DIARIO", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@peiCantidadStock", stock);
                    comando.Parameters.AddWithValue("@pedPrecioDia", precioDia);
                    comando.Parameters.AddWithValue("@peiIdDiario", diarioSeleccionado);
                    comando.Parameters.AddWithValue("@peiUsuarioRegistro", iUsuarioCreacion);
                    comando.Parameters.AddWithValue("@pedtFechaRegistro", DateTime.Now);
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }

        public bool EditarInvDiario(int idInvDiario, int cantidadStock, float precioDia,int usuarioModificacion)
        {
            try
            {
                AbrirConexion();
                using (SqlCommand comando = new SqlCommand("SP_EDITAR_INVENTARIO_DIARIO", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@peiIdInvDiario", idInvDiario);
                    comando.Parameters.AddWithValue("@peiCantidadStock", cantidadStock);
                    comando.Parameters.AddWithValue("@pefPrecioDia", precioDia);
                    comando.Parameters.AddWithValue("@peiUsuarioCreacion", usuarioModificacion);

                    int filasAfectadas = comando.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el registro: " + ex.Message);
                return false;
            }
            finally
            {
                CerrarConexion();
            }
        }

        public string EliminarDiario(int iIdDiario)
        {
            try
            {
                AbrirConexion();
                using (SqlCommand comando = new SqlCommand("SP_ELIMINAR_DIARIO", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@peiIdDiario", iIdDiario);

                    int filasAfectadas = comando.ExecuteNonQuery();
                    return filasAfectadas > 0 ? "Registro eliminado exitosamente." : "No se encontró el registro.";
                }
            }
            catch (Exception ex)
            {
                return "Error al eliminar el registro: " + ex.Message;
            }
            finally
            {
                CerrarConexion();
            }
        }

        public string EliminarInvDiario(int iInvIdDiario)
        {
            try
            {
                AbrirConexion();
                using (SqlCommand comando = new SqlCommand("SP_ELIMINAR_INVENTARIO_DIARIO", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@peiInvIdDiario", iInvIdDiario);

                    int filasAfectadas = comando.ExecuteNonQuery();
                    return filasAfectadas > 0 ? "Registro eliminado exitosamente." : "No se encontró el registro.";
                }
            }
            catch (Exception ex)
            {
                return "Error al eliminar el registro: " + ex.Message;
            }
            finally
            {
                CerrarConexion();
            }
        }

        public bool EditarDiario(int idDiario, string nuevoNombreDiario)
        {
            try
            {
                AbrirConexion();
                using (SqlCommand comando = new SqlCommand("SP_EDITAR_DIARIO", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@peiIdDiario", idDiario);
                    comando.Parameters.AddWithValue("@pevchNuevoNombreDiario", nuevoNombreDiario);
                    comando.Parameters.AddWithValue("@pedtFechaModificacion", DateTime.Now);

                    int filasAfectadas = comando.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el registro: " + ex.Message);
                return false;
            }
            finally
            {
                CerrarConexion();
            }
        }
    }
}
