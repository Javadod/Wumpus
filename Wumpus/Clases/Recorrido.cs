using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wumpus.Clases
{
    class Recorrido
    {
        public Movimiento movimientoInicial { get; set; }

        public Recorrido(Jugador jugador, Tablero tablero)
        {
            movimientoInicial = new Movimiento(jugador, tablero);
            movimientoInicial.movimientoSiguiente = null;
        }
        public Movimiento last()
        {
            Movimiento actual = movimientoInicial;
            while (actual.movimientoSiguiente != null)
            {
                actual = actual.movimientoSiguiente;
            }
            return actual;
        }
        public void nuevoMovimiento(Movimiento movimiento)
        {
            Movimiento actual = last();
           
            Movimiento nuevoMovimiento = new Movimiento(movimiento.jugador,movimiento.tablero);
            nuevoMovimiento.movimientoSiguiente = null;
            actual.movimientoSiguiente = nuevoMovimiento;
         
        }

        internal void retrocede()
        {
            Movimiento actual = movimientoInicial;
            Movimiento anterior = actual;
            while (actual.movimientoSiguiente != null)
            {
                anterior = actual;
                actual = actual.movimientoSiguiente;
            }

            //Casilla ultimaPosicion = new Casilla(actual.posicionActual.fila,actual.posicionActual.columna);
            //actual.jugador.posicionActual = ultimaPosicion;
            actual.jugador.posicionActual = anterior.posicionActual;
            //anterior.posicionActual = ultimaPosicion;
            anterior.movimientoSiguiente = null;
            
        }
    }
    
}
