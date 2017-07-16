using Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento;
using Informatica_Peruana.SGC.BL_Sistema_SGC.Mantenimiento;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GestionCombustibles.Archivo
{
    public partial class frm_cambio_De_Clave_DeUsuario : Form
    {
        BE_Usuarios pBE_Usuarios = new BE_Usuarios();
        BL_Usuarios pBL_Usuarios = new BL_Usuarios();

        public List<BE_Usuarios> Usuario_Login = new List<BE_Usuarios>();
        public frm_cambio_De_Clave_DeUsuario()
        {
            InitializeComponent();
        }

        private void btn_descartar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_cambio_De_Clave_DeUsuario_Load(object sender, EventArgs e)
        {
            string nombre = Usuario_Login[0].Str_Nom_Usuario;
        }

        private void btn_CUsuario_Aceptar_Click(object sender, EventArgs e)
        {
            if (txt_CUsuario_ClaveAnterior.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese la contraseña antertior");
            }
            else
            {
                if (txt_CUsuario_Nueva_Usuario.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Ingrese nueva contraseña");
                }
                else
                {
                    if (txt_CUsuario_RClave.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Repita la contraseña");
                    }
                    else
                    {
                        if (txt_CUsuario_Nueva_Usuario.Text == txt_CUsuario_RClave.Text)
                        {
                            int res = 0;
                            pBE_Usuarios = new BE_Usuarios();
                            pBL_Usuarios = new BL_Usuarios();

                            pBE_Usuarios.ID = Usuario_Login[0].ID;
                            pBE_Usuarios.Str_Clave_Usuario = txt_CUsuario_ClaveAnterior.Text.ToString();
                            pBE_Usuarios.Str_Nueva_Clave = txt_CUsuario_Nueva_Usuario.Text.ToString();

                            res = BL_Usuarios.Actualizar_Clave_Usuario(pBE_Usuarios);

                            MessageBox.Show("Exito Clave cambiada");
                            this.Hide();
                            this.Close();
                        
                        }

                        else
                        {
                            MessageBox.Show("La clave no coincide weon");
                        }

                    }
                }
            }
        }
    }
}
