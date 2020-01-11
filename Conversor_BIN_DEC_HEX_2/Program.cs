using System;
using System.Collections.Generic;
using System.Linq;

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

            //string convertido = Console.ReadLine();
            //List<string> lista = new List<string>();
            //double[] x = new double[convertido.Length];
            //double y;
            //int pegar = 4;
            //int saltar = pegar - 4;
            //int n = convertido.Length;
            //int pos = 0;

            //foreach (char a in convertido) lista.Add(a.ToString());

            //for (int i = 0; i < convertido.Length / Math.Ceiling(n / 4d); i += 3)
            //{
            //    string s = lista.Skip(saltar).Take(pegar).ToString();
            //    //int[] valor = new int[s.Length];
            //    Console.WriteLine(s[pos]);
            //    pos++;
            //}


            //Decisao.ConvertendoDecEmBinOuHex(Console.ReadLine(), 1);
        }
    }
}
