using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones_bloque_finally
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader archivo = null;

            try
            {
                string linea;
                int cont = 0;

                string path = @"C:\Users\Federico\Desktop\texto.txt";
                archivo = new System.IO.StreamReader(path);
                while( (linea= archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                    cont++;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Error con la lectura del archivo");

            }
            finally
            {
                if(archivo != null)
                {
                    archivo.Close();
                    Console.WriteLine("Conexcion con fichero cerrada");
                }
            }
        }
    }
}
