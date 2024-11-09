using System.Data;
using capaDatos;
using capaNegocio;
public class PautasClientesNegocio
{
    PautasClienteDatos pautasClientes = new PautasClienteDatos();

    public void AgregarPautasClientes(int iCliente, int iDiario, int txtCantidadPromedio, int iUsuarioRegistro)
    {
        pautasClientes.AgregarPautasClientes(iCliente, iDiario, txtCantidadPromedio, iUsuarioRegistro);
    }


    public DataTable ListarPautasClientes()
    {
        return pautasClientes.ListarPautasClientes();
    }

    public void EditarPautasClientes(
        int idPauta, int iCliente, int iDiario, string txtCantidadPromedio,
        int iUsuarioModificacion)
    {
        pautasClientes.EditarPautasCliente(idPauta, iCliente, iDiario, txtCantidadPromedio, iUsuarioModificacion);
    }

    //public void EliminarCliente(int idCliente)
    //{
    //    datos.EliminarCliente(idCliente);
    //}
}
