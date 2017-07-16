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
    public class BL_Departamento
    {
        #region "Listados"
        //public static List<BE_Departamento> Listar_Departamento(BE_Departamento pBE_Departamento)
        //{
        //    try
        //    {
        //        return DA_Departamento.Listar_Departamento(pBE_Departamento);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        public static List<BE_Departamento> Listar_Departamento_Desp(BE_Departamento pBE_Departamento)
        {
            try
            {
                return DA_Departamento.Listar_Departamento_Desp(pBE_Departamento);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
