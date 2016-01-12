using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Activador.Utilidades
{
    public class ClsLocalidad
    {
        Entities oEntities; 
        
        public IQueryable Search()
        {
            oEntities = new Entities();

            try
            {                
                var query = from q in oEntities.dEstado
                            select q;

                return query;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema al obtener el registro de estados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public IQueryable Search(dEstado oEstado)
        {
            oEntities = new Entities();

            try
            {
                var query = from q in oEntities.cMunicipio
                            where q.iddEstado == oEstado.iddEstado
                            select q;

                return query;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema al obtener el registro de municipios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
