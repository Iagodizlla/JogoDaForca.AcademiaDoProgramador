namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string[] p = {
        "DIAMANTE",//minecraft
        "FERRO",
        "OURO",
        "REDSTONE",
        "LAPIS-LAZULI",
        "CARVAO",
        "NETHERITE",
        "ESMERALDA",
        "MADEIRA",
        "PEDRA",
        "TIJOLO",
        "AREIA",
        "ARGILA",
        "VIDRO",
        "OBSIDIANA",
        "GLOWSTONE",
        "QUARTZO",
        "CENOURA",
        "BATATA",
        "TRIGO",
        "MELANCIA",
        "ABOBORA",
        "CACAU",
        "FUNGOS-DO-NETHER",
        "BARRIL",
        "SINALIZILADOR",
        "TNT",
        "FLECHA",
        "RELOGIO",
        "PICARETA",
        "ESPADA",
        "MACHADO",
        "PA",
        "ENXADA",
        "ARMADURA",
        "CAPACETE",
        "PEITORAL",
        "CALÇA",
        "BOTAS",
        "ARCO",
        "BESTA",
        "POCAO",
        "IMPOSTOR",//among us
        "TRIPULANTE",
        "VENTILACAO",
        "TASK",
        "SABOTAGEM",
        "REATOR",
        "O2",
        "ELETRICA",
        "ADMIN",
        "MAPA",
        "CARTAO",
        "ALARME",
        "EMERGENCIA",
        "CAMERAS",
        "ENGENHEIRO",
        "CIENTISTA",
        "MEDICO",
        "SKIN"
};
                
                Random random = new Random();
                int ns = random.Next(p.Length);
                string pes = p[ns];

                char[] le = new char[pes.Length];

                for (int i = 0; i < le.Length; i++)
                {
                    le[i] = '_';
                }

                int qe = 0;
                bool perdeu = false, ganhou = false, dica = false;
                do
                {
                    string lfd = qe >= 1 ? " | " : " ";
                    string cd = qe >= 1 ? " o " : " ";
                    string tsd = qe >= 2 ? "X" : " ";
                    string tid = qe >= 2 ? " X " : " ";
                    string bqd = qe >= 3 ? "/" : " ";
                    string bdd = qe >= 4 ? @"\" : " ";
                    string pqd = qe >= 5 ? "/" : " ";
                    string pdd = qe >= 6 ? " \\" : " ";

                    Console.Clear();
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Jogo da Forca");
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine(" ___________        ");
                    Console.WriteLine(" |/       {0}       ", lfd);
                    Console.WriteLine(" |        {0}       ", cd);
                    Console.WriteLine(" |        {0}{1}{2} ", bqd, tsd, bdd);
                    Console.WriteLine(" |        {0}       ", tid);
                    Console.WriteLine(" |        {0}{1}    ", pqd, pdd);
                    Console.WriteLine(" |                  ");
                    Console.WriteLine(" |                  ");
                    Console.WriteLine("_|____              ");
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Erros do jogador: " + qe);
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Palavra escolhida: " + String.Join("", le));
                    Console.WriteLine("----------------------------------------------");

                    if (qe == 3 && dica == false)
                    {
                        dica = true;
                        if (ns < 42)
                        {
                            Console.WriteLine("Dica: Algo do jogo 'Minecraft'");
                            Console.WriteLine("----------------------------------------------");
                        }
                        else if (ns >= 42 && ns < 59)
                        {
                            Console.WriteLine("Dica: Algo do jogo 'Among Us'");
                            Console.WriteLine("----------------------------------------------");
                        }
                    }
                    Console.Write("Digite uma letra: ");
                    char chute = Console.ReadLine()!.ToUpper()[0];

                    bool lfe = false;

                    for (int i = 0; i < pes.Length; i++)
                    {
                        char la = pes[i];

                        if (chute == la)
                        {
                            le[i] = la;
                            lfe = true;
                        }
                    }

                    if (lfe == false)
                    {
                        qe++;
                    }

                    string pe = String.Join("", le);

                    ganhou = pe == pes;
                    perdeu = qe > 6;

                    if (ganhou)
                    {
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine($"Você acertou a palavra secreta {pes}, parabéns!");
                        Console.WriteLine("----------------------------------------------");
                    }
                    else if (perdeu)
                    {
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine("Que azar! Tente novamente!\nA palavar era: "+pes);
                        Console.WriteLine("----------------------------------------------");
                    }
                } while (perdeu == false && ganhou == false);

                Console.Write("Quer jogar novamente? (S/N): ");
                string jn = Console.ReadLine().ToUpper();

                if (jn != "S")
                {
                    break;
                }

            } while (true);
        }
    }
}
