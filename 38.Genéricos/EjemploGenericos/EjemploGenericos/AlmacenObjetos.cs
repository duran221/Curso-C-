using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploGenericos
{
    /// <summary>
    /// Para específicar una clase Genérica todo lo que debemos hacer es indicar entre parentesís angulares un tipo, por convensión
    /// se Usa letras únicas en mayuscula y generalmente se usa la letra T
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class AlmacenObjetos <T>
    {
        private T[] objetos;
        private int i;

        public AlmacenObjetos(int i)
        {
            this.objetos = new T[i];
            this.i = 0;
        }

        /// <summary>
        /// Permite agregar un elemento a el array de Genéricos
        /// </summary>
        /// <param name="elemento"></param>
        public void Agregar(T elemento)
        {
            this.objetos[i] = elemento;
            this.i++;
        }

        /// <summary>
        /// Permite obtener un elemento del array específicada su posición
        /// </summary>
        /// <param name="i">Posición del objeto en el array que deseo obtener</param>
        /// <returns></returns>
        public T GetElemento(int i) => this.objetos[i];
    }
}
