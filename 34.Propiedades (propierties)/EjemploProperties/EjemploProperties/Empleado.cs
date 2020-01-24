using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploProperties
{
    class Empleado
    {
        private string _nombre;
        private double salario;

        public Empleado(string nombre)
        {
            this._nombre = nombre;
        }

        
        /// <summary>
        /// Creando una Propertie con una sintaxis más simplificada, una nomenclatura o convención usada usualmente para diferenciar
        /// claramente una propertie de una variable es anteponer un '_', también podemos tener claro que podemos usar properties de sólo
        /// escritura (útil por ejemplo para contraseñas) prescindiendo del método get.
        /// </summary>
        public string NOMBRE
        {
            get => this._nombre;
            set => this._nombre = SetNombre(value);
        }

        //A continuación vamos a crear una autopropiedad, por CONVENSIÓN en nombre de la propiedad se indica en MAYUSCULAS,
        //aquí se invocan los métodos GET y SET necesarios para que la variable sea accesible ó modificable PERO siguiendo las
        //convenciones de modificación definidas por el programador.
        public double SALARIO
        {
            get { return this.salario; }
            set { this.salario = SetSalario(value); }

        }

        /// <summary>
        /// Haciendo uso del operador ternario para asignar un valor de salario siempre y cuando este no sea negativo
        /// </summary>
        /// <param name="salario"></param>
        public double SetSalario(double salario)
        {
            return salario > 0 ? salario : 0;
        }

        /// <summary>
        /// Permite obtener el nombre especificado para ser luego modificado
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>cadena con el nombre específicado</returns>
        public string SetNombre(string nombre) => nombre;

       

    }
}
