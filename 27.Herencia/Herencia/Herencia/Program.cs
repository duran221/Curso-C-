using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {

            Humano cristianDuran= new Humano();

            Caballo pepe= new Caballo();

            Gorilla chepe = new Gorilla();

            cristianDuran.Pensar();

            pepe.Galopar();

            pepe.Respirar();

            //Al heredar de la clase 'Mamifero', al igual que las demás clases que heredan de esta tenemos acceso a sus métodos, tal es
            //el caso del comportamiento respirar, común en todos los mamíferos.
            cristianDuran.Respirar();

            chepe.Trepar();
        }

    }

    class Mamifero
    {
        public void Respirar()
        {
            Console.WriteLine("Estoy respirando");

        }

        public void Amamantar()
        {
            Console.WriteLine("Estoy amamantando a mis crías");

        }

    }

    /// <summary>
    /// La sintaxis de la HERENCIA se puede establecer mediante los ':' con esa sintaxis, estamos denotando que dicha clase 
    /// hereda de un supertipo, en este caso estamos heredando de la clase Mamífero
    /// </summary>
    class Humano: Mamifero
    {
        public void Hablar()
        {
            Console.WriteLine("Estoy hablando");
        }

        public void Pensar()
        {
            Console.WriteLine("Estoy pensando");
        }

    }

    class Caballo: Mamifero
    {
        public void Galopar() {

            Console.WriteLine("Estoy galopando");
        }
    }

    class Gorilla: Mamifero
    {
        public void Trepar()
        {
            Console.WriteLine("Estoy trepando por los zurcos");
        }
    }
}
