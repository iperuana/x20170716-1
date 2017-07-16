using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Informatica_Peruana.SGC.BE_Sistema_SGC.Mantenimiento;
using Informatica_Peruana.SGC.BL_Sistema_SGC.Mantenimiento;
using System.Windows.Forms;

namespace GestionCombustibles.Archivo
{
    public partial class frm_Sub_Turnos : Form
    {
        //private frm_Sub_Turnos frmTurnos = new frm_Sub_Turnos();
        public int Dato { get; set; }
        BE_Turnos pBE_Turnos = new BE_Turnos();
        BL_Turnos pBL_Turnos = new BL_Turnos();
        public void Listar_Turnos_x_ID()
        {
            List<BE_Turnos> Listar_Turnos_x_ID = new List<BE_Turnos>();
            pBE_Turnos = new BE_Turnos();
            pBL_Turnos = new BL_Turnos();

            pBE_Turnos.ID = Convert.ToInt32(txt_Turnos_ID.Text);

            Listar_Turnos_x_ID = BL_Turnos.Listar_Turnos_x_ID(pBE_Turnos);

            txt_Turnos_codigo.Text = Convert.ToString(Listar_Turnos_x_ID[0].Str_cod_turno);
            mtb_Turno_inicio.Text = Convert.ToString(Listar_Turnos_x_ID[0].Str_hora_inicio);
            mtb_Turno_fin.Text = Convert.ToString(Listar_Turnos_x_ID[0].Str_hora_fin);
        }
        public void Registrar_Turnos()
        {
            int res = 0;
            pBE_Turnos = new BE_Turnos();
            pBL_Turnos = new BL_Turnos();

            pBE_Turnos.ID = Convert.ToInt32(txt_Turnos_ID.Text);
            pBE_Turnos.Str_cod_turno = txt_Turnos_codigo.Text;
            pBE_Turnos.Str_hora_inicio = mtb_Turno_inicio.Text;
            pBE_Turnos.Str_hora_fin = mtb_Turno_fin.Text;

            if (Convert.ToInt32(txt_Turnos_ID.Text) == 0)
            {
                pBE_Turnos.IDUsuarioCreacion = 1;
                res = BL_Turnos.Registrar_Turnos(pBE_Turnos);
            }
            else
            {
                pBE_Turnos.IDUsuarioModificacion = 1;
                res = BL_Turnos.Actualizar_Turnos(pBE_Turnos);
            }
        }

        public frm_Sub_Turnos()
        {
            InitializeComponent();
        }

        private void btn_descartar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Sub_Turnos_Load(object sender, EventArgs e)
        {
            txt_Turnos_ID.Text = Dato.ToString();
            if (this.Dato > 0)
            {
                Listar_Turnos_x_ID();
            }

        }

        private void btn_Turno_aceptar_Click(object sender, EventArgs e)
        {
            this.Registrar_Turnos();
            Archivo.frm_Turnos F = new Archivo.frm_Turnos();
            this.Close();
        }
    }
}
