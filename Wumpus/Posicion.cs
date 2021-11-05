using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wumpus
{
    class Posicion {
        private int[] casilla;
        private int[] pos;
        private Posicion[] adyacente;
        private Posicion padre;
        private int puntos;
        private string[,] infoGeneral;

        public int[] Casilla { get => casilla; set => casilla = value; }
        public int[] Pos { get => pos; set => pos = value; }
        public Posicion[] Adyacente { get => adyacente; set => adyacente = value; }
        public Posicion Padre { get => padre; set => padre = value; }
        public int Puntos { get => puntos; set => puntos = value; }

        public Posicion (int posX, int posY, string[,] info, Posicion padre = null) {
            puntos = contarPuntos();
            infoGeneral = info;
            casilla = new int[9];
            adyacente = new Posicion[4];
            pos = new int[] { posX, posY };
            guardarInformacion(infoGeneral[posX, posY]);
            if (padre != null) this.padre = padre;
        }
        private void guardarInformacion (string info) {
            string[] lista = info.Split();
            foreach (var elemento in lista) {
                try {
                    casilla[Int32.Parse(elemento)] = 1;
                } catch {
                    Console.WriteLine("Error en almacenar en casilla.");
                }
            }
        }
        public void generarAdyacente () {
            if (verificarPosicion(pos[0] + 1, pos[1])) adyacente[0] = new Posicion(pos[0] + 1, pos[1], infoGeneral, this);
            if (verificarPosicion(pos[0] - 1, pos[1])) adyacente[1] = new Posicion(pos[0] - 1, pos[1], infoGeneral, this);
            if (verificarPosicion(pos[0], pos[1] + 1)) adyacente[2] = new Posicion(pos[0], pos[1] + 1, infoGeneral, this);
            if (verificarPosicion(pos[0], pos[1] - 1)) adyacente[3] = new Posicion(pos[0], pos[1] - 1, infoGeneral, this);
        }
        private bool verificarPosicion (int posX, int posY) {
            if (padre != null)
                if (padre.pos[0] == posX && padre.pos[1] == posY)
                    return false;
            if ( (posX >= 0 && posX <= 3) && (posY >= 0 && posY <= 3) ) return true;
            return false;
        }
        private int contarPuntos() {
            int suma = 0;
            suma--;
            if (casilla[2] == 1) suma -= 1000;
            if (casilla[4] == 1) suma -= 1000;
            if (casilla[6] == 1) suma += 1000;
            return suma;
        }
        public bool encontroLingote () {
            return casilla[6] == 1;
        }
    }
}