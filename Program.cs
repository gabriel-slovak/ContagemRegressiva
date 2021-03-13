using System;

namespace ContagemRegressiva_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Contagem Regressiva");
            Console.WriteLine("-------------------");
            Console.WriteLine();

Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Pressione uma tecla para começar!");
         Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine("Preparar...");
            Console.ReadKey();
            Console.WriteLine("Apontar...");
            Console.ReadKey();
Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("FOGO!");
            Console.WriteLine();
        Console.ResetColor();
        }
    }
}
