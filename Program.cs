using System;

namespace RetContorno
{
    class Program
    {
        static void Main(string[] args)
        {

        int altura, largura, meio = 1; 
        bool valor; 
    
        Console.WriteLine("Tamanho do retângulo, digite apenas números de 1 a 10:");

        Console.Write("Largura: ");
        valor = Int32.TryParse (Console.ReadLine(), out largura);

        Console.Write("Altura: ");
        valor = Int32.TryParse (Console.ReadLine(), out altura);

        if (!valor || largura < 1 || largura > 10 || altura < 1 || altura > 10)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Por favor, recomeçe e digite números de 1 a 10. ");
                Console.ResetColor();
                Environment.Exit(-1);
            }
        else
            {
                int linhaUm = 1;
                while (linhaUm <= largura)
            {
                Console.Write("* ");
                linhaUm++;
            }

            Console.WriteLine();
            int parteUm = altura - 2; 
            while(meio <= parteUm)
            {
                int parteDois = 1; 
                Console.Write("* ");
                int result = largura - 2;
                while (parteDois <= result)
                {
                    Console.Write("* ");
                    parteDois++;                   
                }

                Console.Write("  ");
                Console.WriteLine();
                meio++;
            }

            int linhaDois = 1;
            while (linhaDois <= largura)
            {
                Console.Write("* ");
                linhaDois++;
            }
        }
     }
   }
}
