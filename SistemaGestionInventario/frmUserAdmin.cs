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

            deshabilitarCajasDeTexto();

            cbxRol.SelectedIndex = 0;
            cbxSexo.SelectedIndex = 0;
            cbxEstatus.SelectedIndex = 0;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;

            btnReestablecerContrasena.Enabled = false;

            VariablesGlobales.ModificacionEnCurso = false;
            VariablesGlobales.ModificacionesRealizadas = false;
        }

        private void habilitarCajasDeTexto()//HABILITA EL FORMULARIO
        {
            txtNombre.Enabled = true;
            txtApellidos.Enabled = true;
            txtCorreo.Enabled = true;
            txtTelefono.Enabled = true;
            txtUsuario.Enabled = true;
            txtContrasena.Enabled = true;
            cbxRol.Enabled = true;
            cbxSexo.Enabled = true;
            cbxEstatus.Enabled = true;
        }

        private void deshabilitarCajasDeTexto()//DEHABILITA EL FORMULARIO
        {
            txtNombre.Enabled = false;
            txtApellidos.Enabled = false;
            txtCorreo.Enabled = false;
            txtTelefono.Enabled = false;
            txtUsuario.Enabled = false;
            txtContrasena.Enabled = false;
            cbxRol.Enabled = false;
            cbxSexo.Enabled = false;
            cbxEstatus.Enabled = false;
        }

        private void LimpiarFormulario()//LIMPIA EL FORMULARIO
        {
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtUsuario.Text = "";
            txtContrasena.Text = "";
            cbxSexo.SelectedIndex = 0;
            cbxRol.SelectedIndex = 0;
            cbxEstatus.SelectedIndex = 0;
        }

        private void CamposModificados(object sender, EventArgs e)//Si se modifico algun campo del formulario
        {
            if (VariablesGlobales.ModificacionesRealizadas == false)
            {
                VariablesGlobales.ModificacionesRealizadas = true;
            }
        }

        ////////////////////////EVENTOS DE LOS BOTONES///////////////////////////
        private void btnNuevo_Click(object sender, EventArgs e)//NUEVO
        {
            habilitarCajasDeTexto();
            LimpiarFormulario();

            btnNuevo.Enabled = false;
            btnActualizar.Enabled = false;
            btnEditar.Enabled = false;
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;
            btnBuscar.Enabled = false;

            btnReestablecerContrasena.Enabled = false;

            dgvTabla.Enabled = false;

            VariablesGlobales.ModificacionEnCurso = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)//EDITAR
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

            btnReestablecerContrasena.Enabled = true;

            dgvTabla.Enabled = false;

            VariablesGlobales.ModificacionEnCurso = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)//GUARDAR
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

            btnReestablecerContrasena.Enabled = false;

            dgvTabla.Enabled = true;

            VariablesGlobales.ModificacionesRealizadas = false;
            VariablesGlobales.ModificacionEnCurso = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)//ELIMINAR
        {
            if (MessageBox.Show("¿Está seguro de eliminar este usuario? Esta acción no se puede deshacer.", "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                //Aqui se procesa la eliminacion del usuario
                MessageBox.Show("El usuario ha sido eliminado con éxito", "Eliminar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VariablesGlobales.ModificacionEnCurso = false;
                VariablesGlobales.ModificacionesRealizadas = false;
                LimpiarFormulario();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)//CANCELAR
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

            btnReestablecerContrasena.Enabled = false;

            dgvTabla.Enabled = true;

            VariablesGlobales.ModificacionEnCurso = false;
            VariablesGlobales.ModificacionesRealizadas = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)//LIMPIAR
        {
            LimpiarFormulario();
        }

        private void btnActualizar_Click(object sender, EventArgs e)//ACTUALIZAR
        {
            //Aqui se vuelven a cargar los datos de la tabla
        }

        private void btnReestablecerContrasena_Click(object sender, EventArgs e)//REESTABLECER CONTRASEÑA
        {
            if (MessageBox.Show("La contraseña actual se borrará y se generará una nueva, ¿Desea continuar?", "SIGAL SW", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                MessageBox.Show("La contraseña actual es: " + GenerarContrasena.GenerarPassword(8), "SIGAL SW", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VariablesGlobales.ModificacionEnCurso = false;
                VariablesGlobales.ModificacionesRealizadas = false;
            }
        }
    }
}