namespace ListasSimplementeLigadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nodo nodoA = new Nodo();
            nodoA.Dato = "Hola";

            Nodo nodoB = new Nodo();
            nodoB.Dato = "Mundo";

            Console.WriteLine(nodoA.Dato);
        }
    }
}
