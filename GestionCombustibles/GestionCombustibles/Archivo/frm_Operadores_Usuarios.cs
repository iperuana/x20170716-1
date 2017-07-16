using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento;
using Informatica_Peruana.SGC.BL_Sistema_SGC.Mantenimiento;
namespace GestionCombustibles.Archivo
{
    public partial class frm_Operadores_Usuarios : Form
    {
        BE_Operador_Usuario pBE_Operador_Usuario = new BE_Operador_Usuario();
        BL_Operador_Usuario pBL_Operador_Usuario = new BL_Operador_Usuario();
        BE_Nivel pBE_Nivel = new BE_Nivel();
        BL_Nivel pBL_Nivel = new BL_Nivel();

        public void Listar_Operador_Usuario()
        {
            List<BE_Operador_Usuario> Listar_Operador_Usuario = new List<BE_Operador_Usuario>();
            pBE_Operador_Usuario = new BE_Operador_Usuario();
            pBL_Operador_Usuario = new BL_Operador_Usuario();

            pBE_Operador_Usuario.Str_texto_buscar = Convert.ToString(txt_Operador_Buscar.Text);
            Listar_Operador_Usuario = BL_Operador_Usuario.Listar_Operador_Usuario(pBE_Operador_Usuario);

            gv_Operador_Lista.AutoGenerateColumns = false;
            gv_Operador_Lista.DataSource = Listar_Operador_Usuario;
            gv_Operador_Lista.ClearSelection();
        }

        public frm_Operadores_Usuarios()
        {
            InitializeComponent();
        }
        private void Operadores_Usuarios_Load(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(0);
            this.Listar_Operador_Usuario();
        }

        private void gv_Operador_Lista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gv_Operador_Lista.RowCount > 0)
            {
                DataGridViewRow row = gv_Operador_Lista.CurrentRow;
                int valor = Convert.ToInt32(row.Cells["ID"].Value);
                label2.Text = Convert.ToString(valor);
            }
        }

        private void btn_Operador_Buscar_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(0);
            this.Listar_Operador_Usuario();
        }
        private void btn_Operador_nuevo_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(0);
            frm_Sub_Operadores_Usuarios fr = new frm_Sub_Operadores_Usuarios();
            fr.ShowDialog();
        }
        private void btn_Operador_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gv_Operador_Lista.RowCount > 0)
                {
                    int ID = Convert.ToInt16(label2.Text);
                    if (ID == 0)
                    {
                        MessageBox.Show("Seleecione fila");
                    }
                    else
                    {
                        label2.Text = Convert.ToString(0);
                        frm_Sub_Operadores_Usuarios FrmSub = new frm_Sub_Operadores_Usuarios();
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
        private void btn_Operador_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gv_Operador_Lista.RowCount > 0)
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
                            pBE_Operador_Usuario = new BE_Operador_Usuario();
                            pBL_Operador_Usuario = new BL_Operador_Usuario();

                            pBE_Operador_Usuario.ID = ID;
                            pBE_Operador_Usuario.IDUsuarioModificacion = 1;

                            BL_Operador_Usuario.ActualizarEstadoOperador_Usuario(pBE_Operador_Usuario);

                            Listar_Operador_Usuario();
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

        private void frm_Operadores_Usuarios_Activated(object sender, EventArgs e)
        {
            this.Listar_Operador_Usuario();
        }
    }
}
