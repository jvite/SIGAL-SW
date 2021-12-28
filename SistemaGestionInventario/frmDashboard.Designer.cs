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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalUsuarios = new System.Windows.Forms.Label();
            this.lblUsuariosNuevos = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNumClientesNuevos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotalClientes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbxUsuarios = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsuarios)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.ForeColor = System.Drawing.Color.White;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(433, 68);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(337, 184);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title3.BackColor = System.Drawing.Color.Transparent;
            title3.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "titulo1";
            title3.Text = "Ventas semanales";
            this.chart1.Titles.Add(title3);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.lblTotalUsuarios);
            this.panel1.Controls.Add(this.pbxUsuarios);
            this.panel1.Controls.Add(this.lblUsuariosNuevos);
            this.panel1.Location = new System.Drawing.Point(7, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 89);
            this.panel1.TabIndex = 2;
            // 
            // lblTotalUsuarios
            // 
            this.lblTotalUsuarios.AutoSize = true;
            this.lblTotalUsuarios.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUsuarios.ForeColor = System.Drawing.Color.White;
            this.lblTotalUsuarios.Location = new System.Drawing.Point(82, 42);
            this.lblTotalUsuarios.Name = "lblTotalUsuarios";
            this.lblTotalUsuarios.Size = new System.Drawing.Size(35, 18);
            this.lblTotalUsuarios.TabIndex = 2;
            this.lblTotalUsuarios.Text = "NaN";
            // 
            // lblUsuariosNuevos
            // 
            this.lblUsuariosNuevos.AutoSize = true;
            this.lblUsuariosNuevos.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuariosNuevos.ForeColor = System.Drawing.Color.White;
            this.lblUsuariosNuevos.Location = new System.Drawing.Point(3, 9);
            this.lblUsuariosNuevos.Name = "lblUsuariosNuevos";
            this.lblUsuariosNuevos.Size = new System.Drawing.Size(114, 18);
            this.lblUsuariosNuevos.TabIndex = 0;
            this.lblUsuariosNuevos.Text = "Total de usuarios:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.panel3.Controls.Add(this.lblNumClientesNuevos);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(149, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(136, 88);
            this.panel3.TabIndex = 4;
            // 
            // lblNumClientesNuevos
            // 
            this.lblNumClientesNuevos.AutoSize = true;
            this.lblNumClientesNuevos.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumClientesNuevos.ForeColor = System.Drawing.Color.White;
            this.lblNumClientesNuevos.Location = new System.Drawing.Point(77, 41);
            this.lblNumClientesNuevos.Name = "lblNumClientesNuevos";
            this.lblNumClientesNuevos.Size = new System.Drawing.Size(35, 18);
            this.lblNumClientesNuevos.TabIndex = 2;
            this.lblNumClientesNuevos.Text = "NaN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total de clientes:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.panel4.Controls.Add(this.lblTotalClientes);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(291, 69);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(136, 88);
            this.panel4.TabIndex = 5;
            // 
            // lblTotalClientes
            // 
            this.lblTotalClientes.AutoSize = true;
            this.lblTotalClientes.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalClientes.ForeColor = System.Drawing.Color.White;
            this.lblTotalClientes.Location = new System.Drawing.Point(81, 41);
            this.lblTotalClientes.Name = "lblTotalClientes";
            this.lblTotalClientes.Size = new System.Drawing.Size(35, 18);
            this.lblTotalClientes.TabIndex = 2;
            this.lblTotalClientes.Text = "NaN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-1, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total de proveedores:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(7, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(136, 89);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "NaN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Productos:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.pictureBox5);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(149, 163);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(136, 89);
            this.panel5.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(82, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "NaN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ventas:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::SistemaGestionInventario.Properties.Resources.dollar___1189_;
            this.pictureBox5.Location = new System.Drawing.Point(6, 30);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(49, 47);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SistemaGestionInventario.Properties.Resources.collection___989_;
            this.pictureBox2.Location = new System.Drawing.Point(6, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SistemaGestionInventario.Properties.Resources.car_round___647_;
            this.pictureBox4.Location = new System.Drawing.Point(6, 29);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(49, 47);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SistemaGestionInventario.Properties.Resources.pngegg;
            this.pictureBox3.Location = new System.Drawing.Point(6, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pbxUsuarios
            // 
            this.pbxUsuarios.Image = global::SistemaGestionInventario.Properties.Resources.profile_round___1342_;
            this.pbxUsuarios.Location = new System.Drawing.Point(6, 30);
            this.pbxUsuarios.Name = "pbxUsuarios";
            this.pbxUsuarios.Size = new System.Drawing.Size(49, 47);
            this.pbxUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxUsuarios.TabIndex = 1;
            this.pbxUsuarios.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.pictureBox6);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(291, 163);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(136, 89);
            this.panel6.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(82, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "NaN";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::SistemaGestionInventario.Properties.Resources.money_round___1184_;
            this.pictureBox6.Location = new System.Drawing.Point(6, 30);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(49, 47);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Caja:";
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(81)))), ((int)(((byte)(95)))));
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.BackColor = System.Drawing.Color.Transparent;
            legend4.ForeColor = System.Drawing.Color.White;
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(433, 258);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(337, 267);
            this.chart2.TabIndex = 8;
            this.chart2.Text = "chart2";
            title4.BackColor = System.Drawing.Color.Transparent;
            title4.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.Name = "titulo1";
            title4.Text = "Productos mas vendidos";
            this.chart2.Titles.Add(title4);
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(783, 33);
            this.lblTitulo.TabIndex = 23;
            this.lblTitulo.Text = "Dashboard";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(782, 562);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsuarios)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbxUsuarios;
        private System.Windows.Forms.Label lblUsuariosNuevos;
        private System.Windows.Forms.Label lblTotalUsuarios;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNumClientesNuevos;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTotalClientes;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label lblTitulo;
    }
}