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

        public DataTable ObtenerInvtDiarios()
        {
            return datos.ObtenerInvtDiarios();
        }

        public DataTable ObtenerVentasClientes(DateTime? fechaInicio = null, DateTime? fechaFin = null, string nombre = null, int? dni = null)
        {
            return datos.ObtenerVentasClientes(fechaInicio, fechaFin, nombre, dni);
        }

        public bool EditarDiario(int idDiario, string nuevoNombreDiario)
        {
            return datos.EditarDiario(idDiario, nuevoNombreDiario);
        }

        public bool EditarInvDiario(int idInvDiario, int cantidadStock, float precioDia,int usuarioModificacion)
        {
            return datos.EditarInvDiario(idInvDiario,cantidadStock, precioDia, usuarioModificacion);
        }

        public string EliminarDiario(int iIdDiario)
        {
            return datos.EliminarDiario(iIdDiario);
        }
        public void AgregarInvDiario(int diarioSeleccionado, int stock,double precioDia, int iUsuarioRegistro)
        {
            datos.AgregarInvDiario(diarioSeleccionado, stock, precioDia, iUsuarioRegistro);
        }

        public string EliminarInvDiario(int iInvIdDiario)
        {
            return datos.EliminarInvDiario(iInvIdDiario);
        }
    }
}
