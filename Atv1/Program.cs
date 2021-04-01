using System;

namespace Atv1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[3];
            int? maior;
            int count = 0, ciclos;
            maior = null;
            ciclos = 3;
            while(count < ciclos)
            {
                valores[count] = Console.Read();
                if(maior == null)
                {
                    maior = valores[count];
                }
                else
                {
                    if(valores[count] > maior)
                    {
                        maior = valores[count];
                    }
                }
            }

        }
    }
}
