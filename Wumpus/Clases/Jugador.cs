using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wumpus.Clases
{
    class Jugador {
        private bool flecha { get; set; }
        private int puntaje { get; set; }
        private List<bool> sentidos { get; set; }
        private List<int> posicionActual;
        public Jugador () {
            this.flecha = true;
            this.puntaje = 0;
            this.sentidos = new List<bool>();
        }
        public void lanzarFlecha () {
            this.flecha = false;
        }
    }
}
