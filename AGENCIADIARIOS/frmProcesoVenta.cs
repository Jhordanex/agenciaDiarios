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
    public partial class frmProcesoVenta : Form
    {
        public frmProcesoVenta()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ibtnBuscarCliente_Click(object sender, EventArgs e)
        {

            String sIdentificadorCliente = txtCodigoCliente.Text;
            clsVentaNegocio ventaNeg = new clsVentaNegocio();

            try
            {
                DataTable dtCliente = ventaNeg.ObtenerCliente(sIdentificadorCliente);
                //dataClientes.DataSource = dtCliente;
                //dataClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                if (dtCliente.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraró cliente.");
                    return;
                }
                string sNombres = dtCliente.Rows[0].Field<string>(2);
                string sApellidos = dtCliente.Rows[0].Field<string>(3);
                string sDni = dtCliente.Rows[0].Field<string>(4);
                int idCliente =  int.Parse(dtCliente.Rows[0].Field<string>(1));

                txtDni.Text = sDni;
                txtNombreCliente.Text = sNombres;
                txtApellidosCliente.Text = sApellidos;


                DataTable dtPautaClienteVenta = ventaNeg.ListarPautaClienteVenta(idCliente);
                dataClientes.DataSource = dtPautaClienteVenta;
                dataClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataClientes.Columns["vchNombreDiario"].HeaderText = "Diario";
                dataClientes.Columns["iPautaPromedioAyer"].HeaderText = "Pauta Ayer";
                dataClientes.Columns["devolucion"].HeaderText = "Devolucion";
                dataClientes.Columns["vchCantidadpromedio"].HeaderText = "Pauta Hoy";

                //dataClientes.Columns["Usuario ID"].HeaderText = "Usuario Registro";
                //dataClientes.Columns["iUsuarioRegistro"].HeaderText = "Usuario Registro";
                //dataClientes.Columns["idCliente"].HeaderText = "ID Cliente";
                //dataClientes.Columns["vchNombreCliente"].HeaderText = "Nombre";
                //dataClientes.Columns["vchApellidoCliente"].HeaderText = "Apellido";
                //dataClientes.Columns["vchDNI"].HeaderText = "DNI";
                //dataClientes.Columns["vchTelefono"].HeaderText = "Teléfono";
                //dataClientes.Columns["vchEmailCliente"].HeaderText = "Email";
                //dataClientes.Columns["dFechaModificacion"].HeaderText = "Fecha Modificación";
                //dataClientes.Columns["vchSindicato"].HeaderText = "Sindicato";

                dataClientes.Columns["idCliente"].Visible = false;
                dataClientes.Columns["idDiario"].Visible = false;
                dataClientes.Columns["idPauta"].Visible = false;
                dataClientes.Columns["idPautaAyer"].Visible = false;


                //btnEditar.Enabled = dataClientes.SelectedRows.Count > 0;
                //btnEliminar.Enabled = dataClientes.SelectedRows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar cliente: " + ex.Message);
            }

        }
    }
}
