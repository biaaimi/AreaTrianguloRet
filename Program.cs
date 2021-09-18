using System;

namespace exercicios_etec
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Digite o valor da base triângulo ");
            string Base = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nAgora, digite o valor da altura:");
            string Altura = Console.ReadLine();

            double areaTriangulo = ( Convert.ToDouble(Base)* Convert.ToDouble(Altura))/ 2;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\nTotal área = {areaTriangulo}");


            Console.ReadKey();
            Console.ResetColor();
            
        }
    }
}
