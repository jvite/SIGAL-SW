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
            cbxUnidadMedida.SelectedIndex = 0;
            cbxProveedor.SelectedIndex = 0;
            cbxUbicacion.SelectedIndex = 0;

            dtpFechaEntrada.Value = DateTime.Today;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;

            VariablesGlobales.ModificacionEnCurso = false;
            VariablesGlobales.ModificacionesRealizadas = false;
        }

        private void habilitarCajasDeTexto()//HABILITAR EL FORMULARIO
        {
            txtArticulo.Enabled = true;
            cbxProveedor.Enabled = true;
            txtMarca.Enabled = true;
            txtModelo.Enabled = true;
            txtDescripcion.Enabled = true;
            txtPrecio.Enabled = true;
            cbxUnidadMedida.Enabled = true;
            txtEnExistencia.Enabled = true;
            cbxUbicacion.Enabled = true;
            dtpFechaEntrada.Enabled = true;
            cbxEstado.Enabled = true;
        }

        private void deshabilitarCajasDeTexto()//DESHABILITAR EL FORMULARIO
        {
            txtArticulo.Enabled = false;
            cbxProveedor.Enabled = false;
            txtMarca.Enabled = false;
            txtModelo.Enabled = false;
            txtDescripcion.Enabled = false;
            txtPrecio.Enabled = false;
            cbxUnidadMedida.Enabled = false;
            txtEnExistencia.Enabled = false;
            cbxUbicacion.Enabled = false;
            dtpFechaEntrada.Enabled = false;
            cbxEstado.Enabled = false;
        }

        private void limpiarFormulario()//LIMPIAR EL FORMULARIO
        {
            txtArticulo.Text="";
            cbxProveedor.SelectedIndex = 0;
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            cbxUnidadMedida.SelectedIndex = 0;
            txtEnExistencia.Text = "";
            cbxUbicacion.SelectedIndex = 0;
            dtpFechaEntrada.Value = DateTime.Today;
            cbxEstado.SelectedIndex = 0;
        }

        ///////////////////////////////////////////////////////////////////////
        
        private void btnNuevo_Click(object sender, EventArgs e)//BOTON NUEVO
        {
            habilitarCajasDeTexto();
            limpiarFormulario();

            btnNuevo.Enabled = false;
            btnActualizar.Enabled = false;
            btnEditar.Enabled = false;
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;
            btnBuscar.Enabled = false;

            VariablesGlobales.ModificacionEnCurso = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)//BOTON EDITAR
        {
            habilitarCajasDeTexto();

            btnEditar.Enabled = false;
            btnNuevo.Enabled = false;
            btnActualizar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = false;
            btnEliminar.Enabled = false;
            btnBuscar.Enabled = false;

            VariablesGlobales.ModificacionEnCurso = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)//BOTON GUARDAR
        {
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
        }

        private void btnEliminar_Click(object sender, EventArgs e)//BOTON ELIMINAR
        {
            if (MessageBox.Show("¿Está seguro de eliminar este articulo? Esta acción no se puede deshacer.", "Eliminar articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                limpiarFormulario();
                MessageBox.Show("El articulo ha sido eliminado con éxito", "Eliminar articulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VariablesGlobales.ModificacionEnCurso = false;
                VariablesGlobales.ModificacionesRealizadas = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)//BOTON CANECLAR
        {
            limpiarFormulario();
            deshabilitarCajasDeTexto();

            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnActualizar.Enabled = true;
            btnLimpiar.Enabled = false;
            btnBuscar.Enabled = true;

            VariablesGlobales.ModificacionEnCurso = false;
            VariablesGlobales.ModificacionesRealizadas = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)//BOTON LIMPIAR
        {
            limpiarFormulario();
            VariablesGlobales.ModificacionEnCurso = false;
            VariablesGlobales.ModificacionesRealizadas = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)//BOTON ACTUALIZAR
        {
            //Aqui se volveran a cargar los datos de la tabla
        }

        private void CamposModificados(object sender, EventArgs e)//Si se modifico algun campo del formulario
        {
            if (VariablesGlobales.ModificacionesRealizadas == false)
            {
                VariablesGlobales.ModificacionesRealizadas = true;
            }
        }
    }
}
