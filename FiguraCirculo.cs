using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aporte
{
    class FiguraCirculo: FiguraPADRE, Interfaz
    {
        public double SimboloPi = 3.1416;
        public double Radiodelafigura { set; get; }

        public FiguraCirculo(string  Identificacion, string tono, double Radiodelafigura ): base ( Identificacion , tono)
        {
            this.Radiodelafigura = Radiodelafigura;
            

        }
        public  void calculararea()
        {
            double areadelcirculo;
            Console.WriteLine("Nombre : " + Identificacion);
            Console.WriteLine("Color : " + tono);
            Console.WriteLine("Radio : " + Radiodelafigura);
            areadelcirculo = SimboloPi * Math.Pow(Radiodelafigura, 2);
            Console.WriteLine("El area total de esta figura:  " + areadelcirculo);

        }






    }
}
