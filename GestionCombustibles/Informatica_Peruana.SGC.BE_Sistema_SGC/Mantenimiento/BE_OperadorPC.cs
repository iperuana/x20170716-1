using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento
{
    public partial class BE_Operador
    {
        public string Str_texto_buscar { get; set; }

        public BE_Operador()
        {
        }

        public BE_Operador(IDataReader pDataReader, int pIntTipo)
        {
            switch (pIntTipo)
            {
                case 1:
                    this.ID = pDataReader["id_operador"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_operador"].ToString()) : null;
                    this.Str_Cod_Operador = pDataReader["v_cod_operador"] != DBNull.Value ? pDataReader["v_cod_operador"].ToString() : null;
                    this.Str_Nombre_Operador = pDataReader["v_nombre_operador"] != DBNull.Value ? pDataReader["v_nombre_operador"].ToString() : null;
                    this.Str_ApePaterno_Operador = pDataReader["v_apepaterno_operador"] != DBNull.Value ? pDataReader["v_apepaterno_operador"].ToString() : null;
                    this.Str_ApeMaterno_Operador = pDataReader["v_apematerno_operador"] != DBNull.Value ? pDataReader["v_apematerno_operador"].ToString() : null;
                    this.ID_Nivel = pDataReader["id_nivel"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_nivel"].ToString()) : null;
                    this.Str_Usuario_Operador = pDataReader["v_usuario_operador"] != DBNull.Value ? pDataReader["v_usuario_operador"].ToString() : null;
                    this.Str_Clave_Operador = pDataReader["v_clave_operador"] != DBNull.Value ? pDataReader["v_clave_operador"].ToString() : null;
                    
                    break;
                case 2:
                    this.ID = pDataReader["id_operador"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_operador"].ToString()) : null;
                    this.Str_Cod_Operador = pDataReader["v_cod_operador"] != DBNull.Value ? pDataReader["v_cod_operador"].ToString() : null;
                    this.Str_Nombre_Operador = pDataReader["v_nombre_operador"] != DBNull.Value ? pDataReader["v_nombre_operador"].ToString() : null;
                    this.Str_ApePaterno_Operador = pDataReader["v_apepaterno_operador"] != DBNull.Value ? pDataReader["v_apepaterno_operador"].ToString() : null;
                    this.Str_ApeMaterno_Operador = pDataReader["v_apematerno_operador"] != DBNull.Value ? pDataReader["v_apematerno_operador"].ToString() : null;
                    this.ID_Nivel = pDataReader["id_nivel"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_nivel"].ToString()) : null;
                    this.Str_Usuario_Operador = pDataReader["v_usuario_operador"] != DBNull.Value ? pDataReader["v_usuario_operador"].ToString() : null;
                    this.Str_Clave_Operador = pDataReader["v_clave_operador"] != DBNull.Value ? pDataReader["v_clave_operador"].ToString() : null;

                    break;
            }
        }
    }
}
