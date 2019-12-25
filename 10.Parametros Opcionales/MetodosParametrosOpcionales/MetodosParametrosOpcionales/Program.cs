using System;

namespace MetodosParametrosOpcionales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("La suma de los números es: "+sumaNumeros());
            Console.WriteLine("La suma de los números es: "+sumaNumeros(3,6));


        }


        /**
         * Si analizamos con detenimiento veremos que no se genera ningún error de sintaxis
         * Ya que los parámetro opcionales me permiten que un método sea tratado como tal con hasta tres párametros OPCIONALES
         * La regla que si OBLIGATORIAMENTE debo respetar es el hecho de que los párametros obligatorios DEBEN ir primero, no se admite
         * ni intercalar ni mucho menos colocarlos al final
        */
        private static double sumaNumeros(int valor1=3, int valor2=8, int valor3=4) {

            return valor1 + valor2 + valor3;
        }
    }
}
