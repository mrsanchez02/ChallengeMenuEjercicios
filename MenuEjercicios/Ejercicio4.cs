using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuEjercicios
{
    internal class Ejercicio4
    {
        public void TablaDeMultiplicar()
        {
            for (int i = 2; i <= 6; i++)
            {
                int result;
                Console.WriteLine("La tabla del: " + i);

                for (int j = 1; j <= 12; j++)
                {
                    result = i * j;
                    Console.WriteLine(i + "x" + j + "=" + result);
                }

                Console.WriteLine();
            }
        }
    }
}
