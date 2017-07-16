using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento
{
    public partial class BE_Operador_Usuario
    {
        public string Str_texto_buscar { get; set; }
        public BE_Nivel oBE_Nivel { get; set; }
        public string Str_Nivel { get; set; }

        public BE_Operador_Usuario()
        {
            oBE_Nivel = new BE_Nivel();
         }
        public BE_Operador_Usuario(IDataReader pDataReader, int pIntTipo)
        {
            oBE_Nivel = new BE_Nivel();
            switch (pIntTipo)
            {
                case 1:
                    this.ID = pDataReader["id_operador_usuario"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_operador_usuario"].ToString()) : null;
                    this.Str_Cod_Operador_Usuario = pDataReader["v_cod_operador_usuario"] != DBNull.Value ? pDataReader["v_cod_operador_usuario"].ToString() : null;
                    this.Str_Nombre_Operador_Usuario = pDataReader["v_nombre_operador_usuario"] != DBNull.Value ? pDataReader["v_nombre_operador_usuario"].ToString() : null;
                    this.Str_Nivel = pDataReader["v_desc_nivel"] != DBNull.Value ? pDataReader["v_desc_nivel"].ToString() : null;
                    break;

                case 2:
                    this.ID = pDataReader["id_operador_usuario"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_operador_usuario"].ToString()) : null;
                    this.Str_Cod_Operador_Usuario = pDataReader["v_cod_operador_usuario"] != DBNull.Value ? pDataReader["v_cod_operador_usuario"].ToString() : null;
                    this.Str_Nombre_Operador_Usuario = pDataReader["v_nombre_operador_usuario"] != DBNull.Value ? pDataReader["v_nombre_operador_usuario"].ToString() : null;
                    this.oBE_Nivel.ID = pDataReader["id_nivel"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_nivel"].ToString()) : null;
                    this.oBE_Nivel.Str_Desc_Nivel = pDataReader["v_desc_nivel"] != DBNull.Value ? pDataReader["v_desc_nivel"].ToString() : null;
                    break;
            }
        }
    }
}
