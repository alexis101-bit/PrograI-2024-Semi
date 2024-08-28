using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    namespace ImpuestoActividadesEconomicas
    {
        class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine("Introduce el monto de la actividad económica:");
                double monto = double.Parse(Console.ReadLine());

                double impuesto = CalcularImpuesto(monto);
                Console.WriteLine($"El impuesto a pagar es: {impuesto:C2}"); 

                
                Console.WriteLine("Presiona cualquier tecla para salir...");
                Console.ReadKey();
            }

            static double CalcularImpuesto(double monto)
            {
                double impuesto = 0;

                if (monto >= 0.01 && monto <= 500)
                {
                    impuesto = monto * 1.5 / 100;
                }
                else if (monto >= 500.01 && monto <= 1000)
                {
                    impuesto = ((monto - 500) * 1.5 / 100) + 3;
                }
                else if (monto >= 1000.01 && monto <= 2000)
                {
                    impuesto = ((monto - 1000) * 3 / 100) + 3;
                }
                else if (monto >= 2000.01 && monto <= 3000)
                {
                    impuesto = ((monto - 2000) * 6 / 100) + 3;
                }
                else if (monto >= 3000.01 && monto <= 6000)
                {
                    impuesto = ((monto - 3000) * 9 / 100) + 2;
                }
                else if (monto >= 8000.01 && monto <= 18000)
                {
                    impuesto = ((monto - 8000) * 15 / 100) + 2;
                }
                else if (monto >= 18000.01 && monto <= 30000)
                {
                    impuesto = ((monto - 18000) * 39 / 100) + 2;
                }
                else if (monto >= 30000.01 && monto <= 60000)
                {
                    impuesto = ((monto - 30000) * 63 / 100) + 1;
                }
                else if (monto >= 60000.01 && monto <= 100000)
                {
                    impuesto = ((monto - 60000) * 93 / 100) + 0.8;
                }
                else if (monto >= 100000.01 && monto <= 200000)
                {
                    impuesto = ((monto - 100000) * 125 / 100) + 0.7;
                }
                else if (monto >= 200000.01 && monto <= 300000)
                {
                    impuesto = ((monto - 200000) * 195 / 100) + 0.6;
                }
                else if (monto >= 300000.01 && monto <= 400000)
                {
                    impuesto = ((monto - 300000) * 255 / 100) + 0.45;
                }
                else if (monto >= 400000.01 && monto <= 500000)
                {
                    impuesto = ((monto - 400000) * 300 / 100) + 0.4;
                }
                else if (monto >= 500000.01 && monto <= 1000000)
                {
                    impuesto = ((monto - 500000) * 340 / 100) + 0.3;
                }
                else if (monto >= 1000000.01 && monto <= 99999999)
                {
                    impuesto = ((monto - 1000000) * 490 / 100) + 0.18;
                }

                return Math.Round(impuesto, 2); // Redondear el impuesto a dos decimales

            }
        }
    }
}

