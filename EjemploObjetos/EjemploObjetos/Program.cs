using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversorEuroDolar obj = new ConversorEuroDolar();
            Console.WriteLine(obj.convierte(50));

            obj.cambiaValorEuro(2.20);
            Console.WriteLine(obj.convierte(50));

        }
    }

    class Circulo
    {
        private const double pi = 3.1416;
        public double CalcularArea(int radio)
        {
            return pi * radio * radio;
        }
    }

    class ConversorEuroDolar
    {
        double euro = 1.253;
        public double convierte(double cantidad)
        {
            return cantidad * euro;
        }
        public void cambiaValorEuro(double nuevoValor)
        {
            if(nuevoValor> 0)
            {
                euro = nuevoValor;
            }
            else
            {
                Console.WriteLine("No se puede ingresar un valor negativo");
            }
            
        }

    }
}
