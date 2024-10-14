using System;
using System.Windows.Forms;

namespace AGENCIADIARIOS
{
    public partial class ClientesForm : Form
    {
        private int selectedIdCliente; // Variable para almacenar el ID del cliente seleccionado

        public ClientesForm()
        {
            InitializeComponent();
            dataClientes.CellClick += new DataGridViewCellEventHandler(dataClientes_CellClick); // Asignar el evento
            dataClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleccionar toda la fila
            dataClientes.AllowUserToAddRows = false;
            dataClientes.ReadOnly = false; // Asegúrate de que no esté en modo solo lectura

        }

        ClientesNegocio clientesNegocio = new ClientesNegocio();
        private void CargarClientes()
        {
            try
            {
                dataClientes.DataSource = clientesNegocio.ListarClientes();
                dataClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de clientes: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            // Limpiar los campos de entrada
            txtNombreCliente.Clear();
            txtApellidoCliente.Clear();
            txtDni.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombreCliente.Text) ||
                    string.IsNullOrEmpty(txtApellidoCliente.Text) ||
                    string.IsNullOrEmpty(txtDni.Text) ||
                    string.IsNullOrEmpty(txtEmail.Text) ||
                    string.IsNullOrEmpty(txtTelefono.Text))
                {
                    MessageBox.Show("Por favor, llenar todos los campos requeridos");
                    return;
                }

                clientesNegocio.AgregarCliente(
                    txtNombreCliente.Text,
                    txtApellidoCliente.Text,
                    Convert.ToInt32(txtDni.Text),
                    Convert.ToInt32(txtTelefono.Text),
                    txtEmail.Text
                    //iUsuarioRegistro
                );

                MessageBox.Show("Cliente agregado exitosamente.");

                CargarClientes();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el cliente: " + ex.Message);
            }
        }
        private void ClientesForm_Load(object sender, EventArgs e)
        {

            CargarClientes();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombreCliente.Text) ||
                    string.IsNullOrEmpty(txtApellidoCliente.Text) ||
                    string.IsNullOrEmpty(txtDni.Text) ||
                    string.IsNullOrEmpty(txtEmail.Text) ||
                    string.IsNullOrEmpty(txtTelefono.Text))
                {
                    MessageBox.Show("Por favor, llenar todos los campos requeridos");
                    return;
                }

                
                // Llama al método para editar el cliente usando el ID almacenado
                
                clientesNegocio.EditarCliente(
                    selectedIdCliente, // Usa la variable almacenada
                    txtNombreCliente.Text,
                    txtApellidoCliente.Text,
                    Convert.ToInt32(txtDni.Text),
                    Convert.ToInt32(txtTelefono.Text),
                    txtEmail.Text
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
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
        }

        private void dataClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                selectedIdCliente = Convert.ToInt32(dataClientes.Rows[e.RowIndex].Cells["idCliente"].Value);

                txtNombreCliente.Text = dataClientes.Rows[e.RowIndex].Cells["vchNombreCliente"].Value.ToString();
                txtApellidoCliente.Text = dataClientes.Rows[e.RowIndex].Cells["vchApellidoCliente"].Value.ToString();
                txtDni.Text = dataClientes.Rows[e.RowIndex].Cells["DNI"].Value.ToString();
                txtTelefono.Text = dataClientes.Rows[e.RowIndex].Cells["telefono"].Value.ToString();
                txtEmail.Text = dataClientes.Rows[e.RowIndex].Cells["vchEmailCliente"].Value.ToString();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedIdCliente <= 0) // Verificar si hay un cliente seleccionado
                {
                    MessageBox.Show("Por favor, seleccione un cliente para eliminar.");
                    return;
                }

                // Confirmar la eliminación
                var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este cliente?",
                                                     "Confirmar eliminación",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    clientesNegocio.EliminarCliente(selectedIdCliente); // Llamar al método que elimina el cliente

                    MessageBox.Show("Cliente eliminado exitosamente.");
                    CargarClientes(); // Volver a cargar la lista de clientes
                    LimpiarCampos(); // Limpiar los campos
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el cliente: " + ex.Message);
            }
        }
    }
}
