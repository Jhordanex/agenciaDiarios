﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGENCIADIARIOS
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new InicioSesion());
            //Application.Run(new frmInventarioDiarios());
            //Application.Run(new frmMaestroDiarios());
            //Application.Run(new frmReporte_Voucher());
			Application.Run(new Form2());

		}
	}
}
