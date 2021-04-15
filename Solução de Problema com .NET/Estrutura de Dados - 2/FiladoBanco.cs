using System;

namespace FilaDoBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCasos = int.Parse(Console.ReadLine());
            int numClientes;
            string[] entrada;
            int max = 0;
            int maxindex = 0;
            int[] fila;
            int[] finalFila;
            int numeroTroca;

            for (int i = 0; i < numCasos; i++)
            {
                numClientes = int.Parse(Console.ReadLine());
                numeroTroca = 0;
                if (numClientes < 2)
                    Console.WriteLine("0");
                else
                {
                    entrada = Console.ReadLine().Split();
                    fila = new int[numClientes];
                    finalFila = new int[numClientes];
                    for (int j = 0; j < numClientes; j++)
                        fila[j] = int.Parse(entrada[j]);
                    for (int ctrl = 0; ctrl < numClientes; ctrl++)
                    {
                        for (int k = 0; k < numClientes; k++)
                        {
                            if (fila[k] > max)
                            {
                                max = fila[k];
                                maxindex = k;
                            }
                        }
                        finalFila[ctrl] = maxindex;
                        fila[maxindex] = 0;
                        max = 0;
                    }
                    for(int q = 0;q<numClientes;q++)
                    {
                        if(finalFila[q]!=q)
                            numeroTroca++;
                    }
                }
                Console.WriteLine(numClientes-numeroTroca);
            } 
        }
    }
}