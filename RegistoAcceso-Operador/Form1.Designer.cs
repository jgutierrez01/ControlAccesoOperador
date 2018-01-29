namespace RegistoAcceso_Operador
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabRegistroInicial = new System.Windows.Forms.TabPage();
            this.btnActualizarPantalla = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RegistroAccesoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistroPersonasID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsignacionGafeteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gafete1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gafete2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGafeteBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevaEntrada = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHistoricoSalidas = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFiltrarSalidas = new System.Windows.Forms.Button();
            this.FechaHasta = new System.Windows.Forms.DateTimePicker();
            this.FechaDesde = new System.Windows.Forms.DateTimePicker();
            this.gridHistoricoSalidas = new System.Windows.Forms.DataGridView();
            this.AsignacionGafeteID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GafeteAsignado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gafete111 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAsignacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDesAsignacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsAutobus1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asunto2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabRegistroInicial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabHistoricoSalidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistoricoSalidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabRegistroInicial
            // 
            this.tabRegistroInicial.Controls.Add(this.btnActualizarPantalla);
            this.tabRegistroInicial.Controls.Add(this.btnSalida);
            this.tabRegistroInicial.Controls.Add(this.dataGridView1);
            this.tabRegistroInicial.Controls.Add(this.txtGafeteBuscar);
            this.tabRegistroInicial.Controls.Add(this.label1);
            this.tabRegistroInicial.Controls.Add(this.btnNuevaEntrada);
            this.tabRegistroInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRegistroInicial.Location = new System.Drawing.Point(4, 33);
            this.tabRegistroInicial.Name = "tabRegistroInicial";
            this.tabRegistroInicial.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistroInicial.Size = new System.Drawing.Size(1296, 566);
            this.tabRegistroInicial.TabIndex = 0;
            this.tabRegistroInicial.Text = "Asignaciones Actuales";
            this.tabRegistroInicial.UseVisualStyleBackColor = true;
            // 
            // btnActualizarPantalla
            // 
            this.btnActualizarPantalla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarPantalla.Location = new System.Drawing.Point(13, 74);
            this.btnActualizarPantalla.Name = "btnActualizarPantalla";
            this.btnActualizarPantalla.Size = new System.Drawing.Size(176, 33);
            this.btnActualizarPantalla.TabIndex = 17;
            this.btnActualizarPantalla.Text = "Actualizar Pantalla";
            this.btnActualizarPantalla.UseVisualStyleBackColor = true;
            this.btnActualizarPantalla.Click += new System.EventHandler(this.btnActualizarPantalla_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalida.Location = new System.Drawing.Point(863, 17);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(198, 58);
            this.btnSalida.TabIndex = 16;
            this.btnSalida.Text = "Quitar Asignación";
            this.btnSalida.UseVisualStyleBackColor = true;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegistroAccesoID,
            this.RegistroPersonasID,
            this.AsignacionGafeteID,
            this.Nombre,
            this.Gafete1,
            this.Gafete2,
            this.Placa,
            this.FechaEntrada,
            this.HoraEntrada,
            this.Asunto,
            this.Departamento});
            this.dataGridView1.Location = new System.Drawing.Point(13, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1243, 434);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditarGafeteOperador);
            // 
            // RegistroAccesoID
            // 
            this.RegistroAccesoID.DataPropertyName = "RegistroAccesoID";
            this.RegistroAccesoID.HeaderText = "RegistroAccesoID";
            this.RegistroAccesoID.Name = "RegistroAccesoID";
            this.RegistroAccesoID.ReadOnly = true;
            this.RegistroAccesoID.Visible = false;
            // 
            // RegistroPersonasID
            // 
            this.RegistroPersonasID.DataPropertyName = "RegistroPersonasID";
            this.RegistroPersonasID.HeaderText = "RegistroPersonasID";
            this.RegistroPersonasID.Name = "RegistroPersonasID";
            this.RegistroPersonasID.ReadOnly = true;
            this.RegistroPersonasID.Visible = false;
            // 
            // AsignacionGafeteID
            // 
            this.AsignacionGafeteID.DataPropertyName = "AsignacionGafeteID";
            this.AsignacionGafeteID.HeaderText = "AsignacionGafeteID";
            this.AsignacionGafeteID.Name = "AsignacionGafeteID";
            this.AsignacionGafeteID.ReadOnly = true;
            this.AsignacionGafeteID.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 300;
            // 
            // Gafete1
            // 
            this.Gafete1.DataPropertyName = "Gafete1";
            this.Gafete1.HeaderText = "Gafete Administrador";
            this.Gafete1.Name = "Gafete1";
            this.Gafete1.ReadOnly = true;
            this.Gafete1.Width = 150;
            // 
            // Gafete2
            // 
            this.Gafete2.DataPropertyName = "Gafete2";
            this.Gafete2.HeaderText = "Gafete Operador";
            this.Gafete2.Name = "Gafete2";
            this.Gafete2.ReadOnly = true;
            this.Gafete2.Width = 200;
            // 
            // Placa
            // 
            this.Placa.DataPropertyName = "Placa";
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
            this.Placa.Width = 160;
            // 
            // FechaEntrada
            // 
            this.FechaEntrada.DataPropertyName = "FechaEntrada";
            dataGridViewCellStyle8.Format = "d";
            dataGridViewCellStyle8.NullValue = null;
            this.FechaEntrada.DefaultCellStyle = dataGridViewCellStyle8;
            this.FechaEntrada.HeaderText = "Fecha Entrada Admin";
            this.FechaEntrada.Name = "FechaEntrada";
            this.FechaEntrada.ReadOnly = true;
            this.FechaEntrada.Width = 190;
            // 
            // HoraEntrada
            // 
            this.HoraEntrada.DataPropertyName = "HoraEntrada";
            dataGridViewCellStyle9.Format = "t";
            dataGridViewCellStyle9.NullValue = null;
            this.HoraEntrada.DefaultCellStyle = dataGridViewCellStyle9;
            this.HoraEntrada.HeaderText = "Hora Entrada Admin";
            this.HoraEntrada.Name = "HoraEntrada";
            this.HoraEntrada.ReadOnly = true;
            this.HoraEntrada.Width = 190;
            // 
            // Asunto
            // 
            this.Asunto.DataPropertyName = "Asunto";
            this.Asunto.HeaderText = "Asunto";
            this.Asunto.Name = "Asunto";
            this.Asunto.ReadOnly = true;
            this.Asunto.Width = 200;
            // 
            // Departamento
            // 
            this.Departamento.DataPropertyName = "Departamento";
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            this.Departamento.ReadOnly = true;
            this.Departamento.Width = 200;
            // 
            // txtGafeteBuscar
            // 
            this.txtGafeteBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGafeteBuscar.Location = new System.Drawing.Point(164, 30);
            this.txtGafeteBuscar.Name = "txtGafeteBuscar";
            this.txtGafeteBuscar.Size = new System.Drawing.Size(269, 29);
            this.txtGafeteBuscar.TabIndex = 1;
            this.txtGafeteBuscar.TextChanged += new System.EventHandler(this.BuscarGafeteAsignadoEnGrid);
            this.txtGafeteBuscar.Enter += new System.EventHandler(this.BorrarGafeteOperador);
            this.txtGafeteBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ToUpper);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Gafete Operador";
            // 
            // btnNuevaEntrada
            // 
            this.btnNuevaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaEntrada.Location = new System.Drawing.Point(581, 17);
            this.btnNuevaEntrada.Name = "btnNuevaEntrada";
            this.btnNuevaEntrada.Size = new System.Drawing.Size(212, 58);
            this.btnNuevaEntrada.TabIndex = 1;
            this.btnNuevaEntrada.Text = "Asignación";
            this.btnNuevaEntrada.UseVisualStyleBackColor = true;
            this.btnNuevaEntrada.Click += new System.EventHandler(this.btnNuevaEntrada_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabRegistroInicial);
            this.tabControl1.Controls.Add(this.tabHistoricoSalidas);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(28, 86);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1304, 603);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.ActualizarHistoricoSalidas);
            // 
            // tabHistoricoSalidas
            // 
            this.tabHistoricoSalidas.Controls.Add(this.label2);
            this.tabHistoricoSalidas.Controls.Add(this.label3);
            this.tabHistoricoSalidas.Controls.Add(this.btnFiltrarSalidas);
            this.tabHistoricoSalidas.Controls.Add(this.FechaHasta);
            this.tabHistoricoSalidas.Controls.Add(this.FechaDesde);
            this.tabHistoricoSalidas.Controls.Add(this.gridHistoricoSalidas);
            this.tabHistoricoSalidas.Location = new System.Drawing.Point(4, 33);
            this.tabHistoricoSalidas.Name = "tabHistoricoSalidas";
            this.tabHistoricoSalidas.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistoricoSalidas.Size = new System.Drawing.Size(1296, 566);
            this.tabHistoricoSalidas.TabIndex = 2;
            this.tabHistoricoSalidas.Text = "Historico Asignaciones";
            this.tabHistoricoSalidas.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Fecha Entrada  Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(483, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Hasta";
            // 
            // btnFiltrarSalidas
            // 
            this.btnFiltrarSalidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarSalidas.Location = new System.Drawing.Point(847, 34);
            this.btnFiltrarSalidas.Name = "btnFiltrarSalidas";
            this.btnFiltrarSalidas.Size = new System.Drawing.Size(269, 40);
            this.btnFiltrarSalidas.TabIndex = 21;
            this.btnFiltrarSalidas.Text = "Filtrar Registros";
            this.btnFiltrarSalidas.UseVisualStyleBackColor = true;
            this.btnFiltrarSalidas.Click += new System.EventHandler(this.btnFiltrarSalidas_Click);
            // 
            // FechaHasta
            // 
            this.FechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaHasta.Location = new System.Drawing.Point(557, 39);
            this.FechaHasta.Name = "FechaHasta";
            this.FechaHasta.ShowCheckBox = true;
            this.FechaHasta.Size = new System.Drawing.Size(199, 29);
            this.FechaHasta.TabIndex = 20;
            // 
            // FechaDesde
            // 
            this.FechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDesde.Location = new System.Drawing.Point(242, 39);
            this.FechaDesde.Name = "FechaDesde";
            this.FechaDesde.ShowCheckBox = true;
            this.FechaDesde.Size = new System.Drawing.Size(200, 29);
            this.FechaDesde.TabIndex = 18;
            // 
            // gridHistoricoSalidas
            // 
            this.gridHistoricoSalidas.AllowUserToAddRows = false;
            this.gridHistoricoSalidas.AllowUserToDeleteRows = false;
            this.gridHistoricoSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHistoricoSalidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AsignacionGafeteID2,
            this.GafeteAsignado,
            this.Gafete111,
            this.Placa2,
            this.Nombre2,
            this.FechaAsignacion,
            this.FechaDesAsignacion,
            this.EsAutobus1,
            this.Departamento2,
            this.Asunto2});
            this.gridHistoricoSalidas.Location = new System.Drawing.Point(41, 117);
            this.gridHistoricoSalidas.Name = "gridHistoricoSalidas";
            this.gridHistoricoSalidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridHistoricoSalidas.Size = new System.Drawing.Size(1218, 415);
            this.gridHistoricoSalidas.TabIndex = 16;
            // 
            // AsignacionGafeteID2
            // 
            this.AsignacionGafeteID2.DataPropertyName = "AsignacionGafeteID";
            this.AsignacionGafeteID2.HeaderText = "AsignacionGafeteID";
            this.AsignacionGafeteID2.Name = "AsignacionGafeteID2";
            this.AsignacionGafeteID2.ReadOnly = true;
            this.AsignacionGafeteID2.Visible = false;
            this.AsignacionGafeteID2.Width = 50;
            // 
            // GafeteAsignado
            // 
            this.GafeteAsignado.DataPropertyName = "Gafete2";
            this.GafeteAsignado.FillWeight = 153.1915F;
            this.GafeteAsignado.HeaderText = "Gafete Operador";
            this.GafeteAsignado.Name = "GafeteAsignado";
            this.GafeteAsignado.ReadOnly = true;
            this.GafeteAsignado.Width = 200;
            // 
            // Gafete111
            // 
            this.Gafete111.DataPropertyName = "Gafete1";
            this.Gafete111.FillWeight = 83.7461F;
            this.Gafete111.HeaderText = "Gafete Administrador";
            this.Gafete111.Name = "Gafete111";
            this.Gafete111.ReadOnly = true;
            this.Gafete111.Width = 150;
            // 
            // Placa2
            // 
            this.Placa2.DataPropertyName = "Placa";
            this.Placa2.FillWeight = 53.57546F;
            this.Placa2.HeaderText = "Placa";
            this.Placa2.Name = "Placa2";
            this.Placa2.ReadOnly = true;
            this.Placa2.Width = 70;
            // 
            // Nombre2
            // 
            this.Nombre2.DataPropertyName = "Nombre";
            this.Nombre2.FillWeight = 205.2907F;
            this.Nombre2.HeaderText = "Nombre";
            this.Nombre2.Name = "Nombre2";
            this.Nombre2.ReadOnly = true;
            this.Nombre2.Width = 268;
            // 
            // FechaAsignacion
            // 
            this.FechaAsignacion.DataPropertyName = "FechaAsignacion";
            this.FechaAsignacion.HeaderText = "FechaAsignación";
            this.FechaAsignacion.Name = "FechaAsignacion";
            this.FechaAsignacion.ReadOnly = true;
            this.FechaAsignacion.Width = 200;
            // 
            // FechaDesAsignacion
            // 
            this.FechaDesAsignacion.DataPropertyName = "FechaSalida";
            this.FechaDesAsignacion.HeaderText = "Fecha Des-Asignación";
            this.FechaDesAsignacion.Name = "FechaDesAsignacion";
            this.FechaDesAsignacion.ReadOnly = true;
            this.FechaDesAsignacion.Width = 200;
            // 
            // EsAutobus1
            // 
            this.EsAutobus1.DataPropertyName = "EsAutobus";
            this.EsAutobus1.FillWeight = 50.12963F;
            this.EsAutobus1.HeaderText = "EsAutobus";
            this.EsAutobus1.Name = "EsAutobus1";
            this.EsAutobus1.ReadOnly = true;
            // 
            // Departamento2
            // 
            this.Departamento2.DataPropertyName = "Departamento";
            this.Departamento2.FillWeight = 101.4707F;
            this.Departamento2.HeaderText = "Departamento";
            this.Departamento2.Name = "Departamento2";
            this.Departamento2.ReadOnly = true;
            this.Departamento2.Width = 200;
            // 
            // Asunto2
            // 
            this.Asunto2.DataPropertyName = "Asunto";
            this.Asunto2.FillWeight = 93.94317F;
            this.Asunto2.HeaderText = "Asunto";
            this.Asunto2.Name = "Asunto2";
            this.Asunto2.ReadOnly = true;
            this.Asunto2.Width = 200;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1017, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 100);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 701);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Acceso Operador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabRegistroInicial.ResumeLayout(false);
            this.tabRegistroInicial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabHistoricoSalidas.ResumeLayout(false);
            this.tabHistoricoSalidas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistoricoSalidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabRegistroInicial;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtGafeteBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevaEntrada;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.TabPage tabHistoricoSalidas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFiltrarSalidas;
        private System.Windows.Forms.DateTimePicker FechaHasta;
        private System.Windows.Forms.DateTimePicker FechaDesde;
        private System.Windows.Forms.DataGridView gridHistoricoSalidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistroAccesoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistroPersonasID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AsignacionGafeteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gafete1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gafete2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.Button btnActualizarPantalla;
        private System.Windows.Forms.DataGridViewTextBoxColumn AsignacionGafeteID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn GafeteAsignado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gafete111;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAsignacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDesAsignacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn EsAutobus1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asunto2;
    }
}

