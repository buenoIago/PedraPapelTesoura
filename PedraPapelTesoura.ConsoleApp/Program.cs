
using System.Collections.Concurrent;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        const int pedra = 1;
        const int papel = 2;
        const int tesoura = 3;
        int contador = 0;
        while (true)
        {
            Console.Clear();
            contador++;

            System.Console.WriteLine("------------------------------");
            System.Console.WriteLine("Pedra, Papel Tesoura!");
            System.Console.WriteLine("------------------------------");
            System.Console.WriteLine($"Iniciando a rodada {contador}");
            System.Console.WriteLine("------------------------------\n");

            System.Console.WriteLine("Escolha sua jogada: (1, 2 ou 3) \n1: Pedra, 2: Papel 3: Tesoura:");
            int chuteJogador = Convert.ToInt32(Console.ReadLine());

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
                    break;
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
                default:
                    Console.WriteLine("Jogada inválida");
                    break;
            }

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
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Vitória do Computador!");
                Console.ResetColor();
                System.Console.WriteLine($"Jogador escolheu: {JogadaJogador} e o computador: {jogadaComputador}.");
            }

            System.Console.WriteLine("\n------------------------------");
            System.Console.WriteLine("Pressione ENTER para continuar");
            System.Console.WriteLine("------------------------------");
            Console.ReadLine();

            if (!JogadorDesejaContinuar())
            {
                System.Console.WriteLine("Encerrando o programa...");
                Thread.Sleep(1000);
                break;
            }
        }
        static bool JogadorDesejaContinuar()
        {

        Console.WriteLine("Deseja continuar? (s/N)");
        string? opcaoContinuar = Console.ReadLine()?.ToUpper();

        if (opcaoContinuar != "S")
            return false;
        
        else
            return true;            
       }
    }
}