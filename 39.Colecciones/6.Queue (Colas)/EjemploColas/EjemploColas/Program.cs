using System;
using System.Collections.Generic;

namespace EjemploColas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creando una cola para realizar operaciones con ella:
            Queue<int> cola = new Queue<int>();

            foreach (int numero in new int[] {2, 4, 6, 8, 20 })
            {
                //Encolando números en nuestra cola de elementos:
                cola.Enqueue(numero);
            }

            //Recorriendo los números con tenidos en el Queue (Desencolando)
            Console.WriteLine("Recorriendo los elementos de la cola");
            foreach(int numero in cola)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("Eliminando elementos de la cola");

            //El siguiente código me permite desencolar el primer elemento en nuestra Cola:
            cola.Dequeue();

            foreach (int numero in cola)
            {
                Console.WriteLine(numero);
            }
            {

            }

        }
    }
}
