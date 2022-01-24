namespace TerminalesProyecto.Cooperativa.Forms
{
    partial class frmEncomiendas
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtnDesttinatario = new System.Windows.Forms.RadioButton();
            this.rbtnNGuia = new System.Windows.Forms.RadioButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaEnvio = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnDespachar = new System.Windows.Forms.Button();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.dgvEncomiendas = new System.Windows.Forms.DataGridView();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxLugarEnvio = new System.Windows.Forms.ComboBox();
            this.btnRecibir = new System.Windows.Forms.Button();
            this.rbtnRecibidas = new System.Windows.Forms.RadioButton();
            this.rbtnEnviadas = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncomiendas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnRecibidas);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.rbtnEnviadas);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(901, 127);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbxLugarEnvio);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.dtpFechaEnvio);
            this.groupBox3.Controls.Add(this.rbtnDesttinatario);
            this.groupBox3.Controls.Add(this.rbtnNGuia);
            this.groupBox3.Location = new System.Drawing.Point(439, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(458, 109);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Criterio de Busqueda";
            // 
            // rbtnDesttinatario
            // 
            this.rbtnDesttinatario.AutoSize = true;
            this.rbtnDesttinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbtnDesttinatario.Location = new System.Drawing.Point(107, 28);
            this.rbtnDesttinatario.Name = "rbtnDesttinatario";
            this.rbtnDesttinatario.Size = new System.Drawing.Size(113, 24);
            this.rbtnDesttinatario.TabIndex = 2;
            this.rbtnDesttinatario.Text = "Destinatario";
            this.rbtnDesttinatario.UseVisualStyleBackColor = true;
            // 
            // rbtnNGuia
            // 
            this.rbtnNGuia.AutoSize = true;
            this.rbtnNGuia.Checked = true;
            this.rbtnNGuia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbtnNGuia.Location = new System.Drawing.Point(16, 28);
            this.rbtnNGuia.Name = "rbtnNGuia";
            this.rbtnNGuia.Size = new System.Drawing.Size(85, 24);
            this.rbtnNGuia.TabIndex = 0;
            this.rbtnNGuia.TabStop = true;
            this.rbtnNGuia.Text = "N° Guia ";
            this.rbtnNGuia.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBuscar.Location = new System.Drawing.Point(81, 25);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(352, 26);
            this.txtBuscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // dtpFechaEnvio
            // 
            this.dtpFechaEnvio.Location = new System.Drawing.Point(240, 32);
            this.dtpFechaEnvio.Name = "dtpFechaEnvio";
            this.dtpFechaEnvio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaEnvio.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRecibir);
            this.groupBox2.Controls.Add(this.btnRegistar);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnDespachar);
            this.groupBox2.Controls.Add(this.btnDetalles);
            this.groupBox2.Controls.Add(this.dgvEncomiendas);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(0, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(901, 289);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Encomiendas";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEliminar.Location = new System.Drawing.Point(259, 19);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(69, 46);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnDespachar
            // 
            this.btnDespachar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDespachar.Location = new System.Drawing.Point(168, 19);
            this.btnDespachar.Name = "btnDespachar";
            this.btnDespachar.Size = new System.Drawing.Size(85, 46);
            this.btnDespachar.TabIndex = 4;
            this.btnDespachar.Text = "Despachar";
            this.btnDespachar.UseVisualStyleBackColor = true;
            // 
            // btnDetalles
            // 
            this.btnDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDetalles.Location = new System.Drawing.Point(93, 19);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(69, 46);
            this.btnDetalles.TabIndex = 2;
            this.btnDetalles.Text = "Detalles";
            this.btnDetalles.UseVisualStyleBackColor = true;
            // 
            // dgvEncomiendas
            // 
            this.dgvEncomiendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEncomiendas.Location = new System.Drawing.Point(6, 71);
            this.dgvEncomiendas.Name = "dgvEncomiendas";
            this.dgvEncomiendas.Size = new System.Drawing.Size(873, 197);
            this.dgvEncomiendas.TabIndex = 0;
            // 
            // btnRegistar
            // 
            this.btnRegistar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRegistar.Location = new System.Drawing.Point(6, 19);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(81, 46);
            this.btnRegistar.TabIndex = 4;
            this.btnRegistar.Text = "Registrar Nuevo";
            this.btnRegistar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Envio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lugar Envio";
            // 
            // cbxLugarEnvio
            // 
            this.cbxLugarEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxLugarEnvio.FormattingEnabled = true;
            this.cbxLugarEnvio.Location = new System.Drawing.Point(111, 70);
            this.cbxLugarEnvio.Name = "cbxLugarEnvio";
            this.cbxLugarEnvio.Size = new System.Drawing.Size(154, 28);
            this.cbxLugarEnvio.TabIndex = 6;
            // 
            // btnRecibir
            // 
            this.btnRecibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRecibir.Location = new System.Drawing.Point(334, 19);
            this.btnRecibir.Name = "btnRecibir";
            this.btnRecibir.Size = new System.Drawing.Size(81, 46);
            this.btnRecibir.TabIndex = 6;
            this.btnRecibir.Text = "Recibir ";
            this.btnRecibir.UseVisualStyleBackColor = true;
            // 
            // rbtnRecibidas
            // 
            this.rbtnRecibidas.AutoSize = true;
            this.rbtnRecibidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbtnRecibidas.Location = new System.Drawing.Point(12, 87);
            this.rbtnRecibidas.Name = "rbtnRecibidas";
            this.rbtnRecibidas.Size = new System.Drawing.Size(97, 24);
            this.rbtnRecibidas.TabIndex = 8;
            this.rbtnRecibidas.Text = "Recibidas";
            this.rbtnRecibidas.UseVisualStyleBackColor = true;
            // 
            // rbtnEnviadas
            // 
            this.rbtnEnviadas.AutoSize = true;
            this.rbtnEnviadas.Checked = true;
            this.rbtnEnviadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbtnEnviadas.Location = new System.Drawing.Point(12, 57);
            this.rbtnEnviadas.Name = "rbtnEnviadas";
            this.rbtnEnviadas.Size = new System.Drawing.Size(92, 24);
            this.rbtnEnviadas.TabIndex = 7;
            this.rbtnEnviadas.TabStop = true;
            this.rbtnEnviadas.Text = "Enviadas";
            this.rbtnEnviadas.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelar.Location = new System.Drawing.Point(703, 422);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 46);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAceptar.Location = new System.Drawing.Point(798, 422);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(81, 46);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // frmEncomiendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 469);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEncomiendas";
            this.Text = "frmEncomiendas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncomiendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtnDesttinatario;
        private System.Windows.Forms.RadioButton rbtnNGuia;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaEnvio;
        private System.Windows.Forms.RadioButton rbtnRecibidas;
        private System.Windows.Forms.ComboBox cbxLugarEnvio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnEnviadas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRecibir;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnDespachar;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.DataGridView dgvEncomiendas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}