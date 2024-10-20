using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace capaDatos
{
    public class ClientesDatos
    {
        clsConexion con = new clsConexion();

        public void AgregarCliente(string txtNombre, string txtApellido, int txtDni, int txtTelefono, string txtEmail)
        {
            using (SqlCommand cmd = new SqlCommand("SP_AGREGAR_CLIENTES", con.AbrirConexion()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pevchNombreCliente", txtNombre);
                cmd.Parameters.AddWithValue("@pevchApellidoCliente", txtApellido);
                cmd.Parameters.AddWithValue("@peDNI", txtDni);
                cmd.Parameters.AddWithValue("@petelefono", txtTelefono);
                cmd.Parameters.AddWithValue("@pevchEmailCliente", txtEmail);
                cmd.ExecuteNonQuery();
                con.CerrarConexion();
            }
        }
        public DataTable ListarClientes()
        {
            DataTable tabla = new DataTable();
            using (SqlCommand cmd = new SqlCommand("SP_LISTAR_CLIENTES", con.AbrirConexion()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();
                tabla.Load(reader);
                con.CerrarConexion();
            }
            return tabla;
        }

        public void EditarCliente( int idCliente,string txtNombre, string txtApellido, int txtDni, int txtTelefono, string txtEmail)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_EDITAR_CLIENTES", con.AbrirConexion());

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCliente", idCliente);
                cmd.Parameters.AddWithValue("@vchNombreCliente", txtNombre);
                cmd.Parameters.AddWithValue("@vchApellidoCliente", txtApellido);
                cmd.Parameters.AddWithValue("@DNI", txtDni);
                cmd.Parameters.AddWithValue("@telefono", txtTelefono);
                cmd.Parameters.AddWithValue("@vchEmailCliente", txtEmail);
                cmd.ExecuteNonQuery();
                con.CerrarConexion();
            }
            catch (Exception ex) {

                throw new Exception("Error al editar el cliente: " + ex.Message);

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
                con.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el cliente: " + ex.Message);
            }
        }


    }
}
