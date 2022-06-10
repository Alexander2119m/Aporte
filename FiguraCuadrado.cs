using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aporte
{
    class FiguraCuadrado : FiguraPADRE,Interfaz
    {
        public int costado { get; set; }



        public FiguraCuadrado(string Identificacion, string tono, int costado):base (Identificacion, tono)
        {
            this.costado = costado;

        }




        public void calculararea()
        {

            int lados;
            Console.WriteLine("Nombre : " + Identificacion);
            Console.WriteLine("Color : " + tono);
            Console.WriteLine("lados : " + costado);
            lados = costado * 4;
            Console.WriteLine("El area toral de la figura del cuadrado es :  " + lados);
        }
    }
}