using System;
using Conversor_BIN_DEC_HEX_2.Conversor;

namespace Conversor_BIN_DEC_HEX_2
{
    class Decisao
    {
        public static void ChamandoConvBinHex(int escolha, string digito)
        {
            bool controle = false;
            while (!controle)
            {
                foreach (char a in digito) if (a != '0' && a != '1' && a != '2' && a != '3' && a != '4' && a != '5' && a != '6' && a != '7' && a != '8' && a != '9') controle = true;

                if (controle)
                {
                    Console.WriteLine("FAVOR DIGITAR ALGARISMOS ENTRE 0 À 9!!!\n");
                    Console.Write("Digite um número decimal: ");
                    digito = Console.ReadLine().ToUpper();
                    Console.WriteLine();
                    Console.WriteLine("Número digitado foi: " + digito);
                    controle = false;
                }

                else
                {
                    //Conversores conv = new Conversores();
                    //string conversor = conv.ConvBinHex(digito, escolha);
                    string conversor = Conversores.ConvBinHex(digito, escolha);
                    if (escolha == 3) Console.WriteLine("Convertido em hexadecimal: " + conversor);
                    else Console.WriteLine("Convertido em binário: " + conversor);
                    controle = true;
                }
            }
        }

        public static void ChamandoConvDec(int escolha, string digito)
        {
            bool controle = false;

            while (!controle)
            {
                if (escolha == 1)
                    foreach (char a in digito)
                        if (a != '0' && a != '1') controle = true;

                if (escolha == 3)
                    foreach (char a in digito)
                        if (a != '0' && a != '1' && a != '2' && a != '3' && a != '4' && a != '5' && a != '6' && a != '7' && a != '8' && a != '9' && a != 'A' && a != 'B' && a != 'C' && a != 'D' && a != 'E' && a != 'F') controle = true;

                if (controle)
                {
                    Console.WriteLine("FAVOR DIGITAR ALGARISMOS ENTRE 0 E 1!!!");

                    if (escolha == 1) Console.Write("Digite um número binário: ");

                    if (escolha == 3) Console.Write("Digite um número hexadecimal: ");

                    digito = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Número digitado foi: " + digito);
                    controle = false;
                }

                else
                {
                    //Conversores conv = new Conversores();
                    //string conversor = conv.ConvDec(digito, escolha);
                    string conversor = Conversores.ConvBinHex(digito, escolha);
                    Console.WriteLine(conversor);
                    controle = true;

                }
            }
        }

        public void Escolher()
        {
            Console.WriteLine("CONVERSOR NUMÉRICO\n");
            Console.Write("Escolha:" +
                "\n1 - Para converter BINÁRIO em DECIMAL / HEXADECIMAL" +
                "\n2 - Para converter DECIMAL em BINÁRIO / HEXADECIMAL" +
                "\n3 - Para converter HEXADECIMAL em DECIMAL / BINÁRIO" +
                "\n4 - Para SAIR: ");

            bool controle = false;

            while (!controle)
            {
                Conversores conv = new Conversores { escolha = int.Parse(Console.ReadLine()) };
                if (conv.escolha < 1 || conv.escolha > 4)
                {
                    Console.Write("\nFAVOR DIGITAR UM VALOR ENTRE 1 À 4!!!" +
                        "\nQual a sua escolha?" +
                        "\n1 - (BINÁRIO / DECIMAL & HEXADECIMAL)" +
                        "\n2 - (DECIMAL / BINÁRIO & HEXADECIMAL)" +
                        "\n3 - (HEXADECIMAL / DECIMAL & BINÁRIO)" +
                        "\n4 - (SAIR): ");
                }

                if (conv.escolha == 1)
                {
                    Console.Write("\nDigite um número binário: ");
                    string digito = Console.ReadLine().ToUpper();
                    Console.WriteLine($"\nNúmero digitado foi: {digito}");

                    ChamandoConvDec(conv.escolha, digito);

                    Console.Write("\nEscolha:" +
                "\n1 - Para converter BINÁRIO em DECIMAL / HEXADECIMAL" +
                "\n2 - Para converter DECIMAL em BINÁRIO / HEXADECIMAL" +
                "\n3 - Para converter HEXADECIMAL em DECIMAL / BINÁRIO" +
                "\n4 - Para SAIR: ");
                }

                if (conv.escolha == 2)
                {
                    Console.Write("\nDigite um número decimal: ");
                    string digito = Console.ReadLine().ToUpper();
                    Console.WriteLine($"\nNúmero digitado foi: {digito}");

                    ChamandoConvBinHex(conv.escolha, digito);
                    ChamandoConvBinHex(conv.escolha = 3, digito);
                    conv.escolha = 0;

                    Console.Write("\nEscolha:" +
                "\n1 - Para converter BINÁRIO em DECIMAL / HEXADECIMAL" +
                "\n2 - Para converter DECIMAL em BINÁRIO / HEXADECIMAL" +
                "\n3 - Para converter HEXADECIMAL em DECIMAL / BINÁRIO" +
                "\n4 - Para SAIR: ");
                }

                if (conv.escolha == 3)
                {
                    Console.Write("\nDigite um número hexadecimal: ");
                    string digito = Console.ReadLine().ToUpper();
                    Console.WriteLine($"\nNúmero digitado foi: {digito}");
                    ChamandoConvDec(conv.escolha, digito);
                    //conv.ConvDec(digito, conv.escolha);
                    //dcd.x = conv.resultado;
                    //Console.WriteLine(dcd.x);

                    Console.Write("\nEscolha:" +
                "\n1 - Para converter BINÁRIO em DECIMAL / HEXADECIMAL" +
                "\n2 - Para converter DECIMAL em BINÁRIO / HEXADECIMAL" +
                "\n3 - Para converter HEXADECIMAL em DECIMAL / BINÁRIO" +
                "\n4 - Para SAIR: ");
                }

                if (conv.escolha == 4)
                {
                    Console.WriteLine("ADEUS!!!");
                    controle = true;
                }
            }
        }
    }
}
