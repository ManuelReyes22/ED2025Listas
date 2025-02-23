using System.ComponentModel;

namespace ListasSimplementeLigadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa de prueba
            Lista lista = new Lista();

            // Agregar elementos a la lista
            lista.Agregar("A");
            lista.Agregar("B");
            lista.Agregar("C");
            lista.Agregar("D");
            lista.Agregar("E");

            // Imprimir los valores de la lista
            Console.WriteLine("Lista original:");
            Console.WriteLine(lista.ObtenerValores());

            // Eliminar un elemento de la lista
            lista.Eliminar("C");

            // Imprimir la lista después de eliminar "C"
            Console.WriteLine("Lista después de eliminar 'C':");
            Console.WriteLine(lista.ObtenerValores());

            // Buscar un elemento en la lista
            Console.WriteLine("Resultado de buscar 'E':");
            Console.WriteLine(lista.Buscar("E"));

        }
    }
}
