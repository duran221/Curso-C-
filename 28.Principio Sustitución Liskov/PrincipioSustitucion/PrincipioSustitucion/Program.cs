using System;

namespace PrincipioSustitucion
{
   
    class Program
    {
        static void Main(string[] args)
        {
            //Podemos analizar el principio de sustitución en la práctica ya que al cambiar un Humano siempre es un mamífero,
            //Pero no necesariamene siempre ocurre lo mismo en sentido contrario
            Mamifero humano = new Humano("Cristian");

            //Al igual, que por ejemplo, un Caballo siempre es un Mámifero, pero no viceversa
            Mamifero caballo = new Caballo("Horse");

            Mamifero gorilla = new Gorilla("Chita");

            Mamifero[] mamiferos = new Mamifero[3];

            mamiferos[0] = caballo;
            mamiferos[1] = gorilla;
            mamiferos[2] = humano;

            //Esto nos puede traer beneficios tan grandes como por ejemplo, poder recorrer objetos almacenados en un array cuyo tipo del
            //supertipo es el mismo, recorriendo un array de Mamiferos que no necesariamente son del mismo tipo, hay humanos, caballos y gorillas.
            foreach(Mamifero m in mamiferos)
            {
                Console.WriteLine(m.Nombre);
            }
        }

    }

    class Mamifero
    {
        public string Nombre { get; }


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
