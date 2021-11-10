using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wumpus.Clases
{
    class Movimiento
    {
        public Jugador jugador;
        public Casilla posicionActual;
        public Movimiento movimientoSiguiente { get; set; }
        public Tablero tablero;

        public Movimiento(Jugador jugador, Tablero tablero)
        {
            this.jugador = jugador;
            this.tablero = tablero;
            this.posicionActual = new Casilla(jugador.posicionActual.fila, jugador.posicionActual.columna);
            this.posicionActual.contenido = jugador.posicionActual.contenido;
        }
        
        public Movimiento mejorMovimiento()
        {
            
            int filaActual = jugador.posicionActual.fila;
            int columnaActual = jugador.posicionActual.columna;
            List<Casilla> adyacentesList = new List<Casilla>();
            if (columnaActual + 1 < 4)
                adyacentesList.Add(jugador.baseConocimiento[filaActual, columnaActual + 1]);
            if (filaActual + 1 < 4)
                adyacentesList.Add(jugador.baseConocimiento[filaActual + 1, columnaActual]);
            if (columnaActual - 1 >= 0)
                adyacentesList.Add(jugador.baseConocimiento[filaActual, columnaActual - 1]);
            if (filaActual - 1 >= 0)
                adyacentesList.Add(jugador.baseConocimiento[filaActual - 1, columnaActual]);
            
            
            Casilla[] adyacentes = adyacentesList.ToArray();
            Casilla mejorCasilla = checkValoresHeuristica(adyacentes);
            if (mejorCasilla == null)
            {
                return null;
            }
            else
            {
                Movimiento mejorMovimiento = new Movimiento(jugador,tablero);

                jugador.posicionActual = tablero.mapa[mejorCasilla.fila, mejorCasilla.columna];
                jugador.posicionActual.contenido = tablero.mapa[mejorCasilla.fila, mejorCasilla.columna].contenido;

                mejorMovimiento.posicionActual.contenido = jugador.posicionActual.contenido;

                
                return mejorMovimiento;
            }
            

        }

        public bool checkMovimientos(Casilla[,] baseConocimiento)
        {
            for (int i = 0; i < baseConocimiento.GetLength(0); i++)
            {
                for (int j = 0; j < baseConocimiento.GetLength(1); j++)
                {
                    if (baseConocimiento[i, j].contenido.Contains("ok") && !baseConocimiento[i, j].contenido.Contains("visitado"))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private Casilla checkValoresHeuristica(Casilla[] adyacentes)
        {
            int puntaje;
            int mejorPuntaje = -1;
            Casilla mejorCasilla= null;
            for (int i = 0; i < adyacentes.Length; i++)
            {
                puntaje = -1;
                if (adyacentes[i].contenido.Contains("wumpus") || adyacentes[i].contenido.Contains("posible wumpus"))
                {
                    puntaje += -1000;
                }
                if (adyacentes[i].contenido.Contains("hoyo") || adyacentes[i].contenido.Contains("posible hoyo"))
                {
                    puntaje += -1000;
                }
                if (adyacentes[i].contenido.Contains("oro") || adyacentes[i].contenido.Contains("posible oro"))
                {
                    puntaje += +1002;
                }
                if (adyacentes[i].contenido.Contains("ok")&&!adyacentes[i].contenido.Contains("visitado"))
                {
                    puntaje += 1;
                }
                if (puntaje == 1)
                {
                    if(adyacentes[i].contenido.Contains("wumpus")&& adyacentes[i].contenido.Contains("oro")&& !adyacentes[i].contenido.Contains("posible wumpus")&& !adyacentes[i].contenido.Contains("posible oro"))
                    {
                        jugador.flecha = false;
                        jugador.sentidos.grito = true;
                        
                    }
                }
                if (puntaje > mejorPuntaje)
                {
                    mejorCasilla = adyacentes[i];
                    mejorPuntaje = puntaje;
                }
            }
            
                return mejorCasilla;
        }
    }
}
