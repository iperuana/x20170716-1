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
    public partial class DA_Operador : DA_Base
    {
        public static List<BE_Operador> Listar_Operador(BE_Operador pBE_Operador)
        {
            IDataReader DataReader = null;
            List<BE_Operador> oBE_Operador = new List<BE_Operador>();
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_OPERADOR");
                db.AddInParameter(cmd, "@texto_buscar", DbType.String, pBE_Operador.Str_texto_buscar);
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                using (DataReader = db.ExecuteReader(cmd))
                {
                    while (DataReader.Read())
                    {
                        oBE_Operador.Add(new BE_Operador(DataReader, 1));
                    }
                }
                return oBE_Operador;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }

        public static List<BE_Operador> Listar_Operador_x_ID(BE_Operador pBE_Operador)
        {
            IDataReader DataReader = null;
            List<BE_Operador> oBE_Operador = new List<BE_Operador>();
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_OPERADOR_X_ID");
                db.AddInParameter(cmd, "@ID", DbType.String, pBE_Operador.ID);
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                using (DataReader = db.ExecuteReader(cmd))
                {
                    while (DataReader.Read())
                    {
                        oBE_Operador.Add(new BE_Operador(DataReader, 2));
                    }
                }
                return oBE_Operador;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }

        public static List<BE_Operador> Listar_Operador_Logueo(BE_Operador pBE_Operador)
        {
            IDataReader DataReader = null;
            List<BE_Operador> oBE_Operador = new List<BE_Operador>();
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_OPERADOR_LOGUEO");
                db.AddInParameter(cmd, "@v_usuario_operador", DbType.String, pBE_Operador.Str_Usuario_Operador);
                db.AddInParameter(cmd, "@v_clave_operador", DbType.String, pBE_Operador.Str_Clave_Operador);

                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                using (DataReader = db.ExecuteReader(cmd))
                {
                    while (DataReader.Read())
                    {
                        oBE_Operador.Add(new BE_Operador(DataReader, 2));
                    }
                }
                return oBE_Operador;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }
    }
}
