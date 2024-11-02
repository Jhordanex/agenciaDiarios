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
    public partial class InicioSesion : System.Windows.Forms.Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            string mensajeValidacion = usuarioNegocio.ValidarUsuario(usuario, contraseña);
    
            // Verificar si el acceso fue concedido
            if (mensajeValidacion == "Acceso concedido.")
            {
                frmMenuInicio menuForm = new frmMenuInicio();
                menuForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(mensajeValidacion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.SizeGripStyle = SizeGripStyle.Hide;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
