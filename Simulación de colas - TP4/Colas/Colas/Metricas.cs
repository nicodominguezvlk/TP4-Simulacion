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
        public Metricas(Visualizador visualizador, decimal? metrosPromedioAparcamiento, decimal? cantPromAutosColaPark, decimal? tiempoPromColaEntrada, decimal? tiempoPromColaComida, decimal? tiempoConseguirEntrada, 
                        decimal? cantPromGenteColaEntrada,decimal? tiempoEntradaDespuesEstacionar)
        {
            InitializeComponent();
            this.visualizador = visualizador;
            metrosAparc = metrosPromedioAparcamiento;
            cantAutosCP = cantPromAutosColaPark;
            tiempoPromCE = tiempoPromColaEntrada;
            tiempoPromCC = tiempoPromColaComida;
            tiempoEntrada = tiempoConseguirEntrada;
            gentePromCE = cantPromGenteColaEntrada;
            entradaDE = tiempoEntradaDespuesEstacionar;

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
