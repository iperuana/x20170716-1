using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento
{
    public partial class BE_Distrito
    {
        public BE_Provincia oBE_Provincia { get; set; }

        public BE_Distrito()
        {
            oBE_Provincia = new BE_Provincia();
        }
        public BE_Distrito(IDataReader pDataReader, int pIntTipo)
        {

            oBE_Provincia = new BE_Provincia();
            switch (pIntTipo)
            {
                case 1:
                    this.ID = pDataReader["id_distrito"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_distrito"].ToString()) : null;
                    this.Str_Distrito = pDataReader["v_desc_distrito"] != DBNull.Value ? pDataReader["v_desc_distrito"].ToString() : null;
                    break;
                case 2:
                    this.ID = pDataReader["id_distrito"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_distrito"].ToString()) : null;
                    this.Str_Distrito = pDataReader["v_desc_distrito"] != DBNull.Value ? pDataReader["v_desc_distrito"].ToString() : null;
                    break;
            }
        }
    }

    }
