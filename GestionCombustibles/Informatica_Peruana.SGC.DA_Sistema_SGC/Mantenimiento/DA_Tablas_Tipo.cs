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
    public partial class DA_Tablas_Tipo : DA_Base
    {
        public static List<BE_Tablas_Tipos> Listar_Tablas_Tipo(BE_Tablas_Tipos pBE_Tablas_Tipos)
        {
            IDataReader DataReader = null;
            List<BE_Tablas_Tipos> oBE_Tablas_Tipos = new List<BE_Tablas_Tipos>();
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_TABLAS_TIPO");
                db.AddInParameter(cmd, "@texto_buscar", DbType.String, pBE_Tablas_Tipos.Str_texto_buscar);
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                using (DataReader = db.ExecuteReader(cmd))
                {
                    while (DataReader.Read())
                    {
                        oBE_Tablas_Tipos.Add(new BE_Tablas_Tipos(DataReader, 1));
                    }
                }
                return oBE_Tablas_Tipos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }

        public static List<BE_Tablas_Tipos> Listar_Tablas_Tipo_x_ID(BE_Tablas_Tipos pBE_Tablas_Tipo)
        {
            IDataReader DataReader = null;
            List<BE_Tablas_Tipos> oBE_Tablas_Tipo = new List<BE_Tablas_Tipos>();
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_TABLAS_TIPO_X_ID");
                db.AddInParameter(cmd, "@ID", DbType.String, pBE_Tablas_Tipo.ID);
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                using (DataReader = db.ExecuteReader(cmd))
                {
                    while (DataReader.Read())
                    {
                        oBE_Tablas_Tipo.Add(new BE_Tablas_Tipos(DataReader, 2));
                    }
                }
                return oBE_Tablas_Tipo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }
    }
}
