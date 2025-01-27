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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void btnReporte_Click(object sender, EventArgs e)
		{
			int idVenta;

			if (!int.TryParse(txtIdVenta.Text, out idVenta))
			{
				MessageBox.Show("Ingrese un ID de venta válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			frmReporte_Voucher formularioReporte = new frmReporte_Voucher(idVenta);

			formularioReporte.Show();
		}
	}
}
