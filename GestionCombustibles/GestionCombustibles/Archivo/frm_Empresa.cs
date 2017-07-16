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
    public partial class frm_Empresa : Form
    {
        BE_Empresa pBE_Empresa = new BE_Empresa();
        BL_Empresa pBL_Empresa = new BL_Empresa();

        public void Listar_Empresa()
        {
            List<BE_Empresa> Listar_Empresa = new List<BE_Empresa>();
            pBE_Empresa = new BE_Empresa();
            pBL_Empresa = new BL_Empresa();

            pBE_Empresa.Str_texto_buscar = Convert.ToString(txt_buscar.Text);
            Listar_Empresa = BL_Empresa.Listar_Empresa(pBE_Empresa);

            gv_Empresa_Lista.AutoGenerateColumns = false;
            gv_Empresa_Lista.DataSource = Listar_Empresa;
            gv_Empresa_Lista.ClearSelection();
        }

        public frm_Empresa()
        {
            InitializeComponent();
        }
        private void Empresa_Load(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(0);
            this.Listar_Empresa();
        }

        private void gv_Empresa_Lista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gv_Empresa_Lista.RowCount > 0)
            {
                DataGridViewRow row = gv_Empresa_Lista.CurrentRow;
                int valor = Convert.ToInt32(row.Cells["ID"].Value);
                label2.Text = Convert.ToString(valor);
            }
        }

        private void btn_Empresa_Buscar_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(0);
            this.Listar_Empresa();
        }
        private void btn_Empresa_Nuevo_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(0);
            frm_Sub_Empresa fr = new frm_Sub_Empresa();
            fr.ShowDialog();
        }
        private void btn_Empresa_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gv_Empresa_Lista.RowCount > 0)
                {
                    int ID = Convert.ToInt16(label2.Text);
                    if (ID == 0)
                    {
                        MessageBox.Show("Seleecione fila");
                    }
                    else
                    {
                        label2.Text = Convert.ToString(0);
                        frm_Sub_Empresa FrmSub = new frm_Sub_Empresa();
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
        private void btn_Empresa_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gv_Empresa_Lista.RowCount > 0)
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
                            pBE_Empresa = new BE_Empresa();
                            pBL_Empresa = new BL_Empresa();

                            pBE_Empresa.ID = ID;
                            pBE_Empresa.IDUsuarioModificacion = 1;

                            BL_Empresa.ActualizarEstadoEmpresa(pBE_Empresa);

                            Listar_Empresa();
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

        private void Empresa_Activated(object sender, EventArgs e)
        {
            this.Listar_Empresa();
        }

        private void gv_Empresa_Lista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}