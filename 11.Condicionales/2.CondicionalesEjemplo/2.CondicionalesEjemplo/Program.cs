using System;

namespace _2.CondicionalesEjemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos a evaluar si puedes conducir coche");

            Console.WriteLine("Por favor, introduce tu edad");
            byte edad = Byte.Parse(Console.ReadLine());

            Console.WriteLine("¿Tienes carnet?");
            string carnet = Console.ReadLine();

            if(edad>= 18 && carnet=="si")
                Console.WriteLine("Puedes conducir");

            else
                Console.WriteLine("No puedes conducir");

        }
    }
}
