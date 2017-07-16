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
   public partial  class BL_Provincia
    {
        public static List<BE_Provincia> Listar_Provincia_Desp(BE_Provincia pBE_Provincia)
        {
            try
            {
                return DA_Provincia.Listar_Provincia_Desp(pBE_Provincia);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
