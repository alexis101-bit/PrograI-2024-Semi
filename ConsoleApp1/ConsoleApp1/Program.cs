using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Conversor de Monedas
            double[,] tasasMonedas = {
    { 1.00, 0.91, 18.64, 24.68, 0.91, 8.72, 6.88, 36.67, 937.21, 3999.64, 23.91 }, // Tasa de USD a otras monedas
    { 1.10, 1.00, 20.49, 27.13, 1.10, 9.59, 7.56, 40.32, 1023.63, 4390.76, 26.21 }, // Tasa de EUR a otras monedas
    { 0.053, 0.049, 1.00, 1.32, 0.053, 0.47, 0.37, 1.95, 55.08, 211.51, 1.28 }, // Tasa de MXN a otras monedas
    { 0.040, 0.037, 0.76, 1.00, 0.040, 0.35, 0.28, 1.49, 42.63, 159.21, 0.97 }, // Tasa de HNL a otras monedas
    { 0.069, 0.063, 1.51, 2.00, 0.069, 0.60, 0.48, 2.55, 70.69, 261.45, 1.61 }, // Tasa de SVC a otras monedas
    { 0.15, 0.14, 2.73, 3.70, 0.15, 1.29, 1.01, 5.46, 151.48, 569.71, 3.39 }, // Tasa de BOB a otras monedas
    { 0.027, 0.025, 0.54, 0.71, 0.027, 0.24, 0.19, 1.00, 27.54, 101.52, 0.61 }, // Tasa de NIO a otras monedas
    { 0.0011, 0.0010, 0.022, 0.030, 0.0011, 0.0096, 0.0076, 0.041, 1.00, 0.12, 0.025 }, // Tasa de ARS a otras monedas
    { 0.00025, 0.00023, 0.00050, 0.00067, 0.00025, 0.0025, 0.002, 0.010, 0.080, 1.00, 0.006 }, // Tasa de COP a otras monedas
    { 0.042, 0.038, 0.083, 0.11, 0.042, 0.37, 0.29, 1.58, 65.88, 266.16, 1.00 } // Tasa de CUP a otras monedas
};
            string[] monedas = { "Dólar estadounidense", "Euro", "Peso mexicano", "Lempira hondureño", "Colón salvadoreño", "Boliviano", "Córdoba nicaragüense", "Peso argentino", "Peso colombiano", "Peso cubano" };
            Conversor(tasasMonedas, monedas, "monedas");

            // Conversor de Masa (Gramos, Kilogramos, Onzas, etc.)
            double[,] tasasMasa = {
            { 1.00, 0.001, 0.000001, 0.000000001, 0.00000000003527396, 0.00003527396, 0.00000220462, 0.00003527396, 0.0000283495, 0.0000321507 }, // Tasa de g a otras unidades
            { 1000.00, 1.00, 0.001, 0.000001, 0.00003527396, 0.03527396, 0.00220462, 0.03527396, 0.0283495, 0.0321507 }, // Tasa de kg a otras unidades
            { 1000000.00, 1000.00, 1.00, 0.001, 35.27396, 35.27396, 2.20462, 35.27396, 28.3495, 32.1507 }, // Tasa de mg a otras unidades
            { 1000000000.00, 1000000.00, 1000.00, 1.00, 35273.96, 35273.96, 2204.62, 35273.96, 28349.5, 32150.7 }, // Tasa de µg a otras unidades
            { 28349.5, 28.3495, 0.03527396, 0.00003527396, 1.00, 1.00, 0.0625, 1.00, 0.0625, 0.072 }, // Tasa de oz a otras unidades
            { 32.1507, 0.0321507, 0.0000321507, 0.0000000321507, 0.000072, 0.000072, 0.00000416667, 0.000072, 0.0000055, 0.0000068 }, // Tasa de oz_troy a otras unidades
            { 0.00110231, 0.00110231, 0.00000110231, 0.00000000110231, 0.000038, 0.000038, 0.0000025, 0.000038, 0.000029, 0.000035 }, // Tasa de tonelada_corta a otras unidades
            { 0.000984207, 0.000984207, 0.000000984207, 0.000000000984207, 0.000033, 0.000033, 0.0000022, 0.000033, 0.000026, 0.000031 }, // Tasa de tonelada_larga a otras unidades
            { 0.0154324, 0.0154324, 0.0000154324, 0.0000000154324, 0.00054, 0.00054, 0.000036, 0.00054, 0.000042, 0.000048 }, // Tasa de grano a otras unidades
        };
            string[] masas = { "Gramo", "Kilogramo", "Miligramo", "Microgramo", "Onza", "Onza troy", "Tonelada corta", "Tonelada larga", "Grano" };
            Conversor(tasasMasa, masas, "masa");

            // Conversor de Volumen (Litros, Mililitros, Galones, etc.)
            double[,] tasasVolumen = {
            { 1.00, 1000.00, 0.264172, 4.22675, 33.814, 67.628, 202.884, 0.001, 0.0353147, 0.000578704 }, // Tasa de L a otras unidades
            { 0.001, 1.00, 0.000264172, 0.00422675, 0.033814, 0.067628, 0.202884, 0.000001, 0.0000353147, 0.000000578704 }, // Tasa de mL a otras unidades
            { 3.78541, 3785.41, 1.00, 15.999, 128.00, 256.00, 768.00, 0.00378541, 0.132, 0.002096 }, // Tasa de gal a otras unidades
            { 0.236588, 236.588, 0.059994, 1.00, 8.00, 16.00, 48.00, 0.000236588, 0.008, 0.000133 }, // Tasa de cup a otras unidades
            { 0.0295735, 29.5735, 0.0078125, 0.125, 1.00, 2.00, 6.00, 0.0000295735, 0.001, 0.000016 }, // Tasa de oz_fl a otras unidades
            { 0.0147868, 14.7868, 0.0032868, 0.0475, 0.25, 0.50, 1.50, 0.0000147868, 0.00000492892, 0.0000008 }, // Tasa de tbsp a otras unidades
            { 0.00492892, 4.92892, 0.001953125, 0.03125, 0.25, 0.50, 1.50, 0.00000492892, 0.0015736, 0.0145 }, // Tasa de tsp a otras unidades
            { 1000.00, 1000000.00, 264.172, 4226.75, 33814.00, 67628.00, 202884.00, 1.00, 220.00, 35200.00 }, // Tasa de m3 a otras unidades
            { 0.3048, 304.8, 0.0254, 0.42, 3.48, 6.96, 20.88, 0.001, 0.00022, 0.0058 }, // Tasa de ft3 a otras unidades
            { 0.0163871, 16.3871, 0.001043, 0.0166, 0.15, 0.32, 0.99, 0.0000163871, 0.0031, 0.0364 } // Tasa de in3 a otras unidades
        };
            string[] volumenes = { "Litro", "Mililitro", "Galón", "Taza", "Onza líquida", "Cucharada", "Cucharadita", "Metro cúbico", "Pie cúbico", "Pulgada cúbica" };
            Conversor(tasasVolumen, volumenes, "volumen");


            // Conversor de Longitud (Metros, Kilómetros, Millas, etc.)
            double[,] tasasLongitud = {
            { 1.00, 0.001, 0.000621371, 100.00, 1000.00, 0.000539957, 1.09361, 39.3701, 0.001, 100000.0 }, // Tasa de m a otras unidades
            { 1000.00, 1.00, 0.621371, 100000.00, 1000000.00, 0.539957, 1093.61, 39370.1, 100.00, 100000000.0 }, // Tasa de km a otras unidades
            { 1609.34, 1.60934, 1.00, 160934.00, 1609340.00, 0.869, 1760.00, 63360.00, 1609.34, 16093400.00 }, // Tasa de mi a otras unidades
            { 0.01, 0.00001, 0.00000621371, 1.00, 10.00, 0.00000539957, 0.0109361, 0.393701, 0.0001, 1000.0 }, // Tasa de cm a otras unidades
            { 0.001, 0.000001, 0.000000621371, 0.10, 1.00, 0.000000539957, 0.00109361, 0.0393701, 0.00001, 0.1 }, // Tasa de mm a otras unidades
            { 1852.00, 1.852, 1.00, 185200.00, 1852000.00, 0.999, 2000.00, 72600.00, 1852.00, 18520000.00 }, // Tasa de nmi a otras unidades
            { 0.9144, 0.0009144, 0.000568182, 91.44, 914.4, 0.000539957, 1.00, 36.00, 0.0009, 9144.0 }, // Tasa de yd a otras unidades
            { 0.0254, 0.0000254, 0.0000157828, 2.54, 25.4, 0.0000157828, 0.027778, 1.00, 0.0000254, 2.54 }, // Tasa de in a otras unidades
            { 0.1, 0.0001, 0.0000621371, 10.00, 100.00, 0.0000621371, 0.1, 3.93701, 0.0001, 1000.0 }, // Tasa de dm a otras unidades
            { 0.000001, 0.000000001, 0.000000000621371, 0.0001, 0.001, 0.000000000539957, 0.00000109361, 0.0000393701, 0.0000001, 0.001 } // Tasa de µm a otras unidades
        };
            string[] longitudes = { "Metro", "Kilómetro", "Milímetro", "Micrómetro", "Milla", "Pie", "Pulgada", "Centímetro", "Decímetro", "Yarda" };
            Conversor(tasasLongitud, longitudes, "longitud");

            // Conversor de Almacenamiento (Bytes, Kilobytes, Megabytes, etc.)
            double[,] tasasAlmacenamiento = {
            { 1.00, 0.001, 0.000001, 0.000000001, 0.000000000001, 0.000000000000001, 0.000000000000000001, 0.000000000000000000001, 0.000000000000000000000001, 0.000000000000000000000000001 }, // Tasa de B a otras unidades
            { 1000.00, 1.00, 0.001, 0.000001, 0.000000001, 0.000000000001, 0.000000000000001, 0.000000000000000001, 0.000000000000000000001, 0.000000000000000000000001 }, // Tasa de KB a otras unidades
            { 1000000.00, 1000.00, 1.00, 0.001, 0.000001, 0.000000001, 0.000000000001, 0.000000000000001, 0.000000000000000001, 0.000000000000000000001 }, // Tasa de MB a otras unidades
            { 1000000000.00, 1000000.00, 1000.00, 1.00, 0.001, 0.000001, 0.000000001, 0.000000000001, 0.000000000000001, 0.000000000000000001 }, // Tasa de GB a otras unidades
            { 1000000000000.00, 1000000000.00, 1000000.00, 1000.00, 1.00, 0.001, 0.000001, 0.000000001, 0.000000000001, 0.000000000000001 }, // Tasa de TB a otras unidades
            { 1048576.00, 1024.00, 1.00, 0.000976563, 0.000000953674, 0.000000000931323, 0.000000000000910, 0.000000000000000000007, 0.000000000000000000000007, 0.000000000000000000000000007 }, // Tasa de KiB a otras unidades
            { 1073741824.00, 1048576.00, 1024.00, 1.00, 0.000976563, 0.000000953674, 0.000000000931323, 0.000000000000910, 0.000000000000000000007, 0.000000000000000000000000007 }, // Tasa de MiB a otras unidades
            { 1099511627776.00, 1073741824.00, 1048576.00, 1024.00, 1.00, 0.000976563, 0.000000953674, 0.000000000931323, 0.000000000000910, 0.000000000000000000007 }, // Tasa de GiB a otras unidades
            { 1152921504606846976.00, 1099511627776.00, 1073741824.00, 1048576.00, 1024.00, 1.00, 0.000976563, 0.000000953674, 0.000000000931323, 0.000000000000000000007 }, // Tasa de TiB a otras unidades
            { 1152921504606846976.00, 1152921504606846976.00, 1152921504606846976.00, 1152921504606846976.00, 1152921504606846976.00, 1152921504606846976.00, 1152921504606846976.00, 1152921504606846976.00, 1152921504606846976.00, 1152921504606846976.00 }, // Tasa de PiB a otras unidades
        };
            string[] almacenamiento = { "Byte", "Kilobyte", "Megabyte", "Gigabyte", "Terabyte", "Petabyte", "Exabyte", "Zettabyte" };
            Conversor(tasasAlmacenamiento, almacenamiento, "almacenamiento");

            // Conversor de Tiempo (Segundos, Minutos, Horas, etc.)
            double[,] tasasTiempo = {
            { 1.00, 0.0166667, 0.000277778, 0.000011574, 0.00000011574, 0.0000000011574, 0.0000000000196078, 0.0000000000015748, 0.000000000000026028, 0.000000000000000264 }, // Tasa de s a otras unidades
            { 60.00, 1.00, 0.0166667, 0.000694444, 0.00000694444, 0.000000069444, 0.000000000333333, 0.0000000000208333, 0.000000000000347222, 0.0000000000000000000316 }, // Tasa de min a otras unidades
            { 3600.00, 60.00, 1.00, 0.0416667, 0.000416667, 0.00000416667, 0.00000006, 0.0000000027778, 0.000000000028, 0.000000000000025 }, // Tasa de h a otras unidades
            { 86400.00, 1440.00, 24.00, 1.00, 0.01, 0.0001, 0.00000138889, 0.0000000416667, 0.000000000694, 0.0000000000000171 }, // Tasa de d a otras unidades
            { 604800.00, 10080.00, 168.00, 7.00, 1.00, 0.01, 0.00001, 0.00000083333, 0.00000001443, 0.0000000002 }, // Tasa de wk a otras unidades
            { 2629800.00, 43800.00, 730.00, 30.00, 4.33, 1.00, 0.0002, 0.000004, 0.00000007, 0.00000000001 }, // Tasa de mo a otras unidades
            { 31536000.00, 525600.00, 8760.00, 365.00, 52.14, 12.0, 1.00, 0.0416667, 0.00000137, 0.00000000432 }, // Tasa de y a otras unidades
            { 31557600000.00, 525600000.00, 8760000.00, 36500.00, 5250.00, 87600.00, 365.00, 1.00, 0.0104, 0.00000000293 }, // Tasa de c a otras unidades
            { 31536000000000.00, 525600000000.00, 8760000000.00, 365000000.00, 52500000.00, 876000000.00, 365000.00, 100.00, 1.00, 0.00000000000002 }, // Tasa de e a otras unidades
            { 3153600000000000.00, 52560000000000.00, 876000000000.00, 36500000000.00, 5250000000.00, 87600000000.00, 365000000.00, 10000.00, 1000.00, 1.00 } // Tasa de a a otras unidades
        };
           string[] tiempos = { "Segundo", "Minuto", "Hora", "Día", "Semana", "Mes", "Año", "Década" };
Conversor(tasasTiempo, tiempos, "tiempo");
        }

        static void Conversor(double[,] tasas, string[] unidades, string tipo)
        {
            Console.WriteLine($"Conversor de {tipo}");
            Console.WriteLine("Selecciona una opcion:");
            for (int i = 0; i < unidades.Length; i++)
            {
                Console.WriteLine($"{i}: {unidades[i]}");
            }
            int origen = int.Parse(Console.ReadLine());

            Console.WriteLine("Selecciona la segunda opcion:");
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
