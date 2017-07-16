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
    public partial class Login : Form
    {
        BE_Usuarios pBE_Usuarios = new BE_Usuarios();
        BL_Usuarios pBL_Usuarios = new BL_Usuarios();

        BE_Operador pBE_Operador = new BE_Operador();
        BL_Operador pBL_Operador = new BL_Operador();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    //List<BE_Usuarios> Lista_Usuario = new List<BE_Usuarios>();
                    //pBE_Usuarios = new BE_Usuarios();
                    //pBL_Usuarios = new BL_Usuarios();

                    //pBE_Usuarios.Str_Usuario = txtusuario.Text.ToString();
                    //pBE_Usuarios.Str_Clave_Usuario = txtclave.Text.ToString();

                    //Lista_Usuario = BL_Usuarios.Loguear(pBE_Usuarios);

                    //if (Lista_Usuario.Count>0)
                    //{
                    //    MessageBox.Show("BIENVENIDO "+ txtusuario.Text);

                    //    Main abrir = new Main();
                    //    abrir.Show();
                    //}
                    //else
                    //{
                    //    txtusuario.Clear();
                    //    txtclave.Clear();
                    //    txtusuario.Focus();
                    //    MessageBox.Show("Usuario no exite");
                    //}


                    List<BE_Operador> Lista_Operador = new List<BE_Operador>();
                    pBE_Operador = new BE_Operador();
                    pBL_Operador = new BL_Operador();

                    pBE_Operador.Str_Usuario_Operador = txtusuario.Text.ToString();
                    pBE_Operador.Str_Clave_Operador = txtclave.Text.ToString();

                    Lista_Operador = BL_Operador.Listar_Operador_Logueo(pBE_Operador);

                    if (Lista_Operador.Count > 0)
                    {
                        MessageBox.Show("BIENVENIDO " + txtusuario.Text);

                        Main abrir = new Main();
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
    }

}
