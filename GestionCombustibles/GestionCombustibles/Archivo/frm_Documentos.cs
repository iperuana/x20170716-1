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
    public partial class frm_Documentos : Form
    {
        BE_Documentos pBE_Documentos = new BE_Documentos();
        BL_Documentos pBL_Documentos = new BL_Documentos();

        public void Listar_Documentos()
        {
            List<BE_Documentos> Lista_Documentos = new List<BE_Documentos>();
            pBE_Documentos = new BE_Documentos();
            pBL_Documentos = new BL_Documentos();

            pBE_Documentos.Str_texto_buscar = Convert.ToString(txt_Documentos_buscar.Text);
            Lista_Documentos = BL_Documentos.Listar_Documentos(pBE_Documentos);

            gv_Documentos_Lista.AutoGenerateColumns = false;
            gv_Documentos_Lista.DataSource = Lista_Documentos;
            gv_Documentos_Lista.ClearSelection();
        }

        public frm_Documentos()
        {
            InitializeComponent();
        }
        private void frm_Documentos_Load(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(0);
            this.Listar_Documentos();
        }

        private void gv_Documentos_Lista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gv_Documentos_Lista.RowCount > 0)
            {
                DataGridViewRow row = gv_Documentos_Lista.CurrentRow;
                int valor = Convert.ToInt32(row.Cells["ID"].Value);
                label2.Text = Convert.ToString(valor);
            }
        }

        private void btn_Documentos_buscar_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(0);
            this.Listar_Documentos();
        }
        private void btn_Documentos_Nuevo_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(0);
            frm_Sub_Correlativo_de_Documentos fr = new frm_Sub_Correlativo_de_Documentos();
            fr.ShowDialog();
        }
        private void btn_Documentos_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gv_Documentos_Lista.RowCount > 0)
                {
                    int ID = Convert.ToInt16(label2.Text);
                    if (ID == 0)
                    {
                        MessageBox.Show("Seleecione fila");
                    }
                    else
                    {
                        label2.Text = Convert.ToString(0);
                        frm_Sub_Correlativo_de_Documentos FrmSub = new frm_Sub_Correlativo_de_Documentos();
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
        private void btn_Documentos_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gv_Documentos_Lista.RowCount > 0)
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
                            pBE_Documentos = new BE_Documentos();
                            pBL_Documentos = new BL_Documentos();

                            pBE_Documentos.ID = ID;
                            pBE_Documentos.IDUsuarioModificacion = 1;

                            BL_Documentos.ActualizarEstadoDocumento(pBE_Documentos);

                            Listar_Documentos();
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

        private void frm_Documentos_Activated(object sender, EventArgs e)
        {
            this.Listar_Documentos();
        }
    }
}
