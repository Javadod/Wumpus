using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Wumpus.Clases
{
    class Tablero {
        public Casilla[,] mapa { get; set; }
        public int tamano { get; set; }
        private static Random random    ;
        public Tablero (int tamano) {
            this.tamano = tamano;
            this.mapa = new Casilla[tamano, tamano];
            random = new Random();
            setStart();
        }
        private void setCasillas()
        {
            if (tamano <= 2) return;
            for (int i = 0; i < tamano; i++)
                for (int j = 0; j < tamano; j++)
                    mapa[i, j] = new Casilla(i, j);
        }
        private void setStart () {
            setCasillas();

            setHoles();
            setWumpus();
            setGold();
            setEmpty();
        }
        private void setEmpty() {
            for (int i = 0; i < tamano; i++)
                for (int j = 0; j < tamano; j++) 
                    if (!mapa[i, j].contenido.Any())
                        mapa[i, j].contenido.Add("vacio");
                
        }
        private void setHoles () {
            for (int i = 0; i < tamano; i++)
                for (int j = 0; j < tamano; j++)
                    if(random.Next(0,100) < 20)
                    {
                        if (i != 0 && j != 0)
                        {
                            mapa[i, j].contenido.Add("hoyo");
                            crearBrisas(i, j);
                        }
                        
                    }
        }

        private void crearBrisas(int i, int j)
        {
            ponerEnMapa(i, j, "brisa");
        }

        private void ponerEnMapa (int i,int j, string contenido) {
            if(i - 1 >= 0)
            {
                if(!mapa[i - 1, j].contenido.Contains(contenido))
                    mapa[i - 1, j].contenido.Add(contenido);
            }
            if(i+1 < tamano)
            {
                if (!mapa[i + 1, j].contenido.Contains(contenido))
                    mapa[i + 1, j].contenido.Add(contenido);
            }
            if (j - 1 >= 0)
            {
                if (!mapa[i, j - 1].contenido.Contains(contenido))
                    mapa[i, j - 1].contenido.Add(contenido);
            }
            if (j + 1 < tamano)
            {
                if (!mapa[i, j + 1].contenido.Contains(contenido))
                    mapa[i,j + 1].contenido.Add(contenido);
            }

        }
        private void setWumpus () {
            int fila = 0;
            int columna = 0;
            while (fila == 0 && columna == 0)
            {
                fila = random.Next(tamano);
                columna = random.Next(tamano);
            }
            mapa[fila, columna].contenido.Add("wumpus");
            crearHedor(fila,columna);
        }
        private void crearHedor (int i, int j) {
            ponerEnMapa(i, j, "hedor");
        }
        private void setGold () {
            int fila = 0;
            int columna = 0;
            while (fila == 0 && columna == 0)
            {
                fila = random.Next(tamano);
                columna = random.Next(tamano);
            }
            mapa[fila, columna].contenido.Add("oro");
            crearBrillo(fila,columna);
        }

        private void crearBrillo(int i, int j)
        {
            ponerEnMapa(i, j, "brillo");
        }
    }
}
