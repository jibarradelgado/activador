namespace Activador.mClientes
{
    partial class FrmClientes
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
            this.components = new System.ComponentModel.Container();
            this.tbcCliente = new System.Windows.Forms.TabControl();
            this.tbpCliente = new System.Windows.Forms.TabPage();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbpDomicilio = new System.Windows.Forms.TabPage();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblNoInterior = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.txtInterior = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.dEstadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNoExterior = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.txtExterior = new System.Windows.Forms.TextBox();
            this.cmbMunicipio = new System.Windows.Forms.ComboBox();
            this.cMunicipioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDomicilioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteSistemaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlFormulario.SuspendLayout();
            this.grbDatos.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.tbcCliente.SuspendLayout();
            this.tbpCliente.SuspendLayout();
            this.tbpDomicilio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dEstadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMunicipioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.Controls.Add(this.tbcCliente);
            this.pnlFormulario.Size = new System.Drawing.Size(712, 177);
            // 
            // grbDatos
            // 
            this.grbDatos.Location = new System.Drawing.Point(0, 211);
            this.grbDatos.Size = new System.Drawing.Size(715, 171);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.dgvDatos);
            this.pnlDatos.Size = new System.Drawing.Size(709, 152);
            // 
            // errProvider
            // 
            this.errProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            // 
            // tbcCliente
            // 
            this.tbcCliente.Controls.Add(this.tbpCliente);
            this.tbcCliente.Controls.Add(this.tbpDomicilio);
            this.tbcCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcCliente.Location = new System.Drawing.Point(0, 0);
            this.tbcCliente.Name = "tbcCliente";
            this.tbcCliente.SelectedIndex = 0;
            this.tbcCliente.Size = new System.Drawing.Size(712, 177);
            this.tbcCliente.TabIndex = 0;
            // 
            // tbpCliente
            // 
            this.tbpCliente.AutoScroll = true;
            this.tbpCliente.BackColor = System.Drawing.Color.Transparent;
            this.tbpCliente.Controls.Add(this.lblEmail);
            this.tbpCliente.Controls.Add(this.lblCelular);
            this.tbpCliente.Controls.Add(this.lblTelefono);
            this.tbpCliente.Controls.Add(this.txtEmail);
            this.tbpCliente.Controls.Add(this.txtCelular);
            this.tbpCliente.Controls.Add(this.txtTelefono);
            this.tbpCliente.Controls.Add(this.txtApellido);
            this.tbpCliente.Controls.Add(this.lblApellido);
            this.tbpCliente.Controls.Add(this.txtNombre);
            this.tbpCliente.Controls.Add(this.lblNombre);
            this.tbpCliente.Location = new System.Drawing.Point(4, 22);
            this.tbpCliente.Name = "tbpCliente";
            this.tbpCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCliente.Size = new System.Drawing.Size(704, 151);
            this.tbpCliente.TabIndex = 0;
            this.tbpCliente.Text = "Datos del cliente";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(9, 121);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(43, 15);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "E-mail";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(9, 94);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(46, 15);
            this.lblCelular.TabIndex = 8;
            this.lblCelular.Text = "Celular";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(9, 67);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(55, 15);
            this.lblTelefono.TabIndex = 7;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(96, 118);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(134, 21);
            this.txtEmail.TabIndex = 6;
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(96, 91);
            this.txtCelular.MaxLength = 50;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(134, 21);
            this.txtCelular.TabIndex = 5;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(96, 64);
            this.txtTelefono.MaxLength = 50;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(134, 21);
            this.txtTelefono.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(96, 37);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(134, 21);
            this.txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(9, 40);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 15);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(96, 10);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(134, 21);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(8, 13);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(52, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // tbpDomicilio
            // 
            this.tbpDomicilio.AutoScroll = true;
            this.tbpDomicilio.BackColor = System.Drawing.Color.Transparent;
            this.tbpDomicilio.Controls.Add(this.txtPais);
            this.tbpDomicilio.Controls.Add(this.label1);
            this.tbpDomicilio.Controls.Add(this.lblCalle);
            this.tbpDomicilio.Controls.Add(this.txtCalle);
            this.tbpDomicilio.Controls.Add(this.lblNoInterior);
            this.tbpDomicilio.Controls.Add(this.lblEstado);
            this.tbpDomicilio.Controls.Add(this.txtReferencia);
            this.tbpDomicilio.Controls.Add(this.txtLocalidad);
            this.tbpDomicilio.Controls.Add(this.txtInterior);
            this.tbpDomicilio.Controls.Add(this.cmbEstado);
            this.tbpDomicilio.Controls.Add(this.label9);
            this.tbpDomicilio.Controls.Add(this.label6);
            this.tbpDomicilio.Controls.Add(this.lblNoExterior);
            this.tbpDomicilio.Controls.Add(this.label7);
            this.tbpDomicilio.Controls.Add(this.txtCP);
            this.tbpDomicilio.Controls.Add(this.txtColonia);
            this.tbpDomicilio.Controls.Add(this.txtExterior);
            this.tbpDomicilio.Controls.Add(this.cmbMunicipio);
            this.tbpDomicilio.Controls.Add(this.label8);
            this.tbpDomicilio.Controls.Add(this.label5);
            this.tbpDomicilio.Location = new System.Drawing.Point(4, 22);
            this.tbpDomicilio.Name = "tbpDomicilio";
            this.tbpDomicilio.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDomicilio.Size = new System.Drawing.Size(704, 151);
            this.tbpDomicilio.TabIndex = 1;
            this.tbpDomicilio.Text = "Domicilio";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(398, 14);
            this.txtPais.MaxLength = 50;
            this.txtPais.Name = "txtPais";
            this.txtPais.ReadOnly = true;
            this.txtPais.Size = new System.Drawing.Size(127, 20);
            this.txtPais.TabIndex = 39;
            this.txtPais.Text = "México";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "Pais";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.Location = new System.Drawing.Point(8, 15);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(35, 15);
            this.lblCalle.TabIndex = 19;
            this.lblCalle.Text = "Calle";
            // 
            // txtCalle
            // 
            this.txtCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalle.Location = new System.Drawing.Point(83, 12);
            this.txtCalle.MaxLength = 50;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(214, 21);
            this.txtCalle.TabIndex = 20;
            // 
            // lblNoInterior
            // 
            this.lblNoInterior.AutoSize = true;
            this.lblNoInterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoInterior.Location = new System.Drawing.Point(8, 42);
            this.lblNoInterior.Name = "lblNoInterior";
            this.lblNoInterior.Size = new System.Drawing.Size(64, 15);
            this.lblNoInterior.TabIndex = 21;
            this.lblNoInterior.Text = "No interior";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(331, 42);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(45, 15);
            this.lblEstado.TabIndex = 33;
            this.lblEstado.Text = "Estado";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferencia.Location = new System.Drawing.Point(83, 120);
            this.txtReferencia.MaxLength = 100;
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(214, 21);
            this.txtReferencia.TabIndex = 30;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalidad.Location = new System.Drawing.Point(83, 93);
            this.txtLocalidad.MaxLength = 50;
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(135, 21);
            this.txtLocalidad.TabIndex = 28;
            // 
            // txtInterior
            // 
            this.txtInterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterior.Location = new System.Drawing.Point(83, 39);
            this.txtInterior.MaxLength = 10;
            this.txtInterior.Name = "txtInterior";
            this.txtInterior.Size = new System.Drawing.Size(51, 21);
            this.txtInterior.TabIndex = 22;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DataSource = this.dEstadoBindingSource;
            this.cmbEstado.DisplayMember = "Nombre";
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(398, 39);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(127, 23);
            this.cmbEstado.TabIndex = 34;
            this.cmbEstado.ValueMember = "iddEstado";
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cboEstado_SelectedIndexChanged);
            // 
            // dEstadoBindingSource
            // 
            this.dEstadoBindingSource.DataSource = typeof(Activador.dEstado);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 29;
            this.label9.Text = "Referencia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "Localidad";
            // 
            // lblNoExterior
            // 
            this.lblNoExterior.AutoSize = true;
            this.lblNoExterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoExterior.Location = new System.Drawing.Point(176, 42);
            this.lblNoExterior.Name = "lblNoExterior";
            this.lblNoExterior.Size = new System.Drawing.Size(67, 15);
            this.lblNoExterior.TabIndex = 23;
            this.lblNoExterior.Text = "No exterior";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(331, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "Municipio";
            // 
            // txtCP
            // 
            this.txtCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCP.Location = new System.Drawing.Point(398, 95);
            this.txtCP.MaxLength = 10;
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(44, 21);
            this.txtCP.TabIndex = 38;
            // 
            // txtColonia
            // 
            this.txtColonia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColonia.Location = new System.Drawing.Point(83, 66);
            this.txtColonia.MaxLength = 50;
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(135, 21);
            this.txtColonia.TabIndex = 26;
            // 
            // txtExterior
            // 
            this.txtExterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExterior.Location = new System.Drawing.Point(249, 39);
            this.txtExterior.MaxLength = 10;
            this.txtExterior.Name = "txtExterior";
            this.txtExterior.Size = new System.Drawing.Size(48, 21);
            this.txtExterior.TabIndex = 24;
            // 
            // cmbMunicipio
            // 
            this.cmbMunicipio.DataSource = this.cMunicipioBindingSource;
            this.cmbMunicipio.DisplayMember = "Municipio";
            this.cmbMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMunicipio.FormattingEnabled = true;
            this.cmbMunicipio.Location = new System.Drawing.Point(398, 66);
            this.cmbMunicipio.Name = "cmbMunicipio";
            this.cmbMunicipio.Size = new System.Drawing.Size(127, 23);
            this.cmbMunicipio.TabIndex = 36;
            this.cmbMunicipio.ValueMember = "idcMunicipio";
            // 
            // cMunicipioBindingSource
            // 
            this.cMunicipioBindingSource.DataSource = typeof(Activador.cMunicipio);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(331, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 15);
            this.label8.TabIndex = 37;
            this.label8.Text = "CP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Colonia";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AutoGenerateColumns = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClienteDataGridViewTextBoxColumn,
            this.idDomicilioDataGridViewTextBoxColumn,
            this.nombreClienteDataGridViewTextBoxColumn,
            this.apellidoClienteDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.domicilioDataGridViewTextBoxColumn,
            this.clienteSistemaDataGridViewTextBoxColumn});
            this.dgvDatos.DataSource = this.clienteBindingSource;
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(0, 0);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(709, 152);
            this.dgvDatos.TabIndex = 1;
            this.dgvDatos.SelectionChanged += new System.EventHandler(this.dgvDatos_SelectionChanged);
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDomicilioDataGridViewTextBoxColumn
            // 
            this.idDomicilioDataGridViewTextBoxColumn.DataPropertyName = "idDomicilio";
            this.idDomicilioDataGridViewTextBoxColumn.HeaderText = "idDomicilio";
            this.idDomicilioDataGridViewTextBoxColumn.Name = "idDomicilioDataGridViewTextBoxColumn";
            this.idDomicilioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDomicilioDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreClienteDataGridViewTextBoxColumn
            // 
            this.nombreClienteDataGridViewTextBoxColumn.DataPropertyName = "NombreCliente";
            this.nombreClienteDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreClienteDataGridViewTextBoxColumn.Name = "nombreClienteDataGridViewTextBoxColumn";
            this.nombreClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoClienteDataGridViewTextBoxColumn
            // 
            this.apellidoClienteDataGridViewTextBoxColumn.DataPropertyName = "ApellidoCliente";
            this.apellidoClienteDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoClienteDataGridViewTextBoxColumn.Name = "apellidoClienteDataGridViewTextBoxColumn";
            this.apellidoClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "Celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            this.celularDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // domicilioDataGridViewTextBoxColumn
            // 
            this.domicilioDataGridViewTextBoxColumn.DataPropertyName = "Domicilio";
            this.domicilioDataGridViewTextBoxColumn.HeaderText = "Domicilio";
            this.domicilioDataGridViewTextBoxColumn.Name = "domicilioDataGridViewTextBoxColumn";
            this.domicilioDataGridViewTextBoxColumn.ReadOnly = true;
            this.domicilioDataGridViewTextBoxColumn.Visible = false;
            // 
            // clienteSistemaDataGridViewTextBoxColumn
            // 
            this.clienteSistemaDataGridViewTextBoxColumn.DataPropertyName = "ClienteSistema";
            this.clienteSistemaDataGridViewTextBoxColumn.HeaderText = "ClienteSistema";
            this.clienteSistemaDataGridViewTextBoxColumn.Name = "clienteSistemaDataGridViewTextBoxColumn";
            this.clienteSistemaDataGridViewTextBoxColumn.ReadOnly = true;
            this.clienteSistemaDataGridViewTextBoxColumn.Visible = false;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Activador.Cliente);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 385);
            this.Name = "FrmClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.pnlFormulario.ResumeLayout(false);
            this.grbDatos.ResumeLayout(false);
            this.pnlDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.tbcCliente.ResumeLayout(false);
            this.tbpCliente.ResumeLayout(false);
            this.tbpCliente.PerformLayout();
            this.tbpDomicilio.ResumeLayout(false);
            this.tbpDomicilio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dEstadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMunicipioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCliente;
        private System.Windows.Forms.TabPage tbpCliente;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TabPage tbpDomicilio;
        private System.Windows.Forms.Label lblCalle;
        public System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblNoInterior;
        private System.Windows.Forms.Label lblEstado;
        public System.Windows.Forms.TextBox txtReferencia;
        public System.Windows.Forms.TextBox txtLocalidad;
        public System.Windows.Forms.TextBox txtInterior;
        public System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNoExterior;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtCP;
        public System.Windows.Forms.TextBox txtColonia;
        public System.Windows.Forms.TextBox txtExterior;
        public System.Windows.Forms.ComboBox cmbMunicipio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDomicilioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteSistemaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.BindingSource dEstadoBindingSource;
        private System.Windows.Forms.BindingSource cMunicipioBindingSource;


    }
}