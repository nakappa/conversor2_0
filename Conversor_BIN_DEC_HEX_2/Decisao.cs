using System;

namespace Conversor_BIN_DEC_HEX_2
{
    class Decisao
    {
        public static void ConvertendoDecEmBinOuHex(string numero, int escolha)
        {
            string conversor = Conversores.ConvDecEmBinOuHex(numero, escolha);
            //if (escolha == 3) Console.WriteLine("Convertido em hexadecimal: " + conversor);
            //else Console.WriteLine("Convertido em binário: " + conversor);
            Console.WriteLine("Convertido em binário: " + conversor);
            numero = Conversores.ConvBinEmHexOuHexEmBin(conversor, escolha);
            Console.WriteLine("Convertido em hexadecimal:" + numero);
        }

        public static void ConvertendoBinOuHexEmDec(string numero, int escolha)
        {
            string conversor = Conversores.ConvBinOuHexEmDec(numero, escolha);
            Console.WriteLine("Convertido em decimal: " + conversor);
            conversor = Conversores.ConvBinEmHexOuHexEmBin(numero, escolha);
            Console.WriteLine("Convertido em hexadecimal:" + conversor);
        }

        public static void Escolher()
        {
            Conversores conv = new Conversores(); ;

            bool controle = false;
            try
            {
                while (!controle)
                {
                    Console.Write("\nEscolha:" +
                        "\n1 - Para converter BINÁRIO em DECIMAL / HEXADECIMAL" +
                        "\n2 - Para converter DECIMAL em BINÁRIO / HEXADECIMAL" +
                        "\n3 - Para converter HEXADECIMAL em DECIMAL / BINÁRIO" +
                        "\n4 - Para SAIR: ");

                    conv.Escolha = int.Parse(Console.ReadLine());
                    if (conv.Escolha < 1 || conv.Escolha > 4)
                    {
                        ConsoleColor aux = Console.BackgroundColor;
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        ConsoleColor aux2 = Console.ForegroundColor;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nFAVOR DIGITAR UM VALOR ENTRE 1 À 4!!!");
                        Console.BackgroundColor = aux;
                        Console.ForegroundColor = aux2;

                        Console.Write("\nQual a sua escolha?" +
                            "\n1 - (BINÁRIO / DECIMAL & HEXADECIMAL)" +
                            "\n2 - (DECIMAL / BINÁRIO & HEXADECIMAL)" +
                            "\n3 - (HEXADECIMAL / DECIMAL & BINÁRIO)" +
                            "\n4 - (SAIR): ");
                    }

                    if (conv.Escolha == 1)
                    {
                        Console.Write("\nDigite um número binario: ");
                        string numero = Console.ReadLine();

                        while (!controle)
                        {
                            string erro = Verificador.Verificar(numero, conv.Escolha);

                            if (erro == "ok")
                            {
                                numero = Console.ReadLine();
                                controle = false;
                            }

                            else
                            {
                                Console.WriteLine($"\nNúmero digitado foi: {numero}");
                                ConvertendoBinOuHexEmDec(numero, conv.Escolha);
                                ConvertendoDecEmBinOuHex(Conversores.ConvBinOuHexEmDec(numero, conv.Escolha), conv.Escolha = 3);
                                conv.Escolha = 0;
                                controle = true;
                            }
                        }

                        controle = false;
                    }

                    if (conv.Escolha == 2)
                    {
                        Console.Write("\nDigite um número decimal: ");
                        string numero = Console.ReadLine();

                        while (!controle)
                        {
                            string erro = Verificador.Verificar(numero, conv.Escolha);

                            if (erro == "ok")
                            {
                                numero = Console.ReadLine();
                                controle = false;
                            }

                            else
                            {
                                Console.WriteLine($"\nNúmero digitado foi: {numero}");
                                ConvertendoDecEmBinOuHex(numero, conv.Escolha);
                                conv.Escolha = 0;
                                controle = true;
                            }
                        }

                        controle = false;
                    }

                    if (conv.Escolha == 3)
                    {
                        Console.Write("\nDigite um número hexadecimal: ");
                        string numero = Console.ReadLine().ToUpper();

                        while (!controle)
                        {
                            string erro = Verificador.Verificar(numero, conv.Escolha);

                            if (erro == "ok")
                            {
                                numero = Console.ReadLine().ToUpper();
                                controle = false;
                            }

                            else
                            {
                                Console.WriteLine($"\nNúmero digitado foi: {numero}");
                                ConvertendoBinOuHexEmDec(numero, conv.Escolha);
                                ConvertendoDecEmBinOuHex(Conversores.ConvBinOuHexEmDec(numero, conv.Escolha), conv.Escolha = 1);
                                conv.Escolha = 0;
                                controle = true;
                            }
                        }

                        controle = false;
                    }

                    if (conv.Escolha == 4)
                    {
                        ConsoleColor aux = Console.BackgroundColor;
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        ConsoleColor aux2 = Console.ForegroundColor;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nADEUS!!!");
                        Console.BackgroundColor = aux;
                        Console.ForegroundColor = aux2;
                        controle = true;
                    }
                }
            }

            catch (Exception)
            {
                //Console.WriteLine(e.Message);
                ConsoleColor aux = Console.BackgroundColor;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                ConsoleColor aux2 = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nFAVOR DIGITAR UM VALOR ENTRE 1 À 4!!!");
                Console.BackgroundColor = aux;
                Console.ForegroundColor = aux2;

                Escolher();
            }
        }
    }
}
