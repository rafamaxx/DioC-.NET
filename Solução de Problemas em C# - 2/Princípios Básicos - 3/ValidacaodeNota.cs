using System;
using System.Globalization;

class minhaClasse {

    static void Main(string[] args) { 

            double nota = 0.0;
            int qtdIgual = 0;
            double soma = 0;
            while (qtdIgual != 2)
            {
                nota = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (nota>=0 && nota <=10)   //complete a condicional
                {
                    soma += nota;
                    qtdIgual++;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }
                
            }
            Console.WriteLine("media = {0:0.00}", (soma /2)); //insira a variavel correta

    }

}