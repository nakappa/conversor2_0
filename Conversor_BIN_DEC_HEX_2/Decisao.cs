using System;

namespace Conversor_BIN_DEC_HEX_2
{
    class Decisao
    {
        public static void Escolher()
        {
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

                    int escolha = int.Parse(Console.ReadLine());
                    if (escolha < 1 || escolha > 4)
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

                    if (escolha == 1)
                    {
                        Console.Write("\nDigite um número binario: ");
                        string numero = Console.ReadLine();

                        while (!controle)
                        {
                            string erro = Verificador.Verificar(numero, escolha);

                            if (erro == "ok")
                            {
                                numero = Console.ReadLine();
                                controle = false;
                            }

                            else
                            {
                                Console.WriteLine($"\nNúmero digitado foi: {numero}");
                                string convertido = Conversores.ConvBinOuHexEmDec(numero, escolha);
                                Console.WriteLine("Convertido em decimal: " + convertido);

                                convertido = Conversores.ConvBinEmHex(numero, escolha);
                                Console.WriteLine("Convertido em hexadecimal: " + convertido);

                                controle = true;
                            }
                        }

                        controle = false;
                    }

                    if (escolha == 2)
                    {
                        Console.Write("\nDigite um número decimal: ");
                        string numero = Console.ReadLine();

                        while (!controle)
                        {
                            string erro = Verificador.Verificar(numero, escolha);

                            if (erro == "ok")
                            {
                                numero = Console.ReadLine();
                                controle = false;
                            }

                            else
                            {
                                Console.WriteLine($"\nNúmero digitado foi: {numero}");
                                string convertido = Conversores.ConvDecEmBinOuHex(numero, escolha);
                                Console.WriteLine("Convertido em binario: " + convertido);

                                convertido = Conversores.ConvBinEmHex(convertido, escolha);
                                Console.WriteLine("Convertido em hexadecimal: " + convertido);

                                controle = true;
                            }
                        }

                        controle = false;
                    }

                    if (escolha == 3)
                    {
                        Console.Write("\nDigite um número hexadecimal: ");
                        string numero = Console.ReadLine().ToUpper();

                        while (!controle)
                        {
                            string erro = Verificador.Verificar(numero, escolha);

                            if (erro == "ok")
                            {
                                numero = Console.ReadLine().ToUpper();
                                controle = false;
                            }

                            else
                            {
                                Console.WriteLine($"\nNúmero digitado foi: {numero}");
                                string convertido = Conversores.ConvBinOuHexEmDec(numero, escolha);
                                Console.WriteLine("Convertido em decimal: " + convertido);

                                convertido = Conversores.ConvDecEmBinOuHex(convertido, escolha - 2);
                                Console.WriteLine("Convertido em binario: " + convertido);

                                controle = true;
                            }
                        }

                        controle = false;
                    }

                    if (escolha == 4)
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
