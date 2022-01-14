namespace SistemaGestionInventario
{
    partial class frmGastos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblConceptoGasto = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cbxUnidadMedida = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dtpFechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConceptoGasto
            // 
            this.lblConceptoGasto.AutoSize = true;
            this.lblConceptoGasto.BackColor = System.Drawing.Color.Transparent;
            this.lblConceptoGasto.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConceptoGasto.Location = new System.Drawing.Point(12, 97);
            this.lblConceptoGasto.Name = "lblConceptoGasto";
            this.lblConceptoGasto.Size = new System.Drawing.Size(130, 18);
            this.lblConceptoGasto.TabIndex = 21;
            this.lblConceptoGasto.Text = "Concepto del gasto:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(12, 65);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 18);
            this.lblID.TabIndex = 19;
            this.lblID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(148, 62);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(65, 26);
            this.txtID.TabIndex = 18;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(332, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(91, 33);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "Gastos";
            // 
            // dgvTabla
            // 
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(12, 334);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.Size = new System.Drawing.Size(757, 216);
            this.dgvTabla.TabIndex = 23;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(12, 129);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(84, 18);
            this.lblDescripcion.TabIndex = 25;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(148, 126);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(247, 67);
            this.txtDescripcion.TabIndex = 24;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(12, 202);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(67, 18);
            this.lblCantidad.TabIndex = 27;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(148, 199);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(163, 26);
            this.txtCantidad.TabIndex = 26;
            // 
            // cbxUnidadMedida
            // 
            this.cbxUnidadMedida.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUnidadMedida.FormattingEnabled = true;
            this.cbxUnidadMedida.Items.AddRange(new object[] {
            "Transporte",
            "Utileria",
            "Mercancia",
            "Proveedores",
            "Alimentacion"});
            this.cbxUnidadMedida.Location = new System.Drawing.Point(148, 93);
            this.cbxUnidadMedida.Name = "cbxUnidadMedida";
            this.cbxUnidadMedida.Size = new System.Drawing.Size(247, 27);
            this.cbxUnidadMedida.TabIndex = 51;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImage = global::SistemaGestionInventario.Properties.Resources.color4;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = global::SistemaGestionInventario.Properties.Resources.file___1699_;
            this.btnLimpiar.Location = new System.Drawing.Point(658, 232);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(111, 33);
            this.btnLimpiar.TabIndex = 70;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::SistemaGestionInventario.Properties.Resources.color6_fw;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::SistemaGestionInventario.Properties.Resources.close___1511_1;
            this.btnCancelar.Location = new System.Drawing.Point(658, 158);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 33);
            this.btnCancelar.TabIndex = 69;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::SistemaGestionInventario.Properties.Resources.color5;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::SistemaGestionInventario.Properties.Resources.edit___1483_1;
            this.btnEditar.Location = new System.Drawing.Point(658, 47);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(111, 33);
            this.btnEditar.TabIndex = 68;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackgroundImage = global::SistemaGestionInventario.Properties.Resources.color5;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = global::SistemaGestionInventario.Properties.Resources.arrow_repeat___235_;
            this.btnActualizar.Location = new System.Drawing.Point(658, 195);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(111, 33);
            this.btnActualizar.TabIndex = 67;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::SistemaGestionInventario.Properties.Resources.color4;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::SistemaGestionInventario.Properties.Resources.save_item___1409_;
            this.btnGuardar.Location = new System.Drawing.Point(658, 84);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(111, 33);
            this.btnGuardar.TabIndex = 66;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::SistemaGestionInventario.Properties.Resources.color3;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::SistemaGestionInventario.Properties.Resources.delete___1487_1;
            this.btnEliminar.Location = new System.Drawing.Point(658, 121);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(111, 33);
            this.btnEliminar.TabIndex = 65;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = global::SistemaGestionInventario.Properties.Resources.color2;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = global::SistemaGestionInventario.Properties.Resources.plus_circle___1425_1;
            this.btnNuevo.Location = new System.Drawing.Point(658, 10);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(111, 33);
            this.btnNuevo.TabIndex = 64;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dtpFechaEntrada
            // 
            this.dtpFechaEntrada.CalendarFont = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEntrada.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEntrada.Location = new System.Drawing.Point(148, 301);
            this.dtpFechaEntrada.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaEntrada.Name = "dtpFechaEntrada";
            this.dtpFechaEntrada.Size = new System.Drawing.Size(333, 27);
            this.dtpFechaEntrada.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 19);
            this.label4.TabIndex = 71;
            this.label4.Text = "Mostrar por fecha:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::SistemaGestionInventario.Properties.Resources.linea;
            this.pictureBox3.Location = new System.Drawing.Point(0, 272);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(783, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 73;
            this.pictureBox3.TabStop = false;
            // 
            // frmGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(782, 562);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.dtpFechaEntrada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.cbxUnidadMedida);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblConceptoGasto);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGastos";
            this.Text = "Gastos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConceptoGasto;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cbxUnidadMedida;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}