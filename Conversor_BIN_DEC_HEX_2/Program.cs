﻿using System;
using Conversor_BIN_DEC_HEX_2.Conversor;

namespace Conversor_BIN_DEC_HEX_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversores conv = new Conversores { escolha = int.Parse(Console.ReadLine()) };

            string digito = Console.ReadLine();
            string conversor = Conversores.ConvBinHex(digito, conv.escolha);
            Console.WriteLine(conversor + "\n");

            digito = Console.ReadLine().ToUpper();
            conversor = Conversores.ConvDec(digito, conv.escolha);
            Console.WriteLine(conversor + "\n");


        }
    }
}
