using System;
using System.Collections.Generic;

namespace Atv3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> valores = new List<int>();
            int ciclos, count = 0;
            ciclos = 10;

            while (count < ciclos)
            {
                valores.Add(Convert.ToInt32(Console.ReadLine()));
                count++;
            }

            List<int> limpo = new List<int>(), contagem = new List<int>();
            valores.Sort();
            foreach(int val in valores)
            {
                if(limpo.IndexOf(val) != -1)
                {
                    contagem[limpo.IndexOf(val)]++;
                }
                else
                {
                    limpo.Add(val);
                    contagem.Add(1);
                }
            }
            int quantidade;
            string plural;
            foreach(int val in limpo)
            {
                quantidade = contagem[limpo.IndexOf(val)];
                plural = (quantidade > 1) ? "es." : ".";
                Console.WriteLine("O valor " + val + " apareceu " + quantidade + " vez" + plural);
            }
        }
    }
}
