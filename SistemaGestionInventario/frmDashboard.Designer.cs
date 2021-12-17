namespace SistemaGestionInventario
{
    partial class frmDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsuariosNuevos = new System.Windows.Forms.Label();
            this.lblNumUsuarios = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNumUsuariosTotales = new System.Windows.Forms.Label();
            this.lblUsuariosTotales = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbxUsuarios = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNumClientesNuevos = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotalClientes = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(21, 300);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(368, 237);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.lblNumUsuarios);
            this.panel1.Controls.Add(this.pbxUsuarios);
            this.panel1.Controls.Add(this.lblUsuariosNuevos);
            this.panel1.Location = new System.Drawing.Point(21, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 105);
            this.panel1.TabIndex = 2;
            // 
            // lblUsuariosNuevos
            // 
            this.lblUsuariosNuevos.AutoSize = true;
            this.lblUsuariosNuevos.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuariosNuevos.ForeColor = System.Drawing.Color.White;
            this.lblUsuariosNuevos.Location = new System.Drawing.Point(15, 9);
            this.lblUsuariosNuevos.Name = "lblUsuariosNuevos";
            this.lblUsuariosNuevos.Size = new System.Drawing.Size(112, 18);
            this.lblUsuariosNuevos.TabIndex = 0;
            this.lblUsuariosNuevos.Text = "Usuarios nuevos:";
            // 
            // lblNumUsuarios
            // 
            this.lblNumUsuarios.AutoSize = true;
            this.lblNumUsuarios.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumUsuarios.ForeColor = System.Drawing.Color.White;
            this.lblNumUsuarios.Location = new System.Drawing.Point(107, 51);
            this.lblNumUsuarios.Name = "lblNumUsuarios";
            this.lblNumUsuarios.Size = new System.Drawing.Size(35, 18);
            this.lblNumUsuarios.TabIndex = 2;
            this.lblNumUsuarios.Text = "NaN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.panel2.Controls.Add(this.lblNumUsuariosTotales);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lblUsuariosTotales);
            this.panel2.Location = new System.Drawing.Point(208, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 105);
            this.panel2.TabIndex = 3;
            // 
            // lblNumUsuariosTotales
            // 
            this.lblNumUsuariosTotales.AutoSize = true;
            this.lblNumUsuariosTotales.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumUsuariosTotales.ForeColor = System.Drawing.Color.White;
            this.lblNumUsuariosTotales.Location = new System.Drawing.Point(110, 51);
            this.lblNumUsuariosTotales.Name = "lblNumUsuariosTotales";
            this.lblNumUsuariosTotales.Size = new System.Drawing.Size(35, 18);
            this.lblNumUsuariosTotales.TabIndex = 2;
            this.lblNumUsuariosTotales.Text = "NaN";
            // 
            // lblUsuariosTotales
            // 
            this.lblUsuariosTotales.AutoSize = true;
            this.lblUsuariosTotales.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuariosTotales.ForeColor = System.Drawing.Color.White;
            this.lblUsuariosTotales.Location = new System.Drawing.Point(15, 9);
            this.lblUsuariosTotales.Name = "lblUsuariosTotales";
            this.lblUsuariosTotales.Size = new System.Drawing.Size(114, 18);
            this.lblUsuariosTotales.TabIndex = 0;
            this.lblUsuariosTotales.Text = "Total de usuarios:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SistemaGestionInventario.Properties.Resources.profile_round___1342_;
            this.pictureBox2.Location = new System.Drawing.Point(18, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pbxUsuarios
            // 
            this.pbxUsuarios.Image = global::SistemaGestionInventario.Properties.Resources.profile_image_plus_round___1327_1;
            this.pbxUsuarios.Location = new System.Drawing.Point(18, 42);
            this.pbxUsuarios.Name = "pbxUsuarios";
            this.pbxUsuarios.Size = new System.Drawing.Size(49, 47);
            this.pbxUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxUsuarios.TabIndex = 1;
            this.pbxUsuarios.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::SistemaGestionInventario.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(2, 233);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(780, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.panel3.Controls.Add(this.lblNumClientesNuevos);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(395, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(181, 105);
            this.panel3.TabIndex = 4;
            // 
            // lblNumClientesNuevos
            // 
            this.lblNumClientesNuevos.AutoSize = true;
            this.lblNumClientesNuevos.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumClientesNuevos.ForeColor = System.Drawing.Color.White;
            this.lblNumClientesNuevos.Location = new System.Drawing.Point(110, 51);
            this.lblNumClientesNuevos.Name = "lblNumClientesNuevos";
            this.lblNumClientesNuevos.Size = new System.Drawing.Size(35, 18);
            this.lblNumClientesNuevos.TabIndex = 2;
            this.lblNumClientesNuevos.Text = "NaN";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SistemaGestionInventario.Properties.Resources.car_round___647_;
            this.pictureBox3.Location = new System.Drawing.Point(18, 42);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Clientes nuevos:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.panel4.Controls.Add(this.lblTotalClientes);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(582, 33);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(181, 105);
            this.panel4.TabIndex = 5;
            // 
            // lblTotalClientes
            // 
            this.lblTotalClientes.AutoSize = true;
            this.lblTotalClientes.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalClientes.ForeColor = System.Drawing.Color.White;
            this.lblTotalClientes.Location = new System.Drawing.Point(110, 51);
            this.lblTotalClientes.Name = "lblTotalClientes";
            this.lblTotalClientes.Size = new System.Drawing.Size(35, 18);
            this.lblTotalClientes.TabIndex = 2;
            this.lblTotalClientes.Text = "NaN";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SistemaGestionInventario.Properties.Resources.car_round___647_;
            this.pictureBox4.Location = new System.Drawing.Point(18, 42);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(49, 47);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Clientes nuevos:";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(782, 562);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbxUsuarios;
        private System.Windows.Forms.Label lblUsuariosNuevos;
        private System.Windows.Forms.Label lblNumUsuarios;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNumUsuariosTotales;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblUsuariosTotales;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNumClientesNuevos;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTotalClientes;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
    }
}