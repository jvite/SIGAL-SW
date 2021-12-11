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
    public partial class frmAlmacen : Form
    {
        public frmAlmacen()
        {
            InitializeComponent();

            deshabilitarCajasDeTexto();
            cbxEstado.SelectedIndex = 0;
            cbxProveedor.SelectedIndex = 0;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            VariablesGlobales.ModificacionEnCurso = false;
            VariablesGlobales.ModificacionesRealizadas = false;
        }

        private void habilitarCajasDeTexto()
        {
            txtArticulo.Enabled = true;
            txtMarca.Enabled = true;
            txtModelo.Enabled = true;
            txtDescripcion.Enabled = true;
            cbxProveedor.Enabled = true;
            cbxUnidadMedida.Enabled = true;
            txtEnExistencia.Enabled = true;
            dtpFechaEntrada.Enabled = true;
            cbxEstado.Enabled = true;
        }

        private void deshabilitarCajasDeTexto()
        {
            txtArticulo.Enabled = false;
            txtMarca.Enabled = false;
            txtModelo.Enabled = false;
            txtDescripcion.Enabled = false;
            cbxProveedor.Enabled = false;
            cbxUnidadMedida.Enabled = false;
            txtEnExistencia.Enabled = false;
            dtpFechaEntrada.Enabled = false;
            cbxEstado.Enabled = false;
        }

        private void limpiarFormulario()
        {
            txtArticulo.Text="";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtDescripcion.Text = "";
            cbxProveedor.SelectedIndex = 0;
            cbxUnidadMedida.SelectedIndex = 0;
            txtEnExistencia.Text = "";
            dtpFechaEntrada.Value = DateTime.Today;
            cbxEstado.SelectedIndex = 0;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarCajasDeTexto();
            btnActualizar.Enabled = false;
            btnEditar.Enabled = false;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnBuscar.Enabled = false;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;
            btnEliminar.Enabled = false;

            VariablesGlobales.ModificacionEnCurso = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitarCajasDeTexto();
            btnEditar.Enabled = false;
            btnNuevo.Enabled = false;
            btnActualizar.Enabled = false;
            btnGuardar.Enabled = true;
            btnBuscar.Enabled = false;
            btnLimpiar.Enabled = false;
            btnCancelar.Enabled = false;

            VariablesGlobales.ModificacionEnCurso = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            deshabilitarCajasDeTexto();
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnActualizar.Enabled = true;
            btnNuevo.Enabled = true;
            btnBuscar.Enabled = true;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;

            VariablesGlobales.ModificacionEnCurso = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de eliminar este articulo? Esta acción no se puede deshacer.", "Eliminar articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                limpiarFormulario();
                MessageBox.Show("El articulo ha sido eliminado con éxito", "Eliminar articulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VariablesGlobales.ModificacionEnCurso = false;
                VariablesGlobales.ModificacionesRealizadas = false;
            }
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = true;
            btnActualizar.Enabled = true;
            btnLimpiar.Enabled = false;
        }
    }
}
