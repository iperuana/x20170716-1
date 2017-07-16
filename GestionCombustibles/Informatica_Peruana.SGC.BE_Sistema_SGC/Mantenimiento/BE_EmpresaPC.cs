using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento
{
    public partial class BE_Empresa
    {
        public string Str_texto_buscar { get; set; }
        public BE_Departamento oBE_Departamento { get; set; }
        public BE_Provincia oBE_Provincia { get; set; }
        public BE_Distrito oBE_Distrito { get; set; }
        public string Str_Nom_Departamento { get; set; }
        public string Str_Nom_Provincia { get; set; }
        public string Str_Nom_Distrito { get; set; }

        public BE_Empresa()
        {
            oBE_Departamento = new BE_Departamento();
            oBE_Provincia = new BE_Provincia();
            oBE_Distrito = new BE_Distrito();
        }
        public BE_Empresa(IDataReader pDataReader, int pIntTipo)
        {
            oBE_Departamento = new BE_Departamento();
            oBE_Provincia = new BE_Provincia();
            oBE_Distrito = new BE_Distrito();
            switch(pIntTipo)
            {
                case 1:
                    this.ID = pDataReader["id_empresa"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_empresa"].ToString()) : null;
                    this.Str_num_documento = pDataReader["v_num_documento"] != DBNull.Value ? pDataReader["v_num_documento"].ToString() : null;
                    this.Str_nom_empresa = pDataReader["v_nom_empresa"] != DBNull.Value ? pDataReader["v_nom_empresa"].ToString() : null;
                    this.Str_direccion_empresa = pDataReader["v_direccion_empresa"] != DBNull.Value ? pDataReader["v_direccion_empresa"].ToString() : null;
                    this.oBE_Departamento.Str_Departamento = pDataReader["v_desc_departamento"] != DBNull.Value ? pDataReader["v_desc_departamento"].ToString() : null;
                    this.Str_Nom_Departamento = pDataReader["v_desc_departamento"] != DBNull.Value ? pDataReader["v_desc_departamento"].ToString() : null;
                    this.oBE_Provincia.Str_Provincia = pDataReader["v_desc_provincia"] != DBNull.Value ? pDataReader["v_desc_provincia"].ToString() : null;
                    this.Str_Nom_Provincia = pDataReader["v_desc_provincia"] != DBNull.Value ? pDataReader["v_desc_provincia"].ToString() : null;
                    this.oBE_Distrito.Str_Distrito = pDataReader["v_desc_distrito"] != DBNull.Value ? pDataReader["v_desc_distrito"].ToString() : null;
                    this.Str_Nom_Distrito = pDataReader["v_desc_distrito"] != DBNull.Value ? pDataReader["v_desc_distrito"].ToString() : null;
                    this.Str_ubigeo = pDataReader["v_ubigeo"] != DBNull.Value ? pDataReader["v_ubigeo"].ToString() : null;
                    this.Str_texto = pDataReader["v_texto"] != DBNull.Value ? pDataReader["v_texto"].ToString() : null;
                    break;

                case 2:
                    this.ID = pDataReader["id_empresa"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_empresa"].ToString()) : null;
                    this.Str_num_documento = pDataReader["v_num_documento"] != DBNull.Value ? pDataReader["v_num_documento"].ToString() : null;
                    this.Str_nom_empresa = pDataReader["v_nom_empresa"] != DBNull.Value ? pDataReader["v_nom_empresa"].ToString() : null;
                    this.Str_direccion_empresa = pDataReader["v_direccion_empresa"] != DBNull.Value ? pDataReader["v_direccion_empresa"].ToString() : null;
                    this.oBE_Departamento.ID = pDataReader["id_departamento"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_departamento"].ToString()) : null;
                    this.oBE_Departamento.Str_Departamento = pDataReader["v_desc_departamento"] != DBNull.Value ? pDataReader["v_desc_departamento"].ToString() : null;
                    this.oBE_Provincia.ID = pDataReader["id_provincia"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_provincia"].ToString()) : null;
                    this.oBE_Provincia.Str_Provincia = pDataReader["v_desc_provincia"] != DBNull.Value ? pDataReader["v_desc_provincia"].ToString() : null;
                    this.oBE_Distrito.ID = pDataReader["id_distrito"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_distrito"].ToString()) : null;
                    this.oBE_Distrito.Str_Distrito = pDataReader["v_desc_distrito"] != DBNull.Value ? pDataReader["v_desc_distrito"].ToString() : null;
                    this.Str_ubigeo = pDataReader["v_ubigeo"] != DBNull.Value ? pDataReader["v_ubigeo"].ToString() : null;
                    this.Str_texto = pDataReader["v_texto"] != DBNull.Value ? pDataReader["v_texto"].ToString() : null;
                    break;

            }
        }

    }
}
