using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCombustibles.Cobranza
{
    public partial class Cobranza_de_Credito : Form
    {
        public Cobranza_de_Credito()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sub_Cobranza_de_Credito fr = new Sub_Cobranza_de_Credito();
            fr.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sub_Cobranza_de_Credito fr = new Sub_Cobranza_de_Credito();
            fr.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seguro que desea Eliminar", "Correlativo de Documentos",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }
    }
}
