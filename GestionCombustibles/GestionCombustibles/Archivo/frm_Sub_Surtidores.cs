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
    public partial class frm_Sub_Surtidores : Form
    {
        private frm_Surtidores frmSurtidor = new frm_Surtidores();
        public int Dato { get; set; }

        BE_Surtidor pBE_surtidor = new BE_Surtidor();
        BL_Surtidor pBL_surtidor = new BL_Surtidor();

        public void Listar_Surtidores_x_ID()
        {
            List<BE_Surtidor> Listar_Surtidor_x_ID = new List<BE_Surtidor>();
            pBE_surtidor = new BE_Surtidor();
            pBL_surtidor = new BL_Surtidor();

            pBE_surtidor.ID = Convert.ToInt32(txt_Surtidor_ID.Text);

            Listar_Surtidor_x_ID = BL_Surtidor.Listar_Surtidor_x_ID(pBE_surtidor);

            txt_Surtidor_codigo.Text = Convert.ToString(Listar_Surtidor_x_ID[0].Str_cod_surtidor);
            txt_Surtidor_denominacion.Text = Convert.ToString(Listar_Surtidor_x_ID[0].Str_denominacion_surtidor);
        }
        public void Registrar_Surtidor()
        {
            int res = 0;
            pBE_surtidor = new BE_Surtidor();
            pBL_surtidor = new BL_Surtidor();

            pBE_surtidor.ID = Convert.ToInt32(txt_Surtidor_ID.Text);
            pBE_surtidor.Str_cod_surtidor = txt_Surtidor_codigo.Text;
            pBE_surtidor.Str_denominacion_surtidor = txt_Surtidor_denominacion.Text;

            if (Convert.ToInt32(txt_Surtidor_ID.Text) == 0)
            {
                pBE_surtidor.IDUsuarioCreacion = 1;
                res = BL_Surtidor.Registrar_Surtidor(pBE_surtidor);
            }
            else
            {
                pBE_surtidor.IDUsuarioModificacion = 1;
                res = BL_Surtidor.Actualizar_Surtidor(pBE_surtidor);
            }
        }

        public frm_Sub_Surtidores()
        {
            InitializeComponent();
        }
        private void frm_Sub_Surtidores_Load(object sender, EventArgs e)
        {
            txt_Surtidor_ID.Text = Dato.ToString();
            if (this.Dato > 0)
            {
                Listar_Surtidores_x_ID();
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Registrar_Surtidor();
            Archivo.frm_Surtidores F = new Archivo.frm_Surtidores();
            this.Close();
        }
        private void btn_descartar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
