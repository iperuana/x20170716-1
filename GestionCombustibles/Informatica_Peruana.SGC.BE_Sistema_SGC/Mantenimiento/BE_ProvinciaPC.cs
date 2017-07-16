using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento
{
    public partial class BE_Provincia
    {
       public BE_Departamento oBE_Departamento { get; set; } 

        public BE_Provincia()
        {
            oBE_Departamento = new BE_Departamento();
        }
        public BE_Provincia(IDataReader pDataReader, int pIntTipo)
        { 

            oBE_Departamento = new BE_Departamento();
            switch (pIntTipo)
            {
                case 1:
                    this.ID = pDataReader["id_provincia"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_provincia"].ToString()) : null;
                    this.Str_Provincia = pDataReader["v_desc_provincia"] != DBNull.Value ? pDataReader["v_desc_provincia"].ToString() : null;
                    break;
                case 2:
                    this.ID = pDataReader["id_provincia"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_provincia"].ToString()) : null;
                    this.Str_Provincia = pDataReader["v_desc_provincia"] != DBNull.Value ? pDataReader["v_desc_provincia"].ToString() : null;
                    break;

                case 3:
                    this.ID = pDataReader["id_provincia"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_provincia"].ToString()) : null;
                    this.Str_Provincia = pDataReader["v_desc_provincia"] != DBNull.Value ? pDataReader["v_desc_provincia"].ToString() : null;
                    break;
            }
        }
    }
}
