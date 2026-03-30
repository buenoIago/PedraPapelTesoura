
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            int pedra = 1;
            int papel = 2;
            int tesoura = 3;

            System.Console.WriteLine("------------------------------");
            System.Console.WriteLine("Pedra, Papel Tesoura!");
            System.Console.WriteLine("------------------------------");

            System.Console.WriteLine("Escolha sua jogada: \nDigite 1 para Pedra, 2 para Papel ou 3 para Tesoura");
            int chuteJogador = Convert.ToInt32(Console.ReadLine());

            string JogadaJogador = "";

            switch (chuteJogador)
            {
                case 1:
                    JogadaJogador = "pedra";
                    break;                   
                case 2:
                    JogadaJogador = "Papel";
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
                    jogadaComputador = "Papel";
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
            else if (chuteJogador == pedra && chuteComputador == papel)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Vitória do Computador!");
                Console.ResetColor();
                System.Console.WriteLine("Jogador escolheu: PEDRA e o computador: PAPEL.");
            }
            else if (chuteJogador == papel && chuteComputador == pedra)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine("Vitória do Jogador!");
                Console.ResetColor();
                System.Console.WriteLine("Jogador escolheu: PAPEL e o computador: PEDRA.");
            }
            else if (chuteJogador == papel && chuteComputador == tesoura)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Vitória do Computador!");
                Console.ResetColor();
                System.Console.WriteLine("Jogador escolheu: PAPEL e o computador: TESOURA.");
            }
            else if (chuteJogador == tesoura && chuteComputador == papel)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine("Vitória do Jogador!");
                Console.ResetColor();
                System.Console.WriteLine("Jogador escolheu: TESOURA e o computador: PAPEL.");
            }
            else if (chuteJogador == pedra && chuteComputador == tesoura)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine("Vitória do Jogador!");
                Console.ResetColor(); 
                System.Console.WriteLine("Jogador escolheu: PEDRA e o computador: TESOURA.");
            }
            else if (chuteJogador == tesoura && chuteComputador == pedra)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine($"Vitória do Computador!");
                Console.ResetColor(); 
                Console.WriteLine("Jogador escolheu: TESOURA e o computador: PEDRA.");
            }
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