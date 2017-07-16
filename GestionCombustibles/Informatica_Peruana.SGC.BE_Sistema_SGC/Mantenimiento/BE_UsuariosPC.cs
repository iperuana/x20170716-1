using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento
{
    public partial class BE_Usuarios
    {
        public BE_Tipo_Perfil oBE_Tipo_Perfil { get; set; }

        public string Str_texto_buscar { get; set; }
        public string Str_Tipo_perfil { get; set; }
        public string Str_Nueva_Clave { get; set; }
        public BE_Usuarios()
        {
            oBE_Tipo_Perfil = new BE_Tipo_Perfil();
        }
        public BE_Usuarios(IDataReader pDataReader, int pIntTipo)
        {
            oBE_Tipo_Perfil = new BE_Tipo_Perfil();
            switch (pIntTipo)
            {
                case 1:
                    this.ID = pDataReader["id_usuario"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_usuario"].ToString()) : null;
                    this.Str_Nom_Usuario = pDataReader["v_nom_usuario"] != DBNull.Value ? pDataReader["v_nom_usuario"].ToString() : null;
                    this.Str_Usuario = pDataReader["v_usuario"] != DBNull.Value ? pDataReader["v_usuario"].ToString() : null;
                    this.Str_Clave_Usuario = pDataReader["v_clave_usuario"] != DBNull.Value ? pDataReader["v_clave_usuario"].ToString() : null;                    
                    break;
                case 2:
                    this.ID = pDataReader["id_usuario"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_usuario"].ToString()) : null;
                    this.Str_Nom_Usuario = pDataReader["v_nom_usuario"] != DBNull.Value ? pDataReader["v_nom_usuario"].ToString() : null;
                    this.Str_Usuario = pDataReader["v_usuario"] != DBNull.Value ? pDataReader["v_usuario"].ToString() : null;   
                    break;
                case 3:
                    this.ID = pDataReader["id_usuario"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_usuario"].ToString()) : null;
                    this.Str_Nom_Usuario = pDataReader["v_nom_usuario"] != DBNull.Value ? pDataReader["v_nom_usuario"].ToString() : null;
                    this.Str_Usuario = pDataReader["v_usuario"] != DBNull.Value ? pDataReader["v_usuario"].ToString() : null;
                    this.Str_Clave_Usuario = pDataReader["v_clave_usuario"] != DBNull.Value ? pDataReader["v_clave_usuario"].ToString() : null;
                    this.oBE_Tipo_Perfil.ID = pDataReader["id_tipo_perfil"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_tipo_perfil"].ToString()) : null;
                    this.oBE_Tipo_Perfil.Str_Tipo_Perfil = pDataReader["Tipo_perfil"] != DBNull.Value ? pDataReader["Tipo_perfil"].ToString() : null;
                    break;
            }
        }
    }
}
