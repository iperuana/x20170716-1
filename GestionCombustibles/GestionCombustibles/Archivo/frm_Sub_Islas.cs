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
using System.Data.SqlClient;

namespace GestionCombustibles.Archivo
{
    public partial class frm_Sub_Islas : Form
    {
        private frm_Islas frmIslas = new frm_Islas();
        public int Dato { get; set; }

        BE_Islas pBE_Islas = new BE_Islas();
        BL_Islas pBL_Islas = new BL_Islas();

        public void Listar_Islas_x_ID()
        {
            List<BE_Islas> Listar_Islas_x_ID = new List<BE_Islas>();
            pBE_Islas = new BE_Islas();
            pBL_Islas = new BL_Islas();

            pBE_Islas.ID = Convert.ToInt32(txt_Islas_ID.Text);

            Listar_Islas_x_ID = BL_Islas.Listar_Islas_x_ID(pBE_Islas);

            txt_Surtidor_codigo.Text = Convert.ToString(Listar_Islas_x_ID[0].Str_cod_isla);
            txt_Surtidor_denominacion.Text = Convert.ToString(Listar_Islas_x_ID[0].Str_denominacion_isla);

        }

        public void Registrar_Islas()
        {
            int res = 0;
            pBE_Islas = new BE_Islas();
            pBL_Islas = new BL_Islas();

            pBE_Islas.ID = Convert.ToInt32(txt_Islas_ID.Text);
            pBE_Islas.Str_cod_isla = txt_Surtidor_codigo.Text;
            pBE_Islas.Str_denominacion_isla = txt_Surtidor_denominacion.Text;

            if (Convert.ToInt32(txt_Islas_ID.Text) == 0)
            {
                pBE_Islas.IDUsuarioCreacion = 1;
                res = BL_Islas.Registrar_Islas(pBE_Islas);
            }
            else
            {
                pBE_Islas.IDUsuarioModificacion = 1;
                res = BL_Islas.Actualizar_Islas(pBE_Islas);
            }
        }
        public frm_Sub_Islas()
        {
            InitializeComponent();
        }

        private void frm_Sub_Islas_Load(object sender, EventArgs e)
        {
            txt_Islas_ID.Text = Dato.ToString();
            if (this.Dato > 0)
            {
                Listar_Islas_x_ID();
            }
        }

        private void btn_Islas_Aceptar_Click(object sender, EventArgs e)
        {
            this.Registrar_Islas();
            Archivo.frm_Islas F = new Archivo.frm_Islas();
            this.Close();
        }
    }
}
