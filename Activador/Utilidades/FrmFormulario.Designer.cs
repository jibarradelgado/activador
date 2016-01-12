namespace Activador.Utilidades
{
    partial class FrmFormulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFormulario));
            this.tsmMenu = new System.Windows.Forms.ToolStrip();
            this.tsbtnNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.tstxtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.tscmbBuscar = new System.Windows.Forms.ToolStripComboBox();
            this.tstxbLimpiarBusqueda = new System.Windows.Forms.ToolStripButton();
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tsmMenu.SuspendLayout();
            this.grbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tsmMenu
            // 
            this.tsmMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsmMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnNuevo,
            this.tsbtnGuardar,
            this.tsbtnModificar,
            this.tsbtnEliminar,
            this.tsbtnCancelar,
            this.tstxtBuscar,
            this.tscmbBuscar,
            this.tstxbLimpiarBusqueda});
            this.tsmMenu.Location = new System.Drawing.Point(0, 0);
            this.tsmMenu.Name = "tsmMenu";
            this.tsmMenu.Size = new System.Drawing.Size(763, 25);
            this.tsmMenu.TabIndex = 5;
            // 
            // tsbtnNuevo
            // 
            this.tsbtnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnNuevo.Image")));
            this.tsbtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnNuevo.Name = "tsbtnNuevo";
            this.tsbtnNuevo.Size = new System.Drawing.Size(46, 22);
            this.tsbtnNuevo.Text = "&Nuevo";
            this.tsbtnNuevo.Click += new System.EventHandler(this.tsbtnNuevo_Click);
            // 
            // tsbtnGuardar
            // 
            this.tsbtnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnGuardar.Image")));
            this.tsbtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnGuardar.Name = "tsbtnGuardar";
            this.tsbtnGuardar.Size = new System.Drawing.Size(53, 22);
            this.tsbtnGuardar.Text = "&Guardar";
            this.tsbtnGuardar.Click += new System.EventHandler(this.tsbtnGuardar_Click);
            // 
            // tsbtnModificar
            // 
            this.tsbtnModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnModificar.Image")));
            this.tsbtnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnModificar.Name = "tsbtnModificar";
            this.tsbtnModificar.Size = new System.Drawing.Size(62, 22);
            this.tsbtnModificar.Text = "&Modificar";
            this.tsbtnModificar.Click += new System.EventHandler(this.tsbtnModificar_Click);
            // 
            // tsbtnEliminar
            // 
            this.tsbtnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEliminar.Image")));
            this.tsbtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEliminar.Name = "tsbtnEliminar";
            this.tsbtnEliminar.Size = new System.Drawing.Size(54, 22);
            this.tsbtnEliminar.Text = "&Eliminar";
            this.tsbtnEliminar.Click += new System.EventHandler(this.tsbtnEliminar_Click);
            // 
            // tsbtnCancelar
            // 
            this.tsbtnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCancelar.Image")));
            this.tsbtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCancelar.Name = "tsbtnCancelar";
            this.tsbtnCancelar.Size = new System.Drawing.Size(57, 22);
            this.tsbtnCancelar.Text = "&Cancelar";
            this.tsbtnCancelar.Click += new System.EventHandler(this.tsbtnCancelar_Click);
            // 
            // tstxtBuscar
            // 
            this.tstxtBuscar.Name = "tstxtBuscar";
            this.tstxtBuscar.Size = new System.Drawing.Size(100, 25);
            // 
            // tscmbBuscar
            // 
            this.tscmbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscmbBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.tscmbBuscar.Name = "tscmbBuscar";
            this.tscmbBuscar.Size = new System.Drawing.Size(121, 25);
            // 
            // tstxbLimpiarBusqueda
            // 
            this.tstxbLimpiarBusqueda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstxbLimpiarBusqueda.Name = "tstxbLimpiarBusqueda";
            this.tstxbLimpiarBusqueda.Size = new System.Drawing.Size(106, 22);
            this.tstxbLimpiarBusqueda.Text = "&Limpiar búsqueda";
            this.tstxbLimpiarBusqueda.Visible = false;
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFormulario.AutoScroll = true;
            this.pnlFormulario.Location = new System.Drawing.Point(0, 28);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(763, 159);
            this.pnlFormulario.TabIndex = 6;
            // 
            // grbDatos
            // 
            this.grbDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDatos.Controls.Add(this.pnlDatos);
            this.grbDatos.Location = new System.Drawing.Point(0, 193);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(763, 150);
            this.grbDatos.TabIndex = 7;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Registros";
            // 
            // pnlDatos
            // 
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatos.Location = new System.Drawing.Point(3, 16);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(757, 131);
            this.pnlDatos.TabIndex = 0;
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // FrmFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 342);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.pnlFormulario);
            this.Controls.Add(this.tsmMenu);
            this.Name = "FrmFormulario";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.FrmFormulario_Load);
            this.tsmMenu.ResumeLayout(false);
            this.tsmMenu.PerformLayout();
            this.grbDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStripButton tsbtnNuevo;
        public System.Windows.Forms.ToolStripButton tsbtnGuardar;
        public System.Windows.Forms.ToolStripButton tsbtnModificar;
        public System.Windows.Forms.ToolStripButton tsbtnEliminar;
        public System.Windows.Forms.ToolStripButton tsbtnCancelar;
        public System.Windows.Forms.ToolStripTextBox tstxtBuscar;
        public System.Windows.Forms.ToolStripComboBox tscmbBuscar;
        public System.Windows.Forms.ToolStripButton tstxbLimpiarBusqueda;
        protected System.Windows.Forms.Panel pnlFormulario;
        protected System.Windows.Forms.GroupBox grbDatos;
        protected System.Windows.Forms.Panel pnlDatos;
        protected System.Windows.Forms.ToolStrip tsmMenu;
        protected System.Windows.Forms.ErrorProvider errProvider;
    }
}