using System;
using Conversor_BIN_DEC_HEX_2.Conversor;

namespace Conversor_BIN_DEC_HEX_2
{
    class Decisao
    {
        public static void ChamandoConvBinHex(string digito, int escolha)
        {
            string conversor = Conversores.ConvBinHex(digito, escolha);
            if (escolha == 3) Console.WriteLine("Convertido em hexadecimal: " + conversor);
            else Console.WriteLine("Convertido em binário: " + conversor);
        }

        public static void ChamandoConvDec(string digito, int escolha)
        {
            string conversor = Conversores.ConvDec(digito, escolha);
            Console.WriteLine("Convertido em decimal: " + conversor);
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

                    conv.escolha = int.Parse(Console.ReadLine());
                    if (conv.escolha < 1 || conv.escolha > 4)
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

                    if (conv.escolha == 1)
                    {
                        Console.Write("\nDigite um número binario: ");
                        string digito = Console.ReadLine();

                        //controle = 0;

                        while (!controle)
                        {
                            string erro = Verificador.Verificar(digito, conv.escolha);

                            if (erro == "ok")
                            {
                                digito = Console.ReadLine();
                                controle = false;
                            }

                            else
                            {
                                Console.WriteLine($"\nNúmero digitado foi: {digito}");
                                ChamandoConvDec(digito, conv.escolha);
                                ChamandoConvBinHex(Conversores.ConvDec(digito, conv.escolha), conv.escolha = 3);
                                conv.escolha = 0;
                                controle = true;
                            }
                        }

                        controle = false;
                    }

                    if (conv.escolha == 2)
                    {
                        Console.Write("\nDigite um número decimal: ");
                        string digito = Console.ReadLine();

                        //controle = 0;

                        while (!controle)
                        {
                            string erro = Verificador.Verificar(digito, conv.escolha);

                            if (erro == "ok")
                            {
                                digito = Console.ReadLine();
                                controle = false;
                            }

                            else
                            {
                                Console.WriteLine($"\nNúmero digitado foi: {digito}");
                                ChamandoConvBinHex(digito, conv.escolha);
                                ChamandoConvBinHex(digito, conv.escolha = 3);
                                conv.escolha = 0;
                                controle = true;
                            }
                        }

                        controle = false;
                    }

                    if (conv.escolha == 3)
                    {
                        Console.Write("\nDigite um número hexadecimal: ");
                        string digito = Console.ReadLine().ToUpper();

                        //controle = 0;

                        while (!controle)
                        {
                            string erro = Verificador.Verificar(digito, conv.escolha);

                            if (erro == "ok")
                            {
                                digito = Console.ReadLine().ToUpper();
                                controle = false;
                            }

                            else
                            {
                                Console.WriteLine($"\nNúmero digitado foi: {digito}");
                                ChamandoConvDec(digito, conv.escolha);
                                ChamandoConvBinHex(Conversores.ConvDec(digito, conv.escolha), conv.escolha = 1);
                                conv.escolha = 0;
                                controle = true;
                            }
                        }

                        controle = false;
                    }

                    if (conv.escolha == 4)
                    {
                        Console.WriteLine("\nADEUS!!!");
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
