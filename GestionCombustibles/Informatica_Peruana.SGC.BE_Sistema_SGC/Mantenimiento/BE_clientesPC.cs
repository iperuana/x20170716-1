using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento
{
    public partial class BE_clientes
    {

        public string Str_texto_buscar { get; set; }
        public BE_Departamento oBE_Departamento { get; set; }
        public BE_Provincia oBE_Provincia { get; set; }
        public BE_Distrito oBE_Distrito { get; set; }
        public BE_Tipo_Documento oBE_Tipo_Documento { get; set; }

        public BE_clientes()
        {
            oBE_Departamento = new BE_Departamento();
            oBE_Provincia = new BE_Provincia();
            oBE_Distrito = new BE_Distrito();
            oBE_Tipo_Documento = new BE_Tipo_Documento();

        }
        public BE_clientes(IDataReader pDataReader, int pIntTipo)
        {
            oBE_Departamento = new BE_Departamento();
            oBE_Provincia = new BE_Provincia();
            oBE_Distrito = new BE_Distrito();
            oBE_Tipo_Documento = new BE_Tipo_Documento();
            switch (pIntTipo)
            {
                case 1:
                    this.ID = pDataReader["id_cliente"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_cliente"].ToString()) : null;
                    this.Str_num_documento = pDataReader["v_num_documento"] != DBNull.Value ? pDataReader["v_num_documento"].ToString() : null;
                    this.Str_nom_cliente = pDataReader["v_nom_cliente"] != DBNull.Value ? pDataReader["v_nom_cliente"].ToString() : null;
                    this.Str_direccion_cliente = pDataReader["v_direccion_cliente"] != DBNull.Value ? pDataReader["v_direccion_cliente"].ToString() : null;
                    this.Str_v_ubigeo = pDataReader["v_ubigeo"] != DBNull.Value ? pDataReader["v_ubigeo"].ToString() : null;
                    this.Int_chk_promo_vigentes = pDataReader["i_chk_promo_vigentes"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["i_chk_promo_vigentes"].ToString()) : null;
                    this.Int_chk_aceptar_vtas_credito = pDataReader["i_chk_aceptar_vtas_credito"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["i_chk_aceptar_vtas_credito"].ToString()) : null;
                    this.Dcm_linea_credito = pDataReader["d_linea_credito"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_linea_credito"]) : null;
                    this.Dcm_credito_utilizado = pDataReader["d_credito_utilizado"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_credito_utilizado"]) : null;
                    this.Dcm_credito_disponible = pDataReader["d_credito_disponible"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_credito_disponible"]) : null;
                    break;

                case 2:
                    this.ID = pDataReader["id_cliente"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_cliente"].ToString()) : null;
                    this.oBE_Tipo_Documento.ID = pDataReader["id_tipo_documento"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_tipo_documento"].ToString()) : null;
                    this.oBE_Tipo_Documento.Str_abrev_tipo_documento = pDataReader["tipo_documento"] != DBNull.Value ? pDataReader["tipo_documento"].ToString() : null;
                    this.Str_num_documento = pDataReader["v_num_documento"] != DBNull.Value ? pDataReader["v_num_documento"].ToString() : null;
                    this.Str_nom_cliente = pDataReader["v_nom_cliente"] != DBNull.Value ? pDataReader["v_nom_cliente"].ToString() : null;
                    this.Str_direccion_cliente = pDataReader["v_direccion_cliente"] != DBNull.Value ? pDataReader["v_direccion_cliente"].ToString() : null;
                    this.oBE_Departamento.ID = pDataReader["id_departamento"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_departamento"].ToString()) : null;
                    this.oBE_Departamento.Str_Departamento = pDataReader["departamento"] != DBNull.Value ? pDataReader["departamento"].ToString() : null;
                    this.oBE_Provincia.ID = pDataReader["id_provincia"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_provincia"].ToString()) : null;
                    this.oBE_Provincia.Str_Provincia = pDataReader["provincia"] != DBNull.Value ? pDataReader["provincia"].ToString() : null;
                    this.oBE_Distrito.ID = pDataReader["id_distrito"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_distrito"].ToString()) : null;
                    this.oBE_Distrito.Str_Distrito = pDataReader["distrito"] != DBNull.Value ? pDataReader["distrito"].ToString() : null;
                    this.Str_v_ubigeo = pDataReader["v_ubigeo"] != DBNull.Value ? pDataReader["v_ubigeo"].ToString() : null;
                    this.Int_chk_promo_vigentes = pDataReader["i_chk_promo_vigentes"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["i_chk_promo_vigentes"].ToString()) : null;
                    this.Int_chk_aceptar_vtas_credito = pDataReader["i_chk_aceptar_vtas_credito"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["i_chk_aceptar_vtas_credito"].ToString()) : null;
                    this.Dcm_linea_credito = pDataReader["d_linea_credito"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_linea_credito"]) : null;
                    this.Dcm_credito_utilizado = pDataReader["d_credito_utilizado"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_credito_utilizado"]) : null;
                    this.Dcm_credito_disponible = pDataReader["d_credito_disponible"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_credito_disponible"]) : null;
                    break;
                case 3:
                    this.ID = pDataReader["id_cliente"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_cliente"].ToString()) : null;
                    this.oBE_Tipo_Documento.ID = pDataReader["id_tipo_documento"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_tipo_documento"].ToString()) : null;
                    this.Str_num_documento = pDataReader["v_num_documento"] != DBNull.Value ? pDataReader["v_num_documento"].ToString() : null;
                    this.Str_nom_cliente = pDataReader["v_nom_cliente"] != DBNull.Value ? pDataReader["v_nom_cliente"].ToString() : null;
                    this.Str_direccion_cliente = pDataReader["v_direccion_cliente"] != DBNull.Value ? pDataReader["v_direccion_cliente"].ToString() : null;
                    this.oBE_Departamento.ID = pDataReader["id_departamento"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_departamento"].ToString()) : null;
                    this.oBE_Provincia.ID = pDataReader["id_provincia"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_provincia"].ToString()) : null;
                    this.oBE_Distrito.ID = pDataReader["id_distrito"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_distrito"].ToString()) : null;
                    this.Str_v_ubigeo = pDataReader["v_ubigeo"] != DBNull.Value ? pDataReader["v_ubigeo"].ToString() : null;
                    this.Int_chk_promo_vigentes = pDataReader["i_chk_promo_vigentes"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["i_chk_promo_vigentes"].ToString()) : null;
                    this.Int_chk_aceptar_vtas_credito = pDataReader["i_chk_aceptar_vtas_credito"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["i_chk_aceptar_vtas_credito"].ToString()) : null;
                    this.Dcm_linea_credito = pDataReader["d_linea_credito"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_linea_credito"]) : null;
                    this.Dcm_credito_utilizado = pDataReader["d_credito_utilizado"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_credito_utilizado"]) : null;
                    this.Dcm_credito_disponible = pDataReader["d_credito_disponible"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_credito_disponible"]) : null;
                    break;
            }
        }
    }
}
