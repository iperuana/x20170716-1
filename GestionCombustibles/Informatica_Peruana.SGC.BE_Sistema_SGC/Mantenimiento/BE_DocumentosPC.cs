using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento
{
    public partial class BE_Documentos
    {
        public string Str_texto_buscar { get; set; }
        public BE_Documentos()
        {

        }
        public BE_Documentos(IDataReader pDataReader, int pIntTipo)
        {
            switch (pIntTipo)
            {
                case 1:
                    this.ID = pDataReader["id_documento"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_documento"].ToString()) : null;
                    this.Str_cod_documento = pDataReader["v_cod_documento"] != DBNull.Value ? pDataReader["v_cod_documento"].ToString() : null;
                    this.Str_deno_documento = pDataReader["v_deno_documento"] != DBNull.Value ? pDataReader["v_deno_documento"].ToString() : null;
                    this.Str_serie_documento = pDataReader["v_serie_documento"] != DBNull.Value ? pDataReader["v_serie_documento"].ToString() : null;
                    this.Str_num_documento = pDataReader["v_num_documento"] != DBNull.Value ? pDataReader["v_num_documento"].ToString() : null;
                    break;
                case 2:
                    this.ID = pDataReader["id_documento"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_documento"].ToString()) : null;
                    this.Str_cod_documento = pDataReader["v_cod_documento"] != DBNull.Value ? pDataReader["v_cod_documento"].ToString() : null;
                    this.Str_deno_documento = pDataReader["v_deno_documento"] != DBNull.Value ? pDataReader["v_deno_documento"].ToString() : null;
                    this.Str_serie_documento = pDataReader["v_serie_documento"] != DBNull.Value ? pDataReader["v_serie_documento"].ToString() : null;
                    this.Str_num_documento = pDataReader["v_num_documento"] != DBNull.Value ? pDataReader["v_num_documento"].ToString() : null;
                    break;
            }
        }
    }
}
