using System;
using System.Collections.Generic;
using System.Linq;

namespace ComprasSupermercado
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCasos = int.Parse(Console.ReadLine());
            List<string> listaCompra = new List<string>();
            
            for(int i = 0; i< numCasos; i++){
                 string[] entrada = Console.ReadLine().Split();   
                foreach(string a in entrada)
                    listaCompra.Add(a);
                listaCompra.Sort();
                string[] saida = listaCompra.Distinct().ToArray();
                for(int j = 0;j < saida.Length;j++)
                {
                    Console.Write(saida[j]+" ");
                }
                Console.Write("\n");
                listaCompra.Clear();
            }
        }
    }
}
