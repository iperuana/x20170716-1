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
    public class BL_Tipo_Documento
    {
        #region "Listados"
        public static List<BE_Tipo_Documento> Listar_Tipo_Documento(BE_Tipo_Documento pBE_Tipo_Documento)
        {
            try
            {
                return DA_Tipo_Documento.Listar_Tipo_Documento(pBE_Tipo_Documento);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 
        #endregion
    }
}
