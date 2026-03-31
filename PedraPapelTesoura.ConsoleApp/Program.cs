using System.Collections.Concurrent;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        int contador = 0;
        while (true)
        {
            Console.Clear();
            contador++;

            System.Console.WriteLine("------------------------------");
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.Write("Pedra ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            System.Console.Write("Papel");
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine(" Tesoura!");
            Console.ResetColor();
            System.Console.WriteLine("------------------------------");
            System.Console.WriteLine($"Iniciando a rodada {contador}");
            System.Console.WriteLine("------------------------------");
            
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            System.Console.WriteLine("1: Pedra 2: Papel 3: Tesoura\nEscolha sua jogada: (1, 2 ou 3)");
            Jogo.chuteJogador = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();

            Jogo.ConfigurarJogo(Jogo.chuteJogador);

            Jogo.JogoEmAndamento();
            
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