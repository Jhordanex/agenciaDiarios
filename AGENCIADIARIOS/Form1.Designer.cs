﻿
namespace AGENCIADIARIOS
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtNombreDiario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgDiarios = new System.Windows.Forms.DataGridView();
            this.lblNombreUser = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDiarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.txtNombreDiario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MAESTRO DE DIARIOS";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.DimGray;
            this.btnCancelar.Location = new System.Drawing.Point(286, 121);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 37);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "🔓 Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.ForeColor = System.Drawing.Color.Gray;
            this.btnEditar.Location = new System.Drawing.Point(194, 121);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 37);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "✏ Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.Color.Gray;
            this.btnAgregar.Location = new System.Drawing.Point(10, 121);
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
            this.btnEliminar.Location = new System.Drawing.Point(102, 121);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 37);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "❌ Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtNombreDiario
            // 
            this.txtNombreDiario.Location = new System.Drawing.Point(183, 38);
            this.txtNombreDiario.Name = "txtNombreDiario";
            this.txtNombreDiario.Size = new System.Drawing.Size(126, 20);
            this.txtNombreDiario.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese nombre del diario:";
            // 
            // dtgDiarios
            // 
            this.dtgDiarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDiarios.Location = new System.Drawing.Point(434, 73);
            this.dtgDiarios.Name = "dtgDiarios";
            this.dtgDiarios.ReadOnly = true;
            this.dtgDiarios.Size = new System.Drawing.Size(543, 270);
            this.dtgDiarios.TabIndex = 1;
            this.dtgDiarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDiarios_CellClick);
            this.dtgDiarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblNombreUser
            // 
            this.lblNombreUser.AutoSize = true;
            this.lblNombreUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUser.ForeColor = System.Drawing.Color.White;
            this.lblNombreUser.Location = new System.Drawing.Point(832, 12);
            this.lblNombreUser.Name = "lblNombreUser";
            this.lblNombreUser.Size = new System.Drawing.Size(66, 24);
            this.lblNombreUser.TabIndex = 2;
            this.lblNombreUser.Text = "label2";
            this.lblNombreUser.Click += new System.EventHandler(this.lblNombreUser_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.lblNombreUser);
            this.panel1.Location = new System.Drawing.Point(12, 473);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 46);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 531);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgDiarios);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "SISTEMA DE DIARIOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDiarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombreDiario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dtgDiarios;
        private System.Windows.Forms.Label lblNombreUser;
        private System.Windows.Forms.Panel panel1;
    }
}

