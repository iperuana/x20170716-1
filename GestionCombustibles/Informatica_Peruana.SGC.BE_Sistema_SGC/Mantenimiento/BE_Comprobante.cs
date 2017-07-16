using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento
{
    public partial class BE_Comprobante : BE_Base
    {
        public string Str_Tipo_Comprobante { get; set; }

        public string Str_Serie_Comprobante { get; set; }

        public string Str_Numero_Comprobante { get; set; }

        public string Str_Num_Documento_Cliente { get; set; }

        public string Str_Fecha_Hora_Comprobante { get; set; }

        public string Str_Placa_Comprobante { get; set; }

        public string Str_Linea_Cred_Soles_Comprobante { get; set; }

        public string Str_Cod_Operador { get; set; }

        public string Str_Cod_Turno { get; set; }

        public string Str_Tarjeta_Soles_Comprobante { get; set; }

        public string Str_Linea_Cred_Comprobante { get; set; }

        public decimal? Dec_Total_Gravado_Comprobante { get; set; }

        public decimal? Dec_Total_Gratuito_Comprobante { get; set; }

        public decimal? Dec_Total_Inafecto_Comprobante { get; set; }

        public decimal? Dec_Total_Exonerado_Comprobante { get; set; }

        public decimal? Dec_Dscnto_Global_Comprobante { get; set; }

        public decimal? Dec_Total_Venta_Soles_Comprobante { get; set; }

        public decimal? Dec_Total_Igv_Soles_Comprobante { get; set; }

        public decimal? Dec_Total_Isc_Soles_Comprobante { get; set; }

        public decimal? Dec_Efectivo_Soles_Comprobante { get; set; }

        public decimal? Dec_Tipo_Cambio_Comprobante { get; set; }

        public decimal? Dec_Efectivo_Dolares_Comprobante { get; set; }
        
        public decimal? Dec_Pago_Comprobante { get; set; }

        public decimal? Dec_Vuelto_Comprobante { get; set; }

        public string Str_Monto_Letras_Comprobante { get; set; }

        public string Str_Hash_Comprobante { get; set; }

        public string Str_MsjRpta_Comprobante { get; set; }

        public List<BE_Comprobante_Detalle> Listado_Detalle { get; set; }
    }
}
