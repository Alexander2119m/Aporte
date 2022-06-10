using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aporte
{
    class FiguraRectangulo:FiguraPADRE,Interfaz
    {
        public int basedelafigura {set ; get; }
        public int alturadelafigura { set; get; }

        public FiguraRectangulo(string Identificacion, string tono, int alturadelafigura, int  basedelafigura) : base (Identificacion,tono)
        {
            this.alturadelafigura = alturadelafigura;
            this.basedelafigura = basedelafigura;
            
        }

        public void calculararea()
        {
            int areatotal;
            Console.WriteLine("Nombre : " + Identificacion);
            Console.WriteLine("Color : " + tono);
            Console.WriteLine("Base : " + basedelafigura);
            Console.WriteLine("Altura : " + alturadelafigura);
            areatotal = basedelafigura * alturadelafigura;
            Console.WriteLine("El area total de la figura es : " + areatotal);
        }

        


    }
}
