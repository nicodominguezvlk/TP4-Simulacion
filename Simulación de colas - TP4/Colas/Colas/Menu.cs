using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            Visualizador visualizador = new Visualizador(Convert.ToDecimal(txtMediaLLegadaAuto.Text), Convert.ToDecimal(txtMediaAtenciónParking.Text), Convert.ToDecimal(txtMediaAtenciónEntrada.Text), Convert.ToDecimal(txtMediaControlComida.Text), Convert.ToDecimal(txtMediaControlComidaMayores.Text));
            visualizador.Show();
            Hide();
        }
    }
}
