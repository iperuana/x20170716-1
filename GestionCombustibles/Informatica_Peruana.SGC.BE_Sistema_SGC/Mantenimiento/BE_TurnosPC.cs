using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento
{
    public partial class BE_Turnos
    {
        public string Str_inicio_buscar { get; set; }
        public string Str_fin_buscar { get; set; }
        public BE_Turnos()
        {

        }
        public BE_Turnos(IDataReader pDataReader, int pIntTipo)
        {
            switch (pIntTipo)
            {
                case 1:
                    this.ID = pDataReader["id_turno"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_turno"].ToString()) : null;
                    this.Str_cod_turno = pDataReader["v_cod_turno"] != DBNull.Value ? pDataReader["v_cod_turno"].ToString() : null;
                    this.Str_denominacion_turno = pDataReader["v_denominacion_turno"] != DBNull.Value ? pDataReader["v_denominacion_turno"].ToString() : null;
                    this.Str_hora_inicio = pDataReader["v_hora_inicio"] != DBNull.Value ? pDataReader["v_hora_inicio"].ToString() : null;
                    this.Str_hora_fin = pDataReader["v_hora_fin"] != DBNull.Value ? pDataReader["v_hora_fin"].ToString() : null;
                    break;

                case 2:
                    this.ID = pDataReader["id_turno"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_turno"].ToString()) : null;
                    this.Str_cod_turno = pDataReader["v_cod_turno"] != DBNull.Value ? pDataReader["v_cod_turno"].ToString() : null;
                    this.Str_denominacion_turno = pDataReader["v_denominacion_turno"] != DBNull.Value ? pDataReader["v_denominacion_turno"].ToString() : null;
                    this.Str_hora_inicio = pDataReader["v_hora_inicio"] != DBNull.Value ? pDataReader["v_hora_inicio"].ToString() : null;
                    this.Str_hora_fin = pDataReader["v_hora_fin"] != DBNull.Value ? pDataReader["v_hora_fin"].ToString() : null;
                    break;
            }
        }
    }
}
