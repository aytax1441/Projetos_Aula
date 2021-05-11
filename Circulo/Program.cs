using System;

namespace Circulo
{
    class Circulos
    {
        double R { get; }

        public Circulos(double raio)
        {
            try
            {
                if (raio > 0)
                {
                    this.R = raio;
                }
                else
                {
                    throw new Exception("Valor inválido!");
                }
            }catch(Exception e)
            {
                Console.WriteLine(e);
                return;
            }
        }

        public double calcComprimento()
        {
            return Math.PI * 2 * R;
        }
        public double calcArea()
        {
            return Math.PI * Math.Pow(R, 2.0);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Insira o valor do raio: ");
                double raio;
                raio = Convert.ToDouble(Console.ReadLine());
                Circulos circ = new Circulos(raio);
                Console.WriteLine("Comprimento: " + circ.calcComprimento().ToString("0.##"));
                Console.WriteLine("Área: " + circ.calcArea().ToString("0.##"));
            }catch(Exception e)
            {
                Console.Clear();
                Console.WriteLine("Erro encontrado: " + e.Message);
            }
        }
    }
}
