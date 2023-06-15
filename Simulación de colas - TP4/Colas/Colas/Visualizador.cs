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
        decimal mediaLlegada;
        decimal mediaAP;
        decimal mediaAE;
        decimal mediaAC;
        decimal mediaACM;
        DataTable dt;

        public Visualizador(decimal mediaLlegada, decimal mediaAP, decimal mediaAE, decimal mediaAC, decimal mediaACM)
        {
            InitializeComponent();
            this.mediaLlegada = mediaLlegada;
            this.mediaAP = mediaAP;
            this.mediaAE = mediaAE;
            this.mediaAC = mediaAC;
            this.mediaACM = mediaACM;
        }


        // -----INSTRUCCIONES-----
        //
        //
        // Tipos de métodos:
        // - nombreDeEvento(): Métodos que contienen la lógica celda por celda de cada evento.
        // - generarX(): Fórmula (igual al Excel) que genera un valor para una celda relacionada con números aleatorios.
        // - Métodos auxiliares (por ejemplo, para encontrar la cola con menos objetos, etc)
        //
        // EN LOS EVENTOS, UNA VARIABLE POR CELDA, INCLUSO SI NO SE USA EN EL EVENTO EN CUESTIÓN
        //
        // Asegurarse que en los métodos de los eventos esté SÓLO EL ORDEN DE LAS LLAMADAS QUE NECESITA EL EVENTO, y nó la lógica de las fórmulas de las celdas
        // Así también (y más importante), verificar que en los métodos con las fórmulas de las celdas no haya ninguna lógica propia de eventos (para que se pueda usar el mismo método
        // independientemente del evento en cuestión).


        // Generadores
        public decimal? generarRandom()
        {
            Random random = new Random();
            decimal? numeroAleatorio = Convert.ToDecimal(random.NextDouble());
            return numeroAleatorio;
        }

        public decimal? generarTiempoLlegada(decimal? rnd)
        {
            decimal? tiempoLlegada = Convert.ToDecimal(-Convert.ToDouble(mediaLlegada) * Math.Log(Convert.ToDouble(1 - rnd)));
            return tiempoLlegada;
        }

        public decimal? generarProximaLlegada(decimal? reloj, decimal? tiempo)
        {
            decimal? proximaLlegada = reloj + tiempo;

            return proximaLlegada;
        }

        public decimal? generarTiempoFinAP(decimal? rnd)
        {
            decimal? tiempoFinAP = Convert.ToDecimal(-Convert.ToDouble(mediaAP) * Math.Log(Convert.ToDouble(1 - rnd)));
            return tiempoFinAP;
        }

        public decimal? generarProximoFinAP(decimal? reloj, decimal? tiempoFinAP)
        {
            decimal? proximoFinAP = reloj + tiempoFinAP;
            return proximoFinAP;
        }


        // Métodos auxiliares
        public int? obtenerColaMenor(int? colaPark1, int? colaPark2, int? colaPark3, int? colaPark4, int? colaPark5)
        {
            List<int?> colas = new List<int?> { colaPark1, colaPark2, colaPark3, colaPark4, colaPark5 };
            int? menor = colas.Min();
            return menor;
        }

        public string obtenerProximoEvento(decimal? proximoFinAP1, decimal? proximoFinAP2, decimal? proximoFinAP3, decimal? proximoFinAP4, decimal? proximoFinAP5, decimal? proximoFinAE1, decimal? proximoFinAE2, decimal? proximoFinAE3, decimal? proximoFinAE4, decimal? proximoFinAE5, decimal? proximoFinAE6,
                decimal? proximoFinAC1, decimal? proximoFinAC2, decimal? proximoFinAC3, decimal? proximoFinAC4, decimal? proximoFinACM)
        {
            List<decimal?> ListaFin = new List<decimal?> { proximoFinAP1, proximoFinAP2, proximoFinAP3, proximoFinAP4, proximoFinAP5, proximoFinAE1, proximoFinAE2, proximoFinAE3, proximoFinAE4, proximoFinAE5, proximoFinAE6, proximoFinAC1, proximoFinAC2, proximoFinAC3, proximoFinAC4, proximoFinACM };

            decimal? eventoMin = ListaFin.Min();

            string eventoProximo = "";

            if (eventoMin == proximoFinAP1 || eventoMin == proximoFinAP2 || eventoMin == proximoFinAP3 || eventoMin == proximoFinAP4 || eventoMin == proximoFinAP5)

            { eventoProximo = "Fin AP"; }

            else if (eventoMin == proximoFinAE1 || eventoMin == proximoFinAE2 || eventoMin == proximoFinAE3 || eventoMin == proximoFinAE4 || eventoMin == proximoFinAE5 || eventoMin == proximoFinAE6)

            { eventoProximo = "Fin AE"; }

            else if (eventoMin == proximoFinAC1 || eventoMin == proximoFinAC2 || eventoMin == proximoFinAC3)

            { eventoProximo = "Fin AC"; }

            else if (eventoMin == proximoFinACM)

            { eventoProximo = "Fin ACM"; }

            return eventoProximo;
        }


        // Eventos
        public void llegadaAuto(DataRow filaAnterior)
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

            proximoFinAP1 = Convert.ToDecimal(filaAnterior["proximoFinAP1"]);
            proximoFinAP2 = Convert.ToDecimal(filaAnterior["proximoFinAP2"]);
            proximoFinAP3 = Convert.ToDecimal(filaAnterior["proximoFinAP3"]);
            proximoFinAP4 = Convert.ToDecimal(filaAnterior["proximoFinAP4"]);
            proximoFinAP5 = Convert.ToDecimal(filaAnterior["proximoFinAP5"]);

            if (filaAnterior["proximoFinAP1"] == null)
            {
                proximoFinAP1 = generarProximoFinAP(reloj, tiempoFinAP);
            }
            else if (filaAnterior["proximoFinAP2"] == null)
            {
                proximoFinAP2 = generarProximoFinAP(reloj, tiempoFinAP);
            }
            else if (filaAnterior["proximoFinAP3"] == null)
            {
                proximoFinAP3 = generarProximoFinAP(reloj, tiempoFinAP);
            }
            else if (filaAnterior["proximoFinAP4"] == null)
            {
                proximoFinAP4 = generarProximoFinAP(reloj, tiempoFinAP);
            }
            else if (filaAnterior["proximoFinAP5"] == null)
            {
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
                grdAutos.Rows.Add("SiendoAt");
            }
            else if (estadoCajaPark2 == "Libre")
            {
                estadoCajaPark2 = "Ocupada";
                grdAutos.Rows.Add("SiendoAt");
            }
            else if (estadoCajaPark3 == "Libre")
            {
                estadoCajaPark3 = "Ocupada";
                grdAutos.Rows.Add("SiendoAt");
            }
            else if (estadoCajaPark4 == "Libre")
            {
                estadoCajaPark4 = "Ocupada";
                grdAutos.Rows.Add("SiendoAt");
            }
            else if (estadoCajaPark5 == "Libre")
            {
                estadoCajaPark5 = "Ocupada";
                grdAutos.Rows.Add("SiendoAt");
            }
            else
            {
                int? colaMasChica = obtenerColaMenor(colaPark1, colaPark2, colaPark3, colaPark4, colaPark5);

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

            tiempoEnConseguirEntrada = 300 + tiempoPromedioEnColaEntrada + 92;
            cantidadPromedioGenteEnColaEntrada = (acumuladorTiempoColaEntrada / reloj) * (decimal)4.16;
            tiempoEntradaDespuesDeEstacionar = tiempoEnConseguirEntrada + tiempoPromedioEnColaComida + 5;



            // Manejo de tabla y próximo evento

            // Eliminar fila anterior
            dt.Rows.Remove(filaAnterior);

            // Agregar la nueva fila
            dt.Rows.Add(evento, reloj, rndLlegada, tiempoLlegada, proximaLlegada, rndFinAP, tiempoFinAP, proximoFinAP1, proximoFinAP2, proximoFinAP3, proximoFinAP4, proximoFinAP5,
                rndFinAE, tiempoFinAE, proximoFinAE1, proximoFinAE2, proximoFinAE3, proximoFinAE4, proximoFinAE5, proximoFinAE6, rndCantidadPersonas, cantidadPersonas, rndCantidadPersonasMayores,
                cantidadPersonasMayores, cantidadPersonasNoMayores, rndFinAC1, tiempoFinAC1, proximoFinAC1, rndFinAC2, tiempoFinAC2, proximoFinAC2, rndFinAC3, tiempoFinAC3, proximoFinAC3,
                rndFinAC4, tiempoFinAC4, proximoFinAC4, rndFinACM, tiempoFinACM, proximoFinACM, colaPark1, estadoCajaPark1, colaPark2, estadoCajaPark2, colaPark3, estadoCajaPark3, colaPark4, estadoCajaPark4,
                colaPark5, estadoCajaPark5, colaEntrada1y2, estadoCajaEntrada1, estadoCajaEntrada2, colaEntrada3y4, estadoCajaEntrada3, estadoCajaEntrada4, colaEntrada5y6, estadoCajaEntrada5, estadoCajaEntrada6,
                colaComida1, estadoControlComida1, colaComida2, estadoControlComida2, colaComida3, estadoControlComida3, colaComida4, estadoControlComida4, colaComidaMayores, estadoControlComidaMayores,
                metrosPromedioNecesariosParaAparcamiento, acumuladorTiempoColaParking, cantidadPromedioAutosEnColaPark, contadorGruposCajaEntrada, acumuladorTiempoColaEntrada, tiempoPromedioEnColaEntrada,
                contadorPersonasEnControlComida, acumuladorTiempoColaComida, tiempoPromedioEnColaComida, tiempoEnConseguirEntrada, cantidadPromedioGenteEnColaEntrada, tiempoEntradaDespuesDeEstacionar);

            // Guardar la nueva fila en una variable para enviársela al próximo evento
            DataRow filaActual = dt.Rows[0];

            // Determinar el próximo evento

            string proxEvento = obtenerProximoEvento(proximoFinAP1, proximoFinAP2, proximoFinAP3, proximoFinAP4, proximoFinAP5, proximoFinAE1, proximoFinAE2, proximoFinAE3, proximoFinAE4, proximoFinAE5, proximoFinAE6,
                proximoFinAC1, proximoFinAC2, proximoFinAC3, proximoFinAC4, proximoFinACM);

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

        public void finAtencionParking(DataRow filaAnterior)
        {
            throw new NotImplementedException();
        }

        public void finAtencionEntrada(DataRow filaAnterior)
        {
            throw new NotImplementedException();
        }

        public void finAtencionComida(DataRow filaAnterior)
        {
            throw new NotImplementedException();
        }

        public void finAtencionComidaMayores(DataRow filaAnterior)
        {
            throw new NotImplementedException();
        }
    }
}
