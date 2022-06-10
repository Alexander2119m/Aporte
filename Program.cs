using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Aporte
{
    class Program
    {
        public static void Main(String[] args)
        {

            FiguraCuadrado figura1 = new FiguraCuadrado("Es un cuadrado ", " Blanco ", 255);
            

            FiguraRectangulo figura5 = new FiguraRectangulo("Es un Rectangulo ", " Amarillo ", 10,20);
            

            FiguraCirculo figura6 = new FiguraCirculo("Es un circulo  ", " Azul  ", 7895);
            

            List < FiguraPADRE > Listadelasfiguras = new List< FiguraPADRE>();
            Listadelasfiguras.Add(figura1);
            Listadelasfiguras.Add(figura5);
            Listadelasfiguras.Add(figura6);
            
            foreach (Interfaz item in Listadelasfiguras)
            {
                item.calculararea();


            }
        }
    }
}
