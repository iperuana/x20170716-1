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
   public partial class BL_Surtidor
    {
        public static List<BE_Surtidor> Listar_Surtidor(BE_Surtidor pBE_surtidor)
        {
            try
            {
                return DA_Surtidor.Listar_Surtidor(pBE_surtidor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<BE_Surtidor> Listar_Surtidor_x_ID(BE_Surtidor pBE_surtidor)
        {
            try
            {
                return DA_Surtidor.Listar_Surtidor_x_ID(pBE_surtidor);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int Registrar_Surtidor(BE_Surtidor pBE_surtidor)
        {
            int intValor = 0;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {

                    intValor = DA_Surtidor.Registrar_Surtidor(pBE_surtidor);

                    ts.Complete();
                }
                intValor = Convert.ToInt32(pBE_surtidor.ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intValor;
        }
        public static int Actualizar_Surtidor(BE_Surtidor pBE_surtidor)
        {
            int intValor = 0;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {

                    intValor = DA_Surtidor.Actualizar_Surtidor(pBE_surtidor);

                    ts.Complete();
                }
                intValor = Convert.ToInt32(pBE_surtidor.ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intValor;
        }
        public static int ActualizarEstadoSurtidor(BE_Surtidor pBE_surtidor)
        {
            int intValor = 0;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    if (pBE_surtidor.ID != 0)
                    {
                        intValor = DA_Surtidor.ActualizarEstadoSurtidor(pBE_surtidor);
                    }
                    ts.Complete();
                }
                intValor = Convert.ToInt32(pBE_surtidor.ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intValor;
        }
    }
}
