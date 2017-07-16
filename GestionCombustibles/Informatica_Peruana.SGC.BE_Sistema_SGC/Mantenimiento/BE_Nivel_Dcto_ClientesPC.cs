using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento
{
    public partial class BE_Nivel_Dcto_Clientes:BE_Base
    {

        public BE_clientes oBE_Cliente { get; set; }
        public BE_Productos oBE_Producto { get; set; }

        public string Str_Nom_Producto { get; set; }
        public int Int_IDtemp { get; set; }
        public int Int_Tipo_Mantenimiento { get; set; }

        public BE_Nivel_Dcto_Clientes()
        {
            oBE_Cliente = new BE_clientes();
            oBE_Producto = new BE_Productos();
           
        }
        public BE_Nivel_Dcto_Clientes(IDataReader pDataReader, int pIntTipo)
        {
            oBE_Cliente = new BE_clientes();
            oBE_Producto = new BE_Productos();
            switch (pIntTipo)
            {
                case 1:
                    this.ID = pDataReader["id_nivel_dto_cliente"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_nivel_dto_cliente"].ToString()) : null;
                    this.oBE_Producto.ID= pDataReader["id_producto"] != DBNull.Value ? (int?)Convert.ToInt32(pDataReader["id_producto"].ToString()) : null;
                    this.oBE_Producto.Str_nom_producto = pDataReader["v_nom_producto"] != DBNull.Value ? pDataReader["v_nom_producto"].ToString() : null;
                    this.Str_Nom_Producto = pDataReader["v_nom_producto"] != DBNull.Value ? pDataReader["v_nom_producto"].ToString() : null;
                    this.Dcm_cant_minima = pDataReader["d_cant_minima"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_cant_minima"]) : null;
                    this.Dcm_dto_cantidad = pDataReader["d_dto_cantidad"] != DBNull.Value ? (decimal?)Convert.ToDecimal(pDataReader["d_dto_cantidad"]) : null;
                    break;
            }
        }

    }

}
