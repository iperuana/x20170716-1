using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento
{
    public partial class BE_Lados_Caras
    {
        public string Str_texto_buscar { get; set; }

        public BE_Lados_Caras()
        {

        }
        public BE_Lados_Caras(IDataReader pDataReader, int pIntTipo)
        {
            switch (pIntTipo)
            {
                case 1:
                    this.ID = pDataReader["id_lados"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_lados"].ToString()) : null;
                    this.Str_cod_lados = pDataReader["v_cod_lados"] != DBNull.Value ? pDataReader["v_cod_lados"].ToString() : null;
                    this.Str_denominacion_lados = pDataReader["v_denominacion_lados"] != DBNull.Value ? pDataReader["v_denominacion_lados"].ToString() : null;
                    break;

                case 2:
                    this.ID = pDataReader["id_lados"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_lados"].ToString()) : null;
                    this.Str_cod_lados = pDataReader["v_cod_lados"] != DBNull.Value ? pDataReader["v_cod_lados"].ToString() : null;
                    this.Str_denominacion_lados = pDataReader["v_denominacion_lados"] != DBNull.Value ? pDataReader["v_denominacion_lados"].ToString() : null;
                    break;
            }
        }
    }
}
