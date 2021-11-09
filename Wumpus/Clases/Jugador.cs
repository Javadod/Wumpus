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
        public bool wumpusEncontrado{ get; set; }
        public Jugador (Casilla posicionActual, int tamTablero) {
            this.flecha = true;
            this.puntaje = 0;
            this.sentidos = new Sentidos(false,false,false,false);
            this.posicionActual = posicionActual;
            this.baseConocimiento = new Casilla[tamTablero, tamTablero];
            this.wumpusEncontrado = false;
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
        
        public int estadoActual()
        {
            int filaActual = posicionActual.fila;
            int columnaActual = posicionActual.columna;
            if (posicionActual.contenido.Contains("vacio"))
            {
                if (filaActual - 1 >= 0)
                {
                    baseConocimiento[filaActual - 1, columnaActual].contenido.Remove("posible hoyo");
                    baseConocimiento[filaActual - 1, columnaActual].contenido.Remove("posible wumpus");
                    baseConocimiento[filaActual - 1, columnaActual].contenido.Remove("posible oro");
                }
                if (filaActual + 1 < baseConocimiento.GetLength(0))
                {
                    baseConocimiento[filaActual + 1, columnaActual].contenido.Remove("posible hoyo");
                    baseConocimiento[filaActual + 1, columnaActual].contenido.Remove("posible wumpus");
                    baseConocimiento[filaActual + 1, columnaActual].contenido.Remove("posible oro");
                }
                if (columnaActual - 1 >= 0)
                {
                    baseConocimiento[filaActual, columnaActual-1].contenido.Remove("posible hoyo");
                    baseConocimiento[filaActual, columnaActual-1].contenido.Remove("posible wumpus");
                    baseConocimiento[filaActual, columnaActual-1].contenido.Remove("posible oro");
                }
                if (columnaActual + 1 < baseConocimiento.GetLength(1))
                {
                    baseConocimiento[filaActual, columnaActual + 1].contenido.Remove("posible hoyo");
                    baseConocimiento[filaActual, columnaActual + 1].contenido.Remove("posible wumpus");
                    baseConocimiento[filaActual, columnaActual + 1].contenido.Remove("posible oro");
                }
            }
            //muerto
            if (posicionActual.contenido.Contains("wumpus") || posicionActual.contenido.Contains("hoyo"))
                return -1;
            //encontro el oro
            if(posicionActual.contenido.Contains("oro"))
                return 1;
            //vivo

            if (!baseConocimiento[filaActual, columnaActual].contenido.Contains("visitado"))
            {
                baseConocimiento[filaActual, columnaActual].contenido.Add("visitado");
                if (posicionActual.contenido.Contains("hedor"))
                {
                    //marca el hedor
                    baseConocimiento[filaActual, columnaActual].contenido.Add("hedor");
                    if (!wumpusEncontrado)
                        //marca posibles casillas donde puede estar el wumpus
                        updateBaseConocimiento(filaActual, columnaActual, "wumpus");
                }



                if (posicionActual.contenido.Contains("brisa"))
                {
                    baseConocimiento[filaActual, columnaActual].contenido.Add("brisa");
                    updateBaseConocimiento(filaActual, columnaActual, "hoyo");
                }
                if (posicionActual.contenido.Contains("brillo"))
                {
                    baseConocimiento[filaActual, columnaActual].contenido.Add("brillo");
                    updateBaseConocimiento(filaActual, columnaActual, "oro");
                }
                if (posicionActual.contenido.Contains("vacio"))
                {
                    if(!baseConocimiento[filaActual, columnaActual].contenido.Contains("ok"))
                    {
                        baseConocimiento[filaActual, columnaActual].contenido.Add("ok");
                    }
                        
                    updateBaseConocimientoOK(filaActual, columnaActual);
                }
            }
            if (!wumpusEncontrado)
            {
                wumpusEncontrado = checkWumpus();
            }
            
            return 0;

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
            int posiblesCasillas=0;
            int posicionFila=-1;
            int posicionColumna=-1;
            if (filaActual - 1 >= 0)
            {
                if (PeligroNoRecorrido(filaActual - 1, columnaActual))
                {
                    if (checkPeligro(filaActual-1, columnaActual, contenido))
                    {
                        this.baseConocimiento[filaActual - 1, columnaActual].contenido.Add("posible " + contenido);
                        posiblesCasillas++;
                        posicionFila = filaActual - 1;
                        posicionColumna = columnaActual;
                    }

                }
            }
            if (filaActual + 1 < baseConocimiento.GetLength(0))
            {
                if (PeligroNoRecorrido(filaActual + 1, columnaActual))
                {
                    if (checkPeligro(filaActual+1, columnaActual, contenido))
                    {

                        this.baseConocimiento[filaActual + 1, columnaActual].contenido.Add("posible " + contenido);
                        posiblesCasillas++;
                        posicionFila = filaActual + 1;
                        posicionColumna = columnaActual;
                    }
                }

            }
            if (columnaActual - 1 >= 0)
            {
                if (PeligroNoRecorrido(filaActual, columnaActual - 1))
                {
                    if (checkPeligro(filaActual, columnaActual-1, contenido))
                    {

                        this.baseConocimiento[filaActual, columnaActual - 1].contenido.Add("posible " + contenido);
                        posiblesCasillas++;
                        posicionFila = filaActual;
                        posicionColumna = columnaActual-1;
                    }
                }

            }
            if (columnaActual + 1 < baseConocimiento.GetLength(1))
            {

                if (PeligroNoRecorrido(filaActual, columnaActual + 1))
                {
                    if (checkPeligro(filaActual, columnaActual + 1, contenido))
                    {
                        this.baseConocimiento[filaActual, columnaActual + 1].contenido.Add("posible " + contenido);
                        posiblesCasillas++;
                        posicionFila = filaActual;
                        posicionColumna = columnaActual+1;
                    }
                }
            }
            if (posiblesCasillas == 1&&posicionFila!=-1&&posicionColumna!=-1)
            {
                this.baseConocimiento[posicionFila, posicionColumna].contenido.Remove("posible "+contenido);
                this.baseConocimiento[posicionFila, posicionColumna].contenido.Add(contenido);
            }
            
        }

        private bool checkPeligro(int filaActual, int columnaActual, string contenido)
        {
            string buscarPor="";
            switch (contenido)
            {
                case "wumpus":
                    buscarPor = "hedor";
                    break;
                case "hoyo":
                    buscarPor = "brisa";
                    break;
                case "oro":
                    buscarPor = "brillo";
                    break;

            }

            if (filaActual - 1 >= 0)
            {
                if (!baseConocimiento[filaActual-1, columnaActual].contenido.Contains(buscarPor)&& baseConocimiento[filaActual-1, columnaActual].contenido.Contains("visitado"))
                    return false;


            };
            if (filaActual + 1 < baseConocimiento.GetLength(0))
            {
                if (!baseConocimiento[filaActual+1, columnaActual].contenido.Contains(buscarPor) && baseConocimiento[filaActual+1, columnaActual].contenido.Contains("visitado"))
                    return false;

            };
            if (columnaActual - 1 >= 0)
            {
                if (!baseConocimiento[filaActual, columnaActual-1].contenido.Contains(buscarPor) && baseConocimiento[filaActual, columnaActual-1].contenido.Contains("visitado"))
                    return false;

            };
            if (columnaActual + 1 < baseConocimiento.GetLength(1))
            {
                if (!baseConocimiento[filaActual, columnaActual+1].contenido.Contains(buscarPor) && baseConocimiento[filaActual, columnaActual+1].contenido.Contains("visitado"))
                    return false;
            };
            return true;
        }

        private bool PeligroNoRecorrido(int i, int j)
        {
            if (checkBaseConocimiento(i, j, "visitado") || checkBaseConocimiento(i, j, "ok"))
                return false;
            else
                return true;
         
        }
        private bool checkWumpus()
        {
            for(int i=0; i< baseConocimiento.GetLength(0); i++)
            {
                for(int j=0; j< baseConocimiento.GetLength(1); j++)
                {
                    if (baseConocimiento[i, j].contenido.Contains("wumpus"))
                        return true;
                }
            }
            return false;
        }
    }
}
