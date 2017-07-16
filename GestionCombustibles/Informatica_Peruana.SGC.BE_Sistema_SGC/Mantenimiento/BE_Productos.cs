using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento
{
   public partial class BE_Productos:BE_Base
    {
        public string Str_cod_producto { get; set; }
        public string Str_nom_producto { get; set; }
        public decimal? Dcm_Venta { get; set; }
        public decimal? Dcm_Compra { get; set; }
        public int? Int_flg_afecto_igv { get; set; }
        public int? Int_flg_afecto_isc { get; set; }
        public string Str_uni_med { get; set;  }
    }
}
