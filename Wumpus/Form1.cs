using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Wumpus.Clases;

namespace Wumpus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PictureBox[,] pictureB;
        Tablero mazmorra;
        Jugador jugador;
        Recorrido movimientos;
        int mapaType;
        private void Form1_Load(object sender, EventArgs e)
        {
            resetBtn.Enabled = false;
            MoverBtn.Enabled = false;
            //crearMapa();
            //Casilla[,] mapa = mazmorra.mapa;
            //jugador = new Jugador(mapa[0, 0], 4);
            //movimientos  = new Recorrido(jugador, mazmorra);
            

        }

        public void crearMapa(int mapaType)
        {

            mazmorra = new Tablero(4);
            switch (mapaType)
            {
                case 1:
                    mazmorra.setStart2();
                    break;
                case 2:
                    mazmorra.setStart3();
                    break;
                case 3:
                    mazmorra.setStart4();
                    break;
            }
            
            Casilla[,] mapa = mazmorra.mapa;
            pictureB = new PictureBox[4, 4];
            int width = 5, height = 320;

            for (int i = 0; i < 4; i++)
            {
                width = 5;
                for (int j = 0; j < 4; j++)
                {
                    pictureB[i, j] = new PictureBox();
                    pictureB[i, j].BackColor = Color.FromArgb(255, 255, 255, 255);
                    //pictureB[i, j].BackColor = Color.Transparent;
                    pictureB[i, j].Location = new Point(width, height);
                    pictureB[i, j].Size = new Size(100, 100);
                    //pictureB[i, j].Image = Properties.Resources.wumpus;
                    tablero.Controls.Add(pictureB[i, j]);
                    addImagePictureBox(pictureB[i,j],mapa[i,j]);
                    
                    width += 105;

                }
                height -= 105;

            }
            pictureB[0, 0].Image = Properties.Resources._5680d58ebafdf15;
        }

        private void addImagePictureBox(PictureBox pictureB, Casilla mapa)
        {
            if (mapa.contenido.Count() == 1)
            {
                if (mapa.contenido.Contains("oro"))
                {
                    pictureB.Image = Properties.Resources.oro;
                }
                if (mapa.contenido.Contains("wumpus"))
                {
                    pictureB.Image = Properties.Resources.wumpus;
                }
                if (mapa.contenido.Contains("hoyo"))
                {
                    pictureB.Image = Properties.Resources.hoyo;
                }
                if (mapa.contenido.Contains("hedor"))
                {
                    pictureB.Image = Properties.Resources.hedor;
                }
                if (mapa.contenido.Contains("brisa"))
                {
                    pictureB.Image = Properties.Resources.brisa;
                }
                if (mapa.contenido.Contains("brillo"))
                {
                    pictureB.Image = Properties.Resources.brillo;
                }
                if (mapa.contenido.Contains("vacio"))
                {
                    pictureB.Image = null;
                }
            }
            else if (mapa.contenido.Count() == 2)
            {
                if (mapa.contenido.Contains("hoyo") && mapa.contenido.Contains("brisa"))
                {
                    pictureB.Image = Properties.Resources.hoyo_brisa;
                }
                if (mapa.contenido.Contains("hoyo") && mapa.contenido.Contains("brillo"))
                {
                    pictureB.Image = Properties.Resources.hoyo_brillo;
                }
                if (mapa.contenido.Contains("hoyo") && mapa.contenido.Contains("hedor"))
                {
                    pictureB.Image = Properties.Resources.hoyo_hedor;
                }
                if (mapa.contenido.Contains("hoyo") && mapa.contenido.Contains("oro"))
                {
                    pictureB.Image = Properties.Resources.hoyo_oro;
                }
                if (mapa.contenido.Contains("hoyo") && mapa.contenido.Contains("wumpus"))
                {
                    pictureB.Image = Properties.Resources.hoyo_wumpus;
                }
                if (mapa.contenido.Contains("oro") && mapa.contenido.Contains("brisa"))
                {
                    pictureB.Image = Properties.Resources.oro_brisa;
                }
                if (mapa.contenido.Contains("oro") && mapa.contenido.Contains("hedor"))
                {
                    pictureB.Image = Properties.Resources.oro_hedor;
                }
                if (mapa.contenido.Contains("wumpus") && mapa.contenido.Contains("brisa"))
                {
                    pictureB.Image = Properties.Resources.wumpus_brisa;
                }
                if (mapa.contenido.Contains("wumpus") && mapa.contenido.Contains("oro"))
                {
                    pictureB.Image = Properties.Resources.wumpus_oro;
                }
                if (mapa.contenido.Contains("wumpus") && mapa.contenido.Contains("brillo"))
                {
                    pictureB.Image = Properties.Resources.wumpus_brillo;
                }
                if (mapa.contenido.Contains("brillo") && mapa.contenido.Contains("hedor"))
                {
                    pictureB.Image = Properties.Resources.brillo_hedor;
                }
                if (mapa.contenido.Contains("brillo") && mapa.contenido.Contains("brisa"))
                {
                    pictureB.Image = Properties.Resources.brillo_brisa;
                }
                if (mapa.contenido.Contains("brisa") && mapa.contenido.Contains("hedor"))
                {
                    pictureB.Image = Properties.Resources.brisa_hedor;
                }
            }
            else if (mapa.contenido.Count() == 3)
            {
                if (mapa.contenido.Contains("hoyo") && mapa.contenido.Contains("brillo") && mapa.contenido.Contains("brisa"))
                {
                    pictureB.Image = Properties.Resources.hoyo_brillo_brisa;
                }
                if (mapa.contenido.Contains("hoyo") && mapa.contenido.Contains("brisa") && mapa.contenido.Contains("hedor"))
                {
                    pictureB.Image = Properties.Resources.hoyo_brisa_hedor;
                }
                if (mapa.contenido.Contains("hoyo") && mapa.contenido.Contains("oro") && mapa.contenido.Contains("brisa"))
                {
                    pictureB.Image = Properties.Resources.hoyo_oro_brisa;
                }
                if (mapa.contenido.Contains("hoyo") && mapa.contenido.Contains("oro") && mapa.contenido.Contains("hedor"))
                {
                    pictureB.Image = Properties.Resources.hoyo_oro_hedor;
                }
                if (mapa.contenido.Contains("oro") && mapa.contenido.Contains("brisa") && mapa.contenido.Contains("hedor"))
                {
                    pictureB.Image = Properties.Resources.oro_brisa_hedor;
                }
                if (mapa.contenido.Contains("wumpus") && mapa.contenido.Contains("brisa") && mapa.contenido.Contains("brillo"))
                {
                    pictureB.Image = Properties.Resources.wumpus_brisa_brillo;
                }
                if (mapa.contenido.Contains("wumpus") && mapa.contenido.Contains("oro") && mapa.contenido.Contains("hoyo"))
                {
                    pictureB.Image = Properties.Resources.wumpus_oro_hoyo;
                }
                if (mapa.contenido.Contains("wumpus") && mapa.contenido.Contains("oro") && mapa.contenido.Contains("brisa"))
                {
                    pictureB.Image = Properties.Resources.wumpus_oro_brisa;
                }
                if (mapa.contenido.Contains("wumpus") && mapa.contenido.Contains("hoyo") && mapa.contenido.Contains("brillo"))
                {
                    pictureB.Image = Properties.Resources.wumpus_hoyo_brillo;
                }
                if (mapa.contenido.Contains("wumpus") && mapa.contenido.Contains("hoyo") && mapa.contenido.Contains("brisa"))
                {
                    pictureB.Image = Properties.Resources.wumpus_hoyo_brisa;
                }
                if (mapa.contenido.Contains("brillo") && mapa.contenido.Contains("brisa") && mapa.contenido.Contains("hedor"))
                {
                    pictureB.Image = Properties.Resources.brillo_brisa_hedor;
                }
                //caso hoyo-hedor-brillo

            }
            else if (mapa.contenido.Count() == 4)
            {
                if (mapa.contenido.Contains("hoyo") && mapa.contenido.Contains("brillo") && mapa.contenido.Contains("brisa") && mapa.contenido.Contains("hedor"))
                {
                    pictureB.Image = Properties.Resources.hoyo_brillo_brisa_hedor;
                }
                if (mapa.contenido.Contains("hoyo") && mapa.contenido.Contains("oro") && mapa.contenido.Contains("brisa") && mapa.contenido.Contains("hedor"))
                {
                    pictureB.Image = Properties.Resources.hoyo_oro_brisa_hedor;
                }
                if (mapa.contenido.Contains("wumpus") && mapa.contenido.Contains("hoyo") && mapa.contenido.Contains("brillo") && mapa.contenido.Contains("brisa"))
                {
                    pictureB.Image = Properties.Resources.wumpus_hoyo_brillo_brisa;
                }
                if (mapa.contenido.Contains("wumpus") && mapa.contenido.Contains("hoyo") && mapa.contenido.Contains("oro") && mapa.contenido.Contains("brisa"))
                {
                    pictureB.Image = Properties.Resources.wumpus_hoyo_oro_brisa;
                }
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            crearMapa(mapaType);
            jugador = new Jugador(mazmorra.mapa[0, 0], 4);
            movimientos = new Recorrido(jugador, mazmorra);
        }

        private void MoverBtn_Click(object sender, EventArgs e)
        {
            hedorTB.Text = "Nada";
            brilloTB.Text = "Nada";
            brisaTB.Text = "Nada";
            int filaActual = jugador.posicionActual.fila;
            int columnaActual = jugador.posicionActual.columna;
            addImagePictureBox(pictureB[filaActual, columnaActual], mazmorra.mapa[filaActual, columnaActual]);
            pictureB[filaActual, columnaActual].Refresh();

            Movimiento mejorMovimiento = movimientos.last().mejorMovimiento();
            if (jugador.sentidos.grito)
            {
                MessageBox.Show("GRAAAAAAAAHHHHHHH\n has matado al wumpus!");
            }
            if (mejorMovimiento == null)
            {
                //no quedan casillas por explorar o son peligrosas
                if (!movimientos.last().checkMovimientos(jugador.baseConocimiento))
                {
                    movimientos.retrocede();
                    MessageBox.Show("Decides irte a casa con las manos vacias");

                }
                movimientos.retrocede();

            }
            else
                movimientos.nuevoMovimiento(mejorMovimiento);
            int estado=jugador.estadoActual();
            if (estado == -1)
            {
                MessageBox.Show("Has muerto :(");
            }
            else if(estado == 1)
            {
                MessageBox.Show("Has ganado :)");
                
            }
            moverJugador(jugador.posicionActual);
            if (jugador.sentidos.hedor)
            {
                hedorTB.Text = "Sí";
            }
            else

            if (jugador.sentidos.brisa)
                brisaTB.Text = "Sí";
            if (jugador.sentidos.brillo)
                brilloTB.Text = "Sí";
            if (jugador.sentidos.grito)
                gritoTB.Text = "Sí";
            if (!jugador.flecha)
                flechaTB.Text = "No";

        }

        private void moverJugador(Casilla posicion)
        {
            int fila = posicion.fila;
            int columna = posicion.columna;

            pictureB[fila, columna].Image = Properties.Resources._5680d58ebafdf15;
            pictureB[fila, columna].Refresh();
        }

        private void Map1Btn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();

            resetBtn.Enabled = true;
            MoverBtn.Enabled = true;
            mapaType = 1;
            crearMapa(1);
            
            jugador = new Jugador(mazmorra.mapa[0, 0], 4);
            movimientos = new Recorrido(jugador, mazmorra);
        }

        private void Map2Btn_Click(object sender, EventArgs e)
        {

            this.Controls.Clear();
            this.InitializeComponent();
            resetBtn.Enabled = true;
            MoverBtn.Enabled = true;
            mapaType = 2;
            crearMapa(mapaType);
            jugador = new Jugador(mazmorra.mapa[0, 0], 4);
            movimientos = new Recorrido(jugador, mazmorra);
        }

        private void Map3Btn_Click(object sender, EventArgs e)
        {

            this.Controls.Clear();
            this.InitializeComponent();
            resetBtn.Enabled = true;
            MoverBtn.Enabled = true;
            mapaType = 3;
            crearMapa(mapaType);
            jugador = new Jugador(mazmorra.mapa[0, 0], 4);
            movimientos = new Recorrido(jugador, mazmorra);
        }
    }
}
