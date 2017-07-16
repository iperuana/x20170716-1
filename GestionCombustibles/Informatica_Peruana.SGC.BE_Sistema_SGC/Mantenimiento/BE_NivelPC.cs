using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento
{
  public partial class BE_Nivel
    {
        public BE_Nivel()
        {
         }
        public BE_Nivel(IDataReader pDataReader, int pIntTipo)
        {
            switch (pIntTipo)
            {
                case 1:
                    this.ID = pDataReader["id_nivel"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_nivel"].ToString()) : null;
                    this.Str_Desc_Nivel = pDataReader["v_desc_nivel"] != DBNull.Value ? pDataReader["v_desc_nivel"].ToString() : null;
                    break;

                case 2:
                    this.ID = pDataReader["id_nivel"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_nivel"].ToString()) : null;
                    this.Str_Desc_Nivel = pDataReader["v_desc_nivel"] != DBNull.Value ? pDataReader["v_desc_nivel"].ToString() : null;
                    break;
            }
        }
    }
}
