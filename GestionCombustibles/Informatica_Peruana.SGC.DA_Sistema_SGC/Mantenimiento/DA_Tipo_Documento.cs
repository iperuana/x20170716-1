using Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento;
using Informatica_Peruana.SGC.DA_Sistema_SGC;

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatica_Peruana.SGC.DA_Sistema_SGC.Mantenimiento
{
    public class DA_Tipo_Documento:DA_Base
    {
        #region "Listados"
        public static List<BE_Tipo_Documento> Listar_Tipo_Documento(BE_Tipo_Documento pBE_Tipo_Documento)
        {
            IDataReader DataReader = null;
            List<BE_Tipo_Documento> oBE_Tipo_Documento = new List<BE_Tipo_Documento>();
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_TIPO_DOCUMENTO_DESP");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                using (DataReader = db.ExecuteReader(cmd))
                {
                    while (DataReader.Read())
                    {
                        oBE_Tipo_Documento.Add(new BE_Tipo_Documento(DataReader, 2));
                    }
                }
                return oBE_Tipo_Documento;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }

        #endregion
    }
}
