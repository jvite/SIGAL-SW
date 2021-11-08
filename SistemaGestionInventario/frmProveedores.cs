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
        }

        public void habilitarCajasDeTexto()
        {
            txtRazonSocial.Enabled = true;
            txtDomicilio.Enabled = true;
            txtGiro.Enabled = true;
            txtRFC.Enabled = true;
            txtTelefono.Enabled = true;
            txtCorreo.Enabled = true;
            txtContacto.Enabled = true;
        }

        private void deshabilitarCajasDeTexto()
        {
            txtRazonSocial.Enabled = false;
            txtDomicilio.Enabled = false;
            txtGiro.Enabled = false;
            txtRFC.Enabled = false;
            txtTelefono.Enabled = false;
            txtCorreo.Enabled = false;
            txtContacto.Enabled = false;
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarCajasDeTexto();
            btnActualizar.Enabled = false;
            btnEditar.Enabled = false;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
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
            btnBuscar.Enabled = true;
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
