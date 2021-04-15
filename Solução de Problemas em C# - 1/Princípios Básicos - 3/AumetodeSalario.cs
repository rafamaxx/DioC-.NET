using System; 
using System.Globalization;

class minhaClasse {

    static void Main(string[] args) { 

            double salario, reajuste, novoSalario;
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                       //insira os valores corretos de acordo com o enunciado
                       
            if(salario >= 0.00 && salario <= 400.00)
            {
                reajuste = salario * 0.15; 
                novoSalario = salario + reajuste;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: 15 %");
            }
            else if (salario > 400.00 && salario <= 800.00)
            {
                reajuste = salario * 0.12;
                novoSalario = salario + reajuste;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: 12 %");
            }
            else if (salario > 800.00 && salario <= 1200.00)
            {
                reajuste = salario * 0.10;
                novoSalario = salario + reajuste;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: 10 %");
            }
            else if (salario > 1200.00 && salario <= 2000.00)
            {
                reajuste = salario * 0.07;
                novoSalario = salario + reajuste;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: 7 %");
            }
            else if (salario > 2000.00)
            {
                reajuste = salario * 0.04;
                novoSalario = salario + reajuste;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: 4 %");
            }
            else
            {
                Console.WriteLine("Novo salario: 0.00");
                Console.WriteLine("Reajuste ganho: 0.00");
                Console.WriteLine("Em percentual: 0.00");
            }
        }
    }