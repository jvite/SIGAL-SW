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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
            deshabilitarCajasDeTexto();
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;
            VariablesGlobales.ModificacionEnCurso = false;
            VariablesGlobales.ModificacionesRealizadas = false;
        }

        void habilitarCajasDeTexto()
        {
            txtNombres.Enabled = true;
            txtApellidos.Enabled = true;
            txtEmpresa.Enabled = true;
            txtDomicilio.Enabled = true;
            txtCiudad.Enabled = true;
            txtEstado.Enabled = true;
            txtCodigoPostal.Enabled = true;
            txtTelefono.Enabled = true;
            txtTelefono2.Enabled = true;
            txtCorreo1.Enabled = true;
            txtCorreo2.Enabled = true;
            txtRFC.Enabled = true;
        }

        void deshabilitarCajasDeTexto()
        {
            txtNombres.Enabled = false;
            txtApellidos.Enabled = false;
            txtEmpresa.Enabled = false;
            txtDomicilio.Enabled = false;
            txtCiudad.Enabled = false;
            txtEstado.Enabled = false;
            txtCodigoPostal.Enabled = false;
            txtTelefono.Enabled = false;
            txtTelefono2.Enabled = false;
            txtCorreo1.Enabled = false;
            txtCorreo2.Enabled = false;
            txtRFC.Enabled = false;
        }

        void limpiarFormulario()
        {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtEmpresa.Text = "";
            txtDomicilio.Text = "";
            txtCiudad.Text = "";
            txtEstado.Text = "";
            txtCodigoPostal.Text = "";
            txtTelefono.Text = "";
            txtTelefono2.Text = "";
            txtCorreo1.Text = "";
            txtCorreo2.Text = "";
            txtRFC.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarCajasDeTexto();

            btnActualizar.Enabled = false;
            btnEditar.Enabled = false;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;
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
            btnLimpiar.Enabled = true;
            btnEliminar.Enabled = false;
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
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;
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
                limpiarFormulario();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
            deshabilitarCajasDeTexto();

            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnCancelar.Enabled = false;
            btnActualizar.Enabled = true;
            btnLimpiar.Enabled = false;
            btnBuscar.Enabled = true;

            VariablesGlobales.ModificacionEnCurso = false;
            VariablesGlobales.ModificacionesRealizadas = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
            VariablesGlobales.ModificacionEnCurso = true;
            VariablesGlobales.ModificacionesRealizadas = true;
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
