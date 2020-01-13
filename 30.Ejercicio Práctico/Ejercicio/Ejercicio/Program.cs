using System;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Creando una instancia de la clase Avión:
            Console.WriteLine("Probando nuestro avión:");

            Avion avion = new Avion();

            avion.ArrancaMotor("TRRRRRRR!!!...");
            avion.Despegar();
            avion.Conducir();
            avion.Aterrizar();
            avion.PararMotor("pshhhhhhhh...");
            Console.WriteLine("****************************");

            //Creando una instancia de la clase Coche:
            Coche coche = new Coche();

            coche.ArrancaMotor("Buum Buum");
            coche.Acelerar();
            coche.Conducir();
            coche.Frenar();
            coche.PararMotor("Prake!!");

            Console.WriteLine();

            Console.WriteLine("Polimorfismo en acción:");

            Vehiculo vehiculo = new Vehiculo();

            //Principio de sustitución de Liskov un coche siempre es un vehiculo:
            vehiculo = coche;

            //Este vehículo se comporta de maneras distintas, puede comportarse como un Coche y también como un avión:
            vehiculo.Conducir();

            vehiculo = avion;
            vehiculo.Conducir();
        }
    }
}
