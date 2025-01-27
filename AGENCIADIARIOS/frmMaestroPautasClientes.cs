using capaDatos;
using capaNegocio;
using Microsoft.Build.Framework.XamlTypes;
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
    public partial class frmMaestroPautasClientes : Form
    {

        private int selectedIdPauta;
        public frmMaestroPautasClientes()
        {
            InitializeComponent();

            dataPautasClientes.CellClick += new DataGridViewCellEventHandler(dataPautasClientes_CellClick);
            dataPautasClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataPautasClientes.AllowUserToAddRows = false;
            dataPautasClientes.ReadOnly = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }
        PautasClientesNegocio pautasClientesNegocio = new PautasClientesNegocio();
        private void LimpiarCampos()
        {
            // Limpiar los campos de entrada
            cmbClientes.SelectedIndex = -1;
            cmbDiarios.SelectedIndex = -1;
            txtCantidadPromedio.Clear();
            selectedIdPauta = 0;
            rbtnFechaHoyAgregar.Checked = false;
            rbtnFechaMañanaAgregar.Checked = false;
            rbtnHoy.Checked = false;
            rbtnMañana.Checked = false;



        }
        private void CargarPautasClientes()
        {
            try
            {
                DataTable pautasClientes = pautasClientesNegocio.ListarPautasClientes();

                //int iUsuarioRegistro = VariablesGL.idUsuario;

                //Jala el ID para que llene el campo del usuario de registro
                //clientes.Columns.Add("Usuario ID", typeof(int));
                //foreach (DataRow row in clientes.Rows)
                //{
                //    row["Usuario ID"] = VariablesGL.idUsuario;  
                //}

                dataPautasClientes.DataSource = pautasClientes;

                dataPautasClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                if (pautasClientes.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron las pautas de los clientes.");
                    return;
                }
                //dataClientes.Columns["Usuario ID"].HeaderText = "Usuario Registro";

                dataPautasClientes.Columns["vchNombreCliente"].HeaderText = "Nombre del Cliente";
                dataPautasClientes.Columns["vchNombreDiario"].HeaderText = "Nombre del Diario";
                dataPautasClientes.Columns["vchCantidadpromedio"].HeaderText = "Cantidad Promedio";
                dataPautasClientes.Columns["dtFechaRegistro"].HeaderText = "Fecha del Registro";
                dataPautasClientes.Columns["dtFechaModificacion"].HeaderText = "Fecha de la Modificación";
                dataPautasClientes.Columns["iUsuarioRegistro"].HeaderText = "Usuario Registro";
                dataPautasClientes.Columns["iUsuarioModificacion"].HeaderText = "Usuario Modificación";




                dataPautasClientes.Columns["idPauta"].Visible = false;

                btnEditar.Enabled = dataPautasClientes.SelectedRows.Count > 0;
                btnEliminar.Enabled = dataPautasClientes.SelectedRows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de clientes: " + ex.Message);
            }
        }
        private void frmMaestroPautasClientes_Load(object sender, EventArgs e)
        {


            CargarPautasClientes();
            CargarClientesCombo();
            CargarDiariosCombo();
            lblNombreUser.Text = VariablesGL.Usuario;
            dataPautasClientes.ClearSelection();

        }
        private void CargarClientesCombo()
        {
            ClientesNegocio clientesNegocio = new ClientesNegocio();
            DataTable clientes = clientesNegocio.ListarClientes();

            if (clientes != null && clientes.Rows.Count > 0)
            {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = clientes;

                cmbClientes.DataSource = bindingSource;
                cmbClientes.DisplayMember = "vchNombreCliente";
                cmbClientes.ValueMember = "idCliente";

                cmbClientes.SelectedIndex = -1;

            }
            else
            {
                MessageBox.Show("No se encontraron clientes para listar.");
            }
        }
        private void CargarDiariosCombo()
        {
            ClassDatos diarioNegocio = new ClassDatos();
            DataTable diarios = diarioNegocio.ObtenerDiarios();

            if (diarios != null && diarios.Rows.Count > 0)
            {
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = diarios;

                cmbDiarios.DataSource = bindingSource;
                cmbDiarios.DisplayMember = "NOMBRE DIARIO";
                cmbDiarios.ValueMember = "idDiario";
                cmbDiarios.SelectedIndex = -1;

            }
            else
            {
                MessageBox.Show("No se encontraron diarios para listar.");
            }
        }
        private void dataPautasClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedIdPauta = Convert.ToInt32(dataPautasClientes.Rows[e.RowIndex].Cells["idPauta"].Value);

                cmbClientes.Text = dataPautasClientes.Rows[e.RowIndex].Cells["vchNombreCliente"].Value.ToString();
                cmbDiarios.Text = dataPautasClientes.Rows[e.RowIndex].Cells["vchNombreDiario"].Value.ToString();
                txtCantidadPromedio.Text = dataPautasClientes.Rows[e.RowIndex].Cells["vchCantidadpromedio"].Value.ToString();

                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;

                btnAgregar.Enabled = false;
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int usuarioRegistro = VariablesGL.idUsuario;
                DateTime fechaAgregarPauta;

                if (cmbClientes.SelectedValue == null || cmbDiarios.SelectedValue == null ||
                    string.IsNullOrEmpty(txtCantidadPromedio.Text))
                {
                    MessageBox.Show("Por favor, llenar todos los campos requeridos");
                    return;
                }
                if (rbtnFechaHoyAgregar.Checked)
                {
                    fechaAgregarPauta = DateTime.Today;
                }
                else if (rbtnFechaMañanaAgregar.Checked)
                {
                    fechaAgregarPauta = DateTime.Today.AddDays(1);
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una fecha para agregar una pauta.");
                    return;
                }


                pautasClientesNegocio.AgregarPautasClientes(
                    Convert.ToInt32(cmbClientes.SelectedValue),
                    Convert.ToInt32(cmbDiarios.SelectedValue),
                    Convert.ToInt32(txtCantidadPromedio.Text),
                    fechaAgregarPauta,
                    usuarioRegistro
                );

                MessageBox.Show("Pauta del Cliente agregada exitosamente.");

                CargarPautasClientes();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la pauta del cliente: " + ex.Message);
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int usuarioModificacion = VariablesGL.idUsuario;

                if (cmbClientes.SelectedValue == null || cmbDiarios.SelectedValue == null ||
                    string.IsNullOrEmpty(txtCantidadPromedio.Text))
                {
                    MessageBox.Show("Por favor, llenar todos los campos requeridos");
                    return;
                }

                pautasClientesNegocio.EditarPautasClientes(
                    selectedIdPauta,
                    Convert.ToInt32(cmbClientes.SelectedValue),
                    Convert.ToInt32(cmbDiarios.SelectedValue),
                    txtCantidadPromedio.Text,
                    usuarioModificacion
                );

                MessageBox.Show("Pauta del Cliente editada exitosamente.");
                CargarPautasClientes();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar la pauta del cliente: " + ex.Message);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bool camposVacios = string.IsNullOrEmpty(cmbDiarios.Text) &&
                                string.IsNullOrEmpty(cmbClientes.Text) &&
                                string.IsNullOrEmpty(txtCantidadPromedio.Text);
            string.IsNullOrEmpty(rbtnHoy.Text);
            string.IsNullOrEmpty(rbtnMañana.Text);



            if (camposVacios && selectedIdPauta == 0)
            {
                frmMenuInicio menuForm = new frmMenuInicio();
                menuForm.Show();
                this.Hide();
            }
            else
            {
                LimpiarCampos();

                btnAgregar.Enabled = true;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedIdPauta <= 0)
                {
                    MessageBox.Show("Por favor, seleccione una pauta para eliminar.");
                    return;
                }

                var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar está pauta?",
                                                    "Confirmar eliminación",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    pautasClientesNegocio.EliminarPautasCliente(selectedIdPauta);
                    MessageBox.Show("Cliente eliminado exitosamente.");
                    CargarPautasClientes();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el cliente: " + ex.Message);
            }
        }
        private void cmbDiarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool camposVacios = string.IsNullOrEmpty(cmbDiarios.Text) &&
                        string.IsNullOrEmpty(cmbClientes.Text) &&
                        string.IsNullOrEmpty(txtCantidadPromedio.Text);

            if (camposVacios && selectedIdPauta == 0)
            {
                CargarPautasClientes();
                LimpiarCampos();
                btnAgregar.Enabled = true;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            else
            {
                LimpiarCampos();
                CargarPautasClientes();
                dtpFechaFiltro.ResetText();
                btnAgregar.Enabled = true;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void rbtnHoy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {

            int idCliente = Convert.ToInt32(cmbClientes.SelectedValue);
            DateTime dtFechaRegistro = dtpFechaFiltro.Value.Date;
            DataTable pautasFiltradas = pautasClientesNegocio.FiltrarPautasClientes(idCliente, dtFechaRegistro);
            int usuarioRegistro = VariablesGL.idUsuario;
            DateTime fechaTransferencia;

            try
            {
                if (pautasFiltradas == null || pautasFiltradas.Rows.Count == 0)
                {
                    MessageBox.Show("No hay pautas filtradas para transferir.");
                    return;
                }

                if (cmbClientes.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un cliente antes de transferir las pautas.");
                    return;
                }

                if (rbtnHoy.Checked)
                {
                    fechaTransferencia = DateTime.Today;
                }
                else if (rbtnMañana.Checked)
                {
                    fechaTransferencia = DateTime.Today.AddDays(1);
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una fecha para agregar una pauta.");
                    return;
                }

                foreach (DataGridViewRow fila in dataPautasClientes.Rows)
                {
                    if (fila.Cells["idDiario"].Value != null && fila.Cells["vchCantidadpromedio"].Value != null)
                    {
                        int idDiario = Convert.ToInt32(fila.Cells["idDiario"].Value);
                        int cantidadPromedio = Convert.ToInt32(fila.Cells["vchCantidadpromedio"].Value);

                        pautasClientesNegocio.AgregarPautasClientes(
                            idCliente,
                            idDiario,
                            cantidadPromedio,
                            fechaTransferencia,
                            usuarioRegistro
                        );
                    }
                    else
                    {
                        Console.WriteLine("Fila con datos incompletos, no se procesará.");
                    }
                }

                MessageBox.Show("Las pautas filtradas se han transferido exitosamente.");
                CargarPautasClientes();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al transferir las pautas: " + ex.Message);
            }
        }

        private void btnBuscarPautas_Click(object sender, EventArgs e)
        {

            try
            {
                int idCliente = Convert.ToInt32(cmbClientes.SelectedValue);
                DateTime dtFechaRegistro = dtpFechaFiltro.Value.Date;

                DataTable pautasFiltradas = pautasClientesNegocio.FiltrarPautasClientes(idCliente, dtFechaRegistro);


                dataPautasClientes.DataSource = pautasFiltradas;
                dataPautasClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (cmbClientes.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un cliente para filtrar las pautas.");
                    return;
                }


                if (pautasFiltradas.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron pautas para este cliente en la fecha seleccionada.");
                }

                if (dataPautasClientes.Columns.Contains("idDiario"))
                {
                    dataPautasClientes.Columns["idDiario"].Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar pautas: " + ex.Message);
            }

        }
    }
}
