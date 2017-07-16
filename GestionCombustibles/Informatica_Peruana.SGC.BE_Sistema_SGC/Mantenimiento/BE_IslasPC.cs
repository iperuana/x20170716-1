using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento
{
   public partial class BE_Islas
    {
        public string Str_texto_buscar { get; set; }
          public BE_Islas()
           {

          }
        public BE_Islas(IDataReader pDataReader, int pIntTipo)
        {
            switch (pIntTipo)
            {
                case 1:

                    this.ID = pDataReader["id_isla"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_isla"].ToString()) : null;
                    this.Str_cod_isla = pDataReader["v_cod_isla"] != DBNull.Value ? pDataReader["v_cod_isla"].ToString() : null;
                    this.Str_denominacion_isla = pDataReader["v_denominacion_isla"] != DBNull.Value ? pDataReader["v_denominacion_isla"].ToString() : null;
                    break;
                case 2:
                    this.ID = pDataReader["id_isla"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_isla"].ToString()) : null;
                    this.Str_cod_isla = pDataReader["v_cod_isla"] != DBNull.Value ? pDataReader["v_cod_isla"].ToString() : null;
                    this.Str_denominacion_isla = pDataReader["v_denominacion_isla"] != DBNull.Value ? pDataReader["v_denominacion_isla"].ToString() : null;
                    break;
            }
        }

    }
}
