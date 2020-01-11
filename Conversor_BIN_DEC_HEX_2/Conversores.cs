using System;
using System.Collections.Generic;
using System.Linq;

namespace Conversor_BIN_DEC_HEX_2
{
    public class Conversores
    {
        public int Escolha;
        public string Numero;

        public static string ConvDecEmBinOuHex(string numero, int escolha)
        {
            int valor = int.Parse(numero);
            List<int> lista = new List<int>();
            int div = escolha switch { 3 => 16, _ => 2 };

            do
            {
                int resultado = valor / div;
                int resto = valor % div;
                int aux = resultado;
                valor = aux;
                lista.Insert(0, resto);
            } while (valor != 0);

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

            return new string(convertido);
        }

        public static string ConvBinOuHexEmDec(string numero, int escolha)
        {
            string convertido = numero;
            double[] x = new double[convertido.Length];
            double y;
            int pos = 0;
            double exp = escolha switch { 3 => 16, _ => 2 };

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

            return y.ToString();
        }

        public static string ConvBinEmHexOuHexEmBin(string numero, int escolha)
        {
            char[] convertido = new char[numero.Length];
            List<int> lista = new List<int>();
            double y = 0;
            int valor;
            int pegar = 0;
            int posCon = 0;
            int pos = 0;
            double exp = 2;

            foreach (char a in numero)
            {
                valor = a switch
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

                do
                {
                    int resultado = valor / 2;
                    int resto = valor % 2;
                    int aux = resultado;
                    valor = aux;
                    lista.Insert(0, resto);
                    //convertido[posCon] = char.Parse(resto.ToString());
                    posCon++;
                } while (valor != 0);
            }


            int contador = (int)Math.Ceiling(lista.Count / 4d);

            for (int i = 0; i < contador; i++)
            {
                double[] x = new double[lista.Count];

                for (double j = 0; j <= contador; j++)
                {
                    int a = lista[pegar];
                    valor = a;
                    x[pos] = valor * Math.Pow(exp, y);
                    y++;

                    if (pegar == x.Length - 1) j = contador;

                    pos++;
                    pegar++;
                }

                pos = 0;
                y = 0;

                for (int j = 0; j <= contador; j++) y += x[j];

                char c = y switch
                {
                    0 => '0',
                    1 => '1',
                    2 => '2',
                    3 => '3',
                    4 => '4',
                    5 => '5',
                    6 => '6',
                    7 => '7',
                    8 => '8',
                    9 => '9',
                    10 => 'A',
                    11 => 'B',
                    12 => 'C',
                    13 => 'D',
                    14 => 'E',
                    _ => 'F'
                };

                convertido[contador - i] = c;
                y = 0;
            }

            return new string(convertido);
        }
    }
}
