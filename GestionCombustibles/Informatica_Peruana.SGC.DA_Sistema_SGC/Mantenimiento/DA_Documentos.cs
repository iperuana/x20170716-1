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
    public class DA_Documentos: DA_Base
    {
        #region "Listados"
        public static List<BE_Documentos> Listar_Documentos(BE_Documentos pBE_Documentos)
        {
            IDataReader DataReader = null;
            List<BE_Documentos> oBE_Documentos = new List<BE_Documentos>();
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_DOCUMENTOS");
                db.AddInParameter(cmd, "@texto_buscar", DbType.String, pBE_Documentos.Str_texto_buscar);
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                using (DataReader = db.ExecuteReader(cmd))
                {
                    while (DataReader.Read())
                    {
                        oBE_Documentos.Add(new BE_Documentos(DataReader, 1));
                    }
                }
                return oBE_Documentos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }

        #endregion
        public static List<BE_Documentos> Listar_Documentos_x_ID(BE_Documentos pBE_Documentos)
        {
            IDataReader DataReader = null;
            List<BE_Documentos> oBE_Documentos = new List<BE_Documentos>();
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_DOCUMENTOS_X_ID");
                db.AddInParameter(cmd, "@ID", DbType.String, pBE_Documentos.ID);
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                using (DataReader = db.ExecuteReader(cmd))
                {
                    while (DataReader.Read())
                    {
                        oBE_Documentos.Add(new BE_Documentos(DataReader, 2));
                    }
                }
                return oBE_Documentos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }

        public static int Registrar_Documentos(BE_Documentos pBE_Documentos)
        {
            int intIDInsercion = 0;
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_INS_DOCUMENTOS");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                db.AddOutParameter(cmd, "@id_documento", DbType.Int32, 0);
                db.AddInParameter(cmd, "@v_cod_documento", DbType.String, pBE_Documentos.Str_cod_documento);
                db.AddInParameter(cmd, "@v_deno_documento", DbType.String, pBE_Documentos.Str_deno_documento);
                db.AddInParameter(cmd, "@v_serie_documento", DbType.String, pBE_Documentos.Str_serie_documento);
                db.AddInParameter(cmd, "@v_num_documento", DbType.String, pBE_Documentos.Str_num_documento);
                db.AddInParameter(cmd, "@id_usuario_creacion", DbType.Int32, pBE_Documentos.IDUsuarioCreacion);
                db.ExecuteNonQuery(cmd);
                intIDInsercion = Convert.ToInt32(db.GetParameterValue(cmd, "@id_documento"));
                pBE_Documentos.ID = intIDInsercion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intIDInsercion;
        }

        public static int Actualizar_Documentos(BE_Documentos pBE_Documentos)
        {
            int intIDActualizacion = 0;
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_UPD_DOCUMENTOS");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                db.AddInParameter(cmd, "@id_documento", DbType.Int32, pBE_Documentos.ID);
                db.AddInParameter(cmd, "@v_cod_documento", DbType.String, pBE_Documentos.Str_cod_documento);
                db.AddInParameter(cmd, "@v_deno_documento", DbType.String, pBE_Documentos.Str_deno_documento);
                db.AddInParameter(cmd, "@v_serie_documento", DbType.String, pBE_Documentos.Str_serie_documento);
                db.AddInParameter(cmd, "@v_num_documento", DbType.String, pBE_Documentos.Str_num_documento);
                db.AddInParameter(cmd, "@id_usuario_modificacion", DbType.Int32, pBE_Documentos.IDUsuarioModificacion);

                db.ExecuteNonQuery(cmd);
                intIDActualizacion = 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intIDActualizacion;
        }
        public static int ActualizarEstadoDocumento(BE_Documentos pBE_Documentos)
        {
            int intIDActualizacion = 0;
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_UPD_ESTADO_DOCUMENTOS");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                db.AddInParameter(cmd, "@id_documento", DbType.Int32, pBE_Documentos.ID);
                db.AddInParameter(cmd, "@id_usuario_modificacion", DbType.Int32, pBE_Documentos.IDUsuarioModificacion);
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
