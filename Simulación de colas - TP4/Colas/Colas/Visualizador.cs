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
    public partial class Visualizador : Form
    {
        public Visualizador()
        {
            InitializeComponent();
        }


        // -----INSTRUCCIONES-----
        //
        //
        // Tipos de métodos:
        // - nombreDeEvento(): Métodos que contienen la lógica celda por celda de cada evento.
        // - generarX(): Fórmula (igual al Excel) que genera un valor para una celda relacionada con números aleatorios.
        // - Eventos de manejo de tabla (por ejemplo, para agregar una fila, agregar un objeto temporal, etc)
        // - Eventos auxiliares (por ejemplo, para encontrar la cola con menos objetos, etc)
        //
        // EN LOS EVENTOS, UNA VARIABLE POR CELDA, INCLUSO SI NO SE USA EN EL EVENTO EN CUESTIÓN
        //
        // Asegurarse que en los métodos de los eventos esté SÓLO EL ORDEN DE LAS LLAMADAS QUE NECESITA EL EVENTO, y nó la lógica de las fórmulas de las celdas
        // Así también (y más importante), verificar que en los métodos con las fórmulas de las celdas no haya ninguna lógica propia de eventos (para que se pueda usar el mismo método
        // independientemente del evento en cuestión).

        DataRow llegadaAuto(DataRow filaAnterior) //TERMINAR
        {
            // Nombres de las variables (una por cada columna)
            string evento;
            decimal reloj;

            decimal? rndLlegada;
            decimal? tiempoLlegada;
            decimal? proximaLlegada;

            decimal? rndFinAP;
            decimal? tiempoFinAP;
            decimal? proximoFinAP1;
            decimal? proximoFinAP2;
            decimal? proximoFinAP3;
            decimal? proximoFinAP4;
            decimal? proximoFinAP5;

            decimal? rndFinAE;
            decimal? tiempoFinAE;
            decimal? proximoFinAE1;
            decimal? proximoFinAE2;
            decimal? proximoFinAE3;
            decimal? proximoFinAE4;
            decimal? proximoFinAE5;
            decimal? proximoFinAE6;
            decimal? rndCantidadPersonas;
            int? cantidadPersonas;
            decimal? rndCantidadPersonasMayores;
            int? cantidadPersonasMayores;
            int? cantidadPersonasNoMayores;

            decimal? rndFinAC1;
            decimal? tiempoFinAC1;
            decimal? proximoFinAC1;
            decimal? rndFinAC2;
            decimal? tiempoFinAC2;
            decimal? proximoFinAC2;
            decimal? rndFinAC3;
            decimal? tiempoFinAC3;
            decimal? proximoFinAC3;
            decimal? rndFinAC4;
            decimal? tiempoFinAC4;
            decimal? proximoFinAC4;

            decimal? rndFinACM;
            decimal? tiempoFinACM;
            decimal? proximoFinACM;

            int? colaPark1;
            string estadoCajaPark1;
            int? colaPark2;
            string estadoCajaPark2;
            int? colaPark3;
            string estadoCajaPark3;
            int? colaPark4;
            string estadoCajaPark4;
            int? colaPark5;
            string estadoCajaPark5;

            int? colaEntrada1y2;
            string estadoCajaEntrada1;
            string estadoCajaEntrada2;
            int? colaEntrada3y4;
            string estadoCajaEntrada3;
            string estadoCajaEntrada4;
            int? colaEntrada5y6;
            string estadoCajaEntrada5;
            string estadoCajaEntrada6;

            int? colaComida1;
            string estadoControlComida1;
            int? colaComida2;
            string estadoControlComida2;
            int? colaComida3;
            string estadoControlComida3;
            int? colaComida4;
            string estadoControlComida4;

            int? colaComidaMayores;
            string estadoControlComidaMayores;

            decimal? metrosPromedioNecesariosParaAparcamiento;
            decimal? acumuladorTiempoColaParking;
            decimal? cantidadPromedioAutosEnColaPark;
            int? contadorGruposCajaEntrada;
            decimal? acumuladorTiempoColaEntrada;
            decimal? tiempoPromedioEnColaEntrada;
            int? contadorPersonasEnControlComida;
            decimal? acumuladorTiempoColaComida;
            decimal? tiempoPromedioEnColaComida;
            decimal? tiempoEnConseguirEntrada;
            decimal? cantidadPromedioGenteEnColaEntrada;
            decimal? tiempoEntradaDespuesDeEstacionar;


            // Evento
            evento = "LL Auto";


            // Reloj
            reloj = Convert.ToDecimal(filaAnterior["reloj"]);


            // Llegada auto
            rndLlegada = generarRandom();

            tiempoLlegada = generarTiempoLlegada(rndLlegada);

            proximaLlegada = generarProximaLlegada(reloj, tiempoLlegada);


            // Fin atención parking
            rndFinAP = generarRandom();

            tiempoFinAP = generarTiempoFinAP(rndFinAP);

            if (filaAnterior["proximoFinAP1"] == null)
            {
                proximoFinAP1 = generarProximoFinAP(reloj, tiempoFinAP);
                proximoFinAP2 = Convert.ToDecimal(filaAnterior["proximoFinAP2"]);
                proximoFinAP3 = Convert.ToDecimal(filaAnterior["proximoFinAP3"]);
                proximoFinAP4 = Convert.ToDecimal(filaAnterior["proximoFinAP4"]);
                proximoFinAP5 = Convert.ToDecimal(filaAnterior["proximoFinAP5"]);
            }
            else if (filaAnterior["proximoFinAP2"] == null)
            {
                proximoFinAP1 = Convert.ToDecimal(filaAnterior["proximoFinAP1"]);
                proximoFinAP2 = generarProximoFinAP(reloj, tiempoFinAP);
                proximoFinAP3 = Convert.ToDecimal(filaAnterior["proximoFinAP3"]);
                proximoFinAP4 = Convert.ToDecimal(filaAnterior["proximoFinAP4"]);
                proximoFinAP5 = Convert.ToDecimal(filaAnterior["proximoFinAP5"]);
            }
            else if (filaAnterior["proximoFinAP3"] == null)
            {
                proximoFinAP1 = Convert.ToDecimal(filaAnterior["proximoFinAP1"]);
                proximoFinAP2 = Convert.ToDecimal(filaAnterior["proximoFinAP2"]);
                proximoFinAP3 = generarProximoFinAP(reloj, tiempoFinAP);
                proximoFinAP4 = Convert.ToDecimal(filaAnterior["proximoFinAP4"]);
                proximoFinAP5 = Convert.ToDecimal(filaAnterior["proximoFinAP5"]);
            }
            else if (filaAnterior["proximoFinAP4"] == null)
            {
                proximoFinAP1 = Convert.ToDecimal(filaAnterior["proximoFinAP1"]);
                proximoFinAP2 = Convert.ToDecimal(filaAnterior["proximoFinAP2"]);
                proximoFinAP3 = Convert.ToDecimal(filaAnterior["proximoFinAP3"]);
                proximoFinAP4 = generarProximoFinAP(reloj, tiempoFinAP);
                proximoFinAP5 = Convert.ToDecimal(filaAnterior["proximoFinAP5"]);
            }
            else if (filaAnterior["proximoFinAP5"] == null)
            {
                proximoFinAP1 = Convert.ToDecimal(filaAnterior["proximoFinAP1"]);
                proximoFinAP2 = Convert.ToDecimal(filaAnterior["proximoFinAP2"]);
                proximoFinAP3 = Convert.ToDecimal(filaAnterior["proximoFinAP3"]);
                proximoFinAP4 = Convert.ToDecimal(filaAnterior["proximoFinAP4");
                proximoFinAP5 = generarProximoFinAP(reloj, tiempoFinAP);
            }


            // Fin atención entrada
            rndFinAE = null;

            tiempoFinAE = null;

            proximoFinAE1 = Convert.ToDecimal(filaAnterior["proximoFinAE1"]);
            proximoFinAE2 = Convert.ToDecimal(filaAnterior["proximoFinAE2"]);
            proximoFinAE3 = Convert.ToDecimal(filaAnterior["proximoFinAE3"]);
            proximoFinAE4 = Convert.ToDecimal(filaAnterior["proximoFinAE4"]);
            proximoFinAE5 = Convert.ToDecimal(filaAnterior["proximoFinAE5"]);
            proximoFinAE6 = Convert.ToDecimal(filaAnterior["proximoFinAE6"]);

            rndCantidadPersonas = null;

            cantidadPersonas = null;

            rndCantidadPersonasMayores = null;

            cantidadPersonasMayores = null;

            cantidadPersonasNoMayores = null;


            // Fin atención control comida
            rndFinAC1 = null;
            tiempoFinAC1 = null;
            proximoFinAC1 = null;

            rndFinAC2 = null;
            tiempoFinAC2 = null;
            proximoFinAC2 = null;

            rndFinAC3 = null;
            tiempoFinAC3 = null;
            proximoFinAC3 = null;

            rndFinAC4 = null;
            tiempoFinAC4 = null;
            proximoFinAC4 = null;


            // Fin atención control comida mayores
            rndFinACM = null;
            tiempoFinACM = null;
            proximoFinACM = null;


            // Caja park
            colaPark1 = Convert.ToInt32(filaAnterior["colaPark1"]);
            estadoCajaPark1 = filaAnterior["estadoCajaPark1"].ToString();
            colaPark2 = Convert.ToInt32(filaAnterior["colaPark2"]);
            estadoCajaPark2 = filaAnterior["estadoCajaPark2"].ToString();
            colaPark3 = Convert.ToInt32(filaAnterior["colaPark3"]);
            estadoCajaPark3 = filaAnterior["estadoCajaPark3"].ToString();
            colaPark4 = Convert.ToInt32(filaAnterior["colaPark4"]);
            estadoCajaPark4 = filaAnterior["estadoCajaPark4"].ToString();
            colaPark5 = Convert.ToInt32(filaAnterior["colaPark5"]);
            estadoCajaPark5 = filaAnterior["estadoCajaPark5"].ToString();

            if (estadoCajaPark1 == "Libre")
            {
                estadoCajaPark1 = "Ocupada";
            }
            else if (estadoCajaPark2 == "Libre")
            {
                estadoCajaPark2 = "Ocupada";
            }
            else if (estadoCajaPark3 == "Libre")
            {
                estadoCajaPark3 = "Ocupada";
            }
            else if (estadoCajaPark4 == "Libre")
            {
                estadoCajaPark4 = "Ocupada";
            }
            else if (estadoCajaPark5 == "Libre")
            {
                estadoCajaPark5 = "Ocupada";
            }
            else
            {
                int colaMasChica = obtenerMenor(colaPark1, colaPark2, colaPark3, colaPark4, colaPark5);

                if (colaMasChica == colaPark1)
                {
                    colaPark1++;
                }
                else if (colaMasChica == colaPark2)
                {
                    colaPark2++;
                }
                else if (colaMasChica == colaPark3)
                {
                    colaPark3++;
                }
                else if (colaMasChica == colaPark4)
                {
                    colaPark4++;
                }
                else if (colaMasChica == colaPark5)
                {
                    colaPark5++;
                }
            }


            // Caja entrada
            colaEntrada1y2 = Convert.ToInt32(filaAnterior["colaEntrada1y2"]);
            estadoCajaEntrada1 = filaAnterior["estadoCajaEntrada1"].ToString();
            estadoCajaEntrada2 = filaAnterior["estadoCajaEntrada2"].ToString();

            colaEntrada3y4 = Convert.ToInt32(filaAnterior["colaEntrada3y4"]);
            estadoCajaEntrada3 = filaAnterior["estadoCajaEntrada3"].ToString();
            estadoCajaEntrada4 = filaAnterior["estadoCajaEntrada4"].ToString();

            colaEntrada5y6 = Convert.ToInt32(filaAnterior["colaEntrada5y6"]);
            estadoCajaEntrada5 = filaAnterior["estadoCajaEntrada5"].ToString();
            estadoCajaEntrada6 = filaAnterior["estadoCajaEntrada6"].ToString();


            // Control comida
            colaComida1 = Convert.ToInt32(filaAnterior["colaComida1"]);
            estadoControlComida1 = filaAnterior["estadoControlComida1"].ToString();

            colaComida2 = Convert.ToInt32(filaAnterior["colaComida2"]);
            estadoControlComida2 = filaAnterior["estadoControlComida2"].ToString();

            colaComida3 = Convert.ToInt32(filaAnterior["colaComida3"]);
            estadoControlComida3 = filaAnterior["estadoControlComida3"].ToString();

            colaComida4 = Convert.ToInt32(filaAnterior["colaComida4"]);
            estadoControlComida4 = filaAnterior["estadoControlComida4"].ToString();


            // Control comida mayores
            colaComidaMayores = Convert.ToInt32(filaAnterior["colaComidaMayores"]);
            estadoControlComidaMayores = filaAnterior["estadoControlComidaMayores"].ToString();


            // Estadísticas
            metrosPromedioNecesariosParaAparcamiento = Convert.ToDecimal(filaAnterior["cantidadPromedioAutosEnColaPark"]) * 4;
            acumuladorTiempoColaParking = (reloj - Convert.ToDecimal(filaAnterior["reloj"])) * (colaPark1 + colaPark2 + colaPark3 + colaPark4 + colaPark5) + Convert.ToDecimal(filaAnterior["acumuladorTiempoColaPark"]);
            cantidadPromedioAutosEnColaPark = acumuladorTiempoColaParking / reloj;

            contadorGruposCajaEntrada = Convert.ToInt32(filaAnterior["contadorGruposCajaEntrada"]);
            acumuladorTiempoColaEntrada = (reloj - Convert.ToDecimal(filaAnterior["reloj"])) * (colaEntrada1y2 + colaEntrada3y4 + colaEntrada5y6) + Convert.ToDecimal("acumuladorTiempoColaEntrada");
            if (contadorGruposCajaEntrada == 0)
            {
                tiempoPromedioEnColaEntrada = 0;
            }
            else
            {
                tiempoPromedioEnColaEntrada = acumuladorTiempoColaEntrada / contadorGruposCajaEntrada;
            }

            contadorPersonasEnControlComida = Convert.ToInt32(filaAnterior["contadorPersonasEnControlComida"]);
            acumuladorTiempoColaComida = (reloj - Convert.ToDecimal(filaAnterior["reloj"])) * (colaComida1 + colaComida2 + colaComida3 + colaComida4 + colaComidaMayores) + Convert.ToDecimal("acumuladorTiempoColaComida");
            if (contadorGruposCajaEntrada == 0)
            {
                tiempoPromedioEnColaComida = 0;
            }
            else
            {
                tiempoPromedioEnColaComida = acumuladorTiempoColaComida / contadorPersonasEnControlComida;
            }


            // Manejo de tabla y próximo evento
            DataRow filaActual = new DataRow();
            agregarFila(filaActual);

            if (proxEvento == "LL Auto")
            {
                llegadaAuto(filaActual);
            }
            else if (proxEvento == "Fin AP")
            {
                finAtencionParking(filaActual);
            }
            else if (proxEvento == "Fin AE")
            {
                finAtencionEntrada(filaActual);
            }
            else if (proxEvento == "Fin AC")
            {
                finAtencionComida(filaActual);
            }
            else if (proxEvento == "Fin ACM")
            {
                finAtencionComidaMayores(filaActual);
            }
        }

    }
}
