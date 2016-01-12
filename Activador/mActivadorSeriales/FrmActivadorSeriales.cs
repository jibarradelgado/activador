using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Activador.Utilidades;

namespace Activador.mActivadorSeriales
{
    public partial class FrmActivadorSeriales : Form
    {
        mClientes.ClsClientes oclsClientes;
        mSistemas.ClsSistemas oclsSistemas;
        ClsActivadorSeriales oclsActivadorSeriales;
        string nombreSistema;
        string version;
        string macAddress;
        string fechapeticion;

        protected const int BLOQUEADO = 0, NUEVO = 1, MODIFICAR = 2, BUSCAR = 3, ELIMINAR = 4;
        protected int estadoFormulario = 0;
        protected bool estadoSeleccion = false;
        
        public FrmActivadorSeriales()
        {
            InitializeComponent();
            oclsClientes = new mClientes.ClsClientes();
            oclsSistemas = new mSistemas.ClsSistemas();
            oclsActivadorSeriales = new ClsActivadorSeriales();   
        }

        #region MetodosFormularioBasicos
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
                    OperacionesFormulario.Limpiar(pnlActivador);
                    OperacionesFormulario.Limpiar(pnlClientes);
                    tsbtnCancelar.Visible = false;
                    tsbtnNuevo.Visible = true;
                    tsbtnGuardar.Visible = false;
                    tsbtnActivar.Visible = false;
                    tsbtnDesactivar.Visible = false;
                    tsbtnEliminar.Visible = false;
                    pnlActivador.Enabled = false;
                    pnlClientes.Enabled = false;
                    break;
                case NUEVO:
                    OperacionesFormulario.Limpiar(pnlActivador);
                    OperacionesFormulario.Limpiar(pnlClientes);
                    tsbtnCancelar.Visible = true;
                    tsbtnNuevo.Visible = false;
                    tsbtnGuardar.Visible = true;
                    tsbtnActivar.Visible = false;
                    tsbtnDesactivar.Visible = false;
                    tsbtnEliminar.Visible = false;
                    pnlActivador.Enabled = true;
                    pnlClientes.Enabled = true;
                    break;
                case MODIFICAR:
                    pnlActivador.Enabled = true;
                    pnlClientes.Enabled = true;
                    tsbtnCancelar.Visible = true;
                    tsbtnNuevo.Visible = true;
                    tsbtnGuardar.Visible = true;
                    tsbtnActivar.Visible = true;
                    tsbtnDesactivar.Visible = true;
                    tsbtnEliminar.Visible = true;
                    break;
                case BUSCAR:
                    OperacionesFormulario.Limpiar(pnlActivador);
                    OperacionesFormulario.Limpiar(pnlClientes);
                    tsbtnCancelar.Visible = false;
                    tsbtnNuevo.Visible = true;
                    tsbtnGuardar.Visible = false;
                    tsbtnActivar.Visible = true;
                    tsbtnDesactivar.Visible = true;
                    tsbtnEliminar.Visible = true;
                    pnlActivador.Enabled = false;
                    pnlClientes.Enabled = false;
                    break;
            }
        }

        /// <summary>
        /// Jorge Ibarra
        /// 19/10/2012
        /// Realiza los ajustes de diseño de este formulario
        /// </summary>
        private void DisenoVentana()
        {
            SuspendLayout();

            cmbBuscarCliente.SelectedIndex = 0;
            tscmbBuscar.ComboBox.SelectedIndex = 0;

            //tsControlFecha1.Visible = false;
            //tsControlFecha2.Visible = false;
            //tsbtnBuscar.Visible = false;
            ResumeLayout();
        }


        #endregion

        #region MetodosFormularioEspecificos
        /// <summary>
        /// 23/10/2012
        /// Jorge Ibarra
        /// Coloca los atributos al objeto que se maneja en el módulo
        /// </summary>
        private void SetPrincipalObject()
        {
            if (estadoFormulario == NUEVO)
            {
                oclsActivadorSeriales.oClienteSistema = new ClienteSistema();
                oclsActivadorSeriales.oClienteSistema.idEstado = 2;
                oclsActivadorSeriales.oClienteSistema.idCliente = ((Cliente)dgvClientes.SelectedRows[0].DataBoundItem).idCliente;
                oclsActivadorSeriales.oClienteSistema.idSistema = oclsSistemas.oSistema.idSistema;

                oclsActivadorSeriales.oClienteSistema.MACAdress = macAddress;
                oclsActivadorSeriales.oClienteSistema.FechaPeticion = Convert.ToDateTime(fechapeticion);
                oclsActivadorSeriales.oClienteSistema.NumeroSerie = ObtenerNumeroSerie();
            }
            else if (estadoFormulario == MODIFICAR)
            {
            
            }
        }

        private string ObtenerNumeroSerie()
        {
            ClienteSistema oClienteSistema = oclsActivadorSeriales.SearchClienteSistemaByIdSistema(oclsSistemas.oSistema.idSistema);
            if (oClienteSistema == null)
            {
                return OperacionesFormulario.LlenaCeros(oclsSistemas.oSistema.idSistema, 4) + OperacionesFormulario.LlenaCeros(1, 12);
            }
            else
            { 
                string sNumeroSerie = oClienteSistema.NumeroSerie.Substring(4);
                int iNumeroSerie = Convert.ToInt32(sNumeroSerie);
                iNumeroSerie++;
                return OperacionesFormulario.LlenaCeros(oclsSistemas.oSistema.idSistema, 4) + OperacionesFormulario.LlenaCeros(iNumeroSerie, 12);
            }
        }

        /// <summary>
        /// 23/10/2012
        /// Jorge Ibarra
        /// Llena el formulario con los datos del objeto que se maneja en el módulo
        /// </summary>
        private void LlenarFormulario()
        {
            SuspendLayout();
            txtClaveDescifrada.Text = "Sistema: " + oclsActivadorSeriales.oClienteSistema.Sistema.Nombre + 
                " Version: " + oclsActivadorSeriales.oClienteSistema.Sistema.Version + "\r\nMAC Adress: " + oclsActivadorSeriales.oClienteSistema.MACAdress
                    + "\r\nFecha de petición: " + oclsActivadorSeriales.oClienteSistema.FechaPeticion;

            nombreSistema = oclsActivadorSeriales.oClienteSistema.Sistema.Nombre;
            version = oclsActivadorSeriales.oClienteSistema.Sistema.Version;
            macAddress = oclsActivadorSeriales.oClienteSistema.MACAdress;
            fechapeticion = oclsActivadorSeriales.oClienteSistema.FechaPeticion.ToString();
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
            bool bValido = true;
            if (dgvClientes.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debe de seleccionar un cliente");
                bValido = false;
            }
            if (oclsSistemas.oSistema == null)
            {
                MessageBox.Show("El sistema que aparece en la clave no existe en el sistema");
                bValido = false;
            }
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
                if (!oclsActivadorSeriales.Add())
                {
                    MessageBox.Show(oclsActivadorSeriales.GetError());
                }
                else
                {
                    Utilidades.OperacionesFormulario.Limpiar(pnlActivador);
                    Utilidades.OperacionesFormulario.Limpiar(pnlClientes);
                    SetEstadoForm(BLOQUEADO);
                    MessageBox.Show("Registro agregado con éxito, recuerde activar posteriormente la licencia");
                }
            }
            else if (estadoFormulario == MODIFICAR || estadoFormulario == ELIMINAR)
            {
                if (!oclsActivadorSeriales.Edit())
                {
                    MessageBox.Show(oclsActivadorSeriales.GetError());
                }
                else
                {
                    Utilidades.OperacionesFormulario.Limpiar(pnlActivador);
                    Utilidades.OperacionesFormulario.Limpiar(pnlClientes);
                    if (estadoFormulario == MODIFICAR) MessageBox.Show("Registro modificado");
                    else MessageBox.Show("Registro eliminado");
                    SetEstadoForm(BLOQUEADO);
                }
            }
        }

        /// <summary>
        /// 25/10/2012
        /// Jorge Ibarra
        /// Descifra la clave enviada por el cliente y la muestra en pantalla
        /// </summary>
        private void DescifrarClaveCliente()
        {
            string sClaveDescifrada = ClsDesencriptador.Decrypt(txtClaveCliente.Text, "Pussyhumeda", "S@1tV4lu3", "SHA1", 2, "@1B2c3D4e5F6g7H8", 256);
            string[] sClaves = sClaveDescifrada.Split('|');
            try
            {
                SuspendLayout();
                txtClaveDescifrada.Text = "Sistema: " + sClaves[0] + " Version: " + sClaves[1] + "\r\nMAC Adress: " + sClaves[2]
                    + "\r\nFecha de petición: " + sClaves[3];

                nombreSistema = sClaves[0];
                version = sClaves[1];
                macAddress = sClaves[2];
                fechapeticion = sClaves[3];

                oclsSistemas.Search(sClaves[0], sClaves[1]);
                ResumeLayout();
            }
            catch (Exception)
            {
                MessageBox.Show("Es posible que la clave entregada no sea legítima");
            }
        }

        private void MostrarClavePrivadaSistema()
        {
            string sClaveEncriptada = "";

            string sCadena = nombreSistema + "|" + version + "|" + macAddress + "|" + fechapeticion + "|" +
                        oclsActivadorSeriales.oClienteSistema.Cliente.NombreCliente + " " + oclsActivadorSeriales.oClienteSistema.Cliente.ApellidoCliente + "|" +
                        oclsActivadorSeriales.oClienteSistema.NumeroSerie;

            switch (nombreSistema)
            { 
                case "VParking" :
                    sClaveEncriptada = ClsEncriptador.Encrypt(sCadena, "m3nudit@s", "s@ltv4lue", "SHA1", 2, "@1B2c3D4e5F6g7H8", 256);
                    txtClaveActivacion.Text = sClaveEncriptada;
                    break;
            }
        }
        #endregion

        #region Eventos

        private void FrmActivadorSeriales_Load(object sender, EventArgs e)
        {
            DisenoVentana();
            SetEstadoForm(BLOQUEADO);
        }

        private void txtBuscarCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {                
                oclsClientes.Search(dgvClientes, cmbBuscarCliente.SelectedIndex, txtBuscarCliente.Text);
            }
        }

        private void tstxtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                estadoSeleccion = false;
                oclsActivadorSeriales.Search(dgvDatos, tscmbBuscar.SelectedIndex, tstxtBuscar.Text);
            }
        }

        private void btnDescifrar_Click(object sender, EventArgs e)
        {
            if (txtClaveCliente.Text.Length > 0)
            {
                DescifrarClaveCliente();
            }
            else
            {
                MessageBox.Show("El campo de texto esta vacío");
            }
        }

        private void tsbtnNuevo_Click(object sender, EventArgs e)
        {
            SetEstadoForm(NUEVO);
            dgvClientes.ClearSelection();
            dgvDatos.ClearSelection(); 
        }

        private void tsbtnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Guardar();
                oclsActivadorSeriales.Search(dgvDatos, tscmbBuscar.SelectedIndex, tstxtBuscar.Text);
            }
        }

        private void tsbtnActivar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta usted seguro de activar la licencia", "Activar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                estadoFormulario = MODIFICAR;
                oclsActivadorSeriales.oClienteSistema.idEstado = 1;                
                Guardar();
                oclsActivadorSeriales.Search(dgvDatos, tscmbBuscar.SelectedIndex, tstxtBuscar.Text);
            }
        }

        private void tsbtnDesactivar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta usted seguro de desactivar la licencia", "Desactivar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                estadoFormulario = MODIFICAR;
                oclsActivadorSeriales.oClienteSistema.idEstado = 2;                
                Guardar();
                oclsActivadorSeriales.Search(dgvDatos, tscmbBuscar.SelectedIndex, tstxtBuscar.Text);
            }
        }

        private void tsbtnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta usted seguro de eliminar", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                estadoFormulario = ELIMINAR;
                oclsActivadorSeriales.oClienteSistema.idEstado = 4;                
                Guardar();
                oclsActivadorSeriales.Search(dgvDatos, tscmbBuscar.SelectedIndex, tstxtBuscar.Text);
            }
        }

        private void tsbtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está usted seguro de cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                OperacionesFormulario.Limpiar(pnlActivador);
                OperacionesFormulario.Limpiar(pnlClientes);
                SetEstadoForm(BLOQUEADO);
            }
        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDatos.Rows.Count > 0 && dgvDatos.SelectedRows.Count > 0)
            {
                if (estadoSeleccion)
                {
                    oclsActivadorSeriales.oClienteSistema = 
                        oclsActivadorSeriales.SearchClienteSistema(((vwClienteSistema)dgvDatos.SelectedRows[0].DataBoundItem).idClienteSistema);                    
                    SetEstadoForm(MODIFICAR);
                    LlenarFormulario();
                }
                else estadoSeleccion = true;
            }
        }

        private void btnMostrarClave_Click(object sender, EventArgs e)
        {
            if (((vwClienteSistema)dgvDatos.SelectedRows[0].DataBoundItem).idEstadoClienteSistema == 1)
            {
                MostrarClavePrivadaSistema();
            }
            else
            {
                MessageBox.Show("La licencia debe de ser activada para proporcionarle su clave");
            }
        }

        #endregion

        

        
    }
}
