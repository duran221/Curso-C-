using System;

namespace Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Al instanciar una clase, estoy en pocas palabras, invocando su constructor para que el objeto sea construído:
            Coche pichirilo = new Coche();
            Console.WriteLine(pichirilo.GetInformacion());

            Coche pichirilo2 = new Coche(3, 2.1);
            Console.WriteLine(pichirilo2.GetInformacion());


        }
    }


    public class Coche
    {
        private int ruedas;
        private double altura;
        private double largo;
        private double ancho;
        private bool aireAcondicionado;

        public Coche()
        {
            this.ruedas = 4;
            this.altura = 2;
            this.largo = 1.2;
            this.ancho = 0.2;
            this.aireAcondicionado = true;
        }

        public Coche(double altura,double largo)
        {
            this.ruedas = 4;
            this.altura = altura;
            this.largo = largo;
            this.ancho = 0.2;
            this.aireAcondicionado = true;
        }

        /// <summary>
        /// Indica el estado actual del coche así como el contenido de algunas de sus variables.
        /// </summary>
        /// <returns>Un String con el estado de las variables del coche actualmente instanciado</returns>
        public string GetInformacion() => $"Num ruedas: {this.ruedas}, altura: {this.altura}, largo del coche: {this.largo}, alto: {this.ancho}";      
    }
}
