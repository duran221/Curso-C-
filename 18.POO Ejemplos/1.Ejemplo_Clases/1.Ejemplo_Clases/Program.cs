using System;

namespace _1.Ejemplo_Clases
{
    class Program
    {

        static void Main(string[] args)
        {
            Circulo miCirculo; //Creación de objeto de tipo Circulo. Variable/objeto tipo Circulo.

            //Iniciación de variable/objeto tipo circulo.//Instanciar una clase//Ejemplarización//Creación de un ejemplar de clase
            miCirculo = new Circulo();

            Console.WriteLine($"El área de el Circulo es {miCirculo.calculaArea(5)}");

        }

    }

    /// <summary>
    /// Pretendo construir un Circulo y esta es descripción de dicho objeto.
    /// Estoy comentando una clase en C#
    /// </summary>
    class Circulo {

        //Propiedad de la clase Circulo. Campo de clase.
        private const double pi = Math.PI;

        /// <summary>
        /// Método de Clase ¿Qué pueden hacer los objetos de tipo Circulo?
        /// </summary>
        /// <param name="radio">El radio que se ingresa por el usuario</param>
        /// <returns>Un double con el balor del área del Circulo</returns>
        public double calculaArea(int radio) => Math.Pow(radio, 2) * pi;
    
    }
}
