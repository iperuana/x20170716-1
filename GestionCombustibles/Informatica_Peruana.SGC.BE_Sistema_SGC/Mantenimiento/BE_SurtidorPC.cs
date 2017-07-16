using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento
{
    public partial class BE_Surtidor
    {
        public string Str_texto_buscar { get; set; }

        public BE_Surtidor()
        {

        }
        public BE_Surtidor(IDataReader pDataReader, int pIntTipo)
        {
            switch (pIntTipo)
            {
                case 1:

                    this.ID = pDataReader["id_surtidor"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_surtidor"].ToString()) : null;
                    this.Str_cod_surtidor = pDataReader["v_cod_surtidor"] != DBNull.Value ? pDataReader["v_cod_surtidor"].ToString() : null;
                    this.Str_denominacion_surtidor = pDataReader["v_denominacion_surtidor"] != DBNull.Value ? pDataReader["v_denominacion_surtidor"].ToString() : null;
                    break;
                case 2:
                    this.ID = pDataReader["id_surtidor"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_surtidor"].ToString()) : null;
                    this.Str_cod_surtidor = pDataReader["v_cod_surtidor"] != DBNull.Value ? pDataReader["v_cod_surtidor"].ToString() : null;
                    this.Str_denominacion_surtidor = pDataReader["v_denominacion_surtidor"] != DBNull.Value ? pDataReader["v_denominacion_surtidor"].ToString() : null;
                    break;
            }
        }

    }
}
