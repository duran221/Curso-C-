using System;

namespace ConstructoresHerencia
{
    class Program
    {
        static void Main(string[] args)
        {

            Humano cristianDuran = new Humano("Cristian");

            Caballo pepe = new Caballo("Pepito");

            Gorilla chepe = new Gorilla("Chita");

            cristianDuran.Pensar();

            //cristianDuran.Nombre = "Juan";
            Console.WriteLine(cristianDuran.Nombre);

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
        public string Nombre { get;}


        /// <summary>
        /// Construyendo un constructor para la superclase, con esto, será necesario implementar una llamada a dicho constructor
        /// en TODOS los demás objetos que hereden de el, veamos:
        /// </summary>
        /// <param name="nombre"></param>
        public Mamifero(string nombre)
        {
            this.Nombre = nombre;
        }

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
    class Humano : Mamifero
    {
        public Humano(string nombre) : base(nombre)
        {

        }

        public void Hablar()
        {
            Console.WriteLine("Estoy hablando");
        }

        public void Pensar()
        {
            Console.WriteLine("Estoy pensando");
        }

    }

    class Caballo : Mamifero
    {
        /// <summary>
        /// Con la instruccion ':base' lo que estamos haciendo es indicarle a nuestro constructor base, que al inicializarse, además
        /// debe llamar el constructor de la clase padre, y pasar como argumento un párametro, en este caso será el nombre del Mamífero
        /// y cuyo atributo comparten todas sus clases hijas.
        /// </summary>
        /// <param name="nombre"></param>
        public Caballo(string nombre) : base(nombre)
        {

        }

        public void Galopar()
        {

            Console.WriteLine("Estoy galopando");
        }
    }

    class Gorilla : Mamifero
    {
        public Gorilla(string nombre) : base(nombre)
        {

        }

        public void Trepar()
        {
            Console.WriteLine("Estoy trepando por los zurcos");
        }
    }
}
