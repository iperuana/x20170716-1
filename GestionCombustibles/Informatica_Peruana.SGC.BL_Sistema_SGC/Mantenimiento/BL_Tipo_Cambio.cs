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
    public class BL_Tipo_Cambio
    {
        #region "Listados"
        public static List<BE_Tipo_Cambio> Listar_TipoCambio(BE_Tipo_Cambio pBE_Tipo_Cambio)
        {
            try
            {
                return DA_Tipo_Cambio.Listar_TipoCambio(pBE_Tipo_Cambio);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<BE_Tipo_Cambio>Listar_Tipo_Cambio_x_fecha(BE_Tipo_Cambio pBE_Tipo_Cambio)
        {
            try
            {
                return DA_Tipo_Cambio.Listar_Tipo_Cambio_x_fecha(pBE_Tipo_Cambio);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
      
        public static int Registrar_Tipo_Cambio(BE_Tipo_Cambio pBE_Tipo_Cambio)
        {
            int intValor = 0;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {

                   intValor = DA_Tipo_Cambio.Registrar_Tipo_Cambio(pBE_Tipo_Cambio);
                   
                    ts.Complete();
                }
                intValor = Convert.ToInt32(pBE_Tipo_Cambio.ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intValor;
        }

        public static int Actualizar_Tipo_Cambio(BE_Tipo_Cambio pBE_Tipo_Cambio)
        {
            int intValor = 0;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {

                    intValor = DA_Tipo_Cambio.Actualizar_Tipo_Cambio(pBE_Tipo_Cambio);

                    ts.Complete();
                }
                intValor = Convert.ToInt32(pBE_Tipo_Cambio.ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intValor;
        }
        
    }
}
