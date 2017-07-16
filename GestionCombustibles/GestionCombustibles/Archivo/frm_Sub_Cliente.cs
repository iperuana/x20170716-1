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
    public partial class frm_Sub_Cliente : Form
    {
        BE_Departamento pBE_departamento = new BE_Departamento();
        BL_Departamento pBL_departamento = new BL_Departamento();
        BE_Provincia pBE_Provincia = new BE_Provincia();
        BL_Provincia pBL_Provincia = new BL_Provincia();
        BE_Distrito pBE_Distrito = new BE_Distrito();
        BL_Distrito pBL_Distrito = new BL_Distrito();
        BE_Tipo_Documento pBE_Tipo_Documento = new BE_Tipo_Documento();
        BL_Tipo_Documento pBL_Tipo_Documento = new BL_Tipo_Documento();
        BE_clientes pBE_clientes = new BE_clientes();
        BL_Clientes pBL_clientes = new BL_Clientes();
        BE_Nivel_Dcto_Clientes pBE_Nivel_Dcto_Clientes = new BE_Nivel_Dcto_Clientes();

        public int Dato { get; set; }
        //public List<BE_Nivel_Dcto_Clientes> Pub_Lista_Nivel_Dcto();

        public void Listar_Tipo_Documento()
        {
            List<BE_Tipo_Documento> Lista_Tipo_Documento = new List<BE_Tipo_Documento>();
            pBE_Tipo_Documento = new BE_Tipo_Documento();
            pBL_Tipo_Documento = new BL_Tipo_Documento();

            Lista_Tipo_Documento = BL_Tipo_Documento.Listar_Tipo_Documento(pBE_Tipo_Documento);

            cbo_Clientes_Documento.ValueMember = "ID";
            cbo_Clientes_Documento.DisplayMember = "Str_abrev_tipo_documento";
            cbo_Clientes_Documento.DataSource = Lista_Tipo_Documento;
        }
        public void Listar_Departamento()
        {
            List<BE_Departamento> Lista_Departamento = new List<BE_Departamento>();
            pBE_departamento = new BE_Departamento();
            pBL_departamento = new BL_Departamento();

            Lista_Departamento = BL_Departamento.Listar_Departamento_Desp(pBE_departamento);

            cbo_Clientes_Departamento.ValueMember = "ID";
            cbo_Clientes_Departamento.DisplayMember = "Str_Departamento";
            cbo_Clientes_Departamento.DataSource = Lista_Departamento;
        }
        public void Listar_Provincia(int id_departamento)
        {
            List<BE_Provincia> Listar_Provincia = new List<BE_Provincia>();
            pBE_Provincia = new BE_Provincia();
            pBL_Provincia = new BL_Provincia();

            pBE_Provincia.oBE_Departamento = new BE_Departamento();
            pBE_Provincia.oBE_Departamento.ID = id_departamento;

            Listar_Provincia = BL_Provincia.Listar_Provincia_Desp(pBE_Provincia);

            cbo_Clientes_Provincia.ValueMember = "ID";
            cbo_Clientes_Provincia.DisplayMember = "Str_Provincia";
            cbo_Clientes_Provincia.DataSource = Listar_Provincia;
        }
        public void Listar_Distrito(int id_provincia)
        {
            List<BE_Distrito> Listar_Distrito = new List<BE_Distrito>();
            pBE_Distrito = new BE_Distrito();
            pBL_Distrito = new BL_Distrito();

            pBE_Distrito.oBE_Provincia = new BE_Provincia();
            pBE_Distrito.oBE_Provincia.ID = id_provincia;

            Listar_Distrito = BL_Distrito.Listar_Distrito_Desp(pBE_Distrito);

            cbo_Clientes_Distrito.ValueMember = "ID";
            cbo_Clientes_Distrito.DisplayMember = "Str_Distrito";
            cbo_Clientes_Distrito.DataSource = Listar_Distrito;
        }
        public void Listar_Clientes_x_ID()
        {
            List<BE_clientes> Listar_Clientes_x_ID = new List<BE_clientes>();
            pBE_clientes = new BE_clientes();
            pBL_clientes = new BL_Clientes();

            pBE_clientes.ID = Convert.ToInt32(txt_Codigo_Cliente.Text);

            Listar_Clientes_x_ID = BL_Clientes.Listar_Clientes_x_ID(pBE_clientes);

            txt_Codigo_Cliente.Text = Convert.ToString(Listar_Clientes_x_ID[0].ID);

            cbo_Clientes_Documento.Text = Convert.ToString(Listar_Clientes_x_ID[0].oBE_Tipo_Documento.Str_abrev_tipo_documento);
            txt_Documento_Cliente.Text = Convert.ToString(Listar_Clientes_x_ID[0].Str_num_documento);
            txt_Clientes_RazonSocial.Text = Convert.ToString(Listar_Clientes_x_ID[0].Str_nom_cliente);
            txt_Clientes_Direccion.Text = Convert.ToString(Listar_Clientes_x_ID[0].Str_direccion_cliente);
            cbo_Clientes_Departamento.Text = Convert.ToString(Listar_Clientes_x_ID[0].oBE_Departamento.Str_Departamento);
            cbo_Clientes_Provincia.Text = Convert.ToString(Listar_Clientes_x_ID[0].oBE_Provincia.Str_Provincia);
            cbo_Clientes_Distrito.Text = Convert.ToString(Listar_Clientes_x_ID[0].oBE_Distrito.Str_Distrito);
            txt_Clientes_Ubigeo.Text = Convert.ToString(Listar_Clientes_x_ID[0].Str_v_ubigeo);
            if (Listar_Clientes_x_ID[0].Int_chk_promo_vigentes == 1) { chk_Clientes_ProVigentes.Checked = true; } else { chk_Clientes_ProVigentes.Checked = false; }
            if (Listar_Clientes_x_ID[0].Int_chk_aceptar_vtas_credito == 1) { chk_Clientes_VentaCredito.Checked = true; } else { chk_Clientes_VentaCredito.Checked = false; }
            txt_Clientes_LineaCredito.Text = Convert.ToString(Listar_Clientes_x_ID[0].Dcm_linea_credito);
            txt_Clientes_CreditoUtilizado.Text = Convert.ToString(Listar_Clientes_x_ID[0].Dcm_credito_utilizado);
            txt_Clientes_CreditoDisponible.Text = Convert.ToString(Listar_Clientes_x_ID[0].Dcm_credito_disponible);

            this.Listar_Nivel_Dcto_x_Cliente();
        }
        public void Listar_Nivel_Dcto_x_Cliente()
        {
            List<BE_Nivel_Dcto_Clientes> Lista_Nivel_Dcto_x_Cliente = new List<BE_Nivel_Dcto_Clientes>();
            pBE_Nivel_Dcto_Clientes = new BE_Nivel_Dcto_Clientes();

            pBE_Nivel_Dcto_Clientes.oBE_Cliente = new BE_clientes();
            pBE_Nivel_Dcto_Clientes.oBE_Cliente.ID = Convert.ToInt32(txt_Codigo_Cliente.Text);

            Lista_Nivel_Dcto_x_Cliente = BL_Nivel_Dcto_Clientes.Listar_Nivel_Dcto_x_Cliente(pBE_Nivel_Dcto_Clientes);

            int cont = 1;
            foreach (var item in Lista_Nivel_Dcto_x_Cliente)
            {
                item.Int_IDtemp = cont;
                cont++;
            }

            //Pub_Lista_Nivel_Dcto = Lista_Nivel_Dcto_x_Cliente;
            //gv_Clientes_NDescuento_Lista.AutoGenerateColumns = false;
            //gv_Clientes_NDescuento_Lista.DataSource = Pub_Lista_Nivel_Dcto;

        }
        public void Registrar_Clientes()
        {
            int res = 0;
            pBE_clientes = new BE_clientes();
            pBL_clientes = new BL_Clientes();
            pBE_clientes.ID = Convert.ToInt32(txt_Codigo_Cliente.Text);
            pBE_clientes.oBE_Tipo_Documento.ID = Convert.ToInt32(cbo_Clientes_Documento.SelectedValue);
            pBE_clientes.Str_num_documento = txt_Documento_Cliente.Text;
            pBE_clientes.Str_nom_cliente = txt_Clientes_RazonSocial.Text;
            pBE_clientes.Str_direccion_cliente = txt_Clientes_Direccion.Text;
            pBE_clientes.oBE_Departamento.ID = Convert.ToInt16(cbo_Clientes_Departamento.SelectedValue);
            pBE_clientes.oBE_Provincia.ID = Convert.ToInt32(cbo_Clientes_Provincia.SelectedValue);
            pBE_clientes.oBE_Distrito.ID = Convert.ToInt32(cbo_Clientes_Distrito.SelectedValue);
            pBE_clientes.Str_v_ubigeo = txt_Clientes_Ubigeo.Text;
            if (chk_Clientes_ProVigentes.Checked == true) { pBE_clientes.Int_chk_promo_vigentes = 1; } else { pBE_clientes.Int_chk_promo_vigentes = 0; }
            if (chk_Clientes_VentaCredito.Checked == true) { pBE_clientes.Int_chk_aceptar_vtas_credito = 1; } else { pBE_clientes.Int_chk_aceptar_vtas_credito = 0; }
            if (txt_Clientes_LineaCredito.Text.Length == 0)
            {
                pBE_clientes.Dcm_linea_credito = 0;
            }
            else
            {
                pBE_clientes.Dcm_linea_credito = Convert.ToDecimal(txt_Clientes_LineaCredito.Text.Replace(".", ","));
            }

            if (txt_Clientes_CreditoUtilizado.Text.Length == 0)
            {
                pBE_clientes.Dcm_credito_utilizado = 0;
            }
            else
            {
                pBE_clientes.Dcm_credito_utilizado = Convert.ToDecimal(txt_Clientes_CreditoUtilizado.Text.Replace(".", ","));
            }

            if (txt_Clientes_CreditoDisponible.Text.Length == 0)
            {
                pBE_clientes.Dcm_credito_disponible = 0;
            }
            else
            {
                pBE_clientes.Dcm_credito_disponible = Convert.ToDecimal(txt_Clientes_CreditoDisponible.Text.Replace(".", ","));
            }


            if (Convert.ToInt32(txt_Codigo_Cliente.Text) == 0)
            {
                pBE_clientes.IDUsuarioCreacion = 1;
                res = BL_Clientes.Registrar_clientes(pBE_clientes);
            }
            else
            {
                pBE_clientes.IDUsuarioModificacion = 1;
                res = BL_Clientes.Actualizar_clientes(pBE_clientes);
            }
        }

        public void Listar_Nivel_Dcto_Agregado(BE_Nivel_Dcto_Clientes pBE_Nivel_Dcto_Clientes)
        {
            //List<BE_Nivel_Dcto_Clientes> Lista_Nivel_Dcto_x_Cliente = new List<BE_Nivel_Dcto_Clientes>();
            //if (Pub_Lista_Nivel_Dcto.Count == 0)
            //{
            //    Pub_Lista_Nivel_Dcto = Lista_Nivel_Dcto_x_Cliente;
            //}
            //Lista_Nivel_Dcto_x_Cliente = Pub_Lista_Nivel_Dcto;
            //if (pBE_Nivel_Dcto_Clientes.Int_IDtemp == 0)
            //{
            //    pBE_Nivel_Dcto_Clientes.Int_IDtemp = Lista_Nivel_Dcto_x_Cliente.Count + 1;
            //    Lista_Nivel_Dcto_x_Cliente.Add(pBE_Nivel_Dcto_Clientes);
            //}
            //else
            //{
            //    (from p in Lista_Nivel_Dcto_x_Cliente where p.Int_IDtemp == pBE_Nivel_Dcto_Clientes.Int_IDtemp select p).ToList()
            //        .ForEach(x =>
            //        {
            //            x.Int_Tipo_Mantenimiento = pBE_Nivel_Dcto_Clientes.Int_Tipo_Mantenimiento;
            //            x.ID = pBE_Nivel_Dcto_Clientes.oBE_Producto.ID;
            //            x.Str_Nom_Producto = pBE_Nivel_Dcto_Clientes.oBE_Producto.Str_nom_producto;
            //            x.Dcm_cant_minima = pBE_Nivel_Dcto_Clientes.Dcm_cant_minima;
            //            x.Dcm_dto_cantidad = pBE_Nivel_Dcto_Clientes.Dcm_dto_cantidad;
            //        }
            //        );
            //}
            //Pub_Lista_Nivel_Dcto = Lista_Nivel_Dcto_x_Cliente;
            //this.Recarga();
        }
        public void Recarga()
        {
            //List<BE_Nivel_Dcto_Clientes> Lista_Nivel_Dcto_x_Cliente = new List<BE_Nivel_Dcto_Clientes>();
            //Lista_Nivel_Dcto_x_Cliente = Pub_Lista_Nivel_Dcto;

            //gv_Clientes_NDescuento_Lista.AutoGenerateColumns = false;
            //gv_Clientes_NDescuento_Lista.DataSource = Lista_Nivel_Dcto_x_Cliente;
        }



        public frm_Sub_Cliente()
        {
            InitializeComponent();
        }
        private void frm_Sub_Cliente_Load(object sender, EventArgs e)
        {
            //this.Pub_Lista_Nivel_Dcto = new List<BE_Nivel_Dcto_Clientes>();
            //Pub_Lista_Nivel_Dcto.Clear();
            this.Listar_Departamento();
            this.Listar_Tipo_Documento();
            txt_Codigo_Cliente.Text = Dato.ToString();
            cbo_Clientes_Departamento.SelectedIndex = 0;
            if (this.Dato > 0)
            {
                Listar_Clientes_x_ID();
            }
        }

        private void btn_Clientes_NDescuento_Nuevo_Click(object sender, EventArgs e)
        {
            SubNivelDcto SubNivel = new SubNivelDcto();
            SubNivel.Show();
        }

        private void btn_Clientes_NDescuento_Modificar_Click(object sender, EventArgs e)
        {

        }
        private void btn_Clientes_NDescuento_Eliminar_Click(object sender, EventArgs e)
        {

        }
        private void cbo_Clientes_Departamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id_departamento = Convert.ToInt32(cbo_Clientes_Departamento.SelectedValue);
            this.Listar_Provincia(id_departamento);

            cbo_Clientes_Provincia.SelectedIndex = 0;
        }
        private void cbo_Clientes_Provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id_Provincia = Convert.ToInt32(cbo_Clientes_Provincia.SelectedValue);
            this.Listar_Distrito(id_Provincia);

            cbo_Clientes_Distrito.SelectedIndex = 0;
        }
        private void btn_Clientes_Guardar_Click(object sender, EventArgs e)
        {
            this.Registrar_Clientes();
            this.Close();
        }

        private void frm_Sub_Cliente_Activated(object sender, EventArgs e)
        {
            this.Recarga();
        }

    }
}
