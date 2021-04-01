using System;
using System.Collections;

namespace Atv2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList valores = new ArrayList();
            float media, soma = 0;

            int ciclos, count = 0, inserido;
            ciclos = 10;

            while (count < ciclos)
            {
                inserido = Convert.ToInt32(Console.ReadLine());
                valores.Add(inserido);
                count++;
            }

            foreach (int valor in valores)
            {
                soma += valor;
            }

            media = soma / valores.Count;

            Console.WriteLine("A média é: " + media);
            Console.WriteLine("Valor(es) menor(es) que a média:");
            foreach (int valor in valores)
            {
                if (valor < media)
                {
                    Console.Write(valor + " ");
                }
            }
        }
    }
}
