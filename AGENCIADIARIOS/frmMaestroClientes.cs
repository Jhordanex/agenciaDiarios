using capaNegocio;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AGENCIADIARIOS
{
    public partial class frmMaestroClientes : Form
    {
        private int selectedIdCliente;

        public frmMaestroClientes()
        {
            InitializeComponent();
            dataClientes.CellClick += new DataGridViewCellEventHandler(dataClientes_CellClick);
            dataClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataClientes.AllowUserToAddRows = false;
            dataClientes.ReadOnly = true; 
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        ClientesNegocio clientesNegocio = new ClientesNegocio();

        private void CargarClientes()
        {
            try
            {
                DataTable clientes = clientesNegocio.ListarClientes();

                //int iUsuarioRegistro = VariablesGL.idUsuario;

                //Jala el ID para que llene el campo del usuario de registro
                //clientes.Columns.Add("Usuario ID", typeof(int));
                //foreach (DataRow row in clientes.Rows)
                //{
                //    row["Usuario ID"] = VariablesGL.idUsuario;  
                //}

                dataClientes.DataSource = clientes;
                dataClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                if (clientes.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron clientes.");
                    return;
                }
                //dataClientes.Columns["Usuario ID"].HeaderText = "Usuario Registro";
                dataClientes.Columns["iUsuarioRegistro"].HeaderText = "Usuario Registro";
                dataClientes.Columns["iUsuarioModificacion"].HeaderText = "Usuario Modificacion";
                dataClientes.Columns["idCliente"].HeaderText = "ID Cliente";
                dataClientes.Columns["vchNombreCliente"].HeaderText = "Nombre";
                dataClientes.Columns["vchApellidoCliente"].HeaderText = "Apellido";
                dataClientes.Columns["vchDNI"].HeaderText = "DNI";
                dataClientes.Columns["vchTelefono"].HeaderText = "Teléfono";
                dataClientes.Columns["vchEmailCliente"].HeaderText = "Email";
                dataClientes.Columns["dFechaModificacion"].HeaderText = "Fecha Modificación";
                dataClientes.Columns["dtFechaRegistro"].HeaderText = "Fecha del Registro";
                dataClientes.Columns["vchSindicato"].HeaderText = "Sindicato";




                dataClientes.Columns["idCliente"].Visible = false;

                btnEditar.Enabled = dataClientes.SelectedRows.Count > 0;
                btnEliminar.Enabled = dataClientes.SelectedRows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de clientes: " + ex.Message);
            }
        }

        private void frmMaestroClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
            lblNombreUser.Text = VariablesGL.Usuario;
        }

        private void LimpiarCampos()
        {
            // Limpiar los campos de entrada
            txtNombreCliente.Clear();
            txtApellidoCliente.Clear();
            txtDni.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            cmbSindicato.SelectedIndex = -1;  // Deselecciona cualquier opción
            selectedIdCliente = 0; 
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int usuarioRegistro = VariablesGL.idUsuario;

                if (string.IsNullOrEmpty(txtNombreCliente.Text) ||
                    string.IsNullOrEmpty(txtApellidoCliente.Text) ||
                    string.IsNullOrEmpty(txtDni.Text) ||
                    string.IsNullOrEmpty(txtEmail.Text) ||
                    string.IsNullOrEmpty(txtTelefono.Text) ||
                    string.IsNullOrEmpty(cmbSindicato.Text))

                {
                    MessageBox.Show("Por favor, llenar todos los campos requeridos");
                    return;
                }


                clientesNegocio.AgregarCliente(
                    usuarioRegistro,
                    txtNombreCliente.Text,
                    txtApellidoCliente.Text,
                    Convert.ToInt32(txtDni.Text),
                    Convert.ToInt32(txtTelefono.Text),
                    txtEmail.Text,
                    cmbSindicato.Text
                    
                );

                MessageBox.Show("Cliente agregado exitosamente.");

                CargarClientes();
                LimpiarCampos();

                btnAgregar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el cliente: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int usuarioModifacion = VariablesGL.idUsuario;

                if (string.IsNullOrEmpty(txtNombreCliente.Text) ||
                    string.IsNullOrEmpty(txtApellidoCliente.Text) ||
                    string.IsNullOrEmpty(txtDni.Text) ||
                    string.IsNullOrEmpty(txtEmail.Text) ||
                    string.IsNullOrEmpty(txtTelefono.Text) ||
                    string.IsNullOrEmpty(cmbSindicato.Text))
                {
                    MessageBox.Show("Por favor, llenar todos los campos requeridos");
                    return;
                }

                clientesNegocio.EditarCliente(
                    selectedIdCliente,
                    txtNombreCliente.Text,
                    txtApellidoCliente.Text,
                    Convert.ToInt32(txtDni.Text),
                    Convert.ToInt32(txtTelefono.Text),
                    txtEmail.Text,
                    cmbSindicato.Text,
                    usuarioModifacion
                );

                MessageBox.Show("Cliente editado exitosamente.");
                CargarClientes();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el cliente: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bool camposVacios = string.IsNullOrEmpty(txtNombreCliente.Text) &&
                                string.IsNullOrEmpty(txtApellidoCliente.Text) &&
                                string.IsNullOrEmpty(txtDni.Text) &&
                                string.IsNullOrEmpty(txtTelefono.Text) &&
                                string.IsNullOrEmpty(txtEmail.Text) &&
                                string.IsNullOrEmpty(cmbSindicato.Text);

            if (camposVacios && selectedIdCliente == 0)
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

        private void dataClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedIdCliente = Convert.ToInt32(dataClientes.Rows[e.RowIndex].Cells["idCliente"].Value);

                txtNombreCliente.Text = dataClientes.Rows[e.RowIndex].Cells["vchNombreCliente"].Value.ToString();
                txtApellidoCliente.Text = dataClientes.Rows[e.RowIndex].Cells["vchApellidoCliente"].Value.ToString();
                txtDni.Text = dataClientes.Rows[e.RowIndex].Cells["vchDNI"].Value.ToString();
                txtTelefono.Text = dataClientes.Rows[e.RowIndex].Cells["vchTelefono"].Value.ToString();
                txtEmail.Text = dataClientes.Rows[e.RowIndex].Cells["vchEmailCliente"].Value.ToString();
                cmbSindicato.Text = dataClientes.Rows[e.RowIndex].Cells["vchSindicato"].Value.ToString();

                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;

                btnAgregar.Enabled = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedIdCliente <= 0)
                {
                    MessageBox.Show("Por favor, seleccione un cliente para eliminar.");
                    return;
                }

                var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este cliente?",
                                                    "Confirmar eliminación",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    clientesNegocio.EliminarCliente(selectedIdCliente);
                    MessageBox.Show("Cliente eliminado exitosamente.");
                    CargarClientes();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el cliente: " + ex.Message);
            }
        }

        private void dataClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblNombreUser_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
