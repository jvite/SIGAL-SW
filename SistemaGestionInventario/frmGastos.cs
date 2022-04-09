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
    public partial class frmGastos : Form
    {
        public frmGastos()//Incicializacion del formulario
        {
            InitializeComponent();

            deshabilitarCajasDeTexto();

            cbxConcepto.Enabled = false;

            dgvTabla.Enabled = false;

            VariablesGlobales.ModificacionEnCurso = false;
            VariablesGlobales.ModificacionesRealizadas = false;
        }
        void habilitarCajasDeTexto()//Habilitar el formulario
        {
            cbxConcepto.Enabled = true;
            txtDescripcion.Enabled = true;
            txtCantidad.Enabled = true;
            dtpFecha.Enabled = true;
        }

        void deshabilitarCajasDeTexto()//Dehabilitar el formulario
        {
            cbxConcepto.Enabled = false;
            txtDescripcion.Enabled = false;
            txtCantidad.Enabled = false;
            dtpFecha.Enabled = false;
        }

        void LimpiarFormulario()//Limpiar el formulario
        {
            cbxConcepto.SelectedIndex = 0;
            txtDescripcion.Text = "";
            txtCantidad.Text = "";
            dtpFecha.Value = DateTime.Today;
        }

        private void CamposModificados(object sender, EventArgs e)//Evento para detectar si se modifico algun campo del formulario
        {
            if (VariablesGlobales.ModificacionesRealizadas == false)
            {
                VariablesGlobales.ModificacionesRealizadas = true;
            }
        }
        ///////////////////////////////////////////////////////
        private void btnNuevo_Click(object sender, EventArgs e)//BOTON NUEVO
        {
            habilitarCajasDeTexto();
            LimpiarFormulario();

            btnNuevo.Enabled = false;
            btnActualizar.Enabled = false;
            btnEditar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;

            dgvTabla.Enabled = false;

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

            dgvTabla.Enabled = false;

            VariablesGlobales.ModificacionEnCurso = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)//BOTON GUARDAR
        {
            deshabilitarCajasDeTexto();

            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
            btnActualizar.Enabled = true;
            btnLimpiar.Enabled = false;

            dgvTabla.Enabled = true;

            VariablesGlobales.ModificacionesRealizadas = false;
            VariablesGlobales.ModificacionEnCurso = false;
        }

        

        private void btnCancelar_Click(object sender, EventArgs e)//BOTON CANCELAR
        {
            deshabilitarCajasDeTexto();

            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnActualizar.Enabled = true;
            btnLimpiar.Enabled = false;

            dgvTabla.Enabled = true;

            VariablesGlobales.ModificacionEnCurso = false;
            VariablesGlobales.ModificacionesRealizadas = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)//BOTON ACTUALIZAR
        {
            //Aqui se van a volver a cargar los datos de la tabla
        }

        private void btnLimpiar_Click(object sender, EventArgs e)//BOTON LIMPIAR
        {
            LimpiarFormulario();
        }
    }
}
