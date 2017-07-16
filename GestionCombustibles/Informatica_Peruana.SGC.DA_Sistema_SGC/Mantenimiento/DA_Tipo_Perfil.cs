using Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatica_Peruana.SGC.DA_Sistema_SGC.Mantenimiento
{
    public class DA_Tipo_Perfil:DA_Base
    {
        public static List<BE_Tipo_Perfil> Listar_Tipo_Perfil_Desp(BE_Tipo_Perfil pBE_Tipo_Perfil)
        {
            IDataReader DataReader = null;
            List<BE_Tipo_Perfil> oBE_Tipo_Perfil = new List<BE_Tipo_Perfil>();
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_TIPO_PERFIL_DESP");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                using (DataReader = db.ExecuteReader(cmd))
                {
                    while (DataReader.Read())
                    {
                        oBE_Tipo_Perfil.Add(new BE_Tipo_Perfil(DataReader, 1));
                    }
                }
                return oBE_Tipo_Perfil;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }
    }
}
