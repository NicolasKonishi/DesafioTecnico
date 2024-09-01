using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaString
{
    internal class VerificaString
    {
        static int CountAInString(string palavra)
        {
            int count = 0;
            foreach (char c in palavra.ToLower())
            {
                if (c.Equals("a")){
                    count++;
                }
            }
            return count;
        }

        static void Main()
        {
            Console.Write("Informe uma palavra: ");
            string input = Console.ReadLine();

            int count = CountAInString(input);

            if (count > 0)
                Console.WriteLine($"A letra 'a' aparece {count} vezes na palavra.");
            else
                Console.WriteLine("A letra 'a' não aparece na palavra.");
        }
    }
}
