using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Activador.Utilidades
{
    public partial class FrmFormulario : Form
    {
        protected ToolStripControlHost tsControlFecha1;
        protected ToolStripControlHost tsControlFecha2;
        protected DateTimePicker dtpFecha1 = new DateTimePicker();
        protected DateTimePicker dtpFecha2 = new DateTimePicker();
        protected ToolStripButton tsbtnBuscar = new ToolStripButton();

        protected const int BLOQUEADO = 0, NUEVO = 1, MODIFICAR = 2, BUSCAR = 3, ELIMINAR = 4;
        protected int estadoFormulario = 0;
        protected bool estadoSeleccion = false;
        
        public FrmFormulario()
        {
            InitializeComponent();
            dtpFecha1.Name = "dtpFecha1";
            dtpFecha1.Size = new System.Drawing.Size(100, 25);
            dtpFecha1.Format = DateTimePickerFormat.Short;
            dtpFecha1.Visible = false;
            dtpFecha2.Name = "dtpFecha2";
            dtpFecha2.Size = new System.Drawing.Size(100, 25);
            dtpFecha2.Format = DateTimePickerFormat.Short;
            dtpFecha2.Visible = false;
            tsbtnBuscar.Name = "tsbtnBuscar";
            tsbtnBuscar.Size = new System.Drawing.Size(75, 25);
            tsbtnBuscar.Text = "Buscar";
            tsbtnBuscar.Visible = false;
            tsControlFecha1 = new ToolStripControlHost(dtpFecha1);
            tsControlFecha1.Visible = false;
            tsControlFecha2 = new ToolStripControlHost(dtpFecha2);
            tsControlFecha2.Visible = false;
            tsmMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsControlFecha1, tsControlFecha2, tsbtnBuscar });
        }

        /// <summary>
        /// metodo que administra el estado del formulario
        /// </summary>
        /// <param name="nuevoEstado"></param>
        protected void SetEstadoForm(int nuevoEstado)
        {
            estadoFormulario = nuevoEstado;
            switch (nuevoEstado)
            {
                case BLOQUEADO:
                    OperacionesFormulario.Limpiar(pnlFormulario);
                    tsbtnCancelar.Visible = false;
                    tsbtnNuevo.Visible = true;
                    tsbtnGuardar.Visible = false;
                    tsbtnModificar.Visible = false;
                    tsbtnEliminar.Visible = false;
                    pnlFormulario.Enabled = false;
                    break;
                case NUEVO:
                    OperacionesFormulario.Limpiar(pnlFormulario);                    
                    tsbtnCancelar.Visible = true;
                    tsbtnNuevo.Visible = false;
                    tsbtnGuardar.Visible = true;
                    tsbtnModificar.Visible = false;
                    tsbtnEliminar.Visible = false;
                    pnlFormulario.Enabled = true;
                    break;
                case MODIFICAR:
                    pnlFormulario.Enabled = true;
                    tsbtnCancelar.Visible = true;
                    tsbtnNuevo.Visible = true;
                    tsbtnGuardar.Visible = true;
                    tsbtnModificar.Visible = false;
                    tsbtnEliminar.Visible = true;
                    break;
                case BUSCAR:
                    OperacionesFormulario.Limpiar(pnlFormulario);
                    tsbtnCancelar.Visible = false;
                    tsbtnNuevo.Visible = true;
                    tsbtnGuardar.Visible = false;
                    tsbtnModificar.Visible = false;
                    tsbtnEliminar.Visible = true;
                    pnlFormulario.Enabled = false;
                    break;
            }
        }

        /// <summary>
        /// 23/10/2012
        /// Jorge Ibarra
        /// Valida que los campos suministrados se encuentren vacíos.
        /// </summary>
        /// <param name="atxt"></param>
        /// <returns></returns>
        protected bool ValidarVacio(params TextBox[] atxt)
        {
            bool bValido = true;
            foreach (TextBox txt in atxt)
            {
                if (txt.Text.Length == 0)
                {
                    errProvider.SetError(txt, "Debe de llenar este campo");
                    bValido = false;
                }
                else errProvider.SetError(txt, "");
            }
            return bValido;
        }

        protected void tsbtnNuevo_Click(object sender, EventArgs e)
        {
            SetEstadoForm(NUEVO);            
        }

        protected void tsbtnModificar_Click(object sender, EventArgs e)
        {
            SetEstadoForm(MODIFICAR);
        }

        protected void FrmFormulario_Load(object sender, EventArgs e)
        {
            SetEstadoForm(BLOQUEADO);
        }

        protected void tsbtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está usted seguro de cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                OperacionesFormulario.Limpiar(pnlFormulario);
                SetEstadoForm(BLOQUEADO);
            }
        }

        protected void tsbtnGuardar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void tsbtnEliminar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }        
    }
}
