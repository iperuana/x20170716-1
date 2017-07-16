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
    public static class BL_Comprobante
    {
        public static int Registrar_Comprobante(BE_Comprobante pBE_comprobante)
        {
            int intValor = 0;
            try
            {
                
                intValor = DA_Comprobante.Registrar_Comprobante(pBE_comprobante);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intValor;
        }
    }
}
