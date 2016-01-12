namespace Activador.mSistemas
{
    partial class FrmSistemas
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
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.idSistemaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEstadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteSistemaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEstadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sistemaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grbFormulario = new System.Windows.Forms.GroupBox();
            this.pnlSistema = new System.Windows.Forms.Panel();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlFormulario.SuspendLayout();
            this.grbDatos.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBindingSource)).BeginInit();
            this.grbFormulario.SuspendLayout();
            this.pnlSistema.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.Controls.Add(this.grbFormulario);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.dgvDatos);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AutoGenerateColumns = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSistemaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.versionDataGridViewTextBoxColumn,
            this.idEstadoDataGridViewTextBoxColumn,
            this.clienteSistemaDataGridViewTextBoxColumn,
            this.cEstadoDataGridViewTextBoxColumn});
            this.dgvDatos.DataSource = this.sistemaBindingSource;
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(0, 0);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(757, 131);
            this.dgvDatos.TabIndex = 2;
            this.dgvDatos.SelectionChanged += new System.EventHandler(this.dgvDatos_SelectionChanged);
            // 
            // idSistemaDataGridViewTextBoxColumn
            // 
            this.idSistemaDataGridViewTextBoxColumn.DataPropertyName = "idSistema";
            this.idSistemaDataGridViewTextBoxColumn.HeaderText = "idSistema";
            this.idSistemaDataGridViewTextBoxColumn.Name = "idSistemaDataGridViewTextBoxColumn";
            this.idSistemaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSistemaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // versionDataGridViewTextBoxColumn
            // 
            this.versionDataGridViewTextBoxColumn.DataPropertyName = "Version";
            this.versionDataGridViewTextBoxColumn.HeaderText = "Versión";
            this.versionDataGridViewTextBoxColumn.Name = "versionDataGridViewTextBoxColumn";
            this.versionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idEstadoDataGridViewTextBoxColumn
            // 
            this.idEstadoDataGridViewTextBoxColumn.DataPropertyName = "idEstado";
            this.idEstadoDataGridViewTextBoxColumn.HeaderText = "idEstado";
            this.idEstadoDataGridViewTextBoxColumn.Name = "idEstadoDataGridViewTextBoxColumn";
            this.idEstadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idEstadoDataGridViewTextBoxColumn.Visible = false;
            // 
            // clienteSistemaDataGridViewTextBoxColumn
            // 
            this.clienteSistemaDataGridViewTextBoxColumn.DataPropertyName = "ClienteSistema";
            this.clienteSistemaDataGridViewTextBoxColumn.HeaderText = "ClienteSistema";
            this.clienteSistemaDataGridViewTextBoxColumn.Name = "clienteSistemaDataGridViewTextBoxColumn";
            this.clienteSistemaDataGridViewTextBoxColumn.ReadOnly = true;
            this.clienteSistemaDataGridViewTextBoxColumn.Visible = false;
            // 
            // cEstadoDataGridViewTextBoxColumn
            // 
            this.cEstadoDataGridViewTextBoxColumn.DataPropertyName = "cEstado";
            this.cEstadoDataGridViewTextBoxColumn.HeaderText = "cEstado";
            this.cEstadoDataGridViewTextBoxColumn.Name = "cEstadoDataGridViewTextBoxColumn";
            this.cEstadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.cEstadoDataGridViewTextBoxColumn.Visible = false;
            // 
            // sistemaBindingSource
            // 
            this.sistemaBindingSource.DataSource = typeof(Activador.Sistema);
            // 
            // grbFormulario
            // 
            this.grbFormulario.Controls.Add(this.pnlSistema);
            this.grbFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbFormulario.Location = new System.Drawing.Point(0, 0);
            this.grbFormulario.Name = "grbFormulario";
            this.grbFormulario.Size = new System.Drawing.Size(763, 159);
            this.grbFormulario.TabIndex = 0;
            this.grbFormulario.TabStop = false;
            this.grbFormulario.Text = "Datos del sistema";
            // 
            // pnlSistema
            // 
            this.pnlSistema.AutoScroll = true;
            this.pnlSistema.Controls.Add(this.txtVersion);
            this.pnlSistema.Controls.Add(this.lblVersion);
            this.pnlSistema.Controls.Add(this.txtNombre);
            this.pnlSistema.Controls.Add(this.lblNombre);
            this.pnlSistema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSistema.Location = new System.Drawing.Point(3, 16);
            this.pnlSistema.Name = "pnlSistema";
            this.pnlSistema.Size = new System.Drawing.Size(757, 140);
            this.pnlSistema.TabIndex = 0;
            // 
            // txtVersion
            // 
            this.txtVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVersion.Location = new System.Drawing.Point(97, 35);
            this.txtVersion.MaxLength = 50;
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(134, 21);
            this.txtVersion.TabIndex = 3;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(10, 38);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(48, 15);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Versión";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(97, 8);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(134, 21);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(9, 11);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(52, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // FrmSistemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(763, 342);
            this.Name = "FrmSistemas";
            this.Text = "Sistemas";
            this.Load += new System.EventHandler(this.FrmSistemas_Load);
            this.pnlFormulario.ResumeLayout(false);
            this.grbDatos.ResumeLayout(false);
            this.pnlDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBindingSource)).EndInit();
            this.grbFormulario.ResumeLayout(false);
            this.pnlSistema.ResumeLayout(false);
            this.pnlSistema.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.BindingSource sistemaBindingSource;
        private System.Windows.Forms.GroupBox grbFormulario;
        private System.Windows.Forms.Panel pnlSistema;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSistemaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteSistemaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEstadoDataGridViewTextBoxColumn;
    }
}
