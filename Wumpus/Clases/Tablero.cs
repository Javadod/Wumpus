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
            //setStart();
            //setStart2();
            setStart3();
            //setStart4();
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
        private void setStart2()
        {
            setCasillas();

            setHoyo2();
            setWumpus2();
            setGold2();
            setEmpty();
        }
        private void setStart3()
        {
            setCasillas();
            setHoyo3();
            setWumpus3();
            setGold3();
            setEmpty();
        }
        private void setStart4()
        {

            setCasillas();
            setHoyo4();
            setWumpus4();
            setGold4();
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
            mapa[1, 2].contenido.Add("wumpus");
            crearHedor(1,2);
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
            mapa[2, 2].contenido.Add("oro");
            crearBrillo(2,2);
        }
        private void setGold2()
        {
            mapa[2, 2].contenido.Add("oro");
            crearBrillo(2, 2);
        }
        private void setWumpus2()
        {
            mapa[2, 1].contenido.Add("wumpus");
            crearHedor(2, 1);
        }
        private void setHoyo2()
        {
            mapa[2, 0].contenido.Add("hoyo");
            crearBrisas(2, 0);
            mapa[3, 1].contenido.Add("hoyo");
            crearBrisas(3, 1);
            mapa[2, 3].contenido.Add("hoyo");
            crearBrisas(2, 3);
        }

        private void crearBrillo(int i, int j)
        {
            ponerEnMapa(i, j, "brillo");
        }
        
        private void setGold3()
        {
            mapa[2, 0].contenido.Add("oro");
            crearBrillo(2, 0);
        }
        private void setWumpus3()
        {
            mapa[2, 0].contenido.Add("wumpus");
            crearHedor(2, 0);
        }
        private void setHoyo3()
        {
            mapa[0, 2].contenido.Add("hoyo");
            crearBrisas(0, 2);
            mapa[1, 1].contenido.Add("hoyo");
            crearBrisas(1, 1);
            mapa[1, 2].contenido.Add("hoyo");
            crearBrisas(1, 2);
        }
        private void setGold4()
        {
            mapa[3, 3].contenido.Add("oro");
            crearBrillo(3, 3);
        }
        private void setWumpus4()
        {
            mapa[2, 2].contenido.Add("wumpus");
            crearHedor(2, 2);
        }
        private void setHoyo4()
        {
            mapa[1, 1].contenido.Add("hoyo");
            crearBrisas(1, 1);
            mapa[3, 0].contenido.Add("hoyo");
            crearBrisas(3, 0);
            mapa[0, 3].contenido.Add("hoyo");
            crearBrisas(0, 3);
        }




    }
}
