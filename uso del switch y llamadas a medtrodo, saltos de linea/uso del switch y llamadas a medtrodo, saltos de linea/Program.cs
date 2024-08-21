using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uso_del_switch_y_llamadas_a_medtrodo__saltos_de_linea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //determinar si cada numero de la serie es primo.

            int[] serie = new int[] { 5, 9, 4, 6, 3, 2, 7, 11, 15, 17, 21};
            foreach (int num in serie)
            {
                int i = 2;
                n = 0;
                while (i<=num && n<=2)
                {
                    if (num % i == 0)
                    {
                        n++; //n=n+1
                    }
                }
                i++; //i=i+1

            }
            Console.ReadLine("El numero {0} {1}", num, n <= 2 ? "Es primo" : "No es primo");
        }
        Console.ReadLine();
        }
    }
}
