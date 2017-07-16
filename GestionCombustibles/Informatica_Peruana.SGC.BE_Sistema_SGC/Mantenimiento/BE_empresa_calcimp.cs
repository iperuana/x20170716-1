using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento
{
    public partial class BE_empresa_calcimp : BE_Base
    {
        public int? ID_CalcImp { get; set; }

        public decimal? Dec_CalculoIGV_CalcImp { get; set; }

        public decimal? Dec_CalculoISC_CalcImp { get; set; }
    }
}
