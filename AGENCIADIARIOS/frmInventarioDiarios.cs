using capaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGENCIADIARIOS
{
    public partial class frmInventarioDiarios : Form
    {
		clsDiarioNegocio usuarioNegocio = new clsDiarioNegocio();

		public frmInventarioDiarios()
        {
            InitializeComponent();
        }

		private void lblNombreDiarioInventario_Click(object sender, EventArgs e)
		{

		}

		private void frmInventarioDiarios_Load(object sender, EventArgs e)
		{
			CargarCbDiarios();
        }

		private void CargarCbDiarios()
		{

			DataTable tablaDiarios = usuarioNegocio.ObtenerDiarios();

			if (tablaDiarios.Rows.Count > 0)
			{
				cbDiarios.DataSource = tablaDiarios;

				cbDiarios.DisplayMember = "nombre Diario";
				cbDiarios.ValueMember = "idDiario";
			}
			else
			{
				MessageBox.Show("No se encontraron diarios para mostrar.");
			}
		}

        private void cbDiarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
			int diarioSeleccionado, stock, cantidadConsumida;
			double precioDia;

            diarioSeleccionado = Convert.ToInt32(cbDiarios.SelectedValue.ToString());
            stock = Convert.ToInt32(txtStock.Text);
			cantidadConsumida = Convert.ToInt32(txtCantidadConsumida.Text);
            // Accede a la propiedad Text del TextBox y conviértela a double
            precioDia = Convert.ToDouble(txtPrecioDia.Text, CultureInfo.InvariantCulture);

            usuarioNegocio.AgregarIventarioDarios(diarioSeleccionado, stock, cantidadConsumida, precioDia);
            txtStock.Text = "";
            txtCantidadConsumida.Text = "";
            txtPrecioDia.Text = "";
        }
    }
}
