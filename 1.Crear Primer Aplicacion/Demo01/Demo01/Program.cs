using System;

namespace Demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            //CONSTANTE PI:
            const float PI = 3.1416F;

            Console.WriteLine("Ingrese la medida de radio de la circunferencia");

            int radio = int.Parse(Console.ReadLine());

            //float resultado = (radio * radio) * PI;

            //Una forma quizá más elegante de realizar la potencia es mediante el uso de la libreria Math que veremos más adelante:
            double resultado = Math.Pow((double)radio, 2)*PI;

            Console.WriteLine($"El radio de la circunferencia es: {resultado}");
            




        }
    }
}
