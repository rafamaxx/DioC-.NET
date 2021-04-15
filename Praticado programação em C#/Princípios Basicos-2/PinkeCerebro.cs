using System;

class MinhaClasse {
  public static void Main (string[] args) {
    int totalDeCasosDeTeste = int.Parse(Console.ReadLine());
            int m2 = 0;
            int m3 = 0;
            int m4 = 0;
            int m5 = 0;
            string[] entrada = Console.ReadLine().Split();
            int[] numeros = new int[totalDeCasosDeTeste];
            
            for(int i = 0;i<totalDeCasosDeTeste;i++){
                numeros[i] = int.Parse(entrada[i]);
            }
            for(int i = 0;i<totalDeCasosDeTeste;i++){
                if(numeros[i]%2==0){
                    m2++;
                    if(numeros[i]%4==0)
                        m4++;
                }
            }
            for(int i = 0;i<totalDeCasosDeTeste;i++){
                if(numeros[i]%3==0)
                    m3++;
            }
            for(int i = 0;i<totalDeCasosDeTeste;i++){
                if(numeros[i]%5==0)
                    m5++;
            }

            Console.WriteLine(m2+" Multiplo(s) de 2");
            Console.WriteLine(m3+" Multiplo(s) de 3");
            Console.WriteLine(m4+" Multiplo(s) de 4");
            Console.WriteLine(m5+" Multiplo(s) de 5");
  }
}