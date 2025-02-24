using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadas
{
    // Clase que representa la lista doblemente ligada
    class Lista
    {
        private Nodo? _nodoInicial; // Referencia al primer nodo de la lista
        private Nodo? _nodoFinal; // Referencia al último nodo de la lista

        public Lista()
        {
            _nodoInicial = new Nodo(); // Se inicializa la lista con un nodo vacío
            _nodoFinal = new Nodo(); // Se inicializa la lista con un nodo vacío
            _nodoInicial = null;
            _nodoFinal = null;
        }

        // Método para agregar un nuevo nodo al final de la lista
        public void Agregar(string dato)
        {
            Nodo nodoNuevo = new Nodo { Dato = dato };

            if (_nodoInicial == null) // Si la lista está vacía
            {
                _nodoInicial = nodoNuevo;
                _nodoFinal = nodoNuevo;
            }
            else
            {
                _nodoFinal.Siguiente = nodoNuevo; // Enlaza el último nodo al nuevo nodo
                nodoNuevo.Anterior = _nodoFinal; // Establece el nodo anterior del nuevo nodo
                _nodoFinal = nodoNuevo; // Actualiza la referencia al último nodo
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

        // Método para buscar un nodo con un valor específico en la lista
        public Nodo? Buscar(string dato)
        {
            if (EstaVacio()) return null;
            Nodo? nodoActual = _nodoInicial;
            while (nodoActual != null)
            {
                if (nodoActual.Dato == dato)
                {
                    return nodoActual; // Retorna el nodo si se encuentra
                }
                nodoActual = nodoActual.Siguiente;
            }
            return null; // Retorna null si no se encuentra el dato
        }

        // Método para eliminar un nodo con un valor específico de la lista
        public void Eliminar(string dato)
        {
            Nodo? nodoAEliminar = Buscar(dato);
            if (nodoAEliminar != null)
            {
                if (nodoAEliminar.Anterior != null)
                {
                    nodoAEliminar.Anterior.Siguiente = nodoAEliminar.Siguiente; // Enlaza el nodo anterior con el siguiente
                }
                else
                {
                    _nodoInicial = nodoAEliminar.Siguiente; // Si es el primer nodo, actualiza la cabeza de la lista
                }

                if (nodoAEliminar.Siguiente != null)
                {
                    nodoAEliminar.Siguiente.Anterior = nodoAEliminar.Anterior; // Enlaza el nodo siguiente con el anterior
                }
                else
                {
                    _nodoFinal = nodoAEliminar.Anterior; // Si es el último nodo, actualiza la cola de la lista
                }
            }
        }

        // Método para obtener una representación en cadena de los valores de la lista
        public string ObtenerValores()
        {
            StringBuilder datos = new StringBuilder();
            Nodo? nodoActual = _nodoInicial;
            while (nodoActual != null)
            {
                datos.AppendLine(nodoActual.Dato); // Agrega el dato del nodo a la cadena
                nodoActual = nodoActual.Siguiente;
            }
            return datos.ToString(); // Retorna la lista de valores en formato de texto
        }
    }
}
