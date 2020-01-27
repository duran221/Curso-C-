using System;
using System.Collections.Generic;
using System.Text;

namespace Enum
{
   
    class Empleado
    {
        //Podemos perfectamente crear un tipo Enumerado y realizar algún tipo de operación con el:
        private Bonus bonusEmpleado;

        private double salario, bonus;

        /// <summary>
        /// Podemos trabajar con los tipos Enúmerados además también como parámetros
        /// </summary>
        /// <param name=""></param>
        public Empleado(Bonus bonusEmpleado, double salario)
        {
            this.bonus = (double)bonusEmpleado;
            this.salario = salario;
            this.bonusEmpleado = bonusEmpleado;

        }

        public double SALARIO
        {
            get => this.salario+this.bonus;
        }

        public double BONUS
        {
            get => this.bonus;
        }


    }
}
