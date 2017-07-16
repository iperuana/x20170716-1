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
    public partial class BL_Islas
    {
        public static List<BE_Islas> Listar_Islas(BE_Islas pBE_Islas)
        {
            try
            {
                return DA_Islas.Listar_Islas(pBE_Islas);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<BE_Islas> Listar_Islas_x_ID(BE_Islas pBE_Islas)
        {
            try
            {
                return DA_Islas.Listar_Islas_x_ID(pBE_Islas);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int Registrar_Islas(BE_Islas pBE_Islas)
        {
            int intValor = 0;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {

                    intValor = DA_Islas.Registrar_Islas(pBE_Islas);

                    ts.Complete();
                }
                intValor = Convert.ToInt32(pBE_Islas.ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intValor;
        }
        public static int Actualizar_Islas(BE_Islas pBE_Islas)
        {
            int intValor = 0;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {

                    intValor = DA_Islas.Actualizar_Islas(pBE_Islas);

                    ts.Complete();
                }
                intValor = Convert.ToInt32(pBE_Islas.ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intValor;
        }
        public static int ActualizarEstadoIslas(BE_Islas pBE_Islas)
        {
            int intValor = 0;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    if (pBE_Islas.ID != 0)
                    {
                        intValor = DA_Islas.ActualizarEstadoIslas(pBE_Islas);
                    }
                    ts.Complete();
                }
                intValor = Convert.ToInt32(pBE_Islas.ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intValor;
        }
    }
}
