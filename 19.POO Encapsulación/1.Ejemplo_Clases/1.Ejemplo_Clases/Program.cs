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

            Console.WriteLine($"El área de el Circulo es {miCirculo.CalculaArea(5)}");

            ConversorEuroDolar miConversion = new ConversorEuroDolar();
            Console.WriteLine($"El valor de la conversión a euros es: {miConversion.Convierte(50)}");

        }

    }

    class ConversorEuroDolar
    {
        private double euro = 1.41;

        /// <summary>
        /// Método público que me permite realizar una conversión de dólares a pesos
        /// </summary>
        /// <param name="cantidad">Double con la cantidad de dolares ingresado</param>
        /// <returns>Un double con el valor convertido a Euros</returns>
        public double Convierte(double cantidad)
        {
            return cantidad * euro;
        }

        /// <summary>
        /// Método que permite módificar el valor de la variable euro siempre y cuando ésta sea mayor que cero
        /// Nótese cómo debo utilizar PascalCase a la hora de nombrar métodos públicos
        /// </summary>
        /// <param name="euro">Valor con el cual deseo modificar el valor de los euros</param>
        public void ModificarEuro(double euro)
        {
            if (euro > 0)
            {
                this.euro = euro;
            }
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
        public double CalculaArea(int radio) => Math.Pow(radio, 2) * pi;
    
    }
}
