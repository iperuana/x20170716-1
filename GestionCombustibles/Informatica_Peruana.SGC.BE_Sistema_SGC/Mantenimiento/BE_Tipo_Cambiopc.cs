using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento
{
    public partial class BE_Tipo_Cambio
    {
        public BE_Tipo_Cambio()
        {

        }
        public BE_Tipo_Cambio(IDataReader pDataReader, int pIntTipo)
        {
            switch (pIntTipo)
            {
                case 1:
                    this.ID = pDataReader["id_tcambio"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_tcambio"].ToString()) : null;
                    this.Str_Fecha= pDataReader["v_fecha"] != DBNull.Value ? pDataReader["v_fecha"].ToString() : null;
                    this.Dcm_Venta= pDataReader["d_venta"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_venta"]) : null;
                    this.Dcm_Compra= pDataReader["d_compra"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_compra"]) : null;
                    break;
                case 2:
                    this.ID = pDataReader["id_tcambio"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_tcambio"].ToString()) : null;
                    this.Str_Fecha = pDataReader["v_fecha"] != DBNull.Value ? pDataReader["v_fecha"].ToString() : null;
                    this.Dcm_Venta = pDataReader["d_venta"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_venta"]) : null;
                    this.Dcm_Compra = pDataReader["d_compra"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_compra"]) : null;
                    break;
            }
        }
    }
}
