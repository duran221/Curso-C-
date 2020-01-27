using System;

namespace EjemploGenericos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creando un array genérico de Strings
            AlmacenObjetos<String> m = new AlmacenObjetos<String>(5);

            //Usando la misma clase genérica para crear un array de enteros:
            AlmacenObjetos<int> n = new AlmacenObjetos<int>(2);

            //Usando nuevamente la misma clase genérica para crear un array de booleanos:
            AlmacenObjetos<bool> tr = new AlmacenObjetos<bool>(1);

            m.Agregar("jajajaaj");
            n.Agregar(86675);
            tr.Agregar(true);

            Console.WriteLine(m.GetElemento(0));
            Console.WriteLine(n.GetElemento(0));
            Console.WriteLine(tr.GetElemento(0));



        }
    }
}
