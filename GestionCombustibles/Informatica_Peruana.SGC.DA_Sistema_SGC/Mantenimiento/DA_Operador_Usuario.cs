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
   public partial class DA_Operador_Usuario:DA_Base
    {
        #region "Listado"

        public static List<BE_Operador_Usuario> Listar_Operador_Usuario(BE_Operador_Usuario pBE_Operador_Usuario)
        {
            IDataReader DataReader = null;
            List<BE_Operador_Usuario> oBE_Operador_Usuario = new List<BE_Operador_Usuario>();
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_OPERADOR_USUARIOS");
                db.AddInParameter(cmd, "@texto_buscar", DbType.String, pBE_Operador_Usuario.Str_texto_buscar);
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                using (DataReader = db.ExecuteReader(cmd))
                {
                    while (DataReader.Read())
                    {
                        oBE_Operador_Usuario.Add(new BE_Operador_Usuario(DataReader, 1));
                    }
                }
                return oBE_Operador_Usuario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }
        public static List<BE_Operador_Usuario> Listar_Operador_Usuario_x_ID(BE_Operador_Usuario pBE_Operador_Usuario)
        {
            IDataReader DataReader = null;
            List<BE_Operador_Usuario> oBE_Operador_Usuario = new List<BE_Operador_Usuario>();
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_OPERADOR_USUARIOS_X_ID");
                db.AddInParameter(cmd, "@ID", DbType.String, pBE_Operador_Usuario.ID);
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                using (DataReader = db.ExecuteReader(cmd))
                {
                    while (DataReader.Read())
                    {
                        oBE_Operador_Usuario.Add(new BE_Operador_Usuario(DataReader, 2));
                    }
                }
                return oBE_Operador_Usuario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }
        #endregion
        #region "Mantenimiento"
        public static int Registrar_Operador_Usuario(BE_Operador_Usuario pBE_Operador_Usuario)
        {
            int intIDInsercion = 0;
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_INS_OPERADOR_USUARIOS");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                db.AddOutParameter(cmd, "@id_operador_usuario", DbType.Int32, 0);
                db.AddInParameter(cmd, "@v_cod_operador_usuario", DbType.String, pBE_Operador_Usuario.Str_Cod_Operador_Usuario);
                db.AddInParameter(cmd, "@v_nombre_operador_usuario", DbType.String, pBE_Operador_Usuario.Str_Nombre_Operador_Usuario);
                db.AddInParameter(cmd, "@id_nivel", DbType.Int32, pBE_Operador_Usuario.oBE_Nivel.ID);
                db.AddInParameter(cmd, "@id_usuario_creacion", DbType.Int32, pBE_Operador_Usuario.IDUsuarioCreacion);
                db.ExecuteNonQuery(cmd);
                intIDInsercion = Convert.ToInt32(db.GetParameterValue(cmd, "@id_operador_usuario"));
                pBE_Operador_Usuario.ID = intIDInsercion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intIDInsercion;
        }
        public static int Actualizar_Operador_Usuario(BE_Operador_Usuario pBE_Operador_Usuario)
        {
            int intIDActualizacion = 0;
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_UPD_OPERADOR_USUARIOS");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);

                db.AddInParameter(cmd, "@id_operador_usuario", DbType.Int32, pBE_Operador_Usuario.ID);
                db.AddInParameter(cmd, "@v_cod_operador_usuario", DbType.String, pBE_Operador_Usuario.Str_Cod_Operador_Usuario);
                db.AddInParameter(cmd, "@v_nombre_operador_usuario", DbType.String, pBE_Operador_Usuario.Str_Nombre_Operador_Usuario);
                db.AddInParameter(cmd, "@id_nivel", DbType.String, pBE_Operador_Usuario.oBE_Nivel.ID);
                db.AddInParameter(cmd, "@id_usuario_modificacion", DbType.Int32, pBE_Operador_Usuario.IDUsuarioModificacion);

                db.ExecuteNonQuery(cmd);
                intIDActualizacion = 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intIDActualizacion;
        }
        public static int ActualizarEstadoOperador_Usuario(BE_Operador_Usuario pBE_Operador_Usuario)
        {
            int intIDActualizacion = 0;
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_UPD_ESTADO_OPERADOR_USUARIOS");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                db.AddInParameter(cmd, "@id_operador_usuario", DbType.Int32, pBE_Operador_Usuario.ID);
                db.AddInParameter(cmd, "@id_usuario_modificacion", DbType.Int32, pBE_Operador_Usuario.IDUsuarioModificacion);
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

   