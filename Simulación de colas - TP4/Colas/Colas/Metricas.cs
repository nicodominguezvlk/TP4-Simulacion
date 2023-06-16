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
            lblCantMetros.Text = Math.Round(Convert.ToDouble(metrosAparc), 4).ToString() + "m";
            lblCantidadAutosPromedio.Text = Math.Round(Convert.ToDouble(cantAutosCP), 4).ToString();
            lblTiempoPromedioEntrada.Text = Math.Round(Convert.ToDouble(tiempoPromCE), 4).ToString() + "s";
            lblTiempoPromedioComida.Text = Math.Round(Convert.ToDouble(tiempoPromCC), 4).ToString() + "s";
            lblTiempoEnConseguirE.Text = Math.Round(Convert.ToDouble(tiempoEntrada), 4).ToString() + "s";
            lblCantidadGente.Text = Math.Round(Convert.ToDouble(gentePromCE), 4).ToString();
            lblTiempoDespEstacionar.Text = Math.Round(Convert.ToDouble(entradaDE), 4).ToString() + "s";
        }

        private void picArrow_Click(object sender, EventArgs e)
        {
            visualizador.Show();
            Close();
        }

        private void picX_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
