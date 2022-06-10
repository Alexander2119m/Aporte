using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aporte
{
    class FiguraPADRE
    {
        public string Identificacion { set; get; }
        public string tono { set; get; }



        public FiguraPADRE (string Identificacion , string tono )
        {
            this.Identificacion = Identificacion;
            this.tono = tono ;
        }

        

        public  void Imprimir () 
        {
            Console.WriteLine("///////////");
            Console.WriteLine(" ID:  " + Identificacion);
            Console.WriteLine(" Tonalidad "  +tono);

        }



    }
}
