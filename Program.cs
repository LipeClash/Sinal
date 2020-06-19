using System;

namespace Sinal
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumeroDigitado;
            Console.WriteLine("Leia um número inteiro e exiba “Negativo”, “Zero” ou “Positivo”\n");
            Console.Write("Digite um número: ");

            NumeroDigitado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Positivo");

        }  
    }
}
