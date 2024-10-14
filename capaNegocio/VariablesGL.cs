using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public static class VariablesGL
    {
        // Simulación de credenciales
        public static string UsuarioSimulado= "admin";
        public static string ContraseñaSimulada = "123456";

        // Información del usuario después del login
        public static string Usuario { get; set; }
        public static string Contraseña { get; set; }
        public static bool SesionActiva { get; set; } = false;
    }
}
