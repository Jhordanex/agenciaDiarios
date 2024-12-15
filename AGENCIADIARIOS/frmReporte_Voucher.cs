using Microsoft.Reporting.WinForms;
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
    public partial class frmReporte_Voucher : Form
    {
		private int _idVenta;

		public frmReporte_Voucher(int idVenta)
		{
			InitializeComponent();
			_idVenta = idVenta; 
		}

		public frmReporte_Voucher()
		{
		}

		private void frmReporte_Voucher_Load(object sender, EventArgs e)
		{
			try
			{
				this.sP_REPORTE_VOUCHERTableAdapter.Fill(this.bD_VENTA_DIARIOSDataSet.SP_REPORTE_VOUCHER, _idVenta);
				// Refrescar el reporte
				this.reportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Ocurrió un error al cargar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnReporte_Click(object sender, EventArgs e)
		{
			//int idVenta;

			//try
			//{
			//	// Validar que el ID ingresado sea un número
			//	if (!int.TryParse(txtIdVenta.Text, out idVenta))
			//	{
			//		MessageBox.Show("Ingrese un ID de venta válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//		return;
			//	}

			//	// Llenar el dataset con el parámetro
			//	this.sP_REPORTE_VOUCHERTableAdapter.Fill(this.bD_VENTA_DIARIOSDataSet.SP_REPORTE_VOUCHER, idVenta);

			//	// Refrescar el reporte
			//	this.reportViewer1.RefreshReport();
			//}
			//catch (Exception ex)
			//{
			//	MessageBox.Show($"Ocurrió un error al generar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//}
		}
	}
}
