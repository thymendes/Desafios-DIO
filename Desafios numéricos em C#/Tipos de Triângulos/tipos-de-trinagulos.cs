using System;

class Desafio
{

    public static void Main()
    {
        string[] s = Console.ReadLine().Split(' ');
        double a = double.Parse(s[0]);
        double b = double.Parse(s[1]);
        double c = double.Parse(s[2]);
        double aux;
        if (a < b )
        {
            aux = a;
            a = b;
            b = aux;
        }
        else if (a < c) 
        {
            aux = a;
            a = c;
            c = aux;
        }

        else if (b < c)
        {
            aux = c;
            b = c;
            c = aux;
        }
        //continue a solucao
        if (a >= b + c)

            Console.WriteLine("NAO FORMA TRIANGULO");


        else if ( a * a == b * b + c * c)

            Console.WriteLine("TRIANGULO RETANGULO");
        else if (a * a > b * b + c * c)
            Console.WriteLine("TRIANGULO OBTUSANGULO");
        else if (a * a < b * b + c * c)
            Console.WriteLine("TRIANGULO ACUTANGULO");
        if (  a==b && b==c  )
            Console.WriteLine("TRIANGULO EQUILATERO");
        if (  a==b && b !=c || b==c && a !=b        )
            Console.WriteLine("TRIANGULO ISOSCELES");

        Console.ReadLine();
    }
}