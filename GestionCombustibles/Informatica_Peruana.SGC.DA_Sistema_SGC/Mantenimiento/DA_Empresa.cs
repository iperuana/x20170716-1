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
    public partial class DA_Empresa:DA_Base
    {
        #region "Listado"
        public static List<BE_Empresa> Listar_Empresas(BE_Empresa pBE_Empresa)
        {
            IDataReader DataReader = null;
            List<BE_Empresa> oBE_Empresa = new List<BE_Empresa>();
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_EMPRESA");
                db.AddInParameter(cmd, "@texto_buscar", DbType.String, pBE_Empresa.Str_texto_buscar);
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                using (DataReader = db.ExecuteReader(cmd))
                {
                    while (DataReader.Read())
                    {
                        oBE_Empresa.Add(new BE_Empresa(DataReader, 1));
                    }
                }
                return oBE_Empresa;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }
        public static List<BE_Empresa> Listar_Empresas_x_ID(BE_Empresa pBE_Empresa)
        {
            IDataReader DataReader = null;
            List<BE_Empresa> oBE_Empresa = new List<BE_Empresa>();
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_EMPRESA_X_ID");
                db.AddInParameter(cmd, "@ID", DbType.String, pBE_Empresa.ID);
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                using (DataReader = db.ExecuteReader(cmd))
                {
                    while (DataReader.Read())
                    {
                        oBE_Empresa.Add(new BE_Empresa(DataReader, 2));
                    }
                }
                return oBE_Empresa;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }
        #endregion
        #region"Mantenimiento"
        public static int Registrar_Empresa(BE_Empresa pBE_Empresa)
        {
            int intIDInsercion = 0;
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_INS_EMPRESA");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                db.AddOutParameter(cmd, "@id_empresa", DbType.Int32, 0);
                db.AddInParameter(cmd, "@v_num_documento", DbType.String, pBE_Empresa.Str_num_documento);
                db.AddInParameter(cmd, "@v_nom_empresa", DbType.String, pBE_Empresa.Str_nom_empresa);
                db.AddInParameter(cmd, "@v_direccion_empresa", DbType.String, pBE_Empresa.Str_direccion_empresa);
                db.AddInParameter(cmd, "@id_departamento", DbType.Int16, pBE_Empresa.oBE_Departamento.ID);
                db.AddInParameter(cmd, "@id_provincia", DbType.Int16, pBE_Empresa.oBE_Provincia.ID);
                db.AddInParameter(cmd, "@id_distrito", DbType.Int16, pBE_Empresa.oBE_Distrito.ID);
                db.AddInParameter(cmd, "@v_ubigeo", DbType.String, pBE_Empresa.Str_ubigeo);
                db.AddInParameter(cmd, "@id_usuario_creacion", DbType.Int32, pBE_Empresa.IDUsuarioCreacion);
                db.ExecuteNonQuery(cmd);
                intIDInsercion = Convert.ToInt32(db.GetParameterValue(cmd, "@id_empresa"));
                pBE_Empresa.ID = intIDInsercion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intIDInsercion;
        }
        public static int Actualizar_Empresa(BE_Empresa pBE_Empresa)
        {
            int intIDActualizacion = 0;
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_UPD_EMPRESA");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);

                db.AddInParameter(cmd, "@id_empresa", DbType.Int32, pBE_Empresa.ID);
                db.AddInParameter(cmd, "@v_num_documento", DbType.String, pBE_Empresa.Str_num_documento);
                db.AddInParameter(cmd, "@v_nom_empresa", DbType.String, pBE_Empresa.Str_nom_empresa);
                db.AddInParameter(cmd, "@v_direccion_empresa", DbType.String, pBE_Empresa.Str_direccion_empresa);
                db.AddInParameter(cmd, "@id_departamento", DbType.Int16, pBE_Empresa.oBE_Departamento.ID);
                db.AddInParameter(cmd, "@id_provincia", DbType.Int16, pBE_Empresa.oBE_Provincia.ID);
                db.AddInParameter(cmd, "@id_distrito", DbType.Int16, pBE_Empresa.oBE_Distrito.ID);
                db.AddInParameter(cmd, "@v_ubigeo", DbType.String, pBE_Empresa.Str_ubigeo);
                db.AddInParameter(cmd, "@id_usuario_modificacion", DbType.Int32, pBE_Empresa.IDUsuarioModificacion);
                db.ExecuteNonQuery(cmd);
                intIDActualizacion = 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intIDActualizacion;
        }
        public static int ActualizarEstadoEmpresa(BE_Empresa pBE_Empresa)
        {
            int intIDActualizacion = 0;
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_UPD_ESTADO_EMPRESA");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                db.AddInParameter(cmd, "@id_empresa", DbType.Int32, pBE_Empresa.ID);
                db.AddInParameter(cmd, "@id_usuario_modificacion", DbType.Int32, pBE_Empresa.IDUsuarioModificacion);
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
