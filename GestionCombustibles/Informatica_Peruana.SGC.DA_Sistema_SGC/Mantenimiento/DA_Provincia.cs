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
    public partial class DA_Provincia :DA_Base
    {

        public static List<BE_Provincia> Listar_Provincia_Desp(BE_Provincia pBE_Provincia)
        {
            IDataReader DataReader = null;
            List<BE_Provincia> oBE_Provincia = new List<BE_Provincia>();
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_PROVINCIA_DESP");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                db.AddInParameter(cmd, "@id_departamento", DbType.Int32, pBE_Provincia.oBE_Departamento.ID);
                using (DataReader = db.ExecuteReader(cmd))
                {
                    while (DataReader.Read())
                    {
                        oBE_Provincia.Add(new BE_Provincia(DataReader, 3));
                    }
                }
                return oBE_Provincia;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }
    }
}
