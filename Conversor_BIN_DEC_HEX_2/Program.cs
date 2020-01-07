using System;

namespace Conversor_BIN_DEC_HEX_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor aux = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("CONVERSOR NUMÉRICO");
            Console.BackgroundColor = aux;

            Decisao.Escolher();
        }
    }
}
