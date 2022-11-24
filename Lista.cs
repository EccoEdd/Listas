using System;

namespace Listas
{
    internal class Lista
    {
        private Nodo P = new Nodo();
        private Nodo F = new Nodo();

        public Lista()
        {
            P = null;
            F = null;
        }

        public void MostrarLista()
        {
            if (P == null)
                Console.WriteLine("Lista vacia");
            else if (P == F)
                Console.WriteLine("Elemento: " + P.dato);
            else
            {
                Console.WriteLine("1 Ascendente, 2 Descendente: ");
                byte N = Convert.ToByte(Console.ReadLine());
                Nodo T;
                if (N == 1)
                {
                    T = P;
                    Console.WriteLine("Elemento: " + T.dato);
                    while (T.siguiente != null)
                    {
                        Console.WriteLine("Elemento: " + (T.siguiente).dato);
                        T = T.siguiente;
                    }
                }
                else
                {
                    T = F;
                    Console.WriteLine("Elemento: " + T.dato);
                    while (T.anterior != null)
                    {
                        Console.WriteLine("Elemento: " + (T.anterior).dato);
                        T = T.anterior;
                    }
                }
            }
        }

        public void InsertarElemento()
        {
            int comparison;

            Nodo N = new Nodo();
            Console.WriteLine("Elemento a guardar");
            N.dato = Console.ReadLine();

            if (P == null)
            {
                P = N;
                F = N;
            }
            else if (P == F)
            {
                comparison = String.Compare(N.dato, P.dato, comparisonType:
                    StringComparison.OrdinalIgnoreCase);
                if (comparison < 0)
                {
                    P.anterior = N;
                    N.siguiente = P;
                    F = P;
                    P = N;
                }
                else
                {
                    P.siguiente = N;
                    N.anterior = P;
                    F = N;
                }
            }
            else
            {
                Nodo Q = P;
                while (Q.siguiente != null)
                {
                    comparison = String.Compare(N.dato, Q.dato, comparisonType:
                                 StringComparison.OrdinalIgnoreCase);
                    if (comparison < 0)
                    {
                        if (Q == P)
                        {
                            P.anterior = N;
                            N.siguiente = P;
                            P = N;
                            break;
                        }
                        else
                        {
                            N.siguiente = Q;
                            N.anterior = Q.anterior;
                            (Q.anterior).siguiente = N;
                            Q.anterior = N;
                            break;
                        }
                    }
                    Q = Q.siguiente;
                }
                if (Q == F)
                {
                    comparison = String.Compare(N.dato, Q.dato, comparisonType:
                                StringComparison.OrdinalIgnoreCase);
                    if (comparison < 0)
                    {
                        N.siguiente = F;
                        N.anterior = F.anterior;
                        (F.anterior).siguiente = N;
                        F.anterior = N;
                    }
                    else
                    {
                        F.siguiente = N;
                        N.anterior = F;
                        F = N;
                    }
                }
            }
        }

        public void BuscarElemento()
        {
            if (P == null)
            {
                Console.WriteLine("Lista Vacia");
                return;
            }
            int count = 0;
            Console.WriteLine("Elemento a buscar: ");
            string elemento = Console.ReadLine();
            Nodo T = P;
            if (T.dato == elemento)
            {
                Console.WriteLine("Encontrado en: 1");
                return;
            }
            while (T.siguiente != null)
            {
                count++;
                if (T.dato == elemento)
                {
                    Console.WriteLine("Encontrado en: " + count);
                    return;
                }
                T = T.siguiente;
            }
            if (T == F && T.dato == elemento)
            {
                Console.WriteLine("Encontrado al final");
                return;
            }
            Console.WriteLine("Elemento no encontrado");
        }

        public bool EliminarElemento()
        {
            if (P == null)
            {
                Console.WriteLine("Lista Vacia");
                return false;
            }
            int count = 0;
            Console.WriteLine("Elemento a buscar: ");
            string elemento = Console.ReadLine();
            Nodo T = P;
            if (T.dato == elemento)
            {
                Console.WriteLine("Encontrado en: 1");
                P = null;
                F = null;
                return true;
            }
            while (T.siguiente != null)
            {
                count++;
                if (T.dato == elemento)
                {
                    Console.WriteLine("Encontrado en: " + count);
                    (T.anterior).siguiente = T.siguiente;
                    (T.siguiente).anterior = T.anterior;
                    return true;
                }
                T = T.siguiente;
            }
            if (T == F && T.dato == elemento)
            {
                Console.WriteLine("Encontrado al final");
                F = T.anterior;
                F.siguiente = null;
                return true;
            }
            Console.WriteLine("Elemento no encontrado");
            return false;
        }

        public void ModificarElemento()
        {
            if (EliminarElemento())
                InsertarElemento();
        }
        public void EliminarInicializar()
        {
            if (P == null)
                return;

            if (P == F)
                P = F = null;

            else
            {
                while (F.anterior != null)
                {
                    F = F.anterior;
                    (F.siguiente).anterior = null;
                    F.siguiente = null;
                }
                P = F = null;
            }
        }
       
    }
}