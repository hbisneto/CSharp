using System;
namespace Matriz
{
    public class Arrays
    {
        int[] IntArray = { 0, 1, 2, 3, 4, 5 };
        int QtdItens = 0;

        public void UniArray()
        {
            QtdItens = 0;

            Console.WriteLine("---------- Itens na matriz ----------");
            foreach (int i in IntArray)
            {
                QtdItens += 1;
                try
                {

                Console.WriteLine(">> " + IntArray[i]);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(">> Mensagem de erro: " + ex);
                }
            }
            Console.WriteLine("---------- Itens na matriz ----------");
            Console.WriteLine();
        }

        public void RunningArrays()
        {
            QtdItens = 0;
            foreach (int i in IntArray)
            {
                try
                {
                    QtdItens += 1;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(">> Mensagem de erro: " + ex);
                }
            }
            Console.WriteLine("---------- Ordem dos elementos ----------");
            Console.WriteLine(">> Primeiro elemento: " + IntArray[0]);
            Console.WriteLine(">> Segundo elemento: " + IntArray[1]);
            Console.WriteLine(">> Terceiro elemento: " + IntArray[2]);
            Console.WriteLine(">> Quarto elemento: " + IntArray[3]);
            Console.WriteLine(">> Quinto elemento: " + IntArray[4]);
            Console.WriteLine(">> Sexto elemento: " + IntArray[5]);
            Console.WriteLine(">> Quantidade de itens na lista: " + QtdItens);
            Console.WriteLine("---------- Ordem dos elementos ----------");
            Console.WriteLine();
        }

        public void UserInteraction()
        {
            int Count = 0;

            Console.WriteLine(">> A matriz terá quantos elementos? [Digite um número]: ");

            int NumeroElementos = Convert.ToInt32(Console.ReadLine());
            int[] NovoArray = new int[NumeroElementos];
            Console.WriteLine();

            for (int i = 0; i < NumeroElementos; i++)
            {
                Console.WriteLine(">> Digite um número");
                int UserNumber = Convert.ToInt32(Console.ReadLine());
                NovoArray[i] = UserNumber;
                Console.WriteLine();

                Console.WriteLine(">> Index da Matriz: " + i);
                Console.WriteLine(">> Número inserido: " + UserNumber);
                Console.WriteLine();
            }
            Console.WriteLine("---------- Números Inseridos na Matriz ----------");
            foreach (var item in NovoArray)
            {
                Count += 1;
                Console.WriteLine(">> " + item);
            }

            Console.WriteLine(">> Número de itens na matriz: " + Count);

            Console.WriteLine("---------- Números Inseridos na Matriz ----------");
            Console.WriteLine();
        }
    }
}
