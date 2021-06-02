using System;

namespace Calculadora
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var CopyrightClass = new Copyright();
            CopyrightClass.Print();

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
