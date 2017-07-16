using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento
{
    public partial class BE_clientes:BE_Base
    {
        public string Str_num_documento { get; set; }
        public string Str_nom_cliente { get; set; }
        public string Str_direccion_cliente { get; set; }
        public string Str_v_ubigeo { get; set; }
        public int? Int_chk_promo_vigentes { get; set; }
        public int? Int_chk_aceptar_vtas_credito { get; set; }
        public decimal? Dcm_linea_credito { get; set; }
        public decimal? Dcm_credito_utilizado { get; set; }
        public decimal? Dcm_credito_disponible { get; set; }
       
    }
}
