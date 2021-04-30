using System;

namespace Matriz
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Copyright
            var CopyrightClass = new Copyright();
            CopyrightClass.Print();

            // Arrays
            var MyArrays = new Arrays();

            Console.WriteLine(">> 1. Mostrar Itens na Matriz");
            Console.WriteLine(">> 2. Mostrar Ordem dos Elementos");
            Console.WriteLine(">> 3. Testar Programa");
            Console.WriteLine();
            Console.WriteLine(">> Escolha um valor do menu");
            int Escolha = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (Escolha == 1)
            {
                MyArrays.UniArray();
            }
            else if (Escolha == 2)
            {
                MyArrays.RunningArrays();
            }
            else if(Escolha == 3)
            {
                MyArrays.UserInteraction();
            }
            else
            {
                Console.WriteLine(">> Opção inválida");
            }

            Console.WriteLine(">> Fim do programa");
        }
    }
}
