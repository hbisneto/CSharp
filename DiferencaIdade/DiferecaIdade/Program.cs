using System;

namespace DiferecaIdade
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var CopyrightClass = new Copyright();
            CopyrightClass.Print();
           
            Console.WriteLine(">> Insira seu nome:");
            string Nome = Console.ReadLine();
            Console.WriteLine(">> Insira o nome da segunda pessoa:");
            string NomeSegundaPessoa = Console.ReadLine();
            Console.WriteLine(">> Em que ano você nasceu:");
            int Nascimento = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(">> Em que ano a segunda pessoa nasceu:");
            int NascimentoSegundaPessoa = Convert.ToInt32(Console.ReadLine());

            int Calc = (Nascimento - NascimentoSegundaPessoa);
            int ConterOperation = Calc * (-1);
            
            if (Nascimento < NascimentoSegundaPessoa)
            {
                if (ConterOperation == 1)
                {
                    Console.WriteLine(">> " + Nome + " é " + ConterOperation + " ano mais velho(a) que " + NomeSegundaPessoa);
                }
                else
                {
                    Console.WriteLine(">> " + Nome + " é " + ConterOperation + " anos mais velho(a) que " + NomeSegundaPessoa);
                }
            }
            else if (Nascimento > NascimentoSegundaPessoa)
            {
                if(ConterOperation == 1)
                {
                    Console.WriteLine(">> " + NomeSegundaPessoa + " é " + Calc + " ano mais velho(a) que " + Nome);
                }
                else
                {
                    Console.WriteLine(">> " + NomeSegundaPessoa + " é " + Calc + " anos mais velho(a) que " + Nome);
                }
            }
            else
            {
                Console.WriteLine(">> Vocês têm a mesma idade!");
            }
        }
    }
}
