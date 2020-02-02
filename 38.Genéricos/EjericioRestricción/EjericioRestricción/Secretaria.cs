using System;
using System.Collections.Generic;
using System.Text;

namespace EjericioRestricción
{
    class Secretaria : Empleado , IEmpleado
    {
        public Secretaria(double salario) : base(salario)
        {
            
        }

        /// <summary>
        /// Retorna el salario de un empleado
        /// </summary>
        /// <returns></returns>
        public double GetSalario() => this.salario;

    }
}
