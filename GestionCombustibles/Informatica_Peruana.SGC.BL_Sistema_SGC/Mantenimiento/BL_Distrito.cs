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
    public partial class BL_Distrito
    {
        public static List<BE_Distrito> Listar_Distrito_Desp(BE_Distrito pBE_Distrito) {
            try
            {
                return DA_Distrito.Listar_Distrito_Desp(pBE_Distrito);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
