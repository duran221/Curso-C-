using System;

namespace Ejemplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vamos a crear una forma distinta de realizar el ejercicio 2: Veamos

            Console.WriteLine("Introduzca su edad:");

            byte edad = Byte.Parse(Console.ReadLine());

            //Obviando el uso de llaves cuando se tiene una única linea de código:
            if (edad < 18) Console.WriteLine("No tienes edad suficiente para conducir");

            else
            {
                Console.WriteLine("Tienes carnet?");
                String carnet = Console.ReadLine();

                //Detalle cómo el método que hay dentro del IF es más adecuado para comparar cadenas de Strings
                //Este metodo arroja un cero en caso de coincidir las cadenas, utiliza un tercer argumento para indicar si 
                //Es sencible o no a MAYUSCULAS:
                if (String.Compare(carnet, "si", true)==0) Console.WriteLine("En hora buena! puedes conducir!");

                else
                    Console.WriteLine("No puedes conducir");

            }
        }
    }
}
