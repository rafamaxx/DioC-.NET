using System;
using System.Globalization;

class minhaClasse {

    static void Main(string[] args) { 

            double nota;
            int qtdIgual = 0;
            double soma = 0;
            double opt;
            int exec = 0;

            while(exec==0){
                 while (qtdIgual != 2)
                {
                     nota = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);
                      if (nota>= 0 && nota <=10)   //complete a condicional
                     {
                       soma+= nota;
                       qtdIgual++;
                      }
                      else
                    {
                      Console.WriteLine("nota invalida");
                    }
                
               }
               Console.WriteLine("media = {0:0.00}", (soma/2)); //insira a variavel correta
               do{
               Console.WriteLine("novo calculo (1-sim 2-nao)");
               nota = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);
               }while(nota<1 || nota>2);
              if(nota == 1){
                qtdIgual = 0;
                soma = 0;
              }
              else
                exec =1;
            }
    }

}