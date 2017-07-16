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
    public partial class DA_Distrito : DA_Base
    {
        public static List<BE_Distrito> Listar_Distrito_Desp(BE_Distrito pBE_Distrito)
        {
            IDataReader DataReader = null;
            List<BE_Distrito> oBE_Distrito = new List<BE_Distrito>();
            try
                {
                    SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_DISTRITO_DESP");
                    cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                    db.AddInParameter(cmd, "@id_provincia", DbType.Int32, pBE_Distrito.oBE_Provincia.ID);
                    using (DataReader = db.ExecuteReader(cmd))
                    {
                        while (DataReader.Read())
                        {
                            oBE_Distrito.Add(new BE_Distrito(DataReader, 2));
                        }
                    }
                    return oBE_Distrito;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }

    }
}
