using Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento;
using Informatica_Peruana.SGC.DA_Sistema_SGC.Mantenimiento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Threading.Tasks;

namespace Informatica_Peruana.SGC.BL_Sistema_SGC.Mantenimiento
{
    public partial class BL_Productos
    {
        #region "Listados"
        public static List<BE_Productos> Listar_Producto_Desp(BE_Productos pBE_Producto)
        {
            try
            {
                return DA_Productos.Listar_Producto_Desp(pBE_Producto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<BE_Productos> Listar_Productos(BE_Productos pBE_productos)
        {
            try
            {
                return DA_Productos.Listar_Productos(pBE_productos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<BE_Productos> Listar_Productos_x_ID(BE_Productos pBE_productos)
        {
            try
            {
                return DA_Productos.Listar_Productos_x_ID(pBE_productos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region"Mantenimiento"
        public static int Registrar_Productos(BE_Productos pBE_productos)
        {
            int intValor = 0;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {

                    intValor = DA_Productos.Registrar_Productos(pBE_productos);

                    ts.Complete();
                }
                intValor = Convert.ToInt32(pBE_productos.ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intValor;
        }
        public static int Actualizar_Productos(BE_Productos pBE_productos)
        {
            int intValor = 0;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {

                    intValor = DA_Productos.Actualizar_Productos(pBE_productos);

                    ts.Complete();
                }
                intValor = Convert.ToInt32(pBE_productos.ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intValor;
        }
        public static int ActualizarEstadoProducto(BE_Productos pBE_productos)
        {
            int intValor = 0;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    if (pBE_productos.ID != 0)
                    {
                        intValor = DA_Productos.ActualizarEstadoProducto(pBE_productos);
                    }
                    ts.Complete();
                }
                intValor = Convert.ToInt32(pBE_productos.ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intValor;
        }
        #endregion

    }

}
