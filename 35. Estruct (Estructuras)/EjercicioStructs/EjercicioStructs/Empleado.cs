using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioStructs
{
    struct Empleado
    {

        public double salario, comision;

        public Empleado(double salario, double comision)
        {
            this.salario = salario;
            this.comision = comision;
        }

        public override string ToString() => string.Format("Salario y comisión del empleado ({0},{1})",this.salario,this.comision);

        public void CambiaSalario(Empleado emp, double incremento)
        {
            emp.salario += incremento;
            emp.comision += incremento;
        }
    }
}
