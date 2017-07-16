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

    public partial class frm_Sub_Correlativo_de_Documentos : Form
    {
        public int Dato { get; set; }

        BE_Documentos pBE_Documentos = new BE_Documentos();
        BL_Documentos pBL_Documentos = new BL_Documentos();

        public void Listar_Documentos_x_ID()
        {
            List<BE_Documentos> Lista_Documentos = new List<BE_Documentos>();
            pBE_Documentos = new BE_Documentos();
            pBL_Documentos = new BL_Documentos();

            pBE_Documentos.ID = Convert.ToInt32(txt_Documentos_ID.Text);

            Lista_Documentos = BL_Documentos.Listar_Documentos_x_ID(pBE_Documentos);

            txt_Documentos_Codigo.Text = Convert.ToString(Lista_Documentos[0].Str_cod_documento);
            txt_Documentos_Denominacion.Text = Convert.ToString(Lista_Documentos[0].Str_deno_documento);
            txt_Documentos_Numero.Text = Convert.ToString(Lista_Documentos[0].Str_num_documento);
            txt_Documentos_Serie.Text = Convert.ToString(Lista_Documentos[0].Str_serie_documento);
        }

        public frm_Sub_Correlativo_de_Documentos()
        {
            InitializeComponent();
        }
        private void Sub_Correlativo_de_Documentos_Load(object sender, EventArgs e)
        {
            txt_Documentos_ID.Text = Dato.ToString();
            if (this.Dato > 0)
            {
                Listar_Documentos_x_ID();
            }
        }
        
        public void Registrar_Documentos()
        {
            int res = 0;
            pBE_Documentos = new BE_Documentos();
            pBL_Documentos = new BL_Documentos();

            pBE_Documentos.ID = Convert.ToInt32(txt_Documentos_ID.Text);
            pBE_Documentos.Str_cod_documento = txt_Documentos_Codigo.Text;
            pBE_Documentos.Str_deno_documento = txt_Documentos_Denominacion.Text;
            pBE_Documentos.Str_num_documento = txt_Documentos_Numero.Text;
            pBE_Documentos.Str_serie_documento = txt_Documentos_Serie.Text;
            if (Convert.ToInt32(txt_Documentos_ID.Text) == 0)
            {
                pBE_Documentos.IDUsuarioCreacion = 1;
                res = BL_Documentos.Registrar_Documentos(pBE_Documentos);
            }
            else
            {
                pBE_Documentos.IDUsuarioModificacion = 1;
                res = BL_Documentos.Actualizar_Documentos(pBE_Documentos);
            }
        }

        private void btn_Documentos_Aceptar_Click(object sender, EventArgs e)
        {
            Registrar_Documentos();
            this.Close();
        }
        private void btn_Documentos_Descartar_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
        private void txt_Documentos_Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_Documentos_Numero.Text.Contains('.'))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' || e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
        }
    }
}
