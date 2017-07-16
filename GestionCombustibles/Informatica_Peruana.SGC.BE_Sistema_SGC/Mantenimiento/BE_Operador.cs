using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento
{
    public partial class BE_Operador: BE_Base
    {
        public string Str_Cod_Operador { get; set; }

        public string Str_Nombre_Operador { get; set; }

        public string Str_ApePaterno_Operador { get; set; }

        public string Str_ApeMaterno_Operador { get; set; }

        public int? ID_Nivel { get; set; }

        public string Str_Usuario_Operador { get; set; }

        public string Str_Clave_Operador { get; set; }
    }
}
