using System;
using System.Collections.Generic;
using System.Text;

namespace Conversor_BIN_DEC_HEX_2.Conversor
{
    class Conversores
    {
       public static string ConvBin(string numero)
        {
            List<int> lista = new List<int>();
            int valor = int.Parse(numero);

            while (valor != 0)
            {
                int resultado = valor / 2;
                int resto = valor % 2;
                int aux = resultado;
                valor = aux;
                lista.Insert(0, resto);
            }

            int n = lista.Count;
            char[] convertido = new char[n];
            int pos = 0;

            Console.WriteLine(convertido.Length);

            foreach (int a in lista)
            {
                convertido[pos] = char.Parse(a.ToString());
                pos++;
            }

            return "Convertido em binário: " + new string (convertido);
        }
    }
}
