using System;

class Desafio {
    static void Main() {
            string[] line = Console.ReadLine().Split(" ");
            int X = int.Parse(line[0]);
            int Y = int.Parse(line[1]);
            if (Y == 0) {
                Console.WriteLine("divisao impossivel");
            } 
            else {
                double divisao = (double)X/Y; // Digite aqui o calculo da divisao
                
                if(divisao < 0 && divisao > -0.5)
                {
                  Console.WriteLine("-0.0");
                }
                else
                {
                Console.WriteLine("{0:0.00}",divisao);
                }
    }
}
}