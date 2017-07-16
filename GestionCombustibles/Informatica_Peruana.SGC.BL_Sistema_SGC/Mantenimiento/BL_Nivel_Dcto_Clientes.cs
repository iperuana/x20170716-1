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
   public partial class BL_Nivel_Dcto_Clientes
    {
        public static List<BE_Nivel_Dcto_Clientes> Listar_Nivel_Dcto_x_Cliente(BE_Nivel_Dcto_Clientes pBE_Nivel_Dcto_Clientes)
        {
            try
            {
                return DA_Nivel_Dcto_Clientes.Listar_Nivel_Dcto_x_Cliente(pBE_Nivel_Dcto_Clientes);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int Registrar_Nivel_Dcto_X_Cliente(BE_Nivel_Dcto_Clientes pBE_NivelDctoCliente)
        {
            int intValor = 0;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {

                    intValor = DA_Nivel_Dcto_Clientes.Registrar_Nivel_Dcto_X_Cliente(pBE_NivelDctoCliente);

                    ts.Complete();
                }
                intValor = Convert.ToInt32(pBE_NivelDctoCliente.ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intValor;
        }

        public static int Actualizar_Nivel_Dcto_x_Cliente(BE_Nivel_Dcto_Clientes pBE_NivelDctoCliente)
        {
            int intValor = 0;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {

                    intValor = DA_Nivel_Dcto_Clientes.Actualizar_Nivel_Dcto_x_Cliente(pBE_NivelDctoCliente);

                    ts.Complete();
                }
                intValor = Convert.ToInt32(pBE_NivelDctoCliente.ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intValor;
        }

        public static int Actualizar_Estado_Nivel_Dcto_x_Cliente(BE_Nivel_Dcto_Clientes pBE_NivelDctoCliente)
        {
            int intValor = 0;
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    if (pBE_NivelDctoCliente.ID != 0)
                    {
                        intValor = DA_Nivel_Dcto_Clientes.Actualizar_Estado_Nivel_Dcto_x_Cliente(pBE_NivelDctoCliente);
                    }
                    ts.Complete();
                }
                intValor = Convert.ToInt32(pBE_NivelDctoCliente.ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return intValor;
        }
    }
}
