using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;

namespace capaNegocio
{
    public class clsDiarioNegocio
    {
        private ClassDatos datos = new ClassDatos();

        public string ObtenerNombreUsuario(int idUser)
        {
            return datos.ObtenerNombreUsuario(idUser);
        }

        public void AgregarDiario(string sNombreDiario, int iUsuarioRegistro)
        {
            datos.AgregarDiario(sNombreDiario, iUsuarioRegistro);
        }

        public DataTable ObtenerDiarios()
        {
            return datos.ObtenerDiarios();
        }

        public bool EditarDiario(int idDiario, string nuevoNombreDiario)
        {
            return datos.EditarDiario(idDiario, nuevoNombreDiario);
        }

        public string EliminarDiario(int iIdDiario)
        {
            return datos.EliminarDiario(iIdDiario);
        }
        public void AgregarIventarioDarios(int diarioSeleccionado, int stock,int cantidadConsumida,double precioDia)
        {
            datos.AgregarDiario(diarioSeleccionado, stock, cantidadConsumida, precioDia);
        }
    }
}
