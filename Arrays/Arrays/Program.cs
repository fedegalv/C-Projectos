using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // array implicito
            /*
            // var datos = new[] {"Juan", "Perez", "Argentina"};
            var valores = new[] { 15, 28, 35, 75.5, 30.30 };
            */
            // array de objetos
            Empleados[] arrayEmpleados = new Empleados[10];
            
            // Creacion objeto y asignacion misma linea
            arrayEmpleados[0] = new Empleados("Sara", 37);

            // Creacion objeto y asignacion a array
            Empleados ana = new Empleados("Ana", 24);
            arrayEmpleados[1] = ana;


            arrayEmpleados[2] = new Empleados("Monty", 13);
            arrayEmpleados[3] = new Empleados("Robert", 22);

            // array de tipos o clases anonimas
            /*
            var personas = new[]
            {
                new {Nombre="Juan", Edad= 19},
                new { Nombre = "Martin", Edad = 22 },
                new { Nombre = "Diana", Edad = 35 }
            };
            */

            for (int i = 0; i < arrayEmpleados.Length; i++)
            {

                //Console.WriteLine("Nombre: {0} Edad: {1}",arrayEmpleados[i].getNombre, arrayEmpleados[i].getEdad);
                try
                {
                    Console.WriteLine(arrayEmpleados[i].getInfo());
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Fuera de rango");
                }
                
            }
        }
    }
    class Empleados
    {
        // CAMPO DE CLASE
        private string nombre;
        private int edad;

        // CONSTRUCTOR
        public Empleados(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public string getInfo()
        {
            return "Nombre: "+ nombre + " Edad: "+edad;
        }
    }
}
