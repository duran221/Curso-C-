using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploDictionary
{
    class Persona
    {

        public string nombre { get; set; }
        public byte edad { get; set; }
        public string fechaNacimiento { get; set; }


        public Persona()
        {   
        }
        /// <summary>
        /// Retorna la descripción de la persona en instancia
        /// </summary>
        /// <returns>string con los datos de la persona en cuestión</returns>
        public override string ToString() => $"su nombre es {this.nombre}, edad es {this.edad} y su fecha de nacimiento es {this.fechaNacimiento}";
        


    }
}
