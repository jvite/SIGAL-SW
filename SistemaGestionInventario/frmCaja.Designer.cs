namespace SistemaGestionInventario
{
    partial class frmCaja
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
            this.gbxCaja = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblEstadoCaja = new System.Windows.Forms.Label();
            this.btnAperturar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMontoInicial = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dtpFechaApertura = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReporteCierreCaja = new System.Windows.Forms.Button();
            this.dtpFechaCierre = new System.Windows.Forms.DateTimePicker();
            this.txtTotalVentas = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtHoraCierre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxCaja.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCaja
            // 
            this.gbxCaja.Controls.Add(this.btnEliminar);
            this.gbxCaja.Controls.Add(this.lblEstadoCaja);
            this.gbxCaja.Controls.Add(this.btnAperturar);
            this.gbxCaja.Controls.Add(this.label1);
            this.gbxCaja.Controls.Add(this.txtMontoInicial);
            this.gbxCaja.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCaja.Location = new System.Drawing.Point(12, 61);
            this.gbxCaja.Name = "gbxCaja";
            this.gbxCaja.Size = new System.Drawing.Size(357, 166);
            this.gbxCaja.TabIndex = 0;
            this.gbxCaja.TabStop = false;
            this.gbxCaja.Text = "Apertura de caja";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::SistemaGestionInventario.Properties.Resources.color3;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(262, 76);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(85, 26);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Cerrar caja";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblEstadoCaja
            // 
            this.lblEstadoCaja.AutoSize = true;
            this.lblEstadoCaja.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCaja.Location = new System.Drawing.Point(61, 91);
            this.lblEstadoCaja.Name = "lblEstadoCaja";
            this.lblEstadoCaja.Size = new System.Drawing.Size(157, 23);
            this.lblEstadoCaja.TabIndex = 3;
            this.lblEstadoCaja.Text = "Caja no aperturada";
            // 
            // btnAperturar
            // 
            this.btnAperturar.BackgroundImage = global::SistemaGestionInventario.Properties.Resources.color2;
            this.btnAperturar.FlatAppearance.BorderSize = 0;
            this.btnAperturar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAperturar.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAperturar.Location = new System.Drawing.Point(262, 25);
            this.btnAperturar.Name = "btnAperturar";
            this.btnAperturar.Size = new System.Drawing.Size(85, 26);
            this.btnAperturar.TabIndex = 1;
            this.btnAperturar.Text = "Aperturar";
            this.btnAperturar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAperturar.UseVisualStyleBackColor = true;
            this.btnAperturar.Click += new System.EventHandler(this.btnAperturar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Monto inicial:";
            // 
            // txtMontoInicial
            // 
            this.txtMontoInicial.Location = new System.Drawing.Point(102, 25);
            this.txtMontoInicial.Name = "txtMontoInicial";
            this.txtMontoInicial.Size = new System.Drawing.Size(154, 26);
            this.txtMontoInicial.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHora);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.dtpFechaApertura);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(381, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 166);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles de apertura";
            // 
            // txtHora
            // 
            this.txtHora.Enabled = false;
            this.txtHora.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.Location = new System.Drawing.Point(127, 87);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(142, 26);
            this.txtHora.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 18);
            this.label10.TabIndex = 8;
            this.label10.Text = "Hora inicio:";
            // 
            // txtMonto
            // 
            this.txtMonto.Enabled = false;
            this.txtMonto.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(127, 119);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(142, 26);
            this.txtMonto.TabIndex = 6;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(127, 26);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(142, 26);
            this.txtCodigo.TabIndex = 3;
            // 
            // dtpFechaApertura
            // 
            this.dtpFechaApertura.CustomFormat = "";
            this.dtpFechaApertura.Enabled = false;
            this.dtpFechaApertura.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaApertura.Location = new System.Drawing.Point(127, 58);
            this.dtpFechaApertura.Name = "dtpFechaApertura";
            this.dtpFechaApertura.Size = new System.Drawing.Size(242, 23);
            this.dtpFechaApertura.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Monto inicial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Codigo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de apertura:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtHoraCierre);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnReporteCierreCaja);
            this.groupBox2.Controls.Add(this.dtpFechaCierre);
            this.groupBox2.Controls.Add(this.txtTotalVentas);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 297);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles de cierre de caja";
            // 
            // btnReporteCierreCaja
            // 
            this.btnReporteCierreCaja.BackgroundImage = global::SistemaGestionInventario.Properties.Resources.color4;
            this.btnReporteCierreCaja.FlatAppearance.BorderSize = 0;
            this.btnReporteCierreCaja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReporteCierreCaja.Font = new System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteCierreCaja.Image = global::SistemaGestionInventario.Properties.Resources.file___1677_;
            this.btnReporteCierreCaja.Location = new System.Drawing.Point(10, 188);
            this.btnReporteCierreCaja.Name = "btnReporteCierreCaja";
            this.btnReporteCierreCaja.Size = new System.Drawing.Size(120, 62);
            this.btnReporteCierreCaja.TabIndex = 11;
            this.btnReporteCierreCaja.Text = "Generar Reporte";
            this.btnReporteCierreCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReporteCierreCaja.UseVisualStyleBackColor = true;
            // 
            // dtpFechaCierre
            // 
            this.dtpFechaCierre.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCierre.Location = new System.Drawing.Point(159, 25);
            this.dtpFechaCierre.Name = "dtpFechaCierre";
            this.dtpFechaCierre.Size = new System.Drawing.Size(242, 23);
            this.dtpFechaCierre.TabIndex = 7;
            // 
            // txtTotalVentas
            // 
            this.txtTotalVentas.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVentas.Location = new System.Drawing.Point(159, 85);
            this.txtTotalVentas.Name = "txtTotalVentas";
            this.txtTotalVentas.Size = new System.Drawing.Size(142, 26);
            this.txtTotalVentas.TabIndex = 8;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(159, 117);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(142, 26);
            this.txtTotal.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(159, 149);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 26);
            this.textBox2.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Total del cierre de caja:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "Total de gastos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Total de ventas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Fecha de cierre:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 1);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(783, 33);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Caja";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHoraCierre
            // 
            this.txtHoraCierre.Enabled = false;
            this.txtHoraCierre.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraCierre.Location = new System.Drawing.Point(159, 54);
            this.txtHoraCierre.Name = "txtHoraCierre";
            this.txtHoraCierre.Size = new System.Drawing.Size(142, 26);
            this.txtHoraCierre.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Hora cierre:";
            // 
            // frmCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(782, 562);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxCaja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCaja";
            this.Text = "frmCaja";
            this.gbxCaja.ResumeLayout(false);
            this.gbxCaja.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMontoInicial;
        private System.Windows.Forms.Label lblEstadoCaja;
        private System.Windows.Forms.Button btnAperturar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DateTimePicker dtpFechaApertura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpFechaCierre;
        private System.Windows.Forms.TextBox txtTotalVentas;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnReporteCierreCaja;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHoraCierre;
        private System.Windows.Forms.Label label2;
    }
}