using Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento;
using Informatica_Peruana.SGC.BL_Sistema_SGC.Mantenimiento;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestionCombustibles.Archivo
{
    public partial class frm_Login : Form
    {
        private BE_Usuarios pBE_Usuarios = new BE_Usuarios();
        private BL_Usuarios pBL_Usuarios = new BL_Usuarios();
        private BE_Operador pBE_Operador = new BE_Operador();
        private BL_Operador pBL_Operador = new BL_Operador();
        private BE_empresa_calcimp pBE_Empresa_CalcImp = new BE_empresa_calcimp();
        private BL_Empresa_CalcImp pBL_Empresa_CalcImp = new BL_Empresa_CalcImp();

        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            this.txtusuario.Text = "javila";
            this.txtclave.Text = "123456";
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese Usuario");
            }
            else
            {
                if (txtclave.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Ingrese Clave");
                }
                else
                {
                    List<BE_Operador> Lista_Operador = new List<BE_Operador>();
                    pBE_Operador = new BE_Operador();
                    pBL_Operador = new BL_Operador();

                    pBE_Operador.Str_Usuario_Operador = txtusuario.Text.ToString();
                    pBE_Operador.Str_Clave_Operador = txtclave.Text.ToString();

                    Lista_Operador = BL_Operador.Listar_Operador_Logueo(pBE_Operador);

                    if (Lista_Operador.Count > 0)
                    {
                        MessageBox.Show("BIENVENIDO " + Lista_Operador[0].Str_Nombre_Operador + " " + Lista_Operador[0].Str_ApePaterno_Operador + " " + Lista_Operador[0].Str_ApeMaterno_Operador);
                        VariablesGlobales.operador_actual = Lista_Operador[0];

                        List<BE_empresa_calcimp> Lista_empresa_calcimp = new List<BE_empresa_calcimp>();
                        Lista_empresa_calcimp = BL_Empresa_CalcImp.Listar_Empresas_CalcImp_x_ID(new BE_empresa_calcimp() { ID = 13, ID_CalcImp = 1 });

                        if (Lista_empresa_calcimp.Count > 0)
                            VariablesGlobales.empresa_calcimp_actual = Lista_empresa_calcimp[0];

                        List<BE_Empresa> Lista_Empresa = new List<BE_Empresa>();
                        Lista_Empresa = BL_Empresa.Listar_Empresa(new BE_Empresa() { Str_texto_buscar = "" });

                        if (Lista_Empresa.Count > 0)
                            VariablesGlobales.empresa = Lista_Empresa[0];

                        this.Hide();
                        Main abrir = new Main();
                        //abrir.Usuario_Logueado = Lista_Usuario;
                        abrir.Show();
                    }
                    else
                    {
                        txtusuario.Clear();
                        txtclave.Clear();
                        txtusuario.Focus();
                        MessageBox.Show("Usuario no exite");
                    }
                }
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtusuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtusuario.Text.Trim().Length > 0)
                {
                    txtclave.Focus();
                }
            }
        }

        private void txtclave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtclave.Text.Trim().Length > 0)
                {
                    Ingresar.Focus();
                }
            }
        }
    }
}