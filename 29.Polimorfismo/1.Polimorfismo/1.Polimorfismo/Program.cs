using System;

namespace _1.Polimorfismo
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

            /*El polimorfismo me permite que un objeto pueda tener distintos comportamientos de acuerdo al contexto en el cual este se encuentre
             En este caso si ejecutamos el programa podremos visualizar cómo estos Mamiferos se comportan de distinta forma ya que cada vez
             que el método Pensar es llamado, se ejecuta el método específico de su instancia*/
            foreach (Mamifero m in mamiferos)
            {
                m.Pensar();
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

        /// <summary>
        /// Estamos indicando con la palabra reservada 'virtual' que en un futuro todas las clases que hereden de este Supertipo deberían
        /// tener un método pensar que modifique el comportamiento del método pensar
        /// </summary>
        public virtual void Pensar()
        {
            Console.WriteLine("Estoy pensando con mis sentidos cognitivos");
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

        /// <summary>
        /// Al usar la palabra reservada 'override' el compilador sabe que no se trata de un método diferente, sinó que se trata de una 
        /// sobre-escritura o modificación del método de su clase padre 'Mamiferos'
        /// </summary>
        public override void Pensar()
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

        public override void Pensar()
        {
            Console.WriteLine("Tengo pensamientos de caballo");
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

        public override void Pensar()
        {
            Console.WriteLine("Tengo una forma de pensamiento cognitiva");
        }
    }
}
