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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
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

        }

        private void maestroDeDiariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMaestroDiarios DiariosForm = new frmMaestroDiarios();
            DiariosForm.Show();
        }

        private void maestroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
  
                ClientesForm clientesForm = new ClientesForm();
                ClientesNegocio clientesNegocio = new ClientesNegocio();
                clientesForm.Show();
                clientesNegocio.ListarClientes();
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
