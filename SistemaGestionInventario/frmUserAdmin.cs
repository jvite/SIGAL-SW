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

            btnGuardar.Enabled = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está a pundo de reestablecer la contraseña actual, ¿Desea continuar?", "Reestablecer contraseña", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                MessageBox.Show("La contraseña actuales: " + GenerarContrasena.GenerarPassword(8), "Contraseña reestablecida con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            btnBuscar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitarCajasDeTexto();
            btnEditar.Enabled = false;
            btnNuevo.Enabled = false;
            btnActualizar.Enabled = false;
            btnGuardar.Enabled = true;
            btnBuscar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            deshabilitarCajasDeTexto();
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnActualizar.Enabled = true;
            btnNuevo.Enabled = true;
            btnReestablecerContrasena.Enabled = true;
            btnBuscar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de eliminar este usuario? Esta acción no se puede deshacer.", "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                MessageBox.Show("El usuario ha sido eliminado con éxito", "Eliminar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
