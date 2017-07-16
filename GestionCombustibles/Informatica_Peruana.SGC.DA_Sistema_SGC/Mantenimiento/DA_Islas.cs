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
    public partial class DA_Islas:DA_Base
    {
        public static List<BE_Islas> Listar_Islas(BE_Islas pBE_Islas)
        {
            IDataReader DataReader = null;
            List<BE_Islas> oBE_Islas = new List<BE_Islas>();
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_ISLAS");
                db.AddInParameter(cmd, "@texto_buscar", DbType.String, pBE_Islas.Str_texto_buscar);
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                using (DataReader = db.ExecuteReader(cmd))
                {
                    while (DataReader.Read())
                    {
                        oBE_Islas.Add(new BE_Islas(DataReader, 1));
                    }
                }
                return oBE_Islas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }
        public static List<BE_Islas> Listar_Islas_x_ID(BE_Islas pBE_Islas)
        {
            IDataReader DataReader = null;
            List<BE_Islas> oBE_Islas = new List<BE_Islas>();
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_ISLAS_X_ID");
                db.AddInParameter(cmd, "@ID", DbType.String, pBE_Islas.ID);
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                using (DataReader = db.ExecuteReader(cmd))
                {
                    while (DataReader.Read())
                    {
                        oBE_Islas.Add(new BE_Islas(DataReader, 2));
                    }
                }
                return oBE_Islas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }
        public static int Registrar_Islas(BE_Islas pBE_Islas)
        {
            int intIDInsercion = 0;
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_INS_ISLAS");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                db.AddOutParameter(cmd, "@id_isla", DbType.Int32, 0);
                db.AddInParameter(cmd, "@v_cod_isla", DbType.String, pBE_Islas.Str_cod_isla);
                db.AddInParameter(cmd, "@v_denominacion_isla", DbType.String, pBE_Islas.Str_denominacion_isla);
                db.AddInParameter(cmd, "@id_usuario_creacion", DbType.Int32, pBE_Islas.IDUsuarioCreacion);
                db.ExecuteNonQuery(cmd);
                intIDInsercion = Convert.ToInt32(db.GetParameterValue(cmd, "@id_isla"));
                pBE_Islas.ID = intIDInsercion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intIDInsercion;
        }
        public static int Actualizar_Islas(BE_Islas pBE_Islas)
        {
            int intIDActualizacion = 0;
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_UPD_ISLAS");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                db.AddInParameter(cmd, "@id_isla", DbType.Int32, pBE_Islas.ID);
                db.AddInParameter(cmd, "@v_cod_isla", DbType.String, pBE_Islas.Str_cod_isla);
                db.AddInParameter(cmd, "@v_denominacion_isla", DbType.String, pBE_Islas.Str_denominacion_isla);
                db.AddInParameter(cmd, "@id_usuario_modificacion", DbType.Int32, pBE_Islas.IDUsuarioModificacion);
                db.ExecuteNonQuery(cmd);
                intIDActualizacion = 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intIDActualizacion;
        }

        public static int ActualizarEstadoIslas(BE_Islas pBE_Islas)
        {
            int intIDActualizacion = 0;
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_UPD_ESTADO_ISLAS");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                db.AddInParameter(cmd, "@id_isla", DbType.Int32, pBE_Islas.ID);
                db.AddInParameter(cmd, "@id_usuario_modificacion", DbType.Int32, pBE_Islas.IDUsuarioModificacion);
                db.ExecuteNonQuery(cmd);
                intIDActualizacion = 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intIDActualizacion;
        }
    }
}
