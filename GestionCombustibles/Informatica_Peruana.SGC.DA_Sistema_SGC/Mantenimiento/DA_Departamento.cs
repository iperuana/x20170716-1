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
    public class DA_Departamento : DA_Base
    {
        public static List<BE_Departamento> Listar_Departamento_Desp(BE_Departamento pBE_Departamento)
        {
            IDataReader DataReader = null;
            List<BE_Departamento> oBE_Departamento = new List<BE_Departamento>();
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_DEPARTAMENTO_DESP");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                using (DataReader = db.ExecuteReader(cmd))
                {
                    while (DataReader.Read())
                    {
                        oBE_Departamento.Add(new BE_Departamento(DataReader, 1));
                    }
                }
                return oBE_Departamento;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }

    }
}
