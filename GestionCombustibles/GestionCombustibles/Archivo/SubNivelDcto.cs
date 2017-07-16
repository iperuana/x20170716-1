using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento;
using Informatica_Peruana.SGC.BL_Sistema_SGC.Mantenimiento;

namespace GestionCombustibles
{
    public partial class SubNivelDcto : Form
    {

        BE_Productos pBE_productos = new BE_Productos();
        BL_Productos pBL_productos = new BL_Productos();
        BE_Nivel_Dcto_Clientes pBE_Nivel_Dcto_Clientes = new BE_Nivel_Dcto_Clientes();
        BL_Nivel_Dcto_Clientes pBL_Nivel_Dcto_Clientes = new BL_Nivel_Dcto_Clientes();

        public List<BE_Nivel_Dcto_Clientes> Lista_Nivel_Dcto_Nivel = new List<BE_Nivel_Dcto_Clientes>();

        public void Listar_Producto()
        {
            List<BE_Productos> Listar_Producto = new List<BE_Productos>();
            pBE_productos = new BE_Productos();
            pBL_productos = new BL_Productos();

            Listar_Producto = BL_Productos.Listar_Producto_Desp(pBE_productos);

            cbo_Nivel_Dcto_Producto.ValueMember = "ID";
            cbo_Nivel_Dcto_Producto.DisplayMember = "Str_nom_producto";
            cbo_Nivel_Dcto_Producto.DataSource = Listar_Producto;
        }

        public SubNivelDcto()
        {
            InitializeComponent();
        }
        private void SubNivelDcto_Load(object sender, EventArgs e)
        {

            this.Listar_Producto();
            cbo_Nivel_Dcto_Producto.SelectedIndex = 0;

            //txt_Nivel_Dcto_ID.Text = Dato.ToString();
            //if (this.Dato > 0)
            //{
            //    Listar_Clientes_x_ID();
            //}
        }


        private void btn_Guardar_NivelDcto_Click(object sender, EventArgs e)
        {
            pBE_Nivel_Dcto_Clientes = new BE_Nivel_Dcto_Clientes();

            pBE_Nivel_Dcto_Clientes.ID = 0;
            pBE_Nivel_Dcto_Clientes.Int_IDtemp = 0;
            pBE_Nivel_Dcto_Clientes.Int_Tipo_Mantenimiento = 1;

            pBE_Nivel_Dcto_Clientes.oBE_Producto = new BE_Productos();
            pBE_Nivel_Dcto_Clientes.oBE_Producto.ID = Convert.ToInt32(cbo_Nivel_Dcto_Producto.SelectedValue);
            pBE_Nivel_Dcto_Clientes.oBE_Producto.Str_nom_producto = (cbo_Nivel_Dcto_Producto.Text).ToString();
            pBE_Nivel_Dcto_Clientes.Dcm_cant_minima = Convert.ToDecimal(txt_Nivel_Dcto_Cant_Min.Text);
            pBE_Nivel_Dcto_Clientes.Dcm_dto_cantidad = Convert.ToDecimal(txt_Nivel_Dcto_Cant.Text);

            Archivo.frm_Sub_Cliente FrmSubCliente = new Archivo.frm_Sub_Cliente();
            FrmSubCliente.Listar_Nivel_Dcto_Agregado(pBE_Nivel_Dcto_Clientes);

            this.Close();
        }
        private void btn_Descartar_NivelDcto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
