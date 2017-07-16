using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento
{
    public partial class BE_Productos
    {
        public string Str_texto_buscar { get; set; }
        public BE_Productos()
        {

        }

        public BE_Productos(IDataReader pDataReader, int pIntTipo)
        {
            switch (pIntTipo)
            {
                case 1:
                    this.ID = pDataReader["id_producto"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_producto"].ToString()) : null;
                    this.Str_cod_producto = pDataReader["v_cod_producto"] != DBNull.Value ? pDataReader["v_cod_producto"].ToString() : null;
                    this.Str_nom_producto = pDataReader["v_nom_producto"] != DBNull.Value ? pDataReader["v_nom_producto"].ToString() : null;
                    this.Dcm_Venta = pDataReader["d_p_venta"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_p_venta"]) : null;
                    this.Dcm_Compra = pDataReader["d_c_compra"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_c_compra"]) : null;
                    this.Int_flg_afecto_igv = pDataReader["i_flg_afecto_igv"] != DBNull.Value ? (int?)Convert.ToDecimal(pDataReader["i_flg_afecto_igv"]) : null;
                    this.Int_flg_afecto_isc = pDataReader["i_flg_afecto_isc"] != DBNull.Value ? (int?)Convert.ToDecimal(pDataReader["i_flg_afecto_isc"]) : null;
                    this.Str_uni_med = pDataReader["v_uni_med"] != DBNull.Value ? pDataReader["v_uni_med"].ToString() : null;
                    break;
                case 2:
                    this.ID = pDataReader["id_producto"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_producto"].ToString()) : null;
                    this.Str_cod_producto = pDataReader["v_cod_producto"] != DBNull.Value ? pDataReader["v_cod_producto"].ToString() : null;
                    this.Str_nom_producto = pDataReader["v_nom_producto"] != DBNull.Value ? pDataReader["v_nom_producto"].ToString() : null;
                    this.Dcm_Venta = pDataReader["d_p_venta"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_p_venta"]) : null;
                    this.Dcm_Compra = pDataReader["d_c_compra"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_c_compra"]) : null;
                    this.Int_flg_afecto_igv = pDataReader["i_flg_afecto_igv"] != DBNull.Value ? (int?)Convert.ToDecimal(pDataReader["i_flg_afecto_igv"]) : null;
                    this.Int_flg_afecto_isc = pDataReader["i_flg_afecto_isc"] != DBNull.Value ? (int?)Convert.ToDecimal(pDataReader["i_flg_afecto_isc"]) : null;
                    this.Str_uni_med = pDataReader["v_uni_med"] != DBNull.Value ? pDataReader["v_uni_med"].ToString() : null;

                    break;
                case 3:
                    this.ID = pDataReader["id_producto"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_producto"].ToString()) : null;
                    this.Str_nom_producto = pDataReader["v_nom_producto"] != DBNull.Value ? pDataReader["v_nom_producto"].ToString() : null;
                    //this.Dcm_Venta = pDataReader["d_p_venta"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_p_venta"]) : null;
                    //this.Dcm_Compra = pDataReader["d_c_compra"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_c_compra"]) : null;
                    break;
            }
        }
    }
}
