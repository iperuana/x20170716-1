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

namespace GestionCombustibles.Archivo
{
    public partial class Productos : Form
    {
        BE_Productos pBE_productos = new BE_Productos();
        BL_Productos pBL_productos = new BL_Productos();

        public void Listar_Productos()
        {
           List<BE_Productos> Listar_Productos = new List<BE_Productos>();
            pBE_productos = new BE_Productos();
            pBL_productos = new BL_Productos();

            pBE_productos.Str_texto_buscar = Convert.ToString(txt_BuscarProducto.Text);
            Listar_Productos = BL_Productos.Listar_Productos(pBE_productos);

            gv_Producto_Lista.AutoGenerateColumns = false;
            gv_Producto_Lista.DataSource = Listar_Productos;
            gv_Producto_Lista.ClearSelection();
        }

        public Productos()
        {
            InitializeComponent();
        }
        private void Producto_Load(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(0);
            this.Listar_Productos();
        }

        private void gv_Producto_Lista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gv_Producto_Lista.RowCount > 0)
            {
                DataGridViewRow row = gv_Producto_Lista.CurrentRow;
                int valor = Convert.ToInt32(row.Cells["ID"].Value);
                label2.Text = Convert.ToString(valor);
            }
        }

        private void btn_Producto_Buscar_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(0);
            this.Listar_Productos();
        }
        private void btn_Productos_Nuevo_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(0);
            frm_Sub_Producto FrmSub = new frm_Sub_Producto();
            FrmSub.ShowDialog();
        }
        private void btn_Productos_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gv_Producto_Lista.RowCount > 0)
                {
                    int ID = Convert.ToInt16(label2.Text);
                    if (ID == 0)
                    {
                        MessageBox.Show("Seleccione fila");
                    }
                    else
                    {
                        label2.Text = Convert.ToString(0);
                        frm_Sub_Producto FrmSub = new frm_Sub_Producto();
                        FrmSub.Dato = ID;
                        FrmSub.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("No hay registros, lista vacia");
                }
            }
            catch
            {

            }
        }
        private void btn_Productos_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gv_Producto_Lista.RowCount > 0)
                {
                    int ID = Convert.ToInt16(label2.Text);
                    if (ID == 0)
                    {
                        MessageBox.Show("Seleccione fila");
                    }
                    else
                    {
                        label2.Text = Convert.ToString(0);
                        if (MessageBox.Show("Estas seguro de eliminar este registro ?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            pBE_productos = new BE_Productos();
                            pBL_productos = new BL_Productos();

                            pBE_productos.ID = ID;
                            pBE_productos.IDUsuarioModificacion = 1;

                            BL_Productos.ActualizarEstadoProducto(pBE_productos);

                            Listar_Productos();
                            MessageBox.Show("Registro eliminado");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay registros, lista vacia");
                }
            }
            catch
            {

            }
        }
        
        private void frm_Producto_Activated(object sender, EventArgs e)
        {
            this.Listar_Productos();
        }
    }
}
