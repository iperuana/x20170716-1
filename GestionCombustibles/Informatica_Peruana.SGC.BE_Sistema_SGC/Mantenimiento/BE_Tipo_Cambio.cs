using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento
{
    public partial class BE_Tipo_Cambio:BE_Base
    {
        public string Str_Fecha { get; set; }
        public decimal? Dcm_Venta { get; set; }
        public decimal? Dcm_Compra { get; set; }
    }
}
