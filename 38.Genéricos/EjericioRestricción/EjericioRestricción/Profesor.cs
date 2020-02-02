using System;
using System.Collections.Generic;
using System.Text;

namespace EjericioRestricción
{
    class Profesor : Empleado , IEmpleado
    {
        public Profesor(double salario) : base(salario)
        {

        }

        /// <summary>
        /// Retorna el salario de un profesor
        /// </summary>
        /// <returns></returns>
        public double GetSalario() => this.salario;
    }
}
