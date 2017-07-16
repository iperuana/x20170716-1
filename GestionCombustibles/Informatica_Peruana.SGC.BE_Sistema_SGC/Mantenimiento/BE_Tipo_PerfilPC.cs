using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento
{
    public partial class BE_Tipo_Perfil
    {
        public BE_Tipo_Perfil()
        {

        }
        public BE_Tipo_Perfil(IDataReader pDataReader, int pIntTipo)
        {
            switch (pIntTipo)
            {
                case 1:
                    this.ID = pDataReader["id_tipo_perfil"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_tipo_perfil"].ToString()) : null;
                    this.Str_Tipo_Perfil = pDataReader["Tipo_perfil"] != DBNull.Value ? pDataReader["Tipo_perfil"].ToString() : null;
                    break;
                case 2:
                    this.ID = pDataReader["id_tipo_perfil"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_tipo_perfil"].ToString()) : null;
                    this.Str_Tipo_Perfil = pDataReader["Tipo_perfil"] != DBNull.Value ? pDataReader["Tipo_perfil"].ToString() : null;
                    break;
            }

        }

    }
}
