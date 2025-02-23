using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasSimplementeLigadasCirculares
{
    internal class Nodo
    {
        public string Dato { get; set; } = string.Empty;
        public Nodo? Siguiente { get; set; } = null;
    }
}
