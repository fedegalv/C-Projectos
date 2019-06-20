using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_Destileria
{
    class Program
    {
        static void Main(string[] args)
        {

            Operacion[] listaOperaciones = new Operacion[5];
            Remito[] listaRemitos = new Remito[5];

            // DECLARACION Y ASIGNACION
            int[] codigoOperacion = { 1, 2, 3, 4, 5 };
            DateTime[] fechas = new DateTime[]
            {
                     new DateTime(2010, 10, 1, 12, 25, 00),
                     new DateTime(2010, 10, 5, 14, 21, 00),
                     new DateTime(2010, 10, 8, 09, 40, 00),
                     new DateTime(2010, 12, 22, 08, 44, 00),
                     new DateTime(2010, 12, 11, 04, 08, 00),
            };
            int[] litrosDescargados = { 200, 125, 350, 800, 480 };
            char[] metodo = { 'C', 'C', 'O', 'C', 'C' };
            int[] numeroRemito = { 125, 126, 127, 128, 130 };

            // ASIGNACION ARRAY OBJETOS
            for (int i = 0; i < listaOperaciones.Length; i++)
            {
                Operacion operacion = new Operacion();
                operacion.setCodigoOperacion(codigoOperacion[i]);
                operacion.setFechaHoraDescarga(fechas[i]);
                operacion.setLitrosDescargados(litrosDescargados[i]);
                operacion.setMetodo(metodo[i]);
                operacion.setNumeroRemito(numeroRemito[i]);
                listaOperaciones[i] = operacion;

            }

            // DECLARACION Y ASIGNACION
            int[] litrosA15C = {10, 25, 39, 70, 65};
            string[] nombreChofer = {"Jorge", "Manuel", "Pedro", "Maria", "Luis"};
            string[] apellidoChofer = {"Lopez", "Monroe", "Lazier", "Tulme", "Prieto"};
            DateTime[] fechasSalida = new DateTime[]
             {
                     new DateTime(2010, 10, 9, 14, 22, 00),
                     new DateTime(2010, 10, 15, 13, 18, 00),
                     new DateTime(2010, 10, 19, 12, 14, 00),
                     new DateTime(2010, 12, 24, 18, 13, 00),
                     new DateTime(2010, 12, 29, 16, 25, 00),
             };

            // ASIGNACION ARRAY OBJETOS
            for (int i = 0; i < listaRemitos.Length; i++)
            {
                Remito remito = new Remito();
                remito.setNumeroRemito(numeroRemito[i]);
                remito.setLitroA15C(litrosA15C[i]);
                remito.setNombreChofer(nombreChofer[i]);
                remito.setApellidoChofer(apellidoChofer[i]);
                remito.setFechaHoraSalida(fechasSalida[i]);
                listaRemitos[i] = remito;
            }
            // CREA LISTA AUXILIAR Y COPIA OBJETOS A LISTA
            Operacion[] listaOrdenadaOperacion = new Operacion[5];
            listaOrdenadaOperacion = listaOperaciones;

            // ORDENA
            for (int i = 0; i < listaOrdenadaOperacion.Length; i++)
            {
                for (int j = 1; j < listaOrdenadaOperacion.Length; j++)
                {
                    if (DateTime.Compare(listaOrdenadaOperacion[i].getFechaHoraDescarga, listaOrdenadaOperacion[j].getFechaHoraDescarga) < 0)
                    {
                        Operacion auxOperacion = new Operacion();
                        auxOperacion = listaOrdenadaOperacion[i];
                        listaOrdenadaOperacion[i] = listaOrdenadaOperacion[j];
                        listaOrdenadaOperacion[j] = auxOperacion;

                    }
                }
            }

            for (int i = 0; i < listaOrdenadaOperacion.Length; i++)
            {
                for (int j = 0; j < listaRemitos.Length; j++)
                {
                    if (listaOrdenadaOperacion[i].getNumeroRemito == listaRemitos[j].getNumeroRemito)
                    {
                        Console.WriteLine("Nro Remito: {0} Fecha/Hora descarga: {1} Litros Descargados: {2} Litros a 15C: {3} Apellido Chofer: {4}", listaOrdenadaOperacion[i].getNumeroRemito, listaOrdenadaOperacion[i].getFechaHoraDescarga,
                            listaOrdenadaOperacion[i].getLitrosDescargados, listaRemitos[j].getLitrosA15C, listaRemitos[j].getApellidoChofer);
                    }
                }
            }


        }
        class Operacion
        {
            // CAMPOS
            private int codigoOperacion;
            private DateTime fechaHoraDescarga;
            private int litrosDescargados;
            private char metodo;
            private int numeroRemito;

            // CONSTRUCTOR
            public Operacion()
            {

            }
            public Operacion(int codigoOperacion, DateTime fechaHoraDescarga, int litrosDescargados, char metodo, int numeroRemito)
            {
                this.codigoOperacion = codigoOperacion;
                this.fechaHoraDescarga = fechaHoraDescarga;
                this.litrosDescargados = litrosDescargados;
                this.metodo = metodo;
                this.numeroRemito = numeroRemito;
            }

            // GETTERS
            public int getCodigoOperacion => codigoOperacion;
            public DateTime getFechaHoraDescarga => fechaHoraDescarga;
            public int getLitrosDescargados => litrosDescargados;
            public char getMetodo => metodo;
            public int getNumeroRemito => numeroRemito;
            // SETTER
            public int setCodigoOperacion(int operacion) => this.codigoOperacion = operacion;
            public DateTime setFechaHoraDescarga(DateTime fecha) => this.fechaHoraDescarga = fecha;
            public int setLitrosDescargados(int litros) => this.litrosDescargados = litros;
            public char setMetodo(char metodo) => this.metodo = metodo;
            public int setNumeroRemito(int remito) => this.numeroRemito = remito;

        }
        class Remito
        {
            // CAMPOS
            private int numeroRemito = -1;
            private int litrosA15C;
            private string nombreChofer;
            private string apellidoChofer;
            private DateTime fechaHoraSalida;

            // CONSTRUCTOR
            public Remito()
            {

            }
            public Remito(int numeroRemito, int litrosA15C, string nombreChofer, string apellidoChofer, DateTime fechaHoraSalida)
            {
                this.numeroRemito = numeroRemito;
                this.litrosA15C = litrosA15C;
                this.nombreChofer = nombreChofer;
                this.apellidoChofer = apellidoChofer;
                this.fechaHoraSalida = fechaHoraSalida;
            }

            // GETTER
            public DateTime GetFechaHoraSalida => fechaHoraSalida;
            public int getNumeroRemito => numeroRemito;
            public int getLitrosA15C => litrosA15C;
            public string getNombreChofer => nombreChofer;
            public string getApellidoChofer => apellidoChofer;

            // SETTER
            public int setNumeroRemito(int remito) => this.numeroRemito = remito;
            public DateTime setFechaHoraSalida(DateTime fecha) => this.fechaHoraSalida = fecha;
            public int setLitroA15C(int litro15C) => this.litrosA15C = litro15C;
            public string setNombreChofer(string nombre) => this.nombreChofer = nombre;
            public string setApellidoChofer(string apellido) => this.apellidoChofer = apellido;

        }

        
    }
}
/*
 * 
 * public void CargaOperacion(Operacion[] arrayOperacion)
            {
                int[] codigoOperacion = { 1, 2, 3, 4, 5 };
                DateTime[] fechas = new DateTime[]
                {
                     new DateTime(2010, 10, 1, 12, 25, 00),
                     new DateTime(2010, 10, 5, 14, 21, 00),
                     new DateTime(2010, 10, 8, 09, 40, 00),
                     new DateTime(2010, 12, 22, 08, 44, 00),
                     new DateTime(2010, 12, 11, 04, 08, 00),
                };
                int[] litrosDescargados = { 200, 125, 350, 800, 480 };
                char[] metodo = { 'C', 'C', 'O', 'C', 'C' };
                int[] numeroRemito = { 125, 126, 127, 128, 130 };
                //ASIGNACION
                for (int i = 0; i < arrayOperacion.Length; i++)
                {
                    arrayOperacion[i].setCodigoOperacion(codigoOperacion[i]);
                    arrayOperacion[i].setFechaHoraDescarga(fechas[i]);
                    arrayOperacion[i].setLitrosDescargados(litrosDescargados[i]);
                    arrayOperacion[i].setMetodo(metodo[i]);
                    arrayOperacion[i].setNumeroRemito(numeroRemito[i]);
                }
            }
 * */


