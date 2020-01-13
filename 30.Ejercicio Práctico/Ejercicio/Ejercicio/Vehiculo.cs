using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio
{
    class Vehiculo
    {
        /// <summary>
        /// Permite arrancar el motor del Vehiculo
        /// Nota, nótese como para los metodos uso PascalCase y para los parametros uso camelCase
        /// </summary>
        /// <param name="sonidoArrancar"></param>
        public void ArrancaMotor(string sonidoArrancar)
        {
            Console.WriteLine($"Arranca el motor {sonidoArrancar}");
        }

        /// <summary>
        /// Permite parar el motor del vehículo
        /// </summary>
        /// <param name="sonidoParar"></param>
        public void PararMotor(string sonidoParar)
        {
            Console.WriteLine($"Parar el motor {sonidoParar}");
        }

        /// <summary>
        /// Debemos tener en cuenta que este método es común a todos los vehículos, PERO cada vehículo implementa este método
        /// de manera distinta, ó contextualizando cada Vehículo puede conducirse de manera distinta.
        /// </summary>
        public virtual void Conducir()
        {
            Console.WriteLine("Este es el códifo genérico que tiene el método Conducir");
        }




    }
}
