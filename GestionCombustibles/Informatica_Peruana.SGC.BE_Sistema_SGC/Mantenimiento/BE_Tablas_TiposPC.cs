using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento
{
    public partial class BE_Tablas_Tipos
    {
        public string Str_texto_buscar { get; set; }
        public BE_Tablas_Tipos()
        {

        }

        public BE_Tablas_Tipos(IDataReader pDataReader, int pIntTipo)
        {
            switch (pIntTipo)
            {
                case 1:

                    this.ID = pDataReader["id_tabla_tipo"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_tabla_tipo"].ToString()) : null;
                    this.Str_cod_tabla_tipo = pDataReader["v_cod_tabla_tipo"] != DBNull.Value ? pDataReader["v_cod_tabla_tipo"].ToString() : null;
                    this.Str_item_tabla_tipo = pDataReader["v_item_tabla_tipo"] != DBNull.Value ? pDataReader["v_item_tabla_tipo"].ToString() : null;
                    this.Str_denominacion_tabla_tipo = pDataReader["v_denominacion_tabla_tipo"] != DBNull.Value ? pDataReader["v_denominacion_tabla_tipo"].ToString() : null;
                    break;
                case 2:
                    this.ID = pDataReader["id_tabla_tipo"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_tabla_tipo"].ToString()) : null;
                    this.Str_cod_tabla_tipo = pDataReader["v_cod_tabla_tipo"] != DBNull.Value ? pDataReader["v_cod_tabla_tipo"].ToString() : null;
                    this.Str_item_tabla_tipo = pDataReader["v_item_tabla_tipo"] != DBNull.Value ? pDataReader["v_item_tabla_tipo"].ToString() : null;
                    this.Str_denominacion_tabla_tipo = pDataReader["v_denominacion_tabla_tipo"] != DBNull.Value ? pDataReader["v_denominacion_tabla_tipo"].ToString() : null;
                    break;
            }
        }
    }
}
