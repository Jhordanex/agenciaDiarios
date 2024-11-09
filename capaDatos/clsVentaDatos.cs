using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class clsVentaDatos
    {
        clsConexion con = new clsConexion();

        public void AgregarCliente(int iUsuario, string txtNombre, string txtApellido, int txtDni, int txtTelefono, string txtEmail, string txtSindicato)
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

        public DataTable ObtenerCliente(String sIdentificadoCliente)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_VENTA_OBTENER_CLIENTES", con.AbrirConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@peIdentificadorCliente", sIdentificadoCliente);

                    SqlDataReader reader = cmd.ExecuteReader();
                    tabla.Load(reader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el cliente: " + ex.Message);
            }
            finally
            {
                con.CerrarConexion();
            }
            return tabla;
        }

        public DataTable ListarPautaClienteVenta(int iIdentificadoCliente)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_VENTA_LISTAR_PAUTA_CLIENTE", con.AbrirConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@peIdentificadorCliente", iIdentificadoCliente);

                    SqlDataReader reader = cmd.ExecuteReader();
                    tabla.Load(reader);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error las pautas del cliente: " + ex.Message);
            }
            finally
            {
                con.CerrarConexion();
            }
            return tabla;
        }

    }
}
