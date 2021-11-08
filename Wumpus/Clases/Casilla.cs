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
        public List<string> contenido { get; set; }

        public Casilla(int fila, int columna)
        {
            this.fila = fila;
            this.columna = columna;
            this.contenido = new List<string>();
        }
        
    }
}
