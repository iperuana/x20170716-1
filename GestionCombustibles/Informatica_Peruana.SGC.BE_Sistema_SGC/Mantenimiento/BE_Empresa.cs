using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento
{
    public partial class BE_Empresa :BE_Base
    {
        public string Str_num_documento { get; set; }
        public string Str_nom_empresa { get; set; }
        public string Str_direccion_empresa { get; set; }
        public string Str_ubigeo { get; set; }
        public string Str_texto { get; set; }
    }
}
