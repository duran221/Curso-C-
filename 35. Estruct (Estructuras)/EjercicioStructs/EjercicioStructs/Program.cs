using System;

namespace EjercicioStructs
{
    class Program
    {
        static void Main(string[] args)
        {

            Empleado empleado1 = new Empleado(1200, 250);
            //Si realizo cambios en el empleado 1 al trabajar con clases, como dicho objeto se encuentra almacenado en el Heap y empleado1
            //hace referencia a dicho objeto, los cambios se verán reflejados en el objeto imprimiendo al final los valores de 1300 y 350
            //respetivamente.s
            empleado1.CambiaSalario(empleado1, 100);

            //Por el contrario si creamos una Struct no estamos modificando una referencia a algo que se almacena en el Heap, por el
            //contrario estamos creando una copia y trabajamos sobre la copia, por tanto los cambios no se van a ver reflejados en la 
            //estructura empleado y sus atributos salario y comisión permanecen inmutables 1200 y 250 respectivamente.


            //empleado1.comision += 100;

            Console.WriteLine(empleado1);
        }
    }
}
