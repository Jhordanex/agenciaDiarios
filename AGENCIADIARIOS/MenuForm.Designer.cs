﻿namespace AGENCIADIARIOS
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.maestroDeDiariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maestroDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsMaestros = new System.Windows.Forms.ToolStripDropDownButton();
            this.maestroDeDiariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.maestroDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.inventarioDeDiariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesoDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.reporteHistoricoDePagoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeEstadisticaDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maestroDeDiariosToolStripMenuItem
            // 
            this.maestroDeDiariosToolStripMenuItem.Name = "maestroDeDiariosToolStripMenuItem";
            this.maestroDeDiariosToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.maestroDeDiariosToolStripMenuItem.Text = "Maestro de Diarios";
            // 
            // maestroDeToolStripMenuItem
            // 
            this.maestroDeToolStripMenuItem.Name = "maestroDeToolStripMenuItem";
            this.maestroDeToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.maestroDeToolStripMenuItem.Text = "Maestro de Clientes";
            this.maestroDeToolStripMenuItem.Click += new System.EventHandler(this.maestroDeToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maestroDeDiariosToolStripMenuItem,
            this.maestroDeToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMaestros,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1106, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsMaestros
            // 
            this.tsMaestros.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsMaestros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maestroDeDiariosToolStripMenuItem1,
            this.maestroDeClientesToolStripMenuItem});
            this.tsMaestros.Image = ((System.Drawing.Image)(resources.GetObject("tsMaestros.Image")));
            this.tsMaestros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMaestros.Name = "tsMaestros";
            this.tsMaestros.Size = new System.Drawing.Size(160, 24);
            this.tsMaestros.Text = "Modulo de Maestros";
            // 
            // maestroDeDiariosToolStripMenuItem1
            // 
            this.maestroDeDiariosToolStripMenuItem1.Name = "maestroDeDiariosToolStripMenuItem1";
            this.maestroDeDiariosToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.maestroDeDiariosToolStripMenuItem1.Text = "Maestro de Diarios";
            this.maestroDeDiariosToolStripMenuItem1.Click += new System.EventHandler(this.maestroDeDiariosToolStripMenuItem1_Click);
            // 
            // maestroDeClientesToolStripMenuItem
            // 
            this.maestroDeClientesToolStripMenuItem.Name = "maestroDeClientesToolStripMenuItem";
            this.maestroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.maestroDeClientesToolStripMenuItem.Text = "Maestro de Clientes";
            this.maestroDeClientesToolStripMenuItem.Click += new System.EventHandler(this.maestroDeClientesToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioDeDiariosToolStripMenuItem,
            this.rToolStripMenuItem,
            this.procesoDeVentasToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(143, 24);
            this.toolStripDropDownButton2.Text = "Modulo de Ventas";
            // 
            // inventarioDeDiariosToolStripMenuItem
            // 
            this.inventarioDeDiariosToolStripMenuItem.Name = "inventarioDeDiariosToolStripMenuItem";
            this.inventarioDeDiariosToolStripMenuItem.Size = new System.Drawing.Size(387, 26);
            this.inventarioDeDiariosToolStripMenuItem.Text = "Inventario de Diarios";
            // 
            // rToolStripMenuItem
            // 
            this.rToolStripMenuItem.Name = "rToolStripMenuItem";
            this.rToolStripMenuItem.Size = new System.Drawing.Size(387, 26);
            this.rToolStripMenuItem.Text = "Registro Integrado de pautas para las ventas";
            // 
            // procesoDeVentasToolStripMenuItem
            // 
            this.procesoDeVentasToolStripMenuItem.Name = "procesoDeVentasToolStripMenuItem";
            this.procesoDeVentasToolStripMenuItem.Size = new System.Drawing.Size(387, 26);
            this.procesoDeVentasToolStripMenuItem.Text = "Proceso de Ventas";
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteHistoricoDePagoDeClientesToolStripMenuItem,
            this.reporteDeEstadisticaDeVentasToolStripMenuItem});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(170, 24);
            this.toolStripDropDownButton3.Text = "Modulo de Reporteria";
            // 
            // reporteHistoricoDePagoDeClientesToolStripMenuItem
            // 
            this.reporteHistoricoDePagoDeClientesToolStripMenuItem.Name = "reporteHistoricoDePagoDeClientesToolStripMenuItem";
            this.reporteHistoricoDePagoDeClientesToolStripMenuItem.Size = new System.Drawing.Size(341, 26);
            this.reporteHistoricoDePagoDeClientesToolStripMenuItem.Text = "Reporte historico de pago de clientes";
            // 
            // reporteDeEstadisticaDeVentasToolStripMenuItem
            // 
            this.reporteDeEstadisticaDeVentasToolStripMenuItem.Name = "reporteDeEstadisticaDeVentasToolStripMenuItem";
            this.reporteDeEstadisticaDeVentasToolStripMenuItem.Size = new System.Drawing.Size(341, 26);
            this.reporteDeEstadisticaDeVentasToolStripMenuItem.Text = "Reporte de Estadistica de Ventas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(434, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU INICIO";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 619);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem maestroDeDiariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maestroDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tsMaestros;
        private System.Windows.Forms.ToolStripMenuItem maestroDeDiariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem maestroDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem inventarioDeDiariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesoDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem reporteHistoricoDePagoDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeEstadisticaDeVentasToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}