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
    public partial class frm_Sub_Usuario : Form
    {
        BE_Tipo_Perfil pBE_Tipo_Perfil = new BE_Tipo_Perfil();
        BL_Tipo_Perfil pBL_Tipo_Perfil = new BL_Tipo_Perfil();
        BE_Usuarios pBE_Usuarios = new BE_Usuarios();
        BL_Usuarios pBL_Usuarios = new BL_Usuarios();
        public int Dato { get; set; }
        public frm_Sub_Usuario()
        {
            InitializeComponent();
        }
        public void Listar_Tipo_Perfil()
        {
            List<BE_Tipo_Perfil> Lista_Tipo_Perfil = new List<BE_Tipo_Perfil>();
            pBE_Tipo_Perfil = new BE_Tipo_Perfil();
            pBL_Tipo_Perfil = new BL_Tipo_Perfil();

            Lista_Tipo_Perfil = BL_Tipo_Perfil.Listar_Tipo_Perfil_Desp(pBE_Tipo_Perfil);

            cbo_Usuario_Tipo_Perfil.ValueMember = "ID";
            cbo_Usuario_Tipo_Perfil.DisplayMember = "Str_Tipo_Perfil";
            cbo_Usuario_Tipo_Perfil.DataSource = Lista_Tipo_Perfil;
        }
        public void Listar_Usuarios_x_ID()
        {
            List<BE_Usuarios> Listar_Usuarios_x_ID = new List<BE_Usuarios>();
            pBE_Usuarios = new BE_Usuarios();
            pBL_Usuarios = new BL_Usuarios();

            pBE_Usuarios.ID = Convert.ToInt32(txt_Usuario_Codigo.Text);

            Listar_Usuarios_x_ID = BL_Usuarios.Listar_Usuarios_x_ID(pBE_Usuarios);

            txt_Usuario_Codigo.Text = Convert.ToString(Listar_Usuarios_x_ID[0].ID);

            txt_Usuario_Nombre.Text = Convert.ToString(Listar_Usuarios_x_ID[0].Str_Nom_Usuario);
            txt_Usuario_usuario.Text = Convert.ToString(Listar_Usuarios_x_ID[0].Str_Usuario);
            txt_Usuario_Clave.Text = Convert.ToString(Listar_Usuarios_x_ID[0].Str_Clave_Usuario);
            cbo_Usuario_Tipo_Perfil.Text = Convert.ToString(Listar_Usuarios_x_ID[0].oBE_Tipo_Perfil.Str_Tipo_Perfil);
        }       
        public void Registrar_Usuario()
        {
            int res = 0;
            pBE_Usuarios = new BE_Usuarios();
            pBL_Usuarios = new BL_Usuarios();
            pBE_Usuarios.ID = Convert.ToInt32(txt_Usuario_Codigo.Text);
            pBE_Usuarios.Str_Nom_Usuario = txt_Usuario_Nombre.Text;
            pBE_Usuarios.Str_Usuario = txt_Usuario_usuario.Text;
            pBE_Usuarios.Str_Clave_Usuario = txt_Usuario_Clave.Text;
            pBE_Usuarios.oBE_Tipo_Perfil = new BE_Tipo_Perfil();
            pBE_Usuarios.oBE_Tipo_Perfil.ID = Convert.ToInt16(cbo_Usuario_Tipo_Perfil.SelectedValue);           
            if (Convert.ToInt32(txt_Usuario_Codigo.Text) == 0)
            {
                pBE_Usuarios.IDUsuarioCreacion = 1;
                res = BL_Usuarios.Registrar_Usuarios(pBE_Usuarios);
            }
            else
            {
                pBE_Usuarios.IDUsuarioModificacion = 1;
                res = BL_Usuarios.Actualizar_Usuario(pBE_Usuarios);
            }
        }
        private void frm_Sub_Usuario_Load(object sender, EventArgs e)
        {
            this.Listar_Tipo_Perfil();
            cbo_Usuario_Tipo_Perfil.SelectedIndex = 0;

            txt_Usuario_Codigo.Text = Dato.ToString();
            if (this.Dato > 0)
            {
                Listar_Usuarios_x_ID();
            }
        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Registrar_Usuario();
            this.Close();
        }
        private void btn_descartar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbo_Usuario_Tipo_Perfil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
