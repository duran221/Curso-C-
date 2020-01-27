using System;

namespace Enum
{
    //Creando un tipo de dato enumerado, Recordar que esto no es un String, es un tipo Enumerado:
    enum Bonus {BAJO=500,NORMAL=1000,BUENO=1500,EXTRA=3000};
    class Program
    {
        static void Main(string[] args)
        {
            Bonus antonio = Bonus.BAJO;

            //Almacenando el valor de el bonus en una variable de tipo double, de ahí el casting realizado.
            double bonusAtonio = (double) antonio;

            Console.WriteLine($"El valor del bonus es {bonusAtonio}");

            //Específicamos como argumento a el constructor un tipo de dato Enumerado:
            Empleado cristian = new Empleado(Bonus.EXTRA, 1900.65);

            Console.WriteLine($"El salario del empleado es {cristian.SALARIO}");
        }
    }
}
