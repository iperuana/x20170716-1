using Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento;
using Informatica_Peruana.SGC.BL_Sistema_SGC.Mantenimiento;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace GestionCombustibles.Archivo
{
    public partial class frm_Cliente : Form
    {
        public BE_clientes pBE_Clientes = new BE_clientes();
        private BL_Clientes pBL_Clientes = new BL_Clientes();
        private int _tipo = 0;

        public void Listar_Clientes()
        {
            List<BE_clientes> Listar_Clientes = new List<BE_clientes>();
            pBE_Clientes = new BE_clientes();
            pBL_Clientes = new BL_Clientes();

            pBE_Clientes.Str_texto_buscar = Convert.ToString(txt_buscar.Text);
            Listar_Clientes = BL_Clientes.Listar_Clientes(pBE_Clientes);

            gv_Clientes_Lista.AutoGenerateColumns = false;
            gv_Clientes_Lista.DataSource = Listar_Clientes;
            gv_Clientes_Lista.ClearSelection();
        }

        public frm_Cliente()
        {
            InitializeComponent();

            this.btn_Clientes_Buscar.Visible = true;
            this.btn_Clientes_Buscar_Sunat.Visible = false;
        }

        public frm_Cliente(int tipo)
        {
            InitializeComponent();
            this._tipo = tipo;
            this.btn_Clientes_Buscar.Visible = false;
            this.btn_Clientes_Buscar_Sunat.Visible = true;
        }

        private void frm_Cliente_Load(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(0);
            this.Listar_Clientes();
        }

        private void gv_Clientes_Lista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gv_Clientes_Lista.RowCount > 0)
            {
                DataGridViewRow row = gv_Clientes_Lista.CurrentRow;
                int valor = Convert.ToInt32(row.Cells["ID"].Value);
                label2.Text = Convert.ToString(valor);
            }
        }

        private void btn_Clientes_Buscar_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(0);
            this.Listar_Clientes();
        }

        private void btn_Clientes_Nuevo_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(0);
            frm_Sub_Cliente FrmSub = new frm_Sub_Cliente();
            FrmSub.ShowDialog();

            Listar_Clientes();
        }

        private void btn_Clientes_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gv_Clientes_Lista.RowCount > 0)
                {
                    int ID = Convert.ToInt16(label2.Text);
                    if (ID == 0)
                    {
                        MessageBox.Show("Seleccione fila");
                    }
                    else
                    {
                        label2.Text = Convert.ToString(0);
                        frm_Sub_Cliente FrmSub = new frm_Sub_Cliente();
                        FrmSub.Dato = ID;
                        FrmSub.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("No hay registros, lista vacia");
                }

                Listar_Clientes();
            }
            catch
            {
            }
        }

        private void btn_Clientes_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gv_Clientes_Lista.RowCount > 0)
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
                            pBE_Clientes = new BE_clientes();
                            pBL_Clientes = new BL_Clientes();

                            pBE_Clientes.ID = ID;
                            pBE_Clientes.IDUsuarioModificacion = 1;

                            BL_Clientes.ActualizarEstadoclientes(pBE_Clientes);

                            Listar_Clientes();
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

        private void frm_Cliente_Activated(object sender, EventArgs e)
        {
            Listar_Clientes();
        }

        private void gb_Clientes_Buscar_Enter(object sender, EventArgs e)
        {
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            if (this._tipo == 1)
            {
                var BE_clienteTmp = BL_Clientes.Listar_Clientes(new BE_clientes() { Str_texto_buscar = this.txt_buscar.Text });

                this.gv_Clientes_Lista.DataSource = BE_clienteTmp;
            }
        }

        private void btn_Clientes_Buscar_Sunat_Click(object sender, EventArgs e)
        {
            var cliente = BL_Clientes.Listar_Clientes_x_NumDoc(new BE_clientes() { Str_num_documento = txtRucDNI.Text });

            if (cliente.Count > 0)
            {
                MessageBox.Show("Nro. Documento ya esta registrado.");
            }
            else
            {
                
                try
                {
                    if (txt_buscar.Text.Length == 8)
                    {
                        string html = string.Empty;
                        string url = @"http://informaticaperuana.com/ukupacha/katariq.php?usr=iperuana&pwd=ip2017!&dni=" + this.txt_buscar.Text;

                        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                        request.AutomaticDecompression = DecompressionMethods.GZip;

                        using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                        using (Stream stream = response.GetResponseStream())
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            html = reader.ReadToEnd();
                        }

                        this.txtRucDNI.Text = txt_buscar.Text;
                        this.txtNombre.Text = html;
                        this.pnlBusquedaSunat.Visible = true;
                    }
                    else if (txt_buscar.Text.Length == 11)
                    {
                        MessageBox.Show("En estos momentos no se puede obtener la información solicitada, por favor verifique su conexión a internet.");
                    }
                }
                catch (Exception es)
                {
                    MessageBox.Show("En estos momentos no se puede obtener la información solicitada, por favor verifique su conexión a internet.");
                }
            }
        }

        private void gv_Clientes_Lista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this._tipo == 1)
            {
                DataGridViewRow row = gv_Clientes_Lista.CurrentRow;
                int valor = Convert.ToInt32(row.Cells["ID"].Value);

                var clienteTmp = BL_Clientes.Listar_Clientes_x_ID(new BE_clientes() { ID = valor });

                if (clienteTmp.Count > 0)
                {
                    pBE_Clientes = clienteTmp[0];
                    this.Close();
                }
            }
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            int res = 0;
            BE_clientes pBE_clientes = new BE_clientes();
            pBE_clientes.ID = Convert.ToInt32(0);
            pBE_clientes.oBE_Tipo_Documento.ID = (this.txtRucDNI.Text.Length == 8) ? 1 : 6;
            pBE_clientes.Str_num_documento = txtRucDNI.Text;
            pBE_clientes.Str_nom_cliente = txtNombre.Text;
            pBE_clientes.Str_direccion_cliente = null;
            pBE_clientes.oBE_Departamento.ID = null;
            pBE_clientes.oBE_Provincia.ID = null;
            pBE_clientes.oBE_Distrito.ID = null;
            pBE_clientes.Str_v_ubigeo = null;
            pBE_clientes.Int_chk_promo_vigentes = 0;
            pBE_clientes.Dcm_linea_credito = 0;
            pBE_clientes.Dcm_credito_utilizado = 0;
            pBE_clientes.Dcm_credito_disponible = 0;

            pBE_clientes.IDUsuarioCreacion = 1;
            res = BL_Clientes.Registrar_clientes(pBE_clientes);

            this.txtRucDNI.Clear();
            this.txtNombre.Clear();
            txt_buscar.Text = pBE_Clientes.Str_num_documento;
            this.pnlBusquedaSunat.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.txtRucDNI.Clear();
            this.txtNombre.Clear();
            this.pnlBusquedaSunat.Visible = false;
        }
    }
}