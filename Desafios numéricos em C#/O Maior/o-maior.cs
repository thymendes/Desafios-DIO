using System;

    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            //complete declarando as variáveis
            int a = Convert.ToInt32(valores[0]);
            int b = Convert.ToInt32(valores[1]);
            int c = Convert.ToInt32(valores[2]);
            
            int MaiorAB = ( a + b + Math.Abs(a-b))/2;
            
            int Maior = (MaiorAB + c + Math.Abs(MaiorAB - c))/2;
            
          Console.WriteLine($"{Maior} eh o maior");
                        
        }
    }