using capaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocio;
using System.Drawing.Drawing2D;

namespace AGENCIADIARIOS
{
    public partial class Form1 : Form
    {
        Class1 usuarioNegocio = new Class1();
        string snombre;

        public Form1()
        {
            InitializeComponent();
        }

        protected void Form1_Load(object sender, EventArgs e)
        {
            ClassDatos conexion = new ClassDatos();
            conexion.AbrirConexion();

            snombre = usuarioNegocio.ObtenerNombreUsuario(7);

            if (!string.IsNullOrEmpty(snombre))
            {
                lblNombreUser.Text = snombre; 
            }
            else
            {
                lblNombreUser.Text = "Usuario no encontrado.";
            }

            CargarDiarios();
            //MakePictureBoxCircular(pictureBox1);
        }

        private void MakePictureBoxCircular(PictureBox picBox)
        {
            // Crear un objeto GraphicsPath para definir la región circular
            GraphicsPath path = new GraphicsPath();
            // Definir la región como un círculo en función del tamaño del PictureBox
            path.AddEllipse(0, 0, picBox.Width, picBox.Height);
            // Aplicar la región circular al PictureBox
            picBox.Region = new Region(path);

            // Sobrescribir el evento Paint del PictureBox para dibujar el borde
            //picBox.Paint += (s, pe) =>
            //{
            //    // Definir el grosor y color del borde
            //    int borderThickness = 3;
            //    Color borderColor = Color.Blue;

            //    // Dibujar el borde circular
            //    using (Pen pen = new Pen(borderColor, borderThickness))
            //    {
            //        // Calcular el rectángulo ajustado al grosor del borde
            //        Rectangle rect = new Rectangle(borderThickness / 2, borderThickness / 2,
            //                                       picBox.Width - borderThickness, picBox.Height - borderThickness);
            //        pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias; // Mejora la calidad del dibujo
            //        pe.Graphics.DrawEllipse(pen, rect);
            //    }
            //};
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string sNombreDiario = txtNombreDiario.Text;

            if (!string.IsNullOrEmpty(sNombreDiario))
            {
                usuarioNegocio.AgregarDiario(sNombreDiario, 7);
            }
            else
            {
                MessageBox.Show("Por favor complete todos los campos.");
            }
            CargarDiarios();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CargarDiarios()
        {
            DataTable diarios = usuarioNegocio.ObtenerDiarios();

            if (diarios.Rows.Count > 0)
            {
                dtgDiarios.DataSource = diarios;
                dtgDiarios.Columns["idDiario"].Visible = false;
            }
            else
            {
                MessageBox.Show("No se encontraron registros.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgDiarios.SelectedRows.Count > 0)
            {
                int iIdDiario = Convert.ToInt32(dtgDiarios.SelectedRows[0].Cells[0].Value);
                usuarioNegocio.EliminarDiario(iIdDiario);
                CargarDiarios(); 
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un registro para eliminar.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnEditar.Text = "✏ Guardar";

            if (dtgDiarios.SelectedRows.Count > 0)
            {
                int iIdDiario = Convert.ToInt32(dtgDiarios.SelectedRows[0].Cells[0].Value);
                string sNuevoNombreDiario = txtNombreDiario.Text;

                bool bEditado = usuarioNegocio.EditarDiario(iIdDiario, sNuevoNombreDiario);

                if (bEditado)
                {
                    MessageBox.Show("Registro actualizado correctamente.");
                    CargarDiarios();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el registro.");
                }
                
            }
            else { 
                    MessageBox.Show("Por favor, selecciona un registro para editar.");
            }
        }

        private void dtgDiarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que el índice de la fila sea válido (evita errores al hacer clic en el encabezado)
            if (e.RowIndex >= 0)
            {
                // Selecciona la fila actual
                DataGridViewRow filaSeleccionada = dtgDiarios.Rows[e.RowIndex];

                // Asigna el valor de la celda "nombreDiario" al TextBox
                txtNombreDiario.Text = filaSeleccionada.Cells["vchNombreDiario"].Value.ToString();
            }
        }

        private void lblNombreUser_Click(object sender, EventArgs e)
        {

        }
    }
}
