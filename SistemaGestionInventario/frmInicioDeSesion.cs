using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestionInventario.Datos;

namespace SistemaGestionInventario
{
    public partial class frmInicioDeSesion : Form
    {
        public frmInicioDeSesion()
        {
            InitializeComponent();
        }

        private void teclaEnter(object sender, KeyEventArgs e)//Evento para la tecla enter
        {
            if (e.KeyCode == Keys.Enter)//Si la tecla pulsada es enter
            {
                iniciarSesion();
            }
        }

        void iniciarSesion()
        {
            if (txtUsuario.Text != "" & txtContrasena.Text != "")
            {
                VariablesGlobales.usuario = txtUsuario.Text.ToString();
                frmAdministrador frm = new frmAdministrador();
                frm.Show();
                this.Hide();
            }
            else if (txtUsuario.ToString() == "")
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "El usuario esta vacío.";
            }
            else if (txtContrasena.ToString() == "")
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "La contraseña esta vacía.";
            }
            else
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "Datos incorrectos. Intente de nuevo.";
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            iniciarSesion();
        }
    }
}
