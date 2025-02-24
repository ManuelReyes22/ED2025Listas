using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasSimplementeLigadasCirculares
{
    // Clase que representa una lista simplemente ligada circular
    internal class Lista
    {
        private Nodo _nodoInicial; // Referencia al primer nodo de la lista
        private Nodo _nodoFinal; // Referencia al último nodo de la lista

        public Lista()
        {
            _nodoInicial = null;
            _nodoFinal = null;
        }

        // Método para agregar un nodo al final de la lista
        public void Agregar(string dato)
        {
            Nodo nodoNuevo = new Nodo { Dato = dato };

            if (_nodoInicial == null) // Si la lista está vacía
            {
                _nodoInicial = nodoNuevo;
                _nodoFinal = nodoNuevo;
                _nodoFinal.Siguiente = _nodoInicial; // Hace que la lista sea circular
            }
            else
            {
                _nodoFinal.Siguiente = nodoNuevo; // Enlaza el último nodo al nuevo nodo
                _nodoFinal = nodoNuevo; // Actualiza la referencia al último nodo
                _nodoFinal.Siguiente = _nodoInicial; // Mantiene la circularidad
            }
        }

        // Método para verificar si la lista está vacía
        public bool EstaVacio()
        {
            return _nodoInicial == null;
        }

        // Método para vaciar la lista
        public void Vaciar()
        {
            _nodoInicial = null;
            _nodoFinal = null;
        }

        // Método para buscar un nodo con un valor específico
        public Nodo? Buscar(string dato)
        {
            if (EstaVacio()) return null;
            Nodo nodoActual = _nodoInicial;
            do
            {
                if (nodoActual.Dato == dato)
                {
                    return nodoActual; // Retorna el nodo si se encuentra
                }
                nodoActual = nodoActual.Siguiente;
            } while (nodoActual != _nodoInicial); // Se detiene al dar una vuelta completa

            return null;
        }

        // Método para eliminar un nodo con un valor específico
        public void Eliminar(string dato)
        {
            if (EstaVacio()) return;

            Nodo nodoActual = _nodoInicial;
            Nodo nodoAnterior = _nodoFinal;

            do
            {
                if (nodoActual.Dato == dato)
                {
                    if (nodoActual == _nodoInicial) // Si es el primer nodo
                    {
                        _nodoInicial = _nodoInicial.Siguiente;
                        _nodoFinal.Siguiente = _nodoInicial;
                    }
                    else if (nodoActual == _nodoFinal) // Si es el último nodo
                    {
                        _nodoFinal = nodoAnterior;
                        _nodoFinal.Siguiente = _nodoInicial;
                    }
                    else
                    {
                        nodoAnterior.Siguiente = nodoActual.Siguiente; // Salta el nodo actual
                    }
                    return;
                }
                nodoAnterior = nodoActual;
                nodoActual = nodoActual.Siguiente;
            } while (nodoActual != _nodoInicial);
        }

        // Método para obtener una representación en cadena de los valores de la lista
        public string ObtenerValores()
        {
            if (EstaVacio()) return string.Empty;

            StringBuilder datos = new StringBuilder();
            Nodo nodoActual = _nodoInicial;
            do
            {
                datos.AppendLine(nodoActual.Dato); // Agrega el dato del nodo a la cadena
                nodoActual = nodoActual.Siguiente;
            } while (nodoActual != _nodoInicial); // Se detiene al dar una vuelta completa

            return datos.ToString(); // Retorna la lista de valores en formato de texto
        }
    }
}
