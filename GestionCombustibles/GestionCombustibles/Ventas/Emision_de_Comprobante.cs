using Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento;
using Informatica_Peruana.SGC.BL_Sistema_SGC.Mantenimiento;
using PrinterUtility;
using Sagitario.DLLFirmado;
using Sagitario.DLLFirmado.Common.Dto.Intercambio;
using Sagitario.DLLFirmado.Common.Dto.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace GestionCombustibles.Ventas
{
    public partial class Emision_de_Comprobante : Form
    {
        private BE_Productos pBE_productos = new BE_Productos();
        private BL_Productos pBL_productos = new BL_Productos();
        private BE_Islas pBE_islas = new BE_Islas();
        private BL_Islas pBL_islas = new BL_Islas();
        private BE_Surtidor pBE_surtidor = new BE_Surtidor();
        private BL_Surtidor pBL_Surtidor = new BL_Surtidor();
        private BE_Lados_Caras pBE_lados_caras = new BE_Lados_Caras();
        private BL_Lados_Caras pBL_lados_caras = new BL_Lados_Caras();
        private BE_Mangueras pBE_mangueras = new BE_Mangueras();
        private BL_Mangueras pBL_mangueras = new BL_Mangueras();
        private BE_Tablas_Tipos pBE_tablas_tipo = new BE_Tablas_Tipos();
        private BL_Tablas_Tipo pBL_tablas_tipo = new BL_Tablas_Tipo();
        private BE_clientes pBE_clientes = new BE_clientes();
        private BL_Clientes pBL_clientes = new BL_Clientes();
        private BE_Operador pBE_operador = new BE_Operador();
        private BL_Operador pBL_operador = new BL_Operador();
        private BE_Tipo_Cambio pBE_tipo_cambio = new BE_Tipo_Cambio();
        private BL_Tipo_Cambio pBL_tipo_cambio = new BL_Tipo_Cambio();
        private int flgCalcularCantTotal = 0;

        public static string enletras(string num)
        {
            string res, dec = "";
            Int64 entero;
            int decimales;
            double nro;

            try

            {
                nro = Convert.ToDouble(num);
            }
            catch
            {
                return "";
            }

            entero = Convert.ToInt64(Math.Truncate(nro));
            decimales = Convert.ToInt32(Math.Round((nro - entero) * 100, 2));
            if (decimales > 0)
            {
                dec = " CON " + decimales.ToString() + "/100";
            }

            res = toText(Convert.ToDouble(entero)) + dec;
            return res;
        }

        private static string toText(double value)
        {
            string Num2Text = "";
            value = Math.Truncate(value);
            if (value == 0) Num2Text = "CERO";
            else if (value == 1) Num2Text = "UNO";
            else if (value == 2) Num2Text = "DOS";
            else if (value == 3) Num2Text = "TRES";
            else if (value == 4) Num2Text = "CUATRO";
            else if (value == 5) Num2Text = "CINCO";
            else if (value == 6) Num2Text = "SEIS";
            else if (value == 7) Num2Text = "SIETE";
            else if (value == 8) Num2Text = "OCHO";
            else if (value == 9) Num2Text = "NUEVE";
            else if (value == 10) Num2Text = "DIEZ";
            else if (value == 11) Num2Text = "ONCE";
            else if (value == 12) Num2Text = "DOCE";
            else if (value == 13) Num2Text = "TRECE";
            else if (value == 14) Num2Text = "CATORCE";
            else if (value == 15) Num2Text = "QUINCE";
            else if (value < 20) Num2Text = "DIECI" + toText(value - 10);
            else if (value == 20) Num2Text = "VEINTE";
            else if (value < 30) Num2Text = "VEINTI" + toText(value - 20);
            else if (value == 30) Num2Text = "TREINTA";
            else if (value == 40) Num2Text = "CUARENTA";
            else if (value == 50) Num2Text = "CINCUENTA";
            else if (value == 60) Num2Text = "SESENTA";
            else if (value == 70) Num2Text = "SETENTA";
            else if (value == 80) Num2Text = "OCHENTA";
            else if (value == 90) Num2Text = "NOVENTA";
            else if (value < 100) Num2Text = toText(Math.Truncate(value / 10) * 10) + " Y " + toText(value % 10);
            else if (value == 100) Num2Text = "CIEN";
            else if (value < 200) Num2Text = "CIENTO " + toText(value - 100);
            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) Num2Text = toText(Math.Truncate(value / 100)) + "CIENTOS";
            else if (value == 500) Num2Text = "QUINIENTOS";
            else if (value == 700) Num2Text = "SETECIENTOS";
            else if (value == 900) Num2Text = "NOVECIENTOS";
            else if (value < 1000) Num2Text = toText(Math.Truncate(value / 100) * 100) + " " + toText(value % 100);
            else if (value == 1000) Num2Text = "MIL";
            else if (value < 2000) Num2Text = "MIL " + toText(value % 1000);
            else if (value < 1000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000)) + " MIL";
                if ((value % 1000) > 0) Num2Text = Num2Text + " " + toText(value % 1000);
            }
            else if (value == 1000000) Num2Text = "UN MILLON";
            else if (value < 2000000) Num2Text = "UN MILLON " + toText(value % 1000000);
            else if (value < 1000000000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000000)) + " MILLONES ";
                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000) * 1000000);
            }
            else if (value == 1000000000000) Num2Text = "UN BILLON";
            else if (value < 2000000000000) Num2Text = "UN BILLON " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            else
            {
                Num2Text = toText(Math.Truncate(value / 1000000000000)) + " BILLONES";
                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            }
            return Num2Text;
        }

        private static Contribuyente CrearEmisor()
        {
            return new Contribuyente
            {
                IdGrupoEconomico = 1,
                NroDocumento = "20402786729",
                TipoDocumento = "6",
                Direccion = "Jr. Moquegua Nro. 398 Int. 7 P.J.",
                Urbanizacion = "-",
                Departamento = "LIMA",
                Provincia = "LIMA",
                Distrito = "LIMA",
                NombreComercial = "INVERSIONES SANTA ROSA E.I.R.L.",
                NombreLegal = "INVERSIONES SANTA ROSA E.I.R.L.",
                Ubigeo = "150101"
            };
        }

        private void CalcularTotal()
        {
            try
            {
                decimal sumatoria = 0;
                foreach (DataGridViewRow row in grvDetalleVenta.Rows)
                {
                    sumatoria += Convert.ToDecimal((row.Cells[9].Value == null) ? "" : row.Cells[9].Value);    //aqui recorre las celdas y las va sumando
                }

                this.txtVentaSoles.Text = Math.Round(sumatoria, 2).ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void CalcularPago()
        {
            try
            {
                decimal efectivoDolares = decimal.Parse((string.IsNullOrEmpty(this.txtEfectivoDolares.Text) ? "0.00" : this.txtEfectivoDolares.Text));
                decimal tipoCambio = decimal.Parse((string.IsNullOrEmpty(this.txtTipoCambio.Text) ? "0.00" : this.txtTipoCambio.Text));
                decimal efectivoSoles = decimal.Parse((string.IsNullOrEmpty(this.txtEfectivoSoles.Text) ? "0.00" : this.txtEfectivoSoles.Text));
                decimal tarjetaSoles = decimal.Parse((string.IsNullOrEmpty(this.txtTarjetaSoles.Text) ? "0.00" : this.txtTarjetaSoles.Text));
                decimal lineaCredSoles = decimal.Parse((string.IsNullOrEmpty(this.txtLineaCredSoles.Text) ? "0.00" : this.txtLineaCredSoles.Text));
                decimal usarLineaCredSoles = decimal.Parse((string.IsNullOrEmpty(this.txtUsarLineaCred.Text) ? "0.00" : this.txtUsarLineaCred.Text));

                if (lineaCredSoles > 0 && lineaCredSoles > usarLineaCredSoles)
                {
                    this.txtUsarLineaCred.Text = "0-00";
                    MessageBox.Show("El valor a usar de la linea de credito excede el valor autorizado.");
                }
                else if (lineaCredSoles < 0)
                {
                    this.txtUsarLineaCred.Text = "0-00";
                    MessageBox.Show("El valor a usar de la linea de crédito es incorrecto.");
                }
                else
                {
                    this.txtPagoSoles.Text = Math.Round((efectivoDolares * tipoCambio) + efectivoSoles + tarjetaSoles + lineaCredSoles, 2).ToString();
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void CalcularVuelto()
        {
            try
            {
                decimal ventaSoles = decimal.Parse((string.IsNullOrEmpty(this.txtVentaSoles.Text) ? "0.00" : this.txtVentaSoles.Text));
                decimal pagoSoles = decimal.Parse((string.IsNullOrEmpty(this.txtPagoSoles.Text) ? "0.00" : this.txtPagoSoles.Text));

                this.txtVueltoSoles.Text = Math.Round(pagoSoles - ventaSoles, 2).ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void CalcularCantidadTotal()
            {
            try
            {
                decimal precioUnitario = decimal.Parse((string.IsNullOrEmpty(this.txtPUnit.Text) ? "0.00" : this.txtPUnit.Text));
                decimal cantidad = decimal.Parse((string.IsNullOrEmpty(this.txtCantidad.Text) ? "0.00" : this.txtCantidad.Text));
                decimal totalItem = decimal.Parse((string.IsNullOrEmpty(this.txtTotalItem.Text) ? "0.00" : this.txtTotalItem.Text));

                if (this.flgCalcularCantTotal == 1)
                {
                    this.txtTotalItem.Text = Math.Round(precioUnitario * cantidad, 2).ToString();
                }
                else if (this.flgCalcularCantTotal == 2)
                {
                    this.txtCantidad.Text = Math.Round(totalItem / precioUnitario, 2).ToString();
                }
            }
            catch (Exception ex)
            {
            }
        }

        public void Listar_Boleta_Factura()
        {
            List<BE_Tablas_Tipos> Listar_Tablas_Tipo = new List<BE_Tablas_Tipos>();
            pBE_tablas_tipo = new BE_Tablas_Tipos();
            pBL_tablas_tipo = new BL_Tablas_Tipo();

            Listar_Tablas_Tipo = BL_Tablas_Tipo.Listar_Tablas_Tipo(new BE_Tablas_Tipos() { Str_texto_buscar = "TB_TDE" });

            this.cboFacturaBoleta.DataSource = Listar_Tablas_Tipo;
            this.cboFacturaBoleta.ValueMember = "Str_item_tabla_tipo";
            this.cboFacturaBoleta.DisplayMember = "Str_denominacion_tabla_tipo";
        }

        private void Listar_Islas()
        {
            List<BE_Islas> Listar_Islas = new List<BE_Islas>();
            pBE_islas = new BE_Islas();
            pBL_islas = new BL_Islas();

            Listar_Islas = BL_Islas.Listar_Islas(new BE_Islas());

            this.cboIsla.DataSource = Listar_Islas;
            this.cboIsla.ValueMember = "Str_cod_isla";
            this.cboIsla.DisplayMember = "Str_cod_isla";
        }

        private void Listar_Surtidor()
        {
            List<BE_Surtidor> Listar_Surtidor = new List<BE_Surtidor>();
            pBE_surtidor = new BE_Surtidor();
            pBL_Surtidor = new BL_Surtidor();

            Listar_Surtidor = BL_Surtidor.Listar_Surtidor(new BE_Surtidor());

            this.cboSurtidor.DataSource = Listar_Surtidor;
            this.cboSurtidor.ValueMember = "Str_cod_surtidor";
            this.cboSurtidor.DisplayMember = "Str_cod_surtidor";
        }

        private void Listar_LadosCaras()
        {
            List<BE_Lados_Caras> Listar_Lados_Caras = new List<BE_Lados_Caras>();
            pBE_lados_caras = new BE_Lados_Caras();
            pBL_lados_caras = new BL_Lados_Caras();

            Listar_Lados_Caras = BL_Lados_Caras.Listar_Lados_Caras(new BE_Lados_Caras());

            this.cboCara.DataSource = Listar_Lados_Caras;
            this.cboCara.ValueMember = "Str_cod_lados";
            this.cboCara.DisplayMember = "Str_cod_lados";
        }

        private void Listar_Mangueras()
        {
            List<BE_Mangueras> Listar_Mangueras = new List<BE_Mangueras>();
            pBE_mangueras = new BE_Mangueras();
            pBL_mangueras = new BL_Mangueras();

            Listar_Mangueras = BL_Mangueras.Listar_Mangueras(new BE_Mangueras());

            this.cboMang.DataSource = Listar_Mangueras;
            this.cboMang.ValueMember = "Str_cod_mangueras";
            this.cboMang.DisplayMember = "Str_cod_mangueras";
        }

        private void Listar_Productos()
        {
            List<BE_Productos> Listar_Productos = new List<BE_Productos>();
            pBE_productos = new BE_Productos();
            pBL_productos = new BL_Productos();

            Listar_Productos = BL_Productos.Listar_Productos(new BE_Productos());

            this.cboProducto.DataSource = Listar_Productos;
            this.cboProducto.ValueMember = "Str_cod_producto";
            this.cboProducto.DisplayMember = "Str_cod_producto";

            if (Listar_Productos.Count > 0)
                this.cboProducto.SelectedIndex = 0;
        }

        private void ObtenerOperador()
        {
            this.txtCodOperador.Text = VariablesGlobales.operador_actual.Str_Cod_Operador;
            this.txtOperador.Text = VariablesGlobales.operador_actual.Str_Nombre_Operador;
        }

        private void ObtenerTurno()
        {
            var BE_turnoTmp = BL_Turnos.Listar_Turnos(new BE_Turnos()
            {
                Str_inicio_buscar = DateTime.Now.Hour.ToString().PadLeft(2, char.Parse("0")) + ":" + DateTime.Now.Minute.ToString().PadLeft(2, char.Parse("0")) + ":" + DateTime.Now.Second.ToString().PadLeft(2, char.Parse("0")),
                Str_fin_buscar = DateTime.Now.Hour.ToString().PadLeft(2, char.Parse("0")) + ":" + DateTime.Now.Minute.ToString().PadLeft(2, char.Parse("0")) + ":" + DateTime.Now.Second.ToString().PadLeft(2, char.Parse("0"))
            });

            if (BE_turnoTmp.Count > 0)
            {
                this.txtCodTurno.Text = BE_turnoTmp[0].Str_cod_turno;
                this.txtTurno.Text = BE_turnoTmp[0].Str_denominacion_turno;
            }
        }

        private void ObtenerTipoCambio()
        {
            var BE_tipo_cambioTmp = BL_Tipo_Cambio.Listar_Tipo_Cambio_x_fecha(new BE_Tipo_Cambio() { Str_Fecha = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString().PadLeft(2, char.Parse("0")) + "-" + DateTime.Now.Day.ToString().PadLeft(2, char.Parse("0")) });

            if (BE_tipo_cambioTmp.Count > 0)
            {
                this.txtTipoCambio.Text = Math.Round(BE_tipo_cambioTmp[0].Dcm_Venta.Value, 2).ToString();
            }
        }

        private void Descartar()
        {
            this.Listar_Boleta_Factura();
            this.txtIDCliente.Clear();
            this.txtRucDNI.Clear();
            this.txtNombre.Clear();
            this.txtDireccion.Clear();
            this.txtPlaca.Clear();
            this.txtLineaCredSoles.Clear();
            this.dtpFechaHora.Value = DateTime.Now;
            this.txtCodOperador.Clear();
            this.ObtenerOperador();
            this.txtCodTurno.Clear();
            this.ObtenerTurno();
            this.Listar_Islas();
            this.Listar_Surtidor();
            this.Listar_LadosCaras();
            this.Listar_Mangueras();
            this.txtProducto.Clear();
            this.txtPUnit.Text = "0.00";
            this.Listar_Productos();
            this.txtCantidad.Text = "0.00";
            this.txtTotalItem.Text = "0.00";
            this.txtIGVUnit.Text = "0";
            this.txtISCUnit.Text = "0";
            this.txtAfectoIGV.Text = "0";
            this.txtAfectoISC.Text = "0";
            this.txtSTExonerado.Text = "0";
            this.txtSTGravado.Text = "0";
            this.txtSTInafecto.Text = "0";
            this.txtSTGratuito.Text = "0";
            this.grvDetalleVenta.Rows.Clear();
            this.txtEfectivoDolares.Text = "0.00";
            this.txtEfectivoSoles.Text = "0.00";
            this.txtTarjetaSoles.Text = "0.00";
            this.txtUsarLineaCred.Text = "0.00";
            this.ObtenerTipoCambio();
            this.CalcularTotal();
            this.txtPagoSoles.Text = "0.00";
            this.txtVueltoSoles.Text = "0.00";
        }

        public byte[] CutPage()
        {
            List<byte> oby = new List<byte>();
            oby.Add(Convert.ToByte(Convert.ToChar(0x1D)));
            oby.Add(Convert.ToByte('V'));
            oby.Add((byte)66);
            oby.Add((byte)3);
            return oby.ToArray();
        }

        public string Izq(string xText, int Repetir)
        {
            string xResult = xText.PadLeft(Repetir, ' ');
            return xResult;
        }

        public string Der(string xText, int Repetir)
        {
            string xResult = xText.PadRight(Repetir, ' ');
            return xResult;
        }

        public Emision_de_Comprobante()
        {
            InitializeComponent();
        }

        private void Emision_de_Comprobante_Load(object sender, EventArgs e)
        {
            this.Listar_Boleta_Factura();
            this.Listar_Islas();
            this.Listar_Surtidor();
            this.Listar_LadosCaras();
            this.Listar_Mangueras();
            this.Listar_Productos();
            this.ObtenerOperador();
            this.ObtenerTurno();
            this.ObtenerTipoCambio();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Archivo.frm_Cliente frm = new Archivo.frm_Cliente(1);
                frm.ShowDialog();

                if (frm.pBE_Clientes != null)
                {
                    this.txtIDCliente.Text = frm.pBE_Clientes.ID.ToString();
                    this.txtRucDNI.Text = frm.pBE_Clientes.Str_num_documento;
                    this.txtNombre.Text = frm.pBE_Clientes.Str_nom_cliente;
                    this.txtDireccion.Text = frm.pBE_Clientes.Str_direccion_cliente;
                    this.txtPlaca.Text = "";
                    this.txtLineaCredSoles.Text = (frm.pBE_Clientes.Dcm_linea_credito == null) ? "0.00" : Math.Round(frm.pBE_Clientes.Dcm_linea_credito.Value, 2).ToString();
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var listadoBE_productos = BL_Productos.Listar_Productos(new BE_Productos() { Str_texto_buscar = this.cboProducto.SelectedValue.ToString() });

                if (listadoBE_productos.Count > 0)
                {
                    this.txtProducto.Text = listadoBE_productos[0].Str_nom_producto;

                    decimal valorVentaUnit = 0;
                    decimal valorIGVUnit = 0;
                    decimal valorISCUnit = 0;

                    if (listadoBE_productos[0].Int_flg_afecto_igv == 1)
                    {
                        valorVentaUnit = Math.Round(listadoBE_productos[0].Dcm_Venta.Value / (VariablesGlobales.empresa_calcimp_actual.Dec_CalculoIGV_CalcImp.Value + 1), 2);
                        valorIGVUnit = Math.Round(listadoBE_productos[0].Dcm_Venta.Value - valorVentaUnit, 2);

                        this.txtSTGravado.Text = Math.Round(decimal.Parse((string.IsNullOrEmpty(this.txtSTGravado.Text)) ? "0" : this.txtSTGravado.Text) + valorVentaUnit, 2).ToString();
                        this.txtSTInafecto.Text = "0";
                    }
                    else
                    {
                        valorVentaUnit = Math.Round(listadoBE_productos[0].Dcm_Venta.Value, 2);
                        valorIGVUnit = 0;

                        this.txtSTGravado.Text = "0";
                        this.txtSTInafecto.Text = Math.Round(decimal.Parse((string.IsNullOrEmpty(this.txtSTInafecto.Text)) ? "0" : this.txtSTInafecto.Text) + valorVentaUnit, 2).ToString();
                    }

                    if (listadoBE_productos[0].Int_flg_afecto_isc == 1)
                    {
                        valorISCUnit = Math.Round(valorVentaUnit * VariablesGlobales.empresa_calcimp_actual.Dec_CalculoISC_CalcImp.Value, 2);
                    }
                    else
                    {
                        valorISCUnit = 0;
                    }

                    this.txtPUnit.Text = Math.Round(valorVentaUnit, 2).ToString(); //listadoBE_productos[0].Dcm_Venta.Value;
                    this.txtIGVUnit.Text = valorIGVUnit.ToString();
                    this.txtISCUnit.Text = valorISCUnit.ToString();
                    this.txtAfectoIGV.Text = listadoBE_productos[0].Int_flg_afecto_igv.ToString();
                    this.txtAfectoISC.Text = listadoBE_productos[0].Int_flg_afecto_isc.ToString();
                    this.txtUniMed.Text = listadoBE_productos[0].Str_uni_med;
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            grvDetalleVenta.Rows.Add(0,
                this.cboIsla.SelectedValue,
                this.cboSurtidor.SelectedValue,
                this.cboCara.SelectedValue,
                this.cboMang.SelectedValue,
                this.cboProducto.SelectedValue,
                this.txtProducto.Text,
                this.txtPUnit.Text,
                this.txtCantidad.Text,
               this.txtTotalItem.Text,
                this.txtIGVUnit.Text,
                this.txtISCUnit.Text,
                this.txtAfectoIGV.Text,
                this.txtAfectoISC.Text,
                this.txtSTGravado.Text,
                this.txtSTInafecto.Text,
                this.txtUniMed.Text);

            //this.Descartar();
            this.Listar_Islas();
            this.Listar_Surtidor();
            this.Listar_LadosCaras();
            this.Listar_Mangueras();
            this.txtProducto.Clear();
            this.txtUniMed.Text = "0.00"; //listadoBE_productos[0].Dcm_Venta.Value;
            this.Listar_Productos();
            this.txtCantidad.Text = "0.00";
            this.txtIGVUnit.Text = "0";
            this.txtISCUnit.Text = "0";
            this.txtAfectoIGV.Text = "0";
            this.txtAfectoISC.Text = "0";
            this.txtSTExonerado.Text = "0";
            this.txtSTGravado.Text = "0";
            this.txtSTInafecto.Text = "0";
            this.txtSTGratuito.Text = "0";
            this.txtTotalItem.Text = "0.00";
            this.CalcularTotal();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (grvDetalleVenta.SelectedRows.Count > 0)
                {
                    grvDetalleVenta.Rows.Remove(grvDetalleVenta.SelectedRows[0]);
                    this.CalcularTotal();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila.");
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void btnImprimirVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtIDCliente.Text))
                {
                    MessageBox.Show("Error: Debe seleccionar un cliente.");
                    return;
                }

                decimal ventaSoles = decimal.Parse((string.IsNullOrEmpty(this.txtVentaSoles.Text) ? "0.00" : this.txtVentaSoles.Text));
                decimal pagoSoles = decimal.Parse((string.IsNullOrEmpty(this.txtPagoSoles.Text) ? "0.00" : this.txtPagoSoles.Text));

                if (ventaSoles > pagoSoles)
                {
                    MessageBox.Show("Monto pago es insuficiente.");
                }
                else
                {
                    var documento = new DocumentoElectronico
                    {
                        Emisor = CrearEmisor(),
                        Receptor = new Contribuyente
                        {
                            NroDocumento = "20100039207",
                            TipoDocumento = "6",
                            NombreLegal = "RANSA COMERCIAL S.A.",
                            Email = "admin@mail.com"
                        },
                        IdDocumento = "",
                        FechaEmision = dtpFechaHora.Value.ToShortDateString(),
                        Moneda = "PEN",
                        MontoEnLetras = enletras(txtVentaSoles.Text), //"SON CIENTO DIECIOCHO SOLES CON 0/100",
                        CalculoIgv = 0.18m,
                        CalculoIsc = 0.10m,
                        CalculoDetraccion = 0.04m,
                        TipoDocumento = cboFacturaBoleta.SelectedValue.ToString(),
                        TotalIgv = 18,
                        TotalVenta = 118,
                        Gravadas = 100
                    };

                    foreach (DataGridViewRow row in grvDetalleVenta.Rows)
                    {
                        documento.Items.Add(new DetalleDocumento
                        {
                            IdDocumento = documento.IdDocumento, //+ i.ToString().PadLeft(8, char.Parse("0")),
                            Id = row.Index + 1,
                            Cantidad = decimal.Parse(row.Cells["Cantidad"].Value.ToString()),
                            PrecioReferencial = decimal.Parse(row.Cells["PUnit"].Value.ToString()),
                            PrecioUnitario = decimal.Parse(row.Cells["PUnit"].Value.ToString()),
                            TipoPrecio = "01",
                            CodigoItem = row.Cells["CodProd"].Value.ToString(),
                            Descripcion = row.Cells["Descripcion"].Value.ToString(),
                            UnidadMedida = row.Cells["UnidMed"].Value.ToString(),
                            Impuesto = 18,
                            TipoImpuesto = (row.Cells["FlgAfectoIGV"].Value.ToString() == "1") ? "10" : "30",// Gravada
                            TotalVenta = decimal.Parse(row.Cells["TotaItem"].Value.ToString()),
                            Suma = decimal.Parse(row.Cells["TotaItem"].Value.ToString()),
                        });
                    }

                    FirmadoResponse response = FirmadoCPE.Generar(documento);

                    var resumentFirma = response.ResumenFirma;
                    var firma = response.ValorFirma;
                    var mensajeError = response.MensajeError;

                    BE_Comprobante pBE_ComprobanteTMP = new BE_Comprobante()
                    {
                        ID = 0,
                        Str_Tipo_Comprobante = documento.TipoDocumento,
                        Str_Serie_Comprobante = "",
                        Str_Numero_Comprobante = "",
                        Str_Num_Documento_Cliente = documento.Receptor.NroDocumento,
                        Str_Fecha_Hora_Comprobante = documento.FechaEmision,
                        Str_Placa_Comprobante = txtPlaca.Text,
                        Str_Linea_Cred_Soles_Comprobante = txtLineaCredSoles.Text,
                        Str_Cod_Operador = this.txtCodOperador.Text,
                        Str_Cod_Turno = this.txtCodTurno.Text,
                        Str_Tarjeta_Soles_Comprobante = this.txtTarjetaSoles.Text,
                        Str_Linea_Cred_Comprobante = this.txtUsarLineaCred.Text,
                        //Dec_Total_Gravado_Comprobante = decimal.Parse(txtSTGravado.Text),
                        Dec_Total_Gravado_Comprobante = decimal.Parse((string.IsNullOrEmpty(this.txtSTGravado.Text) ? "0.00" : this.txtSTGravado.Text)),
                        Dec_Total_Gratuito_Comprobante = 0,
                        //Dec_Total_Inafecto_Comprobante = decimal.Parse(txtSTInafecto.Text),
                        Dec_Total_Inafecto_Comprobante = decimal.Parse((string.IsNullOrEmpty(this.txtSTInafecto.Text) ? "0.00" : this.txtSTInafecto.Text)),
                        Dec_Total_Exonerado_Comprobante = 0,
                        Dec_Dscnto_Global_Comprobante = 0,
                        //Dec_Total_Venta_Soles_Comprobante = decimal.Parse(txtVentaSoles.Text),
                        Dec_Total_Venta_Soles_Comprobante = decimal.Parse((string.IsNullOrEmpty(this.txtVentaSoles.Text) ? "0.00" : this.txtVentaSoles.Text)),
                        Dec_Total_Igv_Soles_Comprobante = 0,
                        Dec_Total_Isc_Soles_Comprobante = 0,
                        //Dec_Efectivo_Soles_Comprobante = decimal.Parse(txtEfectivoSoles.Text),
                        Dec_Efectivo_Soles_Comprobante = decimal.Parse((string.IsNullOrEmpty(this.txtEfectivoSoles.Text) ? "0.00" : this.txtEfectivoSoles.Text)),
                        //Dec_Tipo_Cambio_Comprobante = decimal.Parse(txtTipoCambio.Text),
                        Dec_Tipo_Cambio_Comprobante = decimal.Parse((string.IsNullOrEmpty(this.txtTipoCambio.Text) ? "0.00" : this.txtTipoCambio.Text)),
                        //Dec_Efectivo_Dolares_Comprobante = decimal.Parse(txtEfectivoDolares.Text),
                        Dec_Efectivo_Dolares_Comprobante = decimal.Parse((string.IsNullOrEmpty(this.txtEfectivoDolares.Text) ? "0.00" : this.txtEfectivoDolares.Text)),
                        //Dec_Pago_Comprobante = decimal.Parse(txtPagoSoles.Text),
                        Dec_Pago_Comprobante = decimal.Parse((string.IsNullOrEmpty(this.txtPagoSoles.Text) ? "0.00" : this.txtPagoSoles.Text)),
                        //Dec_Vuelto_Comprobante = decimal.Parse(txtVueltoSoles.Text),
                        Dec_Vuelto_Comprobante = decimal.Parse((string.IsNullOrEmpty(this.txtVueltoSoles.Text) ? "0.00" : this.txtVueltoSoles.Text)),
                        Str_Monto_Letras_Comprobante = documento.MontoEnLetras,
                        Str_Hash_Comprobante = resumentFirma,
                        Str_MsjRpta_Comprobante = mensajeError,
                        IDUsuarioCreacion = VariablesGlobales.operador_actual.ID
                    };

                    pBE_ComprobanteTMP.Listado_Detalle = new List<BE_Comprobante_Detalle>();

                    foreach (DataGridViewRow row in grvDetalleVenta.Rows)
                    {
                        pBE_ComprobanteTMP.Listado_Detalle.Add(new BE_Comprobante_Detalle()
                        {
                            Str_Cod_Isla = row.Cells["Isla"].Value.ToString(),
                            Str_Cod_Surtidor = row.Cells["Surtidor"].Value.ToString(),
                            Str_Cod_Lados = row.Cells["Cara"].Value.ToString(),
                            Str_Cod_Manguera = row.Cells["Manguera"].Value.ToString(),
                            Str_Cod_Producto = row.Cells["Cara"].Value.ToString(),
                            Dec_Precio_Unitario_DComprobante = decimal.Parse(row.Cells["PUnit"].Value.ToString()),
                            Dec_Cantidad_DComprobante = decimal.Parse(row.Cells["Cantidad"].Value.ToString()),
                            Dec_SubTotal_Gravado_DComprobante = decimal.Parse(row.Cells["STGravado"].Value.ToString()),
                            Dec_SubTotal_Inafecto_DComprobante = decimal.Parse(row.Cells["STInafecto"].Value.ToString()),
                            Dec_SubTotal_Gratuito_DComprobante = 0,
                            Dec_SubTotal_Exonerado_DComprobante = 0,
                            Dec_SubTotal_Item_DComprobante = decimal.Parse(row.Cells["TotaItem"].Value.ToString()),
                            Int_Flg_Agecto_IGV = int.Parse(row.Cells["FlgAfectoIGV"].Value.ToString()),
                            Dec_IGV_Item_DComprobante = decimal.Parse(row.Cells["IGVUnit"].Value.ToString()),
                            Int_Flg_Agecto_ISC = int.Parse(row.Cells["FlgAfectoISC"].Value.ToString()),
                            Dec_ISC_Item_DComprobante = decimal.Parse(row.Cells["ISCUnit"].Value.ToString()),
                            IDUsuarioCreacion = VariablesGlobales.operador_actual.ID
                        });
                    }

                    int id = BL_Comprobante.Registrar_Comprobante(pBE_ComprobanteTMP);

                    if (id > 0)
                    {
                        if (string.IsNullOrEmpty(GestionCombustibles.Properties.Settings.Default.PrinterPath))
                        {
                            MessageBox.Show("No hay una impresora configurada.");
                        }
                        else
                        {
                            string xNumComprobante = txtSerieNumero.Text;
                            string xFecha = dtpFechaHora.Value.Day.ToString().PadLeft(2, char.Parse("0")) + "-" + dtpFechaHora.Value.Month.ToString().PadLeft(2, char.Parse("0")) + "-" + dtpFechaHora.Value.Year.ToString().PadLeft(2, char.Parse("0")) + " " + dtpFechaHora.Value.Hour.ToString().PadLeft(2, char.Parse("0")) + ":" + dtpFechaHora.Value.Minute.ToString().PadLeft(2, char.Parse("0")) + ":" + dtpFechaHora.Value.Second.ToString().PadLeft(2, char.Parse("0"));
                            string xSurtidor = cboSurtidor.SelectedValue.ToString();
                            string xLado = cboCara.SelectedValue.ToString();
                            string xCodHash = txtCodHash.Text;
                            string xPlaca = txtPlaca.Text;

                            //
                            decimal xTotal = Convert.ToDecimal("00");
                            decimal xTotal_gravado = Convert.ToDecimal("00");
                            decimal xTotal_inafecto = Convert.ToDecimal("00");
                            decimal xTotal_igv = Convert.ToDecimal("00");
                            decimal xTotal_exonerado = Convert.ToDecimal("00");
                            decimal xTotal_isc = Convert.ToDecimal("00");
                            //
                            List<string> xHeader = new List<string>();
                            xHeader.Add((string.IsNullOrEmpty(VariablesGlobales.empresa.Str_nom_empresa) ? "" : VariablesGlobales.empresa.Str_nom_empresa) + "\n");
                            xHeader.Add((string.IsNullOrEmpty(VariablesGlobales.empresa.Str_direccion_empresa) ? "" : VariablesGlobales.empresa.Str_direccion_empresa));
                            xHeader.Add((string.IsNullOrEmpty(VariablesGlobales.empresa.Str_Nom_Distrito) ? "" : VariablesGlobales.empresa.Str_Nom_Distrito) + ", " + (string.IsNullOrEmpty(VariablesGlobales.empresa.Str_Nom_Provincia) ? "" : VariablesGlobales.empresa.Str_Nom_Provincia) + ", " + (string.IsNullOrEmpty(VariablesGlobales.empresa.Str_Nom_Departamento) ? "" : VariablesGlobales.empresa.Str_Nom_Departamento) + "\n");
                            xHeader.Add("RUC " + (string.IsNullOrEmpty(VariablesGlobales.empresa.Str_num_documento) ? "" : VariablesGlobales.empresa.Str_num_documento) + "\n");
                            xHeader.Add("----------------------------------------\n");
                            xHeader.Add("BOLETA DE VENTA ELECTRONICA\n");
                            xHeader.Add(" " + xNumComprobante + "\n");
                            xHeader.Add(" " + xFecha + "\n");
                            xHeader.Add("----------------------------------------\n");
                            xHeader.Add("POS  :" + xSurtidor + "                       LADO: " + xLado + "\n");
                            xHeader.Add("----------------------------------------\n");

                            List<string> xFooter = new List<string>();
                            xFooter.Add("----------------------------------------\n");
                            xFooter.Add("Placa del Vehiculo: " + xPlaca + "\n");
                            xFooter.Add("Cod Has: " + xCodHash + "\n");
                            xFooter.Add("Autorizado mediante\n");
                            xFooter.Add("Resolucion Nro.034-005-0006616/SUNAT \n");
                            xFooter.Add("RUC 20519069262 BOLETA de Venta\n");
                            xFooter.Add("Electronica, para consultar el\n");
                            xFooter.Add("documento ingrese a www.facturas.com.pe\n");
                            xFooter.Add("----------------------------------------\n");
                            xFooter.Add("*** GRACIAS POR SU COMPRA ***\n");

                            //
                            List<string> xCodigo = new List<string>();
                            List<string> xProducto = new List<string>();
                            List<string> xValor = new List<string>();
                            List<string> xCant = new List<string>();
                            List<string> xUM = new List<string>();

                            ////////// cargar los datos de los productos a facturar
                            ////////xCodigo.Add("GH90");
                            ////////xProducto.Add("GASOLINA90");
                            ////////xCant.Add("1.925");
                            ////////xUM.Add("GLN");
                            ////////xValor.Add("20.00");
                            //////////
                            ////////// cargar los datos de los productos a facturar
                            ////////xCodigo.Add("AG01");
                            ////////xProducto.Add("CIELO 250ML");
                            ////////xCant.Add("1");
                            ////////xUM.Add("UND");
                            ////////xValor.Add("1.50");
                            //////////

                            foreach (DataGridViewRow row in grvDetalleVenta.Rows)
                            {
                                xCodigo.Add(row.Cells[5].Value.ToString());
                                xProducto.Add(row.Cells[6].Value.ToString());
                                xCant.Add(row.Cells[8].Value.ToString());
                                xUM.Add("GLN");
                                xValor.Add(row.Cells[9].Value.ToString());
                            }

                            PrinterUtility.EscPosEpsonCommands.EscPosEpson obj = new PrinterUtility.EscPosEpsonCommands.EscPosEpson();

                            var BytesValue = Encoding.ASCII.GetBytes(string.Empty);
                            BytesValue = PrintExtensions.AddBytes(BytesValue, obj.Alignment.Center());
                            //
                            // IMPRIMIENDO ENCABEZADO //
                            for (int i = 0; i < xHeader.Count; i++)
                            {
                                BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes(xHeader[i]));
                            }
                            BytesValue = PrintExtensions.AddBytes(BytesValue, obj.CharSize.Nomarl());
                            // IMPRIMIENDO DETALLES //
                            for (int i = 0; i < xCodigo.Count; i++)
                            {
                                string xC = xCodigo[i];
                                string xP = xProducto[i];
                                string xQ = xCant[i];
                                string xU = xUM[i];
                                string xV = xValor[i];
                                xTotal = xTotal + Convert.ToDecimal(xV);
                                string linea = Der(xC, 8) + Der(xP, 12) + Izq(xQ, 8) + Der(xU, 4) + Izq(xV, 8) + "\n";
                                BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes(linea));
                            }
                            BytesValue = PrintExtensions.AddBytes(BytesValue, obj.CharSize.Nomarl());
                            BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes("----------------------------------------\n"));
                            BytesValue = PrintExtensions.AddBytes(BytesValue, string.Format("{0,-20}{1,10}{2,10:N2}\n", "TOTAL", "", xTotal));
                            BytesValue = PrintExtensions.AddBytes(BytesValue, string.Format("{0,-20}{2,10}{3,10:N2}\n", "OP.GRAVADA", "", "", xTotal_gravado));
                            BytesValue = PrintExtensions.AddBytes(BytesValue, string.Format("{0,-20}{2,10}{3,10:N2}\n", "OP.INAFECTA", "", "", xTotal_inafecto));
                            BytesValue = PrintExtensions.AddBytes(BytesValue, string.Format("{0,-20}{2,10}{3,10:N2}\n", "IGV (18.00%)", "", "", xTotal_igv));
                            BytesValue = PrintExtensions.AddBytes(BytesValue, string.Format("{0,-20}{2,10}{3,10:N2}\n", "OP.EXONERADA", "", "", xTotal_exonerado));
                            BytesValue = PrintExtensions.AddBytes(BytesValue, string.Format("{0,-20}{2,10}{3,10:N2}\n", "I.S.C.", "", "", xTotal_isc));
                            BytesValue = PrintExtensions.AddBytes(BytesValue, string.Format("{0,-20}{2,10}{3,10:N2}\n", "IMPORTE TOTAL", "", "", xTotal));
                            BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes("Conserve su comprobante\n"));
                            // IMPRESION DE PIE DE COMPROBANTE //
                            for (int i = 0; i < xFooter.Count; i++)
                            {
                                BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes(xFooter[i]));
                            }
                            BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes("\n"));
                            BytesValue = PrintExtensions.AddBytes(BytesValue, VariablesGlobales.empresa.Str_texto);
                            BytesValue = PrintExtensions.AddBytes(BytesValue, Encoding.ASCII.GetBytes("\n"));
                            BytesValue = PrintExtensions.AddBytes(BytesValue, CutPage());
                            PrinterUtility.PrintExtensions.Print(BytesValue, GestionCombustibles.Properties.Settings.Default.PrinterPath);

                            // COMO HABILITAR LA IMPRESORA:
                            // configurar una impresora Generic/Txt apuntando a puerto FILE, renombrarla y compartirla como TMU220
                            // en Settings: crear una clave PrinterPath \\\\<nombre de esta pc>\\TMU220
                            // ejemplo : \\\\DEVELOPER_01\\TMU220
                            //
                            // FIN DE IMPRESION
                        }

                        Descartar();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al registrar la operación.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.ToString());
            }
        }

        private void btnDescartar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Descartar();
            }
            catch (Exception ex)
            {
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (this.flgCalcularCantTotal == 0)
            {
                decimal precioUnitario = decimal.Parse((string.IsNullOrEmpty(this.txtPUnit.Text) ? "0.00" : this.txtPUnit.Text));
                decimal cantidad = decimal.Parse((string.IsNullOrEmpty(this.txtCantidad.Text) ? "0.00" : this.txtCantidad.Text));
                decimal totalItem = decimal.Round((precioUnitario * cantidad), 2);
                this.flgCalcularCantTotal = 1;
                this.txtTotalItem.Text = totalItem.ToString();
                this.flgCalcularCantTotal = 0;
            }
        }
        private void txtTotalItem_TextChanged(object sender, EventArgs e)
        {
            if (this.flgCalcularCantTotal == 0)
            {
                decimal precioUnitario = decimal.Parse((string.IsNullOrEmpty(this.txtPUnit.Text) ? "0.00" : this.txtPUnit.Text));
                decimal totalItem = decimal.Parse((string.IsNullOrEmpty(this.txtTotalItem.Text) ? "0.00" : this.txtTotalItem.Text));
                decimal cantidad = decimal.Round(totalItem / precioUnitario,4);
                this.flgCalcularCantTotal = 1;
                this.txtCantidad.Text = cantidad.ToString();
                this.flgCalcularCantTotal = 0;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtTotalItem_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtEfectivoDolares_TextChanged(object sender, EventArgs e)
        {
            this.CalcularPago();
        }

        private void txtEfectivoSoles_TextChanged(object sender, EventArgs e)
        {
            this.CalcularPago();
        }

        private void txtTarjetaSoles_TextChanged(object sender, EventArgs e)
        {
            this.CalcularPago();
        }

        private void txtUsarLineaCred_TextChanged(object sender, EventArgs e)
        {
            this.CalcularPago();
        }

        private void txtPagoSoles_TextChanged(object sender, EventArgs e)
        {
            this.CalcularVuelto();
        }

        private void txtVentaSoles_TextChanged(object sender, EventArgs e)
        {
            this.CalcularVuelto();
        }
    }
}