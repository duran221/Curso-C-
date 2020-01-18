using System;

namespace ClasesAbstractas
{
 
    class Program
    {
        static void Main(string[] args)
        {

            Humano cristianDuran = new Humano("Cristian");

            Caballo pepe = new Caballo("Pepito");

            //ISaltoConPatas iPepe = pepe;
            IMamiferosTerrestres iPepe = pepe;
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

            Ballena wally = new Ballena("Wally");
            wally.Nadar();

            Console.WriteLine($"Chepe tiene un total de {chepe.NumeroPatas()} patas");

            //Implementando el ejemplo de clases Abstractas:
            Console.WriteLine("Implementando ejemplo de clases abstractas:");

            //Instanciando un objeto de tipo Lagartija:
            Lagartija soka = new Lagartija("Chepe");
            //La lagartija puede respirar gracias a que hereda dicho método de la clase abstracta Animal, pero dicho método no es abstracto:
            soka.Respirar();
            //cristianDuran por su parte también lo hereda, y por tanto el mensaje que se muestra en pantalla es identico:
            cristianDuran.Respirar();
            //Los métodos siguientes son abstractos y a su vez heredados de Animal, y por tanto, tienen distinta implementación:
            soka.GetNombre();
            cristianDuran.GetNombre();


        }

    }

    abstract class Animal
    {

        public void Respirar() => Console.WriteLine("Estoy respirando");


        /// <summary>
        /// Este método al ser abstracto, por obligación debe ser implementado en TODAS las clases que hereden de Animal:
        /// </summary>
        public abstract void GetNombre();
    }

    interface ISaltoConPatas
    {

        int NumeroPatas();

    }

    interface IMamiferosTerrestres
    {
        //Ahora definimos el comportamiento ó métodos que OBLIGATORIAMENTE deben implementar las clases que implementen de ella
        //En el interior de un método de una interfaz NO HAY NUNCA CÓDIGO.
        //Los métodos de acceso de una interfaz, tampoco llevan modificadores de acceso PUBLIC,PRIVATE ó PROTECTED

        int NumeroPatas();


    }

    interface IAnimalesYDeportes
    {
        /// <summary>
        ///Informa el tipo de deporte que practica un Mamifero en específico 
        /// </summary>
        /// <returns></returns>
        string TipoDeporte();

        /// <summary>
        /// Informa si el deporte que practica un animal específico es un deporte olimpico o nó
        /// </summary>
        /// <returns>True si el deporte es olimpico, False de lo contrario</returns>
        Boolean EsOlimpico();
    }

    class Lagartija : Animal
    {
        private string nombreReptil;

        public Lagartija(string nombre)
        {
            this.nombreReptil = nombre;
        }

        public override void GetNombre() => Console.WriteLine($"El nombre del reptil es : {nombreReptil}");
    }

    class Mamifero : Animal
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

        /// <summary>
        /// Método implementado de la clase Abstracta Animal (Por obligación)
        /// </summary>
        public override void GetNombre() => Console.WriteLine("El nombre del mamífero es: {0} ",this.Nombre);

        public void Amamantar()
        {
            Console.WriteLine("Estoy amamantando a mis crías");

        }

    }

    class Ballena : Mamifero
    {

        public Ballena(string nombreBallena) : base(nombreBallena)
        {

        }

        public void Nadar()
        {
            Console.WriteLine("Estoy nadando");
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

    class Caballo : Mamifero, IMamiferosTerrestres, IAnimalesYDeportes, ISaltoConPatas
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

        /// <summary>
        /// Retorna el tipo de deporte que practican los caballos,Método implementado de la interfaz IAnimalesYDeportes
        /// </summary>
        /// <returns></returns>
        public String TipoDeporte() => "Hipica";

        /// <summary>
        /// Retorna si el deporte practicado por el caballo es considerado olimpico, Método implementado de la interfaz IAnimalesYDeportes
        /// </summary>
        /// <returns></returns>
        public Boolean EsOlimpico() => true;

        /// <summary>
        /// Retorna el número de patas de un caballo
        /// </summary>
        /// <returns>entero con la cantidad de patas del animal</returns>
        int IMamiferosTerrestres.NumeroPatas() => 4;

        /// <summary>
        /// Retorna el número de patas con las cuales salta el caballo
        /// Nota: Para eliminar la ambiguedad que se produce con la interfaz IMamiferosTerrestres y su método NumeroPatas específicamos
        /// La siguiente sintaxis (NombreInterfaz.NombreMétodo)
        /// Se DEBE ELIMINAR el modificador de acceso para corregir una ambiguedad que se genera al querer por ejemplo llamar alguno de los
        /// dos métodos ¿A cual método haría referencia si lo llamo desde una instancia?
        /// </summary>
        /// <returns></returns>
        int ISaltoConPatas.NumeroPatas() => 2;

        public void Galopar()
        {

            Console.WriteLine("Estoy galopando");
        }
    }

    class Gorilla : Mamifero, IMamiferosTerrestres
    {
        public Gorilla(string nombre) : base(nombre)
        {

        }

        /// <summary>
        /// Retorna el número de patas de un gorilla
        /// </summary>
        /// <returns>entero con la cantidad de patas del animal</returns>
        public int NumeroPatas() => 2;

        public void Trepar()
        {
            Console.WriteLine("Estoy trepando por los zurcos");
        }
    }

}
