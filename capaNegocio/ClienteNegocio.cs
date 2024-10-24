using System.Data;
using capaDatos;
using capaNegocio;
public class ClientesNegocio
{
    ClientesDatos datos = new ClientesDatos();

    public void AgregarCliente(int iUsuario,string txtNombre, string txtApellido, int txtDni, int txtTelefono, string txtEmail,string cmbSindicato)
    {
        datos.AgregarCliente(iUsuario,txtNombre, txtApellido, txtDni, txtTelefono, txtEmail,cmbSindicato);
    }

   public DataTable ListarClientes()
    {
        return datos.ListarClientes();
    }

   public void EditarCliente(int idCliente, string txtNombre, string txtApellido, int txtDni, int txtTelefono, string txtEmail, string cmbSindicato)
    {
        datos.EditarCliente(idCliente,txtNombre, txtApellido, txtDni, txtTelefono, txtEmail,cmbSindicato);
    }

    public void EliminarCliente(int idCliente)
    {
        datos.EliminarCliente(idCliente);
    }
}
