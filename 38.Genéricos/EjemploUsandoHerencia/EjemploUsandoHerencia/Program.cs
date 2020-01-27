using System;

namespace EjemploUsandoHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando un array de objetos de 4 posiciones, si analizamos con detenimiento veremos cómo se han agregado objetos de
            //Distintos tipos a el Array cosa que me parece maravillosa!!!!!! pero esto trae algunos inconvenientes, sobre todo con el tema
            //Del casting que resulta un poco engorroso, además de producir errores en ejecución los cuales en compilación son imperceptible,
            //Es por ello que se suele usar la programación genérica para solventar estos problemas:
            AlmacenObjetos almacen = new AlmacenObjetos(4);

            almacen.Agregar("Cristian Duran");
            almacen.Agregar(123431);
            almacen.Agregar(new Persona(21));

            Console.WriteLine((string)almacen.GetElemento(0));
            Console.WriteLine((int)almacen.GetElemento(1));

            Console.WriteLine(almacen.GetElemento(0).GetType().Name);

            Persona pepito = (Persona)almacen.GetElemento(2);
            Console.WriteLine(pepito.SALARIO);
        }
    }
}
