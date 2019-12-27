using System;

namespace Get_Setters
{
    class Program
    {
        static void Main(string[] args)
        {

            Auto auto1 = new Auto();

            auto1.Ruedas = 3;
            Console.WriteLine(auto1.Ruedas);
            Console.WriteLine(auto1.retornarCosto());

        }
    }

    /// <summary>
    /// Estableciendo una clase parcial con la cual podemos dividir una clase en trozos de código
    /// </summary>
    partial class Auto
    {
        //Auto-propiedades que nos permiten gestionar tanto set- como getters, muy útil para ahorrar costo en lineas de código
        public int Ruedas { get; set; }
        //Inicializando una Auto-propiedad
        public int valvulas { get; set; } = 16;
        public bool AireCondicionado { get; set; }
        public string tapiceria { get; set; }

        public Auto()
        {
            this.Ruedas = 4;
            this.AireCondicionado = false;
            this.tapiceria = "Cuero";

        }

    }

    /// <summary>
    /// Otro trozo de código perteneciente a la clase Auto:
    /// </summary>
    partial class Auto
    {
        public double retornarCosto()
        {
            return 12.3*this.Ruedas;
        }

    }
}
