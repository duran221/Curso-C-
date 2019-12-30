using System;

namespace ClasesAnonimas
{
    class Program
    {
        static void Main(string[] args)
        {

            var claseAnonima1 = new {
                Nombre="Cristian",
                edad= 25,
                carrera= "Ingeniería de sistemas"
            };

            var claseAnonima2 = new { 
                Nombre= "Juan Carlos",
                edad= 20,
                carrera= "Ingeniería de sistemas"
            
            };

            Console.WriteLine($"Datos de la clase anónima 1: Nombre {claseAnonima1.Nombre}, edad {claseAnonima1.edad}, carrera {claseAnonima1.carrera}");

            claseAnonima1 = claseAnonima2;

            Console.WriteLine($"Datos de la clase anónima 1: Nombre {claseAnonima1.Nombre}, edad {claseAnonima1.edad}, carrera {claseAnonima1.carrera}");

        }

    }
}
