using System;
using System.Collections.Generic;
using System.Text;

namespace EjericioRestricción
{
    class Electricista : Empleado , IEmpleado
    {

        public Electricista(double salario) : base(salario)
        {

        }

        /// <summary>
        /// Retorna el salario de un electricista
        /// </summary>
        /// <returns></returns>
        public double GetSalario() => this.salario;
    }
}
