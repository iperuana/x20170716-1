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
    public partial class DA_Surtidor:DA_Base
    {
        public static List<BE_Surtidor> Listar_Surtidor(BE_Surtidor pBE_surtidor)
        {
            IDataReader DataReader = null;
            List<BE_Surtidor> oBE_Surtidor = new List<BE_Surtidor>();
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_SURTIDORES");
                db.AddInParameter(cmd, "@texto_buscar", DbType.String, pBE_surtidor.Str_texto_buscar);
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                using (DataReader = db.ExecuteReader(cmd))
                {
                    while (DataReader.Read())
                    {
                        oBE_Surtidor.Add(new BE_Surtidor(DataReader, 1));
                    }
                }
                return oBE_Surtidor;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }

        public static List<BE_Surtidor> Listar_Surtidor_x_ID(BE_Surtidor pBE_surtidor)
        {
            IDataReader DataReader = null;
            List<BE_Surtidor> oBE_Surtidor = new List<BE_Surtidor>();
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_SURTIDOR_X_ID");
                db.AddInParameter(cmd, "@ID", DbType.String, pBE_surtidor.ID);
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                using (DataReader = db.ExecuteReader(cmd))
                {
                    while (DataReader.Read())
                    {
                        oBE_Surtidor.Add(new BE_Surtidor(DataReader, 2));
                    }
                }
                return oBE_Surtidor;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }
        public static int Registrar_Surtidor(BE_Surtidor pBE_surtidor)
        {
            int intIDInsercion = 0;
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_INS_SURTIDOR");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                db.AddOutParameter(cmd, "@id_surtidor", DbType.Int32, 0);
                db.AddInParameter(cmd, "@v_cod_surtidor", DbType.String, pBE_surtidor.Str_cod_surtidor);
                db.AddInParameter(cmd, "@v_denominacion_surtidor", DbType.String, pBE_surtidor.Str_denominacion_surtidor);
                db.AddInParameter(cmd, "@id_usuario_creacion", DbType.Int32, pBE_surtidor.IDUsuarioCreacion);
                db.ExecuteNonQuery(cmd);
                intIDInsercion = Convert.ToInt32(db.GetParameterValue(cmd, "@id_surtidor"));
                pBE_surtidor.ID = intIDInsercion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intIDInsercion;
        }
        public static int Actualizar_Surtidor(BE_Surtidor pBE_surtidor)
        {
            int intIDActualizacion = 0;
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_UPD_SURTIDOR");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                db.AddInParameter(cmd, "@id_surtidor", DbType.Int32, pBE_surtidor.ID);
                db.AddInParameter(cmd, "@v_cod_surtidor", DbType.String, pBE_surtidor.Str_cod_surtidor);
                db.AddInParameter(cmd, "@v_denominacion_surtidor", DbType.String, pBE_surtidor.Str_denominacion_surtidor);
                db.AddInParameter(cmd, "@id_usuario_modificacion", DbType.Int32, pBE_surtidor.IDUsuarioModificacion);
                db.ExecuteNonQuery(cmd);
                intIDActualizacion = 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intIDActualizacion;
        }
        public static int ActualizarEstadoSurtidor(BE_Surtidor pBE_surtidor)
        {
            int intIDActualizacion = 0;
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_UPD_ESTADO_SURTIDOR");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                db.AddInParameter(cmd, "@id_surtidor", DbType.Int32, pBE_surtidor.ID);
                db.AddInParameter(cmd, "@id_usuario_modificacion", DbType.Int32, pBE_surtidor.IDUsuarioModificacion);
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
