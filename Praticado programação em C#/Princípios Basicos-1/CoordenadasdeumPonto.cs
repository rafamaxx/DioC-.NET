using System; 

class URI {

    static void Main(string[] args) { 

            double x,y;
            string[] inn = Console.ReadLine().Split();
            x = double.Parse(inn[0]);
            y = double.Parse(inn[1]);

            if(x==0 && y==0)
            {
                Console.WriteLine("Origem");
            }
            else if(x==0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if(y==0)
            {
                Console.WriteLine("Eixo X");
            }
            else{
                if(x>0 && y>0)
                    Console.WriteLine("Q1");
                else if(x>0&&y<0)
                    Console.WriteLine("Q4");
                else if (x<0 && y>0)
                    Console.WriteLine("Q2");
                else
                    Console.WriteLine("Q3");
            }


    }

}