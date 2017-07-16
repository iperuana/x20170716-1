using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatica_Peruana.SGC.BE_Sistema_SGC
{
    public class BE_Base
    {
        public int? ID { get; set; }
        public string VID { get; set; }
        public int? IDUsuarioCreacion { get; set; }
        public int? IDUsuarioModificacion { get; set; }
        public string StrFechaCreacion { get; set; }
        public string StrFechaModificacion { get; set; }
        public int? IntEstado { get; set; }
        public string StrLatitud { get; set; }
        public string StrLongitud { get; set; }
    }
}
