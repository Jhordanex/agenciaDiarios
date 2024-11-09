using System;
using System.Data.SqlClient;
using System.Data;

namespace capaDatos
{
    public class PautasClienteDatos
    {
        clsConexion con = new clsConexion();

        public void AgregarPautasClientes(int iCliente, int iDiario, int txtCantidadPromedio, int iUsuarioRegistro)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_AGREGAR_PAUTAS_CLIENTES", con.AbrirConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@peiCliente", iCliente);
                    cmd.Parameters.AddWithValue("@peiDiario", iDiario);
                    cmd.Parameters.AddWithValue("@pevchCantidadPromedio", txtCantidadPromedio);
                    cmd.Parameters.AddWithValue("@peiUsuarioRegistro", iUsuarioRegistro);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar una pauta del cliente: " + ex.Message);
            }
            finally
            {
                con.CerrarConexion();
            }
        }

        public DataTable ListarPautasClientes()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_LISTAR_PAUTAS_CLIENTES", con.AbrirConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader();
                    tabla.Load(reader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar las pautas del cliente: " + ex.Message);
            }
            finally
            {
                con.CerrarConexion();
            }
            return tabla;
        }

        public void EditarPautasCliente(
            int idPauta, int iCliente, int iDiario, string vchCantidadPromedio, int iUsuarioModificacion)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_EDITAR_PAUTAS_CLIENTES", con.AbrirConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idPauta", idPauta);
                    cmd.Parameters.AddWithValue("@iCliente", iCliente);
                    cmd.Parameters.AddWithValue("@iDiario", iDiario);
                    cmd.Parameters.AddWithValue("@vchCantidadPromedio", vchCantidadPromedio);
                    cmd.Parameters.AddWithValue("@iUsuarioModificacion", iUsuarioModificacion);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar la pauta del cliente: " + ex.Message);
            }
            finally
            {
                con.CerrarConexion();
            }
        }

        public void EliminarPautasCliente(int idPauta)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_ELIMINAR_PAUTAS_CLIENTE", con.AbrirConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idPauta", idPauta);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la pauta: " + ex.Message);
            }
            finally
            {
                con.CerrarConexion();
            }
        }
    }
}
