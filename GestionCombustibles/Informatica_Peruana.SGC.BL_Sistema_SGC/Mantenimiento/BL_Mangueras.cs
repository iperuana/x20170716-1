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
    public partial class BL_Mangueras
    {
        public static List<BE_Mangueras> Listar_Mangueras(BE_Mangueras pBE_manguera)
        {
            try
            {
                return DA_Mangueras.Listar_Mangueras (pBE_manguera);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<BE_Mangueras> Listar_Mangueras_x_ID(BE_Mangueras pBE_manguera)
        {
            try
            {
                return DA_Mangueras.Listar_Mangueras_x_ID(pBE_manguera);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
