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
    public partial class DA_Turnos:DA_Base
    {
        #region"listado"
        public static List<BE_Turnos> Listar_Turnos(BE_Turnos pBE_Turnos)
        {
            IDataReader DataReader = null;
            List<BE_Turnos> oBE_Turnos = new List<BE_Turnos>();
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_TURNOS");
                db.AddInParameter(cmd, "@v_hora_inicio", DbType.String, pBE_Turnos.Str_inicio_buscar);
                db.AddInParameter(cmd, "@v_hora_fin", DbType.String, pBE_Turnos.Str_fin_buscar);
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                using (DataReader = db.ExecuteReader(cmd))
                {
                    while (DataReader.Read())
                    {
                        oBE_Turnos.Add(new BE_Turnos(DataReader, 1));
                    }
                }
                return oBE_Turnos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }
        public static List<BE_Turnos> Listar_Turnos_x_ID(BE_Turnos pBE_Turnos)
        {
            IDataReader DataReader = null;
            List<BE_Turnos> oBE_Turnos = new List<BE_Turnos>();
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_TURNOS_X_ID");
                db.AddInParameter(cmd, "@ID", DbType.String, pBE_Turnos.ID);
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                using (DataReader = db.ExecuteReader(cmd))
                {
                    while (DataReader.Read())
                    {
                        oBE_Turnos.Add(new BE_Turnos(DataReader, 2));
                    }
                }
                return oBE_Turnos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }
        #endregion
        public static int Registrar_Turnos(BE_Turnos pBE_Turnos)
        {
            int intIDInsercion = 0;
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_INS_TURNO");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                db.AddOutParameter(cmd, "@id_turno", DbType.Int32, 0);
                db.AddInParameter(cmd, "@v_cod_turno", DbType.String, pBE_Turnos.Str_cod_turno);
                db.AddInParameter(cmd, "@v_denominacion_turno", DbType.String, pBE_Turnos.Str_denominacion_turno);
                db.AddInParameter(cmd, "@v_hora_inicio", DbType.String, pBE_Turnos.Str_hora_inicio);
                db.AddInParameter(cmd, "@v_hora_fin", DbType.String, pBE_Turnos.Str_hora_fin);
                db.AddInParameter(cmd, "@id_usuario_creacion", DbType.Int32, pBE_Turnos.IDUsuarioCreacion);
                db.ExecuteNonQuery(cmd);
                intIDInsercion = Convert.ToInt32(db.GetParameterValue(cmd, "@id_turno"));
                pBE_Turnos.ID = intIDInsercion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intIDInsercion;
        }
        public static int Actualizar_Turnos(BE_Turnos pBE_Turnos)
        {
            int intIDActualizacion = 0;
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_UPD_TURNO");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                db.AddInParameter(cmd, "@id_turno", DbType.Int32, pBE_Turnos.ID);
                db.AddInParameter(cmd, "@v_cod_turno", DbType.String, pBE_Turnos.Str_cod_turno);
                db.AddInParameter(cmd, "@v_denominacion_turno", DbType.String, pBE_Turnos.Str_denominacion_turno);
                db.AddInParameter(cmd, "@v_hora_inicio", DbType.String, pBE_Turnos.Str_hora_inicio);
                db.AddInParameter(cmd, "@v_hora_fin", DbType.String, pBE_Turnos.Str_hora_fin);
                db.AddInParameter(cmd, "@id_usuario_modificacion", DbType.Int32, pBE_Turnos.IDUsuarioModificacion);
                db.ExecuteNonQuery(cmd);
                intIDActualizacion = 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intIDActualizacion;
        }

        public static int ActualizarEstadoTurnos(BE_Turnos pBE_Turnos)
        {
            int intIDActualizacion = 0;
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_UPD_ESTADO_TURNO");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                db.AddInParameter(cmd, "@id_turno", DbType.Int32, pBE_Turnos.ID);
                db.AddInParameter(cmd, "@id_usuario_modificacion", DbType.Int32, pBE_Turnos.IDUsuarioModificacion);
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
