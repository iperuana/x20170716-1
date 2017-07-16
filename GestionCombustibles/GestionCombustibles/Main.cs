using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Informatica_Peruana.SGC.BE_Sistema_SGC;
using Informatica_Peruana.SGC.BL_Sistema_SGC;
using Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento;

namespace GestionCombustibles
{
    public partial class Main : Form
    {
        //public List<BE_Usuarios> Usuario_Logueado = new List<BE_Usuarios>();
        //public List<BE_Usuarios> Usuario_Logueado = new List<BE_Usuarios>();

        public Main()
        {
            InitializeComponent();
        }

        private void tipoDeCambioDelDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_TCambio fr = new frm_TCambio();
            fr.ShowDialog ();
        }
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Archivo.frm_Cliente fr = new Archivo.frm_Cliente();
            fr.ShowDialog();
        }
        private void producotsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Archivo.Productos fr = new Archivo.Productos();
            fr.ShowDialog();
        }
        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
   
        }
        private void emisionFacturasBoletasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas.VentasDiarias  fr = new Ventas.VentasDiarias();
            fr.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void correlativoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Archivo.frm_Documentos fr = new Archivo.frm_Documentos();
            fr.ShowDialog();
        }
        private void operadoresUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Archivo.frm_Operadores_Usuarios fr = new Archivo.frm_Operadores_Usuarios();
            fr.ShowDialog();
        }
        private void turnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Archivo.frm_Turnos fr = new Archivo.frm_Turnos();
            fr.ShowDialog();
        }
        private void ladosCarasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Archivo.frm_Lados_Caras fr = new Archivo.frm_Lados_Caras();
            fr.ShowDialog();
        }
        private void surtidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Archivo.frm_Surtidores fr = new Archivo.frm_Surtidores();
            fr.ShowDialog();
        }
        private void cambioDeClaveDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Archivo.frm_cambio_De_Clave_DeUsuario fr = new Archivo.frm_cambio_De_Clave_DeUsuario();
            //fr.Usuario_Login = Usuario_Logueado;
            //fr.ShowDialog();
        }
        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Archivo.frm_Empresa fr = new Archivo.frm_Empresa();
            fr.ShowDialog();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cobranzaDeCreditoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cobranza.Cobranza_de_Credito fr = new Cobranza.Cobranza_de_Credito();
            fr.ShowDialog();
        }
        private void islasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Archivo.frm_Islas fr = new Archivo.frm_Islas();
            fr.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Archivo.frm_Usuario fr = new Archivo.frm_Usuario();
            fr.ShowDialog();
        }

        private void emisiónComprobanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas.Emision_de_Comprobante fr = new Ventas.Emision_de_Comprobante();
            fr.ShowDialog();
        }
    }
}
