using System;
using Conversor_BIN_DEC_HEX_2.Conversor;

namespace Conversor_BIN_DEC_HEX_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string digito = Console.ReadLine();
            string conversor = Conversores.ConvBin(digito);
            Console.WriteLine(conversor + "\n");
        }
    }
}
