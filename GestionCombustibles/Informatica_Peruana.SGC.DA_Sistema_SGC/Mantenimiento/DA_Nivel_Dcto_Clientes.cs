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
   public partial class DA_Nivel_Dcto_Clientes:DA_Base
    {
        public static List<BE_Nivel_Dcto_Clientes> Listar_Nivel_Dcto_x_Cliente(BE_Nivel_Dcto_Clientes pBE_NivelDctoCliente)
        {
            IDataReader DataReader = null;
            List<BE_Nivel_Dcto_Clientes> oBE_NivelDctoCliente = new List<BE_Nivel_Dcto_Clientes>();
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_SEL_NIVEL_DCTO_X_CLIENTE");
                db.AddInParameter(cmd, "@id_cliente", DbType.String, pBE_NivelDctoCliente.oBE_Cliente.ID);
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                using (DataReader = db.ExecuteReader(cmd))
                {
                    while (DataReader.Read())
                    {
                        oBE_NivelDctoCliente.Add(new BE_Nivel_Dcto_Clientes(DataReader, 1));
                    }
                }
                return oBE_NivelDctoCliente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { if (!DataReader.IsClosed) DataReader.Close(); }
        }
        public static int Registrar_Nivel_Dcto_X_Cliente(BE_Nivel_Dcto_Clientes pBE_NivelDctoCliente)
        {
            int intIDInsercion = 0;
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_INS_CLIENTES");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                db.AddOutParameter(cmd, "@id_nivel_dto_cliente", DbType.Int32, 0);
                db.AddInParameter(cmd, "@id_cliente", DbType.Int32, pBE_NivelDctoCliente.oBE_Cliente.ID);
                db.AddInParameter(cmd, "@id_producto", DbType.Int32, pBE_NivelDctoCliente.oBE_Producto.ID);
                db.AddInParameter(cmd, "@d_cant_minima", DbType.Decimal, pBE_NivelDctoCliente.Dcm_cant_minima);
                db.AddInParameter(cmd, "@d_dto_cantidad", DbType.Decimal, pBE_NivelDctoCliente.Dcm_dto_cantidad);
                db.ExecuteNonQuery(cmd);
                intIDInsercion = Convert.ToInt32(db.GetParameterValue(cmd, "@id_nivel_dto_cliente"));
                pBE_NivelDctoCliente.ID = intIDInsercion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intIDInsercion;
        }

        public static int Actualizar_Nivel_Dcto_x_Cliente(BE_Nivel_Dcto_Clientes pBE_NivelDctoCliente)
        {
            int intIDActualizacion = 0;
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_UPD_DESCUENTO");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);

                db.AddInParameter(cmd, "@id_nivel_dto_cliente", DbType.Int32, pBE_NivelDctoCliente.ID);
                db.AddInParameter(cmd, "@id_cliente", DbType.Int32, pBE_NivelDctoCliente.oBE_Cliente.ID);
                db.AddInParameter(cmd, "@id_producto", DbType.Int32, pBE_NivelDctoCliente.oBE_Producto.ID);
                db.AddInParameter(cmd, "@d_cant_minima", DbType.Decimal, pBE_NivelDctoCliente.Dcm_cant_minima);
                db.AddInParameter(cmd, "@d_dto_cantidad", DbType.Decimal, pBE_NivelDctoCliente.Dcm_dto_cantidad);
                db.ExecuteNonQuery(cmd);
                intIDActualizacion = 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intIDActualizacion;
        }

        public static int Actualizar_Estado_Nivel_Dcto_x_Cliente(BE_Nivel_Dcto_Clientes pBE_NivelDctoCliente)
        {
            int intIDActualizacion = 0;
            try
            {
                SqlCommand cmd = (SqlCommand)db.GetStoredProcCommand("USP_UPD_ESTADO_DESCUENTO");
                cmd.CommandTimeout = Convert.ToInt32(DuracionConexion.corta);
                db.AddInParameter(cmd, "@id_cliente", DbType.Int32, pBE_NivelDctoCliente.ID);
                db.AddInParameter(cmd, "@i_estado_registro", DbType.Int32, pBE_NivelDctoCliente.IntEstado);
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
