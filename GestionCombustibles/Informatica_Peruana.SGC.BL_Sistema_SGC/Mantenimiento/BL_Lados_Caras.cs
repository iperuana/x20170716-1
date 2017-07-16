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
    public partial class BL_Lados_Caras
    {
        #region"Listado"
        public static List<BE_Lados_Caras> Listar_Lados_Caras(BE_Lados_Caras pBE_Lados_Caras)
        {
            try
            {
                return DA_Lados_Caras.Listar_Lados_Caras(pBE_Lados_Caras);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<BE_Lados_Caras> Listar_Lados_Caras_x_ID(BE_Lados_Caras pBE_Lados_Caras)
        {
            try
            {
                return DA_Lados_Caras.Listar_Lados_Caras_x_ID(pBE_Lados_Caras);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region"Mantenimiento"
        public static int Registrar_Lados_Caras(BE_Lados_Caras pBE_Lados_Caras)
        {
            int intValor = 0;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {

                    intValor = DA_Lados_Caras.Registrar_Lados_Caras(pBE_Lados_Caras);

                    ts.Complete();
                }
                intValor = Convert.ToInt32(pBE_Lados_Caras.ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intValor;
        }
        public static int Actualizar_Lados_Caras(BE_Lados_Caras pBE_Lados_Caras)
        {
            int intValor = 0;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {

                    intValor = DA_Lados_Caras.Actualizar_Lados_Caras(pBE_Lados_Caras);

                    ts.Complete();
                }
                intValor = Convert.ToInt32(pBE_Lados_Caras.ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intValor;
        }
        public static int ActualizarEstadoLadosCaras(BE_Lados_Caras pBE_Lados_Caras)
        {
            int intValor = 0;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    if (pBE_Lados_Caras.ID != 0)
                    {
                        intValor = DA_Lados_Caras.ActualizarEstadoLadosCaras(pBE_Lados_Caras);
                    }
                    ts.Complete();
                }
                intValor = Convert.ToInt32(pBE_Lados_Caras.ID);
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

