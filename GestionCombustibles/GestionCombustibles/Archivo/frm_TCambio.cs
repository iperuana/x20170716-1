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

namespace GestionCombustibles
{
    public partial class frm_TCambio : Form
    {
        BE_Tipo_Cambio pBE_Tipo_Cambio = new BE_Tipo_Cambio();
        BL_Tipo_Cambio pBL_Tipo_Cambio = new BL_Tipo_Cambio();
        
        public void Listar_Tipos_Cambio()
        {
            List<BE_Tipo_Cambio> Lista_Tipo_Cambio = new List<BE_Tipo_Cambio>(); 
            pBE_Tipo_Cambio = new BE_Tipo_Cambio();
            pBL_Tipo_Cambio = new BL_Tipo_Cambio();

            Lista_Tipo_Cambio = BL_Tipo_Cambio.Listar_TipoCambio(pBE_Tipo_Cambio);

            gv_TCambio_Lista.AutoGenerateColumns = false;
            gv_TCambio_Lista.DataSource = Lista_Tipo_Cambio;
        }

        public void Listar_Tipo_Cambio_x_fecha()
        {
            List<BE_Tipo_Cambio> Lista_Tipo_Cambio = new List<BE_Tipo_Cambio>();
            pBE_Tipo_Cambio = new BE_Tipo_Cambio();
            pBL_Tipo_Cambio = new BL_Tipo_Cambio();

            pBE_Tipo_Cambio.Str_Fecha = txt_TCambio_Fecha.Text;

            Lista_Tipo_Cambio = BL_Tipo_Cambio.Listar_Tipo_Cambio_x_fecha(pBE_Tipo_Cambio);

            if (Lista_Tipo_Cambio.Count == 0){
                txt_ID.Text = "0";
                txt_TCambio_Compra.Text = "0.00";
                txt_TCambio_Venta.Text = "0.00";
            }
            else
            {
                txt_ID.Text = Convert.ToString(Lista_Tipo_Cambio[0].ID);
                txt_TCambio_Compra.Text = Convert.ToString(Lista_Tipo_Cambio[0].Dcm_Compra);
                txt_TCambio_Venta.Text = Convert.ToString(Lista_Tipo_Cambio[0].Dcm_Venta);
            }

        }
        public void Registrar_TCambio()
        {
            int res = 0;
            pBE_Tipo_Cambio = new BE_Tipo_Cambio();
            pBL_Tipo_Cambio = new BL_Tipo_Cambio();

            pBE_Tipo_Cambio.ID = Convert.ToInt32(txt_ID.Text);
            pBE_Tipo_Cambio.Str_Fecha = txt_TCambio_Fecha.Text;
            if (txt_TCambio_Compra.Text.Length==0)
            {
                pBE_Tipo_Cambio.Dcm_Compra = 0;
            }
            else
            {
                pBE_Tipo_Cambio.Dcm_Compra = Convert.ToDecimal(txt_TCambio_Compra.Text.Replace(".", ","));
               
            }
            if (txt_TCambio_Venta.Text.Length == 0)
            {
                pBE_Tipo_Cambio.Dcm_Venta = 0;
            }
            else
            { 
                pBE_Tipo_Cambio.Dcm_Venta = Convert.ToDecimal(txt_TCambio_Venta.Text.Replace(".", ","));
            }

            //pBE_Tipo_Cambio.Dcm_Compra = Convert.ToDecimal(txt_TCambio_Compra.Text);
            //pBE_Tipo_Cambio.Dcm_Venta = Convert.ToDecimal(txt_TCambio_Venta.Text);
            if (txt_ID.Text == "0")
            {
                res = BL_Tipo_Cambio.Registrar_Tipo_Cambio(pBE_Tipo_Cambio);
            }
            else
            {
                res = BL_Tipo_Cambio.Actualizar_Tipo_Cambio(pBE_Tipo_Cambio);
            }

            this.Listar_Tipos_Cambio();
            this.Listar_Tipo_Cambio_x_fecha();
        }

        public frm_TCambio()
        {
            InitializeComponent();
        }
        private void TCanbio_Load(object sender, EventArgs e)
        {
            txt_TCambio_Fecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txt_TCambio_Compra.Text = "0.00";
            txt_TCambio_Venta.Text = "0.00";
            this.Listar_Tipos_Cambio();
            this.Listar_Tipo_Cambio_x_fecha();
        }

        private void btn_TCambio_Descartar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_TCambio_Aceptar_Click(object sender, EventArgs e)
        {
            this.Registrar_TCambio();
        }

        private void txt_TCambio_Compra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_TCambio_Compra.Text.Contains('.'))
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

        private void txt_TCambio_Venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_TCambio_Venta.Text.Contains('.'))
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
