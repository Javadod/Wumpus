using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private void Form1_Load(object sender, EventArgs e)
        {
            Tablero mazmorra = new Tablero(4);
            Casilla[,] mapa = mazmorra.mapa; 
            pictureB = new PictureBox[4, 4];
            int width=5, height = 5;
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
                    if (mapa[i, j].contenido.Count() == 1)
                    {
                        if (mapa[i, j].contenido.Contains("oro"))
                        {
                            pictureB[i, j].Image = Properties.Resources.oro;
                        }
                        if (mapa[i, j].contenido.Contains("wumpus"))
                        {
                            pictureB[i, j].Image = Properties.Resources.wumpus;
                        }
                        if (mapa[i, j].contenido.Contains("hoyo"))
                        {
                            pictureB[i, j].Image = Properties.Resources.hoyo;
                        }
                        if (mapa[i, j].contenido.Contains("hedor"))
                        {
                            pictureB[i, j].Image = Properties.Resources.hedor;
                        }
                        if (mapa[i, j].contenido.Contains("brisa"))
                        {
                            pictureB[i, j].Image = Properties.Resources.brisa;
                        }
                        if (mapa[i, j].contenido.Contains("brillo"))
                        {
                            pictureB[i, j].Image = Properties.Resources.brillo;
                        }
                    }
                    else if (mapa[i, j].contenido.Count() == 2)
                    {
                        if (mapa[i, j].contenido.Contains("hoyo") && mapa[i, j].contenido.Contains("brisa"))
                        {
                            pictureB[i, j].Image = Properties.Resources.hoyo_brisa;
                        }
                        if (mapa[i, j].contenido.Contains("hoyo") && mapa[i, j].contenido.Contains("brillo"))
                        {
                            pictureB[i, j].Image = Properties.Resources.hoyo_brillo;
                        }
                        if (mapa[i, j].contenido.Contains("hoyo") && mapa[i, j].contenido.Contains("hedor"))
                        {
                            pictureB[i, j].Image = Properties.Resources.hoyo_hedor;
                        }
                        if (mapa[i, j].contenido.Contains("hoyo") && mapa[i, j].contenido.Contains("oro"))
                        {
                            pictureB[i, j].Image = Properties.Resources.hoyo_oro;
                        }
                        if (mapa[i, j].contenido.Contains("hoyo") && mapa[i, j].contenido.Contains("wumpus"))
                        {
                            pictureB[i, j].Image = Properties.Resources.hoyo_wumpus;
                        }
                        if (mapa[i, j].contenido.Contains("oro") && mapa[i, j].contenido.Contains("brisa"))
                        {
                            pictureB[i, j].Image = Properties.Resources.oro_brisa;
                        }
                        if (mapa[i, j].contenido.Contains("oro") && mapa[i, j].contenido.Contains("hedor"))
                        {
                            pictureB[i, j].Image = Properties.Resources.oro_hedor;
                        }
                        if (mapa[i, j].contenido.Contains("wumpus") && mapa[i, j].contenido.Contains("brisa"))
                        {
                            pictureB[i, j].Image = Properties.Resources.wumpus_brisa;
                        }
                        if (mapa[i, j].contenido.Contains("wumpus") && mapa[i, j].contenido.Contains("oro"))
                        {
                            pictureB[i, j].Image = Properties.Resources.wumpus_oro;
                        }
                        if (mapa[i, j].contenido.Contains("wumpus") && mapa[i, j].contenido.Contains("brillo"))
                        {
                            pictureB[i, j].Image = Properties.Resources.wumpus_brillo;
                        }
                        if (mapa[i, j].contenido.Contains("brillo") && mapa[i, j].contenido.Contains("hedor"))
                        {
                            pictureB[i, j].Image = Properties.Resources.brillo_hedor;
                        }
                        if (mapa[i, j].contenido.Contains("brillo") && mapa[i, j].contenido.Contains("brisa"))
                        {
                            pictureB[i, j].Image = Properties.Resources.brillo_brisa;
                        }
                        if (mapa[i, j].contenido.Contains("brisa") && mapa[i, j].contenido.Contains("hedor"))
                        {
                            pictureB[i, j].Image = Properties.Resources.brisa_hedor;
                        }
                    }
                    else if (mapa[i, j].contenido.Count() == 3)
                    {
                        if (mapa[i, j].contenido.Contains("hoyo") && mapa[i, j].contenido.Contains("brillo") && mapa[i, j].contenido.Contains("brisa"))
                        {
                            pictureB[i, j].Image = Properties.Resources.hoyo_brillo_brisa;
                        }
                        if (mapa[i, j].contenido.Contains("hoyo") && mapa[i, j].contenido.Contains("brisa") && mapa[i, j].contenido.Contains("hedor"))
                        {
                            pictureB[i, j].Image = Properties.Resources.hoyo_brisa_hedor;
                        }
                        if (mapa[i, j].contenido.Contains("hoyo") && mapa[i, j].contenido.Contains("oro") && mapa[i, j].contenido.Contains("brisa"))
                        {
                            pictureB[i, j].Image = Properties.Resources.hoyo_oro_brisa;
                        }
                        if (mapa[i, j].contenido.Contains("hoyo") && mapa[i, j].contenido.Contains("oro") && mapa[i, j].contenido.Contains("hedor"))
                        {
                            pictureB[i, j].Image = Properties.Resources.hoyo_oro_hedor;
                        }
                        if (mapa[i, j].contenido.Contains("oro") && mapa[i, j].contenido.Contains("brisa") && mapa[i, j].contenido.Contains("hedor"))
                        {
                            pictureB[i, j].Image = Properties.Resources.oro_brisa_hedor;
                        }
                        if (mapa[i, j].contenido.Contains("wumpus") && mapa[i, j].contenido.Contains("brisa") && mapa[i, j].contenido.Contains("brillo"))
                        {
                            pictureB[i, j].Image = Properties.Resources.wumpus_brisa_brillo;
                        }
                        if (mapa[i, j].contenido.Contains("wumpus") && mapa[i, j].contenido.Contains("oro") && mapa[i, j].contenido.Contains("hoyo"))
                        {
                            pictureB[i, j].Image = Properties.Resources.wumpus_oro_hoyo;
                        }
                        if (mapa[i, j].contenido.Contains("wumpus") && mapa[i, j].contenido.Contains("oro") && mapa[i, j].contenido.Contains("brisa"))
                        {
                            pictureB[i, j].Image = Properties.Resources.wumpus_oro_brisa;
                        }
                        if (mapa[i, j].contenido.Contains("wumpus") && mapa[i, j].contenido.Contains("hoyo") && mapa[i, j].contenido.Contains("brillo"))
                        {
                            pictureB[i, j].Image = Properties.Resources.wumpus_hoyo_brillo;
                        }
                        if (mapa[i, j].contenido.Contains("wumpus") && mapa[i, j].contenido.Contains("hoyo") && mapa[i, j].contenido.Contains("brisa"))
                        {
                            pictureB[i, j].Image = Properties.Resources.wumpus_hoyo_brisa;
                        }
                        if (mapa[i, j].contenido.Contains("brillo") && mapa[i, j].contenido.Contains("brisa") && mapa[i, j].contenido.Contains("hedor"))
                        {
                            pictureB[i, j].Image = Properties.Resources.brillo_brisa_hedor;
                        }
                        
                    }
                    else if (mapa[i, j].contenido.Count() == 4)
                    {
                        if (mapa[i, j].contenido.Contains("hoyo") && mapa[i, j].contenido.Contains("brillo") && mapa[i, j].contenido.Contains("brisa") && mapa[i, j].contenido.Contains("hedor"))
                        {
                            pictureB[i, j].Image = Properties.Resources.hoyo_brillo_brisa_hedor;
                        }
                        if (mapa[i, j].contenido.Contains("hoyo") && mapa[i, j].contenido.Contains("oro") && mapa[i, j].contenido.Contains("brisa") && mapa[i, j].contenido.Contains("hedor"))
                        {
                            pictureB[i, j].Image = Properties.Resources.hoyo_oro_brisa_hedor;
                        }
                        if (mapa[i, j].contenido.Contains("wumpus") && mapa[i, j].contenido.Contains("hoyo") && mapa[i, j].contenido.Contains("brillo") && mapa[i, j].contenido.Contains("brisa"))
                        {
                            pictureB[i, j].Image = Properties.Resources.wumpus_hoyo_brillo_brisa;
                        }
                        if (mapa[i, j].contenido.Contains("wumpus") && mapa[i, j].contenido.Contains("hoyo") && mapa[i, j].contenido.Contains("oro") && mapa[i, j].contenido.Contains("brisa"))
                        {
                            pictureB[i, j].Image = Properties.Resources.wumpus_hoyo_oro_brisa;
                        }
                    }
                        width += 105;
                    
                }
                height += 105;
                    
            }
        }
    }
}
