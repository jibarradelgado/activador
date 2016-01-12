using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Activador.Utilidades
{
    abstract class ClsModulo
    {
        protected List<string> lstErrores = new List<string>();
        protected Entities oEntities;

        public abstract bool Add();

        public abstract bool Edit();

        public abstract bool ChangeState(int iNewState);

        public abstract bool Search(Control oControl, int iValor, string sValor);

        /// <summary>
        /// 23/10/2012
        /// Jorge Ibarra
        /// Carga los datos obtenidos de un query en el control 
        /// </summary>
        /// <param name="oControl"></param>
        /// <param name="oValor"></param>
        protected void CargarControl(Control oControl, IQueryable oValor)
        {
            if (oControl is DataGridView)
            {
                ((DataGridView)oControl).DataSource = oValor;
                ((DataGridView)oControl).ClearSelection();
            }
            else if (oControl is ComboBox)
            {
                ((ComboBox)oControl).DataSource = oValor;
                if (((ComboBox)oControl).Items.Count > 0)
                {
                    ((ComboBox)oControl).SelectedIndex = 0;
                }
            }
        }

        /// <summary>
        /// metodo que limpia atributos que deben limpiarse
        /// </summary>
        protected void Clear()
        {
            lstErrores = new List<string>();
        }

        /// <summary>
        /// Obtiene listado de errores
        /// </summary>
        /// <returns>regresa la lista de errores</returns>
        public string GetError()
        {
            string err = "";
            foreach (string e in lstErrores)
            {
                err += e + ",";
            }
            err = err.Substring(0, err.Length - 1);
            return err;
        }
    }
}
