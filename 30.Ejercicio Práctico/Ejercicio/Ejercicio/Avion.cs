using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio
{
    class Avion : Vehiculo
    {

        public void Despegar()
        {
            Console.WriteLine("Estoy despegando");
        }

        public void Aterrizar()
        {
            Console.WriteLine("Estoy despegando");
        }

        public override void Conducir()
        {
            //base.Conducir();
            Console.WriteLine("Zurcando los cielos del globos");
        }


    }
}
