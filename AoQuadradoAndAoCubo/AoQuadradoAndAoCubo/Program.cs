using System;

namespace AoQuadradoAndAoCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] resposta = new int[2]; 

            for (int i = 1; i <= n; i++)
            {
                resposta[0] = i * i;
                resposta[1] = resposta[0] * i;
                Console.WriteLine($"{i} {resposta[0]} {resposta[1]}");
            }
        }
    }
}
