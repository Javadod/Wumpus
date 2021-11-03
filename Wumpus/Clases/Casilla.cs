using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wumpus.Clases
{
    class Casilla
    {
        public int columna { get; set; }
        public int fila { get; set; }
        public List<string> contenido;

        public Casilla(int columna, int fila)
        {
            this.columna = columna;
            this.fila = fila;
            this.contenido = new List<string>();
        }
        
    }
}
