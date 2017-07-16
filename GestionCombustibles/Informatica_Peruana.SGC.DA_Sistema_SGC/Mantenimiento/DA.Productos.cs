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
    public class DA_Productos:DA_Base
    {
        public static List<BE_Productos>Listar_Productos(BE_Productos pBE_productos)
        {
            IDataReader DataReader = null;
            List<BE_Productos> oBE_Productos = new List<BE_Productos>();
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_PRODUCTOS");
                db.AddInParameter(cmd, "@texto_buscar", DbType.String, pBE_productos.Str_texto_buscar);
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                using (DataReader = db.ExecuteReader(cmd))
                {
                    while (DataReader.Read())
                    {
                        oBE_Productos.Add(new BE_Productos(DataReader, 1));
                    }
                }
                return oBE_Productos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }

        public static List<BE_Productos> Listar_Producto_Desp(BE_Productos pBE_productos)
        {
            IDataReader DataReader = null;
            List<BE_Productos> oBE_Productos = new List<BE_Productos>();
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_PRODUCTO_DESP");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                using (DataReader = db.ExecuteReader(cmd))
                {
                    while (DataReader.Read())
                    {
                        oBE_Productos.Add(new BE_Productos(DataReader, 3));
                    }
                }
                return oBE_Productos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }
        public static List<BE_Productos> Listar_Productos_x_ID(BE_Productos pBE_productos)
        {
            IDataReader DataReader = null;
            List<BE_Productos> oBE_Productos = new List<BE_Productos>();
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_PRODUCTOS_X_ID");
                db.AddInParameter(cmd, "@ID", DbType.String, pBE_productos.ID);
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                using (DataReader = db.ExecuteReader(cmd))
                {
                    while (DataReader.Read())
                    {
                        oBE_Productos.Add(new BE_Productos(DataReader, 2));
                    }
                }
                return oBE_Productos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }
        public static int Registrar_Productos(BE_Productos pBE_productos)
        {
            int intIDInsercion = 0;
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_INS_PRODUCTO");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                db.AddOutParameter(cmd, "@id_producto", DbType.Int32, 0);
                db.AddInParameter(cmd, "@v_cod_producto", DbType.String, pBE_productos.Str_cod_producto);
                db.AddInParameter(cmd, "@v_nom_producto", DbType.String, pBE_productos.Str_nom_producto);
                db.AddInParameter(cmd, "@d_p_venta", DbType.Decimal, pBE_productos.Dcm_Venta);
                db.AddInParameter(cmd, "@d_c_compra", DbType.Decimal, pBE_productos.Dcm_Compra);
                db.AddInParameter(cmd, "@id_usuario_creacion", DbType.Int32, pBE_productos.IDUsuarioCreacion);
                db.ExecuteNonQuery(cmd);
                intIDInsercion = Convert.ToInt32(db.GetParameterValue(cmd, "@id_producto"));
                pBE_productos.ID = intIDInsercion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intIDInsercion;
        }
        public static int Actualizar_Productos(BE_Productos pBE_productos)
        {
            int intIDActualizacion = 0;
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_UPD_PRODUCTO");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                db.AddInParameter(cmd, "@id_producto", DbType.Int32, pBE_productos.ID);
                db.AddInParameter(cmd, "@v_cod_producto", DbType.String, pBE_productos.Str_cod_producto);
                db.AddInParameter(cmd, "@v_nom_producto", DbType.String, pBE_productos.Str_nom_producto);
                db.AddInParameter(cmd, "@d_p_venta", DbType.Decimal, pBE_productos.Dcm_Venta);
                db.AddInParameter(cmd, "@d_c_compra", DbType.Decimal, pBE_productos.Dcm_Compra);
                db.AddInParameter(cmd, "@id_usuario_modificacion", DbType.Int32, pBE_productos.IDUsuarioModificacion);

                db.ExecuteNonQuery(cmd);
                intIDActualizacion = 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intIDActualizacion;
        }
        public static int ActualizarEstadoProducto(BE_Productos pBE_productos)
        {
            int intIDActualizacion = 0;
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_UPD_ESTADO_PRODUCTOS");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                db.AddInParameter(cmd, "@id_producto", DbType.Int32, pBE_productos.ID);
                db.AddInParameter(cmd, "@id_usuario_modificacion", DbType.Int32, pBE_productos.IDUsuarioModificacion);
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
