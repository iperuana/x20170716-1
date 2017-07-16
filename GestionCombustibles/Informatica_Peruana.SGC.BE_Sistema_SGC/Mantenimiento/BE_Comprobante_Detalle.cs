using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento
{
    public partial class BE_Comprobante_Detalle : BE_Base
    {
        public int? ID_Item_Comprobante { get; set; }

        public string Str_Cod_Surtidor { get; set; }

        public string Str_Cod_Isla { get; set; }

        public string Str_Cod_Lados { get; set; }

        public string Str_Cod_Manguera { get; set; }

        public string Str_Cod_Producto { get; set; }

        public decimal? Dec_Precio_Unitario_DComprobante { get; set; }

        public decimal? Dec_Cantidad_DComprobante { get; set; }

        public decimal? Dec_SubTotal_Gravado_DComprobante { get; set; }

        public decimal? Dec_SubTotal_Gratuito_DComprobante { get; set; }

        public decimal? Dec_SubTotal_Inafecto_DComprobante { get; set; }

        public decimal? Dec_SubTotal_Exonerado_DComprobante { get; set; }

        public decimal? Dec_SubTotal_Item_DComprobante { get; set; }

        public int? Int_Flg_Agecto_IGV { get; set; }

        public decimal? Dec_IGV_Item_DComprobante { get; set; }

        public int? Int_Flg_Agecto_ISC { get; set; }

        public decimal? Dec_ISC_Item_DComprobante { get; set; }
    }
}
