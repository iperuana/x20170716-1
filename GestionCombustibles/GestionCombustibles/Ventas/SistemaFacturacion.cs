using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCombustibles
{
    public partial class SistemaFacturacion : Form
    {
        public SistemaFacturacion()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void SistemaFacturacion_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            reportes.rptComprobante fr = new reportes.rptComprobante();
            fr.ShowDialog();
        }
    }
}
