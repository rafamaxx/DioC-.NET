using System;

namespace TeoremaEuclidiano
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split();
            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);
            int q, r;

           q = (int)a/b;
           r = a%b;
           
           if(r<0)
           {    
               r = r + Math.Abs(b);
               //a = b*q+r;
               q=(a-r)/b;
           }

            Console.WriteLine("{0} {1}", q, r);
        }
    }
}
