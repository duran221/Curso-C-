using System;
using System.Collections.Generic;
using System.Text;

namespace EjericioRestricción
{
    /// <summary>
    /// La siguiente clausula me indica que nuestra clase Genérica tendrá una resticción, dicha clase será capaz de manejar
    /// objetos de distinto tipo, siempre y cuando, dichos objetos IMPLEMENTEN de la interfaz IEMPLEADO, cabe aclarar que la restricción
    /// puede ser una superclase o cualquier objeto que deseemos restringir
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class AlmacenEmpleados <T> where T : IEmpleado 
    {

        private int i;
        private T[] empleados;

        public AlmacenEmpleados(int size)
        {
            this.empleados = new T[size];
            this.i = 0;
        }

        /// <summary>
        /// Permite obtener un objeto, especificada su posición en el vector
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public T GetElemento(int i) => this.empleados[i];

        /// <summary>
        /// Permite añadir un elemento a el vector especificada su posición
        /// </summary>
        /// <param name="elemento"></param>
        public void Agregar(T elemento)
        {
            this.empleados[i] = elemento;
            this.i++;
        }
       
    }
}
