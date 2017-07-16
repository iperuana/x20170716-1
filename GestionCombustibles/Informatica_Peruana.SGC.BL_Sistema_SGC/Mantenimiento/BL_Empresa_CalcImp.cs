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
    public partial class BL_Empresa_CalcImp
    {
        public static List<BE_empresa_calcimp> Listar_Empresa_CalcImp(BE_empresa_calcimp pBE_Empresa_CalcImp)
        {
            try
            {
                return DA_Empresa_CalcImp.Listar_Empresa_CalcImp(pBE_Empresa_CalcImp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<BE_empresa_calcimp> Listar_Empresas_CalcImp_x_ID(BE_empresa_calcimp pBE_Empresa_CalcImp)
        {
            try
            {
                return DA_Empresa_CalcImp.Listar_Empresas_CalcImp_x_ID(pBE_Empresa_CalcImp);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
