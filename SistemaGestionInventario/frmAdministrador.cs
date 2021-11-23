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
    public partial class frmAdministrador : Form
    {

        public frmAdministrador()
        {
            InitializeComponent();
        }

        private void frmAlmacen_Load(object sender, EventArgs e)
        {
            
        }

        private void ColorLetra()
        {
            rbtAcercaDe.ForeColor = Color.Gray;
            rbtAdminDeUsuarios.ForeColor = Color.Gray;
            rbtAlmacen.ForeColor = Color.Gray;
            rbtClientes.ForeColor = Color.Gray;
            rbtCuenta.ForeColor = Color.Gray;
            rbtEscritorio.ForeColor = Color.Gray;
            rbtEstadisticas.ForeColor = Color.Gray;
            rbtFacturas.ForeColor = Color.Gray;
            rbtPagos.ForeColor = Color.Gray;
            rbtProveedores.ForeColor = Color.Gray;
            rbtReportes.ForeColor = Color.Gray;
        }

        private void abrirForm(object formHija) //Metodo para abrir un formulario dentro de un panel
        {
            if (plContenedor.Controls.Count > 0) //Si hay mas de un control en en contenedor
            {
                this.plContenedor.Controls.RemoveAt(0);//Se vacía el conetenedor
            }
            Form fh = formHija as Form;//se declara el objeto
            fh.TopLevel = false;//no es una ventana
            fh.Dock = DockStyle.Fill;//para que se acople
            this.plContenedor.Controls.Add(fh);//se añade el form al panel
            this.plContenedor.Tag = fh;
            fh.Show();//se muestra el form
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("¿Desea salir de SIGAL SW?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está a punto de cerrar sesión, ¿Continuar?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Dispose();
                frmInicioDeSesion inicio = new frmInicioDeSesion();
                inicio.Show();
            }
        }

        //////////////////////////////////////ABRIR FORMULARIOS CON RADIO BUTTON////////////////////////////////////////////////
        private void rbtCuenta_CheckedChanged(object sender, EventArgs e)//CUENTA
        {
            if(rbtCuenta.Checked == true)
            {
                abrirForm(new frmPerfil());
                rbtCuenta.ForeColor = Color.DimGray;
            }
            else
            {
                rbtCuenta.ForeColor = Color.White;
            }
        }

        private void rbtAlmacen_CheckedChanged(object sender, EventArgs e)//ALMACEN
        {
            if (rbtAlmacen.Checked == true)
            {
                abrirForm(new frmAlmacen());
                rbtAlmacen.ForeColor = Color.DimGray;
            }
            else
            {
                rbtAlmacen.ForeColor = Color.White;
            }
        }

        private void rbtProveedores_CheckedChanged(object sender, EventArgs e)//PROVEEDORES
        {
            if (rbtProveedores.Checked == true)
            {
                abrirForm(new frmProveedores());
                rbtProveedores.ForeColor = Color.DimGray;
            }
            else
            {
                rbtProveedores.ForeColor = Color.White;
            }
        }

        private void rbtClientes_CheckedChanged(object sender, EventArgs e)//CLIENTES
        {
            if (rbtClientes.Checked == true)
            {
                //abrirForm(new frmClientes()):
                rbtClientes.ForeColor = Color.DimGray;
            }
            else
            {
                rbtClientes.ForeColor = Color.White;
            }
        }

        private void rbtReportes_CheckedChanged(object sender, EventArgs e)//REPORTES
        {
            if (rbtReportes.Checked == true)
            {
                //abrirForm(new frmReportes());
                rbtReportes.ForeColor = Color.DimGray;
            }
            else
            {
                rbtReportes.ForeColor = Color.White;
            }
        }

        private void rbtPagos_CheckedChanged(object sender, EventArgs e)//PAGOS
        {
            if (rbtPagos.Checked == true)
            {
                rbtPagos.ForeColor = Color.DimGray;
            }
            else
            {
                rbtPagos.ForeColor = Color.White;
            }
        }

        private void rbtFacturas_CheckedChanged(object sender, EventArgs e)//FACTURAS
        {
            if (rbtFacturas.Checked == true)
            {
                abrirForm(new frmFacturacion());
                rbtFacturas.ForeColor = Color.DimGray;
            }
            else
            {
                rbtFacturas.ForeColor = Color.White;
            }
        }

        private void rbtEstadisticas_CheckedChanged(object sender, EventArgs e)//ESTADISTICAS
        {
            if (rbtFacturas.Checked == true)
            {
                abrirForm(new frmFacturacion());
                rbtEstadisticas.ForeColor = Color.DimGray;
            }
            else
            {
                rbtEstadisticas.ForeColor = Color.White;
            }
        }

        private void rbtEscritorio_CheckedChanged(object sender, EventArgs e)//ESCRITORIO
        {
            if (rbtEscritorio.Checked == true)
            {
                abrirForm(new frmDashboard());
                rbtEscritorio.ForeColor = Color.DimGray;
            }
            else
            {
                rbtEscritorio.ForeColor = Color.White;
            }
        }

        private void rbtAdminDeUsuarios_CheckedChanged(object sender, EventArgs e)//ADMINISTRADOR DE USUARIOS
        {
            if (rbtAdminDeUsuarios.Checked == true)
            {
                abrirForm(new frmUserAdmin());
                rbtAdminDeUsuarios.ForeColor = Color.DimGray;
            }
            else
            {
                rbtAdminDeUsuarios.ForeColor = Color.White;
            }
        }

        private void rbtAcercaDe_CheckedChanged(object sender, EventArgs e)//ACERCA DE
        {
            if (rbtAcercaDe.Checked == true)
            {
                rbtAcercaDe.ForeColor = Color.DimGray;
            }
            else
            {
                rbtAcercaDe.ForeColor = Color.White;
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////
        
        private void rbtCuenta_MouseEnter(object sender, EventArgs e)//SI EL MOUSE ENTRA EN EL BOTON
        {
            rbtCuenta.ForeColor = Color.DimGray;
        }

        private void rbtCuenta_MouseLeave(object sender, EventArgs e)
        {
            if (rbtCuenta.Checked == true)
            {
                rbtCuenta.ForeColor = Color.DimGray;
            }
            else
            {
                rbtCuenta.ForeColor = Color.White;
            }
        }

        private void rbtEscritorio_MouseEnter(object sender, EventArgs e)
        {
            rbtEscritorio.ForeColor = Color.DimGray;
        }

        private void rbtEscritorio_MouseLeave(object sender, EventArgs e)
        {
            if (rbtEscritorio.Checked == true)
            {
                rbtEscritorio.ForeColor = Color.DimGray;
            }
            else
            {
                rbtEscritorio.ForeColor = Color.White;
            }
        }

        private void rbtAlmacen_MouseEnter(object sender, EventArgs e)
        {
            rbtAlmacen.ForeColor = Color.DimGray;
        }

        private void rbtAlmacen_MouseLeave(object sender, EventArgs e)
        {
            if (rbtAlmacen.Checked == true)
            {
                rbtAlmacen.ForeColor = Color.DimGray;
            }
            else
            {
                rbtAlmacen.ForeColor = Color.White;
            }
        }

        private void rbtProveedores_MouseEnter(object sender, EventArgs e)
        {
            rbtProveedores.ForeColor = Color.DimGray;
        }

        private void rbtProveedores_MouseLeave(object sender, EventArgs e)
        {
            if (rbtProveedores.Checked == true)
            {
                rbtProveedores.ForeColor = Color.DimGray;
            }
            else
            {
                rbtProveedores.ForeColor = Color.White;
            }
        }

        private void rbtClientes_MouseEnter(object sender, EventArgs e)
        {
            rbtClientes.ForeColor = Color.DimGray;
        }

        private void rbtClientes_MouseLeave(object sender, EventArgs e)
        {
            if (rbtClientes.Checked == true)
            {
                rbtClientes.ForeColor = Color.DimGray;
            }
            else
            {
                rbtClientes.ForeColor = Color.White;
            }
        }

        private void rbtReportes_MouseEnter(object sender, EventArgs e)
        {
            rbtReportes.ForeColor = Color.DimGray;
        }

        private void rbtReportes_MouseLeave(object sender, EventArgs e)
        {
            if (rbtReportes.Checked == true)
            {
                rbtReportes.ForeColor = Color.DimGray;
            }
            else
            {
                rbtReportes.ForeColor = Color.White;
            }
        }

        private void rbtPagos_MouseEnter(object sender, EventArgs e)
        {
            rbtPagos.ForeColor = Color.DimGray;
        }

        private void rbtPagos_MouseLeave(object sender, EventArgs e)
        {
            if (rbtPagos.Checked == true)
            {
                rbtPagos.ForeColor = Color.DimGray;
            }
            else
            {
                rbtPagos.ForeColor = Color.White;
            }
        }

        private void rbtFacturas_MouseEnter(object sender, EventArgs e)
        {
            rbtFacturas.ForeColor = Color.DimGray;
        }

        private void rbtFacturas_MouseLeave(object sender, EventArgs e)
        {
            if (rbtFacturas.Checked == true)
            {
                rbtFacturas.ForeColor = Color.DimGray;
            }
            else
            {
                rbtFacturas.ForeColor = Color.White;
            }
        }

        private void rbtEstadisticas_MouseEnter(object sender, EventArgs e)
        {
            rbtEstadisticas.ForeColor = Color.DimGray;
        }

        private void rbtEstadisticas_MouseLeave(object sender, EventArgs e)
        {
            if (rbtEstadisticas.Checked == true)
            {
                rbtEstadisticas.ForeColor = Color.DimGray;
            }
            else
            {
                rbtEstadisticas.ForeColor = Color.White;
            }
        }

        private void rbtAdminDeUsuarios_MouseEnter(object sender, EventArgs e)
        {
            rbtAdminDeUsuarios.ForeColor = Color.DimGray;
        }

        private void rbtAdminDeUsuarios_MouseLeave(object sender, EventArgs e)
        {
            if (rbtAdminDeUsuarios.Checked == true)
            {
                rbtAdminDeUsuarios.ForeColor = Color.DimGray;
            }
            else
            {
                rbtAdminDeUsuarios.ForeColor = Color.White;
            }
        }

        private void rbtAcercaDe_MouseEnter(object sender, EventArgs e)
        {
            rbtAcercaDe.ForeColor = Color.DimGray;
        }

        private void rbtAcercaDe_MouseLeave(object sender, EventArgs e)
        {
            if (rbtAcercaDe.Checked == true)
            {
                rbtAcercaDe.ForeColor = Color.DimGray;
            }
            else
            {
                rbtAcercaDe.ForeColor = Color.White;
            }
        }
    }
}