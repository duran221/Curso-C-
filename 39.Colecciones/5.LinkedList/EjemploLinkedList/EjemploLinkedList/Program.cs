using System;
using System.Collections.Generic;

namespace EjemploLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creando una LinkedList:
            LinkedList<int> numeros = new LinkedList<int>();

            //Insertando números en nuestro LinkedList: El siguiente for recorre un vector declarado implícitamente, es hermoso:
            foreach (int numero in new int[] {10,8,6,4,2,0,-2 })
            {
                //El siguiente método agrega SIEMPRE el elemento entrante en la primera posición, con lo cual el primero en entrar sería el último en
                //Imprimirse.
                numeros.AddFirst(numero);

            }
            //Remueve la primer ocurrencia encontrada y la cual es especificada como argumento:
            numeros.Remove(-2);

            //Recorriendo la lista con un foreach
            foreach  (int i in numeros)
            {
                Console.WriteLine(i);

            }

            Console.WriteLine("*********************************");
            //La siguiente forma puede ilustrarnos de una mejor manera acerca de el funcionamiento de los LinkedList:
            //Uso de tratamiento de Nodos en todo su esplendor:
            for(LinkedListNode<int> nodo = numeros.First; nodo != null; nodo= nodo.Next)
            {
                int dato = nodo.Value;
                Console.WriteLine(dato);

            }

            Console.WriteLine("**********************************");
            //Creando un elemento de tipo nodo y añadiendolo a nuestra LinkedList:
            LinkedListNode<int> nodo1 = new LinkedListNode<int>(12);
            numeros.AddFirst(nodo1);

            foreach (int i in numeros)
            {
                Console.WriteLine(i);

            }
        }
    }
}
