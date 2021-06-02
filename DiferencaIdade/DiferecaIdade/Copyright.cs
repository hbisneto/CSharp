using System;
namespace DiferecaIdade
{
    public class Copyright
    {
        public void Print()
        {
            string SoftwareName = "DiferencaIdade";
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

            Console.WriteLine("[" + SoftwareName + "] - Em Execução...");
            Console.WriteLine();
        }
    }
}
