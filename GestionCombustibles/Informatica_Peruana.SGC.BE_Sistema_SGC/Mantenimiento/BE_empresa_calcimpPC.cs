using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento
{
    public partial class BE_empresa_calcimp
    {
        public string Str_texto_buscar { get; set; }

        public BE_empresa_calcimp() { }

        public BE_empresa_calcimp(IDataReader pDataReader, int pIntTipo)
        {
            switch (pIntTipo)
            {
                case 1:
                    this.ID = pDataReader["id_empresa"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_empresa"].ToString()) : null;
                    this.ID_CalcImp = pDataReader["id_calcimp"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_calcimp"].ToString()) : null;
                    this.Dec_CalculoIGV_CalcImp = pDataReader["d_calculoIGV_calcimp"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_calculoIGV_calcimp"]) : null;
                    this.Dec_CalculoISC_CalcImp = pDataReader["d_calculoISC_calcimp"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_calculoISC_calcimp"]) : null;

                    break;

                case 2:
                    this.ID = pDataReader["id_empresa"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_empresa"].ToString()) : null;
                    this.ID_CalcImp = pDataReader["id_calcimp"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_calcimp"].ToString()) : null;
                    this.Dec_CalculoIGV_CalcImp = pDataReader["d_calculoIGV_calcimp"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_calculoIGV_calcimp"]) : null;
                    this.Dec_CalculoISC_CalcImp = pDataReader["d_calculoISC_calcimp"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_calculoISC_calcimp"]) : null;

                    break;
            }


        }
    }
}
