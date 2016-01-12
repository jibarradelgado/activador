namespace Activador
{
    partial class FrmPrincipal
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSistemas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVerificador = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmClientes,
            this.tsmSistemas,
            this.tsmVerificador});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(824, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // tsmClientes
            // 
            this.tsmClientes.Name = "tsmClientes";
            this.tsmClientes.Size = new System.Drawing.Size(61, 20);
            this.tsmClientes.Text = "&Clientes";
            this.tsmClientes.Click += new System.EventHandler(this.tsmClientes_Click);
            // 
            // tsmSistemas
            // 
            this.tsmSistemas.Name = "tsmSistemas";
            this.tsmSistemas.Size = new System.Drawing.Size(65, 20);
            this.tsmSistemas.Text = "&Sistemas";
            this.tsmSistemas.Click += new System.EventHandler(this.tsmSistemas_Click);
            // 
            // tsmVerificador
            // 
            this.tsmVerificador.Name = "tsmVerificador";
            this.tsmVerificador.Size = new System.Drawing.Size(76, 20);
            this.tsmVerificador.Text = "&Verificador";
            this.tsmVerificador.Click += new System.EventHandler(this.tsmVerificador_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 458);
            this.Controls.Add(this.menuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FrmPrincipal";
            this.Text = "Verificador de seriales";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmClientes;
        private System.Windows.Forms.ToolStripMenuItem tsmSistemas;
        private System.Windows.Forms.ToolStripMenuItem tsmVerificador;
    }
}

