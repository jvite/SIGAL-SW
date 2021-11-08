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
        bool botonCuenta = false;
        bool botonEscritorio = false;
        bool botonAlmacen = false;
        bool botonProveedores = false;
        bool botonReportes = false;
        bool botonPagos = false;
        bool botonFacturas = false;
        bool botonEstadisticas = false;
        bool botonAdinUsuarios = false;
        bool botonAcercaDe = false;

        public frmAdministrador()
        {
            InitializeComponent();
        }

        private void frmAlmacen_Load(object sender, EventArgs e)
        {
            
        }

        private void abrirForm(object formHija) //Metodo para abrir un formulario dentro de un panel
        {
            if (plContenedor.Controls.Count > 0)
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

        private void coloresDefault()
        {
            //Color de la letra
            btnAlmacen.ForeColor = Color.Silver;
            btnCuenta.ForeColor = Color.Silver;
            btnEscritorio.ForeColor = Color.Silver;
            btnEstadisticas.ForeColor = Color.Silver;
            btnFacturas.ForeColor = Color.Silver;
            btnPagos.ForeColor = Color.Silver;
            btnProveedores.ForeColor = Color.Silver;
            btnReportes.ForeColor = Color.Silver;

            //Color de fondo
            btnAlmacen.BackColor = Color.Transparent;
            btnCuenta.BackColor = Color.Transparent;
            btnEscritorio.BackColor = Color.Transparent;
            btnEstadisticas.BackColor = Color.Transparent;
            btnFacturas.BackColor = Color.Transparent;
            btnPagos.BackColor = Color.Transparent;
            btnProveedores.BackColor = Color.Transparent;
            btnReportes.BackColor = Color.Transparent;
        }

        private void resetearBotones()
        {
            botonCuenta = false;
            botonEscritorio = false;
            botonAlmacen = false;
            botonProveedores = false;
            botonReportes = false;
            botonPagos = false;
            botonFacturas = false;
            botonEstadisticas = false;
            botonAdinUsuarios = false;
            botonAcercaDe = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("¿Desea salir de SIGAL SW?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        /////////////////////////////////////EVENTOS BOTON CUENTA/////////////////////////////////////
        private void btnCuenta_MouseEnter(object sender, EventArgs e)//El mouse pasa sobre el botón
        {
            if (botonCuenta==false) {
                btnCuenta.BackColor = Color.FromArgb(38, 50, 56);
                btnCuenta.ForeColor = Color.White;
            }
        }

        private void btnCuenta_MouseLeave(object sender, EventArgs e)//El mouse se sale del boton
        {
            if (botonCuenta == false)
            {
                btnCuenta.BackColor = Color.Transparent;
                btnCuenta.ForeColor = Color.Silver;
            }
            
        }
        /////////////////////////////////////EVENTOS BOTON ESCRITORIO/////////////////////////////////////
        private void btnEscritorio_MouseEnter(object sender, EventArgs e)
        {
            if (botonEscritorio == false) { 
                btnEscritorio.BackColor = Color.FromArgb(38, 50, 56);
                btnEscritorio.ForeColor = Color.White;
            }
        }

        private void btnEscritorio_MouseLeave(object sender, EventArgs e)
        {
            if (botonEscritorio == false)
            {
                btnEscritorio.BackColor = Color.Transparent;
                btnEscritorio.ForeColor = Color.Silver;
            }
        }
        /////////////////////////////////////EVENTOS BOTON ALMACEN/////////////////////////////////////
        private void btnAlmacen_MouseEnter(object sender, EventArgs e)
        {
            if (botonAlmacen == false)
            {
                btnAlmacen.BackColor = Color.FromArgb(38, 50, 56);
                btnAlmacen.ForeColor = Color.White;
            }
        }

        private void btnAlmacen_MouseLeave(object sender, EventArgs e)
        {
            if (botonAlmacen == false)
            {
                btnAlmacen.ForeColor = Color.Silver;
                btnAlmacen.BackColor = Color.Transparent;
            }
        }
        /////////////////////////////////////EVENTOS BOTON PROVEEDORES/////////////////////////////////////
        private void btnProveedores_MouseEnter(object sender, EventArgs e)
        {
            btnProveedores.BackColor = Color.FromArgb(38, 50, 56);
            btnProveedores.ForeColor = Color.White;
        }

        private void btnProveedores_MouseLeave(object sender, EventArgs e)
        {
            btnProveedores.ForeColor = Color.Silver;
            btnProveedores.BackColor = Color.Transparent;
        }
        /////////////////////////////////////EVENTOS BOTON REPORTES/////////////////////////////////////
        private void btnReportes_MouseEnter(object sender, EventArgs e)
        {
            btnReportes.BackColor = Color.FromArgb(38, 50, 56);
            btnReportes.ForeColor = Color.White;
        }

        private void btnReportes_MouseLeave(object sender, EventArgs e)
        {
            btnReportes.ForeColor = Color.Silver;
            btnReportes.BackColor = Color.Transparent;
        }
        /////////////////////////////////////EVENTOS BOTON PAGOS/////////////////////////////////////
        private void btnPagos_MouseEnter(object sender, EventArgs e)
        {
            btnPagos.BackColor = Color.FromArgb(38, 50, 56);
            btnPagos.ForeColor = Color.White;
        }

        private void btnPagos_MouseLeave(object sender, EventArgs e)
        {
            btnPagos.ForeColor = Color.Silver;
            btnPagos.BackColor = Color.Transparent;
        }
        /////////////////////////////////////EVENTOS BOTON FACTURAS/////////////////////////////////////
        private void btnFacturas_MouseEnter(object sender, EventArgs e)
        {
            btnFacturas.BackColor = Color.FromArgb(38, 50, 56);
            btnFacturas.ForeColor = Color.White;
        }

        private void btnFacturas_MouseLeave(object sender, EventArgs e)
        {
            btnFacturas.ForeColor = Color.Silver;
            btnFacturas.BackColor = Color.Transparent;
        }
        /////////////////////////////////////EVENTOS BOTON ESTADISTICAS/////////////////////////////////////
        private void btnEstadisticas_MouseEnter(object sender, EventArgs e)
        {
            btnEstadisticas.BackColor = Color.FromArgb(38, 50, 56);
            btnEstadisticas.ForeColor = Color.White;
        }

        private void btnEstadisticas_MouseLeave(object sender, EventArgs e)
        {
            btnEstadisticas.ForeColor = Color.Silver;
            btnEstadisticas.BackColor = Color.Transparent;
        }
        /////////////////////////////////////EVENTOS BOTON ADMINISTRADOR/////////////////////////////////////
        private void btnAdministradorUsuarios_MouseEnter(object sender, EventArgs e)
        {
            if (botonAdinUsuarios == false)
            {
                btnAdministradorUsuarios.BackColor = Color.FromArgb(38, 50, 56);
                btnAdministradorUsuarios.ForeColor = Color.White;
            }
        }

        private void btnAdministradorUsuarios_MouseLeave(object sender, EventArgs e)
        {
            if (botonAdinUsuarios == false)
            {
                btnAdministradorUsuarios.ForeColor = Color.Silver;
                btnAdministradorUsuarios.BackColor = Color.Transparent;
            }
        }
        /////////////////////////////////////EVENTOS BOTON ACERCA DE/////////////////////////////////////
        private void btnAcercaDe_MouseEnter(object sender, EventArgs e)
        {
            btnAcercaDe.BackColor = Color.FromArgb(38, 50, 56);
            btnAcercaDe.ForeColor = Color.White;
        }

        private void btnAcercaDe_MouseLeave(object sender, EventArgs e)
        {
            btnAcercaDe.ForeColor = Color.Silver;
            btnAcercaDe.BackColor = Color.Transparent;
        }
        //////////////////////////////////////ABRIR FORMULARIOS CON BOTONES////////////////////////////////////////////////
        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            coloresDefault(); //Se restablecen los colores por defecto
            btnAlmacen.BackColor = Color.White; //Se cambia el color del boton a blanco
            btnAlmacen.ForeColor = Color.Gray; //Se cambia el color de la fuente del boton a gris
            abrirForm(new frmAlmacen()); //Se llama la función para abrir el formulario
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            coloresDefault();
            btnProveedores.BackColor = Color.White;
            btnProveedores.ForeColor = Color.Gray;
            abrirForm(new frmProveedores());
        }

        private void btnAdministradorUsuarios_Click(object sender, EventArgs e)
        {
            coloresDefault();
            resetearBotones();
            btnAdministradorUsuarios.BackColor = Color.White;
            btnAdministradorUsuarios.ForeColor = Color.Gray;
            botonAdinUsuarios = true;
            abrirForm(new frmUserAdmin());
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            coloresDefault();
            resetearBotones();
            btnCuenta.BackColor = Color.White;
            btnCuenta.ForeColor = Color.Gray;
            botonCuenta = true;
            abrirForm(new frmPerfil());
        }

        private void btnEscritorio_Click(object sender, EventArgs e)
        {
            coloresDefault();
            btnEscritorio.BackColor = Color.White;
            btnEscritorio.ForeColor = Color.Gray;
            abrirForm(new frmDashboard());
        }
        //////////////////////////////////////////////////////////////////////////////////////

        /////////////////////////////////////////CERRAR SESIÓN/////////////////////////////////////////////
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está a punto de cerrar sesión, ¿Continuar?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Dispose();
                frmInicioDeSesion inicio = new frmInicioDeSesion();
                inicio.Show();
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////
    }
}