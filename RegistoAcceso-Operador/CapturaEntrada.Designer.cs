namespace RegistoAcceso_Operador
{
    partial class CapturaEntrada
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
            this.txtGafete1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGafeteAsignado = new System.Windows.Forms.TextBox();
            this.lblGafeteOperador = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtFechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtRegistroAccesoID = new System.Windows.Forms.TextBox();
            this.txtRegistroPersonaID = new System.Windows.Forms.TextBox();
            this.txtAsignacionGafeteID = new System.Windows.Forms.TextBox();
            this.lblGafeteAnterior = new System.Windows.Forms.Label();
            this.txtGafeteAnterior = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtGafete1
            // 
            this.txtGafete1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGafete1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtGafete1.Location = new System.Drawing.Point(179, 31);
            this.txtGafete1.Name = "txtGafete1";
            this.txtGafete1.Size = new System.Drawing.Size(380, 30);
            this.txtGafete1.TabIndex = 1;
            this.txtGafete1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MuestraInformacion);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gafete Admin";
            // 
            // txtGafeteAsignado
            // 
            this.txtGafeteAsignado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGafeteAsignado.Enabled = false;
            this.txtGafeteAsignado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtGafeteAsignado.Location = new System.Drawing.Point(615, 112);
            this.txtGafeteAsignado.Name = "txtGafeteAsignado";
            this.txtGafeteAsignado.Size = new System.Drawing.Size(349, 30);
            this.txtGafeteAsignado.TabIndex = 8;
            this.txtGafeteAsignado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AsignarGafeteOperador);
            this.txtGafeteAsignado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValidarSintaxisGafete);
            // 
            // lblGafeteOperador
            // 
            this.lblGafeteOperador.AutoSize = true;
            this.lblGafeteOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGafeteOperador.Location = new System.Drawing.Point(715, 84);
            this.lblGafeteOperador.Name = "lblGafeteOperador";
            this.lblGafeteOperador.Size = new System.Drawing.Size(158, 25);
            this.lblGafeteOperador.TabIndex = 7;
            this.lblGafeteOperador.Text = "Gafete Operador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Asunto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Departamento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Descripcion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "FechaEntradaAdmin";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtNombre.Location = new System.Drawing.Point(179, 93);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(380, 30);
            this.txtNombre.TabIndex = 14;
            // 
            // txtAsunto
            // 
            this.txtAsunto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAsunto.Enabled = false;
            this.txtAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtAsunto.Location = new System.Drawing.Point(179, 149);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(380, 30);
            this.txtAsunto.TabIndex = 15;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDepartamento.Enabled = false;
            this.txtDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtDepartamento.Location = new System.Drawing.Point(179, 205);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(380, 30);
            this.txtDepartamento.TabIndex = 16;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtDescripcion.Location = new System.Drawing.Point(179, 259);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(380, 30);
            this.txtDescripcion.TabIndex = 17;
            // 
            // txtFechaEntrada
            // 
            this.txtFechaEntrada.Enabled = false;
            this.txtFechaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtFechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaEntrada.Location = new System.Drawing.Point(213, 312);
            this.txtFechaEntrada.Name = "txtFechaEntrada";
            this.txtFechaEntrada.Size = new System.Drawing.Size(346, 30);
            this.txtFechaEntrada.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "HoraEntradaAdmin";
            // 
            // txtHoraEntrada
            // 
            this.txtHoraEntrada.Enabled = false;
            this.txtHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtHoraEntrada.Location = new System.Drawing.Point(213, 368);
            this.txtHoraEntrada.Name = "txtHoraEntrada";
            this.txtHoraEntrada.Size = new System.Drawing.Size(346, 30);
            this.txtHoraEntrada.TabIndex = 20;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(675, 158);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(228, 88);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(671, 285);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(228, 88);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtRegistroAccesoID
            // 
            this.txtRegistroAccesoID.Location = new System.Drawing.Point(675, 423);
            this.txtRegistroAccesoID.Name = "txtRegistroAccesoID";
            this.txtRegistroAccesoID.Size = new System.Drawing.Size(223, 20);
            this.txtRegistroAccesoID.TabIndex = 23;
            this.txtRegistroAccesoID.Visible = false;
            // 
            // txtRegistroPersonaID
            // 
            this.txtRegistroPersonaID.Location = new System.Drawing.Point(675, 397);
            this.txtRegistroPersonaID.Name = "txtRegistroPersonaID";
            this.txtRegistroPersonaID.Size = new System.Drawing.Size(223, 20);
            this.txtRegistroPersonaID.TabIndex = 24;
            this.txtRegistroPersonaID.Visible = false;
            // 
            // txtAsignacionGafeteID
            // 
            this.txtAsignacionGafeteID.Location = new System.Drawing.Point(550, 423);
            this.txtAsignacionGafeteID.Name = "txtAsignacionGafeteID";
            this.txtAsignacionGafeteID.Size = new System.Drawing.Size(100, 20);
            this.txtAsignacionGafeteID.TabIndex = 25;
            this.txtAsignacionGafeteID.Visible = false;
            // 
            // lblGafeteAnterior
            // 
            this.lblGafeteAnterior.AutoSize = true;
            this.lblGafeteAnterior.Enabled = false;
            this.lblGafeteAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGafeteAnterior.Location = new System.Drawing.Point(670, 9);
            this.lblGafeteAnterior.Name = "lblGafeteAnterior";
            this.lblGafeteAnterior.Size = new System.Drawing.Size(218, 25);
            this.lblGafeteAnterior.TabIndex = 26;
            this.lblGafeteAnterior.Text = "Gafete Operador Actual";
            this.lblGafeteAnterior.Visible = false;
            // 
            // txtGafeteAnterior
            // 
            this.txtGafeteAnterior.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGafeteAnterior.Enabled = false;
            this.txtGafeteAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtGafeteAnterior.Location = new System.Drawing.Point(615, 37);
            this.txtGafeteAnterior.Name = "txtGafeteAnterior";
            this.txtGafeteAnterior.Size = new System.Drawing.Size(349, 30);
            this.txtGafeteAnterior.TabIndex = 27;
            this.txtGafeteAnterior.Visible = false;
            // 
            // CapturaEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 460);
            this.Controls.Add(this.txtGafeteAnterior);
            this.Controls.Add(this.lblGafeteAnterior);
            this.Controls.Add(this.txtAsignacionGafeteID);
            this.Controls.Add(this.txtRegistroPersonaID);
            this.Controls.Add(this.txtRegistroAccesoID);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtHoraEntrada);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFechaEntrada);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGafeteAsignado);
            this.Controls.Add(this.lblGafeteOperador);
            this.Controls.Add(this.txtGafete1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "CapturaEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar Gafete Operador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGafete1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGafeteAsignado;
        private System.Windows.Forms.Label lblGafeteOperador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DateTimePicker txtFechaEntrada;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker txtHoraEntrada;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtRegistroAccesoID;
        private System.Windows.Forms.TextBox txtRegistroPersonaID;
        private System.Windows.Forms.TextBox txtAsignacionGafeteID;
        private System.Windows.Forms.Label lblGafeteAnterior;
        private System.Windows.Forms.TextBox txtGafeteAnterior;
    }
}