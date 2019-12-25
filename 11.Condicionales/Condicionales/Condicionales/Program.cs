using System;

namespace Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos a evaluar si eres mayor de edad!");
            Console.WriteLine("Por favor, ingrese su edad:");

            byte edad = byte.Parse(Console.ReadLine());

            //Cuando tanto en el 'if' como en el 'else' usamos no más de una linea de código es posible ovbiar las llaves también:
            if (edad >= 18)
            
                Console.WriteLine("Eres Mayor de edad :/");
            
            else
            
                Console.WriteLine("Eres Menor de edad :)");
            

            byte factor = 12;

            //C# permite que omitamos el uso de llaves a la hora de programar ÚNICAMENTE cuando dentro del condicional hay una sola
            //linea de código.
            if(factor>15)

                Console.WriteLine("No tienes suficiente Level men");

            Console.WriteLine("Imprimiendo un mensaje que no hace parte del condicional");

            bool condicion = true;

            //Podemos también prescindir del '==true' ya que se el condicional evalúa dicha condición también de esta manera:
            if (condicion)

                Console.WriteLine("Cumple la condición");




        }
    }
}
