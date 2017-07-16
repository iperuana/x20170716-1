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
    public partial class DA_Mangueras : DA_Base
    {
        public static List<BE_Mangueras> Listar_Mangueras(BE_Mangueras pBE_Mangueras)
        {
            IDataReader DataReader = null;
            List<BE_Mangueras> oBE_Mangueras = new List<BE_Mangueras>();
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_MANGUERAS");
                db.AddInParameter(cmd, "@texto_buscar", DbType.String, pBE_Mangueras.Str_texto_buscar);
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                using (DataReader = db.ExecuteReader(cmd))
                {
                    while (DataReader.Read())
                    {
                        oBE_Mangueras.Add(new BE_Mangueras(DataReader, 1));
                    }
                }
                return oBE_Mangueras;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }

        public static List<BE_Mangueras> Listar_Mangueras_x_ID(BE_Mangueras pBE_Mangueras)
        {
            IDataReader DataReader = null;
            List<BE_Mangueras> oBE_Mangueras = new List<BE_Mangueras>();
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_MANGUERAS_X_ID");
                db.AddInParameter(cmd, "@ID", DbType.String, pBE_Mangueras.ID);
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                using (DataReader = db.ExecuteReader(cmd))
                {
                    while (DataReader.Read())
                    {
                        oBE_Mangueras.Add(new BE_Mangueras(DataReader, 2));
                    }
                }
                return oBE_Mangueras;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }
    }
}
