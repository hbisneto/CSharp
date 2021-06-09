using System;

namespace Calculadora
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool Run = true;

            var CopyrightClass = new Copyright();
            CopyrightClass.Print();

            var CalculatorOS = new CalculatorOS();

            // 1º Instância do programa
            CalculatorOS.TheSystem();

            // 2º Looping do programa
            while(Run == true)
            {
                Console.WriteLine();
                Console.WriteLine(">> Gostaria de executar a Calculadora novamente? [S ou N]:");
                string Confirmation = Console.ReadLine();
                string Confirm = Confirmation.ToUpper();
                Console.WriteLine();

                if(Confirm == "S")
                {
                    CalculatorOS.TheSystem();
                }
                else
                {
                    Run = false;
                }
            }
        }
    }
}
