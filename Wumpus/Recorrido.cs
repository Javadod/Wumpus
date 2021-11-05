using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wumpus {
    class Recorrido {
        private Posicion raiz;
        public Posicion Raiz { get => raiz; set => raiz = value; }
        public Recorrido (Posicion raiz) {
            this.raiz = raiz;
        }
        public Posicion determinarMenorHeuristica (Posicion casilla, int puntaje) {
            Posicion aux;
            Posicion posicionImportante = null;
            if (casilla.Adyacente != null) {
                foreach (var hijo in casilla.Adyacente) {
                    if (hijo != null) {
                        aux = determinarMenorHeuristica(hijo, puntaje);
                        if (aux != null) {
                            if (posicionImportante != null) {
                                if (posicionImportante.Puntos <= aux.Puntos) {
                                    posicionImportante = aux;
                                    aux = null;
                                }
                            } else {
                                posicionImportante = aux;
                            }
                            aux = null;
                        }
                    }
                }
                if (posicionImportante != null)
                    return posicionImportante;
                else
                    return casilla;
            }
            return casilla;
        }
    }
}
