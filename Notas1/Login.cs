using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notas1
{
    public partial class Login : Form
    {
        Clases.cl_Conexion conexion = new Clases.cl_Conexion();
        Clases.cl_Usuarios usuario = new Clases.cl_Usuarios();
        public Login()
        {
            InitializeComponent();
        }       

        private void btniniciar_Click(object sender, EventArgs e)
        {
            if (ValidacionCampos())
            {
                errorProvider1.Clear();
                usuario.ObtenerUsuario(txtusuario.Text.Trim(), txtclave.Text.Trim());
                if (usuario.usuario != txtusuario.Text.Trim() || usuario.clave != txtclave.Text.Trim())
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtusuario, "El usuario '" + txtusuario.Text + "' no existe o la clave ingresada en incorrecta");
                    LimpiarFormulario();
                }
                else
                {
                    this.Hide();
                    MenuFondo frm2 = new MenuFondo();
                    frm2.Show();
                }
            }           

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hasta la proxima", "Sistema de Control de Notas", MessageBoxButtons.OK);
            this.Close();
        }

        private Boolean ValidacionCampos()
        {
            if (txtusuario.Text == string.Empty)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtusuario, "Ingrese el nombre del usuario");
                return false;
            }
            else if (txtclave.Text == string.Empty)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtclave, "Ingrese la clave del usuario");
                return false;
            }
            else
            {
                return true;
            }

        }

        private void LimpiarFormulario()
        {
            txtusuario.Text = "";
            txtclave.Text = "";
            txtusuario.Focus();
        }
    }
}
