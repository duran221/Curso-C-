using System;

namespace EjemploProperties
{
    class Program
    {
        static void Main(string[] args)
        {

            Empleado emp1 = new Empleado("José");

            emp1.SALARIO = 300;

            //Accediendo sin problemas a la variable encapsulada
            Console.WriteLine($"El salario del empleado es {emp1.SALARIO}");

            //Una manera simple de cambiar el valor del salario:
            emp1.SALARIO += 500;

            Console.WriteLine($"El salario del empleado es {emp1.SALARIO}");

            //Como nuestro SET está condicionado a valores no negativos esta instrucción me arrojará como resultado 0 ya que el método
            //Set no me permite asignar salarios negativos.
            emp1.SALARIO = -200;

            Console.WriteLine($"El salario del empleado es {emp1.SALARIO}");

        }
    }
}
