using System;
using System.Globalization;

namespace Notasemoedas
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal entrada = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
                Console.WriteLine("NOTAS:");
                Console.WriteLine("{0} nota(s) de R$ 100.00", (int)entrada / 100);
                entrada = (entrada % 100);
                Console.WriteLine("{0} nota(s) de R$ 50.00", (int)entrada / 50);
                entrada = (entrada % 50);
                Console.WriteLine("{0} nota(s) de R$ 20.00", (int)entrada / 20);
                entrada = (entrada % 20);
                Console.WriteLine("{0} nota(s) de R$ 10.00", (int)entrada / 10);
                entrada = (entrada % 10);
                Console.WriteLine("{0} nota(s) de R$ 5.00", (int)entrada / 5);
                entrada = (entrada % 5);
                Console.WriteLine("{0} nota(s) de R$ 2.00", (int)entrada / 2);
                entrada = (entrada % 2);
                entrada = entrada*100;
                Console.WriteLine("MOEDAS:");
                Console.WriteLine("{0} moeda(s) de R$ 1.00", (int)entrada / 100);
                entrada = (entrada % 100);
                Console.WriteLine("{0} moeda(s) de R$ 0.50", (int)entrada / 50);
                entrada = (entrada % 50);
                Console.WriteLine("{0} moeda(s) de R$ 0.25", (int)entrada / 25);
                entrada = (entrada % 25);
                Console.WriteLine("{0} moeda(s) de R$ 0.10", (int)entrada / 10);
                entrada = (entrada % 10);
                Console.WriteLine("{0} moeda(s) de R$ 0.05", (int)entrada / 5);
                entrada = (entrada % 5);
                Console.WriteLine("{0} moeda(s) de R$ 0.01", (int)entrada / 1);
                entrada = (entrada % 1);
            
        }
    }
}
