using System;
using System.Windows.Forms;
using SistemaGestionInventario.Datos;


namespace SistemaGestionInventario
{
    public partial class frmUserAdmin : Form
    {
        public frmUserAdmin()
        {
            InitializeComponent();

            deshabilitarCajasDeTexto();

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
            cbxSexo.SelectedIndex = -1;
            cbxRol.SelectedIndex = -1;
            cbxEstatus.SelectedIndex = -1;
        }
        void SeleccionarDatos()//Metodo para poner el formulario con los datos que estan seleccionados
        {
            txtNombre.Text = dgvTabla.CurrentRow.Cells[1].Value.ToString();
            txtApellidos.Text = dgvTabla.CurrentRow.Cells[2].Value.ToString();
            cbxSexo.Text= dgvTabla.CurrentRow.Cells[3].Value.ToString();
            txtCorreo.Text = dgvTabla.CurrentRow.Cells[4].Value.ToString();
            txtUsuario.Text = dgvTabla.CurrentRow.Cells[5].Value.ToString();
            cbxRol.Text = dgvTabla.CurrentRow.Cells[6].Value.ToString();
            cbxEstatus.Text = dgvTabla.CurrentRow.Cells[7].Value.ToString();
        }

        bool ValidarCamposVacios()// Validar si las cajas de texto estan vacios
        {
            foreach(Control c in this.Controls) //ciclo for donce c es un control que recorrera todo el formulario
            {
                if(c is TextBox & (string)c.Tag == "formulario") //Si c es un textbox y tiene el tag de formulario
                {
                    if (string.IsNullOrWhiteSpace(((TextBox)c).Text))//Si el textobox esta vacio
                    {
                        MessageBox.Show("Rellene los espacios en blanco por favor", "SIGALSW", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }else if(c is ComboBox & (string)c.Tag == "formulario")//Si c es un cobobox y tiene el tag de formulario
                {
                    if(c.Text == string.Empty)//Si el combobox esta vacio
                    {
                        MessageBox.Show("Rellene los espacios en blanco por favor", "SIGALSW", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
            }
            return true;
        }

        private void CamposModificados(object sender, EventArgs e)//Si se modifico algun campo del formulario
        {
            if (dgvTabla.Enabled == false)//Cuando se esta agregando o modificando un elemento del formulario
            {
                if (VariablesGlobales.ModificacionesRealizadas == false)
                {
                    VariablesGlobales.ModificacionesRealizadas = true;
                }
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

                btnReestablecerContrasena.Enabled = false;

                dgvTabla.Enabled = true;

                VariablesGlobales.ModificacionesRealizadas = false;
                VariablesGlobales.ModificacionEnCurso = false;
            }
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
            SeleccionarDatos();
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