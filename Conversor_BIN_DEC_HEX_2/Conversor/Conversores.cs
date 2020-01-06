using System;
using System.Collections.Generic;
using System.Text;

namespace Conversor_BIN_DEC_HEX_2.Conversor
{
    class Conversores
    {
        public int escolha;

        public static string ConvBinHex(string numero, int decide)
        {
            int valor = int.Parse(numero);
            List<int> lista = new List<int>();
            int div = decide switch { 3 => 16, _ => 2 };

            while (valor != 0)
            {
                int resultado = valor / div;
                int resto = valor % div;
                int aux = resultado;
                valor = aux;
                lista.Insert(0, resto);
            }

            char[] convertido = new char[lista.Count];
            int pos = 0;

            foreach (int a in lista)
            {
                string s = a switch
                {
                    0 => "0",
                    1 => "1",
                    2 => "2",
                    3 => "3",
                    4 => "4",
                    5 => "5",
                    6 => "6",
                    7 => "7",
                    8 => "8",
                    9 => "9",
                    10 => "A",
                    11 => "B",
                    12 => "C",
                    13 => "D",
                    14 => "E",
                    _ => "F",
                };

                convertido[pos] = char.Parse(s);
                pos++;
            }

            if (decide == 3) Console.Write("Convertido em hexadecimal: ");
            else Console.Write("Convertido em binário: ");

            return new string(convertido);
        }

        public static string ConvDec(string numero, int decide)
        {
            Conversores decisao = new Conversores();
            string convertido = numero.ToString();
            double[] x = new double[convertido.Length];
            double y;
            int pos = 0;
            double exp = decide switch { 3 => 16, _ => 2 };

            foreach (char a in convertido)
            {
                int valor = a switch
                {
                    '0' => 0,
                    '1' => 1,
                    '2' => 2,
                    '3' => 3,
                    '4' => 4,
                    '5' => 5,
                    '6' => 6,
                    '7' => 7,
                    '8' => 8,
                    '9' => 9,
                    'A' => 10,
                    'B' => 11,
                    'C' => 12,
                    'D' => 13,
                    'E' => 14,
                    _ => 15
                };

                y = convertido.Length - pos - 1;
                x[pos] = valor * Math.Pow(exp, y);
                pos++;
            }

            y = 0;
            for (int i = 0; i < x.Length; i++) y += x[i];

            convertido = y.ToString();

            return "Convertido em decimal: " + convertido;
        }
    }
}
