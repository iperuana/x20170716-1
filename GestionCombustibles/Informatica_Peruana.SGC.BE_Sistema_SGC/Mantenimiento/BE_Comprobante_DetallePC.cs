using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento
{
    public partial class BE_Comprobante_Detalle
    {
        public string Str_texto_buscar { get; set; }

        public BE_Comprobante_Detalle()
        {
        }

        public BE_Comprobante_Detalle(IDataReader pDataReader, int pIntTipo)
        {
            switch (pIntTipo)
            {
                case 1:
                    this.ID = pDataReader["id_comprobante"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_comprobante"].ToString()) : null;
                    this.ID_Item_Comprobante = pDataReader["id_item_comprobante"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_item_comprobante"].ToString()) : null;
                    this.Str_Cod_Surtidor = pDataReader["v_cod_surtidor"] != DBNull.Value ? pDataReader["v_cod_surtidor"].ToString() : null;
                    this.Str_Cod_Isla = pDataReader["v_cod_isla"] != DBNull.Value ? pDataReader["v_cod_isla"].ToString() : null;
                    this.Str_Cod_Lados = pDataReader["v_cod_lados"] != DBNull.Value ? pDataReader["v_cod_lados"].ToString() : null;
                    this.Str_Cod_Manguera = pDataReader["v_cod_manguera"] != DBNull.Value ? pDataReader["v_cod_manguera"].ToString() : null;
                    this.Str_Cod_Producto = pDataReader["v_cod_producto"] != DBNull.Value ? pDataReader["v_cod_producto"].ToString() : null;
                    this.Dec_Precio_Unitario_DComprobante = pDataReader["d_precio_unitario_dcomprobante"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_precio_unitario_dcomprobante"].ToString()) : null;
                    this.Dec_Cantidad_DComprobante = pDataReader["d_cantidad_dcomprobante"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_cantidad_dcomprobante"].ToString()) : null;
                    //this.Dec_Total_Item_DComprobante = pDataReader["d_total_item_dcomprobante"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_total_item_dcomprobante"].ToString()) : null;

                    break;
                case 2:
                    this.ID = pDataReader["id_comprobante"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_comprobante"].ToString()) : null;
                    this.ID_Item_Comprobante = pDataReader["id_item_comprobante"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_item_comprobante"].ToString()) : null;
                    this.Str_Cod_Surtidor = pDataReader["v_cod_surtidor"] != DBNull.Value ? pDataReader["v_cod_surtidor"].ToString() : null;
                    this.Str_Cod_Isla = pDataReader["v_cod_isla"] != DBNull.Value ? pDataReader["v_cod_isla"].ToString() : null;
                    this.Str_Cod_Lados = pDataReader["v_cod_lados"] != DBNull.Value ? pDataReader["v_cod_lados"].ToString() : null;
                    this.Str_Cod_Manguera = pDataReader["v_cod_manguera"] != DBNull.Value ? pDataReader["v_cod_manguera"].ToString() : null;
                    this.Str_Cod_Producto = pDataReader["v_cod_producto"] != DBNull.Value ? pDataReader["v_cod_producto"].ToString() : null;
                    this.Dec_Precio_Unitario_DComprobante = pDataReader["d_precio_unitario_dcomprobante"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_precio_unitario_dcomprobante"].ToString()) : null;
                    this.Dec_Cantidad_DComprobante = pDataReader["d_cantidad_dcomprobante"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_cantidad_dcomprobante"].ToString()) : null;
                    //this.Dec_Total_Item_DComprobante = pDataReader["d_total_item_dcomprobante"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_total_item_dcomprobante"].ToString()) : null;

                    break;
            }
        }

    }
}
