using System;

namespace Practicas_metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            int cont = 1;
            num1 = pedirNumero(cont);
            cont++;
            num2 = pedirNumero(cont);
            sumaNumero(num1, num2);
            
        }
        static int pedirNumero(int cont)
        {
            Console.WriteLine("Ingrese numero {0}: ", cont);
            int numero = int.Parse(Console.ReadLine());
            return numero;
        }
        static void sumaNumero(int num1, int num2)
        {
            Console.WriteLine("La suma de los numeros es: {0}", num1+num2);
        }
    }
}
