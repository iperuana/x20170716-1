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
    public class DA_Tipo_Cambio:DA_Base
    {
        #region "Listados"
        public static List<BE_Tipo_Cambio> Listar_TipoCambio(BE_Tipo_Cambio pBE_Tipo_Cambio)
        {
            IDataReader DataReader = null;
            List<BE_Tipo_Cambio> oBE_Tipo_Cambio = new List<BE_Tipo_Cambio>();
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_TIPOS_CAMBIO");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                using (DataReader = db.ExecuteReader(cmd))
                {
                    while (DataReader.Read())
                    {
                        oBE_Tipo_Cambio.Add(new BE_Tipo_Cambio(DataReader, 1));
                    }
                }
                return oBE_Tipo_Cambio;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }

        #endregion

        public static List<BE_Tipo_Cambio> Listar_Tipo_Cambio_x_fecha(BE_Tipo_Cambio pBE_Tipo_Cambio)
        {
            IDataReader DataReader = null;
            List<BE_Tipo_Cambio> oBE_Tipo_Cambio = new List<BE_Tipo_Cambio>();
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_TIPO_CAMBIO_X_FECHA");
                db.AddInParameter(cmd, "@v_fecha", DbType.String, pBE_Tipo_Cambio.Str_Fecha);
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                using (DataReader = db.ExecuteReader(cmd))
                {
                    while (DataReader.Read())
                    {
                        oBE_Tipo_Cambio.Add(new BE_Tipo_Cambio(DataReader, 2));
                    } 
                }
                return oBE_Tipo_Cambio;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }

        public static int Registrar_Tipo_Cambio(BE_Tipo_Cambio pBE_Tipo_Cambio)
        {
            int intIDInsercion = 0;
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_INS_TIPO_CAMBIO");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                db.AddOutParameter(cmd, "@id_tcambio", DbType.Int32, 0);
                db.AddInParameter(cmd, "@v_fecha", DbType.String, pBE_Tipo_Cambio.Str_Fecha);
                db.AddInParameter(cmd, "@d_venta", DbType.Decimal, pBE_Tipo_Cambio.Dcm_Venta);
                db.AddInParameter(cmd, "@d_compra", DbType.Decimal, pBE_Tipo_Cambio.Dcm_Compra);
                db.ExecuteNonQuery(cmd);
                intIDInsercion = Convert.ToInt32(db.GetParameterValue(cmd, "@id_tcambio"));
                pBE_Tipo_Cambio.ID = intIDInsercion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intIDInsercion;
        }

        public static int Actualizar_Tipo_Cambio(BE_Tipo_Cambio pBE_Tipo_Cambio)
        {
            int intIDActualizacion = 0;
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_UPD_TIPO_CAMBIO");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                db.AddInParameter(cmd, "@id_tcambio", DbType.Int32, pBE_Tipo_Cambio.ID);
                db.AddInParameter(cmd, "@v_fecha", DbType.String, pBE_Tipo_Cambio.Str_Fecha);
                db.AddInParameter(cmd, "@d_venta", DbType.Decimal, pBE_Tipo_Cambio.Dcm_Venta);
                db.AddInParameter(cmd, "@d_compra", DbType.Decimal, pBE_Tipo_Cambio.Dcm_Compra);
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
