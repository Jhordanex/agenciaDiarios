using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;


namespace capaNegocio
{
    public class clsVentaNegocio
    {

        clsVentaDatos datos = new clsVentaDatos();
        public DataTable ObtenerCliente(String sIdentificadorCliente)
        {
            return datos.ObtenerCliente(sIdentificadorCliente);
        }

        public DataTable ListarPautaClienteVenta(int sIdentificadorCliente)
        {
            return datos.ListarPautaClienteVenta(sIdentificadorCliente);
        }
    }
}
