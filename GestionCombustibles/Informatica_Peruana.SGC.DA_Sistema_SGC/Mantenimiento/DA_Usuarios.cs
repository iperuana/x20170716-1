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
    public partial class DA_Usuarios:DA_Base
    {
        #region"listado"
        public static List<BE_Usuarios> Loguear(BE_Usuarios pBE_Usuarios)
        {
            IDataReader DataReader = null;
            List<BE_Usuarios> oBE_Usuarios = new List<BE_Usuarios>();
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_USUARIO_LOGIN");
                db.AddInParameter(cmd, "@v_usuario", DbType.String, pBE_Usuarios.Str_Usuario);
                db.AddInParameter(cmd, "@v_clave_usuario", DbType.String, pBE_Usuarios.Str_Clave_Usuario);
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                using (DataReader = db.ExecuteReader(cmd))
                {
                    while (DataReader.Read())
                    {
                        oBE_Usuarios.Add(new BE_Usuarios(DataReader, 1));
                    }
                }
                return oBE_Usuarios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }
        public static List<BE_Usuarios> Listar_Usuarios(BE_Usuarios pBE_Usuarios)
        {
            IDataReader DataReader = null;
            List<BE_Usuarios> oBE_Usuarios = new List<BE_Usuarios>();
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_USUARIO");
                db.AddInParameter(cmd, "@texto_buscar", DbType.String, pBE_Usuarios.Str_texto_buscar);
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                using (DataReader = db.ExecuteReader(cmd))
                {
                    while (DataReader.Read())
                    {
                        oBE_Usuarios.Add(new BE_Usuarios(DataReader, 2));
                    }
                }
                return oBE_Usuarios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }
        public static List<BE_Usuarios> Listar_Usuarios_x_ID(BE_Usuarios pBE_Usuarios)
        {
            IDataReader DataReader = null;
            List<BE_Usuarios> oBE_Usuarios = new List<BE_Usuarios>();
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_USUARIO_X_ID");
                db.AddInParameter(cmd, "@id", DbType.String, pBE_Usuarios.ID);
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                using (DataReader = db.ExecuteReader(cmd))
                {
                    while (DataReader.Read())
                    {
                        oBE_Usuarios.Add(new BE_Usuarios(DataReader, 3));
                    }
                }
                return oBE_Usuarios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }

        #endregion   
        #region"Matenimiento"
        public static int Registrar_Usuarios(BE_Usuarios pBE_Usuarios)
        {
            int intIDInsercion = 0;
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_INS_USUARIO");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                db.AddOutParameter(cmd, "@id_usuario", DbType.Int32, 0);
                db.AddInParameter(cmd, "@v_nom_usuario", DbType.String, pBE_Usuarios.Str_Nom_Usuario);
                db.AddInParameter(cmd, "@v_usuario", DbType.String, pBE_Usuarios.Str_Usuario);
                db.AddInParameter(cmd, "@v_clave_usuario", DbType.String, pBE_Usuarios.Str_Clave_Usuario);
                db.AddInParameter(cmd, "@id_tipo_perfil", DbType.Int16, pBE_Usuarios.oBE_Tipo_Perfil.ID);
                db.ExecuteNonQuery(cmd);
                intIDInsercion = Convert.ToInt32(db.GetParameterValue(cmd, "@id_usuario"));
                pBE_Usuarios.ID = intIDInsercion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intIDInsercion;
        }
        public static int Actualizar_Usuarios(BE_Usuarios pBE_Usuarios)
        {
            int intIDActualizacion = 0;
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_UPD_USUARIO");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                db.AddInParameter(cmd, "@id_usuario", DbType.Int32, pBE_Usuarios.ID);
                db.AddInParameter(cmd, "@v_nom_usuario", DbType.String, pBE_Usuarios.Str_Nom_Usuario);
                db.AddInParameter(cmd, "@v_usuario", DbType.String, pBE_Usuarios.Str_Usuario);
                db.AddInParameter(cmd, "@v_clave_usuario", DbType.String, pBE_Usuarios.Str_Clave_Usuario);
                db.AddInParameter(cmd, "@id_tipo_perfil", DbType.Int16, pBE_Usuarios.oBE_Tipo_Perfil.ID);
                db.ExecuteNonQuery(cmd);
                intIDActualizacion = 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intIDActualizacion;
        }
        public static int ActualizarEstadoUsuarios(BE_Usuarios pBE_Usuarios)
        {
            int intIDActualizacion = 0;
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_UPD_ESTADO_USUARIO");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                db.AddInParameter(cmd, "@id_usuario", DbType.Int32, pBE_Usuarios.ID);
                db.ExecuteNonQuery(cmd);
                intIDActualizacion = 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intIDActualizacion;
        }
        public static int ActualizarClaveUsuarios(BE_Usuarios pBE_Usuarios)
        {
            int intIDActualizacion = 0;
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_UPD_USUARIO_CAMBIO_CLAVE");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                db.AddInParameter(cmd, "@id_usuario", DbType.Int32, pBE_Usuarios.ID);
                db.AddInParameter(cmd, "@v_clave_usuario", DbType.String,pBE_Usuarios.Str_Clave_Usuario);
                db.AddInParameter(cmd, "@v_nueva_usuario", DbType.String,pBE_Usuarios.Str_Nueva_Clave);
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
