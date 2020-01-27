using System;
using System.IO;

namespace Destructores
{
    class Program
    {
        static void Main(string[] args)
        {
            ManejoArchivos archivo = new ManejoArchivos();

            archivo.Mensaje();
        }
    }

    public class ManejoArchivos
    {
        //Usando un flujo de datos Stream de datos
        StreamReader archivo = null;

        int contador = 0;
        string linea;

        public ManejoArchivos()
        {
            //Accediendo a la ruta relativa donde ubicamos el archivo en el proyecto
            archivo = new StreamReader(@"..\..\..\archivo\text.txt");

            while((linea=archivo.ReadLine()) != null)
            {
                Console.WriteLine(linea);
                contador++;
            }

        }

        public void Mensaje() => Console.WriteLine("hay {0} lineas",contador);

        /// <summary>
        /// Sintaxis de un método destructor, todo aquello que quieres que se ejectute inmediatamente después de haber eliminado
        /// el recolector de basuras el recurso correspondiente, por ejemplo cerrar un archivo ó una conexión a la base de datos
        /// </summary>
        ~ManejoArchivos()
        {
            archivo.Close();
        }


    }
}
