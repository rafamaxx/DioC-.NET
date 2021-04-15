using System; 

class minhaClasse{

    static void Main(string[] args) { 

            int a, b, x;
            string[] entrada = Console.ReadLine().Split();
            a = Convert.ToInt32(entrada[0]);
            b = Convert.ToInt32(entrada[1]);

            x = a+b; //complete o código de acordo com o cálculo esperado

            Console.WriteLine("X = {0}", x);

    }

}