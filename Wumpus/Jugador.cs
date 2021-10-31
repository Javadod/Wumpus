using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wumpus
{
    class Jugador {
        private bool flecha { get; set; }
        private int puntaje { get; set; }
        public Jugador () {
            this.flecha = true;
            this.puntaje = 0;
        }
        public void lanzarFlecha () {
            this.flecha = false;
        }
    }
}
