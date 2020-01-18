using System;

namespace EjemploAvisos
{
    class Program
    {
        static void Main(string[] args)
        {
            AvisoTrafico av1 = new AvisoTrafico();

            av1.MostrarAviso();

            AvisoTrafico av2 = new AvisoTrafico("Cristian Duran", "Usted ha incumplido una norma de transito saldo :300", "12-11-16");

            av2.MostrarAviso();
            Console.WriteLine(av2.GetFeha());

        }
    }
}
