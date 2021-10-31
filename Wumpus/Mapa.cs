using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wumpus
{
    class Mapa {
        private int tamano;
        private String[,] mapa;
        public Mapa (int tamano) {
            this.tamano = tamano;
            crearMapa();
        }
        private void crearMapa () {
            if (tamano <= 2) return;
            mapa = new String[tamano, tamano];
            vaciarMapa();
            crearHoyos();
            crearWumpus();
            ponerLingote();
        }
        private void vaciarMapa() {
            for (int i = 0; i < tamano; i++)
                for (int j = 0; j < tamano; j++)
                    mapa[i, j] = "";
        }
        private void crearHoyos () {
            int cantidadHoyos = (int)(tamano * 0.2);
            var random = new Random();
            int valorRandomX, valorRandomY;
            while (cantidadHoyos > 0) {
                valorRandomX = random.Next(0, tamano - 1);
                valorRandomY = random.Next(0, tamano - 1);
                if ((!valorRandomX.En(0, 1) || !valorRandomY.En(0, 1)) && cantidadHoyos > 0) {
                    mapa[valorRandomX, valorRandomY] = mapa[valorRandomX, valorRandomY] + "2";
                    cantidadHoyos--;
                }
            }
            crearBrisas();
        }
        private void crearBrisas () {
            ponerEnMapa("2", "3");
        }
        private bool condicionMuro (int eje) {
            if (eje + 1 < tamano && eje - 1 >= 0) return true;
            return false;
        }
        private void crearWumpus () {
            var random = new Random();
            int min = (int)(tamano/2);
            int ranX = random.Next(min, tamano - 1);
            int ranY = random.Next(min, tamano - 1);
            mapa[ranX, ranY] = mapa[ranX, ranY] + "4";
            crearHedor();
        }
        private void ponerEnMapa (String principal, String adyacente) {
            for (int i = 0; i < tamano; i++) {
                for (int j = 0; j < tamano; j++) {
                    if (mapa[i, j] == principal) {
                        if (condicionMuro(i + 1)) mapa[i + 1, j] = mapa[i + 1, j] + adyacente;
                        if (condicionMuro(i - 1)) mapa[i - 1, j] = mapa[i - 1, j] + adyacente;
                        if (condicionMuro(j + 1)) mapa[i, j + 1] = mapa[i, j + 1] + adyacente;
                        if (condicionMuro(j - 1)) mapa[i, j - 1] = mapa[i, j - 1] + adyacente;
                    }
                }
            }
        }
        private void crearHedor () {
            ponerEnMapa("4", "5");
        }
        private void ponerLingote () {
            bool lingote = true;
            var random = new Random();
            int min = (int)(tamano / 2);
            while (lingote) {
                int ranX = random.Next(min, tamano - 1);
                int ranY = random.Next(min, tamano - 1);
                if (!(mapa[ranX, ranY].En("2")) && (!ranX.En(0, 1) || !ranY.En(0, 1)) )
                    mapa[ranX, ranY] = mapa[ranX, ranY] + "6";
            }
        }
    }
}
