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
    public partial class DA_Empresa_CalcImp : DA_Base
    {
        public static List<BE_empresa_calcimp> Listar_Empresa_CalcImp(BE_empresa_calcimp pBE_Empresa_CalcImp)
        {
            IDataReader DataReader = null;
            List<BE_empresa_calcimp> oBE_Empresa_CalcImp = new List<BE_empresa_calcimp>();
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_EMPRESA_CALCIMP");
                db.AddInParameter(cmd, "@texto_buscar", DbType.String, pBE_Empresa_CalcImp.Str_texto_buscar);
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                using (DataReader = db.ExecuteReader(cmd))
                {
                    while (DataReader.Read())
                    {
                        oBE_Empresa_CalcImp.Add(new BE_empresa_calcimp(DataReader, 1));
                    }
                }
                return oBE_Empresa_CalcImp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }
        public static List<BE_empresa_calcimp> Listar_Empresas_CalcImp_x_ID(BE_empresa_calcimp pBE_Empresa_CalcImp)
        {
            IDataReader DataReader = null;
            List<BE_empresa_calcimp> oBE_Empresa_CalcImp = new List<BE_empresa_calcimp>();
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_EMPRESA_CALCIMP_X_ID");
                db.AddInParameter(cmd, "@ID_empresa", DbType.String, pBE_Empresa_CalcImp.ID);
                db.AddInParameter(cmd, "@ID_calcimp", DbType.String, pBE_Empresa_CalcImp.ID_CalcImp);
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                using (DataReader = db.ExecuteReader(cmd))
                {
                    while (DataReader.Read())
                    {
                        oBE_Empresa_CalcImp.Add(new BE_empresa_calcimp(DataReader, 1));
                    }
                }
                return oBE_Empresa_CalcImp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }
    }
}
