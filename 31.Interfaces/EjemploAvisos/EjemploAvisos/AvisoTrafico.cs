using System;
using System.Collections.Generic;
using System.Text;

namespace EjemploAvisos
{
    class AvisoTrafico : IAviso
    {
        private string remitente;
        private string mensaje;
        private string fecha;

       

        public AvisoTrafico()
        {
            this.remitente = "Dirección Nacional de Tráfico";
            this.mensaje = "Sanción cometida. Pague antes de tres días y recibirá una sanción de menos del 50%";
            this.fecha = "";
        }

        public AvisoTrafico(string remitente, string mensaje, string fecha)
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;
            
        }



        public string GetFeha() => this.fecha;

        /// <summary>
        /// Escribe el mensaje de nuestro Aviso, Nótese como se usa otra forma de concatenar muy bonita
        /// </summary>
        public void MostrarAviso() => Console.WriteLine("Mensaje {0} ha sido por {1} el dia {2}",this.mensaje,this.remitente,this.fecha);
    }
}
