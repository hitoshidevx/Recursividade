using System;

namespace Recursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sequência fibonacci = o próximo número é sempre a soma dos dois anteriores;
            Recursividade fibao = new Recursividade();
            //fibao.GerarValorFibonacci(0,1,30);

            Recursividade fatorial = new Recursividade();
            Console.WriteLine(fatorial.GerarFatorial(14));




        }
    }
}
