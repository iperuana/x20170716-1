using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento;
using Informatica_Peruana.SGC.BL_Sistema_SGC.Mantenimiento;
using System.Data.SqlClient;

namespace GestionCombustibles.Archivo
{
    public partial class frm_Sub_Producto : Form
    {
        private Productos FrmProducto = new Productos();
        public int Dato { get; set; }

        BE_Productos pBE_productos = new BE_Productos();
        BL_Productos pBL_productos = new BL_Productos();

        public void Listar_Productos_x_ID()
        {
            List<BE_Productos> Listar_Productos_x_ID = new List<BE_Productos>();
            pBE_productos = new BE_Productos();
            pBL_productos = new BL_Productos();

            pBE_productos.ID = Convert.ToInt32(txt_Productos_ID.Text);

            Listar_Productos_x_ID = BL_Productos.Listar_Productos_x_ID(pBE_productos);

            txt_Productos_Codigo.Text = Convert.ToString(Listar_Productos_x_ID[0].Str_cod_producto);
            txt_Productos_Nombre.Text = Convert.ToString(Listar_Productos_x_ID[0].Str_nom_producto);
            txt_Productos_PrecioVenta.Text = Convert.ToString(Listar_Productos_x_ID[0].Dcm_Venta);
            txt_Productos_Costo_Compra.Text = Convert.ToString(Listar_Productos_x_ID[0].Dcm_Compra);
        }

        public frm_Sub_Producto()
        {
            InitializeComponent();
        }
        private void frm_Sub_Producto_Load(object sender, EventArgs e)
        {
            txt_Productos_ID.Text = Dato.ToString();
            if (this.Dato > 0)
            {
                Listar_Productos_x_ID();
            }
        }

        public void Registrar_Productos()
        {
            int res = 0;
            pBE_productos = new BE_Productos();
            pBL_productos = new BL_Productos();

            pBE_productos.ID = Convert.ToInt32(txt_Productos_ID.Text);
            pBE_productos.Str_cod_producto = txt_Productos_Codigo.Text;
            pBE_productos.Str_nom_producto = txt_Productos_Nombre.Text;
            pBE_productos.Dcm_Venta = Convert.ToDecimal(txt_Productos_PrecioVenta.Text.Replace(".", ","));
            pBE_productos.Dcm_Compra = Convert.ToDecimal(txt_Productos_Costo_Compra.Text.Replace(".", ","));
            if (Convert.ToInt32(txt_Productos_ID.Text) == 0)
            {
                pBE_productos.IDUsuarioCreacion = 1;
                res = BL_Productos.Registrar_Productos(pBE_productos);
            }
            else
            {
                pBE_productos.IDUsuarioModificacion = 1;
                res = BL_Productos.Actualizar_Productos(pBE_productos);
            }
        }

        private void btn_Productos_Aceptar_Click(object sender, EventArgs e)
        {
            this.Registrar_Productos();
            this.Close();
        }
        private void btn_Productos_Eliminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Productos_PrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_Productos_PrecioVenta.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' || e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
        }
        private void txt_Productos_Costo_Compra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_Productos_Costo_Compra.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' || e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
        }
    }
}
