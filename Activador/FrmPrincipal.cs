using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Activador
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private bool ValidarAbierto(string nombreForm)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.ToUpper() == nombreForm.ToUpper())
                {
                    f.Activate();
                    return true;
                }
            }
            return false;
        }

        private void tsmClientes_Click(object sender, EventArgs e)
        {
            if (ValidarAbierto("FrmClientes")) return;
            mClientes.FrmClientes frmCliente = new mClientes.FrmClientes();
            frmCliente.MdiParent = this;
            frmCliente.Show();
        }

        private void tsmSistemas_Click(object sender, EventArgs e)
        {
            if (ValidarAbierto("FrmSistemas")) return;
            mSistemas.FrmSistemas frmSistema = new mSistemas.FrmSistemas();
            frmSistema.MdiParent = this;
            frmSistema.Show();
        }

        private void tsmVerificador_Click(object sender, EventArgs e)
        {
            if (ValidarAbierto("FrmActivadorSeriales")) return;
            mActivadorSeriales.FrmActivadorSeriales frmActivadorSeriales = new mActivadorSeriales.FrmActivadorSeriales();
            frmActivadorSeriales.MdiParent = this;
            frmActivadorSeriales.Show();
        }


    }
}
