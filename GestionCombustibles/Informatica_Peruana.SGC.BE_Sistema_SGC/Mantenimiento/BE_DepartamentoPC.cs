using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento
{
    public partial class BE_Departamento
    {
        public BE_Departamento()
        {

        }

        public BE_Departamento(IDataReader pDataReader,int pIntTipo)
        {
            switch (pIntTipo)
            {
                case 1:
                    this.ID = pDataReader["id_departamento"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_departamento"].ToString()) : null;
                    this.Str_Departamento = pDataReader["v_desc_departamento"] != DBNull.Value ? pDataReader["v_desc_departamento"].ToString() : null;
                    break;
                case 2:
                    this.ID = pDataReader["id_departamento"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_departamento"].ToString()) : null;
                    this.Str_Departamento = pDataReader["v_desc_departamento"] != DBNull.Value ? pDataReader["v_desc_departamento"].ToString() : null;
                    break;
            }
        }
    }
}
