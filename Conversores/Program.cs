using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Conversores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String continuar = "s";
            while (continuar == "s")
            {
                Console.WriteLine("\n \n *** MENU ***");
                Console.WriteLine("1. Conversor de monedas");
                Console.WriteLine("2. Conversor de masas");
                Console.WriteLine("3. Conversor de Volumen");
                Console.WriteLine("4. Conversor de Almacenamiento");
                Console.WriteLine("5. Conversor de Tiempo");
                Console.WriteLine("6. Salir");
                Console.WriteLine("Opcion : ");
                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        monedas();
                        break;
                    case 2:
                        masas();
                        break;
                    case 3:
                        volumen();
                        break;
                    case 4:
                        almacenamiento();
                        break;
                    case 5:
                        tiempo();
                        break;
                    case 6:
                        continuar = "n";
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta \n\n");
                        break;
                }
            }
        }
        static void monedas()
        {
            // Definimos la matriz de tasas de conversión (10x10)
            double[,] tasas = {
            {1, 0.85, 0.76, 0.74, 1.34, 0.75, 7.13, 83.77, 5.47, 19},  // USD
            {1.18, 1, 0.89, 0.87, 1.58, 0.88, 1.62, 1.10, 0.81, 1.70},  // EUR
            {1.32, 1.12, 1, 0.97, 1.77, 0.99, 1.82, 1.24, 0.91, 1.91},  // GBP
            {1.35, 1.15, 1.03, 1, 1.83, 1.03, 1.86, 1.28, 0.93, 1.96},  // CAD (dolar canadiense)
            {0.75, 0.63, 0.56, 0.55, 1, 0.56, 1.02, 0.70, 0.50, 1.07},  // AUD (dolar australiano)  
            {1.33, 1.14, 1.01, 0.97, 1.79, 1, 1.80, 1.27, 0.93, 1.92},  // JPY
            {0.73, 0.62, 0.55, 0.54, 0.98, 0.56, 1, 0.70, 0.51, 1.06},  // CNY
            {1.07, 0.91, 0.81, 0.78, 1.43, 0.79, 1.42, 1, 0.73, 1.51},  // INR
            {1.45, 1.23, 1.10, 1.08, 2.00, 1.08, 1.96, 1.37, 1, 1.80},  // BRL
            {0.69, 0.59, 0.52, 0.51, 0.93, 0.52, 0.94, 0.66, 0.56, 1}   // MXN
            };

            // Nombres de las monedas
            string[] monedas = { "USD", "EUR", "GBP", "CAD", "AUD", "JPY", "CNY", "INR", "BRL", "MXN" };

            Console.WriteLine("Convertidor de monedas ");
            Console.WriteLine("Seleccione la divisa de origen (0-9):");
            for (int i = 0; i < monedas.Length; i++)
            {
                Console.WriteLine($"{i}. {monedas[i]}");
            }
            int origen = int.Parse(Console.ReadLine());

            Console.WriteLine("Seleccione la divisa de destino (0-9):");
            for (int i = 0; i < monedas.Length; i++)
            {
                Console.WriteLine($"{i}. {monedas[i]}");
            }
            int destino = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el monto a convertir:");
            double monto = double.Parse(Console.ReadLine());

            double resultado = monto * tasas[origen, destino];
            Console.WriteLine($"El monto convertido es: {resultado} {monedas[destino]}");

            Console.ReadLine();
        }

        static void masas()
        {
            //definimos las tasas de conversion
            double[,] medidas = {
                {1, 0.45, 4.54, 45.36, 453.59, 2267.69,45359.24, 4535982.37, 453592370, 0.0005 },//LIBRA 
                {2.2, 1, 10, 100, 1000, 5000, 100000, 1000000, 1000000000, 0.001 },//KILOGRAMO
                {0.22, 0.1, 1, 10, 100, 500, 10000, 100000,100000000, 0.0001  },//HECTOGRAMO 
                {0.022, 0.01, 0.1, 1 , 10, 50, 1000, 10000, 1000000000, 0.00001 },//DECAGRAMO 
                {0.0022, 0.001, 0.01, 0.1, 1, 5, 100, 1000, 1000000, 0.000001 },//GRAMO 
                {0.000441, 0.0002, 0.002, 0.02, 0.2, 1, 20, 200, 200000, 0.0000001 },//QUILATE 
                {0.000022, 0.00001, 0.0001, 0.001, 0.001, 0.05, 1, 10, 10000, 0.00000001 },//CENTIGRAMO 
                {0.000002, 0.000001, 0.00001, 0.0001, 0.001, 0.005, 0.1, 1, 1000, 0.000000001},//MILIGRAMO 
                {0.0000000022, 0.000000001, 0.00000001, 0.0000001, 0.000001, 0.000005,0.0001, 0.001, 1, 0.000000000001 },//MICROGRAMO 
                {2204.6226218, 1000, 10000, 100000, 1000000 , 5000000, 100000000, 1000000000, 1000000000000, 1 },//TONELADA
            };
            // nombre de las medidas de masa
            string[] masas = { "Libra", "kilogramo", "Hectogramo", "Decagramo","Gramo", "Quilate", "Centigramo", "Miligramo", "Microgramo", "Tonelada"};

            Console.WriteLine("Convertidor de masa:");
            Console.WriteLine("Seleccione la medida de origen (0-9):");
            for (int i = 0; i < masas.Length; i++)
            {
                Console.WriteLine($"{i}. {masas[i]}");
            }
            int origen = int.Parse(Console.ReadLine());

            Console.WriteLine("Seleccione la medida de destino (0-9):");
            for (int i = 0; i < masas.Length; i++)
            {
                Console.WriteLine($"{i}.{masas[i]}");
            }
            int destino = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el peso a convertir: ");
            double peso = double.Parse(Console.ReadLine());

            double resultado = peso * medidas[origen, destino];
            Console.WriteLine($"El peso convertido es :{resultado} {masas[destino]}");

            Console.ReadLine();
        }
    }
}
