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
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();

            deshabilitarCajasDeTexto();

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;

            VariablesGlobales.ModificacionEnCurso = false;
            VariablesGlobales.ModificacionesRealizadas = false;
        }

        public void habilitarCajasDeTexto()
        {
            txtRazonSocial.Enabled = true;
            txtGiro.Enabled = true;
            txtServicio.Enabled = true;
            txtCalle.Enabled = true;
            txtCiudad.Enabled = true;
            txtEstado.Enabled = true;
            txtTelefono1.Enabled = true;
            txtCorreo1.Enabled = true;
            txtRFC.Enabled = true;
            txtContacto.Enabled = true;
            cbxEstatus.Enabled = true;
        }

        private void deshabilitarCajasDeTexto()
        {
            txtRazonSocial.Enabled = false;
            txtGiro.Enabled = false;
            txtServicio.Enabled = false;
            txtCalle.Enabled = false;
            txtCiudad.Enabled = false;
            txtEstado.Enabled = false;
            txtTelefono1.Enabled = false;
            txtCorreo1.Enabled = false;
            txtRFC.Enabled = false;
            txtContacto.Enabled = false;
            cbxEstatus.Enabled = false;
        }

        private void limpiarFormulario()
        {
            txtRazonSocial.Text = "";
            txtGiro.Text = "";
            txtServicio.Text = "";
            txtCalle.Text = "";
            txtCiudad.Text = "";
            txtEstado.Text = "";
            txtTelefono1.Text = "";
            txtCorreo1.Text = "";
            txtRFC.Text = "";
            txtContacto.Text = "";
            cbxEstatus.SelectedIndex = 0;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarCajasDeTexto();

            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = true;
            btnActualizar.Enabled = false;
            btnLimpiar.Enabled = true;

            VariablesGlobales.ModificacionEnCurso = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitarCajasDeTexto();

            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = true;
            btnActualizar.Enabled = false;
            btnLimpiar.Enabled = false;

            VariablesGlobales.ModificacionEnCurso = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            deshabilitarCajasDeTexto();

            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = true;
            btnCancelar.Enabled = false;
            btnActualizar.Enabled = true;
            btnLimpiar.Enabled = false;

            VariablesGlobales.ModificacionEnCurso = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("¿Está seguro de eliminar este proveedor? Esta acción no se puede deshacer.", "Eliminar proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    MessageBox.Show("El proveedor ha sido eliminado con éxito", "Eliminar proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            deshabilitarCajasDeTexto();
            VariablesGlobales.ModificacionEnCurso = false;
            VariablesGlobales.ModificacionEnCurso = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
            VariablesGlobales.ModificacionEnCurso = false;
            VariablesGlobales.ModificacionesRealizadas = false;
        }
    }
}
