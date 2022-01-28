using System;

namespace Diferenca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, X;

            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            C = Convert.ToInt32(Console.ReadLine());
            D = Convert.ToInt32(Console.ReadLine());

            X = A * B - C * D;

            Console.WriteLine($"DIFERENCA = {X}");
        }
    }
}
