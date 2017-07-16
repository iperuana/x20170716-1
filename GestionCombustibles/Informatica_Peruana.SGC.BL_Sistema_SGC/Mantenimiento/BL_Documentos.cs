using Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento;
using Informatica_Peruana.SGC.DA_Sistema_SGC.Mantenimiento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Threading.Tasks;

namespace Informatica_Peruana.SGC.BL_Sistema_SGC.Mantenimiento
{
    public class BL_Documentos
    {
        #region "Listados"
        public static List<BE_Documentos> Listar_Documentos(BE_Documentos pBE_Documentos)
        {
            try
            {
                return DA_Documentos.Listar_Documentos(pBE_Documentos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public static List<BE_Documentos> Listar_Documentos_x_ID(BE_Documentos pBE_Documentos)
        {
            try
            {
                return DA_Documentos.Listar_Documentos_x_ID(pBE_Documentos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
        public static int Registrar_Documentos(BE_Documentos pBE_Documentos)
        {
            int intValor = 0;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {

                    intValor = DA_Documentos.Registrar_Documentos(pBE_Documentos);

                    ts.Complete();
                }
                intValor = Convert.ToInt32(pBE_Documentos.ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intValor;
        }

        public static int Actualizar_Documentos(BE_Documentos pBE_Documentos)
        {
            int intValor = 0;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {

                    intValor = DA_Documentos.Actualizar_Documentos(pBE_Documentos);

                    ts.Complete();
                }
                intValor = Convert.ToInt32(pBE_Documentos.ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intValor;
        }
        public static int ActualizarEstadoDocumento(BE_Documentos pBE_Documentos)
        {
            int intValor = 0;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    if (pBE_Documentos.ID != 0)
                    {
                        intValor = DA_Documentos.ActualizarEstadoDocumento(pBE_Documentos);
                    }
                    ts.Complete();
                }
                intValor = Convert.ToInt32(pBE_Documentos.ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intValor;
        }
    }
}
