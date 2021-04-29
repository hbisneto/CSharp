using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string SoftwareName = "HelloWorld";
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
                Console.WriteLine("Copyright © 2020 - " + IntAnoAtual + " | " + CopyrightName + " All rights reserved.");
                Console.WriteLine();
            }

            Console.WriteLine(">> Hello World!");
        }
    }
}
