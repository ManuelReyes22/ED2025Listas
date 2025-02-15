namespace ListasSimplementeLigadas
{
    internal class Lista
    {
        private Nodo _nodoInicial;

        public Lista() 
        {
            _nodoInicial = new Nodo();
        }

        public void Agregar(string dato)
        {
            Nodo nodoActual = _nodoInicial;

            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
            }

            Nodo nodoNuevo = new Nodo();
            nodoNuevo.Dato = dato;

            nodoActual.Siguiente = nodoNuevo;
        }
    }
}
