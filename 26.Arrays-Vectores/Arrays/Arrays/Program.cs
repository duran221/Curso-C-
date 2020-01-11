using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] edades = new int[2];

            edades[0] = 12;
            edades[1] = 11;

            int[] anios = { 2, 3, 4, 5 };

            Console.WriteLine(edades[0]);
            Console.WriteLine(anios[0]);

            //Así se declara un array implícito:
            var implicito = new[] {2,2.5,3.2,0.5 };
            
            var implicito2 = new[] {"Nombre1", "Nombre2", "Nombre3"};

            //Declarando un array de objetos
            Persona[] salon = new Persona[2];
            salon[0] = new Persona("Cris", 22);

            //Declarando e inicializando un array de tipos o clases anónimas:
            var arrayClaseAnonima = new[]
            {
                new {velocidad=300,marca= "Chevrolet" },
                new {velocidad=200,marca= "Renault" },
                new {velocidad=330,marca= "Renault" }
            };

            Console.WriteLine(arrayClaseAnonima[0]);
            
            for(int i=0; i<anios.Length; i++)
            {
                Console.WriteLine($"años del personaje {i+1} : {anios[i]}");
            }


            
        }
    }

    class Persona
    {
        string nombre { get; set; }
        int edad { get; set; }


        public Persona(string nombre,int edad) {

            this.nombre = nombre;
            this.edad = edad;
        }

    }
}
