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
   public partial class DA_Nivel:DA_Base
    {
        #region "Listado"

        public static List<BE_Nivel> Listar_Nivel(BE_Nivel pBE_Nivel)
        {
            IDataReader DataReader = null;
            List<BE_Nivel> oBE_Nivel = new List<BE_Nivel>();
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_NIVEL");
                //db.AddInParameter(cmd, "@texto_buscar", DbType.String, pBE_Nivel.Str_texto_buscar);
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                using (DataReader = db.ExecuteReader(cmd))
                {
                    while (DataReader.Read())
                    {
                        oBE_Nivel.Add(new BE_Nivel(DataReader, 1));
                    }
                }
                return oBE_Nivel;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }
        //public static List<BE_clientes> Listar_Clientes_x_ID(BE_clientes pBE_Clientes)
        //{
        //    IDataReader DataReader = null;
        //    List<BE_clientes> oBE_Clientes = new List<BE_clientes>();
        //    try
        //    {
        //        SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_CLIENTES_X_ID");
        //        db.AddInParameter(cmd, "@ID", DbType.String, pBE_Clientes.ID);
        //        cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
        //        using (DataReader = db.ExecuteReader(cmd))
        //        {
        //            while (DataReader.Read())
        //            {
        //                oBE_Clientes.Add(new BE_clientes(DataReader, 2));
        //            }
        //        }
        //        return oBE_Clientes;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally { if (!DataReader.IsClosed) DataReader.Close(); }
        //}
        #endregion
        #region "Mantenimiento"
        //public static int Registrar_Clientes(BE_clientes pBE_clientes)
        //{
        //    int intIDInsercion = 0;
        //    try
        //    {
        //        SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_INS_CLIENTES");
        //        cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
        //        db.AddOutParameter(cmd, "@id_cliente", DbType.Int32, 0);
        //        db.AddInParameter(cmd, "@id_tipo_documento", DbType.Int32, pBE_clientes.oBE_Tipo_Documento.ID);
        //        db.AddInParameter(cmd, "@v_num_documento", DbType.String, pBE_clientes.Str_num_documento);
        //        db.AddInParameter(cmd, "@v_nom_cliente", DbType.String, pBE_clientes.Str_nom_cliente);
        //        db.AddInParameter(cmd, "@v_direccion_cliente", DbType.String, pBE_clientes.Str_direccion_cliente);
        //        db.AddInParameter(cmd, "@id_departamento", DbType.Int16, pBE_clientes.oBE_Departamento.ID);
        //        db.AddInParameter(cmd, "@id_provincia", DbType.Int16, pBE_clientes.oBE_Provincia.ID);
        //        db.AddInParameter(cmd, "@id_distrito", DbType.Int16, pBE_clientes.oBE_Distrito.ID);
        //        db.AddInParameter(cmd, "@v_ubigeo", DbType.String, pBE_clientes.Str_v_ubigeo);
        //        db.AddInParameter(cmd, "@i_chk_promo_vigentes", DbType.Int16, pBE_clientes.Int_chk_promo_vigentes);
        //        db.AddInParameter(cmd, "@i_chk_aceptar_vtas_credito", DbType.Int16, pBE_clientes.Int_chk_aceptar_vtas_credito);
        //        db.AddInParameter(cmd, "@d_linea_credito", DbType.Decimal, pBE_clientes.Dcm_linea_credito);
        //        db.AddInParameter(cmd, "@d_credito_utilizado", DbType.Decimal, pBE_clientes.Dcm_credito_utilizado);
        //        db.AddInParameter(cmd, "@d_credito_disponible", DbType.Decimal, pBE_clientes.Dcm_credito_disponible);
        //        db.AddInParameter(cmd, "@id_usuario_creacion", DbType.Int32, pBE_clientes.IDUsuarioCreacion);
        //        db.ExecuteNonQuery(cmd);
        //        intIDInsercion = Convert.ToInt32(db.GetParameterValue(cmd, "@id_cliente"));
        //        pBE_clientes.ID = intIDInsercion;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return intIDInsercion;
        //}
        //public static int Actualizar_clientes(BE_clientes pBE_clientes)
        //{
        //    int intIDActualizacion = 0;
        //    try
        //    {
        //        SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_UPD_CLIENTES");
        //        cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);

        //        db.AddInParameter(cmd, "@id_cliente", DbType.Int32, pBE_clientes.ID );
        //        db.AddInParameter(cmd, "@id_tipo_documento", DbType.Int32, pBE_clientes.oBE_Tipo_Documento.ID);
        //        db.AddInParameter(cmd, "@v_num_documento", DbType.String, pBE_clientes.Str_num_documento);
        //        db.AddInParameter(cmd, "@v_nom_cliente", DbType.String, pBE_clientes.Str_nom_cliente);
        //        db.AddInParameter(cmd, "@v_direccion_cliente", DbType.String, pBE_clientes.Str_direccion_cliente);
        //        db.AddInParameter(cmd, "@id_departamento", DbType.Int16, pBE_clientes.oBE_Departamento.ID);
        //        db.AddInParameter(cmd, "@id_provincia", DbType.Int16, pBE_clientes.oBE_Provincia.ID);
        //        db.AddInParameter(cmd, "@id_distrito", DbType.Int16, pBE_clientes.oBE_Distrito.ID);
        //        db.AddInParameter(cmd, "@v_ubigeo", DbType.String, pBE_clientes.Str_v_ubigeo);
        //        db.AddInParameter(cmd, "@i_chk_promo_vigentes", DbType.Int16, pBE_clientes.Int_chk_promo_vigentes);
        //        db.AddInParameter(cmd, "@i_chk_aceptar_vtas_credito", DbType.Int16, pBE_clientes.Int_chk_aceptar_vtas_credito);
        //        db.AddInParameter(cmd, "@d_linea_credito", DbType.Decimal, pBE_clientes.Dcm_linea_credito);
        //        db.AddInParameter(cmd, "@d_credito_utilizado", DbType.Decimal, pBE_clientes.Dcm_credito_utilizado);
        //        db.AddInParameter(cmd, "@d_credito_disponible", DbType.Decimal, pBE_clientes.Dcm_credito_disponible);
        //        db.AddInParameter(cmd, "@id_usuario_modificacion", DbType.Int32, pBE_clientes.IDUsuarioModificacion);

        //        db.ExecuteNonQuery(cmd);
        //        intIDActualizacion = 1;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return intIDActualizacion;
        //}
        //public static int ActualizarEstadoclientes(BE_clientes pBE_clientes)
        //{
        //    int intIDActualizacion = 0;
        //    try
        //    {
        //        SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_UPD_ESTADO_CLIENTES");
        //        cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
        //        db.AddInParameter(cmd, "@id_cliente", DbType.Int32, pBE_clientes.ID);
        //        db.AddInParameter(cmd, "@id_usuario_modificacion", DbType.Int32, pBE_clientes.IDUsuarioModificacion);
        //        db.ExecuteNonQuery(cmd);
        //        intIDActualizacion = 1;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return intIDActualizacion;
        //}

        #endregion
    }
}
