using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace capaDatos
{
    public class ClientesDatos
    {
        clsConexion con = new clsConexion();

        public void AgregarCliente(int iUsuario,string txtNombre, string txtApellido, int txtDni, int txtTelefono, string txtEmail,string txtSindicato)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_AGREGAR_CLIENTES", con.AbrirConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@peiUsuario", iUsuario);
                    cmd.Parameters.AddWithValue("@pevchNombreCliente", txtNombre);
                    cmd.Parameters.AddWithValue("@pevchApellidoCliente", txtApellido);
                    cmd.Parameters.AddWithValue("@pevchDNI", txtDni);
                    cmd.Parameters.AddWithValue("@pevchTelefono", txtTelefono);
                    cmd.Parameters.AddWithValue("@pevchEmailCliente", txtEmail);
                    cmd.Parameters.AddWithValue("@pevchSindicato", txtSindicato);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el cliente: " + ex.Message);
            }
            finally
            {
                con.CerrarConexion();
            }
        }

        public DataTable ListarClientes()
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_LISTAR_CLIENTES", con.AbrirConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader();
                    tabla.Load(reader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar clientes: " + ex.Message);
            }
            finally
            {
                con.CerrarConexion();
            }
            return tabla;
        }

        public void EditarCliente(
            int idCliente, string txtNombre, string txtApellido, int txtDni, int txtTelefono, 
            string txtEmail, string cmbSindicato, int iUsuarioModificacion)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_EDITAR_CLIENTES", con.AbrirConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idCliente", idCliente);
                    cmd.Parameters.AddWithValue("@vchNombreCliente", txtNombre);
                    cmd.Parameters.AddWithValue("@vchApellidoCliente", txtApellido);
                    cmd.Parameters.AddWithValue("@vchDNI", txtDni);
                    cmd.Parameters.AddWithValue("@vchTelefono", txtTelefono);
                    cmd.Parameters.AddWithValue("@vchEmailCliente", txtEmail);
                    cmd.Parameters.AddWithValue("@vchSindicato", cmbSindicato);
                    cmd.Parameters.AddWithValue("@iUsuarioModificacion", iUsuarioModificacion);





                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar el cliente: " + ex.Message);
            }
            finally
            {
                con.CerrarConexion();
            }
        }

        public void EliminarCliente(int idCliente)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_ELIMINAR_CLIENTE", con.AbrirConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idCliente", idCliente);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el cliente: " + ex.Message);
            }
            finally
            {
                con.CerrarConexion();
            }
        }
    }
}
