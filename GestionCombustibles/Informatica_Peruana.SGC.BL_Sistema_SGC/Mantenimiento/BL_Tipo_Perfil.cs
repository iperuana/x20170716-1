using Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento;
using Informatica_Peruana.SGC.DA_Sistema_SGC.Mantenimiento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatica_Peruana.SGC.BL_Sistema_SGC.Mantenimiento
{
    public class BL_Tipo_Perfil
    {
        public static List<BE_Tipo_Perfil> Listar_Tipo_Perfil_Desp(BE_Tipo_Perfil pBE_Tipo_Perfil)
        {
            try
            {
                return DA_Tipo_Perfil.Listar_Tipo_Perfil_Desp(pBE_Tipo_Perfil);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
