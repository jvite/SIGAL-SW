namespace SistemaGestionInventario
{
    partial class frmAdministrador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministrador));
            this.plContenedor = new System.Windows.Forms.Panel();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.pbxSIGALSW = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.plMenuContactos = new System.Windows.Forms.Panel();
            this.plMenuLateral = new System.Windows.Forms.Panel();
            this.pbxSeparador1 = new System.Windows.Forms.PictureBox();
            this.rbtAcercaDe = new System.Windows.Forms.RadioButton();
            this.rbtAdminDeUsuarios = new System.Windows.Forms.RadioButton();
            this.rbtEstadisticas = new System.Windows.Forms.RadioButton();
            this.rbtFacturas = new System.Windows.Forms.RadioButton();
            this.rbtVentas = new System.Windows.Forms.RadioButton();
            this.rbtReportes = new System.Windows.Forms.RadioButton();
            this.rbtClientes = new System.Windows.Forms.RadioButton();
            this.rbtProveedores = new System.Windows.Forms.RadioButton();
            this.rbtAlmacen = new System.Windows.Forms.RadioButton();
            this.rbtEscritorio = new System.Windows.Forms.RadioButton();
            this.rbtCuenta = new System.Windows.Forms.RadioButton();
            this.pbxSeparador4 = new System.Windows.Forms.PictureBox();
            this.pbxSeparador3 = new System.Windows.Forms.PictureBox();
            this.pbxSeparador2 = new System.Windows.Forms.PictureBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.pbxEstado = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pbxImagenPerfil = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSIGALSW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.plMenuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSeparador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSeparador4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSeparador3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSeparador2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // plContenedor
            // 
            this.plContenedor.BackColor = System.Drawing.Color.Transparent;
            this.plContenedor.Location = new System.Drawing.Point(198, 91);
            this.plContenedor.Name = "plContenedor";
            this.plContenedor.Size = new System.Drawing.Size(782, 562);
            this.plContenedor.TabIndex = 4;
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.BackgroundImage = global::SistemaGestionInventario.Properties.Resources.Primary_Light_fw;
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracion.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracion.Image = global::SistemaGestionInventario.Properties.Resources.star___1260_1;
            this.btnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.Location = new System.Drawing.Point(279, 12);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(148, 27);
            this.btnConfiguracion.TabIndex = 15;
            this.btnConfiguracion.Text = "Configurar conexion";
            this.btnConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfiguracion.UseVisualStyleBackColor = false;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // pbxSIGALSW
            // 
            this.pbxSIGALSW.BackColor = System.Drawing.Color.Transparent;
            this.pbxSIGALSW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxSIGALSW.Image = global::SistemaGestionInventario.Properties.Resources.SIGAL_SW_LOGO_WHITE_fw;
            this.pbxSIGALSW.Location = new System.Drawing.Point(463, 1);
            this.pbxSIGALSW.Name = "pbxSIGALSW";
            this.pbxSIGALSW.Size = new System.Drawing.Size(218, 68);
            this.pbxSIGALSW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSIGALSW.TabIndex = 13;
            this.pbxSIGALSW.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::SistemaGestionInventario.Properties.Resources.linea;
            this.pictureBox3.Location = new System.Drawing.Point(198, 65);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(768, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(156)))), ((int)(((byte)(169)))));
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Image = global::SistemaGestionInventario.Properties.Resources.arrow_left___271_;
            this.btnCerrarSesion.Location = new System.Drawing.Point(200, 1);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(50, 51);
            this.btnCerrarSesion.TabIndex = 11;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(156)))), ((int)(((byte)(169)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::SistemaGestionInventario.Properties.Resources.shut_down___1431_;
            this.btnCerrar.Location = new System.Drawing.Point(898, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 51);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // plMenuContactos
            // 
            this.plMenuContactos.BackgroundImage = global::SistemaGestionInventario.Properties.Resources.Primary_Dark;
            this.plMenuContactos.Location = new System.Drawing.Point(986, 0);
            this.plMenuContactos.Name = "plMenuContactos";
            this.plMenuContactos.Size = new System.Drawing.Size(39, 663);
            this.plMenuContactos.TabIndex = 1;
            // 
            // plMenuLateral
            // 
            this.plMenuLateral.BackgroundImage = global::SistemaGestionInventario.Properties.Resources.Primary_Dark;
            this.plMenuLateral.Controls.Add(this.pbxSeparador1);
            this.plMenuLateral.Controls.Add(this.rbtAcercaDe);
            this.plMenuLateral.Controls.Add(this.rbtAdminDeUsuarios);
            this.plMenuLateral.Controls.Add(this.rbtEstadisticas);
            this.plMenuLateral.Controls.Add(this.rbtFacturas);
            this.plMenuLateral.Controls.Add(this.rbtVentas);
            this.plMenuLateral.Controls.Add(this.rbtReportes);
            this.plMenuLateral.Controls.Add(this.rbtClientes);
            this.plMenuLateral.Controls.Add(this.rbtProveedores);
            this.plMenuLateral.Controls.Add(this.rbtAlmacen);
            this.plMenuLateral.Controls.Add(this.rbtEscritorio);
            this.plMenuLateral.Controls.Add(this.rbtCuenta);
            this.plMenuLateral.Controls.Add(this.pbxSeparador4);
            this.plMenuLateral.Controls.Add(this.pbxSeparador3);
            this.plMenuLateral.Controls.Add(this.pbxSeparador2);
            this.plMenuLateral.Controls.Add(this.lblEstado);
            this.plMenuLateral.Controls.Add(this.pbxEstado);
            this.plMenuLateral.Controls.Add(this.lblNombre);
            this.plMenuLateral.Controls.Add(this.pbxImagenPerfil);
            this.plMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.plMenuLateral.Name = "plMenuLateral";
            this.plMenuLateral.Size = new System.Drawing.Size(191, 663);
            this.plMenuLateral.TabIndex = 0;
            // 
            // pbxSeparador1
            // 
            this.pbxSeparador1.BackColor = System.Drawing.Color.Transparent;
            this.pbxSeparador1.Image = global::SistemaGestionInventario.Properties.Resources.linea;
            this.pbxSeparador1.Location = new System.Drawing.Point(0, 220);
            this.pbxSeparador1.Name = "pbxSeparador1";
            this.pbxSeparador1.Size = new System.Drawing.Size(192, 25);
            this.pbxSeparador1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSeparador1.TabIndex = 14;
            this.pbxSeparador1.TabStop = false;
            // 
            // rbtAcercaDe
            // 
            this.rbtAcercaDe.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtAcercaDe.BackColor = System.Drawing.Color.Transparent;
            this.rbtAcercaDe.FlatAppearance.BorderSize = 0;
            this.rbtAcercaDe.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.rbtAcercaDe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.rbtAcercaDe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.rbtAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtAcercaDe.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtAcercaDe.ForeColor = System.Drawing.Color.White;
            this.rbtAcercaDe.Image = global::SistemaGestionInventario.Properties.Resources.information___1446_;
            this.rbtAcercaDe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbtAcercaDe.Location = new System.Drawing.Point(1, 591);
            this.rbtAcercaDe.Name = "rbtAcercaDe";
            this.rbtAcercaDe.Size = new System.Drawing.Size(191, 29);
            this.rbtAcercaDe.TabIndex = 10;
            this.rbtAcercaDe.Text = "Acerca de...";
            this.rbtAcercaDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtAcercaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbtAcercaDe.UseVisualStyleBackColor = false;
            this.rbtAcercaDe.CheckedChanged += new System.EventHandler(this.rbtAcercaDe_CheckedChanged);
            this.rbtAcercaDe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rbtAcercaDe_MouseDown);
            // 
            // rbtAdminDeUsuarios
            // 
            this.rbtAdminDeUsuarios.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtAdminDeUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.rbtAdminDeUsuarios.FlatAppearance.BorderSize = 0;
            this.rbtAdminDeUsuarios.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.rbtAdminDeUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.rbtAdminDeUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.rbtAdminDeUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtAdminDeUsuarios.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtAdminDeUsuarios.ForeColor = System.Drawing.Color.White;
            this.rbtAdminDeUsuarios.Image = global::SistemaGestionInventario.Properties.Resources.profile_image_plus_round___1327_;
            this.rbtAdminDeUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbtAdminDeUsuarios.Location = new System.Drawing.Point(1, 190);
            this.rbtAdminDeUsuarios.Name = "rbtAdminDeUsuarios";
            this.rbtAdminDeUsuarios.Size = new System.Drawing.Size(191, 29);
            this.rbtAdminDeUsuarios.TabIndex = 9;
            this.rbtAdminDeUsuarios.Text = "Admin. de usuarios";
            this.rbtAdminDeUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtAdminDeUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbtAdminDeUsuarios.UseVisualStyleBackColor = false;
            this.rbtAdminDeUsuarios.CheckedChanged += new System.EventHandler(this.rbtAdminDeUsuarios_CheckedChanged);
            this.rbtAdminDeUsuarios.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rbtAdminDeUsuarios_MouseDown);
            // 
            // rbtEstadisticas
            // 
            this.rbtEstadisticas.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtEstadisticas.BackColor = System.Drawing.Color.Transparent;
            this.rbtEstadisticas.FlatAppearance.BorderSize = 0;
            this.rbtEstadisticas.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.rbtEstadisticas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.rbtEstadisticas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.rbtEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtEstadisticas.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtEstadisticas.ForeColor = System.Drawing.Color.White;
            this.rbtEstadisticas.Image = global::SistemaGestionInventario.Properties.Resources.stats___1366_;
            this.rbtEstadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbtEstadisticas.Location = new System.Drawing.Point(1, 526);
            this.rbtEstadisticas.Name = "rbtEstadisticas";
            this.rbtEstadisticas.Size = new System.Drawing.Size(191, 29);
            this.rbtEstadisticas.TabIndex = 8;
            this.rbtEstadisticas.Text = "Estadisticas";
            this.rbtEstadisticas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtEstadisticas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbtEstadisticas.UseVisualStyleBackColor = false;
            this.rbtEstadisticas.CheckedChanged += new System.EventHandler(this.rbtEstadisticas_CheckedChanged);
            this.rbtEstadisticas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rbtEstadisticas_MouseDown);
            // 
            // rbtFacturas
            // 
            this.rbtFacturas.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtFacturas.BackColor = System.Drawing.Color.Transparent;
            this.rbtFacturas.FlatAppearance.BorderSize = 0;
            this.rbtFacturas.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.rbtFacturas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.rbtFacturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.rbtFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtFacturas.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtFacturas.ForeColor = System.Drawing.Color.White;
            this.rbtFacturas.Image = global::SistemaGestionInventario.Properties.Resources.file_double___1695_;
            this.rbtFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbtFacturas.Location = new System.Drawing.Point(1, 496);
            this.rbtFacturas.Name = "rbtFacturas";
            this.rbtFacturas.Size = new System.Drawing.Size(191, 29);
            this.rbtFacturas.TabIndex = 7;
            this.rbtFacturas.Text = "Facturas";
            this.rbtFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtFacturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbtFacturas.UseVisualStyleBackColor = false;
            this.rbtFacturas.CheckedChanged += new System.EventHandler(this.rbtFacturas_CheckedChanged);
            this.rbtFacturas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rbtFacturas_MouseDown);
            // 
            // rbtVentas
            // 
            this.rbtVentas.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtVentas.BackColor = System.Drawing.Color.Transparent;
            this.rbtVentas.FlatAppearance.BorderSize = 0;
            this.rbtVentas.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.rbtVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.rbtVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.rbtVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtVentas.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtVentas.ForeColor = System.Drawing.Color.White;
            this.rbtVentas.Image = global::SistemaGestionInventario.Properties.Resources.money___1183_;
            this.rbtVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbtVentas.Location = new System.Drawing.Point(0, 466);
            this.rbtVentas.Name = "rbtVentas";
            this.rbtVentas.Size = new System.Drawing.Size(191, 29);
            this.rbtVentas.TabIndex = 6;
            this.rbtVentas.Text = "Ventas";
            this.rbtVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbtVentas.UseVisualStyleBackColor = false;
            this.rbtVentas.CheckedChanged += new System.EventHandler(this.rbtVentas_CheckedChanged);
            this.rbtVentas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rbtVentas_MouseDown);
            // 
            // rbtReportes
            // 
            this.rbtReportes.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtReportes.BackColor = System.Drawing.Color.Transparent;
            this.rbtReportes.FlatAppearance.BorderSize = 0;
            this.rbtReportes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.rbtReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.rbtReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.rbtReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtReportes.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtReportes.ForeColor = System.Drawing.Color.White;
            this.rbtReportes.Image = global::SistemaGestionInventario.Properties.Resources.chart_fill___1291_;
            this.rbtReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbtReportes.Location = new System.Drawing.Point(0, 436);
            this.rbtReportes.Name = "rbtReportes";
            this.rbtReportes.Size = new System.Drawing.Size(191, 29);
            this.rbtReportes.TabIndex = 5;
            this.rbtReportes.Text = "Reportes";
            this.rbtReportes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbtReportes.UseVisualStyleBackColor = false;
            this.rbtReportes.CheckedChanged += new System.EventHandler(this.rbtReportes_CheckedChanged);
            this.rbtReportes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rbtReportes_MouseDown);
            // 
            // rbtClientes
            // 
            this.rbtClientes.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtClientes.BackColor = System.Drawing.Color.Transparent;
            this.rbtClientes.FlatAppearance.BorderSize = 0;
            this.rbtClientes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.rbtClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.rbtClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.rbtClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtClientes.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtClientes.ForeColor = System.Drawing.Color.White;
            this.rbtClientes.Image = global::SistemaGestionInventario.Properties.Resources.profile___1335_1;
            this.rbtClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbtClientes.Location = new System.Drawing.Point(1, 406);
            this.rbtClientes.Name = "rbtClientes";
            this.rbtClientes.Size = new System.Drawing.Size(190, 29);
            this.rbtClientes.TabIndex = 4;
            this.rbtClientes.Text = "Clientes";
            this.rbtClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbtClientes.UseVisualStyleBackColor = false;
            this.rbtClientes.CheckedChanged += new System.EventHandler(this.rbtClientes_CheckedChanged);
            this.rbtClientes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rbtClientes_MouseDown);
            // 
            // rbtProveedores
            // 
            this.rbtProveedores.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtProveedores.BackColor = System.Drawing.Color.Transparent;
            this.rbtProveedores.FlatAppearance.BorderSize = 0;
            this.rbtProveedores.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.rbtProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.rbtProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.rbtProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtProveedores.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtProveedores.ForeColor = System.Drawing.Color.White;
            this.rbtProveedores.Image = global::SistemaGestionInventario.Properties.Resources.car___646_;
            this.rbtProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbtProveedores.Location = new System.Drawing.Point(0, 376);
            this.rbtProveedores.Name = "rbtProveedores";
            this.rbtProveedores.Size = new System.Drawing.Size(191, 29);
            this.rbtProveedores.TabIndex = 3;
            this.rbtProveedores.Text = "Proveedores";
            this.rbtProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbtProveedores.UseVisualStyleBackColor = false;
            this.rbtProveedores.CheckedChanged += new System.EventHandler(this.rbtProveedores_CheckedChanged);
            this.rbtProveedores.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rbtProveedores_MouseDown);
            // 
            // rbtAlmacen
            // 
            this.rbtAlmacen.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtAlmacen.BackColor = System.Drawing.Color.Transparent;
            this.rbtAlmacen.FlatAppearance.BorderSize = 0;
            this.rbtAlmacen.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.rbtAlmacen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.rbtAlmacen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.rbtAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtAlmacen.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtAlmacen.ForeColor = System.Drawing.Color.White;
            this.rbtAlmacen.Image = global::SistemaGestionInventario.Properties.Resources.database_system___1797_;
            this.rbtAlmacen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbtAlmacen.Location = new System.Drawing.Point(0, 346);
            this.rbtAlmacen.Name = "rbtAlmacen";
            this.rbtAlmacen.Size = new System.Drawing.Size(191, 29);
            this.rbtAlmacen.TabIndex = 2;
            this.rbtAlmacen.Text = "Almacen";
            this.rbtAlmacen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtAlmacen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbtAlmacen.UseVisualStyleBackColor = false;
            this.rbtAlmacen.CheckedChanged += new System.EventHandler(this.rbtAlmacen_CheckedChanged);
            this.rbtAlmacen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rbtAlmacen_MouseDown);
            // 
            // rbtEscritorio
            // 
            this.rbtEscritorio.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtEscritorio.BackColor = System.Drawing.Color.Transparent;
            this.rbtEscritorio.Checked = true;
            this.rbtEscritorio.FlatAppearance.BorderSize = 0;
            this.rbtEscritorio.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.rbtEscritorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.rbtEscritorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.rbtEscritorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtEscritorio.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtEscritorio.ForeColor = System.Drawing.Color.White;
            this.rbtEscritorio.Image = global::SistemaGestionInventario.Properties.Resources.desktop___232_;
            this.rbtEscritorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbtEscritorio.Location = new System.Drawing.Point(0, 292);
            this.rbtEscritorio.Name = "rbtEscritorio";
            this.rbtEscritorio.Size = new System.Drawing.Size(191, 29);
            this.rbtEscritorio.TabIndex = 1;
            this.rbtEscritorio.TabStop = true;
            this.rbtEscritorio.Text = "Escritorio";
            this.rbtEscritorio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtEscritorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbtEscritorio.UseVisualStyleBackColor = false;
            this.rbtEscritorio.CheckedChanged += new System.EventHandler(this.rbtEscritorio_CheckedChanged);
            this.rbtEscritorio.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rbtEscritorio_MouseDown);
            // 
            // rbtCuenta
            // 
            this.rbtCuenta.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtCuenta.BackColor = System.Drawing.Color.Transparent;
            this.rbtCuenta.FlatAppearance.BorderSize = 0;
            this.rbtCuenta.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.rbtCuenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.rbtCuenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.rbtCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtCuenta.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCuenta.ForeColor = System.Drawing.Color.White;
            this.rbtCuenta.Image = global::SistemaGestionInventario.Properties.Resources.profile___1335_1;
            this.rbtCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbtCuenta.Location = new System.Drawing.Point(0, 246);
            this.rbtCuenta.Name = "rbtCuenta";
            this.rbtCuenta.Size = new System.Drawing.Size(191, 29);
            this.rbtCuenta.TabIndex = 0;
            this.rbtCuenta.Text = "Cuenta";
            this.rbtCuenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbtCuenta.UseVisualStyleBackColor = false;
            this.rbtCuenta.CheckedChanged += new System.EventHandler(this.rbtCuenta_CheckedChanged);
            this.rbtCuenta.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rbtCuenta_MouseDown);
            // 
            // pbxSeparador4
            // 
            this.pbxSeparador4.BackColor = System.Drawing.Color.Transparent;
            this.pbxSeparador4.Image = global::SistemaGestionInventario.Properties.Resources.linea;
            this.pbxSeparador4.Location = new System.Drawing.Point(0, 563);
            this.pbxSeparador4.Name = "pbxSeparador4";
            this.pbxSeparador4.Size = new System.Drawing.Size(192, 25);
            this.pbxSeparador4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSeparador4.TabIndex = 13;
            this.pbxSeparador4.TabStop = false;
            // 
            // pbxSeparador3
            // 
            this.pbxSeparador3.BackColor = System.Drawing.Color.Transparent;
            this.pbxSeparador3.Image = global::SistemaGestionInventario.Properties.Resources.linea;
            this.pbxSeparador3.Location = new System.Drawing.Point(0, 325);
            this.pbxSeparador3.Name = "pbxSeparador3";
            this.pbxSeparador3.Size = new System.Drawing.Size(192, 25);
            this.pbxSeparador3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSeparador3.TabIndex = 5;
            this.pbxSeparador3.TabStop = false;
            // 
            // pbxSeparador2
            // 
            this.pbxSeparador2.BackColor = System.Drawing.Color.Transparent;
            this.pbxSeparador2.Image = global::SistemaGestionInventario.Properties.Resources.linea;
            this.pbxSeparador2.Location = new System.Drawing.Point(0, 276);
            this.pbxSeparador2.Name = "pbxSeparador2";
            this.pbxSeparador2.Size = new System.Drawing.Size(192, 25);
            this.pbxSeparador2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSeparador2.TabIndex = 4;
            this.pbxSeparador2.TabStop = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(75, 159);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(103, 23);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "<<estado>>";
            // 
            // pbxEstado
            // 
            this.pbxEstado.BackColor = System.Drawing.Color.Transparent;
            this.pbxEstado.Location = new System.Drawing.Point(31, 158);
            this.pbxEstado.Name = "pbxEstado";
            this.pbxEstado.Size = new System.Drawing.Size(25, 23);
            this.pbxEstado.TabIndex = 2;
            this.pbxEstado.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(42, 123);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(107, 23);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "<<usuario>>";
            // 
            // pbxImagenPerfil
            // 
            this.pbxImagenPerfil.BackColor = System.Drawing.Color.Transparent;
            this.pbxImagenPerfil.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbxImagenPerfil.ErrorImage")));
            this.pbxImagenPerfil.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbxImagenPerfil.InitialImage")));
            this.pbxImagenPerfil.Location = new System.Drawing.Point(46, 14);
            this.pbxImagenPerfil.Name = "pbxImagenPerfil";
            this.pbxImagenPerfil.Size = new System.Drawing.Size(100, 100);
            this.pbxImagenPerfil.TabIndex = 0;
            this.pbxImagenPerfil.TabStop = false;
            // 
            // frmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SistemaGestionInventario.Properties.Resources.Primary;
            this.ClientSize = new System.Drawing.Size(1025, 661);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnConfiguracion);
            this.Controls.Add(this.pbxSIGALSW);
            this.Controls.Add(this.plContenedor);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.plMenuContactos);
            this.Controls.Add(this.plMenuLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIGAL SW - Administrador";
            this.Load += new System.EventHandler(this.frmAlmacen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSIGALSW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.plMenuLateral.ResumeLayout(false);
            this.plMenuLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSeparador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSeparador4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSeparador3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSeparador2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenPerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plMenuLateral;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pbxImagenPerfil;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.PictureBox pbxEstado;
        private System.Windows.Forms.PictureBox pbxSeparador2;
        private System.Windows.Forms.PictureBox pbxSeparador3;
        private System.Windows.Forms.Panel plMenuContactos;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel plContenedor;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pbxSIGALSW;
        private System.Windows.Forms.PictureBox pbxSeparador4;
        private System.Windows.Forms.RadioButton rbtAcercaDe;
        private System.Windows.Forms.RadioButton rbtAdminDeUsuarios;
        private System.Windows.Forms.RadioButton rbtEstadisticas;
        private System.Windows.Forms.RadioButton rbtFacturas;
        private System.Windows.Forms.RadioButton rbtVentas;
        private System.Windows.Forms.RadioButton rbtReportes;
        private System.Windows.Forms.RadioButton rbtClientes;
        private System.Windows.Forms.RadioButton rbtProveedores;
        private System.Windows.Forms.RadioButton rbtAlmacen;
        private System.Windows.Forms.RadioButton rbtEscritorio;
        private System.Windows.Forms.RadioButton rbtCuenta;
        private System.Windows.Forms.PictureBox pbxSeparador1;
        private System.Windows.Forms.Button btnConfiguracion;
    }
}

