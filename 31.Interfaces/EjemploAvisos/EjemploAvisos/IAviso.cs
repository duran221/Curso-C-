using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploAvisos
{
    interface IAviso
    {
        /// <summary>
        /// Los métodos de esta interfaz deben ser obligatoriamente implementados por la clase que herede
        /// </summary>
        void MostrarAviso();

        string GetFeha();
    }
}
