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
    public partial class frm_Lados_Caras : Form
    {
        BE_Lados_Caras pBE_Lados_Caras = new BE_Lados_Caras();
        BL_Lados_Caras pBL_Lados_Caras = new BL_Lados_Caras();
        public void Listar_Lados_Caras()
        {
            List<BE_Lados_Caras> Listar_Lados_Caras = new List<BE_Lados_Caras>();
            pBE_Lados_Caras = new BE_Lados_Caras();
            pBL_Lados_Caras = new BL_Lados_Caras();
            pBE_Lados_Caras.Str_texto_buscar = Convert.ToString(txt_buscar.Text);

            pBE_Lados_Caras.Str_texto_buscar = Convert.ToString(txt_buscar.Text);
            Listar_Lados_Caras = BL_Lados_Caras.Listar_Lados_Caras(pBE_Lados_Caras);

            gv_LadosCaras_Lista.AutoGenerateColumns = false;
            gv_LadosCaras_Lista.DataSource = Listar_Lados_Caras;
            gv_LadosCaras_Lista.ClearSelection();
        }

        public frm_Lados_Caras()
        {
            InitializeComponent();
        }
        private void frm_Lados_Caras_Load(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(0);
            this.Listar_Lados_Caras();
        }

        private void gv_LadosCaras_Lista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gv_LadosCaras_Lista.RowCount > 0)
            {
                DataGridViewRow row = gv_LadosCaras_Lista.CurrentRow;
                int valor = Convert.ToInt32(row.Cells["ID"].Value);
                label2.Text = Convert.ToString(valor);
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(0);
            Listar_Lados_Caras();
        }
        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(0);
            frm_Sub_Lados_Caras fr = new frm_Sub_Lados_Caras();
            fr.ShowDialog();
        }
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gv_LadosCaras_Lista.RowCount > 0)
                {
                    int ID = Convert.ToInt16(label2.Text);
                    if (ID == 0)
                    {
                        MessageBox.Show("Seleecione fila");
                    }
                    else
                    {
                        label2.Text = Convert.ToString(0);
                        frm_Sub_Lados_Caras FrmSub = new frm_Sub_Lados_Caras();
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
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gv_LadosCaras_Lista.RowCount > 0)
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
                            pBE_Lados_Caras = new BE_Lados_Caras();
                            pBL_Lados_Caras = new BL_Lados_Caras();

                            pBE_Lados_Caras.ID = ID;
                            pBE_Lados_Caras.IDUsuarioModificacion = 1;

                            BL_Lados_Caras.ActualizarEstadoLadosCaras(pBE_Lados_Caras);

                            Listar_Lados_Caras();
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

        private void frm_Lados_Caras_Activated(object sender, EventArgs e)
        {
            this.Listar_Lados_Caras();
        }
    }
}
