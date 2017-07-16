using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento
{
    public partial class BE_Comprobante
    {
        public string Str_texto_buscar { get; set; }

        public BE_Comprobante()
        {
        }

        public BE_Comprobante(IDataReader pDataReader, int pIntTipo)
        {
            switch (pIntTipo)
            {
                case 1:
                    this.ID = pDataReader["id_comprobante"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_comprobante"].ToString()) : null;
                    this.Str_Tipo_Comprobante = pDataReader["v_tipo_comprobante"] != DBNull.Value ? pDataReader["v_tipo_comprobante"].ToString() : null;
                    this.Str_Serie_Comprobante = pDataReader["v_serie_comprobante"] != DBNull.Value ? pDataReader["v_serie_comprobante"].ToString() : null;
                    this.Str_Numero_Comprobante = pDataReader["v_numero_comprobante"] != DBNull.Value ? pDataReader["v_numero_comprobante"].ToString() : null;
                    this.Str_Num_Documento_Cliente = pDataReader["v_num_documento_cliente"] != DBNull.Value ? pDataReader["v_num_documento_cliente"].ToString() : null;
                    this.Str_Fecha_Hora_Comprobante = pDataReader["v_fecha_hora_comprobante"] != DBNull.Value ? pDataReader["v_fecha_hora_comprobante"].ToString() : null;
                    this.Str_Placa_Comprobante = pDataReader["v_placa_comprobante"] != DBNull.Value ? pDataReader["v_placa_comprobante"].ToString() : null;
                    this.Str_Linea_Cred_Soles_Comprobante = pDataReader["v_linea_cred_soles_comprobante"] != DBNull.Value ? pDataReader["v_linea_cred_soles_comprobante"].ToString() : null;
                    this.Str_Cod_Operador = pDataReader["v_cod_operador"] != DBNull.Value ? pDataReader["v_cod_operador"].ToString() : null;
                    this.Str_Cod_Turno = pDataReader["v_cod_turno"] != DBNull.Value ? pDataReader["v_cod_turno"].ToString() : null;
                    this.Str_Tarjeta_Soles_Comprobante = pDataReader["v_tarjeta_soles_comprobante"] != DBNull.Value ? pDataReader["v_tarjeta_soles_comprobante"].ToString() : null;
                    this.Str_Linea_Cred_Comprobante = pDataReader["v_linea_cred_comprobante"] != DBNull.Value ? pDataReader["v_linea_cred_comprobante"].ToString() : null;
                    this.Dec_Total_Gravado_Comprobante = pDataReader["d_total_gravado_comprobante"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_total_gravado_comprobante"].ToString()) : null;
                    this.Dec_Total_Gratuito_Comprobante = pDataReader["d_total_gratuito_comprobante"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_total_gratuito_comprobante"].ToString()) : null;
                    this.Dec_Total_Inafecto_Comprobante = pDataReader["d_total_inafecto_comprobante"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_total_inafecto_comprobante"].ToString()) : null;
                    this.Dec_Total_Exonerado_Comprobante = pDataReader["d_total_exonerado_comprobante"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_total_exonerado_comprobante"].ToString()) : null;
                    this.Dec_Dscnto_Global_Comprobante = pDataReader["d_dscnto_global_comprobante"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_dscnto_global_comprobante"].ToString()) : null;
                    this.Dec_Total_Venta_Soles_Comprobante = pDataReader["d_total_venta_soles_comprobante"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_total_venta_soles_comprobante"].ToString()) : null;
                    this.Dec_Total_Igv_Soles_Comprobante = pDataReader["d_total_igv_soles_comprobante"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_total_igv_soles_comprobante"].ToString()) : null;
                    this.Dec_Total_Isc_Soles_Comprobante = pDataReader["Dec_Total_Isc_Soles_Comprobante"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["Dec_Total_Isc_Soles_Comprobante"].ToString()) : null;
                    this.Dec_Efectivo_Soles_Comprobante = pDataReader["d_efectivo_soles_comprobante"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_efectivo_soles_comprobante"].ToString()) : null;
                    this.Dec_Tipo_Cambio_Comprobante = pDataReader["d_tipo_cambio_comprobante"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_tipo_cambio_comprobante"].ToString()) : null;
                    this.Dec_Efectivo_Dolares_Comprobante = pDataReader["d_efectivo_dolares_comprobante"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_efectivo_dolares_comprobante"].ToString()) : null;
                    this.Dec_Pago_Comprobante = pDataReader["d_pago_comprobante"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_pago_comprobante"].ToString()) : null;
                    this.Dec_Vuelto_Comprobante = pDataReader["d_vuelto_comprobante"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_vuelto_comprobante"].ToString()) : null;
                    this.Str_Monto_Letras_Comprobante = pDataReader["v_monto_letras_comprobante"] != DBNull.Value ? pDataReader["v_monto_letras_comprobante"].ToString() : null;
                    this.Str_Hash_Comprobante = pDataReader["v_hash_comprobante"] != DBNull.Value ? pDataReader["v_hash_comprobante"].ToString() : null;
                    this.Str_MsjRpta_Comprobante = pDataReader["v_msjrpta_comprobante "] != DBNull.Value ? pDataReader["v_msjrpta_comprobante"].ToString() : null;

                    break;
                case 2:
                    this.ID = pDataReader["id_comprobante"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_comprobante"].ToString()) : null;
                    this.Str_Tipo_Comprobante = pDataReader["v_tipo_comprobante"] != DBNull.Value ? pDataReader["v_tipo_comprobante"].ToString() : null;
                    this.Str_Serie_Comprobante = pDataReader["v_serie_comprobante"] != DBNull.Value ? pDataReader["v_serie_comprobante"].ToString() : null;
                    this.Str_Numero_Comprobante = pDataReader["v_numero_comprobante"] != DBNull.Value ? pDataReader["v_numero_comprobante"].ToString() : null;
                    this.Str_Num_Documento_Cliente = pDataReader["v_num_documento_cliente"] != DBNull.Value ? pDataReader["v_num_documento_cliente"].ToString() : null;
                    this.Str_Fecha_Hora_Comprobante = pDataReader["v_fecha_hora_comprobante"] != DBNull.Value ? pDataReader["v_fecha_hora_comprobante"].ToString() : null;
                    this.Str_Placa_Comprobante = pDataReader["v_placa_comprobante"] != DBNull.Value ? pDataReader["v_placa_comprobante"].ToString() : null;
                    this.Str_Linea_Cred_Soles_Comprobante = pDataReader["v_linea_cred_soles_comprobante"] != DBNull.Value ? pDataReader["v_linea_cred_soles_comprobante"].ToString() : null;
                    this.Str_Cod_Operador = pDataReader["v_cod_operador"] != DBNull.Value ? pDataReader["v_cod_operador"].ToString() : null;
                    this.Str_Cod_Turno = pDataReader["v_cod_turno"] != DBNull.Value ? pDataReader["v_cod_turno"].ToString() : null;
                    this.Str_Tarjeta_Soles_Comprobante = pDataReader["v_tarjeta_soles_comprobante"] != DBNull.Value ? pDataReader["v_tarjeta_soles_comprobante"].ToString() : null;
                    this.Str_Linea_Cred_Comprobante = pDataReader["v_linea_cred_comprobante"] != DBNull.Value ? pDataReader["v_linea_cred_comprobante"].ToString() : null;
                    this.Dec_Total_Gravado_Comprobante = pDataReader["d_total_gravado_comprobante"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_total_gravado_comprobante"].ToString()) : null;
                    this.Dec_Total_Gratuito_Comprobante = pDataReader["d_total_gratuito_comprobante"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_total_gratuito_comprobante"].ToString()) : null;
                    this.Dec_Total_Inafecto_Comprobante = pDataReader["d_total_inafecto_comprobante"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_total_inafecto_comprobante"].ToString()) : null;
                    this.Dec_Total_Exonerado_Comprobante = pDataReader["d_total_exonerado_comprobante"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_total_exonerado_comprobante"].ToString()) : null;
                    this.Dec_Dscnto_Global_Comprobante = pDataReader["d_dscnto_global_comprobante"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_dscnto_global_comprobante"].ToString()) : null;
                    this.Dec_Total_Venta_Soles_Comprobante = pDataReader["d_total_venta_soles_comprobante"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_total_venta_soles_comprobante"].ToString()) : null;
                    this.Dec_Total_Igv_Soles_Comprobante = pDataReader["d_total_igv_soles_comprobante"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_total_igv_soles_comprobante"].ToString()) : null;
                    this.Dec_Total_Isc_Soles_Comprobante = pDataReader["Dec_Total_Isc_Soles_Comprobante"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["Dec_Total_Isc_Soles_Comprobante"].ToString()) : null;
                    this.Dec_Efectivo_Soles_Comprobante = pDataReader["d_efectivo_soles_comprobante"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_efectivo_soles_comprobante"].ToString()) : null;
                    this.Dec_Tipo_Cambio_Comprobante = pDataReader["d_tipo_cambio_comprobante"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_tipo_cambio_comprobante"].ToString()) : null;
                    this.Dec_Efectivo_Dolares_Comprobante = pDataReader["d_efectivo_dolares_comprobante"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_efectivo_dolares_comprobante"].ToString()) : null;
                    this.Dec_Pago_Comprobante = pDataReader["d_pago_comprobante"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_pago_comprobante"].ToString()) : null;
                    this.Dec_Vuelto_Comprobante = pDataReader["d_vuelto_comprobante"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_vuelto_comprobante"].ToString()) : null;
                    this.Str_Monto_Letras_Comprobante = pDataReader["v_monto_letras_comprobante"] != DBNull.Value ? pDataReader["v_monto_letras_comprobante"].ToString() : null;
                    this.Str_Hash_Comprobante = pDataReader["v_hash_comprobante"] != DBNull.Value ? pDataReader["v_hash_comprobante"].ToString() : null;
                    this.Str_MsjRpta_Comprobante = pDataReader["v_msjrpta_comprobante "] != DBNull.Value ? pDataReader["v_msjrpta_comprobante"].ToString() : null;

                    break;
            }
        }
    }
}
