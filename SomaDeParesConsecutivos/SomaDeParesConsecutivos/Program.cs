using System;

namespace SomaDeParesConsecutivos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int total;
            int D = Convert.ToInt32(Console.ReadLine());
            while (D != 0) // Esse loop acabará assim que o usuário digitar 0 como entrada para o D
            {
                if (D % 2 == 0) // Checa se o número é par.
                {
                    total = D; // Atribui ao total o valor digitado pelo usúario. 
                    for (int i = 2; i < 10; i+=2) // Um simples 'for' com 5 4 iterações também funcionaria perfeitamente :P
                    {
                        D += 2; // Agora o valor digitado pelo usuario vai ser igual ele mesmo +2
                        //Ex: Se o usuario digita 4, teremos:
                        //Primeira iteração: D + 2 // D = 6
                        //                   total = 4 + 6 // total = 10
                        //Segunda iteração:  D + 2 // D = 8 //Perceba que D agora era 6
                        //                   total = 10 + 8
                        //E assim se segue até termos 4 iterações.

                        total += D;
                    }
                    Console.WriteLine($"{total}");
                }else{
                    D += 1; // A lógica do problema faz com que caso o usúario digite um valor impar
                            //Devamos considerar esse valor sendo ELE + 1
                            //Caso seja 11, o programa deve comporta-se da mesma maneira que caso fosse digitado 12.
                    total = D;
                    for (int i = 1; i < 5; i += 1) // como dito anteriormente, um simples 'for' que itera 4 vezes já era suficiente.
                    {
                        D += 2;
                        total += D;
                    }
                    Console.WriteLine($"{total}");
                }
                D = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
