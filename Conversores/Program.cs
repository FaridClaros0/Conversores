using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

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
        }

        static void masas()
        {

        
    }
}
