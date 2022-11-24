using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();
            LosMinions losMinions = new LosMinions();
            int n;
            while (true)
            {
                Console.WriteLine("Acciones: Mostrar Lista = 1, Insertar = 2, " +
                    "Buscar = 3, Eliminar = 4, Modificar = 5, LiberarMemoria = 6, " +
                    "Integrantes = 7");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        lista.MostrarLista();
                        break;
                    case 2:
                        lista.InsertarElemento();
                        break;
                    case 3:
                        lista.BuscarElemento();
                        break;
                    case 4:
                        lista.EliminarElemento();
                        break;
                    case 5:
                        lista.ModificarElemento();
                        break;
                    case 6:
                        lista.EliminarInicializar();
                        break;
                    case 7:
                        losMinions.Presentan();
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
            
        }
    }
}