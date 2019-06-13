using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            realizarTarea();
        }

        static void realizarTarea()
        {
            Punto origen = new Punto();
            origen.printValues();

            Punto destino = new Punto(150, 90);
            destino.printValues();

            double distancia = origen.DistanciaHasta(destino);
            Console.WriteLine("La distancia entre los puntos es {0}",distancia);
        }
    }
}
