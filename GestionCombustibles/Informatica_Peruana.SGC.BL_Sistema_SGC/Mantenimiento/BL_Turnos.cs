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
    public partial class BL_Turnos
    {
        #region"listado"
        public static List<BE_Turnos> Listar_Turnos(BE_Turnos pBE_Turnos)
        {
            try
            {
                return DA_Turnos.Listar_Turnos(pBE_Turnos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<BE_Turnos> Listar_Turnos_x_ID(BE_Turnos pBE_Turnos)
        {
            try
            {
                return DA_Turnos.Listar_Turnos_x_ID(pBE_Turnos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region"Mantenimiento"
        public static int Registrar_Turnos(BE_Turnos pBE_Turnos)
        {
            int intValor = 0;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {

                    intValor = DA_Turnos.Registrar_Turnos(pBE_Turnos);

                    ts.Complete();
                }
                intValor = Convert.ToInt32(pBE_Turnos.ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intValor;
        }
        public static int Actualizar_Turnos(BE_Turnos pBE_Turnos)
        {
            int intValor = 0;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {

                    intValor = DA_Turnos.Actualizar_Turnos(pBE_Turnos);

                    ts.Complete();
                }
                intValor = Convert.ToInt32(pBE_Turnos.ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intValor;
        }
        public static int ActualizarEstadoTurnos(BE_Turnos pBE_Turnos)
        {
            int intValor = 0;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    if (pBE_Turnos.ID != 0)
                    {
                        intValor = DA_Turnos.ActualizarEstadoTurnos(pBE_Turnos);
                    }
                    ts.Complete();
                }
                intValor = Convert.ToInt32(pBE_Turnos.ID);
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
