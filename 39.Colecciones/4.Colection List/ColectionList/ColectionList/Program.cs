using System;
using System.Collections.Generic;

namespace ColectionList
{
    class Program
    {
        static void Main(string[] args)
        {

            //Creando una colección tipo List de números enteros:
            List<int> numeros = new List<int>();
            string condicion;

            do
            {
                Console.WriteLine("Ingrese un número");

                int numero = Int32.Parse(Console.ReadLine());
                numeros.Add(numero);

                Console.WriteLine("Desea finalizar? S/N");
                condicion = Console.ReadLine();

            } while (condicion.Equals("N"));

            //Removiendo el último elemento de la colección
            numeros.RemoveAt(numeros.Count - 1);

            Console.WriteLine("Elementos introducidos: ");

            //Usando un foreach para recorrer la colección:
            foreach(int elemento in numeros)
            {
                Console.WriteLine(elemento);

            }

            //Para más información sobre las List, consultar la documentación de .NET
        }
    }
}

