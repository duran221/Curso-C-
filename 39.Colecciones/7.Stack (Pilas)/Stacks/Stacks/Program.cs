using System;
using System.Collections.Generic;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando una pila de elementos enteros por defecto:
            Stack<int> pila = new Stack<int>();

            //Agregando elementos en la pila:
            pila.Push(3);
            pila.Push(4);
            pila.Push(5);
            pila.Push(6);
            pila.Push(7);
            pila.Push(8);
            pila.Push(9);

            //Desapilando elementos de la pila: Último en entrar, primero en salir (como una pila de platos):
            Console.WriteLine(pila.Pop());
            Console.WriteLine(pila.Pop());
            Console.WriteLine(pila.Pop());

            //Para más Métodos, revisar la documentación de .NET


        }
    }
}
