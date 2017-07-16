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
    public partial class frm_Surtidores : Form
    {

        BE_Surtidor pBE_surtidor = new BE_Surtidor();
        BL_Surtidor pBL_surtidor = new BL_Surtidor();

        public void Listar_Surtidor()
        {
            List<BE_Surtidor> Listar_Surtidor = new List<BE_Surtidor>();
            pBE_surtidor = new BE_Surtidor();
            pBL_surtidor = new BL_Surtidor();

            pBE_surtidor.Str_texto_buscar = Convert.ToString(txt_buscar.Text);
            Listar_Surtidor = BL_Surtidor.Listar_Surtidor(pBE_surtidor);

            gv_Lista_Surtidores.AutoGenerateColumns = false;
            gv_Lista_Surtidores.DataSource = Listar_Surtidor;
            gv_Lista_Surtidores.ClearSelection();

        }

        public frm_Surtidores()
        {
            InitializeComponent();
        }
        private void frm_Surtidores_Load(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(0);
            this.Listar_Surtidor();
        }

        private void gv_Lista_Surtidores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gv_Lista_Surtidores.RowCount > 0)
            {
                DataGridViewRow row = gv_Lista_Surtidores.CurrentRow;
                int valor = Convert.ToInt32(row.Cells["ID"].Value);
                label2.Text = Convert.ToString(valor);
            }
        }

        private void btn_Surtidores_Buscar_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(0);
            Listar_Surtidor();
        }
        private void btn_Surtidores_Nuevo_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(0);
            frm_Sub_Surtidores fr = new frm_Sub_Surtidores();
            fr.ShowDialog();
        }
        private void btn_Surtidores_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gv_Lista_Surtidores.RowCount > 0)
                {
                    int ID = Convert.ToInt16(label2.Text);
                    if (ID == 0)
                    {
                        MessageBox.Show("Seleecione fila");
                    }
                    else
                    {
                        label2.Text = Convert.ToString(0);
                        frm_Sub_Surtidores FrmSub = new frm_Sub_Surtidores();
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
        private void btn_Surtidores_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gv_Lista_Surtidores.RowCount > 0)
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
                            pBE_surtidor = new BE_Surtidor();
                            pBL_surtidor = new BL_Surtidor();

                            pBE_surtidor.ID = ID;
                            pBE_surtidor.IDUsuarioModificacion = 1;

                            BL_Surtidor.ActualizarEstadoSurtidor(pBE_surtidor);

                            Listar_Surtidor();
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

        private void frm_Surtidores_Activated(object sender, EventArgs e)
        {
            this.Listar_Surtidor();
        }
    }
}
