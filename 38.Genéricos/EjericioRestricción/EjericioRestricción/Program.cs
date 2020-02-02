using System;

namespace EjericioRestricción
{
    class Program
    {
        static void Main(string[] args)
        {
            AlmacenEmpleados<Secretaria> secre = new AlmacenEmpleados<Secretaria>(1);

            Secretaria juliana = new Secretaria(1200);
            secre.Agregar(juliana);

            AlmacenEmpleados<Director> direct = new AlmacenEmpleados<Director>(1);

            Director dire = new Director(1500);
            direct.Agregar(dire);

            //Si descomentamos la siguiente linea de código nos daremos cuenta de como no es posible instanciar nuestro objeto desde la clase
            //genérica ya que esta tiene una restricción la cual permite únicamente instanciar clases que hereden de la interfaz IEmpleado
            //AlmacenEmpleados<Estudiante> est = new AlmacenEmpleados<Estudiante>(1);

            Console.WriteLine(secre.GetElemento(0).GetSalario());
            Console.WriteLine(direct.GetElemento(0).GetSalario());
            
        }
    }
}
