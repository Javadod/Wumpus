using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wumpus
{
    class Jugador {
        private bool flecha;
        private int puntaje;
        public Jugador () {
            this.flecha = true;
            this.puntaje = 0;
        }
        public bool Flecha { get => flecha; set => flecha = value; }
        public int Puntaje { get => puntaje; set => puntaje = value; }
        public void lanzarFlecha () {
            this.flecha = false;
            puntaje -= 10;
        }
    }
}
