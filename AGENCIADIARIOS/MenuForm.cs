using System;
using System.Drawing;
using System.Windows.Forms;

namespace AGENCIADIARIOS
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedDialog; 
            MaximizeBox = false; 
            MinimizeBox = true;  

            StartPosition = FormStartPosition.CenterScreen; 
            WindowState = FormWindowState.Normal;
            this.Size = new Size(800, 600); // Cambia el tamaño según tus necesidades

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ClientesForm clientesForm = new ClientesForm();
            ClientesNegocio clientesNegocio = new ClientesNegocio();
            clientesForm.Show();
            clientesNegocio.ListarClientes();
            this.Hide();
        }

        private void maestroDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            // Evitar maximizar en cualquier momento del ciclo de vida del formulario
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Refuerza la restricción
            this.SizeGripStyle = SizeGripStyle.Hide;
            this.WindowState = FormWindowState.Normal; // Asegurar que no se abra maximizada
        }

        private void maestroDeDiariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMaestroDiarios DiariosForm = new frmMaestroDiarios();
            DiariosForm.Show();
            Close();
        }

        private void maestroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
  
                ClientesForm clientesForm = new ClientesForm();
                ClientesNegocio clientesNegocio = new ClientesNegocio();
                clientesForm.Show();
                clientesNegocio.ListarClientes();

            Close();
        }

        private void toolStripDropDownButton4_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
