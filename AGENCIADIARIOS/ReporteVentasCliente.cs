using capaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGENCIADIARIOS
{
    public partial class ReporteVentasCliente : Form
    {
        clsDiarioNegocio usuarioNegocio = new clsDiarioNegocio();

        public ReporteVentasCliente()
        {
            InitializeComponent();
        }

        private void ReporteVentasClientecs_Load(object sender, EventArgs e)
        {
            dtFechaInicio.Checked = false;   
            dtFechaFin.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = string.IsNullOrWhiteSpace(txtNombre.Text) ? null : txtNombre.Text;
            int? dni = string.IsNullOrWhiteSpace(txtDni.Text) ? (int?)null : Convert.ToInt32(txtDni.Text);
            DateTime? fechaInicio = dtFechaInicio.Checked ? dtFechaInicio.Value : (DateTime?)null;
            DateTime? fechaFin = dtFechaFin.Checked ? dtFechaFin.Value : (DateTime?)null;

            DataTable dgvReportVentasCliente = usuarioNegocio.ObtenerVentasClientes(fechaInicio, fechaFin, nombre, dni);
            dtgReportVentasClientes.DataSource = dgvReportVentasCliente;
        }
    }
}
