using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activador.Utilidades;

namespace Activador.mClientes
{
    public partial class FrmClientes : FrmFormulario
    {
        #region Atributos
        ClsLocalidad oclsLocalidad;
        ClsClientes oclsClientes;
        #endregion

        #region Constructor
        public FrmClientes()
        {
            InitializeComponent();
            oclsClientes = new ClsClientes();
            oclsLocalidad = new ClsLocalidad();
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

            cmbEstado.DataSource = oclsLocalidad.Search();

            tsControlFecha1.Visible = false;
            tsControlFecha2.Visible = false;
            tsbtnBuscar.Visible = false;

            tscmbBuscar.ComboBox.Items.Add("Nombre Cliente");
            tscmbBuscar.ComboBox.Items.Add("Apellido Cliente");            
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
                oclsClientes.oCliente = new Cliente();
                oclsClientes.oCliente.idEstado = 1;
                oclsClientes.oCliente.Domicilio = new Domicilio();
            }
            else if (estadoFormulario == MODIFICAR)
            { 
                
            }

            oclsClientes.oCliente.NombreCliente = txtNombre.Text;
            oclsClientes.oCliente.ApellidoCliente = txtApellido.Text;
            oclsClientes.oCliente.Telefono = txtTelefono.Text;
            oclsClientes.oCliente.Celular = txtCelular.Text;
            oclsClientes.oCliente.Email = txtEmail.Text;

            oclsClientes.oCliente.Domicilio.Calle = txtCalle.Text;
            oclsClientes.oCliente.Domicilio.Colonia = txtColonia.Text;
            oclsClientes.oCliente.Domicilio.NoExterior = txtExterior.Text;
            oclsClientes.oCliente.Domicilio.NoInterior = txtInterior.Text;
            oclsClientes.oCliente.Domicilio.CodigoPostal = txtCP.Text;
            oclsClientes.oCliente.Domicilio.Referencia = txtReferencia.Text;
            oclsClientes.oCliente.Domicilio.Localidad = txtLocalidad.Text;
            oclsClientes.oCliente.Domicilio.Pais = txtPais.Text;
            oclsClientes.oCliente.Domicilio.idEstado = Convert.ToInt32(cmbEstado.SelectedValue);
            oclsClientes.oCliente.Domicilio.idMunicipio = Convert.ToInt32(cmbMunicipio.SelectedValue);
        }

        /// <summary>
        /// 23/10/2012
        /// Jorge Ibarra
        /// Llena el formulario con los datos del objeto que se maneja en el módulo
        /// </summary>
        private void LlenarFormulario()
        {
            SuspendLayout();
            txtNombre.Text = oclsClientes.oCliente.NombreCliente;
            txtApellido.Text = oclsClientes.oCliente.ApellidoCliente;
            txtTelefono.Text = oclsClientes.oCliente.Telefono;
            txtCelular.Text = oclsClientes.oCliente.Celular;
            txtEmail.Text = oclsClientes.oCliente.Email;

            txtCalle.Text = oclsClientes.oCliente.Domicilio.Calle;
            txtColonia.Text = oclsClientes.oCliente.Domicilio.Colonia;
            txtExterior.Text = oclsClientes.oCliente.Domicilio.NoExterior;
            txtInterior.Text = oclsClientes.oCliente.Domicilio.NoInterior;
            txtCP.Text = oclsClientes.oCliente.Domicilio.CodigoPostal;
            txtReferencia.Text = oclsClientes.oCliente.Domicilio.Referencia;
            txtLocalidad.Text = oclsClientes.oCliente.Domicilio.Localidad;
            txtPais.Text = oclsClientes.oCliente.Domicilio.Pais;
            cmbEstado.SelectedValue = oclsClientes.oCliente.Domicilio.idEstado;
            cmbMunicipio.SelectedValue = oclsClientes.oCliente.Domicilio.idMunicipio;
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
            bool bValido = ValidarVacio(txtNombre, txtTelefono, txtEmail, txtCalle, txtExterior, txtCP);
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
                if (!oclsClientes.Add(oclsClientes.oCliente))
                {
                    MessageBox.Show(oclsClientes.GetError());
                }
                else
                {
                    Utilidades.OperacionesFormulario.Limpiar(tbcCliente);
                    SetEstadoForm(BLOQUEADO);
                    MessageBox.Show("Registro agregado con éxito");
                }
            }
            else if (estadoFormulario == MODIFICAR || estadoFormulario == ELIMINAR)
            {
                if (!oclsClientes.Edit())
                {
                    MessageBox.Show(oclsClientes.GetError());
                }
                else
                {
                    Utilidades.OperacionesFormulario.Limpiar(tbcCliente);
                    if (estadoFormulario == MODIFICAR) MessageBox.Show("Registro modificado");
                    else MessageBox.Show("Registro eliminado");
                    SetEstadoForm(BLOQUEADO);                    
                }
            }            
        }
        #endregion

        #region Eventos
        private void FrmClientes_Load(object sender, EventArgs e)
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
            txtPais.Text = "México";            
            dgvDatos.ClearSelection();            
        }

        private new void tsbtnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Guardar();
                oclsClientes.Search(dgvDatos, tscmbBuscar.SelectedIndex, tstxtBuscar.Text);
            }
        }

        private void tstxtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                estadoSeleccion = false;
                oclsClientes.Search(dgvDatos, tscmbBuscar.SelectedIndex, tstxtBuscar.Text);
            }
        }

        private new void tsbtnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta usted seguro de eliminar", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                estadoFormulario = ELIMINAR;
                oclsClientes.oCliente.idEstado = 4;
                Guardar();
            }
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMunicipio.DataSource = oclsLocalidad.Search((dEstado)cmbEstado.SelectedItem);
        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDatos.Rows.Count > 0 && dgvDatos.SelectedRows.Count > 0)
            {
                if (estadoSeleccion)
                {
                    oclsClientes.oCliente = (Cliente)dgvDatos.SelectedRows[0].DataBoundItem;
                    SetEstadoForm(MODIFICAR);
                    LlenarFormulario();
                }
                else estadoSeleccion = true;
            }
        }
        #endregion

        
    }
}
