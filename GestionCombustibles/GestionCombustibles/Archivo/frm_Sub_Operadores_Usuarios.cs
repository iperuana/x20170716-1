using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento;
using Informatica_Peruana.SGC.BL_Sistema_SGC.Mantenimiento;

namespace GestionCombustibles.Archivo
{
    public partial class frm_Sub_Operadores_Usuarios : Form
    {
        BE_Nivel pBE_Nivel = new BE_Nivel();
        BL_Nivel pBL_Nivel = new BL_Nivel();
        BE_Operador_Usuario pBE_Operador_Usuario = new BE_Operador_Usuario();
        BL_Operador_Usuario pBL_Operador_Usuario = new BL_Operador_Usuario();

        public int Dato { get; set; }

        public void Listar_Nivel()
        {
            List<BE_Nivel> Lista_Nivel = new List<BE_Nivel>();
            pBE_Nivel = new BE_Nivel();
            pBL_Nivel = new BL_Nivel();

            Lista_Nivel = BL_Nivel.Listar_Nivel(pBE_Nivel);

            cbo_Operador_nivel.ValueMember = "ID";
            cbo_Operador_nivel.DisplayMember = "Str_Desc_Nivel";
            cbo_Operador_nivel.DataSource = Lista_Nivel;
        }
        public void Listar_Operador_Usuario_x_ID()
        {
            List<BE_Operador_Usuario> Listar_Operador_Usuario_x_ID = new List<BE_Operador_Usuario>();
            pBE_Operador_Usuario = new BE_Operador_Usuario();
            pBL_Operador_Usuario = new BL_Operador_Usuario();

            pBE_Operador_Usuario.ID = Convert.ToInt32(txt_Operador_ID.Text);

            Listar_Operador_Usuario_x_ID = BL_Operador_Usuario.Listar_Operador_Usuario_x_ID(pBE_Operador_Usuario);

            txt_Operador_codigo.Text = Convert.ToString(Listar_Operador_Usuario_x_ID[0].Str_Cod_Operador_Usuario);
            txt_Operador_nombre.Text = Convert.ToString(Listar_Operador_Usuario_x_ID[0].Str_Nombre_Operador_Usuario);
            cbo_Operador_nivel.Text = Listar_Operador_Usuario_x_ID[0].oBE_Nivel.Str_Desc_Nivel;
        }

        public void Registrar_Nivel()
        {
            int res = 0;
            pBE_Operador_Usuario = new BE_Operador_Usuario();
            pBL_Operador_Usuario = new BL_Operador_Usuario();

            pBE_Operador_Usuario.ID = Convert.ToInt32(txt_Operador_ID.Text);
            pBE_Operador_Usuario.Str_Cod_Operador_Usuario = Convert.ToString(txt_Operador_codigo.Text);
            pBE_Operador_Usuario.Str_Nombre_Operador_Usuario = Convert.ToString(txt_Operador_nombre.Text);
            pBE_Operador_Usuario.oBE_Nivel.ID = Convert.ToInt32(cbo_Operador_nivel.SelectedValue);

            if (Convert.ToInt32(txt_Operador_ID.Text) == 0)
            {
                pBE_Operador_Usuario.IDUsuarioCreacion = 1;
                res = BL_Operador_Usuario.Registrar_Operador_Usuario(pBE_Operador_Usuario);
            }
            else
            {
                pBE_Operador_Usuario.IDUsuarioModificacion = 1;
                res = BL_Operador_Usuario.Actualizar_Operador_Usuario(pBE_Operador_Usuario);
            }
        }
        
        public frm_Sub_Operadores_Usuarios()
        {
            InitializeComponent();
        }
        private void frm_Sub_Operadores_Usuarios_Load(object sender, EventArgs e)
        {
            this.Listar_Nivel();
            txt_Operador_ID.Text = Dato.ToString();
            if (this.Dato > 0)
            {
                Listar_Operador_Usuario_x_ID();
            }
        }

        private void btn_Operador_aceptar_Click(object sender, EventArgs e)
        {
            this.Registrar_Nivel();
            Close();
        }
        private void btn_Operador_Descartar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
