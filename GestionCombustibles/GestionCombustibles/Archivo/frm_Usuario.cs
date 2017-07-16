using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento;
using Informatica_Peruana.SGC.BL_Sistema_SGC.Mantenimiento;

namespace GestionCombustibles.Archivo
{
    public partial class frm_Usuario : Form
    {
        BE_Usuarios pBE_Usuarios = new BE_Usuarios();
        BL_Usuarios pBL_Usuarios = new BL_Usuarios();

        public void Listar_Usuarios()
        {
            List<BE_Usuarios> Listar_Usuarios = new List<BE_Usuarios>();
            pBE_Usuarios = new BE_Usuarios();
            pBL_Usuarios = new BL_Usuarios();
            pBE_Usuarios.Str_texto_buscar = Convert.ToString(txt_Usuario_buscar.Text);
            
            Listar_Usuarios = BL_Usuarios.Listar_Usuarios(pBE_Usuarios);

            gv_Lista_Ususario.AutoGenerateColumns = false;
            gv_Lista_Ususario.DataSource = Listar_Usuarios;
            gv_Lista_Ususario.ClearSelection();

        }

        public frm_Usuario()
        {
            InitializeComponent();
        }
        private void frm_Usuario_Load(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(0);
            this.Listar_Usuarios();
        }
     
        private void btn_Usuario_Buscar_Click_1(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(0);
            this.Listar_Usuarios();
        }

        private void btn_Islas_Nuevo_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(0);
            frm_Sub_Usuario fr = new frm_Sub_Usuario();
            fr.ShowDialog();
        }

        private void btn_Usuario_Modificar_Click(object sender, EventArgs e)
        {
           try
            {
                if (gv_Lista_Ususario.RowCount > 0)
                {
                    int ID = Convert.ToInt16(label2.Text);
                    if (ID == 0)
                    {
                        MessageBox.Show("Seleecione fila");
                    }
                    else
                    {
                        label2.Text = Convert.ToString(0);
                        frm_Sub_Usuario FrmSub = new frm_Sub_Usuario();
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
        private void btn_Usuario_Eliminar_Click(object sender, EventArgs e)
        {

            try
            {
                if (gv_Lista_Ususario.RowCount > 0)
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
                            pBE_Usuarios = new BE_Usuarios();
                            pBL_Usuarios = new BL_Usuarios();

                            pBE_Usuarios.ID = ID;
                            pBE_Usuarios.IDUsuarioModificacion = 1;

                            BL_Usuarios.ActualizarEstadoUsuarios(pBE_Usuarios);

                            Listar_Usuarios();
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

        private void frm_Usuario_Activated(object sender, EventArgs e)
        {
            this.Listar_Usuarios();
        }

        private void gv_Lista_Ususario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gv_Lista_Ususario.RowCount > 0)
            {
                DataGridViewRow row = gv_Lista_Ususario.CurrentRow;
                int valor = Convert.ToInt32(row.Cells["ID"].Value);
                label2.Text = Convert.ToString(valor);
            }
        }
    }
}
