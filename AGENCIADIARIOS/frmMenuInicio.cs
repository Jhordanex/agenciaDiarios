using System;
using System.Drawing;
using System.Windows.Forms;

namespace AGENCIADIARIOS
{
    public partial class frmMenuInicio : Form
    {
        public frmMenuInicio()
        {
            InitializeComponent();




        //FormBorderStyle = FormBorderStyle.FixedDialog; 
        //MaximizeBox = false; 
        //MinimizeBox = true;  

        //StartPosition = FormStartPosition.CenterScreen; 
        //WindowState = FormWindowState.Normal;
        //this.Size = new Size(800, 600); // Cambia el tamaño según tus necesidades

    }
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
          //  frmMaestroClientes frmMaestroClientes = new frmMaestroClientes();
           // ClientesNegocio clientesNegocio = new ClientesNegocio();
            //frmMaestroClientes.Show();
            //clientesNegocio.ListarClientes();
            //this.Hide();
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
            //this.MaximizeBox = false;
            //this.FormBorderStyle = FormBorderStyle.FixedDialog; // Refuerza la restricción
            //this.SizeGripStyle = SizeGripStyle.Hide;
            //this.WindowState = FormWindowState.Normal; // Asegurar que no se abra maximizada
        }

        private void maestroDeDiariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMaestroDiarios DiariosForm = new frmMaestroDiarios();
            DiariosForm.Show();
            DiariosForm.TopMost = true;
            DiariosForm.Activate();
            this.Close();


        }

        private void maestroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
  
                frmMaestroClientes frmMaestroClientes = new frmMaestroClientes();
                ClientesNegocio clientesNegocio = new ClientesNegocio();
                frmMaestroClientes.Show();
                frmMaestroClientes.TopMost = true;
                frmMaestroClientes.Activate();
                clientesNegocio.ListarClientes();
                this.Close();


        }

        private void toolStripDropDownButton4_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void procesoDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProcesoVenta ventaForm = new frmProcesoVenta();
            ventaForm.Show();
            ventaForm.TopMost = true;
            ventaForm.Activate();
            this.Close();

        }

        private void maestroDePautasDelClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaestroPautasClientes pautasForm = new frmMaestroPautasClientes();
            pautasForm.Show();
            pautasForm.TopMost = true;
            pautasForm.Activate();
            this.Close();

        }

        private void inventarioDeDiariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
