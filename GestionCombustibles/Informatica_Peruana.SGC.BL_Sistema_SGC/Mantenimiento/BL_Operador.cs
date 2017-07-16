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
    public partial class BL_Operador
    {
        public static List<BE_Operador> Listar_Operador(BE_Operador pBE_Operador)
        {
            try
            {
                return DA_Operador.Listar_Operador(pBE_Operador);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<BE_Operador> Listar_Operador_x_ID(BE_Operador pBE_Operador)
        {
            try
            {
                return DA_Operador.Listar_Operador_x_ID(pBE_Operador);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<BE_Operador> Listar_Operador_Logueo(BE_Operador pBE_Operador)
        {
            try
            {
                return DA_Operador.Listar_Operador_Logueo(pBE_Operador);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
