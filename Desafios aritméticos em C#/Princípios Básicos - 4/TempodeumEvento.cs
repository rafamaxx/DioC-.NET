using System; 

class minhaClasse {

    static void Main(string[] args) { 

            const int day = 86400;
            const int hour = 3600;
            const int mim = 60;
            int diaInicio, diaTermino, horaMomentoInicio, minutoMomentoInicio, segundoMomentoInicio;
            int horaMomentoTermino, minutoMomentoTermino, segundoMomentoTerminio;
            //continue escrevendo a solucao

            string[] dadosInicio = Console.ReadLine().Split();
            diaInicio = Convert.ToInt32(dadosInicio[1]);

            string[] dadosMomentoInicio = Console.ReadLine().Split(':');
            horaMomentoInicio = Convert.ToInt32(dadosMomentoInicio[0]);
            minutoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[1]);
            segundoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[2]);
    

            string[] dadosTermino = Console.ReadLine().Split();
            diaTermino = Convert.ToInt32(dadosTermino[1]);

            string[] dadosMomentoTermino = Console.ReadLine().Split(':');
            horaMomentoTermino = Convert.ToInt32(dadosMomentoTermino[0]);
            minutoMomentoTermino = Convert.ToInt32(dadosMomentoTermino[1]);
            segundoMomentoTerminio = Convert.ToInt32(dadosMomentoTermino[2]);
           
            int transformaSegundosInicio = (segundoMomentoInicio+(minutoMomentoInicio*mim)+(horaMomentoInicio*hour)+(diaInicio*day));
            int transformaSegundosTermino = (segundoMomentoTerminio+(minutoMomentoTermino*mim)+(horaMomentoTermino*hour)+(diaTermino*day));

            int somaTotalSegundos = (transformaSegundosTermino-transformaSegundosInicio);
            int W = somaTotalSegundos/day;
            somaTotalSegundos= somaTotalSegundos%day;
            int X = somaTotalSegundos/hour;
            somaTotalSegundos= somaTotalSegundos%hour;
            int Y = somaTotalSegundos/mim;
            somaTotalSegundos= somaTotalSegundos%mim;
            
            Console.WriteLine(W+" dia(s)");
            Console.WriteLine(X+" hora(s)");
            Console.WriteLine(Y+" minuto(s)");
            Console.WriteLine(somaTotalSegundos+" segundo(s)");
        


    }

}