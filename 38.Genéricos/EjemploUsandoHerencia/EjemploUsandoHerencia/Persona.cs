using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploUsandoHerencia
{
    class Persona
    {
        //Autopropiedad que me permite obtener el salario de la persona
        public double SALARIO { get; }

        public Persona(double salario)
        {
            this.SALARIO = salario;
        }


    }
}
