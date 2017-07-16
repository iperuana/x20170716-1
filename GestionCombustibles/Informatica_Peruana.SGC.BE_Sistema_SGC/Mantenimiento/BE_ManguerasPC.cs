using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento
{
    public partial class BE_Mangueras
    {
        public string Str_texto_buscar { get; set; }

        public BE_Mangueras()
        {

        }

        public BE_Mangueras(IDataReader pDataReader, int pIntTipo)
        {
            switch (pIntTipo)
            {
                case 1:
                    this.ID = pDataReader["id_manguera"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_manguera"].ToString()) : null;
                    this.Str_cod_mangueras = pDataReader["v_cod_manguera"] != DBNull.Value ? pDataReader["v_cod_manguera"].ToString() : null;
                    this.Str_denominacion_mangueras = pDataReader["v_denominacion_manguera"] != DBNull.Value ? pDataReader["v_denominacion_manguera"].ToString() : null;
                    break;

                case 2:
                    this.ID = pDataReader["id_manguera"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_manguera"].ToString()) : null;
                    this.Str_cod_mangueras = pDataReader["v_cod_manguera"] != DBNull.Value ? pDataReader["v_cod_manguera"].ToString() : null;
                    this.Str_denominacion_mangueras = pDataReader["v_denominacion_manguera"] != DBNull.Value ? pDataReader["v_denominacion_manguera"].ToString() : null;
                    break;
            }
        }
    }
}
