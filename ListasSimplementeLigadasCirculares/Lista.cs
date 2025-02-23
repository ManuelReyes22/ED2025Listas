using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasSimplementeLigadasCirculares
{
    internal class Lista
    {
        private Nodo _nodoInicial;
        private Nodo _nodoFinal;

        public Lista()
        {
            _nodoInicial = null;
            _nodoFinal = null;
        }

        public void Agregar(string dato)
        {
            Nodo nodoNuevo = new Nodo { Dato = dato };

            if (_nodoInicial == null)
            {
                _nodoInicial = nodoNuevo;
                _nodoFinal = nodoNuevo;
                _nodoFinal.Siguiente = _nodoInicial;
            }
            else
            {
                _nodoFinal.Siguiente = nodoNuevo;
                _nodoFinal = nodoNuevo;
                _nodoFinal.Siguiente = _nodoInicial;
            }
        }

        public bool EstaVacio()
        {
            return _nodoInicial == null;
        }

        public void Vaciar()
        {
            _nodoInicial = null;
            _nodoFinal = null;
        }

        public (Nodo?,int) Buscar(string dato)
        {
            int cont = 0;
            if (EstaVacio()) return (null,cont);

            Nodo nodoActual = _nodoInicial;
            do
            {
                cont++;
                if (nodoActual.Dato == dato)
                {
                    return (nodoActual, cont);
                }
                nodoActual = nodoActual.Siguiente;
            } while (nodoActual != _nodoInicial);

            return (null,cont);
        }

        public void Eliminar(string dato)
        {
            if (EstaVacio()) return;

            Nodo nodoActual = _nodoInicial;
            Nodo nodoAnterior = _nodoFinal;

            do
            {
                if (nodoActual.Dato == dato)
                {
                    if (nodoActual == _nodoInicial)
                    {
                        _nodoInicial = _nodoInicial.Siguiente;
                        _nodoFinal.Siguiente = _nodoInicial;
                    }
                    else if (nodoActual == _nodoFinal)
                    {
                        _nodoFinal = nodoAnterior;
                        _nodoFinal.Siguiente = _nodoInicial;
                    }
                    else
                    {
                        nodoAnterior.Siguiente = nodoActual.Siguiente;
                    }
                    return;
                }
                nodoAnterior = nodoActual;
                nodoActual = nodoActual.Siguiente;
            } while (nodoActual != _nodoInicial);
        }

        public string ObtenerValores()
        {
            if (EstaVacio()) return string.Empty;

            StringBuilder datos = new StringBuilder();
            Nodo nodoActual = _nodoInicial;
            do
            {
                datos.AppendLine(nodoActual.Dato);
                nodoActual = nodoActual.Siguiente;
            } while (nodoActual != _nodoInicial);

            return datos.ToString();
        }
    }
}
