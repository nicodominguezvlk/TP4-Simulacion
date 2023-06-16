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

        public bool validarParametros()
        {
            if (int.TryParse(txtCantSimulaciones.Text, out int cant))
            {
                if (int.TryParse(txtVerDesde.Text, out int desde))
                {
                    if (!int.TryParse(txtVerHasta.Text, out int hasta))
                    {
                        MessageBox.Show("Valor 'ver hasta' inválido.");
                        return false;
                    }
                }
                else { MessageBox.Show("Valor 'ver desde' inválido."); return false; }
            }
            else { MessageBox.Show("Cantidad de simulaciones inválidas."); return false; }

            if (int.Parse(txtVerHasta.Text) - int.Parse(txtVerDesde.Text) <= 0)
            {
                MessageBox.Show("El valor 'desde' debe ser menor al valor 'hasta'."); return false;
            }

            return true;
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            btnSimular.Enabled = false;
            if (validarParametros())
            {
                Visualizador visualizador = new Visualizador(this, Convert.ToDecimal(txtMediaLLegadaAuto.Text), Convert.ToDecimal(txtMediaAtenciónParking.Text), Convert.ToDecimal(txtMediaAtenciónEntrada.Text), Convert.ToDecimal(txtMediaControlComida.Text), Convert.ToDecimal(txtMediaControlComidaMayores.Text), Convert.ToInt32(txtCantSimulaciones.Text), Convert.ToInt32(txtVerDesde.Text), Convert.ToInt32(txtVerHasta.Text));
                visualizador.Show();
                Hide();
                btnSimular.Enabled = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Hace que solo se puedan ingresar números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
