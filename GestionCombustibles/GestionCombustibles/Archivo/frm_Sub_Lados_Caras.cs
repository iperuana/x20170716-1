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
    public partial class frm_Sub_Lados_Caras : Form
    {
        public int Dato { get; set; }
        BE_Lados_Caras pBE_Lados_Caras = new BE_Lados_Caras();
        BL_Lados_Caras pBL_Lados_Caras = new BL_Lados_Caras();
        public void Listar_Lados_Caras_x_ID()
        {
            List<BE_Lados_Caras> Listar_Lados_Caras_x_ID = new List<BE_Lados_Caras>();
            pBE_Lados_Caras = new BE_Lados_Caras();
            pBL_Lados_Caras = new BL_Lados_Caras();

            pBE_Lados_Caras.ID = Convert.ToInt32(txt_Lados_Caras_id.Text);

            Listar_Lados_Caras_x_ID = BL_Lados_Caras.Listar_Lados_Caras_x_ID(pBE_Lados_Caras);

            txt_Lados_Caras_codigo.Text = Convert.ToString(Listar_Lados_Caras_x_ID[0].Str_cod_lados);
            txt_Lados_Caras_denominacion.Text = Convert.ToString(Listar_Lados_Caras_x_ID[0].Str_denominacion_lados);           
        }
        public void Registrar_Lados_Caras()
        {
            int res = 0;
            pBE_Lados_Caras = new BE_Lados_Caras();
            pBL_Lados_Caras = new BL_Lados_Caras();

            pBE_Lados_Caras.ID = Convert.ToInt32(txt_Lados_Caras_id.Text);
            pBE_Lados_Caras.Str_cod_lados = txt_Lados_Caras_codigo.Text;
            pBE_Lados_Caras.Str_denominacion_lados = txt_Lados_Caras_denominacion.Text;          

            if (Convert.ToInt32(txt_Lados_Caras_id.Text) == 0)
            {
                pBE_Lados_Caras.IDUsuarioCreacion = 1;
                res = BL_Lados_Caras.Registrar_Lados_Caras(pBE_Lados_Caras);
            }
            else
            {
                pBE_Lados_Caras.IDUsuarioModificacion = 1;
                res = BL_Lados_Caras.Actualizar_Lados_Caras(pBE_Lados_Caras);
            }
        }
        public frm_Sub_Lados_Caras()
        {
            InitializeComponent();
        }

        private void btn_descartar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Registrar_Lados_Caras();
            Archivo.frm_Lados_Caras F = new Archivo.frm_Lados_Caras();
            this.Close();
        }

        private void frm_Sub_Lados_Caras_Load(object sender, EventArgs e)
        {
            txt_Lados_Caras_id.Text = Dato.ToString();
            if (this.Dato > 0)
            {
                Listar_Lados_Caras_x_ID();
            }
        }
    }
}
