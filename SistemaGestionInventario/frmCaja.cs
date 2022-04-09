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
    public partial class frmCaja : Form
    {
        public frmCaja()
        {
            InitializeComponent();

            btnCerrarCaja.Enabled = false;
            btnReporteCierreCaja.Enabled = false;
        }

        private void btnAperturar_Click(object sender, EventArgs e)
        {
            if (txtMontoInicial.Text == "" || Convert.ToInt32(txtMontoInicial.Text)<=0)
            {
                MessageBox.Show("Ingrese una cantidad numerica válida.", "SIGAL SW", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                VariablesGlobales.AperturaCaja = true;
                txtHora.Text = DateTime.Now.ToShortTimeString();
                lblEstadoCaja.Text = "Caja Aperturada";
            }
        }

        private void btnReporteCierreCaja_Click(object sender, EventArgs e)
        {
            //Aqui se generar el reporte del cierre de la caja
        }

        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {
            VariablesGlobales.AperturaCaja = false;
            //Aqui se cerrara la caja y se calcularan los gastos y las demas weas
        }
    }
}
