using System; 
using System.Globalization;

class minhaClasse {

    static void Main(string[] args) { 

       int t = Convert.ToInt32(Console.ReadLine());
            int pa, pb;
            double cpa, cpb;
            int anos;

            for (int i = 0; i < t; i++)
            {
                anos = 0;
                string[] valores = Console.ReadLine().Split();
                pa = int.Parse(valores[0]);
                pb = int.Parse(valores[1]);

               //declare as variaveis corretamente
                cpa = double.Parse(valores[2],CultureInfo.InvariantCulture);
                cpb = double.Parse(valores[3],CultureInfo.InvariantCulture);

                while (pa <= pb)
                {
                    pa += Convert.ToInt32(Math.Floor(pa*(cpa/100)));
                    pb += Convert.ToInt32(Math.Floor(pb*(cpb/100)));
                    anos++;
                   //complete o while

                    if (anos > 100)
                    {
                       Console.WriteLine("Mais de 1 seculo.");
                       break;
                    }
                    
                }

                if (anos <= 100)
                {
                   Console.WriteLine("{0} anos.",anos);
                }

            }

    }

}