using System.Security.Cryptography;

static class Jogo
{
    private const int pedra = 1;
    private const int papel = 2;
    private const int tesoura = 3;
    public static int chuteJogador;
    private static int scoreJogador = 0;
    private static int scoreComputador = 0;
    
    public static void ConfigurarJogo(int chuteJogador1)
    {
        chuteJogador = chuteJogador1;
    }  

    public static void JogoEmAndamento()
    {
            string JogadaJogador = "";

            switch (chuteJogador)
            {
                case 1:
                    JogadaJogador = "pedra";
                    break;                   
                case 2:
                    JogadaJogador = "papel";
                    break;
                case 3:
                    JogadaJogador = "Tesoura";
                    break;
                default:
                    Console.WriteLine("Jogada inválida");
                    return;
            }

            int chuteComputador = RandomNumberGenerator.GetInt32(1,4);
            string jogadaComputador = "";

            switch (chuteComputador)
            {
                case 1:
                    jogadaComputador = "pedra";
                    break;                   
                case 2:
                    jogadaComputador = "papel";
                    break;
                case 3:
                    jogadaComputador = "Tesoura";
                    break;
            }
 
            System.Console.WriteLine("------------------------------");

            if (chuteJogador == chuteComputador)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                System.Console.WriteLine("Empate!");
                Console.ResetColor();
                System.Console.WriteLine($"Jogador escolheu: {JogadaJogador} e o computador: {jogadaComputador}.");
            }
            else if (chuteJogador == pedra && chuteComputador == tesoura
            || chuteJogador == tesoura && chuteComputador == papel
            || chuteJogador == papel && chuteComputador == pedra)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine("Vitória do Jogador!");
                Console.ResetColor();
                System.Console.WriteLine($"Jogador escolheu: {JogadaJogador} e o computador: {jogadaComputador}.");
                scoreJogador++;
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Vitória do Computador!");
                Console.ResetColor();
                System.Console.WriteLine($"Jogador escolheu: {JogadaJogador} e o computador: {jogadaComputador}.");
                scoreComputador++;
            }

            System.Console.WriteLine($"\nVitórias do jogador: {scoreJogador}");
            System.Console.WriteLine($"Vitórias do Computador: {scoreComputador}");

            System.Console.WriteLine("------------------------------");
            System.Console.WriteLine("Pressione ENTER para continuar");
            System.Console.WriteLine("------------------------------");
            Console.ReadLine();
    }
}