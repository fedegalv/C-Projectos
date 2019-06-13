using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosOOP
{
    class Punto
    {
        private int x, y;
        public Punto(int x, int y)
        {
            //Console.WriteLine($"Coordenada x: {x}, Coordenada y: {y}");
            this.x = x;
            this.y = y;
        }
        public Punto()
        {
            //Console.WriteLine("Este es constructor por defecto");
            this.x = 0;
            this.y = 0;
        }
        public void printValues()
        {
            Console.WriteLine("x:{0}, y:{1}",x,y);
        }
        public double DistanciaHasta(Punto otroPunto)
        {
            int xDif = this.x - otroPunto.x;
            int yDif = this.y - otroPunto.y;
            double distanciaPuntos = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));
            return distanciaPuntos;
        }
    }
}
