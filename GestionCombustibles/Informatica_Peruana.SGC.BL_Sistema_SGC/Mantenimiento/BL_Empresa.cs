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
    public partial class BL_Empresa
    {
        #region"Listado"
        public static List<BE_Empresa> Listar_Empresa(BE_Empresa pBE_Empresa)
        {
            try
            {
                return DA_Empresa.Listar_Empresas(pBE_Empresa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<BE_Empresa> Listar_Empresa_x_ID(BE_Empresa pBE_Empresa)
        {
            try
            {
                return DA_Empresa.Listar_Empresas_x_ID(pBE_Empresa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region"Mantenimiento"
        public static int Registrar_Empresa(BE_Empresa pBE_Empresa)
        {
            int intValor = 0;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {

                    intValor = DA_Empresa.Registrar_Empresa(pBE_Empresa);

                    ts.Complete();
                }
                intValor = Convert.ToInt32(pBE_Empresa.ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intValor;
        }
        public static int Actualizar_Empresa(BE_Empresa pBE_Empresa)
        {
            int intValor = 0;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {

                    intValor = DA_Empresa.Actualizar_Empresa(pBE_Empresa);

                    ts.Complete();
                }
                intValor = Convert.ToInt32(pBE_Empresa.ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intValor;
        }
        public static int ActualizarEstadoEmpresa(BE_Empresa pBE_Empresa)
        {
            int intValor = 0;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    if (pBE_Empresa.ID != 0)
                    {
                        intValor = DA_Empresa.ActualizarEstadoEmpresa(pBE_Empresa);
                    }
                    ts.Complete();
                }
                intValor = Convert.ToInt32(pBE_Empresa.ID);
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
