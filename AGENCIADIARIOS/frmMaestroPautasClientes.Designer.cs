namespace AGENCIADIARIOS
{
    partial class frmMaestroPautasClientes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnFechaMañanaAgregar = new System.Windows.Forms.RadioButton();
            this.rbtnFechaHoyAgregar = new System.Windows.Forms.RadioButton();
            this.txtCantidadPromedio = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDiarios = new System.Windows.Forms.ComboBox();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDiarios = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.dataPautasClientes = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNombreUser = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.rbtnMañana = new System.Windows.Forms.RadioButton();
            this.rbtnHoy = new System.Windows.Forms.RadioButton();
            this.btnCancelarClick = new System.Windows.Forms.Button();
            this.btnBuscarPautas = new System.Windows.Forms.Button();
            this.dtpFechaFiltro = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPautasClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnFechaMañanaAgregar);
            this.groupBox1.Controls.Add(this.rbtnFechaHoyAgregar);
            this.groupBox1.Controls.Add(this.txtCantidadPromedio);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbDiarios);
            this.groupBox1.Controls.Add(this.cmbClientes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblDiarios);
            this.groupBox1.Controls.Add(this.lblClientes);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(760, 353);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pautas del Cliente";
            // 
            // rbtnFechaMañanaAgregar
            // 
            this.rbtnFechaMañanaAgregar.AutoSize = true;
            this.rbtnFechaMañanaAgregar.Location = new System.Drawing.Point(201, 36);
            this.rbtnFechaMañanaAgregar.Name = "rbtnFechaMañanaAgregar";
            this.rbtnFechaMañanaAgregar.Size = new System.Drawing.Size(183, 20);
            this.rbtnFechaMañanaAgregar.TabIndex = 13;
            this.rbtnFechaMañanaAgregar.TabStop = true;
            this.rbtnFechaMañanaAgregar.Text = "Con Fecha de Mañana";
            this.rbtnFechaMañanaAgregar.UseVisualStyleBackColor = true;
            // 
            // rbtnFechaHoyAgregar
            // 
            this.rbtnFechaHoyAgregar.AutoSize = true;
            this.rbtnFechaHoyAgregar.Location = new System.Drawing.Point(21, 36);
            this.rbtnFechaHoyAgregar.Name = "rbtnFechaHoyAgregar";
            this.rbtnFechaHoyAgregar.Size = new System.Drawing.Size(156, 20);
            this.rbtnFechaHoyAgregar.TabIndex = 12;
            this.rbtnFechaHoyAgregar.TabStop = true;
            this.rbtnFechaHoyAgregar.Text = "Con Fecha de Hoy";
            this.rbtnFechaHoyAgregar.UseVisualStyleBackColor = true;
            // 
            // txtCantidadPromedio
            // 
            this.txtCantidadPromedio.Location = new System.Drawing.Point(201, 217);
            this.txtCantidadPromedio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidadPromedio.Name = "txtCantidadPromedio";
            this.txtCantidadPromedio.Size = new System.Drawing.Size(295, 22);
            this.txtCantidadPromedio.TabIndex = 11;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(324, 297);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 34);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(225, 297);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(77, 34);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(120, 297);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(77, 34);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(21, 297);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(76, 34);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cantidad Promedio";
            // 
            // cmbDiarios
            // 
            this.cmbDiarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiarios.FormattingEnabled = true;
            this.cmbDiarios.Location = new System.Drawing.Point(201, 151);
            this.cmbDiarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDiarios.Name = "cmbDiarios";
            this.cmbDiarios.Size = new System.Drawing.Size(295, 24);
            this.cmbDiarios.TabIndex = 4;
            this.cmbDiarios.SelectedIndexChanged += new System.EventHandler(this.cmbDiarios_SelectedIndexChanged);
            // 
            // cmbClientes
            // 
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(201, 81);
            this.cmbClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(295, 24);
            this.cmbClientes.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 2;
            // 
            // lblDiarios
            // 
            this.lblDiarios.AutoSize = true;
            this.lblDiarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiarios.Location = new System.Drawing.Point(17, 153);
            this.lblDiarios.Name = "lblDiarios";
            this.lblDiarios.Size = new System.Drawing.Size(63, 20);
            this.lblDiarios.TabIndex = 1;
            this.lblDiarios.Text = "Diarios";
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(17, 85);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(61, 20);
            this.lblClientes.TabIndex = 0;
            this.lblClientes.Text = "Cliente";
            // 
            // dataPautasClientes
            // 
            this.dataPautasClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPautasClientes.Location = new System.Drawing.Point(27, 414);
            this.dataPautasClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataPautasClientes.Name = "dataPautasClientes";
            this.dataPautasClientes.RowHeadersWidth = 51;
            this.dataPautasClientes.RowTemplate.Height = 24;
            this.dataPautasClientes.Size = new System.Drawing.Size(1344, 300);
            this.dataPautasClientes.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Location = new System.Drawing.Point(27, 734);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1344, 33);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblNombreUser
            // 
            this.lblNombreUser.AutoSize = true;
            this.lblNombreUser.BackColor = System.Drawing.Color.SteelBlue;
            this.lblNombreUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUser.ForeColor = System.Drawing.Color.White;
            this.lblNombreUser.Location = new System.Drawing.Point(1299, 743);
            this.lblNombreUser.Name = "lblNombreUser";
            this.lblNombreUser.Size = new System.Drawing.Size(50, 16);
            this.lblNombreUser.TabIndex = 8;
            this.lblNombreUser.Text = "label3";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTransferir);
            this.groupBox2.Controls.Add(this.rbtnMañana);
            this.groupBox2.Controls.Add(this.rbtnHoy);
            this.groupBox2.Controls.Add(this.btnCancelarClick);
            this.groupBox2.Controls.Add(this.btnBuscarPautas);
            this.groupBox2.Controls.Add(this.dtpFechaFiltro);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(848, 42);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(445, 261);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrado de Pautas";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnTransferir
            // 
            this.btnTransferir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferir.Location = new System.Drawing.Point(159, 215);
            this.btnTransferir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(125, 26);
            this.btnTransferir.TabIndex = 8;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // rbtnMañana
            // 
            this.rbtnMañana.AutoSize = true;
            this.rbtnMañana.Location = new System.Drawing.Point(19, 148);
            this.rbtnMañana.Name = "rbtnMañana";
            this.rbtnMañana.Size = new System.Drawing.Size(201, 21);
            this.rbtnMañana.TabIndex = 7;
            this.rbtnMañana.TabStop = true;
            this.rbtnMañana.Text = "Transferir para Mañana";
            this.rbtnMañana.UseVisualStyleBackColor = true;
            // 
            // rbtnHoy
            // 
            this.rbtnHoy.AutoSize = true;
            this.rbtnHoy.Location = new System.Drawing.Point(19, 108);
            this.rbtnHoy.Name = "rbtnHoy";
            this.rbtnHoy.Size = new System.Drawing.Size(170, 21);
            this.rbtnHoy.TabIndex = 6;
            this.rbtnHoy.TabStop = true;
            this.rbtnHoy.Text = "Transferir para hoy";
            this.rbtnHoy.UseVisualStyleBackColor = true;
            this.rbtnHoy.CheckedChanged += new System.EventHandler(this.rbtnHoy_CheckedChanged);
            // 
            // btnCancelarClick
            // 
            this.btnCancelarClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarClick.Location = new System.Drawing.Point(290, 215);
            this.btnCancelarClick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarClick.Name = "btnCancelarClick";
            this.btnCancelarClick.Size = new System.Drawing.Size(125, 26);
            this.btnCancelarClick.TabIndex = 3;
            this.btnCancelarClick.Text = "Cancelar";
            this.btnCancelarClick.UseVisualStyleBackColor = true;
            this.btnCancelarClick.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscarPautas
            // 
            this.btnBuscarPautas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPautas.Location = new System.Drawing.Point(320, 52);
            this.btnBuscarPautas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarPautas.Name = "btnBuscarPautas";
            this.btnBuscarPautas.Size = new System.Drawing.Size(109, 26);
            this.btnBuscarPautas.TabIndex = 2;
            this.btnBuscarPautas.Text = "Buscar Pautas";
            this.btnBuscarPautas.UseVisualStyleBackColor = true;
            this.btnBuscarPautas.Click += new System.EventHandler(this.btnBuscarPautas_Click);
            // 
            // dtpFechaFiltro
            // 
            this.dtpFechaFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFiltro.Location = new System.Drawing.Point(19, 52);
            this.dtpFechaFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaFiltro.Name = "dtpFechaFiltro";
            this.dtpFechaFiltro.Size = new System.Drawing.Size(282, 23);
            this.dtpFechaFiltro.TabIndex = 0;
            this.dtpFechaFiltro.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // frmMaestroPautasClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 778);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblNombreUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataPautasClientes);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMaestroPautasClientes";
            this.Text = "Maestro Pautas de Clientes";
            this.Load += new System.EventHandler(this.frmMaestroPautasClientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPautasClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbDiarios;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDiarios;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataPautasClientes;
        private System.Windows.Forms.TextBox txtCantidadPromedio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNombreUser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpFechaFiltro;
        private System.Windows.Forms.Button btnBuscarPautas;
        private System.Windows.Forms.Button btnCancelarClick;
        private System.Windows.Forms.RadioButton rbtnMañana;
        private System.Windows.Forms.RadioButton rbtnHoy;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.RadioButton rbtnFechaHoyAgregar;
        private System.Windows.Forms.RadioButton rbtnFechaMañanaAgregar;
    }
}