using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadas
{
    // Clase que representa un nodo en la lista doblemente ligada
    class Nodo
    {
        public string Dato { get; set; } = string.Empty; // Dato almacenado en el nodo
        public Nodo? Siguiente { get; set; } = null; // Referencia al siguiente nodo
        public Nodo? Anterior { get; set; } = null; // Referencia al nodo anterior
    }
}
