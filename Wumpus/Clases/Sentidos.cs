using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wumpus.Clases
{
    class Sentidos
    {
        public bool hedor { get; set; }
        public bool brisa { get; set; }
        public bool brillo { get; set; }
        public bool grito { get; set; }

        public Sentidos(bool hedor, bool brisa, bool brillo, bool grito)
        {
            this.hedor = hedor;
            this.brisa = brisa;
            this.brillo = brillo;
            this.grito = grito;
        }
    }
}
