using System;

namespace Atv1
{
    class Program
    {
        static void Main(string[] args)
        {
            int? maior;
            int count = 0, ciclos;
            maior = null;

            ciclos = 3;
            int inserido;
            do
            {
                inserido = Convert.ToInt32(Console.ReadLine());
                if (maior == null)
                {
                    maior = inserido;
                }
                else
                {
                    if (inserido > maior)
                    {
                        maior = inserido;
                    }
                }
                count++;
            } while (count < ciclos);

            Console.WriteLine("O maior valor inserido é: " + maior);

        }
    }
}
