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
    public partial class Metricas : Form
    {
        Visualizador visualizador;
        decimal? metrosAparc;
        decimal? cantAutosCP;
        decimal? tiempoPromCE;
        decimal? tiempoPromCC;
        decimal? tiempoEntrada;
        decimal? gentePromCE;
        decimal? entradaDE;
        public Metricas(Visualizador visualizador, DataGridViewRow ultimaFila)
        {
            InitializeComponent();
            this.visualizador = visualizador;
            metrosAparc = Convert.ToDecimal(ultimaFila.Cells["metrosPromedioNecesariosParaAparcamiento"].Value);
            cantAutosCP = Convert.ToDecimal(ultimaFila.Cells["cantidadPromedioAutosEnColaPark"].Value);
            tiempoPromCE = Convert.ToDecimal(ultimaFila.Cells["tiempoPromedioEnColaEntrada"].Value);
            tiempoPromCC = Convert.ToDecimal(ultimaFila.Cells["tiempoPromedioEnColaComida"].Value);
            tiempoEntrada = Convert.ToDecimal(ultimaFila.Cells["tiempoEnConseguirEntrada"].Value);
            gentePromCE = Convert.ToDecimal(ultimaFila.Cells["cantidadPromedioGenteEnColaEntrada"].Value);
            entradaDE = Convert.ToDecimal(ultimaFila.Cells["tiempoEntradaDespuesDeEstacionar"].Value); 

            rellenarMetricas();
        }

        public void rellenarMetricas()
        {
            lblCantMetros.Text = Convert.ToString(metrosAparc);
            lblCantidadAutosPromedio.Text = Convert.ToString(cantAutosCP);
            lblTiempoPromedioEntrada.Text = Convert.ToString(tiempoPromCE);
            lblTiempoPromedioComida.Text = Convert.ToString(tiempoPromCC);
            lblTiempoEnConseguirE.Text = Convert.ToString(tiempoEntrada);
            lblCantidadGente.Text = Convert.ToString(gentePromCE);
            lblTiempoDespEstacionar.Text = Convert.ToString(entradaDE);
        }

        private void picArrow_Click(object sender, EventArgs e)
        {
            visualizador.Show();
            this.Close();
        }

        private void picX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
