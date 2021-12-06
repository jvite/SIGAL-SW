using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestionInventario;


namespace SistemaGestionInventario
{
    public partial class frmUserAdmin : Form
    {
        public frmUserAdmin()
        {
            InitializeComponent();

            //los cuadros de texto no se pueden editar al iniciar
            deshabilitarCajasDeTexto();
            cbxRol.SelectedIndex = 0;
            cbxSexo.SelectedIndex = 0;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void habilitarCajasDeTexto()
        {
            txtID.Enabled = true;
            txtNombre.Enabled = true;
            txtApellidos.Enabled = true;
            txtCorreo.Enabled = true;
            txtTelefono.Enabled = true;
            txtUsuario.Enabled = true;
            txtContrasena.Enabled = true;
            cbxRol.Enabled = true;
            cbxSexo.Enabled = true;
        }

        private void deshabilitarCajasDeTexto()
        {
            txtID.Enabled = false;
            txtNombre.Enabled = false;
            txtApellidos.Enabled = false;
            txtCorreo.Enabled = false;
            txtTelefono.Enabled = false;
            txtUsuario.Enabled = false;
            txtContrasena.Enabled = false;
            cbxRol.Enabled = false;
            cbxSexo.Enabled = false;
        }

        private void LimpiarFormulario()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtUsuario.Text = "";
            txtContrasena.Text = "";
            cbxSexo.SelectedIndex = 0;
            cbxRol.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está a pundo de reestablecer la contraseña actual, ¿Desea continuar?", "Reestablecer contraseña", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                MessageBox.Show("La contraseña actuales: " + GenerarContrasena.GenerarPassword(8), "Contraseña reestablecida con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VariablesGlobales.ModificacionEnCurso = false;
                VariablesGlobales.ModificacionesRealizadas = false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarCajasDeTexto();
            btnActualizar.Enabled = false;
            btnEditar.Enabled = false;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnReestablecerContrasena.Enabled = false;
            btnCancelar.Enabled = true;
            btnBuscar.Enabled = false;

            VariablesGlobales.ModificacionEnCurso = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitarCajasDeTexto();
            btnEditar.Enabled = false;
            btnNuevo.Enabled = false;
            btnActualizar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnBuscar.Enabled = false;

            VariablesGlobales.ModificacionEnCurso = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            deshabilitarCajasDeTexto();
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnActualizar.Enabled = true;
            btnNuevo.Enabled = true;
            btnReestablecerContrasena.Enabled = true;
            btnCancelar.Enabled = false;
            btnBuscar.Enabled = true;

            VariablesGlobales.ModificacionesRealizadas = false;
            VariablesGlobales.ModificacionEnCurso = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de eliminar este usuario? Esta acción no se puede deshacer.", "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                MessageBox.Show("El usuario ha sido eliminado con éxito", "Eliminar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VariablesGlobales.ModificacionEnCurso = false;
                VariablesGlobales.ModificacionesRealizadas = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            deshabilitarCajasDeTexto();
            VariablesGlobales.ModificacionEnCurso = false;
            VariablesGlobales.ModificacionesRealizadas = false;
        }

        private void CamposModificados(object sender, EventArgs e)
        {
            if (VariablesGlobales.ModificacionesRealizadas == false)
            {
                VariablesGlobales.ModificacionesRealizadas = true;
            }
        }
    }
}
