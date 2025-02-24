using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadasCirculares
{
    // Clase que representa la lista doblemente ligada circular
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
                _nodoInicial.Siguiente = _nodoInicial; // Apunta a sí mismo
                _nodoInicial.Anterior = _nodoInicial;
            }
            else
            {
                _nodoFinal.Siguiente = nodoNuevo; // Enlaza el último nodo al nuevo nodo
                nodoNuevo.Anterior = _nodoFinal; // Establece el nodo anterior del nuevo nodo
                nodoNuevo.Siguiente = _nodoInicial; // Apunta al primer nodo (haciendo la lista circular)
                _nodoInicial.Anterior = nodoNuevo; // El primer nodo apunta al nuevo último nodo
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
            while (nodoActual != _nodoInicial);
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
                if (nodoAEliminar == _nodoInicial && nodoAEliminar == _nodoFinal) // Si es el único nodo en la lista
                {
                    _nodoInicial = null;
                    _nodoFinal = null;
                }
                else
                {
                    nodoAEliminar.Anterior.Siguiente = nodoAEliminar.Siguiente; // Enlaza el nodo anterior con el siguiente
                    nodoAEliminar.Siguiente.Anterior = nodoAEliminar.Anterior; // Enlaza el nodo siguiente con el anterior

                    if (nodoAEliminar == _nodoInicial) // Si es el primer nodo
                    {
                        _nodoInicial = nodoAEliminar.Siguiente;
                    }
                    if (nodoAEliminar == _nodoFinal) // Si es el último nodo
                    {
                        _nodoFinal = nodoAEliminar.Anterior;
                    }
                }
            }
        }

        // Método para obtener una representación en cadena de los valores de la lista
        public string ObtenerValores()
        {
            StringBuilder datos = new StringBuilder();
            Nodo? nodoActual = _nodoInicial;
            do
            {
                datos.AppendLine(nodoActual!.Dato); // Agrega el dato del nodo a la cadena
                nodoActual = nodoActual.Siguiente;
            } while (nodoActual != _nodoInicial); // Se detiene al dar una vuelta completa
            return datos.ToString(); // Retorna la lista de valores en formato de texto
        }
    }
}
