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
        }

        private void habilitarCajasDeTexto()
        {
            txtArticulo.Enabled = true;
            txtDescripcion.Enabled = true;
            txtProveedor.Enabled = true;
            txtEnExistencia.Enabled = true;
            dtpFechaEntrada.Enabled = true;
            cbxActivo.Enabled = true;
        }

        private void deshabilitarCajasDeTexto()
        {
            txtArticulo.Enabled = false;
            txtDescripcion.Enabled = false;
            txtProveedor.Enabled = false;
            txtEnExistencia.Enabled = false;
            dtpFechaEntrada.Enabled = false;
            cbxActivo.Enabled = false;
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
            if (MessageBox.Show("¿Está seguro de eliminar este articulo? Esta acción no se puede deshacer.", "Eliminar articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                MessageBox.Show("El articulo ha sido eliminado con éxito", "Eliminar articulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
