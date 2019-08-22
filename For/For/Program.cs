using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.Write("Dame el inicio del ciclo ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Dame el final del ciclo ");
            y = int.Parse(Console.ReadLine());
            Console.Write("De cuanto en cuanto quieres que avance el ciclo? ");
            z = int.Parse(Console.ReadLine());
            if (x > y)
            {
                for (int i=x;i>=y;i-=z)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = x; i <= y; i+=z)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
