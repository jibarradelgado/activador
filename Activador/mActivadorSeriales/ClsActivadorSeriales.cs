using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data;
using System.Windows.Forms;

namespace Activador.mActivadorSeriales
{
    class ClsActivadorSeriales : Utilidades.ClsModulo
    {
        public ClienteSistema oClienteSistema;
        public vwClienteSistema oVistaClienteSistema;

        /// <summary>
        /// 23/10/2012
        /// Jorge Ibarra
        /// Agrega un Objeto al contexto de datos y a la base de datos
        /// </summary>
        /// <returns></returns>
        public override bool Add()
        {
            Clear();
            using (Entities oEntities1 = new Entities())
            {
                oEntities1.ClienteSistema.AddObject(oClienteSistema);

                try
                {
                    oEntities1.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    lstErrores.Add(ex.ToString());
                    return false;
                }
            }
        }

        /// <summary>
        /// 23/10/2012
        /// Jorge Ibarra
        /// Modifica los datos encontrados en el contexto y modifica la base de datos
        /// </summary>
        /// <returns></returns>
        public override bool Edit()
        {
            Clear();
            try
            {
                oEntities.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                lstErrores.Add(ex.ToString());
                return false;
            }
        }

        public override bool ChangeState(int iNewState)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 25/10/2012
        /// Jorge Ibarra
        /// Obtiene el objeto Cliente Sistema mediante el id.
        /// </summary>
        /// <param name="idClienteSistema"></param>
        /// <returns></returns>
        public ClienteSistema SearchClienteSistema(int idClienteSistema)
        {
            Clear();
            oEntities = new Entities();

            try
            {
                oClienteSistema = (from p in oEntities.ClienteSistema
                                   where p.idClienteSistema == idClienteSistema
                                   select p).First();
                return oClienteSistema;
            }
            catch (Exception ex)
            {
                lstErrores.Add(ex.Message);
                return null;
            }
        }

        public ClienteSistema SearchClienteSistemaByIdSistema(int idSistema)
        {
            Clear();
            oEntities = new Entities();

            try
            {
                oClienteSistema = (from q in oEntities.ClienteSistema
                                   where q.idSistema == idSistema
                                   orderby q.idSistema descending
                                   select q).First();
                return oClienteSistema;
            }
            catch (Exception ex)
            {
                lstErrores.Add(ex.Message);
                return null;
            }
        }

        public override bool Search(Control oControl, int iValor, string sValor)
        {
            Clear();
            oEntities = new Entities();

            try
            {
                if (sValor.Length == 0)
                {
                    var query = from p in oEntities.vwClienteSistema
                                where p.idEstadoClienteSistema == 1 || p.idEstadoClienteSistema == 2
                                select p;

                    CargarControl(oControl, query);
                    return true;
                }

                switch (iValor)
                {
                    default:
                    case 0:
                        var query = from q in oEntities.vwClienteSistema
                                    where q.NombreCliente.ToUpper().Contains(sValor) && (q.idEstadoClienteSistema == 1 || q.idEstadoClienteSistema == 2)
                                    select q;

                        CargarControl(oControl, query);
                        return true;
                    case 1:
                        query = from q in oEntities.vwClienteSistema
                                where q.ApellidoCliente.ToUpper().Contains(sValor) && (q.idEstadoClienteSistema == 1 || q.idEstadoClienteSistema == 2)
                                select q;
                        CargarControl(oControl, query);
                        return true;
                    case 2:
                        query = from q in oEntities.vwClienteSistema
                                where q.NombreSistema.ToUpper().Contains(sValor) && (q.idEstadoClienteSistema == 1 || q.idEstadoClienteSistema == 2)
                                select q;
                        CargarControl(oControl, query);
                        return true;
                }
            }
            catch (Exception ex)
            {
                lstErrores.Add(ex.Message);
            }
            return false;
        }
    }
}
