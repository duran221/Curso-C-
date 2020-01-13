using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio
{
    class Coche : Vehiculo
    {
        public void Acelerar()
        {
            Console.WriteLine("Estoy acelerando");
        }

        public void Frenar()
        {
            Console.WriteLine("Estoy frenando el vehículo");
        }

        /// <summary>
        /// Sobreescribiendo el método Conducir que hereda directamente desde el supertipo Vehículo
        /// </summary>
        public override void Conducir()
        {
            //base.Conducir();

            Console.WriteLine("Tomando las curvas con presición y destreza");
        }
    }
}
