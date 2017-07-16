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
   public partial class BL_Nivel
    {
        #region"Listado"
        public static List<BE_Nivel> Listar_Nivel(BE_Nivel pBE_Nivel)
        {
            try
            {
                return DA_Nivel.Listar_Nivel(pBE_Nivel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public static List<BE_clientes> Listar_Clientes_x_ID(BE_clientes pBE_Clientes)
        //{
        //    try
        //    {
        //        return DA_Clientes.Listar_Clientes_x_ID(pBE_Clientes);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        #endregion
        #region"Mantenimiento"
        //public static int Registrar_clientes(BE_clientes pBE_clientes)
        //{
        //    int intValor = 0;
        //    try
        //    {
        //        using (TransactionScope ts = new TransactionScope())
        //        {

        //            intValor = DA_Clientes.Registrar_Clientes(pBE_clientes);

        //            ts.Complete();
        //        }
        //        intValor = Convert.ToInt32(pBE_clientes.ID);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return intValor;
        //}
        //public static int Actualizar_clientes(BE_clientes pBE_clientes)
        //{
        //    int intValor = 0;
        //    try
        //    {
        //        using (TransactionScope ts = new TransactionScope())
        //        {

        //            intValor = DA_Clientes.Actualizar_clientes(pBE_clientes);

        //            ts.Complete();
        //        }
        //        intValor = Convert.ToInt32(pBE_clientes.ID);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return intValor;
        //}
        //public static int ActualizarEstadoclientes(BE_clientes pBE_clientes)
        //{
        //    int intValor = 0;
        //    try
        //    {
        //        using (TransactionScope ts = new TransactionScope())
        //        {
        //            if (pBE_clientes.ID != 0)
        //            {
        //                intValor = DA_Clientes.ActualizarEstadoclientes(pBE_clientes);
        //            }
        //            ts.Complete();
        //        }
        //        intValor = Convert.ToInt32(pBE_clientes.ID);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return intValor;
        //}
        #endregion
    }
}
