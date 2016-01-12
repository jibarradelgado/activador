using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data;
using System.Windows.Forms;

namespace Activador.mClientes
{
    class ClsClientes : Utilidades.ClsModulo
    {
        public Cliente oCliente;

        /// <summary>
        /// 23/10/2012
        /// Jorge Ibarra
        /// Agrega un Objeto al contexto de datos y a la base de datos
        /// </summary>
        /// <returns></returns>
        public override bool Add()
        {
            Clear();
            using(Entities oEntities1 = new Entities())
            {
                oEntities1.Cliente.AddObject(oCliente);

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

        public bool Add<T>(T objeto) where T : class
        {
            using (Entities oEntities1 = new Entities())
            {
                try
                {
                    var os = oEntities1.CreateObjectSet<T>();
                    os.AddObject(objeto);
                    oEntities1.SaveChanges();
                    return true;
                }
                catch
                {
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

        public override bool Search(Control oControl, int iValor, string sValor)
        {
            Clear(); 
            oEntities = new Entities();

            try
            {
                if (sValor.Length == 0)
                {
                    var query = from p in oEntities.Cliente
                                where p.idEstado == 1 || p.idEstado == 2
                                select p;

                    CargarControl(oControl, query);
                    return true;
                }

                switch (iValor)
                {
                    default:
                    case 0:
                        var query = from q in oEntities.Cliente
                                    where q.NombreCliente.ToUpper().Contains(sValor) && (q.idEstado == 1 || q.idEstado == 2)
                                    select q;

                        CargarControl(oControl, query);
                        return true;
                    case 1:
                        query = from q in oEntities.Cliente
                                    where q.ApellidoCliente.ToUpper().Contains(sValor) && (q.idEstado == 1 || q.idEstado == 2)
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
