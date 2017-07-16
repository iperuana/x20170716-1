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
    public partial class BL_Tablas_Tipo
    {
        public static List<BE_Tablas_Tipos> Listar_Tablas_Tipo(BE_Tablas_Tipos pBE_Tablas_Tipos)
        {
            try
            {
                return DA_Tablas_Tipo.Listar_Tablas_Tipo(pBE_Tablas_Tipos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<BE_Tablas_Tipos> Listar_Tablas_Tipo_x_ID(BE_Tablas_Tipos pBE_Tablas_Tipo)
        {
            try
            {
                return DA_Tablas_Tipo.Listar_Tablas_Tipo_x_ID(pBE_Tablas_Tipo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
