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

            cbxEstatus.Enabled = false;

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
            txtRazonSocial.Enabled = true;
            txtRubroGiro.Enabled = true;
            txtCalle.Enabled = true;
            txtNumeroInterior.Enabled = true;
            txtNumeroExterior.Enabled = true;
            txtColonia.Enabled = true;
            txtMunicipio.Enabled = true;
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
            txtRazonSocial.Enabled = false;
            txtRubroGiro.Enabled = false;
            txtCalle.Enabled = false;
            txtNumeroInterior.Enabled = false;
            txtNumeroExterior.Enabled = false;
            txtColonia.Enabled = false;
            txtMunicipio.Enabled = false;
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
            txtRazonSocial.Text = "";
            txtRubroGiro.Text = "";
            txtCalle.Text = "";
            txtNumeroInterior.Text = "";
            txtNumeroExterior.Text = "";
            txtColonia.Text = "";
            txtMunicipio.Text = "";
            txtEstado.Text = "";
            txtCodigoPostal.Text = "";
            txtTelefono.Text = "";
            txtTelefono2.Text = "";
            txtCorreo1.Text = "";
            txtCorreo2.Text = "";
            txtRFC.Text = "";
        }

        bool ValidarCamposVacios()// Validar si las cajas de texto estan vacios
        {
            foreach (Control c in this.Controls) //ciclo for donce c es un control que recorrera todo el formulario
            {
                if (c is TextBox & (string)c.Tag == "formulario") //Si c es un textbox y tiene el tag de formulario
                {
                    if (string.IsNullOrWhiteSpace(((TextBox)c).Text))//Si el textobox esta vacio
                    {
                        MessageBox.Show("Rellene los espacios en blanco por favor", "SIGALSW", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
                else if (c is ComboBox & (string)c.Tag == "formulario")//Si c es un cobobox y tiene el tag de formulario
                {
                    if (c.Text == string.Empty)//Si el combobox esta vacio
                    {
                        MessageBox.Show("Rellene los espacios en blanco por favor", "SIGALSW", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
            }
            return true;
        }

        private void CamposModificados(object sender, EventArgs e)
        {
            if (dgvTabla.Enabled == false)//Cuando se esta agregando o modificando un elemento del formulario
            {
                if (VariablesGlobales.ModificacionesRealizadas == false)
                {
                    VariablesGlobales.ModificacionesRealizadas = true;
                }
            }
        }

        //////////////////////////////////////////////////////////////////////////////
        private void btnNuevo_Click(object sender, EventArgs e)
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

            dgvTabla.Enabled = false;

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
            btnLimpiar.Enabled = false;
            btnEliminar.Enabled = false;
            btnBuscar.Enabled = false;

            dgvTabla.Enabled = false;

            VariablesGlobales.ModificacionEnCurso = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCamposVacios())//VALIDAR SI LOS CAMPOS NO ESTAN VACIOOS
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

                dgvTabla.Enabled = true;

                VariablesGlobales.ModificacionesRealizadas = false;
                VariablesGlobales.ModificacionEnCurso = false;
            }
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
            deshabilitarCajasDeTexto();

            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnActualizar.Enabled = true;
            btnLimpiar.Enabled = false;
            btnBuscar.Enabled = true;

            dgvTabla.Enabled = true;

            VariablesGlobales.ModificacionEnCurso = false;
            VariablesGlobales.ModificacionesRealizadas = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarFormulario();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //Aqui va van a volver a cargar los datos de la tabla
        }
    }
}
