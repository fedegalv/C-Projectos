using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba3
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                try
                {
                    int numero = int.MaxValue;
                    int resultado = numero + 20;
                    Console.WriteLine(resultado);

                }
                catch (OverflowException)
                {
                    Console.WriteLine("Numero muy alto!");
                }
                
            }
        }
    }
}
