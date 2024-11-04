
namespace AGENCIADIARIOS
{
    partial class frmMaestroDiarios
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
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.lblNombreUser = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgDiarios)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
			this.groupBox1.Location = new System.Drawing.Point(26, 44);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(384, 380);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "MAESTRO DE DIARIOS";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnAgregar
			// 
			this.btnAgregar.ForeColor = System.Drawing.Color.Gray;
			this.btnAgregar.Location = new System.Drawing.Point(11, 328);
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
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// txtNombreDiario
			// 
			this.txtNombreDiario.Location = new System.Drawing.Point(181, 151);
			this.txtNombreDiario.Name = "txtNombreDiario";
			this.txtNombreDiario.Size = new System.Drawing.Size(126, 20);
			this.txtNombreDiario.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 154);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(154, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ingrese nombre del diario:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// dtgDiarios
			// 
			this.dtgDiarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgDiarios.Location = new System.Drawing.Point(434, 44);
			this.dtgDiarios.Name = "dtgDiarios";
			this.dtgDiarios.ReadOnly = true;
			this.dtgDiarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtgDiarios.Size = new System.Drawing.Size(543, 380);
			this.dtgDiarios.TabIndex = 1;
			this.dtgDiarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDiarios_CellClick);
			this.dtgDiarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.SteelBlue;
			this.pictureBox3.Location = new System.Drawing.Point(0, 455);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(1000, 22);
			this.pictureBox3.TabIndex = 4;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
			// 
			// lblNombreUser
			// 
			this.lblNombreUser.AutoSize = true;
			this.lblNombreUser.BackColor = System.Drawing.Color.White;
			this.lblNombreUser.Location = new System.Drawing.Point(901, 459);
			this.lblNombreUser.Name = "lblNombreUser";
			this.lblNombreUser.Size = new System.Drawing.Size(35, 13);
			this.lblNombreUser.TabIndex = 6;
			this.lblNombreUser.Text = "label3";
			// 
			// frmMaestroDiarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1000, 477);
			this.Controls.Add(this.lblNombreUser);
			this.Controls.Add(this.dtgDiarios);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "frmMaestroDiarios";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MAESTRO DE DIARIOS";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgDiarios)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

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
        private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label lblNombreUser;
	}
}

