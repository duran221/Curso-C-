using System;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
           
            sumarNumeros(4, 3);
            Console.WriteLine("Este mensaje fué escrito desde la MAIN");

            Console.WriteLine($"el resultado de la división es: {divideNumeros(3,2)}");

            Console.WriteLine($"El resultado de la resta de dos números es: {restarNumeros(5,3)}");

        }

        /**
         * El método es estático ya que como no vamos a instanciar ningún objeto, necesitamos que sea estático.
         * Un método puede ser llamado cuantas veces queramos
         * La palabrita que aparece abajo que dice 'reference' me permite saber cuántas veces ha sido llamado un método en otra parte.
         * En estos momentos estamos haciendo un paso de párametros por VALOR
         * Realiza una suma entre dos números
         */
        static void sumarNumeros(int n1, int n2) {

            Console.WriteLine($"El resultado de la operación es:  {n1+n2}");
        }


        /**
         * Los métodos que no son void, siempre deben tener la palabra reservada return al final del método
         * El resultado no será impreso hasta que dicho método sea llamado e imprimido el valor que este retorna
         * Al operar un double con un int, el resultado será siempre un tipo de dato double.
         *
         */
        static double divideNumeros(int n1,double n2){
        
            return n1/n2;
        }


        /**
         * Otra forma bastante útil de declarar métodos es usar la notación flecha, con la cual podemos declarar el método en una sola
         * linea de código (VÁLIDO únicamente para métodos en los cuales que usa una única linea de código como los GET o SET por ejemplo)
         * Esto con el fín de simplificar nuestro código.
         */
        static int restarNumeros(int n1, int n2) => n1 - n2;

    }
}
