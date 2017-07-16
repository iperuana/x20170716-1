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
   public partial class BL_Usuarios
    {
        #region"listado"
        public static List<BE_Usuarios> Loguear(BE_Usuarios pBE_Usuarios)
        {
            try
            {
                return DA_Usuarios.Loguear(pBE_Usuarios);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<BE_Usuarios> Listar_Usuarios(BE_Usuarios pBE_Usuarios)
        {
            try
            {
                return DA_Usuarios.Listar_Usuarios(pBE_Usuarios);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<BE_Usuarios> Listar_Usuarios_x_ID(BE_Usuarios pBE_Usuarios)
        {
            try
            {
                return DA_Usuarios.Listar_Usuarios_x_ID(pBE_Usuarios);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
        #region"mantenimiento"
        public static int Registrar_Usuarios(BE_Usuarios pBE_Usuarios)
        {
            int intValor = 0;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    intValor = DA_Usuarios.Registrar_Usuarios(pBE_Usuarios);
                    ts.Complete();
                }
                intValor = Convert.ToInt32(pBE_Usuarios.ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intValor;
        }
        public static int Actualizar_Usuario(BE_Usuarios pBE_Usuarios)
        {
            int intValor = 0;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    intValor = DA_Usuarios.Actualizar_Usuarios(pBE_Usuarios);
                    ts.Complete();
                }
                intValor = Convert.ToInt32(pBE_Usuarios.ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intValor;
        }
        public static int ActualizarEstadoUsuarios(BE_Usuarios pBE_Usuarios)
        {
            int intValor = 0;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    if (pBE_Usuarios.ID != 0)
                    {
                        intValor = DA_Usuarios.ActualizarEstadoUsuarios(pBE_Usuarios);
                    }
                    ts.Complete();
                }
                intValor = Convert.ToInt32(pBE_Usuarios.ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intValor;
        }
        public static int Actualizar_Clave_Usuario(BE_Usuarios pBE_Usuarios)
        {
            int intValor = 0;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    intValor = DA_Usuarios.ActualizarClaveUsuarios(pBE_Usuarios);
                    ts.Complete();
                }
                intValor = Convert.ToInt32(pBE_Usuarios.ID);
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
