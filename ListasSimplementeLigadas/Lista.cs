using System.Text;

namespace ListasSimplementeLigadas
{
    internal class Lista
    {
        private Nodo _nodoInicial; // Nodo inicial de la lista

        public Lista()
        {
            _nodoInicial = new Nodo(); // Se inicializa la lista con un nodo vacío
        }

        // Agrega un nuevo nodo al final de la lista
        public void Agregar(string dato)
        {
            Nodo nodoActual = _nodoInicial;

            // Se recorre la lista hasta encontrar el último nodo
            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
            }

            // Se crea un nuevo nodo y se asigna el dato
            Nodo nodoNuevo = new Nodo();
            nodoNuevo.Dato = dato;

            // Se enlaza el nuevo nodo al final de la lista
            nodoActual.Siguiente = nodoNuevo;
        }

        // Verifica si la lista está vacía
        public bool EstaVacio()
        {
            return (_nodoInicial.Siguiente == null); // Si no hay nodos después del inicial, la lista está vacía
        }

        // Vacía la lista estableciendo el siguiente del nodo inicial a null
        public void Vaciar()
        {
            _nodoInicial.Siguiente = null;
        }

        // Busca un nodo en la lista que contenga el dato especificado
        public Nodo? Buscar(string dato)
        {
            if (!EstaVacio())
            {
                Nodo nodoActual = _nodoInicial;

                // Se recorre la lista buscando el dato
                while (nodoActual.Siguiente != null)
                {
                    nodoActual = nodoActual.Siguiente;

                    if (nodoActual.Dato == dato)
                    {
                        return nodoActual; // Se retorna el nodo si se encuentra el dato
                    }
                }
            }
            return null; // Retorna null si el dato no está en la lista
        }

        // Busca el nodo anterior al nodo que contiene el dato especificado
        private Nodo? BuscarAnterior(string dato)
        {
            if (!EstaVacio())
            {
                Nodo nodoActual = _nodoInicial;

                // Se recorre la lista buscando el nodo anterior al que contiene el dato
                while (nodoActual.Siguiente != null)
                {
                    if (nodoActual.Siguiente.Dato == dato)
                    {
                        return nodoActual; // Retorna el nodo anterior si se encuentra
                    }
                    nodoActual = nodoActual.Siguiente;
                }
            }
            return null; // Retorna null si no se encuentra el dato o no hay nodo anterior
        }

        // Elimina un nodo de la lista por su valor
        public void Eliminar(string dato)
        {
            if (!EstaVacio())
            {
                Nodo? nodoActual = Buscar(dato); // Se busca el nodo a eliminar

                if (nodoActual != null)
                {
                    Nodo? nodoAnterior = BuscarAnterior(dato); // Se busca el nodo anterior

                    if (nodoAnterior != null)
                    {
                        // Se elimina el nodo al actualizar el puntero del nodo anterior
                        nodoAnterior.Siguiente = nodoActual.Siguiente;
                        nodoActual.Siguiente = null;
                    }
                }
            }
        }

        // Obtiene los valores almacenados en la lista como una cadena de texto
        public string ObtenerValores()
        {
            if (EstaVacio()) return string.Empty;

            StringBuilder datos = new StringBuilder();
            Nodo nodoActual = _nodoInicial;

            // Se recorre la lista y se agregan los datos a la cadena
            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
                datos.AppendLine(nodoActual.Dato);
            }

            return datos.ToString(); // Retorna la lista de valores como string
        }
    }
}

