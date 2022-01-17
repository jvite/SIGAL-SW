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
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (cbxFormaDePago.SelectedIndex == 1)
            {
                MessageBox.Show("Será redirigido a la sección de facturación.", "SIGAL SW", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmFacturacion factura = new frmFacturacion();
                factura.ShowDialog();
            }
        }
    }
}
