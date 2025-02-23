namespace ListasSimplementeLigadas
{
    internal class Nodo
    {
        // Propiedad para almacenar el dato del nodo
        public string Dato { get; set; } = string.Empty;

        // Referencia al siguiente nodo en la lista (null si es el último nodo)
        public Nodo? Siguiente { get; set; } = null;

    }
}
