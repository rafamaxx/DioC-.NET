using System;

class URI
{

    static void Main(string[] args)
    {

        string n = Console.ReadLine();
        char[] tratamento = n.ToCharArray();
        Array.Reverse(tratamento);
        string v = new string(tratamento);
        Console.WriteLine(v);

    }

}