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
   public partial class BL_Operador_Usuario
    {
        #region"Listado"
        public static List<BE_Operador_Usuario> Listar_Operador_Usuario(BE_Operador_Usuario pBE_Operador_Usuario)
        {
            try
            {
                return DA_Operador_Usuario.Listar_Operador_Usuario(pBE_Operador_Usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<BE_Operador_Usuario> Listar_Operador_Usuario_x_ID(BE_Operador_Usuario pBE_Operador_Usuario)
        {
            try
            {
                return DA_Operador_Usuario.Listar_Operador_Usuario_x_ID(pBE_Operador_Usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region"Mantenimiento"
        public static int Registrar_Operador_Usuario(BE_Operador_Usuario pBE_Operador_Usuario)
        {
            int intValor = 0;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {

                    intValor = DA_Operador_Usuario.Registrar_Operador_Usuario(pBE_Operador_Usuario);

                    ts.Complete();
                }
                intValor = Convert.ToInt32(pBE_Operador_Usuario.ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intValor;
        }
        public static int Actualizar_Operador_Usuario(BE_Operador_Usuario pBE_Operador_Usuario)
        {
            int intValor = 0;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {

                    intValor = DA_Operador_Usuario.Actualizar_Operador_Usuario(pBE_Operador_Usuario);

                    ts.Complete();
                }
                intValor = Convert.ToInt32(pBE_Operador_Usuario.ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intValor;
        }
        public static int ActualizarEstadoOperador_Usuario(BE_Operador_Usuario pBE_Operador_Usuario)
        {
            int intValor = 0;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    if (pBE_Operador_Usuario.ID != 0)
                    {
                        intValor = DA_Operador_Usuario.ActualizarEstadoOperador_Usuario(pBE_Operador_Usuario);
                    }
                    ts.Complete();
                }
                intValor = Convert.ToInt32(pBE_Operador_Usuario.ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intValor;
        }
        #endregion
    }
}
