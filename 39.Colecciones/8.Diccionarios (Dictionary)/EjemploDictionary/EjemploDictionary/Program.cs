using System;
using System.Collections.Generic;

namespace EjemploDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando un diccionario de pares Clave,Valor en el cual podemos almacenar objetos tipo persona, asociados a un valor númerico
            Dictionary<int, Persona> personas = new Dictionary<int, Persona>();

            //Agregando una persona a nuestro Diccionario: Nota: La clave asignada para cada persona debe ser única:
            personas.Add(1, new Persona
            {
                nombre = "Juan",
                edad = 12,
                fechaNacimiento = "12-12-2010"
            });

            personas.Add(2, new Persona
            {
                nombre = "Carlos",
                edad = 15,
                fechaNacimiento = "12-12-2005"
            });

            personas.Add(3, new Persona
            {
                nombre = "Fernando",
                edad = 19,
                fechaNacimiento = "12-12-2001"
            });


            //Recorriendo e imprimiendo la información de los objetos en cuestión: Recordar que el diccionario nos devuelve elementos de (clave,valor):
            foreach (KeyValuePair<int, Persona> valorPersona in personas)
            {
                //Al recorrer la colección, recorre el objeto iterable personas, extrayendo por cada iteración su contenido (Clave,Valor):
                Console.WriteLine("Clave del objeto: {0}  Persona asignada: {1} ",valorPersona.Key,valorPersona.Value.ToString());
            }

        }
    }
}
