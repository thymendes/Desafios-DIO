using System; 

class impares {

        public static void Main()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            //complete seu codigo
            for (int i = 1; i <= n; i++) {
             if(i % 2 == 1) {Console.WriteLine(i);}
            }
            
            Console.ReadLine();
        }

}