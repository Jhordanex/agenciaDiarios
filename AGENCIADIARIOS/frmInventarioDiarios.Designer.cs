﻿namespace AGENCIADIARIOS
{
    partial class frmInventarioDiarios
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
            this.gbInventario = new System.Windows.Forms.GroupBox();
            this.cbDiarios = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblDiarioInventario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidadConsumida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecioDia = new System.Windows.Forms.TextBox();
            this.dtgInvDiarios = new System.Windows.Forms.DataGridView();
            this.gbInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInvDiarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInventario
            // 
            this.gbInventario.Controls.Add(this.txtPrecioDia);
            this.gbInventario.Controls.Add(this.label3);
            this.gbInventario.Controls.Add(this.txtCantidadConsumida);
            this.gbInventario.Controls.Add(this.label2);
            this.gbInventario.Controls.Add(this.txtStock);
            this.gbInventario.Controls.Add(this.label1);
            this.gbInventario.Controls.Add(this.cbDiarios);
            this.gbInventario.Controls.Add(this.btnCancelar);
            this.gbInventario.Controls.Add(this.btnEditar);
            this.gbInventario.Controls.Add(this.btnAgregar);
            this.gbInventario.Controls.Add(this.btnEliminar);
            this.gbInventario.Controls.Add(this.lblDiarioInventario);
            this.gbInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInventario.Location = new System.Drawing.Point(12, 12);
            this.gbInventario.Name = "gbInventario";
            this.gbInventario.Size = new System.Drawing.Size(384, 380);
            this.gbInventario.TabIndex = 1;
            this.gbInventario.TabStop = false;
            this.gbInventario.Text = "MAESTRO DE INVENTARIO DE DIARIOS";
            // 
            // cbDiarios
            // 
            this.cbDiarios.FormattingEnabled = true;
            this.cbDiarios.Location = new System.Drawing.Point(215, 69);
            this.cbDiarios.Name = "cbDiarios";
            this.cbDiarios.Size = new System.Drawing.Size(121, 21);
            this.cbDiarios.TabIndex = 9;
            this.cbDiarios.SelectedIndexChanged += new System.EventHandler(this.cbDiarios_SelectedIndexChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.DimGray;
            this.btnCancelar.Location = new System.Drawing.Point(287, 328);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 37);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "🔓 Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.ForeColor = System.Drawing.Color.Gray;
            this.btnEditar.Location = new System.Drawing.Point(195, 328);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 37);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "✏ Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.Color.Gray;
            this.btnAgregar.Location = new System.Drawing.Point(6, 328);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 37);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "✔ Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.Color.Gray;
            this.btnEliminar.Location = new System.Drawing.Point(103, 328);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 37);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "❌ Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblDiarioInventario
            // 
            this.lblDiarioInventario.AutoSize = true;
            this.lblDiarioInventario.Location = new System.Drawing.Point(21, 72);
            this.lblDiarioInventario.Name = "lblDiarioInventario";
            this.lblDiarioInventario.Size = new System.Drawing.Size(123, 13);
            this.lblDiarioInventario.TabIndex = 1;
            this.lblDiarioInventario.Text = "Seleccione el diario:";
            this.lblDiarioInventario.Click += new System.EventHandler(this.lblNombreDiarioInventario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese stock del día:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(215, 117);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(121, 20);
            this.txtStock.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ingrese cantidad consumida:";
            // 
            // txtCantidadConsumida
            // 
            this.txtCantidadConsumida.Location = new System.Drawing.Point(215, 159);
            this.txtCantidadConsumida.Name = "txtCantidadConsumida";
            this.txtCantidadConsumida.Size = new System.Drawing.Size(121, 20);
            this.txtCantidadConsumida.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ingrese precio día:";
            // 
            // txtPrecioDia
            // 
            this.txtPrecioDia.Location = new System.Drawing.Point(215, 196);
            this.txtPrecioDia.Name = "txtPrecioDia";
            this.txtPrecioDia.Size = new System.Drawing.Size(121, 20);
            this.txtPrecioDia.TabIndex = 14;
            // 
            // dtgInvDiarios
            // 
            this.dtgInvDiarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInvDiarios.Location = new System.Drawing.Point(420, 12);
            this.dtgInvDiarios.Name = "dtgInvDiarios";
            this.dtgInvDiarios.Size = new System.Drawing.Size(512, 248);
            this.dtgInvDiarios.TabIndex = 2;
            // 
            // frmInventarioDiarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 425);
            this.Controls.Add(this.dtgInvDiarios);
            this.Controls.Add(this.gbInventario);
            this.Name = "frmInventarioDiarios";
            this.Text = "frmInventarioDiarios";
            this.Load += new System.EventHandler(this.frmInventarioDiarios_Load);
            this.gbInventario.ResumeLayout(false);
            this.gbInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInvDiarios)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.GroupBox gbInventario;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Label lblDiarioInventario;
		private System.Windows.Forms.ComboBox cbDiarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecioDia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidadConsumida;
        private System.Windows.Forms.DataGridView dtgInvDiarios;
    }
}