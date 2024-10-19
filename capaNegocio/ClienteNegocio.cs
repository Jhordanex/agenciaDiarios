using System.Data;
using capaDatos;
public class ClientesNegocio
{
    ClientesDatos datos = new ClientesDatos();

    public void AgregarCliente(string txtNombre, string txtApellido, int txtDni, int txtTelefono, string txtEmail)
    {
        datos.AgregarCliente(txtNombre, txtApellido, txtDni, txtTelefono, txtEmail);
    }

   public DataTable ListarClientes()
    {
        return datos.ListarClientes();
    }

   public void EditarCliente(int idCliente, string txtNombre, string txtApellido, int txtDni, int txtTelefono, string txtEmail)
    {
        datos.EditarCliente(idCliente,txtNombre, txtApellido, txtDni, txtTelefono, txtEmail);
    }

    public void EliminarCliente(int idCliente)
    {
        datos.EliminarCliente(idCliente);
    }
}
