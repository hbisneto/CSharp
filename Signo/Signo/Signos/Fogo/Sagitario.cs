using System;
namespace Signo.Signos.Fogo
{
    public class Sagitario
    {
        public string Nome;
        public string MesNome;
        public string Signo;
        public string GrupoSigno;

        public int DataAtual;
        public int AnoNascimento;
        public int Dia;
        public int Mes;
        public int Ano;


        public void Trigger()
        {
            Console.WriteLine();
            Console.WriteLine(">> BEM-VINDO SAGITARIANO!");
            Console.WriteLine();
            Console.WriteLine($">> Nome: {Nome}");
            Console.WriteLine($">> Data de Nascimento: {Dia}/{Mes}/{AnoNascimento}");
            Console.WriteLine($">> Idade: {DataAtual - AnoNascimento}");
            Console.WriteLine($">> Signo: {Signo}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($">> {Nome} nascido no dia {Dia} de {MesNome} de {AnoNascimento} é {GrupoSigno}");
        }
    }
}
