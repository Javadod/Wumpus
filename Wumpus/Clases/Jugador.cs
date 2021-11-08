using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wumpus.Clases
{
    class Jugador {
        public bool flecha { get; set; }
        public int puntaje { get; set; }
        public Sentidos sentidos { get; set; }
        public Casilla posicionActual { get; set; }
        public Casilla[,] baseConocimiento { get; set; }
        public Jugador (Casilla posicionActual, int tamTablero) {
            this.flecha = true;
            this.puntaje = 0;
            this.sentidos = new Sentidos(false,false,false,false);
            this.posicionActual = posicionActual;
            this.baseConocimiento = new Casilla[tamTablero, tamTablero];
            startBaseConocimiento(tamTablero);
            estadoActual();
        }
        private void startBaseConocimiento(int tamano)
        {
            if (tamano <= 2) return;
            for (int i = 0; i < tamano; i++)
                for (int j = 0; j < tamano; j++)
                    this.baseConocimiento[i, j] = new Casilla(i, j);
        }
        public void lanzarFlecha () {
            this.flecha = false;
        }
        
        public bool estadoActual()
        {
            int filaActual = posicionActual.fila;
            int columnaActual = posicionActual.columna;

            //muerto
            if (posicionActual.contenido.Contains("wumpus") || posicionActual.contenido.Contains("hoyo"))
                return false;
            //vivo

            if (!baseConocimiento[filaActual, columnaActual].contenido.Contains("visitado"))
            {
                baseConocimiento[filaActual, columnaActual].contenido.Add("visitado");
                if (posicionActual.contenido.Contains("hedor"))
                    updateBaseConocimiento(filaActual, columnaActual, "wumpus");
                if (posicionActual.contenido.Contains("brisa"))
                    updateBaseConocimiento(filaActual, columnaActual, "hoyo");
                if (posicionActual.contenido.Contains("brillo"))
                    updateBaseConocimiento(filaActual, columnaActual, "oro");
                if (posicionActual.contenido.Contains("vacio"))
                {
                    if(!baseConocimiento[filaActual, columnaActual].contenido.Contains("ok"))
                        baseConocimiento[filaActual, columnaActual].contenido.Add("ok");
                    updateBaseConocimientoOK(filaActual, columnaActual);
                }
            }
            return true;

        }

        private void updateBaseConocimientoOK(int filaActual, int columnaActual)
        {
            if (filaActual - 1 >= 0)
            {
                if (!baseConocimiento[filaActual-1, columnaActual].contenido.Contains("ok"))
                    this.baseConocimiento[filaActual - 1, columnaActual].contenido.Add("ok");


            };
            if (filaActual + 1 < baseConocimiento.GetLength(0))
            {
                if (!baseConocimiento[filaActual+1, columnaActual].contenido.Contains("ok"))
                    this.baseConocimiento[filaActual + 1, columnaActual].contenido.Add("ok");

            };
            if (columnaActual - 1 >= 0)
            {
                if (!baseConocimiento[filaActual, columnaActual-1].contenido.Contains("ok"))
                    this.baseConocimiento[filaActual, columnaActual - 1].contenido.Add("ok");

            };
            if (columnaActual + 1 < baseConocimiento.GetLength(1))
            {
                if (!baseConocimiento[filaActual, columnaActual+1].contenido.Contains("ok"))
                    this.baseConocimiento[filaActual, columnaActual + 1].contenido.Add("ok");
            };
        }
        private bool checkBaseConocimiento(int fila, int columna, string contenido)
        {
            if (baseConocimiento[fila, columna].contenido.Contains(contenido))
                return true;
            else
                return false;
        }
        private void updateBaseConocimiento(int filaActual, int columnaActual, string contenido)
        {
                if (filaActual - 1 >= 0)
                {
                if (checkBaseConocimiento(filaActual - 1, columnaActual, "posible " + contenido))
                {
                    this.baseConocimiento[filaActual - 1, columnaActual].contenido.Remove("posible " + contenido);
                    this.baseConocimiento[filaActual - 1, columnaActual].contenido.Add(contenido);
                }
                else
                    this.baseConocimiento[filaActual - 1, columnaActual].contenido.Add("posible " + contenido);
                        
                };
                if (filaActual + 1 < baseConocimiento.GetLength(0))
                {
                if (checkBaseConocimiento(filaActual + 1, columnaActual, "posible " + contenido))
                {
                    this.baseConocimiento[filaActual + 1, columnaActual].contenido.Remove("posible " +contenido);
                    this.baseConocimiento[filaActual + 1, columnaActual].contenido.Add(contenido);
                }
                else
                    this.baseConocimiento[filaActual + 1, columnaActual].contenido.Add("posible " + contenido);
                        
                };
                if (columnaActual - 1 >= 0)
                {
                if (checkBaseConocimiento(filaActual, columnaActual - 1, "posible " + contenido))
                {
                    this.baseConocimiento[filaActual, columnaActual - 1].contenido.Remove("posible " + contenido);
                    this.baseConocimiento[filaActual, columnaActual - 1].contenido.Add(contenido);
                }
                else
                    this.baseConocimiento[filaActual, columnaActual - 1].contenido.Add("posible " + contenido);
                        
                };
                if (columnaActual + 1 < baseConocimiento.GetLength(1))
                {
                if (checkBaseConocimiento(filaActual, columnaActual + 1, "posible " + contenido))
                {
                    this.baseConocimiento[filaActual, columnaActual + 1].contenido.Remove("posible "+contenido);
                    this.baseConocimiento[filaActual, columnaActual + 1].contenido.Add(contenido);
                }

                else
                    this.baseConocimiento[filaActual, columnaActual + 1].contenido.Add("posible " + contenido);
                };
            
        }
    }
}
