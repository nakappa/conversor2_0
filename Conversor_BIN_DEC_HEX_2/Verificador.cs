using System;

namespace Conversor_BIN_DEC_HEX_2
{
    class Verificador
    {
        public static string Verificar(string numero, int escolha)
        {
            string invalido = "vou ver";
            string conversor = "qual?";
            string erro = "nenhum";
            bool controlador = false;

            if (escolha == 1)
            {
                foreach (char a in numero)
                {
                    if (a != '0' && a != '1')
                    {
                        controlador = true;
                    }
                }

                invalido = "\nFAVOR DIGITAR ALGARISMOS ENTRE 0 E 1!!!\n";
                conversor = "Digite um número binário: ";
            }

            if (escolha == 2)
            {
                foreach (char a in numero)
                {
                    if (a != '0' && a != '1' && a != '2' && a != '3' && a != '4' && a != '5' && a != '6' && a != '7' && a != '8' && a != '9')
                    {
                        controlador = true;
                    }
                }

                invalido = "\nFAVOR DIGITAR ALGARISMOS ENTRE 0 À 9!!!\n";
                conversor = "Digite um número decimal: ";
            }

            if (escolha == 3)
            {
                foreach (char a in numero)
                {
                    if (a != '0' && a != '1' && a != '2' && a != '3' && a != '4' && a != '5' && a != '6' && a != '7' && a != '8' && a != '9' && a != 'A' && a != 'B' && a != 'C' && a != 'D' && a != 'E' && a != 'F')
                    {
                        controlador = true;
                    }
                }

                invalido = "\nFAVOR DIGITAR ALGARISMOS ENTRE 0 À 9 E OU A ATÉ F!!!\n";
                conversor = "Digite um número hexdecimal: ";
            }

            
            if (controlador)
            {
                ConsoleColor aux = Console.BackgroundColor;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                ConsoleColor aux2 = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(invalido);
                Console.BackgroundColor = aux;
                Console.ForegroundColor = aux2;
                Console.Write(conversor);
                erro = "ok";
            }
            
            return erro;
        }
    }
}
