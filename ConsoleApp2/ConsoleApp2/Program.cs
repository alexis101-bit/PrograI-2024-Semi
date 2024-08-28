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
            double[,] tasasArea = {
                { 1.00, 0.222395, 0.111111, 0.092903, 0.000152, 0.0000358701, 0.0000092903 }, // Pie Cuadrado a otras unidades
                { 4.50, 1.00, 0.500004, 0.418061, 0.000684, 0.000161423, 0.0000418061 },      // Vara Cuadrada a otras unidades
                { 9.00, 2.00002, 1.00, 0.836127, 0.001368, 0.000322846, 0.0000836127 },      // Yarda Cuadrada a otras unidades
                { 10.7639, 2.392, 1.19599, 1.00, 0.001639, 0.000404686, 0.0001 },            // Metro Cuadrado a otras unidades
                { 6614.62, 1469.39, 734.695, 610.7, 1.00, 0.246, 0.06107 },                 // Tareas a otras unidades
                { 27878.4, 6192.77, 3096.39, 2589.99, 4.065, 1.00, 0.247105 },              // Manzana a otras unidades
                { 107639, 23920, 11959.9, 10000.0, 16.39, 4.04686, 1.00 }                  // Hectárea a otras unidades
            };

            string[] areas = { "Pie Cuadrado", "Vara Cuadrada", "Yarda Cuadrada", "Metro Cuadrado", "Tareas", "Manzana", "Hectárea" };

            Conversor(tasasArea, areas, "área");

           
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        static void Conversor(double[,] tasas, string[] unidades, string tipo)
        {
            Console.WriteLine($"Conversor de {tipo}");
            Console.WriteLine("Selecciona una opción:");
            for (int i = 0; i < unidades.Length; i++)
            {
                Console.WriteLine($"{i}: {unidades[i]}");
            }
            int origen = int.Parse(Console.ReadLine());

            Console.WriteLine("Selecciona la segunda opción:");
            for (int i = 0; i < unidades.Length; i++)
            {
                Console.WriteLine($"{i}: {unidades[i]}");
            }
            int destino = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce la cantidad a convertir:");
            double cantidad = double.Parse(Console.ReadLine());

            double resultado = cantidad * tasas[origen, destino];
            Console.WriteLine($"{cantidad} {unidades[origen]} = {resultado} {unidades[destino]}\n");
        }
    }
}
