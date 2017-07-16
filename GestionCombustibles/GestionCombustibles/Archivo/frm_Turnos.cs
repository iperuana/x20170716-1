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
    public partial class frm_Turnos : Form
    {
        BE_Turnos pBE_Turnos = new BE_Turnos();
        BL_Turnos pBL_Turnos = new BL_Turnos();

        public void Listar_Turnos()
        {
            List<BE_Turnos> Listar_Turnos = new List<BE_Turnos>();
            pBE_Turnos = new BE_Turnos();
            pBL_Turnos = new BL_Turnos();
            if ((mtb_Turno_inicio.Text).Trim() != ":")
            {
                pBE_Turnos.Str_inicio_buscar = Convert.ToString(mtb_Turno_inicio.Text);
            }
            if ((mtb_Turno_fin.Text).Trim() != ":")
            {
                pBE_Turnos.Str_fin_buscar = Convert.ToString(mtb_Turno_fin.Text);
            }

            Listar_Turnos = BL_Turnos.Listar_Turnos(pBE_Turnos);
         
            gv_Lista_Turnos.AutoGenerateColumns = false;
            gv_Lista_Turnos.DataSource = Listar_Turnos;
            gv_Lista_Turnos.ClearSelection();

        }

        public frm_Turnos()
        {
            InitializeComponent();
        }
        private void frm_Turnos_Load(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(0);
            this.Listar_Turnos();
        }

        private void gv_Lista_Turnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gv_Lista_Turnos.RowCount > 0)
            {
                DataGridViewRow row = gv_Lista_Turnos.CurrentRow;
                int valor = Convert.ToInt32(row.Cells["ID"].Value);
                label2.Text = Convert.ToString(valor);
            }
        }
    
        private void btn_Turnos_Buscar_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(0);
            this.Listar_Turnos();
        }
        private void btn_Turnos_Nuevo_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(0);
            frm_Sub_Turnos fr = new frm_Sub_Turnos();
            fr.ShowDialog();
        }
        private void btn_Turnos_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gv_Lista_Turnos.RowCount > 0)
                {
                    int ID = Convert.ToInt16(label2.Text);
                    if (ID == 0)
                    {
                        MessageBox.Show("Seleecione fila");
                    }
                    else
                    {
                        label2.Text = Convert.ToString(0);
                        frm_Sub_Turnos FrmSub = new frm_Sub_Turnos();
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
                if (gv_Lista_Turnos.RowCount > 0)
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
                            pBE_Turnos = new BE_Turnos();
                            pBL_Turnos = new BL_Turnos();

                            pBE_Turnos.ID = ID;
                            pBE_Turnos.IDUsuarioModificacion = 1;

                            BL_Turnos.ActualizarEstadoTurnos(pBE_Turnos);

                            Listar_Turnos();
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

        private void frm_Turnos_Activated(object sender, EventArgs e)
        {
            this.Listar_Turnos();
        }
    }
}
