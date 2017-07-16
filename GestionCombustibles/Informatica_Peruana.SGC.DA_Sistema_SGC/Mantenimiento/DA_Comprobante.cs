using Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace Informatica_Peruana.SGC.DA_Sistema_SGC.Mantenimiento
{
    public partial class DA_Comprobante : DA_Base
    {
        public static int Registrar_Comprobante(BE_Comprobante pBE_comprobante)
        {
            int intIDInsercion = 0;
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    using (SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_INS_COMPROBANTE"))
                    {
                        cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                        db.AddOutParameter(cmd, "@id_comprobante", DbType.Int32, 0);
                        db.AddInParameter(cmd, "@v_tipo_comprobante", DbType.String, pBE_comprobante.Str_Tipo_Comprobante);
                        db.AddInParameter(cmd, "@v_serie_comprobante", DbType.String, pBE_comprobante.Str_Serie_Comprobante);
                        db.AddInParameter(cmd, "@v_numero_comprobante", DbType.String, pBE_comprobante.Str_Numero_Comprobante);
                        db.AddInParameter(cmd, "@v_num_documento_cliente", DbType.String, pBE_comprobante.Str_Num_Documento_Cliente);
                        db.AddInParameter(cmd, "@v_fecha_hora_comprobante", DbType.String, pBE_comprobante.Str_Fecha_Hora_Comprobante);
                        db.AddInParameter(cmd, "@v_placa_comprobante", DbType.String, pBE_comprobante.Str_Placa_Comprobante);
                        db.AddInParameter(cmd, "@v_linea_cred_soles_comprobante", DbType.String, pBE_comprobante.Str_Linea_Cred_Soles_Comprobante);
                        db.AddInParameter(cmd, "@v_cod_operador", DbType.String, pBE_comprobante.Str_Cod_Operador);
                        db.AddInParameter(cmd, "@v_cod_turno", DbType.String, pBE_comprobante.Str_Cod_Turno);
                        db.AddInParameter(cmd, "@v_tarjeta_soles_comprobante", DbType.String, pBE_comprobante.Str_Tarjeta_Soles_Comprobante);
                        db.AddInParameter(cmd, "@v_linea_cred_comprobante", DbType.String, pBE_comprobante.Str_Linea_Cred_Comprobante);
                        db.AddInParameter(cmd, "@d_total_gravado_comprobante", DbType.Decimal, pBE_comprobante.Dec_Total_Gravado_Comprobante);
                        db.AddInParameter(cmd, "@d_total_gratuito_comprobante", DbType.Decimal, pBE_comprobante.Dec_Total_Gratuito_Comprobante);
                        db.AddInParameter(cmd, "@d_total_inafecto_comprobante", DbType.Decimal, pBE_comprobante.Dec_Total_Inafecto_Comprobante);
                        db.AddInParameter(cmd, "@d_total_exonerado_comprobante", DbType.Decimal, pBE_comprobante.Dec_Total_Exonerado_Comprobante);
                        db.AddInParameter(cmd, "@d_dscnto_global_comprobante", DbType.Decimal, pBE_comprobante.Dec_Dscnto_Global_Comprobante);
                        db.AddInParameter(cmd, "@d_total_venta_soles_comprobante", DbType.Decimal, pBE_comprobante.Dec_Total_Venta_Soles_Comprobante);
                        db.AddInParameter(cmd, "@d_total_igv_soles_comprobante", DbType.Decimal, pBE_comprobante.Dec_Total_Igv_Soles_Comprobante);
                        db.AddInParameter(cmd, "@d_total_isc_soles_comprobante", DbType.Decimal, pBE_comprobante.Dec_Total_Isc_Soles_Comprobante);
                        db.AddInParameter(cmd, "@d_efectivo_soles_comprobante", DbType.Decimal, pBE_comprobante.Dec_Efectivo_Soles_Comprobante);
                        db.AddInParameter(cmd, "@d_tipo_cambio_comprobante", DbType.Decimal, pBE_comprobante.Dec_Tipo_Cambio_Comprobante);
                        db.AddInParameter(cmd, "@d_efectivo_dolares_comprobante", DbType.Decimal, pBE_comprobante.Dec_Efectivo_Dolares_Comprobante);
                        db.AddInParameter(cmd, "@d_pago_comprobante", DbType.Decimal, pBE_comprobante.Dec_Pago_Comprobante);
                        db.AddInParameter(cmd, "@d_vuelto_comprobante", DbType.Decimal, pBE_comprobante.Dec_Vuelto_Comprobante);
                        db.AddInParameter(cmd, "@v_monto_letras_comprobante", DbType.String, pBE_comprobante.Str_Monto_Letras_Comprobante);
                        db.AddInParameter(cmd, "@v_hash_comprobante", DbType.String, pBE_comprobante.Str_Hash_Comprobante);
                        db.AddInParameter(cmd, "@v_msjrpta_comprobante", DbType.String, pBE_comprobante.Str_MsjRpta_Comprobante);
                        db.AddInParameter(cmd, "@id_usuario_creacion", DbType.Int32, pBE_comprobante.IDUsuarioCreacion);
                        db.ExecuteNonQuery(cmd);
                        intIDInsercion = Convert.ToInt32(db.GetParameterValue(cmd, "@id_comprobante"));
                        pBE_comprobante.ID = intIDInsercion;
                    }

                    foreach (var item in pBE_comprobante.Listado_Detalle)
                    {
                        int intIDDetalleInsercion = 0;
                        using (SqlCommand cmdDetalle = (SqlCommand)db.GetStoredProcCommand("USP_INS_COMPROBANTE_DETALLE"))
                        {
                            cmdDetalle.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                            db.AddOutParameter(cmdDetalle, "@id_item_comprobante", DbType.Int32, 0);
                            db.AddInParameter(cmdDetalle, "@id_comprobante", DbType.Int32, intIDInsercion);
                            db.AddInParameter(cmdDetalle, "@v_cod_isla", DbType.String, item.Str_Cod_Isla);
                            db.AddInParameter(cmdDetalle, "@v_cod_surtidor", DbType.String, item.Str_Cod_Surtidor);
                            db.AddInParameter(cmdDetalle, "@v_cod_lados", DbType.String, item.Str_Cod_Lados);
                            db.AddInParameter(cmdDetalle, "@v_cod_manguera", DbType.String, item.Str_Cod_Manguera);
                            db.AddInParameter(cmdDetalle, "@v_cod_producto", DbType.String, item.Str_Cod_Producto);
                            db.AddInParameter(cmdDetalle, "@d_precio_unitario_dcomprobante", DbType.Decimal, item.Dec_Precio_Unitario_DComprobante);
                            db.AddInParameter(cmdDetalle, "@d_cantidad_dcomprobante", DbType.Decimal, item.Dec_Cantidad_DComprobante);
                            db.AddInParameter(cmdDetalle, "@d_subtotal_gravado_comprobante", DbType.Decimal, item.Dec_SubTotal_Gravado_DComprobante);
                            db.AddInParameter(cmdDetalle, "@d_subtotal_gratuito_comprobante", DbType.Decimal, item.Dec_SubTotal_Gratuito_DComprobante);
                            db.AddInParameter(cmdDetalle, "@d_subtotal_inafecto_comprobante", DbType.Decimal, item.Dec_SubTotal_Inafecto_DComprobante);
                            db.AddInParameter(cmdDetalle, "@d_subtotal_exonerado_comprobante", DbType.Decimal, item.Dec_SubTotal_Exonerado_DComprobante);
                            db.AddInParameter(cmdDetalle, "@d_subtotal_item_comprobante", DbType.Decimal, item.Dec_SubTotal_Item_DComprobante);
                            db.AddInParameter(cmdDetalle, "@i_flg_afecto_igv", DbType.Int32, item.Int_Flg_Agecto_IGV);
                            db.AddInParameter(cmdDetalle, "@d_igv_item_dcomprobante", DbType.Decimal, item.Dec_IGV_Item_DComprobante);
                            db.AddInParameter(cmdDetalle, "@i_flg_afecto_isc", DbType.Int32, item.Int_Flg_Agecto_ISC);
                            db.AddInParameter(cmdDetalle, "@d_isc_item_dcomprobante", DbType.Decimal, item.Dec_ISC_Item_DComprobante);
                            db.AddInParameter(cmdDetalle, "@id_usuario_creacion", DbType.Int32, item.IDUsuarioCreacion);
                            db.ExecuteNonQuery(cmdDetalle);

                            intIDDetalleInsercion = Convert.ToInt32(db.GetParameterValue(cmdDetalle, "@id_item_comprobante"));
                        }
                    }

                    scope.Complete();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return intIDInsercion;
        }
    }
}