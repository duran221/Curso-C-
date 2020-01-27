using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploUsandoHerencia
{
    class AlmacenObjetos
    {
        private Object[] vector;
        private int i;

        public AlmacenObjetos(int posiciones)
        {
            vector = new Object[posiciones];
                                                                                                                            
        }


        /// <summary>
        /// Permite añadir un objeto a el vector de elementos
        /// </summary>
        /// <param name="obj"></param>
        public void Agregar(Object obj)
        {
            this.vector[i] = obj;
            this.i++;
        }                                                                                                                                                                                                                                                                                       

        /// <summary>
        /// Permite obtener un elemento del vector dada su posición
        /// </summary>
        /// <param name="i">Posición del vector que se desea obtener</param>
        /// <returns>Objeto de tipo Object en la posición especificada</returns>
        public Object GetElemento(int i) => this.vector[i];



    }
}
