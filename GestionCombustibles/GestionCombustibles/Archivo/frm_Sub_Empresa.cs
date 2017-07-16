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
    public partial class frm_Sub_Empresa : Form
    {
        BE_Departamento pBE_departamento = new BE_Departamento();
        BL_Departamento pBL_departamento = new BL_Departamento();
        BE_Provincia pBE_Provincia = new BE_Provincia();
        BL_Provincia pBL_Provincia = new BL_Provincia();
        BE_Distrito pBE_Distrito = new BE_Distrito();
        BL_Distrito pBL_Distrito = new BL_Distrito();
        BE_Empresa pBE_Empresa = new BE_Empresa();
        BL_Empresa pBL_Empresa = new BL_Empresa();

        public int Dato { get; set; }

        public frm_Sub_Empresa()
        {
            InitializeComponent();
        }
       
        public void Listar_Departamento()
        {
            List<BE_Departamento> Lista_Departamento = new List<BE_Departamento>();
            pBE_departamento = new BE_Departamento();
            pBL_departamento = new BL_Departamento();

            Lista_Departamento = BL_Departamento.Listar_Departamento_Desp(pBE_departamento);

            cbo_Empresa_Departamento.ValueMember = "ID";
            cbo_Empresa_Departamento.DisplayMember = "Str_Departamento";
            cbo_Empresa_Departamento.DataSource = Lista_Departamento;
        }
        public void Listar_Provincia(int id_departamento)
        {
            List<BE_Provincia> Listar_Provincia = new List<BE_Provincia>();
            pBE_Provincia = new BE_Provincia();
            pBL_Provincia = new BL_Provincia();

            pBE_Provincia.oBE_Departamento = new BE_Departamento();
            pBE_Provincia.oBE_Departamento.ID = id_departamento;

            Listar_Provincia = BL_Provincia.Listar_Provincia_Desp(pBE_Provincia);

            cbo_Empresa_Provincia.ValueMember = "ID";
            cbo_Empresa_Provincia.DisplayMember = "Str_Provincia";
            cbo_Empresa_Provincia.DataSource = Listar_Provincia;
        }
        public void Listar_Distrito(int id_provincia)
        {
            List<BE_Distrito> Listar_Distrito = new List<BE_Distrito>();
            pBE_Distrito = new BE_Distrito();
            pBL_Distrito = new BL_Distrito();

            pBE_Distrito.oBE_Provincia = new BE_Provincia();
            pBE_Distrito.oBE_Provincia.ID = id_provincia;

            Listar_Distrito = BL_Distrito.Listar_Distrito_Desp(pBE_Distrito);

            cbo_Empresa_Distrito.ValueMember = "ID";
            cbo_Empresa_Distrito.DisplayMember = "Str_Distrito";
            cbo_Empresa_Distrito.DataSource = Listar_Distrito;
        }

        public void Listar_Empresa_x_ID()
        {
            List<BE_Empresa> Listar_Empresa_x_ID = new List<BE_Empresa>();
            pBE_Empresa = new BE_Empresa();
            pBL_Empresa = new BL_Empresa();

            pBE_Empresa.ID = Convert.ToInt32(txt_Empresa_Codigo.Text);

            Listar_Empresa_x_ID = BL_Empresa.Listar_Empresa_x_ID(pBE_Empresa);

            txt_Empresa_Codigo.Text = Convert.ToString(Listar_Empresa_x_ID[0].ID);
                        
            txt_Empresa_Documento.Text = Convert.ToString(Listar_Empresa_x_ID[0].Str_num_documento);
            txt_Empresa_RSocial.Text = Convert.ToString(Listar_Empresa_x_ID[0].Str_nom_empresa);
            txt_Empresa_Direccion.Text = Convert.ToString(Listar_Empresa_x_ID[0].Str_direccion_empresa);
            cbo_Empresa_Departamento.Text = Convert.ToString(Listar_Empresa_x_ID[0].oBE_Departamento.Str_Departamento);
            cbo_Empresa_Provincia.Text = Convert.ToString(Listar_Empresa_x_ID[0].oBE_Provincia.Str_Provincia);
            cbo_Empresa_Distrito.Text = Convert.ToString(Listar_Empresa_x_ID[0].oBE_Distrito.Str_Distrito);
            txt_Empresa_UbiGeo.Text = Convert.ToString(Listar_Empresa_x_ID[0].Str_ubigeo);         
        }

        public void Registrar_Empresa()
        {
            int res = 0;
            pBE_Empresa = new BE_Empresa();
            pBL_Empresa = new BL_Empresa();
            pBE_Empresa.ID = Convert.ToInt32(txt_Empresa_Codigo.Text);
            pBE_Empresa.Str_num_documento = txt_Empresa_Documento.Text;
            pBE_Empresa.Str_nom_empresa = txt_Empresa_RSocial.Text;
            pBE_Empresa.Str_direccion_empresa = txt_Empresa_Direccion.Text;
            pBE_Empresa.oBE_Departamento.ID = Convert.ToInt16(cbo_Empresa_Departamento.SelectedValue);
            pBE_Empresa.oBE_Provincia.ID = Convert.ToInt32(cbo_Empresa_Provincia.SelectedValue);
            pBE_Empresa.oBE_Distrito.ID = Convert.ToInt32(cbo_Empresa_Distrito.SelectedValue);
            pBE_Empresa.Str_ubigeo = txt_Empresa_UbiGeo.Text;            
            if (Convert.ToInt32(txt_Empresa_Codigo.Text) == 0)
            {
                pBE_Empresa.IDUsuarioCreacion = 1;
                res = BL_Empresa.Registrar_Empresa(pBE_Empresa);
            }
            else
            {
                pBE_Empresa.IDUsuarioModificacion = 1;
                res = BL_Empresa.Actualizar_Empresa(pBE_Empresa);
            }
        }

        private void btn_descartar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbo_departamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id_departamento = Convert.ToInt32(cbo_Empresa_Departamento.SelectedValue);
            this.Listar_Provincia(id_departamento);

            cbo_Empresa_Provincia.SelectedIndex = 0;
        }

        private void cbo_provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id_Provincia = Convert.ToInt32(cbo_Empresa_Provincia.SelectedValue);
            this.Listar_Distrito(id_Provincia);

            cbo_Empresa_Distrito.SelectedIndex = 0;
        }

        private void Sub_Empresa_Load(object sender, EventArgs e)
        {
            this.Listar_Departamento();
            cbo_Empresa_Departamento.SelectedIndex = 0;

            txt_Empresa_Codigo.Text = Dato.ToString();
            if (this.Dato > 0)
            {
                Listar_Empresa_x_ID();
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Registrar_Empresa();
            this.Close();
        }

    
    }
}
