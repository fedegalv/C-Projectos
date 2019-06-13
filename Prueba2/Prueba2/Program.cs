using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /*
            const int VALOR = 5;
            string nombre = "mercado";
            Console.WriteLine(VALOR);
            Console.WriteLine($"El valor de la constante es: {VALOR+VALOR} ");
            Console.WriteLine("El valor de la constante es: {0} y el nombre es {1}", VALOR, nombre);
            */
            const double PI = 3.1416;

            Console.WriteLine("Ingrese  medida del radio: ");
            double radio = double.Parse( Console.ReadLine() );

            double area = Math.Pow(radio, 2) * PI;
            Console.WriteLine("El area del circulo es {0}", area);

            Console.WriteLine("Ingrese num1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese num2: ");
            int num2= int.Parse(Console.ReadLine());
            int resultado;
            Console.WriteLine("El resultado es: {0}", resultado);


        }
    }
}
