using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wumpus
{
    static class Extensiones {
        public static bool En<T>(this T elemento, params T[] elementos) {
            if (elemento == null) throw new ArgumentNullException("Elemento");
            return elementos.Contains(elemento);
        }
    }
}
