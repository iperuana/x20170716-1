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
    public partial class DA_Lados_Caras:DA_Base
    {
        #region "Listado"
        public static List<BE_Lados_Caras> Listar_Lados_Caras(BE_Lados_Caras pBE_Lados_Caras)
        {
            IDataReader DataReader = null;
            List<BE_Lados_Caras> oBE_Lados_Caras = new List<BE_Lados_Caras>();
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_LADOS");
                db.AddInParameter(cmd, "@texto_buscar", DbType.String, pBE_Lados_Caras.Str_texto_buscar);
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                using (DataReader = db.ExecuteReader(cmd))
                {
                    while (DataReader.Read())
                    {
                        oBE_Lados_Caras.Add(new BE_Lados_Caras(DataReader, 1));
                    }
                }
                return oBE_Lados_Caras;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }
        public static List<BE_Lados_Caras> Listar_Lados_Caras_x_ID(BE_Lados_Caras pBE_Lados_Caras)
        {
            IDataReader DataReader = null;
            List<BE_Lados_Caras> oBE_Lados_Caras = new List<BE_Lados_Caras>();
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_LADOS_X_ID");
                db.AddInParameter(cmd, "@ID", DbType.String, pBE_Lados_Caras.ID);
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                using (DataReader = db.ExecuteReader(cmd))
                {
                    while (DataReader.Read())
                    {
                        oBE_Lados_Caras.Add(new BE_Lados_Caras(DataReader, 2));
                    }
                }
                return oBE_Lados_Caras;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }
        #endregion
        #region"Mantenimiento"
        public static int Registrar_Lados_Caras(BE_Lados_Caras pBE_Lados_Caras)
        {
            int intIDInsercion = 0;
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_INS_LADOS");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                db.AddOutParameter(cmd, "@id_lados", DbType.Int32, 0);
                db.AddInParameter(cmd, "@v_cod_lados", DbType.String, pBE_Lados_Caras.Str_cod_lados);
                db.AddInParameter(cmd, "@v_denominacion_lados", DbType.String, pBE_Lados_Caras.Str_denominacion_lados);
                db.AddInParameter(cmd, "@id_usuario_creacion", DbType.Int32, pBE_Lados_Caras.IDUsuarioCreacion);
                db.ExecuteNonQuery(cmd);
                intIDInsercion = Convert.ToInt32(db.GetParameterValue(cmd, "@id_lados"));
                pBE_Lados_Caras.ID = intIDInsercion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intIDInsercion;
        }
        public static int Actualizar_Lados_Caras(BE_Lados_Caras pBE_Lados_Caras)
        {
            int intIDActualizacion = 0;
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_UPD_LADOS");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);

                db.AddInParameter(cmd, "@id_lados", DbType.Int32, pBE_Lados_Caras.ID);
                db.AddInParameter(cmd, "@v_cod_lados", DbType.String, pBE_Lados_Caras.Str_cod_lados);
                db.AddInParameter(cmd, "@v_denominacion_lados", DbType.String, pBE_Lados_Caras.Str_denominacion_lados);
                db.AddInParameter(cmd, "@id_usuario_modificacion", DbType.Int32, pBE_Lados_Caras.IDUsuarioModificacion);
                db.ExecuteNonQuery(cmd);
                intIDActualizacion = 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intIDActualizacion;
        }
        public static int ActualizarEstadoLadosCaras(BE_Lados_Caras pBE_Lados_Caras)
        {
            int intIDActualizacion = 0;
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_UPD_ESTADO_LADOS");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                db.AddInParameter(cmd, "@id_lados", DbType.Int32, pBE_Lados_Caras.ID);
                db.AddInParameter(cmd, "@id_usuario_modificacion", DbType.Int32, pBE_Lados_Caras.IDUsuarioModificacion);
                db.ExecuteNonQuery(cmd);
                intIDActualizacion = 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intIDActualizacion;
        }
        #endregion
    }
}

