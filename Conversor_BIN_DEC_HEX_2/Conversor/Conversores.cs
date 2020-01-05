using System;
using System.Collections.Generic;
using System.Text;

namespace Conversor_BIN_DEC_HEX_2.Conversor
{
    class Conversores
    {
        public int escolha;

        public static string ConvBin(string numero)
        {
            int valor = int.Parse(numero);
            List<int> lista = new List<int>();

            while (valor != 0)
            {
                int resultado = valor / 2;
                int resto = valor % 2;
                int aux = resultado;
                valor = aux;
                lista.Insert(0, resto);
            }

            char[] convertido = new char[lista.Count];
            int pos = 0;

            Console.WriteLine(convertido.Length);

            foreach (int a in lista)
            {
                convertido[pos] = char.Parse(a.ToString());
                pos++;
            }

            return "Convertido em binário: " + new string(convertido);
        }

        public static string ConvDec(string numero, int decide)
        {
            Conversores decisao = new Conversores();
            string s = numero.ToString();
            double[] x = new double[s.Length];
            double y;
            int pos = 0;

            decisao.escolha = decide;
            double exp = decide switch { 1 => 2, _ => 16 };

            foreach (char a in s)
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

                y = s.Length - pos - 1;
                x[pos] = valor * Math.Pow(exp, y);
                pos++;
            }

            y = 0;
            for (int i = 0; i < x.Length; i++) y += x[i];

            s = y.ToString();

            return "Convertido em decimal: " + s;
        }
    }
}
