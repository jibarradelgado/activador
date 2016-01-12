using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Activador.mSistemas
{
    public partial class FrmSistemas : Activador.Utilidades.FrmFormulario
    {
        #region Atributos
        ClsSistemas oclsSistemas;
        #endregion

        #region Constructor
        public FrmSistemas()
        {
            InitializeComponent();
            oclsSistemas = new ClsSistemas();
        }
        #endregion

        #region MetodosFormulario
        /// <summary>
        /// Jorge Ibarra
        /// 19/10/2012
        /// Realiza los ajustes de diseño de este formulario
        /// </summary>
        private void DisenoVentana()
        {
            SuspendLayout();

            tsControlFecha1.Visible = false;
            tsControlFecha2.Visible = false;
            tsbtnBuscar.Visible = false;

            tscmbBuscar.ComboBox.Items.Add("Nombre Sistema");            
            tscmbBuscar.ComboBox.SelectedIndex = 0;
            ResumeLayout();
        }

        /// <summary>
        /// 23/10/2012
        /// Jorge Ibarra
        /// Coloca los atributos al objeto que se maneja en el módulo
        /// </summary>
        private void SetPrincipalObject()
        {
            if (estadoFormulario == NUEVO)
            {
                oclsSistemas.oSistema = new Sistema();
                oclsSistemas.oSistema.idEstado = 1;                
            }
            else if (estadoFormulario == MODIFICAR)
            {

            }

            oclsSistemas.oSistema.Nombre = txtNombre.Text;
            oclsSistemas.oSistema.Version = txtVersion.Text;            
        }

        /// <summary>
        /// 23/10/2012
        /// Jorge Ibarra
        /// Llena el formulario con los datos del objeto que se maneja en el módulo
        /// </summary>
        private void LlenarFormulario()
        {
            SuspendLayout();
            txtNombre.Text = oclsSistemas.oSistema.Nombre;
            txtVersion.Text = oclsSistemas.oSistema.Version;
            
            ResumeLayout();
        }

        /// <summary>
        /// 23/10/2012
        /// Jorge Ibarra
        /// Valida el formulario
        /// </summary>
        /// <returns>true si es valido, false si no</returns>
        private bool Validar()
        {
            SuspendLayout();
            bool bValido = ValidarVacio(txtNombre, txtVersion);
            ResumeLayout();
            return bValido;
        }

        /// <summary>
        /// 23/10/2012
        /// Jorge Ibarra
        /// Guarda cambios realizados en el módulo
        /// </summary>
        private void Guardar()
        {
            SetPrincipalObject();

            if (estadoFormulario == NUEVO)
            {
                if (!oclsSistemas.Add())
                {
                    MessageBox.Show(oclsSistemas.GetError());
                }
                else
                {
                    Utilidades.OperacionesFormulario.Limpiar(pnlFormulario);
                    SetEstadoForm(BLOQUEADO);
                    MessageBox.Show("Registro agregado con éxito");
                }
            }
            else if (estadoFormulario == MODIFICAR || estadoFormulario == ELIMINAR)
            {
                if (!oclsSistemas.Edit())
                {
                    MessageBox.Show(oclsSistemas.GetError());
                }
                else
                {
                    Utilidades.OperacionesFormulario.Limpiar(pnlFormulario);
                    if (estadoFormulario == MODIFICAR) MessageBox.Show("Registro modificado");
                    else MessageBox.Show("Registro eliminado");
                    SetEstadoForm(BLOQUEADO);                    
                }
            }
        }
        #endregion

        #region Eventos
        private void FrmSistemas_Load(object sender, EventArgs e)
        {
            DisenoVentana();

            tsbtnNuevo.Click += new EventHandler(tsbtnNuevoCliente_Click);
            tsbtnGuardar.Click -= new EventHandler(base.tsbtnGuardar_Click);
            tsbtnGuardar.Click += new EventHandler(tsbtnGuardar_Click);
            tstxtBuscar.KeyDown += new KeyEventHandler(tstxtBuscar_KeyDown);
            tsbtnEliminar.Click -= new EventHandler(base.tsbtnEliminar_Click);
            tsbtnEliminar.Click += new EventHandler(tsbtnEliminar_Click);
        }

        private void tsbtnNuevoCliente_Click(object sender, EventArgs e)
        {            
            dgvDatos.ClearSelection();
        }

        private new void tsbtnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Guardar();
                oclsSistemas.Search(dgvDatos, tscmbBuscar.SelectedIndex, tstxtBuscar.Text);
            }
        }

        private void tstxtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                estadoSeleccion = false;
                oclsSistemas.Search(dgvDatos, tscmbBuscar.SelectedIndex, tstxtBuscar.Text);
            }
        }

        private new void tsbtnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta usted seguro de eliminar", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                estadoFormulario = ELIMINAR;
                oclsSistemas.oSistema.idEstado = 4;
                Guardar();
            }
        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDatos.Rows.Count > 0 && dgvDatos.SelectedRows.Count > 0)
            {
                if (estadoSeleccion)
                {
                    oclsSistemas.oSistema = (Sistema)dgvDatos.SelectedRows[0].DataBoundItem;
                    SetEstadoForm(MODIFICAR);
                    LlenarFormulario();
                }
                else estadoSeleccion = true;
            }
        }
        #endregion
    }
}
