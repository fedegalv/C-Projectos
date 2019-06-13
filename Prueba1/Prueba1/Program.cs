using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un numero: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce un numero2: ");
            int numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce un nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine($"La suma es {numero1+numero2} y el nombre es {nombre}");


        }
    }
}
