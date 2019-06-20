using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche(); // crea objeto/instacia de tipo Coche
            // Da estado inicial al objeto coche1
            Coche coche2 = new Coche();

            Coche cocheGrande = new Coche(2500.5, 1);

            Console.WriteLine(coche1.getCantRuedas());
            Console.WriteLine(coche2.infoCoche());
            Console.WriteLine(cocheGrande.infoCoche());

            cocheGrande.setExtras(true, "Rojo");
            Console.WriteLine(cocheGrande.getExtra());

        }
    }

    class Coche
    {
        // CONSTRUCTOR - DA ESTADO INICIAL, INICIALIZA EL OBJETO
        public Coche() // ESTADO INICIAL DE COCHE
        {
            cantRuedas = 4;
            largo = 2300.5;
            ancho = 0.800;
        }
        public Coche(double largoCoche, double anchoCoche)
        {
            cantRuedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;

        }
        private int cantRuedas;
        private double largo;
        private double ancho;

        private bool climatizador;
        private string tapiceria;
        public int getCantRuedas()
        {
            return cantRuedas;
        }
        public string getExtra()
        {
            return "Climatizador:" + climatizador + " Tapiceria:" + tapiceria;
        }
        public string infoCoche()
        {

            return "Informacion del coche:\nRuedas:" + cantRuedas + "Largo:" +largo +" Ancho:"+ancho;
        }
        public void setExtras(bool climatizador, string tapiceria)
        {
            this.climatizador = climatizador;
            this.tapiceria = tapiceria;
        }


    }
}
