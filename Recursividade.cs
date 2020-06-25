using System;

namespace Recursividade
{
    public class Recursividade
    {
        public void GerarValorFibonacci(int num1, int num2, int vezes){

            if(vezes > 0){

                int soma = num1 + num2;
                Console.WriteLine(num1);
                GerarValorFibonacci(num2, soma, vezes -1);
            }
        }

        public int GerarFatorial(int numero){

            if(numero == 1){
                return 1;
            }else{

                return numero * GerarFatorial(numero - 1); 

            }

        }

    }
}