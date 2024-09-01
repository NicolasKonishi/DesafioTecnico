using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequencia
{
    internal class Sequencia
    {
        static bool IsFibonacci(int num)
        {
            if (num < 0)
                return false;

            int verificador1 = 0, verificador2 = 1;
            while (verificador1 < num)
            {
                int temp = verificador1;
                verificador1 = verificador2;
                verificador2 = temp + verificador2;
            }
            return verificador1 == num;
        }

        static void Main()
        {
            Console.Write("Informe um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (IsFibonacci(numero))
                Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci. :)");
            else
                Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci. :(");
        }
    }
}
