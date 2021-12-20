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
            VariablesGlobales.EstadoSesion = true;
        }

        private void frmAlmacen_Load(object sender, EventArgs e)
        {
            
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

        private void Advertencia()
        {
            if (VariablesGlobales.ModificacionesRealizadas == true || VariablesGlobales.ModificacionEnCurso == true)//Si se estan realizando cambios
            {
                MessageBox.Show("Guarde los cambios antes de continuar.", "SIGAL SW", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.ModificacionesRealizadas == true || VariablesGlobales.ModificacionEnCurso==true)//Si se estan realizando cambios
            {
                MessageBox.Show("Guarde los cambios antes de salir.", "SIGAL SW", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MessageBox.Show("¿Desea salir de SIGAL SW?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    this.Close();
                    Application.Exit();
                }
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.ModificacionesRealizadas == true || VariablesGlobales.ModificacionEnCurso == true)//Si se estan realizando cambios
            {
                MessageBox.Show("Guarde los cambios antes de cerrar sesión.", "SIGAL SW", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MessageBox.Show("Está a punto de cerrar sesión, ¿Continuar?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    this.Dispose();
                    frmInicioDeSesion inicio = new frmInicioDeSesion();
                    inicio.Show();
                }
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////ABRIR FORMULARIOS CON RADIO BUTTON////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void rbtCuenta_CheckedChanged(object sender, EventArgs e)//CUENTA
        {
            abrirForm(new frmPerfil());
        }

        private void rbtAlmacen_CheckedChanged(object sender, EventArgs e)//ALMACEN
        {
            abrirForm(new frmAlmacen());
        }

        private void rbtProveedores_CheckedChanged(object sender, EventArgs e)//PROVEEDORES
        {
            abrirForm(new frmProveedores());
        }

        private void rbtClientes_CheckedChanged(object sender, EventArgs e)//CLIENTES
        {
            abrirForm(new frmClientes());
        }

        private void rbtReportes_CheckedChanged(object sender, EventArgs e)//REPORTES
        {
            //abrirForm(new frmReportes());
        }

        private void rbtVentas_CheckedChanged(object sender, EventArgs e)//VENTAS
        {
            abrirForm(new frmVentas());
        }

        private void rbtFacturas_CheckedChanged(object sender, EventArgs e)//FACTURAS
        {
            abrirForm(new frmFacturacion());
        }

        private void rbtEstadisticas_CheckedChanged(object sender, EventArgs e)//ESTADISTICAS
        {
            //abrirForm(new frmEstadisticas());
        }

        private void rbtEscritorio_CheckedChanged(object sender, EventArgs e)//ESCRITORIO
        {
            abrirForm(new frmDashboard());
        }

        private void rbtAdminDeUsuarios_CheckedChanged(object sender, EventArgs e)//ADMINISTRADOR DE USUARIOS
        {
            abrirForm(new frmUserAdmin());
        }

        private void rbtRegistro_CheckedChanged(object sender, EventArgs e)
        {
            abrirForm(new frmRegistro());
        }

        private void rbtAcercaDe_CheckedChanged(object sender, EventArgs e)//ACERCA DE
        {
            //abrirForm(new frmAcercaDe());
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.ModificacionesRealizadas == true || VariablesGlobales.ModificacionEnCurso == true)
            {
                Advertencia();
            }
            else
            {
                if (MessageBox.Show("La siguiente configuracion es referente al servidor, guarde los cambios antes de continuar.", "Conexion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    this.Dispose();
                    frmConfiguracion configuracion = new frmConfiguracion();
                    configuracion.Show();
                }
            }
        }

        private void rbtAdminDeUsuarios_MouseDown(object sender, MouseEventArgs e)
        {
            if (rbtAdminDeUsuarios.Checked == false)
            {
                Advertencia();
            }
        }

        private void rbtCuenta_MouseDown(object sender, MouseEventArgs e)
        {
            if (rbtCuenta.Checked == false)
            {
                Advertencia();
            }
        }

        private void rbtEscritorio_MouseDown(object sender, MouseEventArgs e)
        {
            if (rbtEscritorio.Checked == false)
            {
                Advertencia();
            }
        }

        private void rbtAlmacen_MouseDown(object sender, MouseEventArgs e)
        {
            if (rbtAlmacen.Checked == false)
            {
                Advertencia();
            }
        }

        private void rbtProveedores_MouseDown(object sender, MouseEventArgs e)
        {
            if (rbtProveedores.Checked == false)
            {
                Advertencia();
            }
        }

        private void rbtClientes_MouseDown(object sender, MouseEventArgs e)
        {
            if (rbtClientes.Checked == false)
            {
                Advertencia();
            }
        }

        private void rbtReportes_MouseDown(object sender, MouseEventArgs e)
        {
            if (rbtReportes.Checked == false)
            {
                Advertencia();
            }
        }

        private void rbtVentas_MouseDown(object sender, MouseEventArgs e)
        {
            if (rbtVentas.Checked == false)
            {
                Advertencia();
            }
        }

        private void rbtFacturas_MouseDown(object sender, MouseEventArgs e)
        {
            if (rbtFacturas.Checked == false)
            {
                Advertencia();
            }
        }

        private void rbtEstadisticas_MouseDown(object sender, MouseEventArgs e)
        {
            if (rbtEstadisticas.Checked == false)
            {
                Advertencia();
            }
        }

        private void rbtAcercaDe_MouseDown(object sender, MouseEventArgs e)
        {
            if (rbtAcercaDe.Checked == false)
            {
                Advertencia();
            }
        }

        private void rbtRegistro_MouseDown(object sender, MouseEventArgs e)
        {
            if (rbtRegistro.Checked == false)
            {
                Advertencia();
            }
        }
    }
}