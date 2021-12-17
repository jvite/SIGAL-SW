using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionInventario
{
    public partial class frmPerfil : Form
    {
        public frmPerfil()
        {
            InitializeComponent();

            deshabilitarCajasDeTexto();
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;

            VariablesGlobales.ModificacionEnCurso = false;
            VariablesGlobales.ModificacionesRealizadas = false;
        }

        void habilitarCajasDeTexto()
        {
            txtNombre.Enabled = true;
            txtApellidos.Enabled = true;
            txtTelefono.Enabled = true;
            cbxSexo.Enabled = true;
            txtCorreo.Enabled = true;
            txtUsuario.Enabled = true;
        }

        void deshabilitarCajasDeTexto()
        {
            txtNombre.Enabled = false;
            txtApellidos.Enabled = false;
            txtTelefono.Enabled = false;
            cbxSexo.Enabled = false;
            txtCorreo.Enabled = false;
            txtUsuario.Enabled = false;
        }

        void limpiarCajasDeTexto()
        {
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtTelefono.Text = "";
            cbxSexo.SelectedIndex = 0;
            txtCorreo.Text = "";
            txtUsuario.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitarCajasDeTexto();

            btnEditar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;

            VariablesGlobales.ModificacionEnCurso = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = true;

            VariablesGlobales.ModificacionEnCurso = false;
            VariablesGlobales.ModificacionesRealizadas = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            btnEditar.Enabled = true;
            btnGuardar.Enabled = false;

            VariablesGlobales.ModificacionEnCurso = false;
            VariablesGlobales.ModificacionesRealizadas = false;
        }

        private void CamposModificados(object sender, EventArgs e)//Si se modifico algun campo del formulario
        {
            if (VariablesGlobales.ModificacionesRealizadas == false)
            {
                VariablesGlobales.ModificacionesRealizadas = true;
            }
        }

        private void btnCambiarContrasena_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.ModificacionesRealizadas == true || VariablesGlobales.ModificacionEnCurso == true)
            {
                MessageBox.Show("Guarde los cambios antes de continuar.", "SIGAL SW", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                frmCambiarContrasena cambiarContrasena = new frmCambiarContrasena();
                cambiarContrasena.Show();
            }
        }
    }
}
