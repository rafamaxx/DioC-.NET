using System;

namespace TrataSenha
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            char[] tratamento;
            int tamanho;
            bool num = false;
            bool maiuscula = false;
            bool minuscula = false;
            bool erro = false;
            int i;
            entrada = Console.ReadLine();
            while(entrada != null)
            {
                tratamento = entrada.ToCharArray();
                tamanho = tratamento.Length;
                if(tamanho>=6 && tamanho<=32){
                    for(i = 0; i< tamanho;i++){
                            if(tratamento[i]>=48&&tratamento[i]<=57)
                                num = true;
                            else if(tratamento[i]>=65&&tratamento[i]<=90)  
                                maiuscula = true;
                            else if(tratamento[i]>=97&&tratamento[i]<=122)  
                                minuscula = true;                              
                            else
                               erro = true;
                        }
                        if ((num==maiuscula==minuscula==true) &&erro==false){
                                Console.WriteLine("Senha valida.");
                        }
                        else
                               Console.WriteLine("Senha invalida.");  
                }
                else
                Console.WriteLine("Senha invalida.");


                entrada = Console.ReadLine();
                num = false;
                maiuscula = false;
                minuscula = false;
                erro = false;
            }
        }
    }
}