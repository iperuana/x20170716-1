using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento
{
    public partial class BE_Tipo_Documento
    {
        public BE_Tipo_Documento()
        {

        }
        public BE_Tipo_Documento(IDataReader pDataReader, int pIntTipo)
        {
            switch (pIntTipo)
            {
                case 1:
                    this.ID = pDataReader["id_tipo_documento"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_tipo_documento"].ToString()) : null;
                    this.Str_desc_tipo_documento = pDataReader["v_desc_tipo_documento"] != DBNull.Value ? pDataReader["v_desc_tipo_documento"].ToString() : null;
                    this.Str_abrev_tipo_documento = pDataReader["v_abrev_tipo_documento"] != DBNull.Value ? pDataReader["v_abrev_tipo_documento"].ToString() : null;
                    break;
                case 2:
                    this.ID = pDataReader["id_tipo_documento"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_tipo_documento"].ToString()) : null;
                   // this.Str_desc_tipo_documento = pDataReader["v_desc_tipo_documento"] != DBNull.Value ? pDataReader["v_desc_tipo_documento"].ToString() : null;
                   this.Str_abrev_tipo_documento = pDataReader["v_abrev_tipo_documento"] != DBNull.Value ? pDataReader["v_abrev_tipo_documento"].ToString() : null;
                    break;
            }
        }
    }
}
