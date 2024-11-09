using capaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
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
            cbDiarios.Enabled = false;
            txtStock.Enabled = false;
            txtPrecioDia.Enabled = false;
            btnAgregar.Text = "Nuevo";

            string snombre = usuarioNegocio.ObtenerNombreUsuario(1);

            if (!string.IsNullOrEmpty(snombre))
            {
                lblNombreUser.Text = snombre;
            }
            else
            {
                lblNombreUser.Text = "Usuario no encontrado.";
            }
        }

        private void CargarCbDiarios()
        {
            DataTable comboDiarios = usuarioNegocio.ObtenerDiarios();
            DataTable tablaInvDiarios = usuarioNegocio.ObtenerInvtDiarios();

            if (tablaInvDiarios.Rows.Count > 0)
            {
                cbDiarios.DataSource = comboDiarios;

                cbDiarios.DisplayMember = "nombre Diario";
                cbDiarios.ValueMember = "idDiario";

                dtgInvDiarios.DataSource = tablaInvDiarios;
                dtgInvDiarios.Columns["idInventario"].Visible = false;
                dtgInvDiarios.Columns["idDiario"].Visible = false;
            }
            else
            {
                MessageBox.Show("No se encontraron diarios para mostrar.");
            }
        }

        private void cbDiarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            cbDiarios.Enabled = true;
            txtStock.Enabled = true;
            txtPrecioDia.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            if (btnAgregar.Text == "Agregar" &&
                (string.IsNullOrWhiteSpace(cbDiarios.SelectedValue?.ToString()) ||
                string.IsNullOrWhiteSpace(txtStock.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioDia.Text)))
            {
                MessageBox.Show("INGRESE TODOS LOS DATOS");
            }
            else
            {
                if (btnAgregar.Text == "Nuevo")
                {

                }
                else
                {
                    int diarioSeleccionado, stock;
                    double precioDia;

                    diarioSeleccionado = Convert.ToInt32(cbDiarios.SelectedValue.ToString());
                    stock = Convert.ToInt32(txtStock.Text);
                    precioDia = Convert.ToDouble(txtPrecioDia.Text, CultureInfo.InvariantCulture);
                    usuarioNegocio.AgregarInvDiario(diarioSeleccionado, stock, precioDia, VariablesGL.idUsuario); 
                    cbDiarios.Enabled = false;
                    txtStock.Enabled = false;
                    txtPrecioDia.Enabled = false;
                    txtStock.Text = "";
                    txtPrecioDia.Text = "";
                    MessageBox.Show("AGREGADO CORRECTAMENTE");
                }
            }
            btnAgregar.Text = "Agregar";
            txtStock.Focus();
            CargarCbDiarios();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dtgInvDiarios.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int iIdInvDiario = Convert.ToInt32(dtgInvDiarios.SelectedRows[0].Cells[0].Value);
                    usuarioNegocio.EliminarInvDiario(iIdInvDiario);
                    txtStock.Text = "";
                    txtPrecioDia.Text = "";
                    CargarCbDiarios();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un registro para eliminar.");
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (dtgInvDiarios.SelectedRows.Count > 0)
            {
                txtStock.Enabled = true;
                txtPrecioDia.Enabled = true;

                if (btnEditar.Text == "Guardar")
                {
                    if (string.IsNullOrWhiteSpace(cbDiarios.SelectedValue?.ToString()) ||
                        string.IsNullOrWhiteSpace(txtStock.Text) ||
                        string.IsNullOrWhiteSpace(txtPrecioDia.Text))
                    {
                        MessageBox.Show("INGRESE TODOS LOS DATOS");
                    }
                    else
                    {
                        int iIdInvDiario = Convert.ToInt32(dtgInvDiarios.SelectedRows[0].Cells[0].Value);
                        int iStock = Convert.ToInt32(txtStock.Text);
                        float precioDia = float.Parse(txtPrecioDia.Text, CultureInfo.InvariantCulture);

                        bool bEditado = usuarioNegocio.EditarInvDiario(iIdInvDiario, iStock, precioDia);
                        txtStock.Enabled = false;
                        txtPrecioDia.Enabled = false;
                        txtStock.Text = "";
                        txtPrecioDia.Text = "";

                        if (bEditado)
                        {
                            MessageBox.Show("Registro actualizado correctamente.");
                            btnEditar.Text = "✏ Editar";
                            CargarCbDiarios();
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar el registro.");
                        }
                    }
                }
                else
                {
                    btnEditar.Text = "Guardar";
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un registro para editar.");
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            if (btnAgregar.Text == "Agregar" || btnEditar.Text == "Guardar")
            {
                btnAgregar.Text = "Nuevo";
                cbDiarios.Enabled = false;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                txtStock.Enabled = false;
                txtPrecioDia.Enabled = false;
                txtStock.Text = "";
                txtPrecioDia.Text = "";
                btnEditar.Text = "✏ Editar";
            }
            dtgInvDiarios.ClearSelection();
        }

        private void dtgInvDiarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (btnAgregar.Text == "Agregar")
                {

                }
                else
                {
                    DataGridViewRow filaSeleccionada = dtgInvDiarios.Rows[e.RowIndex];

                    string diarioSeleccionado = filaSeleccionada.Cells["NOMBRE DIARIO"].Value.ToString().Trim();

                    int index = cbDiarios.FindStringExact(diarioSeleccionado);
                    if (index != -1)
                    {
                        cbDiarios.SelectedIndex = index;
                    }
                    else
                    {
                        MessageBox.Show("El diario seleccionado no está en la lista del ComboBox.");
                    }

                    txtStock.Text = filaSeleccionada.Cells["CANTIDAD DE STOCK"].Value.ToString();
                    txtPrecioDia.Text = filaSeleccionada.Cells["PRECIO DIA"].Value.ToString();
                }
            }
        }

        private void lblNombreUser_Click(object sender, EventArgs e)
        {

        }
    }
}
