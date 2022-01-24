namespace TerminalesProyecto.Cooperativa.Forms
{
    partial class frmEncomiendaRegistrar
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
            this.txtRemitente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblFehaHora = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefonoDesti = new System.Windows.Forms.TextBox();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCedulaDesti = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxDestino = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.dgvDetalleEnc = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.txtCedulaRuc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleEnc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 418);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Encomienda ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtRemitente
            // 
            this.txtRemitente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRemitente.Location = new System.Drawing.Point(104, 56);
            this.txtRemitente.Name = "txtRemitente";
            this.txtRemitente.Size = new System.Drawing.Size(403, 26);
            this.txtRemitente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(9, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(296, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar ";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblFehaHora
            // 
            this.lblFehaHora.AutoSize = true;
            this.lblFehaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFehaHora.Location = new System.Drawing.Point(627, 19);
            this.lblFehaHora.Name = "lblFehaHora";
            this.lblFehaHora.Size = new System.Drawing.Size(155, 20);
            this.lblFehaHora.TabIndex = 3;
            this.lblFehaHora.Tag = "Fecha ";
            this.lblFehaHora.Text = "MM/DD/AA   HH:MM";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTelefono.Location = new System.Drawing.Point(625, 56);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(163, 26);
            this.txtTelefono.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(548, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Télefono";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCedulaRuc);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbxEstado);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTelefono);
            this.groupBox2.Controls.Add(this.txtRemitente);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.lblFehaHora);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.ForeColor = System.Drawing.Color.Teal;
            this.groupBox2.Location = new System.Drawing.Point(3, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(814, 143);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remitente";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cbxDestino);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtTelefonoDesti);
            this.groupBox3.Controls.Add(this.txtDestinatario);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtCedulaDesti);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox3.Location = new System.Drawing.Point(3, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(814, 107);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Destinatario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Destinatario";
            // 
            // txtTelefonoDesti
            // 
            this.txtTelefonoDesti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTelefonoDesti.Location = new System.Drawing.Point(350, 56);
            this.txtTelefonoDesti.Name = "txtTelefonoDesti";
            this.txtTelefonoDesti.Size = new System.Drawing.Size(207, 26);
            this.txtTelefonoDesti.TabIndex = 7;
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDestinatario.Location = new System.Drawing.Point(104, 13);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(403, 26);
            this.txtDestinatario.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(273, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Télefono";
            // 
            // txtCedulaDesti
            // 
            this.txtCedulaDesti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCedulaDesti.Location = new System.Drawing.Point(104, 56);
            this.txtCedulaDesti.Name = "txtCedulaDesti";
            this.txtCedulaDesti.Size = new System.Drawing.Size(163, 26);
            this.txtCedulaDesti.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(6, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Cedula/Ruc";
            // 
            // cbxDestino
            // 
            this.cbxDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxDestino.FormattingEnabled = true;
            this.cbxDestino.Location = new System.Drawing.Point(596, 13);
            this.cbxDestino.Name = "cbxDestino";
            this.cbxDestino.Size = new System.Drawing.Size(172, 28);
            this.cbxDestino.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(519, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Destino";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAgregar);
            this.groupBox4.Controls.Add(this.BtnEliminar);
            this.groupBox4.Controls.Add(this.dgvDetalleEnc);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox4.Location = new System.Drawing.Point(3, 266);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(814, 164);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detalle de Encomienda ";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAgregar.Location = new System.Drawing.Point(699, 22);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(69, 46);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnEliminar.Location = new System.Drawing.Point(699, 74);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(69, 46);
            this.BtnEliminar.TabIndex = 2;
            this.BtnEliminar.Text = "-";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvDetalleEnc
            // 
            this.dgvDetalleEnc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleEnc.Location = new System.Drawing.Point(6, 22);
            this.dgvDetalleEnc.Name = "dgvDetalleEnc";
            this.dgvDetalleEnc.Size = new System.Drawing.Size(674, 124);
            this.dgvDetalleEnc.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(9, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Estado";
            // 
            // cbxEstado
            // 
            this.cbxEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(101, 96);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(151, 28);
            this.cbxEstado.TabIndex = 12;
            this.cbxEstado.SelectedIndexChanged += new System.EventHandler(this.cbxEstado_SelectedIndexChanged);
            // 
            // txtCedulaRuc
            // 
            this.txtCedulaRuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCedulaRuc.Location = new System.Drawing.Point(104, 16);
            this.txtCedulaRuc.Name = "txtCedulaRuc";
            this.txtCedulaRuc.Size = new System.Drawing.Size(174, 26);
            this.txtCedulaRuc.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cedula/Ruc";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRegistrar.Location = new System.Drawing.Point(716, 441);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(81, 27);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar ";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelar.Location = new System.Drawing.Point(634, 441);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 27);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(552, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmEncomienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 480);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEncomienda";
            this.Text = "frmEncomienda";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleEnc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRemitente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFehaHora;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxDestino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefonoDesti;
        private System.Windows.Forms.TextBox txtDestinatario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCedulaDesti;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.DataGridView dgvDetalleEnc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.TextBox txtCedulaRuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button button1;
    }
}