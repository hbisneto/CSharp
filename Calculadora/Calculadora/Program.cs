using System;

namespace Calculadora
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string SoftwareName = "Calculadora C# Console";
            string Version = "1.0";
            string CopyrightName = "Heitor Bisneto.";
            DateTime AnoAtual = DateTime.Today;

            Console.WriteLine("Nome: " + SoftwareName);
            Console.WriteLine("Versão: " + Version);
            Console.WriteLine("Criado por: " + CopyrightName);

            string StrAnoAtual = AnoAtual.ToString("yyyy");
            int IntAnoAtual = Convert.ToInt32(StrAnoAtual);

            if (IntAnoAtual == 2021)
            {
                Console.WriteLine("Copyright © " + IntAnoAtual + " | " + CopyrightName + " All rights reserved.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Copyright © 2021 - " + IntAnoAtual + " | " + CopyrightName + " All rights reserved.");
                Console.WriteLine();
            }

            try
            {
                Console.WriteLine(">> Digite o primeiro número: ");
                var N1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                try
                {
                    Console.WriteLine("---------- Lista de operações ----------");
                    Console.WriteLine("Potência: **");
                    Console.WriteLine("Raiz Quadrada: R ou r");
                    Console.WriteLine("Multiplicação: *");
                    Console.WriteLine("Divisão: /");
                    Console.WriteLine("Adição: +");
                    Console.WriteLine("Subtração: -");
                    Console.WriteLine("---------- Lista de operações ----------");


                    Console.WriteLine();
                    Console.WriteLine(">> Digite o simbolo da operação de acordo com o exemplo acima: ");
                    string Operacao = Console.ReadLine();

                    if (Operacao == "R" || Operacao == "r")
                    {
                        double Calc = (N1*N1)/N1;
                        double Calculo = Math.Pow(N1, (1 / 2d));

                        Console.WriteLine(">> A Raiz Quadrada de " + N1 + " é " + Calculo);
                    }
                    else
                    {
                        try
                        {
                            Console.WriteLine(">> Insira o segundo número: ");
                            var N2 = Convert.ToDouble(Console.ReadLine());

                            if (Operacao == "+")
                            {
                                double Calculo = N1 + N2;
                                Console.WriteLine(">> Resultado da adição: " + Calculo);
                            }
                            else if (Operacao == "-")
                            {
                                double Calculo = N1 - N2;
                                Console.WriteLine(">> Resultado da Subtração: " + Calculo);
                            }
                            else if (Operacao == "*")
                            {
                                double Calculo = N1 * N2;
                                Console.WriteLine(">> Resultado da Multiplicação: " + Calculo);
                            }
                            else if (Operacao == "/")
                            {
                                double Calculo = N1 / N2;
                                Console.WriteLine(">> Resultado da Divisão: " + Calculo);
                            }
                            else if (Operacao == "**")
                            {
                                double Calculo = Math.Pow(N1, N2);
                                Console.WriteLine(">> Resultado da Potência: " + Calculo);
                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine();
                            Console.WriteLine(">> SEGUNDO CARACTERE INCORRETO:");
                            Console.WriteLine("> O segundo caractere digitado não é um número. Verifique o digito inserido e execute o programa novamente");
                            Console.WriteLine();
                            Console.WriteLine("Codigo do erro: " + ex);
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                    Console.WriteLine(">> OPERADOR INVÁLIDO:");
                    Console.WriteLine("> Operação digitada incorretamente");
                    Console.WriteLine();
                    Console.WriteLine("Codigo do erro: " + ex);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine(">> PRIMEIRO CARACTERE INCORRETO:");
                Console.WriteLine("> O primeiro caractere digitado não é um número. Verifique o digito inserido e execute o programa novamente");
                Console.WriteLine();
                Console.WriteLine("Codigo do erro: " + ex);
            }
        }
    }
}
