using System;

namespace Signo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var CopyrightClass = new Copyright();
            CopyrightClass.Print();
            int DataAtual = CopyrightClass.DataAtual;

            // Agua
            var Can = new Signos.Agua.Cancer();
            var Esc = new Signos.Agua.Escorpiao();
            var Pei = new Signos.Agua.Peixes();

            // Ar
            var Aqu = new Signos.Ar.Aquario();
            var Gem = new Signos.Ar.Gemeos();
            var Lib = new Signos.Ar.Libra();

            // Fogo
            var Ari = new Signos.Fogo.Aries();
            var Lea = new Signos.Fogo.Leao();
            var Sag = new Signos.Fogo.Sagitario();

            // Terra
            var Cap = new Signos.Terra.Capricornio();
            var Tou = new Signos.Terra.Touro();
            var Vir = new Signos.Terra.Virgem();

            string MesNome = "";
            string GrupoSigno = "";
            string UserSigno;

            Console.WriteLine(">> Qual o seu nome?");
            string Nome = Console.ReadLine();

            Console.WriteLine("Insira o dia do seu nascimento [DD]: ");
            int Dia = Convert.ToInt32(Console.ReadLine());           

            if(Dia > 31)
            {
                Console.WriteLine(">> Valor inválido");
                Console.WriteLine(">> Reinicie o programa...");
            }
            else
            {
                Console.WriteLine(">> Digite o mês do seu nascimento [MM]:");
                int Mes = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(">> Digite o ano do seu nascimento [AAAA]:");
                int AnoNascimento = Convert.ToInt32(Console.ReadLine());

                // JANEIRO
                if (Mes == 01)
                {
                    MesNome = "Janeiro";
                    if(Dia >= 21)
                    {
                        UserSigno = "Aquario";
                        GrupoSigno = "aquariano";

                        Aqu.Nome = Nome;
                        Aqu.MesNome = MesNome;
                        Aqu.Signo = UserSigno;
                        Aqu.GrupoSigno = GrupoSigno;

                        Aqu.DataAtual = DataAtual;
                        Aqu.AnoNascimento = AnoNascimento;
                        Aqu.Dia = Dia;
                        Aqu.Mes = Mes;
                        Aqu.Ano = AnoNascimento;

                        Aqu.Trigger();
                    }
                    else
                    {
                        UserSigno = "Capricornio";
                        GrupoSigno = "capricorniano";

                        Cap.Nome = Nome;
                        Cap.MesNome = MesNome;
                        Cap.Signo = UserSigno;
                        Cap.GrupoSigno = GrupoSigno;

                        Cap.DataAtual = DataAtual;
                        Cap.AnoNascimento = AnoNascimento;
                        Cap.Dia = Dia;
                        Cap.Mes = Mes;
                        Cap.Ano = AnoNascimento;

                        Cap.Trigger();
                    }
                }

                // FEVEREIRO
                if (Mes == 02)
                {
                    MesNome = "Fevereiro";
                    if (Dia >= 20)
                    {
                        UserSigno = "Peixes";
                        GrupoSigno = "pisciano";

                        Pei.Nome = Nome;
                        Pei.MesNome = MesNome;
                        Pei.Signo = UserSigno;
                        Pei.GrupoSigno = GrupoSigno;

                        Pei.DataAtual = DataAtual;
                        Pei.AnoNascimento = AnoNascimento;
                        Pei.Dia = Dia;
                        Pei.Mes = Mes;
                        Pei.Ano = AnoNascimento;

                        Pei.Trigger();
                    }
                    else
                    {
                        UserSigno = "Aquario";
                        GrupoSigno = "aquariano";

                        Aqu.Nome = Nome;
                        Aqu.MesNome = MesNome;
                        Aqu.Signo = UserSigno;
                        Aqu.GrupoSigno = GrupoSigno;

                        Aqu.DataAtual = DataAtual;
                        Aqu.AnoNascimento = AnoNascimento;
                        Aqu.Dia = Dia;
                        Aqu.Mes = Mes;
                        Aqu.Ano = AnoNascimento;

                        Aqu.Trigger();
                    }
                }

                // MARÇO
                if (Mes == 03)
                {
                    MesNome = "Março";
                    if (Dia >= 21)
                    {
                        UserSigno = "Áries";
                        GrupoSigno = "ariano";

                        Ari.Nome = Nome;
                        Ari.MesNome = MesNome;
                        Ari.Signo = UserSigno;
                        Ari.GrupoSigno = GrupoSigno;

                        Ari.DataAtual = DataAtual;
                        Ari.AnoNascimento = AnoNascimento;
                        Ari.Dia = Dia;
                        Ari.Mes = Mes;
                        Ari.Ano = AnoNascimento;

                        Ari.Trigger();
                    }
                    else
                    {
                        UserSigno = "Peixes";
                        GrupoSigno = "pisciano";

                        Pei.Nome = Nome;
                        Pei.MesNome = MesNome;
                        Pei.Signo = UserSigno;
                        Pei.GrupoSigno = GrupoSigno;

                        Pei.DataAtual = DataAtual;
                        Pei.AnoNascimento = AnoNascimento;
                        Pei.Dia = Dia;
                        Pei.Mes = Mes;
                        Pei.Ano = AnoNascimento;

                        Pei.Trigger();
                    }
                }

                // ABRIL
                if (Mes == 04)
                {
                    MesNome = "Abril";
                    if (Dia >= 21)
                    {
                        UserSigno = "Touro";
                        GrupoSigno = "taurino";

                        Tou.Nome = Nome;
                        Tou.MesNome = MesNome;
                        Tou.Signo = UserSigno;
                        Tou.GrupoSigno = GrupoSigno;

                        Tou.DataAtual = DataAtual;
                        Tou.AnoNascimento = AnoNascimento;
                        Tou.Dia = Dia;
                        Tou.Mes = Mes;
                        Tou.Ano = AnoNascimento;

                        Tou.Trigger();
                    }
                    else
                    {
                        UserSigno = "Áries";
                        GrupoSigno = "ariano";

                        Ari.Nome = Nome;
                        Ari.MesNome = MesNome;
                        Ari.Signo = UserSigno;
                        Ari.GrupoSigno = GrupoSigno;

                        Ari.DataAtual = DataAtual;
                        Ari.AnoNascimento = AnoNascimento;
                        Ari.Dia = Dia;
                        Ari.Mes = Mes;
                        Ari.Ano = AnoNascimento;

                        Ari.Trigger();
                    }
                }

                // MAIO
                if (Mes == 05)
                {
                    MesNome = "Maio";
                    if (Dia >= 21)
                    {
                        UserSigno = "Gêmeos";
                        GrupoSigno = "geminiano";

                        Gem.Nome = Nome;
                        Gem.MesNome = MesNome;
                        Gem.Signo = UserSigno;
                        Gem.GrupoSigno = GrupoSigno;

                        Gem.DataAtual = DataAtual;
                        Gem.AnoNascimento = AnoNascimento;
                        Gem.Dia = Dia;
                        Gem.Mes = Mes;
                        Gem.Ano = AnoNascimento;

                        Gem.Trigger();
                    }
                    else
                    {
                        UserSigno = "Touro";
                        GrupoSigno = "taurino";

                        Tou.Nome = Nome;
                        Tou.MesNome = MesNome;
                        Tou.Signo = UserSigno;
                        Tou.GrupoSigno = GrupoSigno;

                        Tou.DataAtual = DataAtual;
                        Tou.AnoNascimento = AnoNascimento;
                        Tou.Dia = Dia;
                        Tou.Mes = Mes;
                        Tou.Ano = AnoNascimento;

                        Tou.Trigger();
                    }
                }

                // JUNHO
                if (Mes == 06)
                {
                    MesNome = "Junho";
                    if (Dia >= 21)
                    {
                        UserSigno = "Câncer";
                        GrupoSigno = "canceriano";

                        Can.Nome = Nome;
                        Can.MesNome = MesNome;
                        Can.Signo = UserSigno;
                        Can.GrupoSigno = GrupoSigno;

                        Can.DataAtual = DataAtual;
                        Can.AnoNascimento = AnoNascimento;
                        Can.Dia = Dia;
                        Can.Mes = Mes;
                        Can.Ano = AnoNascimento;

                        Can.Trigger();
                    }
                    else
                    {
                        UserSigno = "Gêmeos";
                        GrupoSigno = "geminiano";

                        Gem.Nome = Nome;
                        Gem.MesNome = MesNome;
                        Gem.Signo = UserSigno;
                        Gem.GrupoSigno = GrupoSigno;

                        Gem.DataAtual = DataAtual;
                        Gem.AnoNascimento = AnoNascimento;
                        Gem.Dia = Dia;
                        Gem.Mes = Mes;
                        Gem.Ano = AnoNascimento;

                        Gem.Trigger();
                    }
                }

                // JULHO
                if (Mes == 07)
                {
                    MesNome = "Julho";
                    if (Dia >= 22)
                    {
                        UserSigno = "Leão";
                        GrupoSigno = "leonino";

                        Lea.Nome = Nome;
                        Lea.MesNome = MesNome;
                        Lea.Signo = UserSigno;
                        Lea.GrupoSigno = GrupoSigno;

                        Lea.DataAtual = DataAtual;
                        Lea.AnoNascimento = AnoNascimento;
                        Lea.Dia = Dia;
                        Lea.Mes = Mes;
                        Lea.Ano = AnoNascimento;

                        Lea.Trigger();
                    }
                    else
                    {
                        UserSigno = "Câncer";
                        GrupoSigno = "canceriano";

                        Can.Nome = Nome;
                        Can.MesNome = MesNome;
                        Can.Signo = UserSigno;
                        Can.GrupoSigno = GrupoSigno;

                        Can.DataAtual = DataAtual;
                        Can.AnoNascimento = AnoNascimento;
                        Can.Dia = Dia;
                        Can.Mes = Mes;
                        Can.Ano = AnoNascimento;

                        Can.Trigger();
                    }
                }

                // AGOSTO
                if (Mes == 08)
                {
                    MesNome = "Agosto";
                    if (Dia >= 22)
                    {
                        UserSigno = "Virgem";
                        GrupoSigno = "virginiano";

                        Vir.Nome = Nome;
                        Vir.MesNome = MesNome;
                        Vir.Signo = UserSigno;
                        Vir.GrupoSigno = GrupoSigno;

                        Vir.DataAtual = DataAtual;
                        Vir.AnoNascimento = AnoNascimento;
                        Vir.Dia = Dia;
                        Vir.Mes = Mes;
                        Vir.Ano = AnoNascimento;

                        Vir.Trigger();
                    }
                    else
                    {
                        UserSigno = "Leão";
                        GrupoSigno = "leonino";

                        Lea.Nome = Nome;
                        Lea.MesNome = MesNome;
                        Lea.Signo = UserSigno;
                        Lea.GrupoSigno = GrupoSigno;

                        Lea.DataAtual = DataAtual;
                        Lea.AnoNascimento = AnoNascimento;
                        Lea.Dia = Dia;
                        Lea.Mes = Mes;
                        Lea.Ano = AnoNascimento;

                        Lea.Trigger();
                    }
                }

                // SETEMBRO
                if (Mes == 09)
                {
                    MesNome = "Setembro";
                    if (Dia >= 23)
                    {
                        UserSigno = "Libra";
                        GrupoSigno = "libriano";

                        Lib.Nome = Nome;
                        Lib.MesNome = MesNome;
                        Lib.Signo = UserSigno;
                        Lib.GrupoSigno = GrupoSigno;

                        Lib.DataAtual = DataAtual;
                        Lib.AnoNascimento = AnoNascimento;
                        Lib.Dia = Dia;
                        Lib.Mes = Mes;
                        Lib.Ano = AnoNascimento;

                        Lib.Trigger();
                    }
                    else
                    {
                        UserSigno = "Virgem";
                        GrupoSigno = "virginiano";

                        Vir.Nome = Nome;
                        Vir.MesNome = MesNome;
                        Vir.Signo = UserSigno;
                        Vir.GrupoSigno = GrupoSigno;

                        Vir.DataAtual = DataAtual;
                        Vir.AnoNascimento = AnoNascimento;
                        Vir.Dia = Dia;
                        Vir.Mes = Mes;
                        Vir.Ano = AnoNascimento;

                        Vir.Trigger();
                    }
                }

                // OUTUBRO
                if (Mes == 10)
                {
                    MesNome = "Outubro";
                    if (Dia >= 23)
                    {
                        UserSigno = "Escorpião";
                        GrupoSigno = "escorpiano";

                        Esc.Nome = Nome;
                        Esc.MesNome = MesNome;
                        Esc.Signo = UserSigno;
                        Esc.GrupoSigno = GrupoSigno;

                        Esc.DataAtual = DataAtual;
                        Esc.AnoNascimento = AnoNascimento;
                        Esc.Dia = Dia;
                        Esc.Mes = Mes;
                        Esc.Ano = AnoNascimento;

                        Esc.Trigger();
                    }
                    else
                    {
                        UserSigno = "Libra";
                        GrupoSigno = "libriano";

                        Lib.Nome = Nome;
                        Lib.MesNome = MesNome;
                        Lib.Signo = UserSigno;
                        Lib.GrupoSigno = GrupoSigno;

                        Lib.DataAtual = DataAtual;
                        Lib.AnoNascimento = AnoNascimento;
                        Lib.Dia = Dia;
                        Lib.Mes = Mes;
                        Lib.Ano = AnoNascimento;

                        Lib.Trigger();
                    }
                }

                // NOVEMBRO
                if (Mes == 11)
                {
                    MesNome = "Novembro";
                    if (Dia >= 22)
                    {
                        UserSigno = "Sagitario";
                        GrupoSigno = "sagitariano";

                        Sag.Nome = Nome;
                        Sag.MesNome = MesNome;
                        Sag.Signo = UserSigno;
                        Sag.GrupoSigno = GrupoSigno;

                        Sag.DataAtual = DataAtual;
                        Sag.AnoNascimento = AnoNascimento;
                        Sag.Dia = Dia;
                        Sag.Mes = Mes;
                        Sag.Ano = AnoNascimento;

                        Sag.Trigger();
                    }
                    else
                    {
                        UserSigno = "Escorpião";
                        GrupoSigno = "escorpiano";

                        Esc.Nome = Nome;
                        Esc.MesNome = MesNome;
                        Esc.Signo = UserSigno;
                        Esc.GrupoSigno = GrupoSigno;

                        Esc.DataAtual = DataAtual;
                        Esc.AnoNascimento = AnoNascimento;
                        Esc.Dia = Dia;
                        Esc.Mes = Mes;
                        Esc.Ano = AnoNascimento;

                        Esc.Trigger();
                    }
                }

                // DEZEMBRO
                if (Mes == 12)
                {
                    MesNome = "Dezembro";
                    if (Dia >= 22)
                    {
                        UserSigno = "Capricórnio";
                        GrupoSigno = "capricorniano";

                        Cap.Nome = Nome;
                        Cap.MesNome = MesNome;
                        Cap.Signo = UserSigno;
                        Cap.GrupoSigno = GrupoSigno;

                        Cap.DataAtual = DataAtual;
                        Cap.AnoNascimento = AnoNascimento;
                        Cap.Dia = Dia;
                        Cap.Mes = Mes;
                        Cap.Ano = AnoNascimento;

                        Cap.Trigger();
                    }
                    else
                    {
                        UserSigno = "Sagitario";
                        GrupoSigno = "sagitariano";

                        Sag.Nome = Nome;
                        Sag.MesNome = MesNome;
                        Sag.Signo = UserSigno;
                        Sag.GrupoSigno = GrupoSigno;

                        Sag.DataAtual = DataAtual;
                        Sag.AnoNascimento = AnoNascimento;
                        Sag.Dia = Dia;
                        Sag.Mes = Mes;
                        Sag.Ano = AnoNascimento;

                        Sag.Trigger();

                    }
                }
            }
        }
    }
}
