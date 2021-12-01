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
    public partial class frmConfiguracion : Form
    {
        public frmConfiguracion()
        {
            InitializeComponent();
            DeshabilitarEdicion();
        }

        void DeshabilitarEdicion()
        {
            txtConexion.Enabled = false;
            txtPuerto.Enabled = false;
            txtUsuario.Enabled = false;
            txtContrasena.Enabled = false;
        }
        void HabilitarEdicion()
        {
            txtConexion.Enabled = true;
            txtPuerto.Enabled = true;
            txtUsuario.Enabled = true;
            txtContrasena.Enabled = true;
        }

        private void btnEditar_Click(object sender, System.EventArgs e)
        {
            HabilitarEdicion();
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            DeshabilitarEdicion();
        }

        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
            DeshabilitarEdicion();
        }

        private void btnDefault_Click(object sender, System.EventArgs e)
        {
            DeshabilitarEdicion();
        }

        private void btnCerrar_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
            frmInicioDeSesion inicio = new frmInicioDeSesion();
            inicio.ShowDialog();
        }
    }
}
