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
    public partial class frm_Islas : Form
    {

        BE_Islas pBE_Islas = new BE_Islas();
        BL_Islas pBL_Islas = new BL_Islas();

        public void Listar_Islas()
        {
            List<BE_Islas> Listar_Islas = new List<BE_Islas>();
            pBE_Islas = new BE_Islas();
            pBL_Islas = new BL_Islas();
            pBE_Islas.Str_texto_buscar = Convert.ToString(txt_Islas_buscar.Text);

            pBE_Islas.Str_texto_buscar = Convert.ToString(txt_Islas_buscar.Text);
            Listar_Islas = BL_Islas.Listar_Islas(pBE_Islas);

            gv_Lista_Islas.AutoGenerateColumns = false;
            gv_Lista_Islas.DataSource = Listar_Islas;
            gv_Lista_Islas.ClearSelection();
        }

        public frm_Islas()
        {
            InitializeComponent();
        }
        private void frm_Islas_Load(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(0);
            this.Listar_Islas();
        }

        private void gv_Lista_Islas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gv_Lista_Islas.RowCount > 0)
            {
                DataGridViewRow row = gv_Lista_Islas.CurrentRow;
                int valor = Convert.ToInt32(row.Cells["ID"].Value);
                label2.Text = Convert.ToString(valor);
            }
        }

        private void btn_Islas_Buscar_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(0);
            this.Listar_Islas();
        }
        private void btn_Islas_Nuevo_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(0);
            frm_Sub_Islas fr = new frm_Sub_Islas();
            fr.ShowDialog();
        }
        private void btn_Islas_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gv_Lista_Islas.RowCount > 0)
                {
                    int ID = Convert.ToInt16(label2.Text);
                    if (ID == 0)
                    {
                        MessageBox.Show("Seleecione fila");
                    }
                    else
                    {
                        label2.Text = Convert.ToString(0);
                        frm_Sub_Islas FrmSub = new frm_Sub_Islas();
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
        private void btn_Islas_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gv_Lista_Islas.RowCount > 0)
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
                            pBE_Islas = new BE_Islas();
                            pBL_Islas = new BL_Islas();

                            pBE_Islas.ID = ID;
                            pBE_Islas.IDUsuarioModificacion = 1;

                            BL_Islas.ActualizarEstadoIslas(pBE_Islas);

                            Listar_Islas();
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

        private void frm_Islas_Activated(object sender, EventArgs e)
        {
            this.Listar_Islas();
        }

    }
}
