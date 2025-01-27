namespace AGENCIADIARIOS
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
            this.txtPrecioDia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDiarios = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblDiarioInventario = new System.Windows.Forms.Label();
            this.dtgInvDiarios = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblNombreUser = new System.Windows.Forms.Label();
            this.gbInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInvDiarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInventario
            // 
            this.gbInventario.Controls.Add(this.txtPrecioDia);
            this.gbInventario.Controls.Add(this.label3);
            this.gbInventario.Controls.Add(this.txtStock);
            this.gbInventario.Controls.Add(this.label1);
            this.gbInventario.Controls.Add(this.cbDiarios);
            this.gbInventario.Controls.Add(this.btnCancelar);
            this.gbInventario.Controls.Add(this.btnEditar);
            this.gbInventario.Controls.Add(this.btnAgregar);
            this.gbInventario.Controls.Add(this.btnEliminar);
            this.gbInventario.Controls.Add(this.lblDiarioInventario);
            this.gbInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInventario.Location = new System.Drawing.Point(16, 15);
            this.gbInventario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbInventario.Name = "gbInventario";
            this.gbInventario.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbInventario.Size = new System.Drawing.Size(511, 431);
            this.gbInventario.TabIndex = 1;
            this.gbInventario.TabStop = false;
            this.gbInventario.Text = "MAESTRO DE INVENTARIO DE DIARIOS";
            // 
            // txtPrecioDia
            // 
            this.txtPrecioDia.Location = new System.Drawing.Point(287, 198);
            this.txtPrecioDia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioDia.Name = "txtPrecioDia";
            this.txtPrecioDia.Size = new System.Drawing.Size(160, 23);
            this.txtPrecioDia.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ingrese precio día:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(287, 144);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(160, 23);
            this.txtStock.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese stock del día:";
            // 
            // cbDiarios
            // 
            this.cbDiarios.FormattingEnabled = true;
            this.cbDiarios.Location = new System.Drawing.Point(287, 85);
            this.cbDiarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDiarios.Name = "cbDiarios";
            this.cbDiarios.Size = new System.Drawing.Size(160, 25);
            this.cbDiarios.TabIndex = 9;
            this.cbDiarios.SelectedIndexChanged += new System.EventHandler(this.cbDiarios_SelectedIndexChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.DimGray;
            this.btnCancelar.Location = new System.Drawing.Point(385, 364);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 46);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "🔓 Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.ForeColor = System.Drawing.Color.Gray;
            this.btnEditar.Location = new System.Drawing.Point(263, 364);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(115, 46);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "✏ Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.Color.Gray;
            this.btnAgregar.Location = new System.Drawing.Point(11, 364);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 46);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "✔ Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.Color.Gray;
            this.btnEliminar.Location = new System.Drawing.Point(140, 364);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 46);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "❌ Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblDiarioInventario
            // 
            this.lblDiarioInventario.AutoSize = true;
            this.lblDiarioInventario.Location = new System.Drawing.Point(28, 89);
            this.lblDiarioInventario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiarioInventario.Name = "lblDiarioInventario";
            this.lblDiarioInventario.Size = new System.Drawing.Size(156, 17);
            this.lblDiarioInventario.TabIndex = 1;
            this.lblDiarioInventario.Text = "Seleccione el diario:";
            this.lblDiarioInventario.Click += new System.EventHandler(this.lblNombreDiarioInventario_Click);
            // 
            // dtgInvDiarios
            // 
            this.dtgInvDiarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInvDiarios.Location = new System.Drawing.Point(560, 15);
            this.dtgInvDiarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgInvDiarios.Name = "dtgInvDiarios";
            this.dtgInvDiarios.RowHeadersWidth = 51;
            this.dtgInvDiarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgInvDiarios.Size = new System.Drawing.Size(716, 431);
            this.dtgInvDiarios.TabIndex = 2;
            this.dtgInvDiarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgInvDiarios_CellClick);
            this.dtgInvDiarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgInvDiarios_CellContentClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox3.Location = new System.Drawing.Point(-9, 481);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1333, 27);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // lblNombreUser
            // 
            this.lblNombreUser.AutoSize = true;
            this.lblNombreUser.BackColor = System.Drawing.Color.SteelBlue;
            this.lblNombreUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUser.ForeColor = System.Drawing.Color.White;
            this.lblNombreUser.Location = new System.Drawing.Point(1219, 487);
            this.lblNombreUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreUser.Name = "lblNombreUser";
            this.lblNombreUser.Size = new System.Drawing.Size(52, 17);
            this.lblNombreUser.TabIndex = 7;
            this.lblNombreUser.Text = "label3";
            this.lblNombreUser.Click += new System.EventHandler(this.lblNombreUser_Click);
            // 
            // frmInventarioDiarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 508);
            this.Controls.Add(this.lblNombreUser);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.dtgInvDiarios);
            this.Controls.Add(this.gbInventario);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmInventarioDiarios";
            this.Text = "MAESTRO INVENTARIO DE DIARIOS";
            this.Load += new System.EventHandler(this.frmInventarioDiarios_Load);
            this.gbInventario.ResumeLayout(false);
            this.gbInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInvDiarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.GroupBox gbInventario;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Label lblDiarioInventario;
		private System.Windows.Forms.ComboBox cbDiarios;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecioDia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgInvDiarios;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblNombreUser;
    }
}